using System;
using CatLib;
using System.Configuration;
namespace Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "";
            string filename = "";
            string path = "";
            try
            {
                Console.WriteLine("Cat Fact Startig..");
                url = ConfigurationManager.AppSettings.Get("CatUrl");
                filename = ConfigurationManager.AppSettings.Get("filename");
              
            }
            catch (Exception ex)
            {
                throw new Exception("Configuration download error..", ex);
            }
            DownloadOperations dw = new DownloadOperations(filename, path, url);
            dw.DownloadCatInfo();
            Console.WriteLine("Cat Fact finished operation..");
            
            
            
        }
    }
}
