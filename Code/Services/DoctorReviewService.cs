// File:    DoctorReviewService.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 12:14:30 PM
// Purpose: Definition of Class DoctorReviewService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class DoctorReviewService
   {
        private MedicalExamRepository _medicalExamRepository;

        public DoctorReviewService(MedicalExamRepository medicalExamRepository)
        {
            this._medicalExamRepository = medicalExamRepository;
        }

        public Model.DoctorReview Get(MedicalExam medicalExam)
        => _medicalExamRepository.Get(medicalExam.Id).DoctorReview;
      
        public Model.DoctorReview Update(Model.DoctorReview doctorReview)
        {
            MedicalExam medicalExam = _medicalExamRepository.Get(doctorReview.MedicalExam);
            if (medicalExam == null)
                return null;

            medicalExam.DoctorReview = doctorReview;
            _medicalExamRepository.Update(medicalExam);

            return doctorReview;
        }
      
   }
}