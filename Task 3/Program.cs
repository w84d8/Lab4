class Program
{
    static void Main()
    {
        Road mainRoad = new Road(10, 2, 2);
        Road sideRoad = new Road(5, 1, 1);

        List<Road> roads = new List<Road> { mainRoad, sideRoad };

        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle("Car", 60, 1.5),
            new Vehicle("Bus", 40, 3.5),
            new Vehicle("Truck", 30, 5.0)
        };

        TrafficSimulation.SimulateTraffic(vehicles, mainRoad);
        TrafficSimulation.SimulateTraffic(vehicles, sideRoad);

        TrafficSimulationCity.SimulateCityTraffic(roads, vehicles);
    }
}