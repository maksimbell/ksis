using System.Net.NetworkInformation;

static void ScanInterfaces()
{
    IPGlobalProperties deviceProps = IPGlobalProperties.GetIPGlobalProperties();
    NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
    Console.WriteLine("Device host name - {0}", deviceProps.HostName);
    Console.WriteLine("Interfaces count - {0}\n", adapters.Length);


    foreach (NetworkInterface adapter in adapters)
    {
        /*Console.WriteLine(adapter.Name);*/
        Console.WriteLine("Interface name: {0}", adapter.Description);
        Console.WriteLine("Interface type: {0}", adapter.NetworkInterfaceType);
        Console.WriteLine("Mac-address: {0}\n", adapter.GetPhysicalAddress());
    }
}

ScanInterfaces();