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

      public MedicalExam UpdateMedicalExam(MedicalExam medicalExam)
      {
            return _medicalExamService.UpdateMedicalExam(medicalExam);
      }

        public MedicalExam Remove(int id) {
            return _medicalExamService.Remove(id);
        }
     
      
        private MedicalExamService _medicalExamService;

        public MedicalExamController(MedicalExamService medicalExamService1)
        {
            this._medicalExamService = medicalExamService1;
        }
    }
}