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


class Program
{
    [DllImport("iphlpapi.dll", ExactSpelling = true)]
    public static extern int SendARP(uint destinationIP, uint sourceIP,
           byte[] macAddress, ref uint macAddressLength);
    static void Main()
    {
        Console.WriteLine("ss");
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
            ScanNetwork();
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
}

