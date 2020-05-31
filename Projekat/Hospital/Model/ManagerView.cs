using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    class ManagerView : EmployeeView
    {
        public static ManagerView Manager = new ManagerView(true);

        public static ManagerView getInstance()
        {
            return Manager;
        }

        private ManagerView(bool rand = false) : base(rand)
        {

        }
    }
}
