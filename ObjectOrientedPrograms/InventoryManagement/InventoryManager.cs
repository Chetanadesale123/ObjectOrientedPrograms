
using ObjectOrientedPrograms.InventoryDataManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.InventoryManagement
{
    public class InventoryManager
    {   
         
        InventoryFactory factory = new InventoryFactory();
         List<InventoryData> RiceList = new List<InventoryData>();
         List<InventoryData> WheatList = new List<InventoryData>();
         List<InventoryData> PulsesList = new List<InventoryData>();
        public void ReadData(string filePath)
        {
            InventoryDetails details = factory.ReadJson(filePath);
            this.RiceList = details.RiceList;
            this.WheatList = details.WheatList;
            this.PulsesList = details.PulsesList;
        }
        public void AddInventory(InventoryData data,string inventoryName,string filePath)
        {
            if (inventoryName.Equals("RiceList"))
            {
                RiceList.Add(data);
            }
            if (inventoryName.Equals("WheatList"))
            {
                WheatList.Add(data);
            }
            if (inventoryName.Equals("PulsesList"))
            {
                PulsesList.Add(data);
            }
            SaveInventory(filePath);
        }
        public void SaveInventory(string filePath)
        {
            InventoryDetails details = new InventoryDetails();
            details.RiceList = RiceList;
            details.WheatList = WheatList;
            details.PulsesList = PulsesList;
            factory.WriteToJson(filePath, details);
        }
        public void EditInventory(string inventoyName,string grains,string filePath)
        {
            InventoryData inventory = new InventoryData();
             string inventoryName=Console.ReadLine();
            if (inventoryName.Equals("Rice"))
            {
                foreach(InventoryData data in RiceList)
                {
                    if (data.Equals(grains))
                    {
                        Console.WriteLine("Choose Option to edit");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                               data.Name = Console.ReadLine();
                                break;
                            case 2:
                                data.Weight =Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;


                        }
                    }
                }
            }
            if (inventoryName.Equals("Wheat"))
            {
                foreach (InventoryData data in WheatList)
                {
                    if (data.Equals(grains))
                    {
                        Console.WriteLine("Choose Option to edit");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                              data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;


                        }
                    }
                }
            }
            if (inventoryName.Equals("Pulses"))
            {
                foreach (InventoryData data in PulsesList)
                {
                    if (data.Equals(grains))
                    {
                        Console.WriteLine("Choose Option to edit");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                data.Name = Console.ReadLine();
                                break;
                            case 2:
                               data.Weight = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                                break;


                        }
                    }
                }
            }
            SaveInventory(filePath);

        }

    }
}
