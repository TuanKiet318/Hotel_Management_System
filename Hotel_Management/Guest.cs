using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel_Management
{
    public class Guest : Person
    {
        private float invoice;

        public float Invoice { get => invoice; set => invoice = value; }

        public Guest()
        {
        }
        public Guest(string name, DateTime birthDay, int number, bool gender, string address, string id, float invoice) :
            base(name, birthDay, number, gender, address, id)
        {
           Invoice = invoice;
        }

        public void MakeReservation()
        {
            throw new System.NotImplementedException();
        }

        public void RequestServices()
        {
            throw new System.NotImplementedException();
        }

        public override void PrintDetails()
        {
            throw new System.NotImplementedException();
        }
    }
}