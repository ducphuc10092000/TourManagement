using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Trip
{
    public class CUSTOMER_TRIP_DETAIL : BaseViewModel
    {
        public CT_DOAN_KHACHHANG ct_doan_kh { get; set; }
        public CUSTOMER_TRIP_DETAIL()
        {

        }
        public virtual void AddNewCustomer_Trip_Detail(int idtrip, int idkh)
        {
            ct_doan_kh = new CT_DOAN_KHACHHANG();
            ct_doan_kh.IDDOAN = idtrip;
            ct_doan_kh.IDKH = idkh;
            DataProvider.Ins.DB.CT_DOAN_KHACHHANG.Add(ct_doan_kh);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
