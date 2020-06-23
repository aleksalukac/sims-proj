// File:    DoctorController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:38:39 PM
// Purpose: Definition of Class DoctorController

using Model; using System; using System.Collections.Generic;

namespace Controllers
{
   public class DoctorController
   {
      public SpecialisationType GetSpecialisation()
      {
         throw new NotImplementedException();
      }
      
      public Doctor GetDoctor(int id)
      {
         throw new NotImplementedException();
      }
      
      public List<Doctor> GetAllDoctor()
      {
         throw new NotImplementedException();
      }
      
      public Services.DoctorService doctorService;
   
   }
}