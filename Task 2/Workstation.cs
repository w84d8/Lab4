internal class Workstation : Computer, IConnectable
{
    public string WorkstationType { get; set; }

    public void Connect()
    {
        Console.WriteLine($"Workstation {IPAddress} connected to the network.");
    }

    public void Disconnect()
    {
        Console.WriteLine($"Workstation {IPAddress} disconnected from the network.");
    }
}