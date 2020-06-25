using Hospital.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.ViewModel
{
    class ViewModelRoom
    {
        public List<ViewChart> Data { get; set; }
        public ViewModelRoom()
        {
            Data = new List<ViewChart>()
            {
                /*operationRoom,
        examinationRoom,
        hospitalRoom*/
                new ViewChart{Type = "Hospital Room", Count = RoomPage.GetRoomCount("hospitalRoom")},
                new ViewChart{Type = "Operation Room", Count = RoomPage.GetRoomCount("operationRoom")},
                new ViewChart{Type = "Examination Room", Count = RoomPage.GetRoomCount("examinationRoom")}
            };

        }
    }
}
