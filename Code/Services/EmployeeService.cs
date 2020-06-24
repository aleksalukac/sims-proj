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
    }
}