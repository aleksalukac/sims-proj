// File:    DrugRepository.cs
// Author:  Aleksa
// Created: Tuesday, May 26, 2020 8:20:30 PM
// Purpose: Definition of Class DrugRepository

using Model; using System; using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class DrugRepository
   {
        public static Drug Update(Drug drug)
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

        public static Drug Get(int id)
        {
            List<Drug> drugs = GetAll();

            foreach (Drug drug in drugs)
            {
                if (drug.Id == id)
                    return drug;
            }

            return null;
        }

        public static Drug Remove(int id)
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

        public static Drug Add(Drug drug)
        {
            List<Drug> drugs = GetAll();
            drugs.Add(drug);
            WriteAll(drugs);

            return drug;
        }

        public static List<Drug> GetAll()
        {
            string drugsSerialized = System.IO.File.ReadAllText(@"..\..\Data\DrugData.txt"); //drugPath

            List<Drug> drugs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Drug>>(drugsSerialized);

            return drugs;
        }


        public static void WriteAll(List<Drug> drugs)
        {
            string drugsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(drugs);

            System.IO.File.WriteAllText(@"..\..\Data\DrugData.txt", drugsSerialized);
        }

    }
}