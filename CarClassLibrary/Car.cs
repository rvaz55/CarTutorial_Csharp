using System;

namespace CarClassLibrary
{
    public class Car
    {
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Mileage { get; set; }

        //Methods

        //Constructor Method #1
        public Car()
        {
                //No code is needed here
                //However, this 'empty' constructor is necessary bc without it,
                //an empty (technical term is 'uninitialized' object) object.

                Make = "Unknown";
                Model = "Four Door SUV";
                Price = 350000.00M;
                Mileage = 10400;

        }


        //Constructor Method #2
        //Constructor #2 takes in three names arguments and assigns them
        //to properties of a 'car' object
        public Car(string a, string b, decimal c, int d)
        {
            Make = a;
            Model = b;
            Price = c;
            Mileage = d;
        }

    }
}
