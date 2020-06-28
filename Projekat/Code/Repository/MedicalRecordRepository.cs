// File:    MedicalRecordRepository.cs
// Author:  Aleksa
// Created: Thursday, May 28, 2020 12:31:25 PM
// Purpose: Definition of Class MedicalRecordRepository

using Model; using System; using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class MedicalRecordRepository
   {
        private const string MEDICAL_RECORD_FILE = @"..\..\Data\MedicalRecordData.txt";

        public MedicalRecordRepository()
        {
            if (!File.Exists(MEDICAL_RECORD_FILE))
            {
                using (StreamWriter sw = File.CreateText(MEDICAL_RECORD_FILE))
                {
                    sw.WriteLine("[]");
                }
            }
        }

        public  MedicalRecord Remove(int id)
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

        public  MedicalRecord Update(MedicalRecord medicalRecord)
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

        public  MedicalRecord Add(MedicalRecord medicalRecord)
        {
            if (Get(medicalRecord.Id) == null)
            {
                List<MedicalRecord> medicalRecords = GetAll();
                medicalRecords.Add(medicalRecord);
                WriteAll(medicalRecords);

                return medicalRecord;
            }
            return null;
        }

        public  MedicalRecord Get(int id)
        {
            List<MedicalRecord> medicalRecords = GetAll();

            foreach (MedicalRecord medicalRecord in medicalRecords)
            {
                if (medicalRecord.Id == id)
                    return medicalRecord;
            }

            return null;

        }

        public  void WriteAll(List<MedicalRecord> medicalRecords)
        {
            string medicalRecordsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(medicalRecords);

            System.IO.File.WriteAllText(MEDICAL_RECORD_FILE, medicalRecordsSerialized);
        }

        public  List<MedicalRecord> GetAll()
        {
            string medicalRecordsSerialized = System.IO.File.ReadAllText(MEDICAL_RECORD_FILE);

            List<MedicalRecord> medicalRecords = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MedicalRecord>>(medicalRecordsSerialized);

            return medicalRecords;
        }


    }
}