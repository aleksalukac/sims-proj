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
            
        private DrugService _drugService;

        public DrugController(DrugService drugService1)
        {
            this._drugService = drugService1;
        }

        public Drug GetByName(string name)
        {
            return _drugService.GetByName(name);
        }

        public List<Drug> GetAll()
        {
            return _drugService.GetAll();
        }

        public Drug Get(int id)
        {
            return _drugService.Get(id);
        }

        public Drug Update(Drug drug)
        {
            return _drugService.Update(drug);
        }

        public Drug Add(Drug drug)
        {
            return _drugService.Add(drug);
        }

        public Drug Approve(int drugId, int doctorId)
        {
            return _drugService.Approve(drugId, doctorId);
        }
    }
}