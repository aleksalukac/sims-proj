// File:    EmployeeService.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:02:00 PM
// Purpose: Definition of Class EmployeeService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class EmployeeService
   {
        public Secretary EditProfile(Model.Employee employee)
        {
            throw new NotImplementedException();
        }

        private ManagerRepository _managerRepository;
        private DoctorRepository _doctorRepository;


        private SecretaryRepository _secretaryRepository;

        public EmployeeService(ManagerRepository managerRepository1, DoctorRepository doctorRepository1, SecretaryRepository secretaryRepository1)
        {
            this._managerRepository = managerRepository1;
            this._doctorRepository = doctorRepository1;
            this._secretaryRepository = secretaryRepository1;
        }

        internal Employee Add(Employee employee)
            => _secretaryRepository.Add((Secretary)employee);

        internal Employee Update(Employee employee)
            => _secretaryRepository.Update((Secretary)employee);

        internal Employee Get()
            => _secretaryRepository.Get();

        internal Employee Get(int id)
        {
            Secretary secretary = _secretaryRepository.Get(id);
            if (secretary != null)
                return secretary;

            Doctor doctor = _doctorRepository.Get(id);
            if (doctor != null)
                return doctor;

            return _managerRepository.Get(id);
        }
    }
}