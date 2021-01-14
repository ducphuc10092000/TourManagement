using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using TourManagement.Model;
using TourManagement.Model.Staff;
using TourManagement.Model.Tour;
using TourManagement.Model.Trip;
using TourManagement.View.ManageTour.ManageHotel;
using TourManagement.View.ManageTrip;
using TourManagement.View.ManageTrip.ManageVehicle;
using TourManagement.View.ManageTrip.Trip_Staff;
using TourManagement.View.ManageTrip.Trip_Vehicle;
using TourManagement.ViewModel.ManageStaff;
using TourManagement.ViewModel.ManageTour;
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

        public ICommand QuitCommand { get; set; }

        private TRIP _SelectedTRIP;
        public TRIP SelectedTRIP { get => _SelectedTRIP; set { _SelectedTRIP = value; OnPropertyChanged(); } }

        #region COMMAND REPORT TOUR
        public ICommand ReportTourCommand { get; set; }
        public ICommand SelectTourCommand { get; set; }
        public ICommand ResetTourCommand { get; set; }
        #endregion
        #region TEXT REPORT TOUR
        private TOURs _SelectedTOURs;
        public TOURs SelectedTOURs { get => _SelectedTOURs; set { _SelectedTOURs = value; OnPropertyChanged(); } }

        private ObservableCollection<TRIP> _TRIPLISTDTG_REPORTTOUR;
        public ObservableCollection<TRIP> TRIPLISTDTG_REPORTTOUR { get => _TRIPLISTDTG_REPORTTOUR; set { _TRIPLISTDTG_REPORTTOUR = value; OnPropertyChanged(); } }

        private Nullable<DateTime> _TripStart_ReportTour_DT;
        public Nullable<DateTime> TripStart_ReportTour_DT { get => _TripStart_ReportTour_DT; set { _TripStart_ReportTour_DT = value; OnPropertyChanged(); } }

        private Nullable<DateTime> _TripStart_ReportTour_DT_1;
        public Nullable<DateTime> TripStart_ReportTour_DT_1 { get => _TripStart_ReportTour_DT_1; set { _TripStart_ReportTour_DT_1 = value; OnPropertyChanged(); } }

        private Nullable<DateTime> _TripEnd_ReportTour_DT;
        public Nullable<DateTime> TripEnd_ReportTour_DT { get => _TripEnd_ReportTour_DT; set { _TripEnd_ReportTour_DT = value; OnPropertyChanged(); } }

        private Nullable<DateTime> _TripEnd_ReportTour_DT_1;
        public Nullable<DateTime> TripEnd_ReportTour_DT_1 { get => _TripEnd_ReportTour_DT_1; set { _TripEnd_ReportTour_DT_1 = value; OnPropertyChanged(); } }
        private string _NumberOfTrip_ReportTour;
        public string NumberOfTrip_ReportTour { get => _NumberOfTrip_ReportTour; set { _NumberOfTrip_ReportTour = value; OnPropertyChanged(); } }
        private string _TotalSalesOfTrip_ReportTour;
        public string TotalSalesOfTrip_ReportTour { get => _TotalSalesOfTrip_ReportTour; set { _TotalSalesOfTrip_ReportTour = value; OnPropertyChanged(); } }
        #endregion

        #region COMMAND REPORT STAFF
        public ICommand ReportStaffCommand { get; set; }
        public ICommand SelectStaffCommand { get; set; }
        public ICommand ResetStaffCommand { get; set; }
        #endregion
        #region TEXT REPORT STAFF
        private ObservableCollection<TRIP> _TRIPLISTDTG_REPORTSTAFF;
        public ObservableCollection<TRIP> TRIPLISTDTG_REPORTSTAFF { get => _TRIPLISTDTG_REPORTSTAFF; set { _TRIPLISTDTG_REPORTSTAFF = value; OnPropertyChanged(); } }
        private STAFF _SelectedSTAFF;
        public STAFF SelectedSTAFF { get => _SelectedSTAFF; set { _SelectedSTAFF = value; OnPropertyChanged(); } }

        private Nullable<DateTime> _TripStart_ReportStaff_DT_1;
        public Nullable<DateTime> TripStart_ReportStaff_DT_1 { get => _TripStart_ReportStaff_DT_1; set { _TripStart_ReportStaff_DT_1 = value; OnPropertyChanged(); } }
        private Nullable<DateTime> _TripEnd_ReportStaff_DT_1;
        public Nullable<DateTime> TripEnd_ReportStaff_DT_1 { get => _TripEnd_ReportStaff_DT_1; set { _TripEnd_ReportStaff_DT_1 = value; OnPropertyChanged(); } }

        private Nullable<DateTime> _TripStart_ReportStaff_DT;
        public Nullable<DateTime> TripStart_ReportStaff_DT { get => _TripStart_ReportStaff_DT; set { _TripStart_ReportStaff_DT = value; OnPropertyChanged(); } }
        private Nullable<DateTime> _TripEnd_ReportStaff_DT;
        public Nullable<DateTime> TripEnd_ReportStaff_DT { get => _TripEnd_ReportStaff_DT; set { _TripEnd_ReportStaff_DT = value; OnPropertyChanged(); } }
        private string _NumberOfTrip_ReportStaff;
        public string NumberOfTrip_ReportStaff { get => _NumberOfTrip_ReportStaff; set { _NumberOfTrip_ReportStaff = value; OnPropertyChanged(); } }
        #endregion

        #region Declare Binding Command UC_MANAGETRIP
        public ICommand TripFindCommand { get; set; }
        public ICommand DefaultTripFindCommand { get; set; }
        public ICommand AddTripCommand { get; set; }
        public ICommand EditTripCommand { get; set; }
        #endregion

        #region Declare Binding Text UC_ManageTRIP
        private ObservableCollection<DOAN> _TRIPLIST;
        public ObservableCollection<DOAN> TRIPLIST { get => _TRIPLIST; set { _TRIPLIST = value; OnPropertyChanged(); } }

        private ObservableCollection<TRIP> _TRIPLISTDTG;
        public ObservableCollection<TRIP> TRIPLISTDTG { get => _TRIPLISTDTG; set { _TRIPLISTDTG = value; OnPropertyChanged(); } }
        private string _TripNameFind;
        public string TripNameFind { get => _TripNameFind; set { _TripNameFind = value; OnPropertyChanged(); } }
        
        #endregion
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

        #region Declare Binding COmmand WD_VehicleList
        public ICommand DoubleClickSelectVehicleCommand { get; set; }
        public ICommand Quit_WD_ManageVehicle_Command { get; set; }
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
                var wd_AddTrip_DT = wd_addtrip.DataContext as WD_AddTripViewModel;
                wd_AddTrip_DT.Reset();
                wd_addtrip.ShowDialog();
                wd_addtrip.Close();
                LoadTripList();
            });
            EditTripCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_EditTrip wd_edittrip = new WD_EditTrip();
                var wd_edittrip_DT = wd_edittrip.DataContext as WD_AddTripViewModel;
                wd_edittrip_DT.SelectedTRIP = SelectedTRIP;
                wd_edittrip_DT.SelectedIDDOAN = SelectedTRIP.doan.IDDOAN;
                wd_edittrip_DT.LoadEditTrip();
                wd_edittrip.ShowDialog();
                wd_edittrip.Close();
                LoadTripList();
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

            #region XỬ LÝ COMMAND WD_VEHICLELIST
            DoubleClickSelectVehicleCommand = new RelayCommand<Window>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                if (SelectedVEHICLE == null)
                {
                    p.Close();
                    return;
                }
                else
                {
                    p.Close();
                }
            });
            Quit_WD_ManageVehicle_Command = new RelayCommand<Window>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                p.Close();
            });
            #endregion

            #region COMMAND REPORT
            #region REPORT TOUR
            ResetTourCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                ResetTourReport();
            });
            SelectTourCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                WD_TourList wd_TourList = new WD_TourList();
                var wd_TourList_DT = wd_TourList.DataContext as UC_ManageTourViewModel;
                wd_TourList_DT.LoadTourList();
                wd_TourList.ShowDialog();
                if (wd_TourList_DT.SelectedTOURs == null)
                {
                    return;
                }
                else
                {
                    SelectedTOURs = wd_TourList_DT.SelectedTOURs;
                    wd_TourList.Close();
                }
            });
            ReportTourCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                if(SelectedTOURs == null)
                {
                    MessageBox.Show("Bạn chưa chọn TOUR để thống kê! Bấm vào chọn TOUR để chọn", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (TripStart_ReportTour_DT > TripEnd_ReportTour_DT)
                {
                    MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc! Vui lòng chọn lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    TripEnd_ReportTour_DT = TripStart_ReportTour_DT;
                    return;
                }

                LoadTripListReportTour();
            });
            #endregion

            #region REPORT STAFF
            ResetStaffCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                ResetStaffReport();
            });
            SelectStaffCommand = new RelayCommand<WD_AddTrip>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                WD_StaffList wd_StaffList = new WD_StaffList();
                var wd_StaffList_DT = wd_StaffList.DataContext as UC_ManageStaffViewModel;
                wd_StaffList.ShowDialog();
                SelectedSTAFF = wd_StaffList_DT.SelectedSTAFF;
                wd_StaffList.Close();
            });
            ReportStaffCommand = new RelayCommand<WD_AddTrip>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                if(SelectedSTAFF == null)
                {
                    MessageBox.Show("Bạn chưa chọn nhân viên để thống kê! Bấm vào chọn TOUR để chọn", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }    
                if (TripStart_ReportStaff_DT > TripEnd_ReportStaff_DT)
                {
                    MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc! Vui lòng chọn lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    TripEnd_ReportTour_DT = TripStart_ReportTour_DT;
                    return;
                }

                LoadTripListReportStaff();
            });
            #endregion
            #endregion
            QuitCommand = new RelayCommand<Window>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                    p.Close();
            });
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
                if(item.BELONGTOCOMPANY == true)
                {
                    temp.BELONGTOCOMPANY = "Công ty";
                }    
                else
                {
                    temp.BELONGTOCOMPANY = "Thuê ngoài";
                }
                VEHICLELISTDTG.Add(temp);
            }    
        }
        #endregion

        #region Function ManageTRIP
        public void LoadTripList()
        {
            TRIPLIST = new ObservableCollection<DOAN>(DataProvider.Ins.DB.DOAN);
            TRIPLISTDTG = new ObservableCollection<TRIP>();

            foreach (var item in TRIPLIST)
            {
                TRIP temp = new TRIP();
                temp.doan = item;
                TRIPLISTDTG.Add(temp);
            }
        }
        #endregion

        #region Function REPORT
        public void LoadTripListReportTour()
        { 
            int tempcost = new int();
            tempcost = 0;
            TRIPLIST = new ObservableCollection<DOAN>();
            TRIPLIST = new ObservableCollection<DOAN>(DataProvider.Ins.DB.DOAN.Where(x=>x.IDTOUR == SelectedTOURs.tour.IDTOUR));
            TRIPLISTDTG_REPORTTOUR = new ObservableCollection<TRIP>();
            
            if (TRIPLIST.Count() == 0)
            {
                MessageBox.Show("Không có đoàn du lịch nào ứng với TOUR này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                NumberOfTrip_ReportTour = 0.ToString();
                TotalSalesOfTrip_ReportTour = 0.ToString();
            }    

            else
            {
                foreach (var item in TRIPLIST)
                {
                    TripStart_ReportTour_DT_1 = Convert.ToDateTime(item.NGAYBATDAU);
                    TripEnd_ReportTour_DT_1 = Convert.ToDateTime(item.NGAYKETTHUC);

                    if (TripStart_ReportTour_DT_1 >= TripStart_ReportTour_DT && TripEnd_ReportTour_DT_1 <= TripEnd_ReportTour_DT)
                    {
                        TRIP temp = new TRIP();
                        temp.doan = item;
                        TRIPLISTDTG_REPORTTOUR.Add(temp);
                        tempcost += Convert.ToInt32(temp.doan.DOANHTHU);
                    }
                }
                if(TRIPLISTDTG_REPORTTOUR.Count() == 0)
                {
                    MessageBox.Show("Không có đoàn du lịch của tour này trong thời gian đã chọn!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    NumberOfTrip_ReportTour = 0.ToString();
                    TotalSalesOfTrip_ReportTour = 0.ToString();
                    return;
                }    
                NumberOfTrip_ReportTour = TRIPLISTDTG_REPORTTOUR.Count().ToString();
                TotalSalesOfTrip_ReportTour = tempcost.ToString();
            }    

        }

        public void LoadTripListReportStaff()
        {

            int tempcost = new int();
            tempcost = 0;
            TRIPLIST = new ObservableCollection<DOAN>(DataProvider.Ins.DB.DOAN.Where(x=>x.CT_DOAN_NHANVIEN.Where(y=>y.IDNV == SelectedSTAFF.nhanvien.IDNV).Count() != 0));
            TRIPLISTDTG_REPORTSTAFF = new ObservableCollection<TRIP>();
            if (TRIPLIST.Count() ==  0)
            {
                MessageBox.Show("Nhân viên này chưa đi TOUR nào!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                NumberOfTrip_ReportStaff = 0.ToString();
                return;
            }
            else
            {
                foreach (var item in TRIPLIST)
                {
                    TripStart_ReportStaff_DT_1 = Convert.ToDateTime(item.NGAYBATDAU);
                    TripEnd_ReportStaff_DT_1 = Convert.ToDateTime(item.NGAYKETTHUC);

                    if (TripStart_ReportStaff_DT_1 >= TripStart_ReportStaff_DT && TripEnd_ReportStaff_DT_1 <= TripEnd_ReportStaff_DT)
                    {
                        TRIP temp = new TRIP();
                        temp.doan = item;
                        TRIPLISTDTG_REPORTSTAFF.Add(temp);
                    }
                }
                if (TRIPLISTDTG_REPORTSTAFF.Count() == 0)
                {
                    MessageBox.Show("Không có đoàn du lịch của nhân viên này trong thời gian đã chọn!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    NumberOfTrip_ReportStaff = 0.ToString();
                    return;
                }
                NumberOfTrip_ReportStaff = TRIPLISTDTG_REPORTSTAFF.Count().ToString();
            }
        }
        public void LoadTimeReport()
        {
            TripStart_ReportTour_DT = DateTime.Today;
            TripEnd_ReportTour_DT = DateTime.Today;
            TripStart_ReportStaff_DT = DateTime.Today;
            TripEnd_ReportStaff_DT = DateTime.Today;
        }

        public void ResetReport()
        {
            SelectedTOURs = null;
            SelectedSTAFF = null;
            TRIPLISTDTG_REPORTTOUR = new ObservableCollection<TRIP>();
            TRIPLISTDTG_REPORTSTAFF = new ObservableCollection<TRIP>();
        }
        public void ResetTourReport()
        {
            TripStart_ReportTour_DT = DateTime.Today;
            TripEnd_ReportTour_DT = DateTime.Today;
            SelectedTOURs = null;
            TRIPLISTDTG_REPORTTOUR = new ObservableCollection<TRIP>();
            NumberOfTrip_ReportTour = null;
            TotalSalesOfTrip_ReportTour = null;
        }

        public void ResetStaffReport()
        {
            NumberOfTrip_ReportStaff = null;
            SelectedSTAFF = null;
            TRIPLISTDTG_REPORTSTAFF = new ObservableCollection<TRIP>();
            TripStart_ReportStaff_DT = DateTime.Today;
            TripEnd_ReportStaff_DT = DateTime.Today;
        }
        #endregion
    }
}
