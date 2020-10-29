using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class Vehicle
    {
        public string type;
        public string Type
        {
            get { return type; }
            set { this.type = value; }
        }
        public string ID
        {
            get;
            set;
        }
        public int mileage
        {
            get;
            set;
        }
        public DateTime lastServiceDate
        {
            get;
            set;
        }
        public string status
        {
            get;
            set;
        }
        public Color color
        {
            get;
            set;
        }
        public int price
        {
            get;
            set;
        }

        public Vehicle(string type, string ID, int mileage, DateTime lastSer, string status)
        {
            this.type = type;
            this.ID = ID;
            this.mileage = mileage;
            this.lastServiceDate = lastSer;
            this.status = status;
            Console.WriteLine("constructor 1");
        }
        public Vehicle(Color color, string type, string ID, int price)
        {
            this.color = color;
            this.price = price;
            this.ID = ID;
            this.type = type;
            Console.WriteLine("constructor 2");
        }
        public Vehicle()
        {
            Console.WriteLine("default constructor");
        }


    }

}
