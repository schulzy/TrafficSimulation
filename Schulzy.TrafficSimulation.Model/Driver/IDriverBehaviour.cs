using Schulzy.TrafficSimulation.Model.Enums;

namespace Schulzy.TrafficSimulation.Model.Driver
{
    internal interface IDriverBehaviour
    {
        Speed Speed { get; }
        Courage Courage { get; }
        VisionDistance Vision { get; }
    }
}