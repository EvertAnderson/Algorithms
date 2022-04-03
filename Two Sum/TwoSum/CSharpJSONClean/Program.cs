using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CSharpJSONClean
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/json-cleaning");
            WebResponse response = request.GetResponse();

            //using (var reader = new StreamReader(response.GetResponseStream()))
            //{
            //    var obj2 = reader.ReadToEnd();
            //    obj2.ToString()
            //    //object o = JsonConvert.DeserializeObject(reader.ReadToEnd());
            //    var obj = JsonConvert.DeserializeObject<dynamic>(reader.ReadToEnd());
            //    obj.to
            //    var data = ((JObject)obj).Children();

            //    foreach (var item in data)
            //    {
            //        int asdfas = 0;
            //        foreach (var item2 in item.Children())
            //        {
            //            int afeun = 0;
            //        }
            //    }
            //}

            Console.WriteLine(response);
            response.Close();
        }
    }
}
