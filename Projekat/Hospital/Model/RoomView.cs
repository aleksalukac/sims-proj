using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    public class RoomView
    {
        public static uint idCount = 1;

        public uint Id { get; set; }
        public string RoomType { get; set; }

        public DateTime Renovation { get; set; }

        public override string ToString()
        {
            return "Soba " + Id.ToString();
        }

        public RoomView()
        {
            Id = idCount++;
        }
    }
}
