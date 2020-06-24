using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Layouts
{
    public class PitanjaiOdgovori
    {
        public int id { get; set; }
        public String pitanje { get; set; }
        public String odgovori { get; set; }
        public PitanjaiOdgovori()
        {
            id = id++;
        }
    }
}
