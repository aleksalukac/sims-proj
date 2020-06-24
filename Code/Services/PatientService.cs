// File:    PatientService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 12:50:23 AM
// Purpose: Definition of Class PatientService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class PatientService
   {
      public MedicalRecord GetMedicalRecord(int id)
      {
         throw new NotImplementedException();
      }
      
      public MedicalRecord UpdateMedicalRecord(Patient patient, MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Patient HospitalizePatient(Patient patient, Room room)
      {
         throw new NotImplementedException();
      }
      
      public List<Patient> GetAllPatient()
      {
         throw new NotImplementedException();
      }
      
      public Patient GetPatient(int id)
      {
         throw new NotImplementedException();
      }
      
        private PatientRepository _patientRepository;

        public PatientService(PatientRepository patientRepository1)
        {
            this._patientRepository = patientRepository1;
        }
    }
}