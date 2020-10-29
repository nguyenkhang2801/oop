using System;
using System.Collections.Specialized;
using System.Security.Principal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace oop
{

    enum Color
    {
        Red,
        Black,
        White
    }

    class Program
    {

        static void Main(string[] args)
        {

            Vehicle car1 = new Vehicle(Color.Black, "sport", "123#", 500);
            Vehicle car2 = new Vehicle(Color.Black, "sport", "124#", 600);
            Vehicle car3 = new Vehicle(Color.Black, "sport", "125#", 600);

            var date1 = new DateTime(2008, 5, 1, 8, 30, 52);
            Vehicle car4 = new Vehicle("1", "126#", 3, date1, "5");

            DB db = new DB();
            Console.WriteLine("Select option:\n 1. Add 1 Vehicle.\n 2. Add multi Vehicle.");
            
            string op = Console.ReadLine();

            if(op == "1")
            {
                //add 1 xe
                Console.WriteLine("them 1 xe:");
                db.add(car1);
            }
            else if(op == "2") 
            {
                //add nhieu xe
                Console.WriteLine("them nhieu xe:");
                Vehicle[] carr = new Vehicle[3] { car1, car3, car4 };
                db.add(carr, 3);
            }


            
            for (int i = 0; i < db.capacity; i++)
            {
                Console.WriteLine(db.carlist[i].ID);

            }


        }
    }
}
