// File:    MedicalExamController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:17:14 PM
// Purpose: Definition of Class MedicalExamController

using Model; using System; using System.Collections.Generic;

namespace Controllers
{
   public class MedicalExamController
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
      
      public MedicalExam ScheduleMedicalExamPriority(Services.PriorityMedicalExamDTO parameter1)
      {
         throw new NotImplementedException();
      }
      
      public MedicalExam AddTherapy(List<Drug> drugList, int medicalExamId)
      {
         throw new NotImplementedException();
      }
      
      public Services.MedicalExamService medicalExamService;
   
   }
}