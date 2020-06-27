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
      public List<MedicalExam> GetAll()
      {
            return _medicalExamRepository.GetAll();
      }
      
   
      
      
      public MedicalExam Update(MedicalExam medicalExam)
      {
            return _medicalExamRepository.Update(medicalExam);
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