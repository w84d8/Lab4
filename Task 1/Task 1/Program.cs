class Program
{
    static void Main()
    {
        Ecosystem ecosystem = new Ecosystem();

        ecosystem.AddOrganism(new Animal { Energy = 50, Age = 3, Size = 2.0, CanReproduce = true, CanHunt = true });
        ecosystem.AddOrganism(new Plant { Energy = 20, Age = 1, Size = 0.5, CanReproduce = true });
        ecosystem.AddOrganism(new Microorganism { Energy = 10, Age = 2, Size = 0.1, CanReproduce = true });

        ecosystem.SimulateEcosystem();
    }
}