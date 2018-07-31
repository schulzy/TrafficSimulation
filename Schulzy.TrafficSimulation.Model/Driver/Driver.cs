using System;
using Schulzy.TrafficSimulation.Model.Enums;

namespace Schulzy.TrafficSimulation.Model.Driver
{
    internal class Driver : IDriver
    {
        private readonly IDriverBehaviour _behaviour;

        public Driver(string name, IDriverBehaviour behaviour)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentOutOfRangeException();

            if(behaviour == null)
                throw new ArgumentNullException();

            _behaviour = behaviour;
            Name = name;
        }

        public string Name { get; }

        public void Drive()
        {
            if(_behaviour.Courage ==  Courage.Coward)
                throw new NotImplementedException(); 

            throw new NotImplementedException();
        }
    }
}