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
        private DoctorRepository _doctorRepository;

        public DoctorReviewService(DoctorRepository doctorRepository)
        {
            this._doctorRepository = doctorRepository;
        }

        public Model.DoctorReview GetDoctorReview(MedicalExam medicalExam)
        => Repository.MedicalExamRepository.Get(medicalExam.Id).DoctorReview;
      
        public Model.DoctorReview SetDoctorReview(Model.DoctorReview doctorReview)
        {
            MedicalExam medicalExam = _doctorRepository.Get(doctorReview.MedicalExam);
            medicalExam.DoctorReview = doctorReview;
            _doctorRepository.Update(medicalExam);

            return doctorReview;
        }
      
   }
}