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
        public static Patient SetPatient(Patient patient)
        {
            List<Patient> patients = GetAllPatient();

            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].Id == patient.Id)
                {
                    patients[i] = patient;
                    break;
                }
            }

            WriteAllPatient(patients);

            return patient;
        }

        public static Patient GetPatient(int id)
        {
            List<Patient> patients = GetAllPatient();

            foreach (Patient patient in patients)
            {
                if (patient.Id == id)
                    return patient;
            }

            return null;
        }

        public static Patient RemovePatient(int id)
        {
            List<Patient> patients = GetAllPatient();

            Patient patientToRemove = patients.SingleOrDefault(r => r.Id == id);

            if (patientToRemove != null)
            {
                patients.Remove(patientToRemove);
                WriteAllPatient(patients);
            }

            return patientToRemove;
        }

        public static Patient AddPatient(Patient patient)
        {
            List<Patient> patients = GetAllPatient();
            patients.Add(patient);
            WriteAllPatient(patients);

            return patient;
        }

        public static List<Patient> GetAllPatient()
        {
            string patientsSerialized = System.IO.File.ReadAllText(@"..\..\Data\PatientData.txt"); //patientPath

            List<Patient> patients = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Patient>>(patientsSerialized);

            return patients;
        }


        public static void WriteAllPatient(List<Patient> patients)
        {
            string patientsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(patients);

            System.IO.File.WriteAllText(@"..\..\Data\PatientData.txt", patientsSerialized);
        }

    }
}