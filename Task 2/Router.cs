internal class Router : Computer, IConnectable
{
    public string RouterType { get; set; }

    public void Connect()
    {
        Console.WriteLine($"Router {IPAddress} connected to the network.");
    }

    public void Disconnect()
    {
        Console.WriteLine($"Router {IPAddress} disconnected from the network.");
    }
}