using System;
using System.Net;
using System.Net.Sockets;

namespace Common.Helpers
{
    public static class NetworkHelper
    {
        private const string MSG_NO_ADAPTERS_FOUND = "No network adapters with an IPv4 address in the system!";

        public static IPAddress GetLocalIpV4()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception(MSG_NO_ADAPTERS_FOUND);
        }
    }
}
