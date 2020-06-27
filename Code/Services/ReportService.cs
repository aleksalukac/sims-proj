// File:    ReportService.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:10:56 PM
// Purpose: Definition of Class ReportService

using Model;
using Repository;
using System; using System.Collections.Generic;

namespace Services
{
   public class ReportService
   {
      
        private ReportRepository _reportRepository;
        private ManagerRepository _managerRepository;

        public ReportService(ReportRepository reportRepository1, ManagerRepository managerRepository)
        {
            this._reportRepository = reportRepository1;
            this._managerRepository = managerRepository;
        }

        internal Report Add(Report report)
            => _reportRepository.Add(report);

        internal Report Add(int id, string text)
        {
            Manager manager = _managerRepository.Get(id);
            if (manager != null)
            {
                Report report = new Report();
                report.DateCreated = DateTime.Now;
                report.Text = text;
                manager.Report.Add(report.Id);
                _managerRepository.Update(manager);
                return Add(report);
            }
            return null;
        }
    }
}