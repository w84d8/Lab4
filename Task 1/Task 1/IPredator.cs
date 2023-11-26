interface IPredator
{
    bool CanHunt { get; set; }
    void Hunt();
}