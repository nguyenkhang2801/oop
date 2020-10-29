using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class CurrentRentalInfo
    {
        private string customer;
        private string license;
        private string address;
        private int phone;
        private string vehicleID;
        private int mileage;
        private DateTime rentDate;

        public void NewRecord() { }
        public void DeleteRecord() { }
        public float CalculateRentalFee() { return 1.0F; }
        public bool ChangeStatus(int vehicleID) { return true; }
        public CurrentRentalInfo Search(string Customer) { CurrentRentalInfo A = new CurrentRentalInfo(); return A; }
    }
}
