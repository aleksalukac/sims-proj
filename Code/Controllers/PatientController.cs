// File:    PatientController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:37:50 PM
// Purpose: Definition of Class PatientController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class PatientController
   {
      
        public Patient Add(Patient patient)
        {
            return _patientService.Add(patient);
        }
      
        public List<Patient> GetAll()
        {
            return _patientService.GetAll();
        }
        
        public Patient Get(int id)
        {
            return _patientService.Get(id);
        }

        private PatientService _patientService;

        public PatientController(PatientService patientService1)
        {
            this._patientService = patientService1;
        }

        public Patient Update(Patient patient)
        {
            return _patientService.Update(patient);
        }

        public Patient Remove(int id)
        {
            return _patientService.Remove(id);
        }
    }
}