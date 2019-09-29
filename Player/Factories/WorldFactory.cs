using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            for (int i = 0; i<=19; i++)
            {
                for (int j = 0; j<=19; j++)
                {
                    newWorld.AddLocation(i, j, "Grasslands", "/WPFUI;component/Images/Locations/25Grassland.png");
                }
            }
            //Farmer's Field
            newWorld.LocationAt(4, 3).ImageName = "/WPFUI;component/Images/Locations/FarmFields.png";
            newWorld.LocationAt(4, 3).Name = "Farmer's Field";
            newWorld.LocationAt(4, 3).AddMonster(2, 95);
            newWorld.LocationAt(4, 3).AddMonster(5, 5);

            //Farmer's House
            newWorld.LocationAt(5, 3).ImageName = "/WPFUI;component/Images/Locations/Farmhouse.png";
            newWorld.LocationAt(5, 3).Name = "Farmer's House";
            newWorld.LocationAt(5, 3).AddQuest(2);

            //Home
            newWorld.LocationAt(5, 5).ImageName = "/WPFUI;component/Images/Locations/Home.png";
            newWorld.LocationAt(5, 5).Name = "Home";

            //Trading Shop
            newWorld.LocationAt(4, 6).ImageName = "/WPFUI;component/Images/Locations/Trader.png";
            newWorld.LocationAt(4, 6).Name = "Trader's Shop";

            //Town Square
            newWorld.LocationAt(5, 6).ImageName = "/WPFUI;component/Images/Locations/TownSquare.png";
            newWorld.LocationAt(5, 6).Name = "Town Square";

            //Town Gate
            newWorld.LocationAt(6, 6).ImageName = "/WPFUI;component/Images/Locations/TownGate.png";
            newWorld.LocationAt(6, 6).Name = "Town Gate";

            //Spider Forest
            newWorld.LocationAt(8, 6).ImageName = "/WPFUI;component/Images/Locations/SpiderForest.png";
            newWorld.LocationAt(8, 6).Name = "Spider Forest";
            newWorld.LocationAt(8, 6).AddMonster(3, 90);
            newWorld.LocationAt(8, 6).AddMonster(6, 10);

            //Herbalist's Hut
            newWorld.LocationAt(5, 7).ImageName = "/WPFUI;component/Images/Locations/HerbalistsHut.png";
            newWorld.LocationAt(5, 7).Name = "Herbalist's Hut";
            newWorld.LocationAt(5, 7).AddQuest(1);

            //Herbalist's Garden
            newWorld.LocationAt(5, 8).ImageName = "/WPFUI;component/Images/Locations/HerbalistsGarden.png";
            newWorld.LocationAt(5, 8).Name = "Herbalist's Garden";
            newWorld.LocationAt(5, 8).AddMonster(1, 95);
            newWorld.LocationAt(5, 8).AddMonster(4, 5);

            return newWorld;
        }
    }
}