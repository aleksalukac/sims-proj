// File:    DoctorService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 12:51:23 PM
// Purpose: Definition of Class DoctorService

using Hospital_class_diagram.Crypt;
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
        {
            doctor.Password = Crypt.Encrypt(doctor.Password);
            return _doctorRepository.Add(doctor);
        }

        public Doctor Remove(Doctor doctor)
            => _doctorRepository.Remove(doctor.Id);

        internal void WriteAll(List<Doctor> list)
            => _doctorRepository.WriteAll(list);

        internal void Update(Doctor doctor)
            => _doctorRepository.Update(doctor);

        internal Doctor FindByEmail(string email)
        {
            List<Doctor> doctors = _doctorRepository.GetAll();

            foreach(var doctor in doctors)
            {
                if (doctor.Email.Equals(email))
                    return doctor;
            }

            return null;
        }
    }
}