// File:    Patient.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Patient

using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Patient : User
   {
        public string Jmbg { get; set; }
        public string InsuranceNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public System.Collections.Generic.List<int> Alergy { get; set; }

        public int MedicalRecord { get; set; }
        public int Room { get; set; }
    }
}