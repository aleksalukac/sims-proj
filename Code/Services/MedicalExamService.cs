// File:    MedicalExamService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 12:55:32 PM
// Purpose: Definition of Class MedicalExamService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class MedicalExamService
   {
      public List<MedicalExam> GetAllMedicalExam()
      {
            return _medicalExamRepository.GetAll();
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
        public MedicalExam Add(MedicalExam medicalExam) 
       =>     _medicalExamRepository.Add(medicalExam);
       
        public MedicalExam Remove(int id) {
            return _medicalExamRepository.Remove(id);
        }
      
      public ScheduleMedicalExam scheduleMedicalExam;
        private MedicalExamRepository _medicalExamRepository;

        internal MedicalExam Get(int id)
            => _medicalExamRepository.Get(id);

        public MedicalExamService(MedicalExamRepository medicalExamRepository1)
        {
            this._medicalExamRepository = medicalExamRepository1;
        }
    }
}