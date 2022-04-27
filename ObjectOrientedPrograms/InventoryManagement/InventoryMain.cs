using ObjectOrientedPrograms.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.InventoryManagement
{
    public class InventoryMain
    {
        public void DataManipulation(string filePath)
        {
            const string INVENTORY_DATA_PATH = @"R:\Practice_problem_Bridgelabz\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryManagement\InventoryList.json";
            InventoryManager manager = new InventoryManager();
            Console.WriteLine("1.Read Json\n 2. Add Inventory\n 3. Edit Inventory\n 4.end");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose an option to execute");
                
                int option = Convert.ToInt32(Console.ReadLine());
                
                switch (option)
                {
                    case 1:
                        manager.ReadData(filePath);
                        break;
                    case 2:
                        Console.WriteLine("Enter Inventory Details such as Name,Weight,price");
                        InventoryData data = new InventoryData();
                        data.Name = Console.ReadLine();
                        data.Weight = Convert.ToInt32(Console.ReadLine());
                        data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the inventrory Name");
                        string inventoryName1 = Console.ReadLine();
                        manager.AddInventory(data, inventoryName1, INVENTORY_DATA_PATH);
                        break;

                    case 3:
                        Console.WriteLine("Enter the Inventoryname list and grains");
                        string inventoryName = Console.ReadLine();
                        string grains1 = Console.ReadLine();
                        manager.EditInventory(inventoryName, grains1, INVENTORY_DATA_PATH);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter Proper Option To Execute");
                        break;
                }

            }
        }
    }
}
