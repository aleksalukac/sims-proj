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
        public MedicalSupply Update(MedicalSupply medicalSupply)
        {
            List<MedicalSupply> medicalSupplies = GetAll();

            for (int i = 0; i < medicalSupplies.Count; i++)
            {
                if (medicalSupplies[i].Id == medicalSupply.Id)
                {
                    medicalSupplies[i] = medicalSupply;
                    break;
                }
            }

            WriteAll(medicalSupplies);

            return medicalSupply;
        }

        public MedicalSupply Get(int id)
        {
            List<MedicalSupply> medicalSupplies = GetAll();

            foreach (MedicalSupply medicalSupply in medicalSupplies)
            {
                if (medicalSupply.Id == id)
                    return medicalSupply;
            }

            return null;
        }

        public MedicalSupply Add(MedicalSupply medicalSupply)
        {
            if (Get(medicalSupply.Id) == null)
            {
                List<MedicalSupply> medicalSupplies = GetAll();
                medicalSupplies.Add(medicalSupply);
                WriteAll(medicalSupplies);

                return medicalSupply;
            }
            return null;
        }

        public  MedicalSupply Remove(int id)
        {
            List<MedicalSupply> medicalSupplies = GetAll();

            MedicalSupply medicalSupplyToRemove = medicalSupplies.SingleOrDefault(r => r.Id == id);

            if (medicalSupplyToRemove != null)
            {
                medicalSupplies.Remove(medicalSupplyToRemove);
                WriteAll(medicalSupplies);
            }

            return medicalSupplyToRemove;
        }

        public  void WriteAll(List<MedicalSupply> medicalSupplies)
        {
            string medicalSuppliesSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(medicalSupplies);

            System.IO.File.WriteAllText(@"..\..\Data\MedicalSupplyData.txt", medicalSuppliesSerialized);
        }
        public  List<MedicalSupply> GetAll()
        {
            string medicalSuppliesSerialized = System.IO.File.ReadAllText(@"..\..\Data\MedicalSupplyData.txt");

            List<MedicalSupply> medicalSupplies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MedicalSupply>>(medicalSuppliesSerialized);

            return medicalSupplies;
        }


    }
}