namespace Schulzy.TrafficSimulation.Model.Driver
{
    internal interface IDriver
    {
        string Name { get; }

        void Drive();
    }
}