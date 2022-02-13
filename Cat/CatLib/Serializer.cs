using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System;
using System.IO;
using System.Text;

namespace CatLib
{
    public class Serializer : ISerializeOperation
    {
        public void CatInfoSerialize(Cat cat, string filename)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(cat);
                string fullpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
                using (StreamWriter writer = File.AppendText(fullpath))
                {
                    writer.WriteLine(jsonString);
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error writing data to the file or prepare directory..", ex);
            }
           

        }

        
    }
}
