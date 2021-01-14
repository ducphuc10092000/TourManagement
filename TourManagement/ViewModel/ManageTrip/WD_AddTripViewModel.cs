using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TourManagement.Model;
using TourManagement.Model.Customer;
using TourManagement.Model.Staff;
using TourManagement.Model.Tour;
using TourManagement.Model.Trip;
using TourManagement.View.ManageTrip;
using TourManagement.View.ManageTrip.Trip_EatingCost;
using TourManagement.View.ManageTrip.Trip_Hotel;
using TourManagement.View.ManageTrip.Trip_OtherCost;
using TourManagement.View.ManageTrip.Trip_Staff;
using TourManagement.View.ManageTrip.Trip_Vehicle;
using TourManagement.ViewModel.ManageCustomer;
using TourManagement.ViewModel.ManageStaff;
using TourManagement.ViewModel.ManageTour;

namespace TourManagement.ViewModel.ManageTrip
{
    public class WD_AddTripViewModel : BaseViewModel
    {

        

        #region Command EDITTRIP
        public ICommand ConfirmEditTripCommand { get; set; }
        public ICommand ResetEditTripCommand { get; set; }
        public ICommand DeleteCustomerFromListCommand { get; set; }
        #endregion
        #region TEXT EDITTRIP
        private TRIP _SelectedTRIP;
        public TRIP SelectedTRIP { get => _SelectedTRIP; set { _SelectedTRIP = value; OnPropertyChanged(); } }
        private int _SelectedIDDOAN;
        public int SelectedIDDOAN { get => _SelectedIDDOAN; set { _SelectedIDDOAN = value; OnPropertyChanged(); } }
        private string _EditTourName;
        public string EditTourName { get => _EditTourName; set { _EditTourName = value; OnPropertyChanged(); } }

        private string _EditTourPrice;
        public string EditTourPrice { get => _EditTourPrice; set { _EditTourPrice = value; OnPropertyChanged(); } }

        #endregion
        #region Declare Text Binding AddTrip
        private TOURs _SelectedTOURs;
        public TOURs SelectedTOURs { get => _SelectedTOURs; set { _SelectedTOURs = value; OnPropertyChanged(); } }

        private int _RevenueSum;
        public int RevenueSum { get => _RevenueSum; set { _RevenueSum = value; OnPropertyChanged(); } }

        private string _TripName;
        public string TripName { get => _TripName; set { _TripName = value; OnPropertyChanged(); } }

        private string _NumberStaff;
        public string NumberStaff { get => _NumberStaff; set { _NumberStaff = value; OnPropertyChanged(); } }

        private Nullable<DateTime> _TripStartDT;
        public Nullable<DateTime> TripStartDT { get => _TripStartDT; set { _TripStartDT = value; OnPropertyChanged(); } }

        private string _TripStart;
        public string TripStart { get => _TripStart; set { _TripStart = value; OnPropertyChanged(); } }

        private Nullable<DateTime> _TripEndDT;
        public Nullable<DateTime> TripEndDT { get => _TripEndDT; set { _TripEndDT = value; OnPropertyChanged(); } }

        private string _TripEnd;
        public string TripEnd { get => _TripEnd; set { _TripEnd = value; OnPropertyChanged(); } }

        private string _TripDescription;
        public string TripDescription { get => _TripDescription; set { _TripDescription = value; OnPropertyChanged(); } }

        private string _HotelCost;
        public string HotelCost { get => _HotelCost; set { _HotelCost = value; OnPropertyChanged(); } }

        private string _VehicleCost;
        public string VehicleCost { get => _VehicleCost; set { _VehicleCost = value; OnPropertyChanged(); } }

        private string _EatingCost;
        public string EatingCost { get => _EatingCost; set { _EatingCost = value; OnPropertyChanged(); } }

        private string _OtherCost;
        public string OtherCost { get => _OtherCost; set { _OtherCost = value; OnPropertyChanged(); } }

        private string _AllTripCost;
        public string AllTripCost { get => _AllTripCost; set { _AllTripCost = value; OnPropertyChanged(); } }


        #endregion

        #region BINDING TEXT HOTEL LIST
        private HOTEL _SelectedHOTEL;
        public HOTEL SelectedHOTEL { get => _SelectedHOTEL; set { _SelectedHOTEL = value; OnPropertyChanged(); } }

        private ObservableCollection<HOTEL> _TRIP_HOTELLISTDTG;
        public ObservableCollection<HOTEL> TRIP_HOTELLISTDTG { get => _TRIP_HOTELLISTDTG; set { _TRIP_HOTELLISTDTG = value; OnPropertyChanged(); } }

        private string _NumberOfSingleRoom;
        public string NumberOfSingleRoom { get => _NumberOfSingleRoom; set { _NumberOfSingleRoom = value; OnPropertyChanged(); } }

        private string _NumberOfDoubleRoom;
        public string NumberOfDoubleRoom { get => _NumberOfDoubleRoom; set { _NumberOfDoubleRoom = value; OnPropertyChanged(); } }

        private int _NumberOfDay;
        public int NumberOfDay { get => _NumberOfDay; set { _NumberOfDay = value; OnPropertyChanged(); } }
        


        #endregion

        #region BINDING CUSTOMER LIST
        private CUSTOMER _SelectedCUSTOMER;
        public CUSTOMER SelectedCUSTOMER { get => _SelectedCUSTOMER; set { _SelectedCUSTOMER = value; OnPropertyChanged(); } }

        private ObservableCollection<CUSTOMER> _TRIP_CUSTOMERLISTDTG;
        public ObservableCollection<CUSTOMER> TRIP_CUSTOMERLISTDTG { get => _TRIP_CUSTOMERLISTDTG; set { _TRIP_CUSTOMERLISTDTG = value; OnPropertyChanged(); } }
        #endregion

        #region BINDING VEHICLE LIST
        private VEHICLE _SelectedVEHICLE;
        public VEHICLE SelectedVEHICLE { get => _SelectedVEHICLE; set { _SelectedVEHICLE = value; OnPropertyChanged(); } }

        private ObservableCollection<VEHICLE> _TRIP_VEHICLELISTDTG;
        public ObservableCollection<VEHICLE> TRIP_VEHICLELISTDTG { get => _TRIP_VEHICLELISTDTG; set { _TRIP_VEHICLELISTDTG = value; OnPropertyChanged(); } }

        private bool _isBelongToCompany;
        public bool isBelongToCompany { get => _isBelongToCompany; set { _isBelongToCompany = value; OnPropertyChanged(); } }

        private bool _BelongToCompany;
        public bool BelongToCompany { get => _BelongToCompany; set { _BelongToCompany = value; OnPropertyChanged(); } }

        private string _VehiclePrice;
        public string VehiclePrice { get => _VehiclePrice; set { _VehiclePrice = value; OnPropertyChanged(); } }

        #endregion

        #region BINDING WD_MANAGETRIP_STAFF
        private STAFF _SelectedSTAFF;
        public STAFF SelectedSTAFF { get => _SelectedSTAFF; set { _SelectedSTAFF = value; OnPropertyChanged(); } }

        private ObservableCollection<STAFF> _TRIP_STAFFLISTDTG;
        public ObservableCollection<STAFF> TRIP_STAFFLISTDTG { get => _TRIP_STAFFLISTDTG; set { _TRIP_STAFFLISTDTG = value; OnPropertyChanged(); } }


        private string _StaffMission;
        public string StaffMission { get => _StaffMission; set { _StaffMission = value; OnPropertyChanged(); } }
        
        #endregion
        #region Command WD_ManageTrip_STAFF
        public ICommand WD_ManageTrip_Staff_QuitCommand { get; set; }

        public ICommand AddStaffToTripCommand { get; set; }

        public ICommand SelectStaffCommand { get; set; }
        #endregion
        #region Command WD_ManageTrip_HOTEL
        public ICommand AddHotelToTripCommand { get; set; }
        public ICommand SelectHotelCommand { get; set; }
        #endregion
        #region Command WD_ManageTrip_Vehicle
        public ICommand AddVehicleToTripCommand { get; set; }
        public ICommand SelectVehicleCommand { get; set; }
        #endregion


        #region Command WD_ManageTrip_EatingCost
        public ICommand AddEatingCostCommand { get; set; }
        public ICommand AddNewEatingCostCommand { get; set; }
        public ICommand DefaultFindEatingCostCommand { get; set; }
        public ICommand FindEatingCostCommand { get; set; }
        #endregion

        #region Text WD_ManageTrip_EatingCost
        private EATING _SelectedEATING;
        public EATING SelectedEATING { get => _SelectedEATING; set { _SelectedEATING = value; OnPropertyChanged(); } }

        private ObservableCollection<EATING> _TRIP_EATINGLISTDTG;
        public ObservableCollection<EATING> TRIP_EATINGLISTDTG { get => _TRIP_EATINGLISTDTG; set { _TRIP_EATINGLISTDTG = value; OnPropertyChanged(); } }

        private string _EatingDescriptionFind;
        public string EatingDescriptionFind { get => _EatingDescriptionFind; set { _EatingDescriptionFind = value; OnPropertyChanged(); } }

        private string _EatingDescription;
        public string EatingDescription { get => _EatingDescription; set { _EatingDescription = value; OnPropertyChanged(); } }

        private string _EatingCostAdd;
        public string EatingCostAdd { get => _EatingCostAdd; set { _EatingCostAdd = value; OnPropertyChanged(); } }

        #endregion

        #region Command WD_ManageTrip_OtherCost
        public ICommand AddNewOtherCostCommand { get; set; }
        public ICommand AddOtherCostCommand { get; set; }
        #endregion
        #region Text WD_ManageTRIP_OtherCost

        private ObservableCollection<OTHERCOST> _TRIP_OTHERCOSTLISTDTG;
        public ObservableCollection<OTHERCOST> TRIP_OTHERCOSTLISTDTG { get => _TRIP_OTHERCOSTLISTDTG; set { _TRIP_OTHERCOSTLISTDTG = value; OnPropertyChanged(); } }

        private string _OtherCostDescriptionFind;
        public string OtherCostDescriptionFind { get => _OtherCostDescriptionFind; set { _OtherCostDescriptionFind = value; OnPropertyChanged(); } }

        private string _OtherCostDescription;
        public string OtherCostDescription { get => _OtherCostDescription; set { _OtherCostDescription = value; OnPropertyChanged(); } }

        private string _OtherCostAdd;
        public string OtherCostAdd { get => _OtherCostAdd; set { _OtherCostAdd = value; OnPropertyChanged(); } }
        #endregion


        #region Command WD_AddTrip
        public ICommand QuitCommand { get; set; }

        public ICommand SelectCustomerCommand { get; set; }

        public ICommand AddCustomerToTripCommand { get; set; }

        public ICommand SelectTourCommand { get; set; }

        public ICommand ManageTrip_Staff_Command { get; set; }

        public ICommand DetailHotelCommand { get; set; }
        public ICommand DetailVehicleCommand { get; set; }
        public ICommand DetailEatingCommand { get; set; }
        public ICommand DetailOtherCostCommand { get; set; }

        public ICommand AddTripCommand { get; set; }
        public ICommand ResetCommand { get; set; }

        #endregion
        public WD_AddTripViewModel()
        {
            TripStartDT = DateTime.Today;
            TripEndDT = DateTime.Today.AddDays(1);
            TRIP_CUSTOMERLISTDTG = new ObservableCollection<CUSTOMER>();
            TRIP_STAFFLISTDTG = new ObservableCollection<STAFF>();
            TRIP_HOTELLISTDTG = new ObservableCollection<HOTEL>();
            TRIP_VEHICLELISTDTG = new ObservableCollection<VEHICLE>();
            TRIP_EATINGLISTDTG = new ObservableCollection<EATING>();
            TRIP_OTHERCOSTLISTDTG = new ObservableCollection<OTHERCOST>();
            AllTripCost = 0.ToString();
            EatingCost = 0.ToString();
            VehicleCost = 0.ToString();
            HotelCost = 0.ToString();
            OtherCost = 0.ToString();

            

            #region HOTEL
            SelectHotelCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                WD_HotelList wd_HotelList = new WD_HotelList();
                var wd_HotelList_DT = wd_HotelList.DataContext as UC_ManageTripViewModel;
                wd_HotelList_DT.LoadProvinceList();
                wd_HotelList_DT.LoadHotelList();
                wd_HotelList.ShowDialog();
                SelectedHOTEL = wd_HotelList_DT.SelectedHOTEL;
                wd_HotelList.Close();
            });
            AddHotelToTripCommand = new RelayCommand<object>((p) =>
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
                    return;
                }
                else
                {

                    if (TRIP_HOTELLISTDTG.Where(x => x.khachsan.IDKS == SelectedHOTEL.khachsan.IDKS).Count() != 0)
                    {
                        MessageBox.Show("Khách sạn đã tồn tại trong đoàn, vui lòng chọn khách sạn khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        SelectedHOTEL = null;
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(NumberOfSingleRoom) && string.IsNullOrEmpty(NumberOfDoubleRoom))
                        {
                            MessageBox.Show("Bạn chưa nhập số lượng phòng!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return;
                        }
                        if (string.IsNullOrEmpty(NumberOfDoubleRoom))
                        {
                            MessageBox.Show("Bạn chưa nhập số lượng phòng đôi!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return;
                        }
                        if (string.IsNullOrEmpty(NumberOfSingleRoom))
                        {
                            MessageBox.Show("Bạn chưa nhập số lượng phòng đơn!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return;
                        }   
                        SelectedHOTEL.SOPHONGDOI = NumberOfDoubleRoom.ToString();
                        SelectedHOTEL.SOPHONGDON = NumberOfSingleRoom.ToString();
                        SelectedHOTEL.TONGCHIPHI = (Convert.ToInt32(SelectedHOTEL.SOPHONGDON) * Convert.ToInt32(SelectedHOTEL.khachsan.GIAPHONGDON) + Convert.ToInt32(SelectedHOTEL.SOPHONGDOI) * Convert.ToInt32(SelectedHOTEL.khachsan.GIAPHONGDOI)).ToString();
                        TRIP_HOTELLISTDTG.Add(SelectedHOTEL);
                        SelectedHOTEL = null;
                        NumberOfSingleRoom = null;
                        NumberOfDoubleRoom = null;
                    }
                }
            });
            #endregion
            #region STAFF
            
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
            AddStaffToTripCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                if (SelectedSTAFF == null)
                {
                    return;
                }
                else
                {
                     
                    if (TRIP_STAFFLISTDTG.Where(x => x.nhanvien.IDNV == SelectedSTAFF.nhanvien.IDNV).Count() != 0)
                    {
                        MessageBox.Show("Nhân viên đã tồn tại trong đoàn, vui lòng chọn khách hàng khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        SelectedSTAFF = null;
                        StaffMission = null;
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(StaffMission))
                        {

                            MessageBox.Show("Bạn chưa nhập nhiệm vụ của nhân viên!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return;
                        }
                        SelectedSTAFF.NHIEMVU = StaffMission;
                        TRIP_STAFFLISTDTG.Add(SelectedSTAFF);
                        NumberStaff = TRIP_STAFFLISTDTG.Count().ToString();
                        SelectedSTAFF = null;
                        StaffMission = null;
                    }
                }
            });
            #endregion
            #region CUSTOMER
            SelectCustomerCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                SelectedCUSTOMER = new CUSTOMER();
                WD_CustomerList wd_CustomerList = new WD_CustomerList();
                var wd_CustomerList_DT = wd_CustomerList.DataContext as UC_ManageCustomerViewModel;
                wd_CustomerList_DT.LoadCustomerList();
                wd_CustomerList.ShowDialog();
                wd_CustomerList.Close();

                if (wd_CustomerList_DT.SelectedCUSTOMER == null)
                {
                    return;
                }
                else
                {
                    SelectedCUSTOMER = wd_CustomerList_DT.SelectedCUSTOMER;
                }
            });
            AddCustomerToTripCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                if (SelectedCUSTOMER == null)
                {
                    return;
                }
                else
                {
                    if (TRIP_CUSTOMERLISTDTG.Where(x => x.khachhang.IDKH == SelectedCUSTOMER.khachhang.IDKH).Count() != 0)
                    {
                        MessageBox.Show("Khách hàng đã tồn tại trong đoàn, vui lòng chọn khách hàng khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        SelectedCUSTOMER = null;
                        return;
                    }
                    else
                    {
                        if (SelectedTOURs == null)
                        {
                            MessageBox.Show("Vui lòng chọn TOUR của đoàn du lịch này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                            SelectedCUSTOMER = null;
                            return;
                        }
                        else
                        {
                            TRIP_CUSTOMERLISTDTG.Add(SelectedCUSTOMER);
                            int temp = Convert.ToInt32(SelectedTOURs.tour.GIATOUR);
                            RevenueSum += temp;
                            SelectedCUSTOMER = null;
                        }
                    }
                }
            });
            #endregion
            #region TOUR
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
                    RevenueSum = TRIP_CUSTOMERLISTDTG.Count() * Convert.ToInt32(SelectedTOURs.tour.GIATOUR);
                    wd_TourList.Close();
                }
            });
            #endregion
            #region VEHICLE
            SelectVehicleCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                WD_VehicleList wd_VehicleList = new WD_VehicleList();
                var wd_VehicleList_DT = wd_VehicleList.DataContext as UC_ManageTripViewModel;
                wd_VehicleList_DT.LoadVehicleList();
                wd_VehicleList.ShowDialog();
                SelectedVEHICLE = wd_VehicleList_DT.SelectedVEHICLE;
                isBelongToCompany = Convert.ToBoolean(SelectedVEHICLE.phuongtien.BELONGTOCOMPANY);
                VehiclePrice = SelectedVEHICLE.phuongtien.GIATHUE;
                if(isBelongToCompany == true)
                {
                    BelongToCompany = false;
                }    
                else
                {
                    BelongToCompany = true;
                }    
                wd_VehicleList.Close();
            });
            AddVehicleToTripCommand = new RelayCommand<object>((p) =>
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
                    MessageBox.Show("Bạn chưa chọn phương tiện, vui lòng chọn phương tiện!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else
                {

                    if (TRIP_VEHICLELISTDTG.Where(x => x.phuongtien.IDPT == SelectedVEHICLE.phuongtien.IDPT).Count() != 0)
                    {
                        MessageBox.Show("Phương tiện đã tồn tại trong đoàn, vui lòng chọn phương tiện khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        SelectedVEHICLE = null;
                        VehiclePrice = null; 
                        return;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(VehiclePrice))
                        {
                            MessageBox.Show("Bạn chưa nhập giá thuê của phương tiện, vui lòng nhập giá thuê!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return;
                        }
                        else
                        {
                            if(SelectedVEHICLE.phuongtien.BELONGTOCOMPANY == true)
                            {
                                SelectedVEHICLE.BELONGTOCOMPANY = "Công ty";
                            }    
                            else
                            {
                                SelectedVEHICLE.BELONGTOCOMPANY = "Thuê ngoài";
                            }
                            SelectedVEHICLE.phuongtien.GIATHUE = VehiclePrice;
                            TRIP_VEHICLELISTDTG.Add(SelectedVEHICLE);
                            SelectedVEHICLE = null;
                            VehiclePrice = null;
                        }    
                    }
                }
            });
            #endregion
            #region EATINGCOST
            AddEatingCostCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_AddEating wd_AddEating = new WD_AddEating();
                wd_AddEating.ShowDialog();
                wd_AddEating.Close();
            });

            AddNewEatingCostCommand = new RelayCommand<Window>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                EATING eating = new EATING();
                eating.CHIPHIBUAAN = EatingCostAdd;
                eating.MOTA = EatingDescription;
                TRIP_EATINGLISTDTG.Add(eating);
                p.Close();
            });
            #endregion
            #region OTHERCOST
            AddOtherCostCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_AddOtherCost wd_AddOtherCost = new WD_AddOtherCost();
                wd_AddOtherCost.ShowDialog();
                wd_AddOtherCost.Close();
            });
            AddNewOtherCostCommand = new RelayCommand<Window>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                OTHERCOST othercost = new OTHERCOST();
                othercost.CHIPHI = OtherCostAdd;
                othercost.MOTA = OtherCostDescription;
                TRIP_OTHERCOSTLISTDTG.Add(othercost);
                p.Close();
            });
            #endregion
            #region ADDTRIP COMMAND
            ResetCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn đặt lại?", "Thông báo", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    Reset();
                }
                else
                {
                    return;
                }
            });
            AddTripCommand = new RelayCommand<Window>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                TripStart = TripStartDT?.ToString("dd/MM/yyyy");
                TripEnd = TripEndDT?.ToString("dd/MM/yyyy");
                TRIP newTRIP = new TRIP();
                newTRIP.AddNewTrip(TripName, SelectedTOURs.tour.IDTOUR, TRIP_CUSTOMERLISTDTG.Count(), TRIP_VEHICLELISTDTG.Count, TripStart, TripEnd,TripDescription,AllTripCost,RevenueSum.ToString(), TRIP_CUSTOMERLISTDTG, TRIP_STAFFLISTDTG, TRIP_HOTELLISTDTG, TRIP_VEHICLELISTDTG, TRIP_EATINGLISTDTG, TRIP_OTHERCOSTLISTDTG);
                MessageBox.Show("Thêm thông tin đoàn du lịch thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                p.Close();
            });
            ManageTrip_Staff_Command = new RelayCommand<WD_AddTrip>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                WD_ManageTrip_Staff wd_ManageTrip_Staff = new WD_ManageTrip_Staff();
                wd_ManageTrip_Staff.ShowDialog();
                wd_ManageTrip_Staff.Close();
            });
            DetailHotelCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                WD_ManageTrip_Hotel wd_ManageTrip_Hotel = new WD_ManageTrip_Hotel();
                wd_ManageTrip_Hotel.ShowDialog();
                wd_ManageTrip_Hotel.Close();

                int SumCost = new int();

                foreach(var item in TRIP_HOTELLISTDTG)
                {
                    SumCost += Convert.ToInt32(item.TONGCHIPHI);
                }

                HotelCost = SumCost.ToString();
                int temp = new int();
                temp = Convert.ToInt32(HotelCost) + Convert.ToInt32(VehicleCost) + Convert.ToInt32(EatingCost) + Convert.ToInt32(OtherCost);
                AllTripCost = temp.ToString();
            });
            DetailVehicleCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                WD_ManageTrip_Vehicle wd_ManageTrip_Vehicle = new WD_ManageTrip_Vehicle();
                wd_ManageTrip_Vehicle.ShowDialog();
                wd_ManageTrip_Vehicle.Close();

                int SumCost = new int();

                foreach (var item in TRIP_VEHICLELISTDTG)
                {
                    SumCost += Convert.ToInt32(item.phuongtien.GIATHUE);
                }

                VehicleCost = SumCost.ToString();
                int temp = new int();
                temp = Convert.ToInt32(HotelCost) + Convert.ToInt32(VehicleCost) + Convert.ToInt32(EatingCost) + Convert.ToInt32(OtherCost);
                AllTripCost = temp.ToString();
            });
            DetailEatingCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                WD_ManageTrip_EatingCost wd_ManageTrip_EatingCost = new WD_ManageTrip_EatingCost();
                wd_ManageTrip_EatingCost.ShowDialog();
                wd_ManageTrip_EatingCost.Close();

                int SumCost = new int();

                foreach (var item in TRIP_EATINGLISTDTG)
                {
                    SumCost += Convert.ToInt32(item.CHIPHIBUAAN);
                }

                EatingCost = SumCost.ToString();
                int temp = new int();
                temp = Convert.ToInt32(HotelCost) + Convert.ToInt32(VehicleCost) + Convert.ToInt32(EatingCost) + Convert.ToInt32(OtherCost);
                AllTripCost = temp.ToString();
            });
            DetailOtherCostCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}

                return true;
            }, (p) =>
            {
                WD_ManageTrip_OtherCost wd_ManageTrip_OtherCost = new WD_ManageTrip_OtherCost();
                wd_ManageTrip_OtherCost.ShowDialog();
                wd_ManageTrip_OtherCost.Close();

                int SumCost = new int();

                foreach (var item in TRIP_OTHERCOSTLISTDTG)
                {
                    SumCost += Convert.ToInt32(item.CHIPHI);
                }

                OtherCost = SumCost.ToString();
                int temp = new int();
                temp = Convert.ToInt32(HotelCost) + Convert.ToInt32(VehicleCost) + Convert.ToInt32(EatingCost) + Convert.ToInt32(OtherCost);
                AllTripCost = temp.ToString();
            });
            #endregion
            #region EDITTRIP COMMAND 
            DeleteCustomerFromListCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá khách hàng khỏi danh sách?", "Thông báo", MessageBoxButton.YesNo,MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    TRIP_CUSTOMERLISTDTG.Remove(SelectedCUSTOMER);
                }
                else
                {
                    return;
                }
            });
            ConfirmEditTripCommand = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                TripStart = TripStartDT?.ToString("dd/MM/yyyy");
                TripEnd = TripEndDT?.ToString("dd/MM/yyyy");
                SelectedTRIP.EditTrip(SelectedTRIP.doan.IDDOAN,TripName, SelectedTRIP.doan.IDTOUR, TRIP_CUSTOMERLISTDTG.Count(), TRIP_VEHICLELISTDTG.Count, TripStart, TripEnd, TripDescription, AllTripCost, RevenueSum.ToString(), TRIP_CUSTOMERLISTDTG, TRIP_STAFFLISTDTG, TRIP_HOTELLISTDTG, TRIP_VEHICLELISTDTG, TRIP_EATINGLISTDTG, TRIP_OTHERCOSTLISTDTG);


                MessageBoxResult result = MessageBox.Show("Chỉnh sửa lịch trình TOUR thành công!" + Environment.NewLine + "Bạn có muốn tiếp tục chỉnh sửa?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (result == MessageBoxResult.No)
                {

                    p.Close();
                }
                else
                {
                    return;
                }
            });
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
                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    p.Close();
                }
                else
                {
                    return;
                }
            });
            
        }

        public void Reset()
        {
            SelectedTOURs = null;
            TripName = null;
            TripDescription = null;
            RevenueSum = 0;
            TripStartDT = DateTime.Today;
            TripEndDT = DateTime.Today.AddDays(1);
            
            TRIP_CUSTOMERLISTDTG = new ObservableCollection<CUSTOMER>();
            TRIP_STAFFLISTDTG = new ObservableCollection<STAFF>();
            TRIP_HOTELLISTDTG = new ObservableCollection<HOTEL>();
            TRIP_VEHICLELISTDTG = new ObservableCollection<VEHICLE>();
            TRIP_EATINGLISTDTG = new ObservableCollection<EATING>();
            TRIP_OTHERCOSTLISTDTG = new ObservableCollection<OTHERCOST>();
            AllTripCost = 0.ToString();
            EatingCost = 0.ToString();
            VehicleCost = 0.ToString();
            HotelCost = 0.ToString();
            OtherCost = 0.ToString();
        }

        

        #region Function WD_EditTrip
        public void LoadEditTrip()
        {
            SelectedTOURs = new TOURs();

            SelectedTOURs.tour = SelectedTRIP.doan.TOUR;

            EditTourName = SelectedTRIP.doan.TOUR.TENTOUR;
            EditTourPrice = SelectedTRIP.doan.TOUR.GIATOUR;
            NumberStaff = null;
            TripName = SelectedTRIP.doan.TENDOAN;
            TripStartDT = Convert.ToDateTime(SelectedTRIP.doan.NGAYBATDAU);
            TripEndDT = Convert.ToDateTime(_SelectedTRIP.doan.NGAYKETTHUC);
            TripDescription = SelectedTRIP.doan.MOTA;
            LoadTRIP_CUSTOMERLISTDTG();
            LoadTRIP_STAFFLISTDTG();
            LoadTRIP_HOTELLISTDTG();
            LoadTRIP_VEHICLELISTDTG();
            LoadTRIP_EATINGLISTDTG();
            LoadTRIP_OTHERCOSTLISTDTG();

            int tempcost = new int();
            tempcost = 0;
            tempcost = Convert.ToInt32(HotelCost) + Convert.ToInt32(VehicleCost) + Convert.ToInt32(EatingCost) + Convert.ToInt32(OtherCost);
            AllTripCost = tempcost.ToString();
        }
        public void LoadTRIP_CUSTOMERLISTDTG()
        {
            TRIP_CUSTOMERLISTDTG = new ObservableCollection<CUSTOMER>();
            ObservableCollection<CT_DOAN_KHACHHANG> TRIP_CUSTOMER_DETAIL = new ObservableCollection<CT_DOAN_KHACHHANG>(DataProvider.Ins.DB.CT_DOAN_KHACHHANG.Where(x => x.IDDOAN == SelectedTRIP.doan.IDDOAN));

            foreach (var item in TRIP_CUSTOMER_DETAIL)
            {
                CUSTOMER temp = new CUSTOMER();
                temp.khachhang = item.KHACHHANG;
                temp.GIOITINH = item.KHACHHANG.GIOITINH;
                TRIP_CUSTOMERLISTDTG.Add(temp);
            }
            RevenueSum = TRIP_CUSTOMERLISTDTG.Count() * Convert.ToInt32(SelectedTRIP.doan.TOUR.GIATOUR);
        }

        public void LoadTRIP_STAFFLISTDTG()
        {
            TRIP_STAFFLISTDTG = new ObservableCollection<STAFF>();

            ObservableCollection<CT_DOAN_NHANVIEN> TRIP_STAFF_DETAIL = new ObservableCollection<CT_DOAN_NHANVIEN>(DataProvider.Ins.DB.CT_DOAN_NHANVIEN.Where(x => x.IDDOAN == SelectedTRIP.doan.IDDOAN));

            foreach (var item in TRIP_STAFF_DETAIL)
            {
                STAFF temp = new STAFF();
                temp.nhanvien = item.NHANVIEN;
                temp.NHIEMVU = item.NHIEMVU;
                TRIP_STAFFLISTDTG.Add(temp);
            }
            NumberStaff = TRIP_STAFFLISTDTG.Count().ToString();
        }
        public void LoadTRIP_HOTELLISTDTG()
        {
            HotelCost = null;
            int tempcost = new int();
            tempcost = 0;
            TRIP_HOTELLISTDTG = new ObservableCollection<HOTEL>();

            ObservableCollection<CT_DOAN_KHACHSAN> TRIP_HOTEL_DETAIL = new ObservableCollection<CT_DOAN_KHACHSAN>(DataProvider.Ins.DB.CT_DOAN_KHACHSAN.Where(x => x.IDDOAN == SelectedTRIP.doan.IDDOAN));

            foreach (var item in TRIP_HOTEL_DETAIL)
            {
                HOTEL temp = new HOTEL();
                temp.khachsan = item.KHACHSAN;
                temp.TONGCHIPHI = item.CHIPHIKS;
                temp.SOPHONGDOI = item.SOPHONGDOI.ToString();
                temp.SOPHONGDON = item.SOPHONGDON.ToString();
                TRIP_HOTELLISTDTG.Add(temp);
                tempcost += Convert.ToInt32(item.CHIPHIKS);
            }
            HotelCost = tempcost.ToString();
        }

        public void LoadTRIP_VEHICLELISTDTG()
        {
            VehicleCost = null;
            int tempcost = new int();
            tempcost = 0;
            TRIP_VEHICLELISTDTG = new ObservableCollection<VEHICLE>();

            ObservableCollection<CT_DOAN_PHUONGTIEN> TRIP_VEHICLE_DETAIL = new ObservableCollection<CT_DOAN_PHUONGTIEN>(DataProvider.Ins.DB.CT_DOAN_PHUONGTIEN.Where(x => x.IDDOAN == SelectedTRIP.doan.IDDOAN));

            foreach (var item in TRIP_VEHICLE_DETAIL)
            {
                VEHICLE temp = new VEHICLE();
                temp.phuongtien = item.PHUONGTIEN;
                if(item.PHUONGTIEN.BELONGTOCOMPANY == true)
                {
                    temp.BELONGTOCOMPANY = "Công ty";
                }    
                else
                {
                    temp.BELONGTOCOMPANY = "Thuê ngoài";
                }
                TRIP_VEHICLELISTDTG.Add(temp);
                tempcost += Convert.ToInt32(item.CHIPHIPT);
            }
            VehicleCost = tempcost.ToString();
        }
        public void LoadTRIP_EATINGLISTDTG()
        {
            EatingCost = null;
            int tempcost = new int();
            tempcost = 0;
            TRIP_EATINGLISTDTG = new ObservableCollection<EATING>();

            ObservableCollection<CT_DOAN_BUAAN> TRIP_EATING_DETAIL = new ObservableCollection<CT_DOAN_BUAAN>(DataProvider.Ins.DB.CT_DOAN_BUAAN.Where(x => x.IDDOAN == SelectedTRIP.doan.IDDOAN));

            foreach (var item in TRIP_EATING_DETAIL)
            {
                EATING temp = new EATING();
                temp.CHIPHIBUAAN = item.CHIPHIBUAAN;
                temp.MOTA = item.MOTA;
                temp.chitiet_doan_buaan = item;
                TRIP_EATINGLISTDTG.Add(temp);
                tempcost += Convert.ToInt32(item.CHIPHIBUAAN);
            }
            EatingCost = tempcost.ToString();
        }
        public void LoadTRIP_OTHERCOSTLISTDTG()
        {
            OtherCost = null;
            int tempcost = new int();
            tempcost = 0;
            TRIP_OTHERCOSTLISTDTG = new ObservableCollection<OTHERCOST>();

            ObservableCollection<CT_DOAN_CHIPHIKHAC> TRIP_OTHERCOST_DETAIL = new ObservableCollection<CT_DOAN_CHIPHIKHAC>(DataProvider.Ins.DB.CT_DOAN_CHIPHIKHAC.Where(x => x.IDDOAN == SelectedTRIP.doan.IDDOAN));

            foreach (var item in TRIP_OTHERCOST_DETAIL)
            {
                OTHERCOST temp = new OTHERCOST();
                temp.chitiet_doan_chiphikhac = item;
                temp.CHIPHI = item.CHIPHI;
                TRIP_OTHERCOSTLISTDTG.Add(temp);
                tempcost += Convert.ToInt32(item.CHIPHI);
            }
            OtherCost = tempcost.ToString();
        }
        #endregion
    }
}
