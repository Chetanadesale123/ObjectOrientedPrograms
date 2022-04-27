using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.StockCompanyAccount
{
    public class CompanyStockManagement
    {
        CompanyStockData data = new CompanyStockData();
        public void DisplayCompanystock(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<List<CompanyStockData>>(json);
                Console.WriteLine("NumberOfShare" + "\t" + "Price Of Share" + "\t" + "Stock Name" + "\t" + "TotalPrice");
               /* foreach (var data in CompanyStock )
                {
                    Console.WriteLine(data.NumberOFShare + "\t" + data.PriceOfShare + "\t" + data.StockName + "\t" + "\t" +(data.NumberOFShare * data.PriceOfShare));
                }*/
            }
        }
    }
}
