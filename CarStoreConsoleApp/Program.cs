using System;
using System.Collections.Generic;
using CarClassLibrary;
using VerificationLibrary;


namespace CarStoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string res;
            object isValidSelection;
            Car carVW = new Car("Volkswagen","Tiguan",18000.00M, 101050);
         
            Store dealership = new Store(carVW);
            do
            {
                do
                {
                    Console.WriteLine("Please select an option: " +
                        "\n 1)Browse store inventory " +
                        "\n 2)Manage store inventory" +
                        "\n To Quit, enter Q! at any time...");
                    res = Console.ReadLine();

                    isValidSelection = VerificationObj.verifyReponse(res);

                    switch (isValidSelection)
                    {
                        case 1://Task #1: Print out current inventory to console

                            foreach (KeyValuePair<int, Car> kvp in dealership.public_storeInventory)
                            {
                                string msg = $"\nCar Details: \n \tCarID: { kvp.Key}";
                                msg += $"\n \tMake: {kvp.Value.Make} ";
                                msg += $"\n \tModel: {kvp.Value.Model} ";
                                msg += $"\n \tPrice: {kvp.Value.Price} ";
                                Console.WriteLine(msg);
                            }

                            Console.WriteLine("To view car specifications, please enter a CarID: ");
                            res = Console.ReadLine();

                            break;


                        case 2:
                            //do something
                            break;
                    }

                    //Info on when to use .GetType versus typeof: https://stackoverflow.com/questions/983030/type-checking-typeof-gettype-or-is
                    //Reminder: isValidSelection returns 'false' when an invalid option is entered
                } while (isValidSelection.GetType() == typeof(bool) );

                
            } while (res != "Q!");
        }
    }
}
