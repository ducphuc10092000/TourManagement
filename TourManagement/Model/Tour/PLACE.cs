using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TourManagement.ViewModel;

namespace TourManagement.Model.Tour
{
    public class PLACE : BaseViewModel
    {
        private string _TRANGTHAI;
        public string TRANGTHAI { get => _TRANGTHAI; set { _TRANGTHAI = value; OnPropertyChanged(); } }

        public DIADIEM diadiem { get; set; }

        public PLACE()
        {

        }

        public void AddNewPlace(string placename,string placedescription,string provincename,string avatar)
        {
            diadiem = new DIADIEM();
            diadiem.TENDIADIEM = placename;
            diadiem.MOTA = placedescription;
            diadiem.TINHTHANH = provincename;
            diadiem.ACTIVE = true;
            diadiem.AVATAR = avatar;
            DataProvider.Ins.DB.DIADIEM.Add(diadiem);
            DataProvider.Ins.DB.SaveChanges();
        }

        public void EditPlace(int IDPLACE,string placename,string placedescription, string provincename,string avatar,bool ischecked)
        {
            diadiem = DataProvider.Ins.DB.DIADIEM.Where(x => x.IDDIADIEM == IDPLACE).Single();
            diadiem.TENDIADIEM = placename;
            diadiem.MOTA = placedescription;
            diadiem.TINHTHANH = provincename;
            diadiem.AVATAR = avatar;
            if(ischecked == true)
            {
                diadiem.ACTIVE = true;
            }    
            else
            {
                diadiem.ACTIVE = false;
            }    
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
