using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class DB : Vehicle
    {

        public int capacity
        {
            get;
            set;
        }
        public DB()
        {
            this.capacity = 0;

        }

        public List<Vehicle> carlist = new List<Vehicle>();
        public void add(Vehicle vehicle)
        {

            this.capacity = this.capacity + 1;
            carlist.Add(vehicle);

        }
        public void add(Vehicle[] vehicle, int n)
        {
            this.capacity = n;
            carlist.AddRange(vehicle);

        }

    }
}
