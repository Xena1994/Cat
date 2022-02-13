using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Text.Json;
using System.Configuration;
using System.Collections.Specialized;
namespace CatLib
{
    public class DownloadOperations : IDownloadOperations
    {
        public DownloadOperations( string filename, string path, string url)
        {
            Path = path;
            Filename = filename;
            Url = url;
        }

        public string Path { get; set; }
        public string Url { get; set; }
        public string Filename { get; set; }

        public void DownloadCatInfo()
        {
            using (WebClient wc = new WebClient())
            {
                Cat cat;
                try
                {
                    Console.WriteLine("Cat Fact connecting and downloading data from endpoint..");
                    var json = wc.DownloadString(Url);
                    cat = JsonConvert.DeserializeObject<Cat>(json);
                    Console.WriteLine("Cat Fact finished downloading data..");
                }
                catch (Exception ex)
                {

                    throw new Exception("No internet connection or json serialization to the object ", ex);
                }
                Serializer s = new Serializer();
                Console.WriteLine("Cat Fact started serialize data to File..");
                s.CatInfoSerialize(cat, Filename);
                Console.WriteLine("Cat Fact finished serialize data to File..");

            }
        }
    }
}
