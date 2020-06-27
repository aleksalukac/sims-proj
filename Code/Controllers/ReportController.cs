// File:    ReportController.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:40:30 PM
// Purpose: Definition of Class ReportController

using Model;
using Services;
using System; using System.Collections.Generic;

namespace Controllers
{
   public class ReportController
   {
      
        private ReportService _reportService;

        public ReportController(ReportService reportService1)
        {
            this._reportService = reportService1;
        }

        public Report Add(int id, string reportText)
        {
            return _reportService.Add(id, reportText);
        }
    }
}