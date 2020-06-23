// File:    GuestUserService.cs
// Author:  Aleksa
// Created: Tuesday, May 26, 2020 7:57:27 PM
// Purpose: Definition of Class GuestUserService

using System;

namespace Services
{
   public class GuestUserService
   {
      public User Register(User newUser)
      {
         throw new NotImplementedException();
      }
      
      public System.Collections.Generic.List<DoctorRepository> doctorRepository;
      
      /// <summary>
      /// Property for collection of Repository.DoctorRepository
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<DoctorRepository> DoctorRepository
      {
         get
         {
            if (doctorRepository == null)
               doctorRepository = new System.Collections.Generic.List<DoctorRepository>();
            return doctorRepository;
         }
         set
         {
            RemoveAllDoctorRepository();
            if (value != null)
            {
               foreach (Repository.DoctorRepository oDoctorRepository in value)
                  AddDoctorRepository(oDoctorRepository);
            }
         }
      }
      
      /// <summary>
      /// Add a new Repository.DoctorRepository in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddDoctorRepository(Repository.DoctorRepository newDoctorRepository)
      {
         if (newDoctorRepository == null)
            return;
         if (this.doctorRepository == null)
            this.doctorRepository = new System.Collections.Generic.List<DoctorRepository>();
         if (!this.doctorRepository.Contains(newDoctorRepository))
            this.doctorRepository.Add(newDoctorRepository);
      }
      
      /// <summary>
      /// Remove an existing Repository.DoctorRepository from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveDoctorRepository(Repository.DoctorRepository oldDoctorRepository)
      {
         if (oldDoctorRepository == null)
            return;
         if (this.doctorRepository != null)
            if (this.doctorRepository.Contains(oldDoctorRepository))
               this.doctorRepository.Remove(oldDoctorRepository);
      }
      
      /// <summary>
      /// Remove all instances of Repository.DoctorRepository from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllDoctorRepository()
      {
         if (doctorRepository != null)
            doctorRepository.Clear();
      }
      public System.Collections.Generic.List<PatientRepository> patientRepository;
      
      /// <summary>
      /// Property for collection of Repository.PatientRepository
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<PatientRepository> PatientRepository
      {
         get
         {
            if (patientRepository == null)
               patientRepository = new System.Collections.Generic.List<PatientRepository>();
            return patientRepository;
         }
         set
         {
            RemoveAllPatientRepository();
            if (value != null)
            {
               foreach (Repository.PatientRepository oPatientRepository in value)
                  AddPatientRepository(oPatientRepository);
            }
         }
      }
      
      /// <summary>
      /// Add a new Repository.PatientRepository in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddPatientRepository(Repository.PatientRepository newPatientRepository)
      {
         if (newPatientRepository == null)
            return;
         if (this.patientRepository == null)
            this.patientRepository = new System.Collections.Generic.List<PatientRepository>();
         if (!this.patientRepository.Contains(newPatientRepository))
            this.patientRepository.Add(newPatientRepository);
      }
      
      /// <summary>
      /// Remove an existing Repository.PatientRepository from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemovePatientRepository(Repository.PatientRepository oldPatientRepository)
      {
         if (oldPatientRepository == null)
            return;
         if (this.patientRepository != null)
            if (this.patientRepository.Contains(oldPatientRepository))
               this.patientRepository.Remove(oldPatientRepository);
      }
      
      /// <summary>
      /// Remove all instances of Repository.PatientRepository from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPatientRepository()
      {
         if (patientRepository != null)
            patientRepository.Clear();
      }
   
   }
}