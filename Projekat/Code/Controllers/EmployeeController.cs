// File:    EmployeeController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:43:02 PM
// Purpose: Definition of Class EmployeeController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class EmployeeController
   {
        public Employee Get()
        {
            return _employeeService.Get();
        }

        public Employee Get(int id)
        {
            return _employeeService.Get(id);
        }

        private EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService1)
        {
            this._employeeService = employeeService1;
        }

        public Employee Add(Employee employee)
        {
            return _employeeService.Add(employee);
        }

        public Employee Update(Employee employee)
        {
            return _employeeService.Update(employee);
        }
    }
}