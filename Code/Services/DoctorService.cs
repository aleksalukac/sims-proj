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

            if (doctors == null)
                return null;

            foreach(var doctor in doctors)
            {
                if (doctor.Email.Equals(email))
                    return doctor;
            }

            return null;
        }

        internal Employee Update(Employee employee)
        {
            Doctor doctor = _doctorRepository.Get(employee.Id);

            if (doctor == null)
                return null;

            Doctor newDoctor = new Doctor(employee);
            newDoctor.specialisationType = doctor.specialisationType;
            newDoctor.medicalExam = doctor.medicalExam;

            return _doctorRepository.Update(newDoctor);
        }

        internal Employee Update(User user)
        {
            if(_doctorRepository.Get(user.Id) != null)
            {
                Doctor doctor = _doctorRepository.Get(user.Id);
                doctor.Email = user.Email;
                doctor.DateOfBirth = user.DateOfBirth;
                doctor.Name = user.Name;
                doctor.Password = user.Password;
                doctor.TextContent = user.TextContent;
                return _doctorRepository.Update(doctor);
            }
            return null;
        }
    }
}