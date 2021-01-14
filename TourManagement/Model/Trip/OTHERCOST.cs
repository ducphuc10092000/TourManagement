using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Trip
{
    public class OTHERCOST : BaseViewModel
    {
        public CT_DOAN_CHIPHIKHAC chitiet_doan_chiphikhac { get; set; }
        public string CHIPHI { get; set; }
        public string MOTA { get; set; }
        public OTHERCOST()
        {

        }
    }
}
