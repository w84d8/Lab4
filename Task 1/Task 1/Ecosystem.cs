class Ecosystem
{
    private List<LivingOrganism> organisms;

    public Ecosystem()
    {
        organisms = new List<LivingOrganism>();
    }

    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    public void SimulateEcosystem()
    {
        foreach (var organism in organisms)
        {
            organism.Grow();
            organism.DisplayInfo();

            if (organism is IReproducible reproducibleOrganism)
            {
                if (reproducibleOrganism.CanReproduce)
                {
                    reproducibleOrganism.Reproduce();
                }
            }

            if (organism is IPredator predatorOrganism)
            {
                if (predatorOrganism.CanHunt)
                {
                    predatorOrganism.Hunt();
                }
            }
        }
    }
}