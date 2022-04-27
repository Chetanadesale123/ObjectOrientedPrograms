
using ObjectOrientedPrograms.InventoryDataManagement;
using ObjectOrientedPrograms.InventoryManagement;
using ObjectOrientedPrograms.StockAccount;
using System;

class Program
{
    static void Main(String[] args)
    {
        
        //const string INVENTORY_DATA_PATH = @"R:\Practice_problem_Bridgelabz\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryManagement\InventoryList.json";
        InventoryManagement inventoryManagement = new InventoryManagement();
        InventoryManager manager = new InventoryManager();
        InventoryData data = new InventoryData();   
        bool end = true;
        Console.WriteLine("1.Display\n 2.Manipulation data \n 3. Stock Display \n 4. End the Program");
        while (end == true)
        {
            Console.WriteLine("Take an option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    
                    const string InDataFilePath = @"R:\Practice_problem_Bridgelabz\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryDataManagement\Inventory.json";
                    inventoryManagement.DisplayInventory(InDataFilePath);
                    break;
                    case 2:
                    const string INVENTORY_DATA_PATH = @"R:\Practice_problem_Bridgelabz\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryManagement\InventoryList.json";
                    InventoryMain main = new InventoryMain();
                    main.DataManipulation(INVENTORY_DATA_PATH);
                    break;
                case 3:
                    const string StockFilePath = @"R:\Practice_problem_Bridgelabz\ObjectOrientedPrograms\ObjectOrientedPrograms\StockAccount\Stock.json";
                    StockPortfolio  folio = new StockPortfolio();
                    folio.DisplayStock(StockFilePath);
                    break ;

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

