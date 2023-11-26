class LivingOrganism
{
    public double Energy { get; set; }
    public int Age { get; set; }
    public double Size { get; set; }

    public void Grow()
    {
        Size += 0.1;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Energy: {Energy}, Age: {Age}, Size: {Size}");
    }
}