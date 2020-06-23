// File:    MedicalSupplyRespository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:05:18 AM
// Purpose: Definition of Class MedicalSupplyRespository

using Model; using System; using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class MedicalSupplyRespository
   {
      public MedicalSupply SetMedicalSupply(MedicalSupply medicalSupply)
      {
            List<MedicalSupply> medicalSupplies = GetAllMedicalSupply();

            for (int i = 0; i < medicalSupplies.Count; i++)
            {
                if (medicalSupplies[i].id == medicalSupply.id)
                {
                    medicalSupplies[i] =medicalSupply;
                    break;
                }
            }

            WriteAllMedicalSupply(medicalSupplies);

            return medicalSupply;
        }
      
      public MedicalSupply GetMedicalSupply(int id)
      {
            List<MedicalSupply> medicalSupplies = GetAllMedicalSupply();

            foreach (MedicalSupply medicalSupply in medicalSupplies)
            {
                if (medicalSupply.id == id)
                    return medicalSupply;
            }

            return null;
        }
      
      public MedicalSupply AddMedicalSupply(MedicalSupply medicalSupply)
      {
            List<MedicalSupply> medicalSupplies = GetAllMedicalSupply();
            medicalSupplies.Add(medicalSupply);
            WriteAllMedicalSupply(medicalSupplies);

            return medicalSupply;
        }
      
      public static MedicalSupply RemoveMedicalSupply(int id)
      {
            List<MedicalSupply> medicalSupplies = GetAllMedicalSupply();

            MedicalSupply medicalSupplyToRemove = medicalSupplies.SingleOrDefault(r => r.id == id);

            if (medicalSupplyToRemove != null)
            {
                medicalSupplies.Remove(medicalSupplyToRemove);
                WriteAllMedicalSupply(medicalSupplies);
            }

            return medicalSupplyToRemove;
        }

        public static void WriteAllMedicalSupply(List<MedicalSupply> medicalSupplies)
        {
            string medicalSuppliesSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(medicalSupplies);

            System.IO.File.WriteAllText(@"..\..\Data\MedicalSupplyData.txt",medicalSuppliesSerialized);
        }
        public static List<MedicalSupply> GetAllMedicalSupply()
      {
            string medicalSuppliesSerialized = System.IO.File.ReadAllText(@"..\..\Data\MedicalSupplyData.txt");

            List<MedicalSupply> medicalSupplies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MedicalSupply>>(medicalSuppliesSerialized);

            return medicalSupplies;
        }
   
   }
}