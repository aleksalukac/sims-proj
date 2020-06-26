// File:    PatientController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:37:50 PM
// Purpose: Definition of Class PatientController

using System;

namespace Controllers
{
   public class PatientController
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
      
      public Services.PatientService patientService;
   
   }
}