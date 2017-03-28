using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownClass
{
    class School
    {
        public School(string bType)
        {
            BuildingType = bType;
        }

        public string Name { get; set; }
        // building type set in constructor
        public string BuildingType { get; set; }
        public int NumberOfRooms { get; set; }
        public string ConstructionMaterial { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public int SquareFootage { get; }
        public int Floors { get; set; }
        public int Classrooms { get; set; }
        public int BathRooms { get; set; }
        public int Volume { get; }
        public string FullAddress { get; }
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
            Console.WriteLine($"This property is named: {Name}");
        }

        public int NumberOfStudents { get; set; }
        public bool InSession { get; set; }
        public int NumberOfTeachers { get; set; }

        public void TeacherStudentRatio ()
        {
            Console.WriteLine($"{NumberOfTeachers}:{NumberOfStudents}");
        }


    }
}
