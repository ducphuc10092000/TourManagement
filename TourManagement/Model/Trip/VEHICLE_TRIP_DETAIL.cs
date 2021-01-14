using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Trip
{
    public class VEHICLE_TRIP_DETAIL : BaseViewModel
    {
        public CT_DOAN_PHUONGTIEN ct_doan_pt { get; set; }
        public VEHICLE_TRIP_DETAIL()
        {

        }
        public virtual void AddNewVehicle_Trip_Detail(int idtrip, int idpt, string chiphi)
        {
            ct_doan_pt = new CT_DOAN_PHUONGTIEN();
            ct_doan_pt.IDDOAN = idtrip;
            ct_doan_pt.IDPT = idpt;
            ct_doan_pt.CHIPHIPT = chiphi;
            DataProvider.Ins.DB.CT_DOAN_PHUONGTIEN.Add(ct_doan_pt);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
