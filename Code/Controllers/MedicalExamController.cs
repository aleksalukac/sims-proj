// File:    MedicalExamController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:17:14 PM
// Purpose: Definition of Class MedicalExamController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class MedicalExamController
   {
      public List<MedicalExam> GetAllMedicalExam()
      {
            return _medicalExamService.GetAllMedicalExam();
      }

        public MedicalExam Add(MedicalExam medicalExam)
        {
            return _medicalExamService.Add(medicalExam);
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
            return _medicalExamService.UpdateMedicalExam(medicalExam);
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

        public MedicalExam Remove(int id) {
            return _medicalExamService.Remove(id);
        }
      public MedicalExam AddTherapy(List<Drug> drugList, int medicalExamId)
      {
         throw new NotImplementedException();
      }
      
        private MedicalExamService _medicalExamService;

        public MedicalExamController(MedicalExamService medicalExamService1)
        {
            this._medicalExamService = medicalExamService1;
        }
    }
}