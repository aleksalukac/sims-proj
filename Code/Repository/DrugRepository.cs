// File:    DrugRepository.cs
// Author:  Aleksa
// Created: Tuesday, May 26, 2020 8:20:30 PM
// Purpose: Definition of Class DrugRepository

using Model; using System; using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class DrugRepository
    {
        private const string DRUG_FILE = @"..\..\Data\DrugData.txt";

        public DrugRepository()
        {
            if (!File.Exists(DRUG_FILE))
            {
                using (StreamWriter sw = File.CreateText(DRUG_FILE))
                {
                    sw.WriteLine("[]");
                }
            }
        }

        public  Drug Update(Drug drug)
        {
            List<Drug> drugs = GetAll();

            for (int i = 0; i < drugs.Count; i++)
            {
                if (drugs[i].Id == drug.Id)
                {
                    drugs[i] = drug;
                    break;
                }
            }

            WriteAll(drugs);

            return drug;
        }

        public  Drug Get(int id)
        {
            List<Drug> drugs = GetAll();

            foreach (Drug drug in drugs)
            {
                if (drug.Id == id)
                    return drug;
            }

            return null;
        }

        public  Drug Remove(int id)
        {
            List<Drug> drugs = GetAll();

            Drug drugToRemove = drugs.SingleOrDefault(r => r.Id == id);

            if (drugToRemove != null)
            {
                drugs.Remove(drugToRemove);
                WriteAll(drugs);
            }

            return drugToRemove;
        }

        public  Drug Add(Drug drug)
        {
            if (Get(drug.Id) == null)
            {
                List<Drug> drugs = GetAll();
                drugs.Add(drug);
                WriteAll(drugs);

                return drug;
            }
            return null;
        }

        public  List<Drug> GetAll()
        {
            string drugsSerialized = System.IO.File.ReadAllText(DRUG_FILE); //drugPath

            List<Drug> drugs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Drug>>(drugsSerialized);

            return drugs;
        }


        public  void WriteAll(List<Drug> drugs)
        {
            string drugsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(drugs);

            System.IO.File.WriteAllText(DRUG_FILE, drugsSerialized);
        }

    }
}