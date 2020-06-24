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
      public Secretary EditProfile(Model.Employee employee)
      {
         throw new NotImplementedException();
      }
      
        private EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService1)
        {
            this._employeeService = employeeService1;
        }
    }
}