using System;

namespace CarClassLibrary
{
    public class Car
    {
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int Mileage { get; set; }
        public bool HasLeatherSeats { get; set; }
        public bool HasSunroof { get; set; }
        public bool HasEngine { get; set; }
        public bool IsForSale { get; set; }

        //Tutorial Task: Add a few more properties to the Car class

        //Methods

        //Constructor Method #1
        public Car()
        {
            //No code is needed here
            //However, this 'empty' constructor is necessary bc without it,
            //an empty (technical term is 'uninitialized' object) object.

            Make = "Peugeot";
            Model = "SUV 3008";
            Year = 2021;
            Price = 1000.00M;
            Mileage = 0;
            HasLeatherSeats = true;
            HasSunroof = true;
            HasEngine = false;
            IsForSale = true;

        }


        //Constructor Method #2
        //Constructor #2 takes in three names arguments and assigns them
        //to properties of a 'car' object
        public Car(string a, string b, int c,decimal d, int e, bool f, bool g, bool h, bool i)
        {
            Make = a;
            Model = b;
            Year = c;
            Price = d;
            Mileage = e;
            HasLeatherSeats = f;
            HasSunroof = g;
            HasEngine = h;
            IsForSale = i;
        }



        //To do: Create a 'TestDriveCar()' method
        //To do: Create a 'PurchaseCar()' method
    }
}
