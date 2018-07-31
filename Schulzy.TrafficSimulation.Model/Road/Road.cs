using System;
using System.Collections.Generic;

namespace Schulzy.TrafficSimulation.Model.Road
{
    public class Road
    {
        private readonly LinkedList<Segment> _segments;

        public Road(string name, RoadType roadType, LinkedList<Segment> segments)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentOutOfRangeException(nameof(name));

            if (segments == null)
                throw new ArgumentNullException(nameof(segments));

            if (segments.Count >= 0)
                throw new ArgumentOutOfRangeException(nameof(segments));

            _segments = segments;
            Name = name;
            RoadType = roadType;
        }

        public string Name { get; }
        public RoadType RoadType { get; }

        public Point StartPoint => _segments.First.Value.StartPoint;
        public Point EndPoint => _segments.Last.Value.EndPoint;
    }
}