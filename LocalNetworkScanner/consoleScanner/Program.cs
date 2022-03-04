using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace consoleScanner
{

    readonly struct IPRangeResult
    {
        public uint Local { get; }
        public uint First { get; }
        public uint Last { get; }

        public IPRangeResult(uint local, uint first, uint last)
        {
            Local = local;
            First = first;
            Last = last;
        }
    }

    static class Program
    {
        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(uint destinationIP, uint sourceIP,
               byte[] macAddress, ref uint macAddressLength);
        static void Main()
        {
            Console.WriteLine("!");
            ScanLocalNetwork();
        }

        static NetworkInterface[] ScanInterfaces()
        {
            IPGlobalProperties deviceProps = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine("Device host name - {0}", deviceProps.HostName);
            Console.WriteLine("Interfaces count - {0}\n", adapters.Length);

            return adapters;

        }

        static bool CheckWorkingInterface(NetworkInterface netInt)
        {
            return (netInt.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                            netInt.OperationalStatus == OperationalStatus.Up);
        }


        static void ScanLocalNetwork()
        {
            NetworkInterface[] adapters = ScanInterfaces();

            foreach (NetworkInterface net in adapters)
            {
                if (CheckWorkingInterface(net))
                {
                    Console.WriteLine($"Interface - {net.Description}");
                    ScanNetwork(net);
                    Console.WriteLine("");
                }
            }
        }

        static void ScanNetwork(NetworkInterface netInterface)
        {
            IPRangeResult ips = GetIPRange(netInterface);

            List<uint> allIps = new List<uint>();
            for (uint ip = ips.First; ip < ips.Last; IncrementIP(ref ip))
            {
                allIps.Add(ip);
            }

            Console.WriteLine("_");

            Parallel.ForEach(allIps, ip =>
            {
                byte[] macAddress = new byte[6];
                uint macAddressLength = 6;
                int arpResult = SendARP(ip, ips.Local, macAddress, ref macAddressLength);

                IPAddress add = new IPAddress(ip);
                if (arpResult == 0)
                {
                    Console.WriteLine($"{add} : {GetMacString(macAddress)}");
                }
            });
        }

        private static uint ToUInt(this byte[] bytes)
        {
            if (bytes.Length != 4)
            {
                throw new ArgumentException("Length of array is not 4");
            }

            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }


            uint result = (uint)((bytes[0] << 24) | (bytes[1] << 16) | (bytes[2] << 8) | bytes[3]);
            return result;
        }

        private static IPRangeResult GetIPRange(NetworkInterface netInterface)
        {
            foreach (UnicastIPAddressInformation ip in netInterface.GetIPProperties().UnicastAddresses)
            {
                if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                {
                    uint localIp = (ip.Address.GetAddressBytes()).ToUInt();
                    uint subnet = (ip.IPv4Mask.GetAddressBytes()).ToUInt();

                    uint first = localIp & subnet;
                    uint last = first | (0xffffffff & ~subnet);

                    if (BitConverter.IsLittleEndian)
                    {
                        first += 1 << 24;
                    }
                    else
                    {
                        first++;
                        last--;
                    }

                    return new IPRangeResult(localIp, first, last);
                }
            }

            throw new ArgumentException("Interface not scannable");
        }

        static string GetMacString(byte[] address)
        {
            StringBuilder macBuilder = new StringBuilder();
            for (int i = 0; i < address.Length - 1; i++)
            {
                macBuilder.AppendFormat("{0:X2}-", address[i]);
            }

            macBuilder.AppendFormat("{0:X2}", address[^1]);

            return macBuilder.ToString();
        }

        private static void IncrementIP(ref uint address)
        {
            if (BitConverter.IsLittleEndian)
            {
                address += 1 << 24;
            }
            else
            {
                address++;
            }
        }
    }

}

