using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> ListBuildings = new List<Building>();
            Building SesameStreet = new Building("123 Sesame St");
            SesameStreet.Stories = 5;
            SesameStreet.Width = 1500;
            SesameStreet.Depth = 1800;
            SesameStreet.Construct();
            SesameStreet.Purchase("Bert and Ernie");
            ListBuildings.Add(SesameStreet);

            Building HomeSweetHome = new Building("210 Prince Ave");
            HomeSweetHome.Stories = 2;
            HomeSweetHome.Width = 2200;
            HomeSweetHome.Depth = 1900;
            HomeSweetHome.Construct();
            HomeSweetHome.Purchase("The Kings");
            ListBuildings.Add(HomeSweetHome);

            Building YoMommasHouse = new Building("4648 SweetBriar");
            YoMommasHouse.Stories = 1;
            YoMommasHouse.Width = 2600;
            YoMommasHouse.Depth = 2200;
            YoMommasHouse.Construct();
            YoMommasHouse.Purchase("Mom and Dad");
            ListBuildings.Add(YoMommasHouse);

            SesameStreet.DisplayInformation();
            HomeSweetHome.DisplayInformation();
            YoMommasHouse.DisplayInformation();
        }
    }
}