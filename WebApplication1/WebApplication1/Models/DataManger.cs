using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace WebApplication1.Models
{
    public class DataManger
    {
        private string Location = $"D:\\database.json";

        public void WriteToJsonFile(Ucomment Wobj)
        {
            try
            {
                var JtoWrite = JsonConvert.SerializeObject(Wobj);
                using (StreamWriter sr = File.AppendText(Location))
                {
                    sr.WriteLine(JtoWrite);
                    sr.Close();
                }
            }
            catch (Exception Ex) { }
        }

        public List<Ucomment> ReadfromJsonFile(string ID)
        {
            List<Ucomment> List = new List<Ucomment>();

            try
            {
                using (StreamReader sr = File.OpenText(Location))
                {
                    String ReadStr = "";
                    while ((ReadStr = sr.ReadLine()) != null)
                    {
                        Ucomment RObj = JsonConvert.DeserializeObject<Ucomment>(ReadStr);
                        if (RObj.id == ID) { List.Add(RObj); }
                    }
                }
            }
            catch (Exception Ex) { }

            return List;
        }

    }


    public class Ucomment
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string userRatings { get; set; }

        public Ucomment(string Id, string Name, string Description, string UserRatings)
        {
            id = Id;
            name = Name;
            description = Description;
            userRatings = UserRatings;
        }
    }


}


