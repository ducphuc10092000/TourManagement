using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Trip
{
    public class EATING : BaseViewModel
    {
        public CT_DOAN_BUAAN chitiet_doan_buaan { get; set; } 

        public string CHIPHIBUAAN { get; set; }
        public string  MOTA { get; set; }
        public EATING()
        {

        }

        public void AddEatingCost(int iddoan, string chiphi, string mota)
        {
            chitiet_doan_buaan.IDDOAN = iddoan;
            chitiet_doan_buaan.CHIPHIBUAAN = chiphi;
            chitiet_doan_buaan.MOTA = mota;
        }

        public void EditEadtingCost(int idct, string chiphi, string mota)
        {
            chitiet_doan_buaan = DataProvider.Ins.DB.CT_DOAN_BUAAN.Where(x => x.IDCT == idct).SingleOrDefault();
            chitiet_doan_buaan.CHIPHIBUAAN = chiphi;
            chitiet_doan_buaan.MOTA = mota;
        }
    }
}
