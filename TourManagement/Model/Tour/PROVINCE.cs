using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TourManagement.ViewModel;

namespace TourManagement.Model.Tour
{
    public class PROVINCE : BaseViewModel
    {
        public TINHTHANH tinhthanh { get; set; }

        public PROVINCE()
        {

        }
        public void AddNewProvince(string tentinhthanh)
        {
            tinhthanh = new TINHTHANH();
            tinhthanh.TENTT = tentinhthanh;
            DataProvider.Ins.DB.TINHTHANH.Add(tinhthanh);
            DataProvider.Ins.DB.SaveChanges();
        }

        public void EditProvince(string tentinhthanh, int idtinhthanh)
        {
            tinhthanh = DataProvider.Ins.DB.TINHTHANH.Where(x => x.IDTT == idtinhthanh).SingleOrDefault();
            tinhthanh.TENTT = tentinhthanh;
            DataProvider.Ins.DB.SaveChanges();
        }    
    }
}
