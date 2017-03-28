using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownClass
{
    class House
    {
        public House()
        {
        }
        public House(string type)
        {
            BuildingType = type;
        }
        public string Name { get; set; }
        public string BuildingType { get; set; }
        public int NumberOfRooms { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double SquareFootage { get { return ( Height * Width); } }
        public int Floors { get; set; }
        public int BedRooms { get; set; }
        public int BathRooms { get; set; }
        public double Volume { get { return (Height * Width * Length); } }
        // Full Address -- string interpolation
        public string FullAddress { get { return $"{Address1} {Address2} {city}, {state} {zip}"); } }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }

        public int CurrentOccupants { get { return _CurrentOccupants; } }
        private int _CurrentOccupants;

        public void InCreaseOccupants ()
        {
            // Increase occupants by one
            _CurrentOccupants++;
        }
        public void DecreaseOccupants()
        {
            // Decrease occupants by one
            _CurrentOccupants--;
        }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }

        public void ToString ()
        {
            Console.WriteLine($"{BuildingType} {Name}");
        }
    }
}
