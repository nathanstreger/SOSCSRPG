using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(Location location)
        {
            _locations.Add(location);
        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location loc in _locations)
            {
                if (loc.XCoordinate==xCoordinate && loc.YCoordinate==yCoordinate)
                {
                    return loc;
                }
            }
            return null;
        }

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string imageName)
        {
            Location loc = new Location(xCoordinate, yCoordinate, name, imageName);

            _locations.Add(loc);
        }
    }
}
