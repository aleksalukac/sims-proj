// File:    DoctorController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:38:39 PM
// Purpose: Definition of Class DoctorController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class DoctorController
   {
        private DoctorService _doctorService;

        public DoctorController(DoctorService service)
        {
            _doctorService = service;
        }

        public Doctor Add(Doctor doctor)
        {
            return _doctorService.Add(doctor);
        }

        public SpecialisationType GetSpecialisation()
        {
            throw new NotImplementedException();
        }
      
        public Doctor Get(int id)
        {
            return _doctorService.Get(id);
        }
      
        public List<Doctor> GetAll()
        {
            return _doctorService.GetAll();
        }
      
        public Services.DoctorService doctorService;

        public void WriteAll(List<Doctor> list)
        {
            _doctorService.WriteAll(list);
        }

        public void Update(Doctor doctor)
        {
            _doctorService.Update(doctor);
        }

        public Doctor Remove(int id)
        {
            return _doctorService.Remove(Get(id));
        }
    }
}