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
      public Report CreateReport(Report report)
      {
         throw new NotImplementedException();
      }
      
        private ReportRepository _reportRepository;

        public ReportService(ReportRepository reportRepository1)
        {
            this._reportRepository = reportRepository1;
        }
    }
}