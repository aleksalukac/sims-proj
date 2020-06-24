// File:    PatientRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:31:56 AM
// Purpose: Definition of Class PatientRepository

using Model; using System; using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class PatientRepository
   {
        public  Patient Update(Patient patient)
        {
            List<Patient> patients = GetAll();

            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].Id == patient.Id)
                {
                    patients[i] = patient;
                    break;
                }
            }

            WriteAll(patients);

            return patient;
        }

        public  Patient Get(int id)
        {
            List<Patient> patients = GetAll();

            foreach (Patient patient in patients)
            {
                if (patient.Id == id)
                    return patient;
            }

            return null;
        }

        public  Patient Remove(int id)
        {
            List<Patient> patients = GetAll();

            Patient patientToRemove = patients.SingleOrDefault(r => r.Id == id);

            if (patientToRemove != null)
            {
                patients.Remove(patientToRemove);
                WriteAll(patients);
            }

            return patientToRemove;
        }

        public  Patient Add(Patient patient)
        {
            if (Get(patient.Id) == null)
            {
                List<Patient> patients = GetAll();
                patients.Add(patient);
                WriteAll(patients);

                return patient;
            }
            return null;
        }

        public  List<Patient> GetAll()
        {
            string patientsSerialized = System.IO.File.ReadAllText(@"..\..\Data\PatientData.txt"); //patientPath

            List<Patient> patients = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Patient>>(patientsSerialized);

            return patients;
        }


        public  void WriteAll(List<Patient> patients)
        {
            string patientsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(patients);

            System.IO.File.WriteAllText(@"..\..\Data\PatientData.txt", patientsSerialized);
        }

    }
}