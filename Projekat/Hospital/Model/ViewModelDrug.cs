using Hospital.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    public class ViewModelDrug
    {
        public List<ViewChart> Data { get; set; }
        public ViewModelDrug()
        {
            Data = new List<ViewChart>()
            {
                new ViewChart{Type = "Odobreni", Count = DrugPage.DrugList.Count},
                new ViewChart{Type = "Neodobreni", Count = DrugPage.DrugListUnapproved.Count}
            };

        }
    }
}
