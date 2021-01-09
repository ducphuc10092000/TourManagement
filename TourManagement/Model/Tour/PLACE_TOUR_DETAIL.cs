using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Tour
{
    public class PLACE_TOUR_DETAIL : BaseViewModel
    {
        public CT_DIADIEM_TOUR ct_diadiem_tour { get; set; }

        public PLACE_TOUR_DETAIL()
        {

        }

        public virtual void AddNewPlace_Tour_Detail(int idtour, int iddiadiem)
        {
            ct_diadiem_tour = new CT_DIADIEM_TOUR();
            ct_diadiem_tour.IDTOUR = idtour;
            ct_diadiem_tour.IDDIADIEM = iddiadiem;
            ct_diadiem_tour.ACTIVE = true;
            ct_diadiem_tour.DIADIEM = DataProvider.Ins.DB.DIADIEM.Where(x => x.IDDIADIEM == iddiadiem).SingleOrDefault();
            ct_diadiem_tour.TOUR = DataProvider.Ins.DB.TOUR.Where(x => x.IDTOUR == idtour).SingleOrDefault();
            DataProvider.Ins.DB.CT_DIADIEM_TOUR.Add(ct_diadiem_tour);
            DataProvider.Ins.DB.SaveChanges();
        }
    }
}
