using System;

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

        #endregion

    }
}
