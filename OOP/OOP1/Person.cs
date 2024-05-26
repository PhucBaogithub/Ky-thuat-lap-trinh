using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Person
    {
        //Attributes
        protected string name;
        protected int birthYear;
        protected string address;


        //Constructors
        public Person() { }

        public Person(string name, int birthYear, string address)
        {
            this.name = name;
            this.birthYear = birthYear;
            this.address = address;
        }

        //Methods
        public void Input()
        {
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter BirthYear: ");
            birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address: ");
            address = Console.ReadLine();
        }

        public int GetAge()
        {
            int currentyear = DateTime.Now.Year;
            return currentyear - birthYear; 
        }

        public string toString()
        {
            return $"Person[Name: {name}], BirthYear: {birthYear}, Address: {address}";
        }
    }
}
