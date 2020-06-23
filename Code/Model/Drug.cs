// File:    Drug.cs
// Author:  Aleksa
// Created: Thursday, May 7, 2020 9:41:02 PM
// Purpose: Definition of Class Drug

using Hospital_class_diagram.Model;
using Model; using System; using System.Collections.Generic;

namespace Model
{
   public class Drug : BaseModel
   {
        private const string ID_PATH = @"..\..\Data\DrugId.txt";

        public Drug() : base(ID_PATH)
        {

        }

        public string Name { get; set; }
        public int Count { get; set; }
        public bool Approved { get; set; }
      
        public System.Collections.Generic.List<int> SimilarDrug { get; set; }
      
        public List<int> ApprovedByDoctor { get; set; }
   
   }
}