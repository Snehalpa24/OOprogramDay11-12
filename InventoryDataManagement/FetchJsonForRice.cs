using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventoryDataManagement
{
    class FetchJsonForRice
    {


        public Rice Read(string Path)
        {
            using(StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    return JsonConvert.DeserializeObject<Rice>(json);

                }catch(Exception e)
                {
                    Console.WriteLine("Problem Reading File");
                    return null;
                }
            }
        }
    }
}
