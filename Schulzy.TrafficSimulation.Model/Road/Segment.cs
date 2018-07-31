namespace Schulzy.TrafficSimulation.Model.Road
{
    public class Segment
    {
        public Segment(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public Point StartPoint { get; }
        public Point EndPoint { get; }
    }
}