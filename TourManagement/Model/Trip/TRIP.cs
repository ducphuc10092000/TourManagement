using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.Model.Customer;
using TourManagement.Model.Staff;
using TourManagement.Model.Tour;
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

        public void AddNewTrip(string tendoan, int idtour, int slkh, int slpt, string ngaybd, string ngaykt,string mota, string tongchiphi, string doanhthu, ObservableCollection<CUSTOMER> customerlist, ObservableCollection<STAFF> stafflist, ObservableCollection<HOTEL> hotellist, ObservableCollection<VEHICLE> vehiclelist, ObservableCollection<EATING> eatinglist, ObservableCollection<OTHERCOST> othercostlist)
        {
            doan = new DOAN();
            doan.TENDOAN = tendoan;
            doan.IDTOUR = idtour;
            doan.SOLUONGKH = slkh;
            doan.SOLUONGPT = slpt;
            doan.NGAYBATDAU = ngaybd;
            doan.NGAYKETTHUC = ngaykt;
            doan.MOTA = mota;
            doan.TONGCHIPHI = tongchiphi;
            doan.DOANHTHU = doanhthu;
            DataProvider.Ins.DB.DOAN.Add(doan);
            DataProvider.Ins.DB.SaveChanges();

            if(customerlist != null)
            {
                foreach (var item in customerlist)
                {
                    CUSTOMER_TRIP_DETAIL customer_list_detail = new CUSTOMER_TRIP_DETAIL();
                    customer_list_detail.AddNewCustomer_Trip_Detail(doan.IDDOAN, item.khachhang.IDKH);
                }
            }    
            if(stafflist != null)
            {
                foreach(var item in stafflist)
                {
                    STAFF_TRIP_DETAIL staff_list_detail = new STAFF_TRIP_DETAIL();
                    staff_list_detail.AddNewStaff_Trip_Detail(doan.IDDOAN, item.nhanvien.IDNV,item.NHIEMVU);
                }    
            }    
            if(hotellist != null)
            {
                foreach (var item in hotellist)
                {
                    HOTEL_TRIP_DETAIL hotel_list_detail = new HOTEL_TRIP_DETAIL();
                    hotel_list_detail.AddNewHotel_Trip_Detail(doan.IDDOAN, item.khachsan.IDKS,item.TONGCHIPHI);
                }
            }    
            if(eatinglist != null)
            {
                foreach(var item in eatinglist)
                {
                    EATING_TRIP_DETAIL eating_trip_detail = new EATING_TRIP_DETAIL();
                    eating_trip_detail.AddNewEating_Trip_Detail(doan.IDDOAN,item.CHIPHIBUAAN,item.MOTA);
                }    
            }    
            if(othercostlist != null)
            {
                foreach (var item in othercostlist)
                {
                    OTHERCOST_TRIP_DETAIL othercost_trip_detail = new OTHERCOST_TRIP_DETAIL();
                    othercost_trip_detail.AddNewOtherCost_Trip_Detail(doan.IDDOAN, item.CHIPHI, item.MOTA);
                }
            }
            if(vehiclelist != null) 
            {
                foreach (var item in vehiclelist)
                {
                    VEHICLE_TRIP_DETAIL vehicle_trip_detail = new VEHICLE_TRIP_DETAIL();
                    vehicle_trip_detail.AddNewVehicle_Trip_Detail(doan.IDDOAN, item.phuongtien.IDPT, item.phuongtien.GIATHUE);
                }
            }    
        }

        public void EditTrip(int iddoan, string tendoan, int idtour, int slkh, int slpt, string ngaybd, string ngaykt, string mota, string tongchiphi, string doanhthu, ObservableCollection<CUSTOMER> customerlist, ObservableCollection<STAFF> stafflist, ObservableCollection<HOTEL> hotellist, ObservableCollection<VEHICLE> vehiclelist, ObservableCollection<EATING> eatinglist, ObservableCollection<OTHERCOST> othercostlist)
        {
            doan = DataProvider.Ins.DB.DOAN.Where(x => x.IDDOAN == iddoan).SingleOrDefault();
            doan.TENDOAN = tendoan;
            doan.IDTOUR = idtour;
            doan.SOLUONGKH = slkh;
            doan.SOLUONGPT = slpt;
            doan.NGAYBATDAU = ngaybd;
            doan.NGAYKETTHUC = ngaykt;
            doan.MOTA = mota;
            doan.TONGCHIPHI = tongchiphi;
            doan.DOANHTHU = doanhthu;
            DataProvider.Ins.DB.SaveChanges();

            if (customerlist != null)
            {
                //Xoá chi tiết địa điểm cũ
                ObservableCollection<CT_DOAN_KHACHHANG> TRIP_CUSTOMER_DETAIL = new ObservableCollection<CT_DOAN_KHACHHANG>(DataProvider.Ins.DB.CT_DOAN_KHACHHANG.Where(x => x.IDDOAN == iddoan));

                foreach (var item in TRIP_CUSTOMER_DETAIL)
                {
                    DataProvider.Ins.DB.CT_DOAN_KHACHHANG.Remove(item);
                    DataProvider.Ins.DB.SaveChanges();
                }

                foreach (var item in customerlist)
                {
                    CUSTOMER_TRIP_DETAIL customer_list_detail = new CUSTOMER_TRIP_DETAIL();
                    customer_list_detail.AddNewCustomer_Trip_Detail(doan.IDDOAN, item.khachhang.IDKH);
                }
            }
            if (stafflist != null)
            {
                //Xoá chi tiết địa điểm cũ
                ObservableCollection<CT_DOAN_NHANVIEN> TRIP_STAFF_DETAIL = new ObservableCollection<CT_DOAN_NHANVIEN>(DataProvider.Ins.DB.CT_DOAN_NHANVIEN.Where(x => x.IDDOAN == iddoan));

                foreach (var item in TRIP_STAFF_DETAIL)
                {
                    DataProvider.Ins.DB.CT_DOAN_NHANVIEN.Remove(item);
                    DataProvider.Ins.DB.SaveChanges();
                }

                foreach (var item in stafflist)
                {
                    STAFF_TRIP_DETAIL staff_list_detail = new STAFF_TRIP_DETAIL();
                    staff_list_detail.AddNewStaff_Trip_Detail(doan.IDDOAN, item.nhanvien.IDNV, item.NHIEMVU);
                }
            }
            if (hotellist != null)
            {
                //Xoá chi tiết cũ
                ObservableCollection<CT_DOAN_KHACHSAN> TRIP_HOTEL_DETAIL = new ObservableCollection<CT_DOAN_KHACHSAN>(DataProvider.Ins.DB.CT_DOAN_KHACHSAN.Where(x => x.IDDOAN == iddoan));

                foreach (var item in TRIP_HOTEL_DETAIL)
                {
                    DataProvider.Ins.DB.CT_DOAN_KHACHSAN.Remove(item);
                    DataProvider.Ins.DB.SaveChanges();
                }

                foreach (var item in hotellist)
                {
                    HOTEL_TRIP_DETAIL hotel_list_detail = new HOTEL_TRIP_DETAIL();
                    hotel_list_detail.AddNewHotel_Trip_Detail(doan.IDDOAN, item.khachsan.IDKS, item.TONGCHIPHI);
                }
            }
            if (eatinglist != null)
            {
                //Xoá chi tiết cũ
                ObservableCollection<CT_DOAN_BUAAN> TRIP_EATING_DETAIL = new ObservableCollection<CT_DOAN_BUAAN>(DataProvider.Ins.DB.CT_DOAN_BUAAN.Where(x => x.IDDOAN == iddoan));

                foreach (var item in TRIP_EATING_DETAIL)
                {
                    DataProvider.Ins.DB.CT_DOAN_BUAAN.Remove(item);
                    DataProvider.Ins.DB.SaveChanges();
                }

                foreach (var item in eatinglist)
                {
                    EATING_TRIP_DETAIL eating_trip_detail = new EATING_TRIP_DETAIL();
                    eating_trip_detail.AddNewEating_Trip_Detail(doan.IDDOAN, item.CHIPHIBUAAN, item.MOTA);
                }
            }
            if (othercostlist != null)
            {
                //Xoá chi tiết cũ
                ObservableCollection<CT_DOAN_CHIPHIKHAC> TRIP_OTHERCOST_DETAIL = new ObservableCollection<CT_DOAN_CHIPHIKHAC>(DataProvider.Ins.DB.CT_DOAN_CHIPHIKHAC.Where(x => x.IDDOAN == iddoan));

                foreach (var item in TRIP_OTHERCOST_DETAIL)
                {
                    DataProvider.Ins.DB.CT_DOAN_CHIPHIKHAC.Remove(item);
                    DataProvider.Ins.DB.SaveChanges();
                }
                foreach (var item in othercostlist)
                {
                    OTHERCOST_TRIP_DETAIL othercost_trip_detail = new OTHERCOST_TRIP_DETAIL();
                    othercost_trip_detail.AddNewOtherCost_Trip_Detail(doan.IDDOAN, item.CHIPHI, item.MOTA);
                }
            }
            if (vehiclelist != null)
            {
                //Xoá chi tiết cũ
                ObservableCollection<CT_DOAN_PHUONGTIEN> TRIP_VEHICLE_DETAIL = new ObservableCollection<CT_DOAN_PHUONGTIEN>(DataProvider.Ins.DB.CT_DOAN_PHUONGTIEN.Where(x => x.IDDOAN == iddoan));

                foreach (var item in TRIP_VEHICLE_DETAIL)
                {
                    DataProvider.Ins.DB.CT_DOAN_PHUONGTIEN.Remove(item);
                    DataProvider.Ins.DB.SaveChanges();
                }
                foreach (var item in vehiclelist)
                {
                    VEHICLE_TRIP_DETAIL vehicle_trip_detail = new VEHICLE_TRIP_DETAIL();
                    vehicle_trip_detail.AddNewVehicle_Trip_Detail(doan.IDDOAN, item.phuongtien.IDPT, item.phuongtien.GIATHUE);
                }
            }
        }
    }
}
