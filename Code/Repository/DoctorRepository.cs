// File:    DoctorRepository.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 1:34:44 AM
// Purpose: Definition of Class DoctorRepository

using Model; using System; using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class DoctorRepository
    {
        private const string DOCTOR_FILE = @"..\..\Data\DoctorData.txt";

        public DoctorRepository()
        {
            if (!File.Exists(DOCTOR_FILE))
            {
                using (StreamWriter sw = File.CreateText(DOCTOR_FILE))
                {
                    sw.WriteLine("[]");
                }
            }
        }

        public Doctor Update(Doctor doctor)
        {
            List<Doctor> doctors = GetAll();

            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].Id == doctor.Id)
                {
                    doctors[i] = doctor;
                    break;
                }
            }

            WriteAll(doctors);

            return doctor;
        }
      
        public Doctor Get(int id)
        {
            if (!File.Exists(DOCTOR_FILE))
            {
                using (StreamWriter sw = File.CreateText(DOCTOR_FILE))
                {
                    sw.WriteLine("[]");
                }
            }

            List<Doctor> doctors = GetAll();

            foreach (Doctor doctor in doctors)
            {
                if (doctor.Id == id)
                    return doctor;
            }

            return null;
        }
      
        public Doctor Remove(int id)
        {
            List<Doctor> doctors = GetAll();

            Doctor doctorToRemove = doctors.SingleOrDefault(r => r.Id == id);

            if (doctorToRemove != null)
            {
                doctors.Remove(doctorToRemove);
                WriteAll(doctors);
            }

            return doctorToRemove;
        }
      
        public Doctor Add(Doctor doctor)
        {
            if (Get(doctor.Id) == null)
            {
                List<Doctor> doctors = GetAll();
                doctors.Add(doctor);
                WriteAll(doctors);
                return doctor;
            }
            return null;
        }
      
        public List<Doctor> GetAll()
        {
            if (!File.Exists(DOCTOR_FILE))
            {
                using (StreamWriter sw = File.CreateText(DOCTOR_FILE))
                {
                    sw.WriteLine("[]");
                }
            }

            string doctorsSerialized = System.IO.File.ReadAllText(DOCTOR_FILE); 

            List<Doctor> doctors = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Doctor>>(doctorsSerialized);

            return doctors;
        }

        public void WriteAll(List<Doctor> doctors)
        {
            string doctorsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(doctors);

            System.IO.File.WriteAllText(DOCTOR_FILE, doctorsSerialized);
        }
   }
}