// File:    MedicalRecordRepository.cs
// Author:  Aleksa
// Created: Thursday, May 28, 2020 12:31:25 PM
// Purpose: Definition of Class MedicalRecordRepository

using Model; using System; using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class MedicalRecordRepository
   {
        public static MedicalRecord Remove(int id)
        {
            List<MedicalRecord> medicalRecords = GetAll();

            MedicalRecord medicalRecordToRemove = medicalRecords.SingleOrDefault(r => r.Id == id);

            if (medicalRecordToRemove != null)
            {
                medicalRecords.Remove(medicalRecordToRemove);
                WriteAll(medicalRecords);
            }

            return medicalRecordToRemove;
        }

        public static MedicalRecord Update(MedicalRecord medicalRecord)
        {

            List<MedicalRecord> medicalRecords = GetAll();

            for (int i = 0; i < medicalRecords.Count; i++)
            {
                if (medicalRecords[i].Id == medicalRecord.Id)
                {
                    medicalRecords[i] = medicalRecord;
                    break;
                }
            }

            WriteAll(medicalRecords);

            return medicalRecord;
        }

        public static MedicalRecord Add(MedicalRecord medicalRecord)
        {
            List<MedicalRecord> medicalRecords = GetAll();
            medicalRecords.Add(medicalRecord);
            WriteAll(medicalRecords);

            return medicalRecord;
        }

        public static MedicalRecord Get(int id)
        {
            List<MedicalRecord> medicalRecords = GetAll();

            foreach (MedicalRecord medicalRecord in medicalRecords)
            {
                if (medicalRecord.Id == id)
                    return medicalRecord;
            }

            return null;

        }

        public static void WriteAll(List<MedicalRecord> medicalRecords)
        {
            string medicalRecordsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(medicalRecords);

            System.IO.File.WriteAllText(@"..\..\Data\MedicalRecordData.txt", medicalRecordsSerialized);
        }

        public static List<MedicalRecord> GetAll()
        {
            string medicalRecordsSerialized = System.IO.File.ReadAllText(@"..\..\Data\MedicalRecordData.txt");

            List<MedicalRecord> medicalRecords = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MedicalRecord>>(medicalRecordsSerialized);

            return medicalRecords;
        }


    }
}