class Plant : LivingOrganism, IReproducible
{
    public bool CanReproduce { get; set; }

    public void Reproduce()
    {
        Console.WriteLine("Plant is reproducing.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type: Plant");
    }
}