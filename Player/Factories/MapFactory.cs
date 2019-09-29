/*using System;
using Engine.Models;

namespace Engine.Factories
{
    public static class MapFactory
    {
        static Location[,] InitialWorld = new Location[20, 20];

        public static Map GetMap()
        {
            Map WorldMap = new Map(
                20, 20,
                );
             return WorldMap;
        }

        private static Location[,] PopulateMap(int mapID)
        {
            switch (mapID)//holds the image name to be displayed in the UI.
            {
                case 1:
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            InitialWorld[i, j] = "25GrassLand.png";
                        }
                    }
                    return InitialWorld;

                default:
                    throw new ArgumentException(string.Format("The map ID# '{0}' does not exist", mapID));
            }
        }
    }
}*/
