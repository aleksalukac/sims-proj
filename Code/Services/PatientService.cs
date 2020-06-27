// File:    PatientService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 12:50:23 AM
// Purpose: Definition of Class PatientService

using Hospital_class_diagram.Crypt;
using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class PatientService
   {
        public Patient Add(Patient patient)
        {
            return _patientRepository.Add(patient);
        }

        public List<Patient> GetAll()
            => _patientRepository.GetAll();

        public Patient Get(int id)
            => _patientRepository.Get(id);

        private PatientRepository _patientRepository;

        public PatientService(PatientRepository patientRepository1)
        {
            this._patientRepository = patientRepository1;
        }

        internal Patient FindByEmail(string email)
        {
            List<Patient> patients = _patientRepository.GetAll();

            if (patients == null)
                return null;

            foreach(var patient in patients)
            {
                if (patient.Email.Equals(email))
                    return patient;
            }
            return null;
        }

        internal Patient Remove(int id)
            => _patientRepository.Remove(id);

        internal Patient Update(User user)
        {
            if(Get(user.Id) != null)
            {
                Patient patient = _patientRepository.Get(user.Id);
                patient.Email = user.Email;
                patient.DateOfBirth = user.DateOfBirth;
                patient.Name = user.Name;
                patient.Password = user.Password;
                patient.TextContent = user.TextContent;

                return _patientRepository.Update(patient);
            }
            return null;
        }

        internal Patient GetByEmail(string email)
        {
            List<Patient> patients = _patientRepository.GetAll();

            if(patients != null)
                foreach(var patient in patients)
                {
                    if (patient.Email.Equals(email))
                        return patient;
                }

            return null;
        }
    }
}