using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Student : Person
    {
        //Attributes
        private string program;
        private int year;

        //Constructors
        public Student() : base() { }

        public Student(string program, int year, string name, int birthYear, string address) : base(name, birthYear, address)
        {

            this.program = program;
            this.year = year;
        }
    }
}
