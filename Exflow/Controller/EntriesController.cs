using Exflow.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Exflow.Controller
{
    public class EntriesController : ApiController
    {
        public void Get()  
        {
         
        }

        public Form Get(int id)
        {
            return null;
        }
     
        public void Post(Form content)
        {
            //string currentDirectory = Directory.GetCurrentDirectory();
            //DirectoryInfo directory = new DirectoryInfo(currentDirectory);

            //var filePath = Path.Combine(directory.FullName, "UserInfo.json");

            using (StreamWriter file = File.CreateText("C:\\Users\\Rino\\Source\\Repos\\Exflow\\Exflow\\obj\\Debug\\User.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file,content);
            }
        }


        public void Put(int id,Form form )
        {

        }

        public void Delete(int id)
        {

        }
    }
}