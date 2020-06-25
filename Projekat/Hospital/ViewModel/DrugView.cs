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

        }

        public ObservableCollection<int> approvedByDoctor = new ObservableCollection<int>();

        public List<int> alternativeDrug = new List<int>();

        private static int idCount = 1;

        public static int getIdCount() => idCount;

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
            Id = idCount++;
        }

        public bool Contains(string str)
        {
            return Name.ToUpper().Contains(str) || Id.ToString().ToUpper().Contains(str)
                || Count.ToString().ToUpper().Contains(str) || Approved.ToString().ToUpper().Contains(str);
        }

    }
}
