using System;
using Hospital.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Collections.ObjectModel;
using Model;

namespace Hospital.ViewModel
{
    public class DrugView
    {
        public DrugView(Drug drug)
        {
            this.Count = drug.Count;
            this.Name = drug.Name;
            this.Id = drug.Id;
            this.alternativeDrug = drug.SimilarDrug;
            this.Approved = drug.Approved;
            this.approvedByDoctor = drug.ApprovedByDoctor;
        }

        public Drug Convert()
        {
            Drug drug = new Drug();
            drug.Count = this.Count;
            drug.SimilarDrug = this.alternativeDrug;
            drug.Name = this.Name;
            drug.Approved = this.Approved;
            drug.ApprovedByDoctor = this.approvedByDoctor;

            return drug;
        }

        public List<int> approvedByDoctor = new List<int>();

        public List<int> alternativeDrug = new List<int>();

        public string Name { get; set; }
        public int Id { get; set; }
        public int Count { get; set; }
        public bool Approved { get; set; }

        public override string ToString()
        {
            return Name + " | " + Id.ToString();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public DrugView(bool rand = false)
        { 
        }

        public bool Contains(string str)
        {
            return Name.ToUpper().Contains(str) || Id.ToString().ToUpper().Contains(str)
                || Count.ToString().ToUpper().Contains(str) || Approved.ToString().ToUpper().Contains(str);
        }

    }
}
