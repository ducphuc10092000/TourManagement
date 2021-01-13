using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TourManagement.ViewModel;

namespace TourManagement.Model.Tour
{
    public class TOURs : BaseViewModel
    {
       
        public TOUR tour { get; set; }

        private ObservableCollection<PLACE> _PLACELIST;
        public ObservableCollection<PLACE> PLACELIST { get => _PLACELIST; set { _PLACELIST = value; OnPropertyChanged(); } }

        private string _STATUS;
        public string STATUS { get => _STATUS; set { _STATUS = value; OnPropertyChanged(); } }

        public TOURs()
        {

        }
        public void AddNewTour(string tentour, string giatour, string loaihinh, string mota, ObservableCollection<PLACE> placelist)
        {
                tour = new TOUR();
                tour.TENTOUR = tentour;
                tour.GIATOUR = giatour;
                tour.LOAIHINH = loaihinh;
                tour.MOTA = mota;
                tour.ACTIVE = true;
                DataProvider.Ins.DB.TOUR.Add(tour);
                DataProvider.Ins.DB.SaveChanges();
                foreach (var item in placelist)
                {
                    PLACE_TOUR_DETAIL place_tour_detail = new PLACE_TOUR_DETAIL();
                    place_tour_detail.AddNewPlace_Tour_Detail(tour.IDTOUR, item.diadiem.IDDIADIEM);
                }
        }
        public void EditTour(int idtour, string tentour, string giatour, string loaihinh, string mota, ObservableCollection<PLACE> placelist)
        {
            tour = DataProvider.Ins.DB.TOUR.Where(x => x.IDTOUR == idtour).SingleOrDefault();
            tour.TENTOUR = tentour;
            tour.GIATOUR = giatour;
            tour.LOAIHINH = loaihinh;
            tour.MOTA = mota;
            tour.ACTIVE = true;
            DataProvider.Ins.DB.SaveChanges();

            //Xoá chi tiết địa điểm cũ
            ObservableCollection<CT_DIADIEM_TOUR> TOUR_PLACE_DETAIL = new ObservableCollection<CT_DIADIEM_TOUR>(DataProvider.Ins.DB.CT_DIADIEM_TOUR.Where(x => x.IDTOUR == tour.IDTOUR));

            foreach (var item in TOUR_PLACE_DETAIL)
            {
                DataProvider.Ins.DB.CT_DIADIEM_TOUR.Remove(item);
            }
            foreach (var item in placelist)
            {
                PLACE_TOUR_DETAIL place_tour_detail = new PLACE_TOUR_DETAIL();
                place_tour_detail.AddNewPlace_Tour_Detail(tour.IDTOUR, item.diadiem.IDDIADIEM);
            }
        }
    }
    
}
