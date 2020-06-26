using Controllers;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Hospital.ViewModel
{
    public class RoomView
    {
        private List<string> roomTypes = Enum.GetNames(typeof(RoomType)).ToList();
        public RoomView(Room room, RoomController _roomController)
        {
            this.Id = (uint)room.Id;
            this.RoomType = room.RoomType.ToString();

            var renovation = _roomController.GetFutureRenovation(room.Id);
            if(renovation != null)
                this.Renovation = _roomController.GetFutureRenovation(room.Id).Date;
        }

        public Room Convert()
        {
            Room room = new Room();
            room.RoomType = (Model.RoomType)(roomTypes.IndexOf(this.RoomType));

            return room;
        }

        public uint Id { get; set; }
        public string RoomType { get; set; }

        public DateTime Renovation { get; set; }

        public override string ToString()
        {
            return "Soba " + Id.ToString();
        }

        public RoomView()
        {

        }
    }
}
