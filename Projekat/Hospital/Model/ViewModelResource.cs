using Hospital.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    class ViewModelResource
    {
        public List<ViewChart> Data { get; set; }
        public ViewModelResource()
        {
            Data = new List<ViewChart>()
            {
                new ViewChart{Type = "Resursi", Count = ResourcePage.ResourceList.Count},
                new ViewChart{Type = "Potrosni materijali", Count = ResourcePage.SupplyList.Count}
            };

        }
    }
}
