using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management
{
    public class Receptionist : Person
    {
        private float salary;

        public Receptionist()
        {
        }

        public Receptionist(string name, DateTime birthDay, int number, bool gender, string address, string id, float salary) :
            base(name, birthDay, number, gender, address, id)
        {
            Salary = salary;
        }

        public float Salary { get => salary; set => salary = value; }

        public void Check_in()
        {
            throw new System.NotImplementedException();
        }

        public void Check_out()
        {
            throw new System.NotImplementedException();
        }

        public override void PrintDetails()
        {
            throw new System.NotImplementedException();
        }
    }
}