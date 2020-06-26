// File:    UserService.cs
// Author:  Aleksa
// Created: Tuesday, May 26, 2020 7:59:18 PM
// Purpose: Definition of Class UserService

using Hospital_class_diagram.Crypt;
using Model;
using Repository;
using System; using System.Collections.Generic;
using System.IO;

namespace Services
{
   public class UserService
   {
        private EmployeeService _employeeService;
        private PatientService _patientService;

        private string LOGGED_FILE_PATH = @"..\..\Data\LoggedId.txt";

        public UserService(EmployeeService employeeService, PatientService patientService)
        {
            this._employeeService = employeeService;
            this._patientService = patientService;
        }

        internal User Get(int id)
        {
            Employee employee = _employeeService.Get(id);
            if (employee != null)
                return employee;

            return _patientService.Get(id);
        }

        public User FindByEmail(string email)
        {
            User user = (User)_employeeService.FindByEmail(email);
            if (user != null)
                return user;

            return (User)_patientService.FindByEmail(email);
        }

        public Model.User Login(string email, string password)
        {
            User user = FindByEmail(email);

            if (user != null)
            {
                if (user.Password.Equals(password))
                {
                    using (StreamWriter sw = File.CreateText(LOGGED_FILE_PATH))
                    {
                        sw.WriteLine(user.Id.ToString());
                    }
                    return user;
                }
            }

            return null;
        }

        internal User GetByEmail(string email)
        {
            User user = _employeeService.GetByEmail(email);
            if (user != null)
                return user;

            user = _patientService.GetByEmail(email);
            return user;
        }

        internal User Update(User user)
        {
            User returnValue = _employeeService.Update(user);

            if (returnValue == null)
                returnValue = _patientService.Update(user);

            return returnValue;
        }

        internal User GetLoggedUser()
        {
            using (StreamReader sr = File.OpenText(LOGGED_FILE_PATH))
            {
                string loggedIdText = sr.ReadLine();

                int parsedId;
                Int32.TryParse(loggedIdText, out parsedId);

                return Get(parsedId);
            }
        }
      
        public Boolean ChangePassword(Model.User user, string newPassword)
        {
            throw new NotImplementedException();
        }
      
        public List<Notification> GetNotifications(Model.User user)
        {
            throw new NotImplementedException();
        }
      
        public TextContent CreateFeedback(Model.User user, TextContent feedback)
        {
            throw new NotImplementedException();
        }
      
        public TextContent CreateQuestion(Model.User user, TextContent question)
        {
            throw new NotImplementedException();
        }
   
   }
}