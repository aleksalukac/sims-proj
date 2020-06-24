using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Layouts
{
    public class Pacijenti2
    {  
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string Kontakt { get; set; }
        public string JMBG { get; set; }
        public string BrZ { get; set; }
        public string Email { get; set; }
        public string sifra { get; set; }
        public string datum { set; get; }
        public Pacijenti2()
        {
            id = id++;
        }

        public bool Contains(string str) {
            return ime.ToUpper().Contains(str) || prezime.ToUpper().Contains(str);
        }
        public object Clone() {
            return this.MemberwiseClone();
        }
    }
}
