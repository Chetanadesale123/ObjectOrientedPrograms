using ObjectOrientedPrograms.StockAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.CompanyStockAccount
{
    public class CompanyManagement
    {   
        StockData data2 = new StockData();
        Commercial com = new Commercial();
        List<StockData> StockList1 = new List<StockData>();
        List<StockData> StockList2 = new List<StockData>();
        List<StockData> StockList3 = new List<StockData>();
        public void ReadData(string filePath)
        {
            CompanyDetails details = com.ReadJson(filePath);
            this.StockList1 = details.StockList1;
            this.StockList2 = details.StockList2;
            this.StockList3 = details.StockList3;
            
        }
        public void AddInventory(StockData data2, string inventoryName, string filePath)
        {
            if (inventoryName.Equals("RiceList"))
            {
                StockList1.Add(data2);
            }
            if (inventoryName.Equals("WheatList"))
            {
                StockList2.Add(data2);
            }
            if (inventoryName.Equals("PulsesList"))
            {
                StockList3.Add(data2);
            }
            SaveInventory(filePath);
        }
        public void SaveInventory(string filePath)
        {
            CompanyDetails details = new CompanyDetails();
            details.StockList1 = StockList1;
            details.StockList2 = StockList2;
            details.StockList3 = StockList3;
            com.WriteToJson(filePath, details);
        }
        public void EditInventory(string inventoryName, string grains, string filePath)
        {
            ReadData(filePath);
            StockData data2 = new StockData();
            //string inventoryName=Console.ReadLine();
            if (inventoryName.Equals("Rice"))
            {
                foreach (StockData data in StockList1)
                {
                    if (data2.StockName.Equals(grains))
                    {
                        Console.WriteLine("Choose Option to edit");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                data2.StockName = Console.ReadLine();
                                break;
                            case 2:
                                data2.NumberOFShare = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data.PriceOfShare = Convert.ToInt32(Console.ReadLine());
                                break;


                        }
                    }
                }
            }
            if (inventoryName.Equals("Wheat"))
            {
                foreach (StockData data in StockList2)
                {
                    if (data2.StockName.Equals(grains))
                    {
                        Console.WriteLine("Choose Option to edit");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                data2.StockName = Console.ReadLine();
                                break;
                            case 2:
                                data2.NumberOFShare = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data2.PriceOfShare = Convert.ToInt32(Console.ReadLine());
                                break;


                        }
                    }
                }
            }
            if (inventoryName.Equals("Pulses"))
            {
                foreach (StockData data in StockList3)
                {
                    if (data2.StockName.Equals(grains))
                    {
                        Console.WriteLine("Choose Option to edit");
                        int check = Convert.ToInt32(Console.ReadLine());
                        switch (check)
                        {
                            case 1:
                                data2.StockName = Console.ReadLine();
                                break;
                            case 2:
                                data2.NumberOFShare = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 3:
                                data2.PriceOfShare = Convert.ToInt32(Console.ReadLine());
                                break;


                        }
                    }
                }
            }
            SaveInventory(filePath);

        }

    }
}
    

