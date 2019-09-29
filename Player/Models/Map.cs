using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Map
    {
        public int XSize { get; set; }
        public int YSize { get; set; }
        public Location[,] WorldMap { get; set; }

        public Map(int xSize, int ySize, Location[,] worldMap)
        {
            XSize = xSize;
            YSize = ySize;
            WorldMap = worldMap;
        }
    }
}
