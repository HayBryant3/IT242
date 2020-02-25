using System;

namespace Urban_Planner
{







    class Program
    {
        static void Main(string[] args)
        {
            //this is where you make objects based on the class blueprint
            Building MCTC = new Building("1 Mountwest Way", "Hailee Bryant")
            {
                Width = 100,
                Depth = 200,
                NumberOfStories = 4
            };

            Building CapitalBuilding = new Building("412 8th Street", "Hailee Bryant")
            {
                Width = 1000,
                Depth = 250,
                NumberOfStories = 6
            };

            Building MyHouse = new Building("1 Holler Way", "Hailee Bryant")
            {
                Width = 10,
                Depth = 50,
                NumberOfStories = 1
            };

            MCTC.Construct();
           CapitalBuilding.Construct();
            MyHouse.Construct();
            MCTC.Purchase("Hailee Bryant");
            MCTC.Purchase("Hailee Bryant");
            MCTC.Purchase("Hailee Bryant");

            MCTC.DisplayBuildingInfo();
            CapitalBuilding.DisplayBuildingInfo();
            MyHouse.DisplayBuildingInfo();

            Console.WriteLine("this is how to use the debugger");
        }
    }
}
