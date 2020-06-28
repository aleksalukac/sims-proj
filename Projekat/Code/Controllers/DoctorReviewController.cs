// File:    DoctorReviewController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:38:54 PM
// Purpose: Definition of Class DoctorReviewController

using Model;
using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class DoctorReviewController
   {
        private DoctorReviewService _doctorReviewService;

        public DoctorReviewController(DoctorReviewService doctorReviewService1)
        {
            this._doctorReviewService = doctorReviewService1;
        }
    }
}