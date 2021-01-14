using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Tour
{
    public class HOTEL : BaseViewModel
    {
        private string _TRANGTHAI;
        public string TRANGTHAI { get => _TRANGTHAI; set { _TRANGTHAI = value; OnPropertyChanged(); } }

        private string _TONGCHIPHI;
        public string TONGCHIPHI { get => _TONGCHIPHI; set { _TONGCHIPHI = value; OnPropertyChanged(); } }

        private string _SOPHONGDOI;
        public string SOPHONGDOI { get => _SOPHONGDOI; set { _SOPHONGDOI = value; OnPropertyChanged(); } }

        private string _SOPHONGDON;
        public string SOPHONGDON { get => _SOPHONGDON; set { _SOPHONGDON = value; OnPropertyChanged(); } }


        public KHACHSAN khachsan { get; set; }

        public HOTEL()
        {

        }

        public void AddNewHotel(string tenks, string diachi, string sdt, string tinhthanh,string mota,string avatar,string giaphongdon, string giaphongdoi)
        {
            KHACHSAN temp = new KHACHSAN();
            temp.TENKS = tenks;
            temp.DIACHI = diachi;
            temp.SDT = sdt;
            temp.TINHTHANH = tinhthanh;
            temp.MOTA = mota;
            temp.AVATAR = avatar;
            temp.ACTIVE = true;
            temp.GIAPHONGDOI = giaphongdoi;
            temp.GIAPHONGDON = giaphongdon;
            DataProvider.Ins.DB.KHACHSAN.Add(temp);
            DataProvider.Ins.DB.SaveChanges();
        }

        public void EditHotel(int idks,string tenks, string diachi, string sdt, string tinhthanh, string mota, bool active,string avatar,string giaphongdon, string giaphongdoi)
        {
            khachsan = DataProvider.Ins.DB.KHACHSAN.Where(x => x.IDKS == idks).SingleOrDefault();
            khachsan.TENKS = tenks;
            khachsan.DIACHI = diachi;
            khachsan.SDT = sdt;
            khachsan.TINHTHANH = tinhthanh;
            khachsan.MOTA = mota;
            khachsan.AVATAR = avatar;
            khachsan.GIAPHONGDON = giaphongdon;
            khachsan.GIAPHONGDOI = giaphongdoi;
            if(active == false)
            {
                khachsan.ACTIVE = false;
            }    
            else
            {
                khachsan.ACTIVE = true;
            }
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
