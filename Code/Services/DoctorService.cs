// File:    DoctorService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 12:51:23 PM
// Purpose: Definition of Class DoctorService

using Model; using System; using System.Collections.Generic;

namespace Services
{
   public class DoctorService
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
      
      public Repository.DoctorRepository doctorRepository;
      public UserService userService;
   
   }
}