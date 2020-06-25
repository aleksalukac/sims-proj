using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hospital_class_diagram.Repository
{
    public class RenovationRepository
    {
        private const string DOCTOR_FILE = @"..\..\Data\RenovationData.txt";

        public RenovationRepository()
        {
            if (!File.Exists(DOCTOR_FILE))
            {
                using (StreamWriter sw = File.CreateText(DOCTOR_FILE))
                {
                    sw.WriteLine("[]");
                }
            }
        }

        public Renovation Update(Renovation renovation)
        {
            List<Renovation> renovations = GetAll();

            for (int i = 0; i < renovations.Count; i++)
            {
                if (renovations[i].Id == renovation.Id)
                {
                    renovations[i] = renovation;
                    break;
                }
            }

            WriteAll(renovations);

            return renovation;
        }

        public Renovation Get(int id)
        {
            if (!File.Exists(DOCTOR_FILE))
            {
                using (StreamWriter sw = File.CreateText(DOCTOR_FILE))
                {
                    sw.WriteLine("[]");
                }
            }

            List<Renovation> renovations = GetAll();

            foreach (Renovation renovation in renovations)
            {
                if (renovation.Id == id)
                    return renovation;
            }

            return null;
        }

        public Renovation Remove(int id)
        {
            List<Renovation> renovations = GetAll();

            Renovation renovationToRemove = renovations.SingleOrDefault(r => r.Id == id);

            if (renovationToRemove != null)
            {
                renovations.Remove(renovationToRemove);
                WriteAll(renovations);
            }

            return renovationToRemove;
        }

        public Renovation Add(Renovation renovation)
        {
            if (Get(renovation.Id) == null)
            {
                List<Renovation> renovations = GetAll();
                renovations.Add(renovation);
                WriteAll(renovations);
                return renovation;
            }
            return null;
        }

        public List<Renovation> GetAll()
        {
            if (!File.Exists(DOCTOR_FILE))
            {
                using (StreamWriter sw = File.CreateText(DOCTOR_FILE))
                {
                    sw.WriteLine("[]");
                }
            }

            string renovationsSerialized = System.IO.File.ReadAllText(DOCTOR_FILE);

            List<Renovation> renovations = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Renovation>>(renovationsSerialized);

            return renovations;
        }

        public void WriteAll(List<Renovation> renovations)
        {
            string renovationsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(renovations);

            System.IO.File.WriteAllText(DOCTOR_FILE, renovationsSerialized);
        }
    }
}
