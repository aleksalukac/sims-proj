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
        public static MedicalRecord RemoveMedicalRecord(int id)
        {
            List<MedicalRecord> medicalRecords = GetAllMedicalRecord();

            MedicalRecord medicalRecordToRemove = medicalRecords.SingleOrDefault(r => r.Id == id);

            if (medicalRecordToRemove != null)
            {
                medicalRecords.Remove(medicalRecordToRemove);
                WriteAllMedicalRecord(medicalRecords);
            }

            return medicalRecordToRemove;
        }

        public static MedicalRecord SetMedicalRecord(MedicalRecord medicalRecord)
        {

            List<MedicalRecord> medicalRecords = GetAllMedicalRecord();

            for (int i = 0; i < medicalRecords.Count; i++)
            {
                if (medicalRecords[i].Id == medicalRecord.Id)
                {
                    medicalRecords[i] = medicalRecord;
                    break;
                }
            }

            WriteAllMedicalRecord(medicalRecords);

            return medicalRecord;
        }

        public static MedicalRecord AddMedicalRecord(MedicalRecord medicalRecord)
        {
            List<MedicalRecord> medicalRecords = GetAllMedicalRecord();
            medicalRecords.Add(medicalRecord);
            WriteAllMedicalRecord(medicalRecords);

            return medicalRecord;
        }

        public static MedicalRecord GetMedicalRecord(int id)
        {
            List<MedicalRecord> medicalRecords = GetAllMedicalRecord();

            foreach (MedicalRecord medicalRecord in medicalRecords)
            {
                if (medicalRecord.Id == id)
                    return medicalRecord;
            }

            return null;

        }

        public static void WriteAllMedicalRecord(List<MedicalRecord> medicalRecords)
        {
            string medicalRecordsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(medicalRecords);

            System.IO.File.WriteAllText(@"..\..\Data\MedicalRecordData.txt", medicalRecordsSerialized);
        }

        public static List<MedicalRecord> GetAllMedicalRecord()
        {
            string medicalRecordsSerialized = System.IO.File.ReadAllText(@"..\..\Data\MedicalRecordData.txt");

            List<MedicalRecord> medicalRecords = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MedicalRecord>>(medicalRecordsSerialized);

            return medicalRecords;
        }


    }
}