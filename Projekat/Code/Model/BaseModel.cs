using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hospital_class_diagram.Model
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        public BaseModel(string path)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("0");
                }
            }

            int parsedId = 0;

            using (StreamReader sr = File.OpenText(path))
            {
                string textFromFile = sr.ReadLine(); 
                

                Int32.TryParse(textFromFile, out parsedId);

                Id = parsedId++;

            }

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(parsedId.ToString());
            }

        }
    }
}
