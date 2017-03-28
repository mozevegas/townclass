using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownClass
{
    class Bank
    {
        public Bank(string bankType)
        {
            BuildingType = bankType;
        }
        public string Name { get; set; }
        public string BuildingType { get; set; }
        public int NumberOfRooms { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int SquareFootage { get; }
        public int Floors { get; set; }
        public int BathRooms { get; set; }
        public int Volume { get; }

        // Full Address -- string interpolation
        public string FullAddress { get { return $"{Address1} {Address2} {city}, {state} {zip}"); } }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }

        public int CurrentOccupants { get { return _CurrentOccupants; } }
        public int _CurrentOccupants;

        public void InCreaseOccupants()
        {
            // Increase occupants by one
            _CurrentOccupants++;
        }

        public void DecreaseOccupants()
        {
            _CurrentOccupants--;
        }

        public void DisplayName()
        {
            Console.WriteLine($"This property is named: {this.Name}");
        }

        public double AmountOfMoney { get { return _AmountOfMoney; } }
        private double _AmountOfMoney;

        public void DepositMoney (double deposit)
        {
            // Modifies AmountOfMoney
            _AmountOfMoney += deposit;
        }

        public void WithdrawMoney (double withdraw)
        {
            _AmountOfMoney -= withdraw;
        }


    }
}
