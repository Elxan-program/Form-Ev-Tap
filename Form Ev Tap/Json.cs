using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anket_Home_Work
{
    class Helper
    {
        public static void JsonSerialization(Human human, string filename)
        {
            var serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(filename))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    jtw.Formatting = Formatting.Indented;
                    serializer.Serialize(jtw, human);
                }
            }
        }
    }
}
