﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.Layouts
{
    class Room
    {
        public static uint idCount = 1;

        public uint Id { get; set; }
        public string RoomType { get; set; }

        public DateTime Renovation { get; set; }

        public override string ToString()
        {
            return "Soba " + Id.ToString();
        }

        public Room()
        {
            Id = idCount++;
        }
    }
}
