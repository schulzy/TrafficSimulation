using System;
using System.Collections.Generic;

namespace Test.Model
{
    public class Road
    {
        private readonly LinkedList<Segment> _segments;
        public string Name { get; }
        public RoadType RoadType { get; }

        public Point StartPoint => _segments.First.Value.StartPoint;
        public Point EndPoint => _segments.Last.Value.EndPoint;

        public Road(string name, RoadType roadType, LinkedList<Segment> segments)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentOutOfRangeException(nameof(name));

            if(segments==null)
                throw new ArgumentNullException(nameof(segments));

            _segments = segments;
            Name = name;
            RoadType = roadType;
        }
    }
}
