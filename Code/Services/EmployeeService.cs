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
        private DoctorService _doctorService;

        private SecretaryRepository _secretaryRepository;

        public EmployeeService(ManagerRepository managerRepository1, DoctorService doctorService, SecretaryRepository secretaryRepository1)
        {
            this._managerRepository = managerRepository1;
            this._doctorService = doctorService;
            this._secretaryRepository = secretaryRepository1;
        }

        internal Employee Add(Employee employee)
            => _secretaryRepository.Add((Secretary)employee);

        internal Employee FindByEmail(string email)
        {
            Employee employee = (Employee)_managerRepository.Get();
            if (employee.Email.Equals(email))
                return employee;

            employee = (Employee)_secretaryRepository.Get();
            if (employee.Email.Equals(email))
                return employee;

            return (Employee)_doctorService.FindByEmail(email);
        }

        internal Employee Update(Employee employee)
            => _secretaryRepository.Update((Secretary)employee);

        internal Employee Get()
            => _secretaryRepository.Get();

        internal Employee Get(int id)
        {
            Secretary secretary = _secretaryRepository.Get(id);
            if (secretary != null)
                return secretary;

            Doctor doctor = _doctorService.Get(id);
            if (doctor != null)
                return doctor;

            return _managerRepository.Get(id);
        }
    }
}