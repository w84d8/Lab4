class Computer
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string? OperatingSystem { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"IP Address: {IPAddress}, Power: {Power}, OS: {OperatingSystem}");
    }

    internal void Connect()
    {
        throw new NotImplementedException();
    }

    internal void Disconnect()
    {
        throw new NotImplementedException();
    }
}