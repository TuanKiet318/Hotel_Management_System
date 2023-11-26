using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management
{
    public abstract class Person
    {
        private string name;
        private DateTime birthDay;
        private int number;
        private bool gender;
        private int address;
        private string id;

        public Person()
        {
        }

        public Person(string name, DateTime birthDay, int number, bool gender, int address, string id)
        {
            this.Name = name;
            this.BirthDay = birthDay;
            this.Number = number;
            this.Gender = gender;
            this.Address = address;
            this.Id = id;
        }

        public string Name { get => name; set => name = value; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public int Number { get => number; set => number = value; }
        public bool Gender { get => gender; set => gender = value; }
        public int Address { get => address; set => address = value; }
        public string Id { get => id; set => id = value; }

        public abstract void PrintDetails();
    }
}