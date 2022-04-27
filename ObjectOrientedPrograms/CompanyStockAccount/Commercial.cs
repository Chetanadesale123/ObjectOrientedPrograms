using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms.CompanyStockAccount
{
    public class Commercial
    {
        public CompanyDetails ReadJson(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var json = reader.ReadToEnd();
                var inventory = JsonConvert.DeserializeObject<CompanyDetails>(json);
                return inventory;
            }
        }
        public void WriteToJson(string filePath, CompanyDetails details)
        {
            var json = JsonConvert.SerializeObject(details);
            File.WriteAllText(filePath, json);

        }
    }
}

