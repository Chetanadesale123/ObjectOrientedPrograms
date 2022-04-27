using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.StockAccount
{
    public class StockPortfolio
    {
        const string StockFilePath = @"R:\Practice_problem_Bridgelabz\ObjectOrientedPrograms\ObjectOrientedPrograms\StockAccount\Stock.json";
                    
        StockData data1 = new StockData();
        public void DisplayStock(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var stock = JsonConvert.DeserializeObject<List<StockData>>(json);
                Console.WriteLine("NumberOfShare"+ "\t" +"Price Of Share" + "\t" + "Stock Name" + "\t" + "TotalPrice");
                foreach (var data1 in stock )
                {
                    Console.WriteLine(data1.NumberOFShare+"\t"+"\t"+data1.PriceOfShare+"\t"+"\t"+data1.StockName+"\t"+(data1.NumberOFShare * data1.PriceOfShare));
                }
            }
        }
    }
}
