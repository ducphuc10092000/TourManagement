using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Trip
{
    public class STAFF_TRIP_DETAIL : BaseViewModel
    {
        public CT_DOAN_NHANVIEN ct_doan_nv { get; set; }
        public STAFF_TRIP_DETAIL()
        {

        }
        public virtual void AddNewStaff_Trip_Detail(int idtrip, int idnv,string nhiemvu)
        {
            ct_doan_nv = new CT_DOAN_NHANVIEN();
            ct_doan_nv.IDDOAN = idtrip;
            ct_doan_nv.IDNV = idnv;
            ct_doan_nv.NHIEMVU = nhiemvu;
            DataProvider.Ins.DB.CT_DOAN_NHANVIEN.Add(ct_doan_nv);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
