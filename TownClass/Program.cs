﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The beginning of Class Usage");

            // create List
            var house= new List<House>();

            // this code works j
            House houseOne = new House("straw");
            House houseTwo = new House("brick");
            House houseThree = new House("wood");

            //var printMe = houseOne<House.bType>;
            //Console.WriteLine(houseOne);

            List<House> houseColl = new List<House>();
            houseColl.Add(new House() { Name = "Home" });
            houseColl.Add(new House() { Name = "Casa" });

            // FROM CLASS
            var myHouse = new House();
            var myHouse2 = new House("wood");
            myHouse.Height = 20;
            myHouse.Width = 55;

            var newHouse3 = new House();

            // List from class
            var villageBlck = new List<House>(); //brackets say type
            villageBlck.Add(myHouse);


        }
    }
}
