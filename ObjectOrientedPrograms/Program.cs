
using ObjectOrientedPrograms.InventoryDataManagement;
using System;

class Program
{
    static void Main(String[] args)
    {
        const string INVENTORY_DATA_PATH = @"R:\Practice_problem_Bridgelabz\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryDataManagement\Inventory.json";
        InventoryManagement inventoryManagement = new InventoryManagement();
        bool end = true;
        Console.WriteLine("1.Display\n 2. End the Program");
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
                    end = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}

