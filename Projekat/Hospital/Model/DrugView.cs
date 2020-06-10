using System;
using Hospital.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Collections.ObjectModel;

namespace Hospital.Model
{
    public class DrugView
    {
        private string name;
        private int id;
        private bool approved;
        private int count;

        public ObservableCollection<int> approvedByDoctor = new ObservableCollection<int>();

        public List<int> alternativeDrug = new List<int>();

        private static int idCount = 1;

        public static int getIdCount() => idCount;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Count { get => count; set => count = value; }
        public bool Approved { get => approved; set => approved = value; }

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
