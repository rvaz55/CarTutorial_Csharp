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
            string res;
            object selection_isValid;
            object carID_isValid = false;
            int indxr;
            Car carVW = new Car("Volkswagen","Tiguan", 2012, 18000.00M, 101050, false, true, true, true);
         
            Store dealership = new Store(carVW);
            do
            {
                do
                {
                    Console.WriteLine("Please select an option: " +
                        "\n 1)Browse store inventory " +
                        "\n 2)Manage store inventory" +
                        "\n To Quit, enter Q! at any time..." +
                        "\nSelection: ");
                    res = Console.ReadLine();

                    selection_isValid = VerificationObj.verifyReponse(res);

                    switch (selection_isValid)
                    {
                        case 1://Task #1: Print out current inventory to console

                            string msg;
                            
                            foreach (KeyValuePair<int, Car> kvp in dealership.public_storeInventory)
                            {
                                msg = $"\nCar Details: \n \tCarID: { kvp.Key}";
                                msg += $"\n \tMake: {kvp.Value.Make} ";
                                msg += $"\n \tModel: {kvp.Value.Model} ";
                                msg += $"\n \tPrice: {kvp.Value.Price} ";
                                Console.WriteLine(msg);
                            }

                            do
                            {
                                Console.WriteLine("\nTo view car specifications, please enter a CarID: ");
                                res = Console.ReadLine();

                                object cardID = VerificationObj.isCarInInventory(res, dealership.public_storeInventory);

                                if (cardID.GetType() == typeof(Int32))
                                {
                                    dealership.public_storeInventory.TryGetValue((int)cardID, out Car carData);
                                    msg = $"\nCar Details: \n \tCarID: {(int)cardID}";
                                    msg += $"\n \tMake: {carData.Make} ";
                                    msg += $"\n \tModel: {carData.Model} ";
                                    msg += $"\n \tPrice: {carData.Price} ";
                                    msg += $"\n \tMileage: {carData.Mileage} ";
                                    msg += $"\n \tHasLeatherSeats: {carData.HasLeatherSeats} ";
                                    msg += $"\n \tHasSunroof: {carData.HasSunroof} ";
                                    msg += $"\n \tIsForSale: {carData.IsForSale} ";
                                    msg += $"\nWould you like to test-drive or purchase this car? T = test, P = purchase vehicle ";
                                    Console.WriteLine(msg);

                                    res = Console.ReadLine();
                                }
                            } while (carID_isValid.GetType() == typeof(bool) && res != "Q!");

                            break;


                        case 2:
                            //do something
                            break;
                    }

                    //Info on when to use .GetType versus typeof: https://stackoverflow.com/questions/983030/type-checking-typeof-gettype-or-is
                    //Reminder: isValidSelection returns 'false' when an invalid option is entered
                } while (selection_isValid.GetType() == typeof(bool) );

                
            } while (res != "Q!");
        }
    }
}
