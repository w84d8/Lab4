class Animal : LivingOrganism, IReproducible, IPredator
{
    public bool CanReproduce { get; set; }
    public bool CanHunt { get; set; }

    public void Reproduce()
    {
        Console.WriteLine("Animal is reproducing.");
    }

    public void Hunt()
    {
        Console.WriteLine("Animal is hunting.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type: Animal");
    }
}