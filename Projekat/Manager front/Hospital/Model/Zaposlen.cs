using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    public class Zaposlen : ICloneable
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Id { get; set; }
        public string Ostalo { get; set; }

        public bool Contains(string str)
        {
            return Ime.ToUpper().Contains(str) || Prezime.ToUpper().Contains(str) || Id.ToString().Contains(str) || Ostalo.ToUpper().ToString().Contains(str);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
