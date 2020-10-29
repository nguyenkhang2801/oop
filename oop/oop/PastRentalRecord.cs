using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class PastRentalRecord
    {
        private int startMileage;
        private int endMileage;
        private int change
        {
            get;
            set;
        }

        private string VehicleID
        {
            get;
            set;
        }
        public int Mileage
        {
            get { return endMileage - startMileage; }
        }
        public DateTime RentDate
        {
            get;
            set;
        }
        public DateTime ReturnDate
        {
            get;
            set;
        }
        public void NewRecord() { }
        public void DeleteRecord() { }
    }
}
