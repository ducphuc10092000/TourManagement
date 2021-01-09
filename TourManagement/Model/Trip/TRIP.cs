using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.ViewModel;

namespace TourManagement.Model.Trip
{
    public class TRIP : BaseViewModel
    {
        public DOAN doan { get; set; }
        private string _STATUS;

        public string STATUS
        {
            get { return _STATUS; }
            set { _STATUS = value; OnPropertyChanged(); }
        }


        public TRIP()
        {

        }

        public void AddNewTrip(string tendoan, int idtour, int slkh, int slpt, string ngaybd, string ngaykt)
        {
            doan = new DOAN();
            doan.TENDOAN = tendoan;
            doan.IDTOUR = idtour;
            doan.SOLUONGKH = slkh;
            doan.SOLUONGPT = slpt;
            doan.NGAYBATDAU = ngaybd;
            doan.NGAYKETTHUC = ngaykt;
            
        }

        public void EditTrip()
        {
            doan = new DOAN();
        }
    }
}
