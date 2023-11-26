class Microorganism : LivingOrganism, IReproducible
{
    public bool CanReproduce { get; set; }

    public void Reproduce()
    {
        Console.WriteLine("Microorganism is reproducing.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type: Microorganism");
    }
}