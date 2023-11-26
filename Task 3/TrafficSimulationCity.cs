class TrafficSimulationCity
{
    public static void SimulateCityTraffic(List<Road> roads, List<Vehicle> vehicles)
    {
        Console.WriteLine("Simulating city traffic:");

        foreach (var road in roads)
        {
            TrafficSimulation.SimulateTraffic(vehicles, road);
        }

        // Ваш код для оптимізації трафіку шляхом зміни руху транспортних засобів, регулювання світлофорів тощо.
    }
}