using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.ViewModel
{
    public class SupplyView
    {
        public static int idCount = 1;

        public SupplyView()
        {

        }

        public SupplyView(MedicalSupply medicalSupply)
        {
            this.Id = medicalSupply.Id;
            this.Type = medicalSupply.Name;
            this.Count = medicalSupply.Count;
        }

        public MedicalSupply Convert()
        {
            MedicalSupply medicalSupply = new MedicalSupply();

            medicalSupply.Id = this.Id;
            medicalSupply.Name = this.Type;
            medicalSupply.Count = this.Count;

            return medicalSupply;
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }

        public bool Contains(string str)
        {
            return Type.ToUpper().Contains(str) || Count.ToString().Contains(str) || Id.ToString().Contains(str);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
