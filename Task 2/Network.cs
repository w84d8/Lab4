class Network
{
    private List<IConnectable> devices;

    public Network()
    {
        devices = new List<IConnectable>();
    }

    public IEnumerable<object> Devices { get; internal set; }

    public void AddDevice(IConnectable device)
    {
        devices.Add(device);
    }

    public void TransmitData()
    {
        foreach (var device in devices)
        {
            Console.WriteLine($"Transmitting data to {device.GetType().Name} {((Computer)device).IPAddress}");
        }
    }
}