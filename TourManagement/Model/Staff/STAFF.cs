using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Staff
{
    public class STAFF : BaseViewModel
    {
        public NHANVIEN nhanvien { get; set; }
        public STAFF()
        {

        }

        public void AddNewStaff(string tennv, string diachi, string sdt, string email, string ngaysinh, string chucvu,string cmnd, string avatar)
        {
            nhanvien = new NHANVIEN();
            nhanvien.TENNV = tennv;
            nhanvien.DIACHI = diachi;
            nhanvien.SDT = sdt;
            nhanvien.EMAIL = email;
            nhanvien.NGAYSINH = ngaysinh;
            nhanvien.CHUCVU = chucvu;
            nhanvien.CMND = cmnd;
            nhanvien.AVATAR = avatar;
            DataProvider.Ins.DB.NHANVIEN.Add(nhanvien);
            DataProvider.Ins.DB.SaveChanges();
        }

        public void EditStaff(int idnv, string tennv, string diachi, string sdt, string email, string ngaysinh, string chucvu)
        {
            nhanvien = DataProvider.Ins.DB.NHANVIEN.Where(x => x.IDNV == idnv).SingleOrDefault();
            nhanvien.TENNV = tennv;
            nhanvien.DIACHI = diachi;
            nhanvien.SDT = sdt;
            nhanvien.EMAIL = email;
            nhanvien.NGAYSINH = ngaysinh;
            nhanvien.CHUCVU = chucvu;
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
