namespace Test.Model
{
    public class Segment
    {
        public Point StartPoint { get; }
        public Point EndPoint { get; }

        public Segment(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
    }
}