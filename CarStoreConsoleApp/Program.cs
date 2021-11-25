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
            //object carID_isValid = false;
            Car carVW = new Car("Volkswagen", "Tiguan", 2012, 18000.00M, 101050, false, true, true, true);        
            Store dealership = new Store(carVW);

            do
            {
                do
                {
                    Console.WriteLine("Please select an option: " +
                        "\n 1) Browse store inventory " +
                        "\n 2) Manage store inventory" +
                        "\n To Quit, press 0 at any time...");
                    //Write() method allows thte cursor stay on the current line
                    //WriteLine() method forces a new-line for the cursor
                    Console.Write("\nSelection:");
                    res = Console.ReadLine();

                    //The variable selection_isValid 
                    selection_isValid = VerificationObj.verifyReponse(res.ToString());

                    ///if (not false and is either [clientWF, adminWF])


                    if ((WorkflowOptions)selection_isValid == WorkflowOptions.ClientWorkflow || (WorkflowOptions)selection_isValid == WorkflowOptions.AdminWorkflow)
                    {
                        clientWorkflow((WorkflowOptions)selection_isValid, dealership);

                    }

                    //Info on when to use .GetType versus typeof: https://stackoverflow.com/questions/983030/type-checking-typeof-gettype-or-is
                    //Reminder: isValidSelection returns 'false' when an invalid option is entered
                } while (selection_isValid.GetType() == typeof(bool) );

                
            } while ((WorkflowOptions)selection_isValid != WorkflowOptions.Quit);
        }

        public static void clientWorkflow(WorkflowOptions selectedOption, Store dealership)
        {

            if ((WorkflowOptions)selectedOption == WorkflowOptions.ClientWorkflow)
            {
                DisplayClientOptions((WorkflowOptions)selectedOption, dealership);
            }

            else if ((WorkflowOptions)selectedOption == WorkflowOptions.AdminWorkflow)
            { }
        }

        public static void DisplayClientOptions(WorkflowOptions selectedOption, Store dealership)
        {
            string res;
            string msg;
            object carID_isValid = false;

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
                Console.Write("\nTo view car specifications, please enter a CarID: ");
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
                    Console.WriteLine(msg);
                    Console.Write($"\nWould you like to test-drive or purchase this car? T = test, P = purchase vehicle ");
                    res = Console.ReadLine();

                    //() ? :


                                }
            } while (carID_isValid.GetType() == typeof(bool) && res != "Q!");


        }
    }
}
