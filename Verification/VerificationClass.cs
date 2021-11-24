using System;
using System.Collections;
using System.Collections.Generic;
using CarClassLibrary;

namespace VerificationLibrary
{

    //The access modifier 'public' is used on a class,
    //The 'VerifivationObj' has two keywords in it's declaration
    //public: The type or member can be accessed by any other code in the same assembly or another assembly that references it. 
    //link for 'public':https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    //static:A static class is basically the same as a non-static class, but there is one difference: a static class cannot be instantiated. In other words, you cannot use the new operator to create a variable of the class type. Because there is no instance variable, you access the members of a static class by using the class name itself. 
    //link for 'static': https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
    //Members of static classes can be accessed directly using the class name followed by a (.) and class member name. 

    //Other notes on static classes:
    // A static class can contain only the static members while a non-static class can contain static members.
    // Also, Static classes are by-default sealed so they cannot be inherited.
    public static class VerificationObj
    {

        #region Properties

        #endregion

        #region Methods

        public static object verifyReponse(string response)
        {
            bool isNumber = false;
            int num;

            if (!String.IsNullOrWhiteSpace(response))
            {
                isNumber = Int32.TryParse(response, out num);
                return num;
            }

            return false;
        }

        //Stackoverflow entry on the usefullness of Interfaces: https://stackoverflow.com/questions/896611/purpose-of-idictionary-interface/896635#896635
        public static object isCarInInventory(string response, IDictionary<int, Car> inventory)
        {
            object response_isNumber = verifyReponse(response);
            object response_isValidCardID;

            if (response_isNumber.GetType() == typeof(Int32))
            {
                //Add link for type-casting
                int cardID = (Int32)response_isNumber;
                //To do: check that the cardID is in the inventory
                response_isValidCardID =  inventory.ContainsKey(cardID);

                if ((bool)response_isValidCardID == true)
                {
                    return cardID;
                }
                return response_isValidCardID;
            }
            return response_isNumber;
        }

        #endregion

    }
}
