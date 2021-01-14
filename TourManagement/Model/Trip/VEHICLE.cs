using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Trip
{
    public class VEHICLE : BaseViewModel
    {
        public PHUONGTIEN phuongtien { get; set; }

        private string _STATUS;
        public string STATUS { get => _STATUS; set { _STATUS = value; OnPropertyChanged(); } }

        private string _BELONGTOCOMPANY;
        public string BELONGTOCOMPANY { get => _BELONGTOCOMPANY; set { _BELONGTOCOMPANY = value; OnPropertyChanged(); } }

        public VEHICLE()
        {

        }

        public void AddNewVehicle(string loaiPT, int soghe, string bks,bool isbelongtocompany, string giathue)
        {
            phuongtien  = new PHUONGTIEN();
            phuongtien.LOAIPT = loaiPT;
            phuongtien.SOGHE = soghe;
            phuongtien.BKS = bks;
            phuongtien.ACTIVE = true;
            phuongtien.ISAVAILABLE = true;
            phuongtien.BELONGTOCOMPANY = isbelongtocompany;
            phuongtien.GIATHUE = giathue;    
            DataProvider.Ins.DB.PHUONGTIEN.Add(phuongtien);
            DataProvider.Ins.DB.SaveChanges();
        }
        public void EditVehicle(int idpt, string loaiPT, int soghe, string bks)
        {
            phuongtien = DataProvider.Ins.DB.PHUONGTIEN.Where(x => x.IDPT == idpt).SingleOrDefault();
            phuongtien.LOAIPT = loaiPT;
            phuongtien.SOGHE = soghe;
            phuongtien.BKS = bks;
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
