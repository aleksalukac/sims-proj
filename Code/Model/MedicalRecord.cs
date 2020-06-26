// File:    MedicalRecord.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class MedicalRecord

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class MedicalRecord : BaseModel
   {
        private const string ID_PATH = @"..\..\Data\MedicalRecordId.txt";

        public MedicalRecord() : base(ID_PATH)
        {
            MedicalExam = new List<int>();
            Therapy = new List<int>();
        }

        public int Patient { get; set; }
        public List<int> MedicalExam { get; set; }
        public System.Collections.Generic.List<int> Therapy { get; set; }
   
   }
}