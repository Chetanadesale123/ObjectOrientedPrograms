
using ObjectOrientedPrograms.InventoryDataManagement;
using ObjectOrientedPrograms.InventoryManagement;
using System;

class Program
{
    static void Main(String[] args)
    {
        const string INVENTORY_DATA_PATH = @"R:\Practice_problem_Bridgelabz\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryDataManagement\Inventory.json";
        InventoryManagement inventoryManagement = new InventoryManagement();
        InventoryManager manager = new InventoryManager();
        InventoryData data = new InventoryData();   
        bool end = true;
        Console.WriteLine("1.Display\n 2.Add data \n 3. Edit data \n 4. End the Program");
        while (end == true)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    inventoryManagement.DisplayInventory(INVENTORY_DATA_PATH);
                    break;
                case 2:
                    Console.WriteLine("Enter the inventrory data and inventory list");
                    string inventoryName1 = Console.ReadLine();
                    manager.AddInventory(data,inventoryName1,INVENTORY_DATA_PATH);
                     break;
                case 3:
                    Console.WriteLine("Enter the Inventoryname list and grains");
                     string inventoryName= Console.ReadLine();
                    string grains1 = Console.ReadLine();
                    manager.EditInventory(inventoryName,grains1,INVENTORY_DATA_PATH);
                    break;
                case 4:
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}

