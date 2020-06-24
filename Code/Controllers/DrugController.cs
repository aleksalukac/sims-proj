// File:    DrugController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:39:05 PM
// Purpose: Definition of Class DrugController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class DrugController
   {
      public int ApproveDrug()
      {
         throw new NotImplementedException();
      }
      
      public List<Drug> GetAllDrug()
      {
         throw new NotImplementedException();
      }
      
        private DrugService _drugService;

        public DrugController(DrugService drugService1)
        {
            this._drugService = drugService1;
        }
    }
}