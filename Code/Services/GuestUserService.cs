// File:    GuestUserService.cs
// Author:  Aleksa
// Created: Tuesday, May 26, 2020 7:57:27 PM
// Purpose: Definition of Class GuestUserService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class GuestUserService
   {
      public User Register(User newUser)
      {
         throw new NotImplementedException();
      }
      
        private MedicalExamRepository _medicalExamRepository;

        public GuestUserService(MedicalExamRepository medicalExamRepository)
        {
            this._medicalExamRepository = medicalExamRepository;
        }
    }
}