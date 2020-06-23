// File:    PatientService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 12:50:23 AM
// Purpose: Definition of Class PatientService

using System;

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
      
      public Repository.PatientRepository patientRepository;
      public UserService userService;
   
   }
}