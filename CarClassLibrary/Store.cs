using System;
using System.Collections.Generic;
using System.Linq;
using CarClassLibrary;

namespace CarClassLibrary
{
    public class Store
    {
        #region 1) Properties & Fields section

        #region 1.a) Subsection of Properties & Fields: Private backing-fields
        #region Notes
        ///By convention, private-backing fields begin with a single underscore
        //The keyterm 'private' is access-modifier and when added to thte field or
        //property of a class, it means that the field or property can only be accessed
        //by code that lives within the 'Store' class. In this examples, this means
        //that the 'Car' class is unable to access (read OR write) directly 
        //to the _storeInventory field.
        #endregion Notes
        private static SortedDictionary<int, Car> _storeInventory = new SortedDictionary<int, Car>();
        #endregion Subsection of Properties & Fields: Private backing-fields

        #region 1.b) Subsection of Properties & Fields: Public backing-fields
        public Dictionary<int, Car> shoppingCart = new Dictionary<int, Car>();

        //public_storeInventory is a 'public' property of the Store class
        //public_storeInventory 
        public IDictionary<int, Car> public_storeInventory
        {
            get {return _storeInventory; }

        }
        #endregion Subsection of Properties & Fields: Public backing-fields

        #endregion Properties & Fields section

        #region 2) Constructors
        /// <summary>
        /// 
        /// </summary>
        ///
        public Store()
        {
            if (_storeInventory.Count == 0 )
            {
                Car carVolvo = new Car("Volvo", "XC40 Recharge", 38000.00M, 0);
                _storeInventory.Add(1000, carVolvo);           
            }

        }


        public Store(Car vehicle): this()
        {
            if (_storeInventory.Count == 0 && vehicle != null)
            {

                _storeInventory.Add(1000, vehicle);
            }
            else if (_storeInventory.Count != 0 && vehicle != null)
            { //Without the 'else' the store executes the two code-blocks
              //following each 'if' statement

                //Linq can be used in Unity engine
                int car_id = _storeInventory.Keys.Last() + 1;
                _storeInventory.Add(car_id, vehicle);
            }

        }

        #endregion Constructors

        #region 3) Methods of class 'Store'

        public void isCarInInventory()
        { }

        #endregion
    }
}
