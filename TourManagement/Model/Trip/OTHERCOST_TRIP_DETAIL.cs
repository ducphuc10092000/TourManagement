using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Trip
{
    public class OTHERCOST_TRIP_DETAIL : BaseViewModel
    {
        public CT_DOAN_CHIPHIKHAC ct_doan_cpkhac { get; set; }
        public OTHERCOST_TRIP_DETAIL()
        {

        }
        public virtual void AddNewOtherCost_Trip_Detail(int idtrip, string chiphi, string mota)
        {
            ct_doan_cpkhac = new CT_DOAN_CHIPHIKHAC();
            ct_doan_cpkhac.IDDOAN = idtrip;
            ct_doan_cpkhac.CHIPHI = chiphi;
            ct_doan_cpkhac.MOTA = mota;
            DataProvider.Ins.DB.CT_DOAN_CHIPHIKHAC.Add(ct_doan_cpkhac);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
