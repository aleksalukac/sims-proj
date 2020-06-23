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
      public static Drug SetDrug(Drug drug)
      {
            List<Drug> drugs = GetAllDrug();

            for (int i = 0; i < drugs.Count; i++)
            {
                if (drugs[i].id == drug.id)
                {
                    drugs[i] = drug;
                    break;
                }
            }
            WriteAllDrug(drugs);

            return drug;
        }
      
      public static Drug GetDrug(int id)
      {
            List<Drug> drugs = GetAllDrug();

            foreach (Drug drug in drugs)
            {
                if (drug.id == id)
                    return drug;
            }

            return null;
        }
      
      public static Drug DeleteDrug(int id)
      {
            List<Drug> drugs = GetAllDrug();

            Drug drugToRemove = drugs.SingleOrDefault(r => r.id == id);

            if (drugToRemove != null)
            {
                drugs.Remove(drugToRemove);
                WriteAllDrug(drugs);
            }

            return drugToRemove;
        }
      
      public static Drug AddDrug(Drug drug)
      {
            List<Drug> drugs = GetAllDrug();
            drugs.Add(drug);
            WriteAllDrug(drugs);

            return drug;
        }
        public static void WriteAllDrug(List<Drug> drugs)
        {
            string drugsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(drugs);

            System.IO.File.WriteAllText(@"..\..\Data\DrugData.txt", drugsSerialized);
        }


        public static List<Drug> GetAllDrug()
      {
            string drugsSerialized = System.IO.File.ReadAllText(@"..\..\Data\DrugData.txt");

            List<Drug> drugs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Drug>>(drugsSerialized);

            return drugs;
        }
   
   }
}