// File:    ReportRepository.cs
// Author:  Aleksa
// Created: Tuesday, June 2, 2020 3:11:09 PM
// Purpose: Definition of Class ReportRepository

using Model; using System; using System.Collections.Generic;
using System.Linq;

namespace Repository
{
   public class ReportRepository
   {
        public static Report SetReport(Report report)
        {
            List<Report> reports = GetAllReport();

            for (int i = 0; i < reports.Count; i++)
            {
                if (reports[i].Id == report.Id)
                {
                    reports[i] = report;
                    break;
                }
            }

            WriteAllReport(reports);

            return report;
        }

        public static Report GetReport(int id)
        {
            List<Report> reports = GetAllReport();

            foreach (Report report in reports)
            {
                if (report.Id == id)
                    return report;
            }

            return null;
        }

        public static Report RemoveReport(int id)
        {
            List<Report> reports = GetAllReport();

            Report reportToRemove = reports.SingleOrDefault(r => r.Id == id);

            if (reportToRemove != null)
            {
                reports.Remove(reportToRemove);
                WriteAllReport(reports);
            }

            return reportToRemove;
        }

        public static Report AddReport(Report report)
        {
            List<Report> reports = GetAllReport();
            reports.Add(report);
            WriteAllReport(reports);

            return report;
        }

        public static List<Report> GetAllReport()
        {
            string reportsSerialized = System.IO.File.ReadAllText(@"..\..\Data\ReportData.txt"); //reportPath

            List<Report> reports = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Report>>(reportsSerialized);

            return reports;
        }


        public static void WriteAllReport(List<Report> reports)
        {
            string reportsSerialized = Newtonsoft.Json.JsonConvert.SerializeObject(reports);

            System.IO.File.WriteAllText(@"..\..\Data\ReportData.txt", reportsSerialized);
        }

    }
}