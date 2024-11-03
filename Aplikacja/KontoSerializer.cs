using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    internal class KontoSerializer
    {
        
        public static string Serialize(List<Konto> konta)
        {
            return JsonConvert.SerializeObject(konta);
        }

        public static List<Konto> Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<List<Konto>>(json);
        }
    }
}
