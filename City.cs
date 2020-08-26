using System;
using System.Collections.Generic;
namespace Planner
{
    public class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public DateTime EstablishedYear { get; set; }
        public List<Building> ListBuildings { get; set; }
        public void AddBuilding(Building newBuilding)
        {
            ListBuildings.Add(newBuilding);
        }
        public void Setmayor(string name)

        {
            Mayor = name;
        }

        public City(string name)
        {
            Name = name;
            EstablishedYear = DateTime.Now;
            ListBuildings = new List<Building>();
        }

        public void Welcome()
        {
            Console.WriteLine($"Welcome to {Name}.");
            Console.WriteLine($"Established: {EstablishedYear}");
            Console.WriteLine($"Our fearless leader: {Mayor}");
            Console.WriteLine();
        }

    }
}