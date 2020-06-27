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
            if (employee != null && employee.Email.Equals(email))
                return employee;

            employee = (Employee)_secretaryRepository.Get();
            if (employee != null && employee.Email.Equals(email))
                return employee;

            return (Employee)_doctorService.FindByEmail(email);
        }

        internal Employee Update(Employee employee)
        {
            if(_secretaryRepository.Get(employee.Id) != null)
                return _secretaryRepository.Update((Secretary)employee);
            if (_managerRepository.Get(employee.Id) != null)
            {
                var manager = _managerRepository.Get();
                Manager newManager = new Manager(employee);
                newManager.Id = manager.Id;
                newManager.Report = manager.Report;

                return _managerRepository.Update(newManager);
            }

            return _doctorService.Update(employee);
        }

        internal Employee GetByEmail(string email)
        {
            List<Doctor> doctors = _doctorService.GetAll();
            if(doctors != null)
                foreach(var doctor in doctors)
                {
                    if (doctor.Email.Equals(email))
                        return doctor;
                }

            Employee secretary = _secretaryRepository.Get();
            if (secretary != null && secretary.Email.Equals(email))
                return secretary;

            Employee manager = _managerRepository.Get();
            if (manager != null && manager.Email.Equals(email))
                return manager;

            return null;
        }

        internal Employee Update(User user)
        {
            if (_secretaryRepository.Get(user.Id) != null)
            {
                Secretary secretary = _secretaryRepository.Get();
                secretary.Email = user.Email;
                secretary.DateOfBirth = user.DateOfBirth;
                secretary.Name = user.Name;
                secretary.Password = user.Password;
                secretary.TextContent = user.TextContent;

                return _secretaryRepository.Update((Secretary)secretary);
            }

            if (_managerRepository.Get(user.Id) != null)
            {
                Manager manager = _managerRepository.Get();
                manager.Email = user.Email;
                manager.DateOfBirth = user.DateOfBirth;
                manager.Name = user.Name;
                manager.Password = user.Password;
                manager.TextContent = user.TextContent;

                return _managerRepository.Update(manager);
            }

            return _doctorService.Update(user);
        }

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