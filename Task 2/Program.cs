internal class Program
{
    private static void Main(string[] args)
    {
        Server server = new Server { IPAddress = "192.168.1.1", Power = 1000, OperatingSystem = "Windows Server", ServerType = "File Server" };
        Workstation workstation = new Workstation { IPAddress = "192.168.1.2", Power = 500, OperatingSystem = "Windows 10", WorkstationType = "Developer Workstation" };
        Router router = new Router { IPAddress = "192.168.1.3", Power = 200, OperatingSystem = "RouterOS", RouterType = "Wireless Router" };

        Network network = new Network();

        network.AddDevice(server);
        network.AddDevice(workstation);
        network.AddDevice(router);

        foreach (var device in network.Devices)
        {
            if (device is Computer computerDevice)
            {
                computerDevice.Connect();
            }
        }

        network.TransmitData();

        foreach (var device in network.Devices)
        {
            if (device is Computer computerDevice)
            {
                computerDevice.Disconnect();
            }
        }
    }
}