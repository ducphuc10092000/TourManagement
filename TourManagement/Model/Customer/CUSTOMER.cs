using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Customer
{
    public class CUSTOMER : BaseViewModel
    {
        public KHACHHANG khachhang { get; set; }

        public string GIOITINH { get; set; }
        

        public CUSTOMER()
        {

        }

        public void AddNewCustomer(string tenkh, string cmnd, string diachi, string sdt, string email, string ngaysinh, string avatar)
        {
            khachhang = new KHACHHANG();
            khachhang.TENKH = tenkh;
            khachhang.CMND = cmnd;
            khachhang.DIACHI = diachi;
            khachhang.SDT = sdt;
            khachhang.EMAIL = email;
            khachhang.NGAYSINH = ngaysinh.ToString();
            khachhang.ACTIVE = true;
            khachhang.AVATAR = avatar;

            DataProvider.Ins.DB.KHACHHANG.Add(khachhang);
            DataProvider.Ins.DB.SaveChanges();
        }

        public void EditCustomer(int idkh, string tenkh, string cmnd, string diachi, string sdt, string email, string ngaysinh,string avatar)
        {
            khachhang = DataProvider.Ins.DB.KHACHHANG.Where(x => x.IDKH == idkh).SingleOrDefault();
            khachhang.TENKH = tenkh;
            khachhang.CMND = cmnd;
            khachhang.DIACHI = diachi;
            khachhang.SDT = sdt;
            khachhang.EMAIL = email;
            khachhang.NGAYSINH = ngaysinh;
            khachhang.AVATAR = avatar;
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
