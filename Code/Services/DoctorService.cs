// File:    DoctorService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 12:51:23 PM
// Purpose: Definition of Class DoctorService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class DoctorService
    {
        private DoctorRepository _doctorRepository;

        public DoctorService(DoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public Doctor Get(int id) 
            => _doctorRepository.Get(id);

        public List<Doctor> GetAll()
            => _doctorRepository.GetAll();

        public Doctor Add(Doctor doctor) 
            => _doctorRepository.Add(doctor);

        public Doctor Remove(Doctor doctor)
            => _doctorRepository.Remove(doctor.Id);

   }
}