class Server : Computer, IConnectable
{
    public string ServerType { get; set; }

    public void Connect()
    {
        Console.WriteLine($"Server {IPAddress} connected to the network.");
    }

    public void Disconnect()
    {
        Console.WriteLine($"Server {IPAddress} disconnected from the network.");
    }
}