using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;

namespace Bank
{
    public class JsonSerializator
    {

        public static void ToJson(List<Owner> owner, string path)
        {
            File.Delete(path);
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Owner>));
            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fstream, owner);
            }
        }

        public static List<Owner> FromJson(string path)
        {
            string owner;
            using (FileStream fstream = File.OpenRead(path))
            {
                var array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                owner = System.Text.Encoding.UTF8.GetString(array);
            }
            return JsonConvert.DeserializeObject<List<Owner>>(owner);
        }
    }
}
