using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using TourManagement.Model;
using TourManagement.Model.Tour;
using TourManagement.Model.Trip;
using TourManagement.View.ManageTour.ManageHotel;
using TourManagement.View.ManageTrip;
using TourManagement.View.ManageTrip.ManageVehicle;
using TourManagement.ViewModel.ManageTour.ManageHotel;
using TourManagement.ViewModel.ManageTrip.ManageVehicle;

namespace TourManagement.ViewModel.ManageTrip
{
    public class UC_ManageTripViewModel : BaseViewModel
    {
        #region Chức năng và command Button chuyển grid
        public enum CHUCNANG
        {
            ManageTrip, ManageHotel, ManageVehicle
        }
        private int _ChucNang;
        public int ChucNang { get => _ChucNang; set { _ChucNang = value; OnPropertyChanged(); } }
        public ICommand BtnManageHotelCommand { get; set; }
        public ICommand BtnManageVehicleCommand { get; set; }
        #endregion

        public ICommand AddTripCommand { get; set; }


        #region Declare Binding Command UC_ManageHotel
        public ICommand Quit_UC_ManageHotelComand { get; set; }
        public ICommand FindHotelCommand { get; set; }
        public ICommand DefaultFindHotelCommand { get; set; }
        public ICommand AddHotelCommand { get; set; }
        public ICommand EditHotelCommand { get; set; }
        #endregion

        #region Declare Binding Text UC_ManageHotel
        //List Hotel
        private ObservableCollection<KHACHSAN> _HOTELLIST;
        public ObservableCollection<KHACHSAN> HOTELLIST { get => _HOTELLIST; set { _HOTELLIST = value; OnPropertyChanged(); } }

        private ObservableCollection<HOTEL> _HOTELLISTDTG;
        public ObservableCollection<HOTEL> HOTELLISTDTG { get => _HOTELLISTDTG; set { _HOTELLISTDTG = value; OnPropertyChanged(); } }

        private string _HotelNameFind;
        public string HotelNameFind { get => _HotelNameFind; set { _HotelNameFind = value; OnPropertyChanged(); } }
        private string _ProvinceNameHotelFind
;
        public string ProvinceNameHotelFind { get => _ProvinceNameHotelFind; set { _ProvinceNameHotelFind = value; OnPropertyChanged(); } }
        #endregion

        #region Declare Binding Command UC_ManageVehicle
        public ICommand Quit_UC_ManageVehicle_Command { get; set; }
        public ICommand AddVehicleCommand { get; set; }
        public ICommand EditVehicleCommand { get; set; }
        #endregion

        #region Declare Binding Text UC_ManageVehicle
        
        private VEHICLE _SelectedVEHICLE;
        public VEHICLE SelectedVEHICLE { get => _SelectedVEHICLE; set { _SelectedVEHICLE = value; OnPropertyChanged(); } }

        private ObservableCollection<PHUONGTIEN> _VEHICLELIST;
        public ObservableCollection<PHUONGTIEN> VEHICLELIST { get => _VEHICLELIST; set { _VEHICLELIST = value; OnPropertyChanged(); } }

        private ObservableCollection<VEHICLE> _VEHICLELISTDTG;
        public ObservableCollection<VEHICLE> VEHICLELISTDTG { get => _VEHICLELISTDTG; set { _VEHICLELISTDTG = value; OnPropertyChanged(); } }
        #endregion

        #region Declare Binding Command WDHotelList
        public ICommand DoubleClickSelectHotelCommand { get; set; }
        #endregion

        #region Declare Binding Text WD_HotelList
        private HOTEL _SelectedHOTEL;
        public HOTEL SelectedHOTEL { get => _SelectedHOTEL; set { _SelectedHOTEL = value; OnPropertyChanged(); } }

        private ObservableCollection<TINHTHANH> _PROVINCELIST;
        public ObservableCollection<TINHTHANH> PROVINCELIST { get => _PROVINCELIST; set { _PROVINCELIST = value; OnPropertyChanged(); } }

        private ObservableCollection<string> _ProvinceNameList;
        public ObservableCollection<string> ProvinceNameList { get => _ProvinceNameList; set { _ProvinceNameList = value; OnPropertyChanged(); } }

        #endregion

        public UC_ManageTripViewModel()
        {
            #region HANDLING COMMAND MANAGETRIP
            BtnManageHotelCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ChucNang = (int)CHUCNANG.ManageHotel;
                LoadHotelList();
            });
            BtnManageVehicleCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ChucNang = (int)CHUCNANG.ManageVehicle;
                LoadVehicleList();
            });
            AddTripCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_AddTrip wd_addtrip = new WD_AddTrip();
                wd_addtrip.ShowDialog();
                wd_addtrip.Close();
            });
            #endregion

            #region XỬ LÝ COMMAND QUẢN LÝ KHÁCH SẠN - MANAGE HOTEL
            AddHotelCommand = new RelayCommand<WD_AddHotel>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_AddHotel addhotel = new WD_AddHotel();
                var addhotellDT = addhotel.DataContext as WD_AddHotelViewModel;
                addhotellDT.Reset();
                addhotellDT.LoadProvinceList();
                addhotel.ShowDialog();
                addhotel.Close();
                LoadHotelList();
            });
            EditHotelCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_EditHotel edithotel = new WD_EditHotel();
                var edithotellDT = edithotel.DataContext as WD_EditHotelViewModel;
                edithotellDT.SelectedIDHotel = (int)p;
                edithotellDT.LoadProvinceList();
                edithotellDT.LoadEditHotel();
                edithotel.ShowDialog();
                edithotel.Close();
                LoadHotelList();
            });
            FindHotelCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                FilterHotel();
            });
            DefaultFindHotelCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ResetFilterHotel();
            });
            Quit_UC_ManageHotelComand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ChucNang = (int)CHUCNANG.ManageTrip;
            });
            #endregion

            #region XỬ LÝ COMMAND WD_HOTELLIST
            DoubleClickSelectHotelCommand = new RelayCommand<WD_HotelList>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                if (SelectedHOTEL == null)
                {
                    p.Close();
                    return;
                }
                else
                {
                    p.Close();
                }
            });
            #endregion

            #region XỬ LÝ COMMAND QUẢN LÝ PHƯƠNG TIỆN - MANAGE VEHICLE
            Quit_UC_ManageVehicle_Command = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ChucNang = (int)CHUCNANG.ManageTrip;
            });

            AddVehicleCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_AddVehicle wd_AddVehicle = new WD_AddVehicle();
                wd_AddVehicle.ShowDialog();
                wd_AddVehicle.Close();
                LoadVehicleList();
            });
            EditVehicleCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_EditVehicle wd_EditVehicle = new WD_EditVehicle();
                var wd_EditVehicle_DT = wd_EditVehicle.DataContext as WD_AddVehicleViewModel;
                wd_EditVehicle_DT.SelectedVEHICLE = SelectedVEHICLE;
                wd_EditVehicle_DT.LoadEditVehicle();
                wd_EditVehicle.ShowDialog();
                wd_EditVehicle.Close();
                LoadVehicleList();
            });
            #endregion
        }
        #region Function ManageHotel
        public void LoadHotelList()
        {
            HOTELLIST = new ObservableCollection<KHACHSAN>(DataProvider.Ins.DB.KHACHSAN);
            HOTELLISTDTG = new ObservableCollection<HOTEL>();
            foreach (var item in HOTELLIST)
            {
                HOTEL temp = new HOTEL();
                temp.khachsan = item;
                if (item.ACTIVE == true)
                {

                    temp.TRANGTHAI = "Hoạt động";
                }
                else
                {
                    temp.TRANGTHAI = "Không hoạt động";
                }
                HOTELLISTDTG.Add(temp);
            }
            LoadProvinceList();
        }
        public void ResetFilterHotel()
        {
            HotelNameFind = null;
            ProvinceNameHotelFind = null;
            CollectionViewSource.GetDefaultView(HOTELLISTDTG).Filter = (all) => { return true; };
        }
        public void FilterHotel()
        {
            if (string.IsNullOrEmpty(HotelNameFind) && string.IsNullOrEmpty(ProvinceNameHotelFind))
            {
                CollectionViewSource.GetDefaultView(HOTELLISTDTG).Filter = (all) => { return true; };
            }
            else if (string.IsNullOrEmpty(ProvinceNameHotelFind))
            {
                CollectionViewSource.GetDefaultView(HOTELLISTDTG).Filter = (hotelfind) =>
                {
                    return (hotelfind as HOTEL).khachsan.TENKS.IndexOf(HotelNameFind, StringComparison.OrdinalIgnoreCase) >= 0;
                };
            }
            else if (string.IsNullOrEmpty(HotelNameFind))
            {
                CollectionViewSource.GetDefaultView(HOTELLISTDTG).Filter = (hotelfind) =>
                {
                    return (hotelfind as HOTEL).khachsan.TINHTHANH.IndexOf(ProvinceNameHotelFind, StringComparison.OrdinalIgnoreCase) >= 0;
                };
            }
            else
            {
                CollectionViewSource.GetDefaultView(HOTELLISTDTG).Filter = (hotelfind) =>
                {
                    return (hotelfind as HOTEL).khachsan.TINHTHANH.IndexOf(ProvinceNameHotelFind, StringComparison.OrdinalIgnoreCase) >= 0 &&
                           (hotelfind as HOTEL).khachsan.TENKS.IndexOf(HotelNameFind, StringComparison.OrdinalIgnoreCase) >= 0;
                };
            }
        }
        public void LoadProvinceList()
        {
            PROVINCELIST = new ObservableCollection<TINHTHANH>(DataProvider.Ins.DB.TINHTHANH);
            ProvinceNameList = new ObservableCollection<string>();
            foreach (var item in PROVINCELIST)
            {
                ProvinceNameList.Add(item.TENTT);
            }
            ProvinceNameList = new ObservableCollection<string>(ProvinceNameList.OrderBy(x => x));
        }
        #endregion

        #region Function ManageVehicle
        public void LoadVehicleList()
        {
            VEHICLELIST = new ObservableCollection<PHUONGTIEN>(DataProvider.Ins.DB.PHUONGTIEN);
            VEHICLELISTDTG = new ObservableCollection<VEHICLE>();

            foreach(var item in VEHICLELIST)
            {
                VEHICLE temp = new VEHICLE();
                temp.phuongtien = item;
                if(item.ISAVAILABLE == true)
                {
                    temp.STATUS = "Chưa được sử dụng";
                }    
                else
                {
                    temp.STATUS = "Đang được sử dụng";
                }
                VEHICLELISTDTG.Add(temp);
            }    
        }
        #endregion
    }
}
