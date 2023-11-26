using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management
{
    public class Manager : Person
    {
        private float salary;

        public float Salary { get => salary; set => salary = value; }

        public Manager()
        {
        }

        public Manager(string name, DateTime birthDay, int number, bool gender, string address, string id, float salary): 
            base(name, birthDay, number, gender, address, id)
        {
            Salary = salary;
        }
        public override void PrintDetails()
        {
        }

        public void ViewReports()
        {
            throw new System.NotImplementedException();
        }

        public void ManageRooms()
        {
            throw new System.NotImplementedException();
        }
    }
}