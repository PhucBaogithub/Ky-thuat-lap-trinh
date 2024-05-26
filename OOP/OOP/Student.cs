using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Student
    {
        //Abbtributes  - Fields
        private string studentID;
        private string name;
        private int birthYear;
        private bool gender;
        private string stdClass;

        //Properties
        public string StudentID
        {
            get { return studentID; }
            set { studentID = StudentID; }
        }

        public string Name
        {
            get { return name; }
            set { name = Name; }
        }


        public int BirthYear
        {
            get { return birthYear; }
            set {
                int currentYear = DateTime.Now.Year;
                if (value > 0 && value <= currentYear)
                {
                    birthYear = value;
                }
                else
                    Console.WriteLine("Invalid Year");
            }
        }


        public bool Gender
        {
            get { return gender; }
            set {}
        }


        public string StdClass
        {
            get { return stdClass; }
            set { stdClass = StdClass; }
        }
        //Constructors
        public Student() { }
        public Student(string studentID, string name, int birthYear, bool gender, string stdClass)
        {
            this.studentID = studentID;
            this.name = name;
            this.birthYear = birthYear;
            this.gender = gender;
            this.stdClass = stdClass;
        } 

        //Methods

        //public int GetBirthYear()
        //{
        //    return birthYear;
        //}
        //public void SetBirthYear(int birthYear)
        //{
        //    int currentYear = DateTime.Now.Year;
        //    if (birthYear > 0 && birthYear <= currentYear)
        //    {
        //        this.birthYear = birthYear;
        //    }
        //    else
        //        Console.WriteLine("Invalid Year");
        //}
        public void InputInfo()
        {
            Console.Write("Student ID: ");
            studentID = Console.ReadLine();
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Birth Year: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.Write("Gender: ");
            int Gender = int.Parse(Console.ReadLine());
            if (Gender == 0)
                gender = false;
            if(Gender == 1)
                gender = true;
            Console.Write("Class: ");
            stdClass = Console.ReadLine();
        }
        public int GetAge()
        {
            return DateTime.Now.Year - BirthYear;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"- MSSV: {StudentID}");
            Console.WriteLine($"- Ho va Ten: {Name}");
            Console.WriteLine($"- Nam Sinh: {BirthYear}");
            Console.WriteLine($"- Gioi Tinh: {Gender}");
            Console.WriteLine($"- MSLH: {StdClass}");
        }
    }
}
