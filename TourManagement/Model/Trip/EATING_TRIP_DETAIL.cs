using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Trip
{
    public class EATING_TRIP_DETAIL : BaseViewModel
    {
        public CT_DOAN_BUAAN ct_doan_buaan { get; set; }
        public EATING_TRIP_DETAIL()
        {

        }
        public virtual void AddNewEating_Trip_Detail(int idtrip,string chiphibuaan, string mota)
        {
            ct_doan_buaan = new CT_DOAN_BUAAN();
            ct_doan_buaan.IDDOAN = idtrip;
            ct_doan_buaan.CHIPHIBUAAN = chiphibuaan;
            ct_doan_buaan.MOTA = mota;
            DataProvider.Ins.DB.CT_DOAN_BUAAN.Add(ct_doan_buaan);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
