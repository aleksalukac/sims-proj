// File:    DrugService.cs
// Author:  Aleksa
// Created: Wednesday, May 27, 2020 12:41:45 AM
// Purpose: Definition of Class DrugService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class DrugService
    {
        private DrugRepository _drugRepository;
        public DrugService(DrugRepository drugRepository1)
        {
            this._drugRepository = drugRepository1;
        }

        public int ApproveDrug()
      {
         throw new NotImplementedException();
      }
      
      public List<Drug> GetAllDrug()
      {
         throw new NotImplementedException();
      }

        internal List<Drug> GetAll()
            => _drugRepository.GetAll();

        internal Drug Get(int id)
            => _drugRepository.Get(id);

        internal Drug Update(Drug drug)
            => _drugRepository.Update(drug);

        internal Drug Add(Drug drug)
            => _drugRepository.Add(drug);
    }
}