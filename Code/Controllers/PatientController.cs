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

        public Patient HospitalizePatient(Patient patient, Room room)
        {
            throw new NotImplementedException();
        }
      
        public List<Patient> GetAllPatient()
        {
            return _patientService.GetAllPatient();
        }
      
        public Patient GetPatient(int id)
        {
            throw new NotImplementedException();
        }
      
        private PatientService _patientService;

        public PatientController(PatientService patientService1)
        {
            this._patientService = patientService1;
        }
    }
}