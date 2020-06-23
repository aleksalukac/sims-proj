// File:    DoctorReview.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class DoctorReview

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class DoctorReview : BaseModel
   {
        private const string ID_PATH = @"..\..\Data\DoctorReviewId.txt";

        public DoctorReview() : base(ID_PATH)
        {

        }

        public string Text { get; set; }
        public uint Rating { get; set; }

        public int MedicalExam { get; set; }
        public int Doctor { get; set; }
   
   }
}