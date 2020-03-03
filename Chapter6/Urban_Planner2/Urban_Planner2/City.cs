using System;
using System.Collections.Generic;
using System.Text;

namespace Urban_Planner2
{
    class City

    //a constructor for making Cities
    {
        public City (string cityName)
        {
            NameOfCity = cityName;
        }

        //name of the city
        public string NameOfCity { get; }
        //mayor of city
        public string MayorName { get; set; }
        //year the city was established
        public DateTime YearEstablished { get; set; }
        //a collection of all of the buildings in the city
        public List<Building> BuildingList = new List<Building>()
        {

        };
        //A method to add a building to the city.
        public void AddBuilding(Building newBuilding)
        {
            BuildingList.Add(newBuilding);
        }


    }


}

