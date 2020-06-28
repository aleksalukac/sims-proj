// File:    MedicalExamService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 12:55:32 PM
// Purpose: Definition of Class MedicalExamService

using System;

namespace Services
{
   public class MedicalExamService
   {
      public List<MedicalExam> GetAllMedicalExam()
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalExam> GetAllUpcomingMedicalExam()
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalExam> GetAllPastMedicalExam()
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalExam> GetAllPatientMedicalExam(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalExam> GetAllDoctorMedicalExam(Doctor doctor)
      {
         throw new NotImplementedException();
      }
      
      public MedicalExam ScheduleMedicalExam(MedicalExam medicalExam)
      {
         throw new NotImplementedException();
      }
      
      public MedicalExam CancelMedicalExam(int id)
      {
         throw new NotImplementedException();
      }
      
      public MedicalExam UpdateMedicalExam(MedicalExam medicalExam)
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalExam> GetAllFreeMedicalExam()
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalExam> GetAllFreeMedicalExamRoom(Room room)
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalExam> GetAllFreeMedicalExamDoctor(Doctor doctor)
      {
         throw new NotImplementedException();
      }
      
      public MedicalExam ScheduleMedicalExamPriority(PriorityMedicalExamDTO parameter1)
      {
         throw new NotImplementedException();
      }
      
      public MedicalExam AddTherapy(List<Drug> drugList, int medicalExamId)
      {
         throw new NotImplementedException();
      }
      
      public Repository.MedicalExamRepository medicalExamRepository;
      public System.Collections.Generic.List<ScheduleMedicalExam> scheduleMedicalExam;
      
      /// <summary>
      /// Property for collection of ScheduleMedicalExam
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<ScheduleMedicalExam> ScheduleMedicalExam
      {
         get
         {
            if (scheduleMedicalExam == null)
               scheduleMedicalExam = new System.Collections.Generic.List<ScheduleMedicalExam>();
            return scheduleMedicalExam;
         }
         set
         {
            RemoveAllScheduleMedicalExam();
            if (value != null)
            {
               foreach (ScheduleMedicalExam oScheduleMedicalExam in value)
                  AddScheduleMedicalExam(oScheduleMedicalExam);
            }
         }
      }
      
      /// <summary>
      /// Add a new ScheduleMedicalExam in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddScheduleMedicalExam(ScheduleMedicalExam newScheduleMedicalExam)
      {
         if (newScheduleMedicalExam == null)
            return;
         if (this.scheduleMedicalExam == null)
            this.scheduleMedicalExam = new System.Collections.Generic.List<ScheduleMedicalExam>();
         if (!this.scheduleMedicalExam.Contains(newScheduleMedicalExam))
            this.scheduleMedicalExam.Add(newScheduleMedicalExam);
      }
      
      /// <summary>
      /// Remove an existing ScheduleMedicalExam from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveScheduleMedicalExam(ScheduleMedicalExam oldScheduleMedicalExam)
      {
         if (oldScheduleMedicalExam == null)
            return;
         if (this.scheduleMedicalExam != null)
            if (this.scheduleMedicalExam.Contains(oldScheduleMedicalExam))
               this.scheduleMedicalExam.Remove(oldScheduleMedicalExam);
      }
      
      /// <summary>
      /// Remove all instances of ScheduleMedicalExam from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllScheduleMedicalExam()
      {
         if (scheduleMedicalExam != null)
            scheduleMedicalExam.Clear();
      }
   
   }
}