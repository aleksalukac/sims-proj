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
        private DoctorService _doctorService;

        public DrugService(DrugRepository drugRepository1, DoctorService doctorService)
        {
            this._drugRepository = drugRepository1;
            this._doctorService = doctorService;
        }

      public List<Drug> GetAllDrug()
      {
         throw new NotImplementedException();
      }

        internal Drug GetByName(string name)
        {
            List<Drug> drugs = GetAll();
            foreach(var drug in drugs)
            {
                if (drug.Name.ToUpper().Equals(name.ToUpper()))
                    return drug;
            }
            return null;
        }

        internal List<Drug> GetAll()
            => _drugRepository.GetAll();

        internal Drug Get(int id)
            => _drugRepository.Get(id);

        internal Drug Update(Drug drug)
            => _drugRepository.Update(drug);

        internal Drug Add(Drug drug)
            => _drugRepository.Add(drug);

        internal Drug Approve(int drugId, int doctorId)
        {
            Drug drug = Get(drugId);
            Doctor doctor = _doctorService.Get(doctorId);

            if (drug == null || doctor == null)
                return null;

            if (!drug.ApprovedByDoctor.Contains(doctor.Id))
                return null;

            drug.ApprovalCount++;
            _doctorService.Update(doctor);

            if (drug.ApprovalCount >= 2)
                drug.Approved = true;

            return Update(drug);
        }
    }
}