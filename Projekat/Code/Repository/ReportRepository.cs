// File:    ReportRepository.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:11:09 PM
// Purpose: Definition of Class ReportRepository

using Model; using System; using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
   public class ReportRepository
    {
        private const string REPORT_FILE = @"..\..\Data\ReportData.txt";

        public ReportRepository()
        {
            if (!File.Exists(REPORT_FILE))
            {
                using (StreamWriter sw = File.CreateText(REPORT_FILE))
                {
                    sw.WriteLine("[]");
                }
            }
        }

        public  Report Update(Report report)
        {
            List<Report> reports = GetAll();

            for (int i = 0; i < reports.Count; i++)
            {
                if (reports[i].Id == report.Id)
                {
                    reports[i] = report;
                    break;
                }
            }

            WriteAll(reports);

            return report;
        }

        public  Report Get(int id)
        {
            List<Report> reports = GetAll();

            foreach (Report report in reports)
            {
                if (report.Id == id)
                    return report;
            }

            return null;
        }

        public  Report Remove(int id)
        {
            List<Report> reports = GetAll();

            Report reportToRemove = reports.SingleOrDefault(r => r.Id == id);

            if (reportToRemove != null)
            {
                reports.Remove(reportToRemove);
                WriteAll(reports);
            }

            return reportToRemove;
        }

        public Report Add(Report report)
        {
            if (Get(report.Id) == null)
            {
                List<Report> reports = GetAll();
                reports.Add(report);
                WriteAll(reports);

                return report;
            }
            return null;
        }

        public List<Report> GetAll()
        {
            string reportsSerialized = System.IO.File.ReadAllText(REPORT_FILE); //reportPath

            List<Report> reports = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Report>>(reportsSerialized);

            return reports;
        }


        public  void WriteAll(List<Report> reports)
        {
            string reportsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(reports);

            System.IO.File.WriteAllText(REPORT_FILE, reportsSerialized);
        }

    }
}