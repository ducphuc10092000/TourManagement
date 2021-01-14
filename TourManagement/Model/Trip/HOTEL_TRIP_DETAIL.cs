using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Trip
{
    public class HOTEL_TRIP_DETAIL : BaseViewModel
    {
        public CT_DOAN_KHACHSAN ct_doan_ks { get; set; }
        public HOTEL_TRIP_DETAIL()
        {

        }
        public virtual void AddNewHotel_Trip_Detail(int idtrip, int idks,string tongchiphi)
        {
            ct_doan_ks = new CT_DOAN_KHACHSAN();
            ct_doan_ks.IDDOAN = idtrip;
            ct_doan_ks.IDKS = idks;
            ct_doan_ks.CHIPHIKS = tongchiphi;
            DataProvider.Ins.DB.CT_DOAN_KHACHSAN.Add(ct_doan_ks);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
