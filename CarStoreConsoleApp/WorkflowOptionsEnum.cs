using System;
using System.ComponentModel;

namespace CarStoreConsoleApp
{
    [DefaultValue(ClientWorkflow)]
    public enum WorkflowOptions
    {
        ClientWorkflow = 1,
        AdminWorkflow = 2,
        Quit = 0
    }

    [DefaultValue(BrowseStore)]
    public enum ClientWorkflowOptionsEnum
    {
        BrowseStore,        //Value: 1
        ViewAllInventory,   //Value: 2
        ViewSpecificCar,    //Value: 3
        TestDriveCar,       //Value: 4
        PurchaseCar,        //Value: 5
    }

    [DefaultValue(ManageStore)]
    public enum AdminWorkflowOptionsEnum
    { 
        ManageStore,        //Value: 1
        EditInventory,      //Value: 2
        AddCar,             //Value: 3
        DeleteCar,          //Value: 4
    }
}
