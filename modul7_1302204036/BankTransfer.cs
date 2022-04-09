using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7_1302204036
{
    internal class BankTransferConfig
    {
        public dynamic ReadJson()
        {
            string jString = File.ReadAllText("D:/Tel U/Semester 4/KPL/pratikum_kpl/Modul7_1302204036/modul7_1302204036/modul7_1302204036/banktransferconfig.json");
            dynamic data = JsonConvert.DeserializeObject(jString);
            return data;
        }
    }
}
