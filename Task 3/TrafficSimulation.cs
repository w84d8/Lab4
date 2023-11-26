class TrafficSimulation
{
    public static void SimulateTraffic(List<Vehicle> vehicles, Road road)
    {
        Console.WriteLine($"Simulating traffic on road. Length: {road.Length}, Width: {road.Width}, Lanes: {road.NumberOfLanes}");

        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }

    }
}