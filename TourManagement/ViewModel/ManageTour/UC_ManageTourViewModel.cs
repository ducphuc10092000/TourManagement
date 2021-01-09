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
using TourManagement.Model.Tour;
using TourManagement.View.ManageTour;
using TourManagement.View.ManageTour.ManageHotel;
using TourManagement.View.ManageTour.ManagePlace;
using TourManagement.View.ManageTour.WD_ManageTour;
using TourManagement.ViewModel.ManageTour.ManageHotel;
using TourManagement.ViewModel.ManageTour.ManagePlace;
using TourManagement.ViewModel.ManageTour.WD_ManageTour;

namespace TourManagement.ViewModel.ManageTour
{
    public class UC_ManageTourViewModel : BaseViewModel
    {

        #region Chức năng và command Button chuyển grid
        public enum CHUCNANG
        {
            ManageTour, ManagePlace
        }
        private int _ChucNang;
        public int ChucNang { get => _ChucNang; set { _ChucNang = value; OnPropertyChanged(); } }
        public ICommand BtnManagePlaceCommand { get; set; }
        #endregion

        #region Declare Binding Command ManageTour
        public ICommand TourFindCommand { get; set; }
        public ICommand DefaultTourFindCommand { get; set; }
        public ICommand AddTourCommand { get; set; }
        public ICommand EditTourCommand { get; set; }
        #endregion

        #region Declare Binding Text ManageTour
        private string _TourNameFind;
        public string TourNameFind { get => _TourNameFind; set { _TourNameFind = value; OnPropertyChanged(); } }

        private ObservableCollection<TOUR> _TOURLIST;
        public ObservableCollection<TOUR> TOURLIST { get => _TOURLIST; set { _TOURLIST = value; OnPropertyChanged(); } }

        private ObservableCollection<TOURs> _TOURLISTDTG;
        public ObservableCollection<TOURs> TOURLISTDTG { get => _TOURLISTDTG; set { _TOURLISTDTG = value; OnPropertyChanged(); } }
        #endregion

        #region Declare Binding Command ManagePlace
        public ICommand BackToManageTourCommand { get; set; }
        public ICommand AddPlaceCommand { get; set; }
        public ICommand EditPlaceCommand { get; set; }
        public ICommand DeletePlaceCommand { get; set; }
        public ICommand FindPlaceCommand { get; set; }
        public ICommand DefaultPlaceCommand { get; set; }
        #endregion

        #region Declare Binding Text ManagePlace
        private ObservableCollection<TINHTHANH> _PROVINCELIST;
        public ObservableCollection<TINHTHANH> PROVINCELIST { get => _PROVINCELIST; set { _PROVINCELIST = value; OnPropertyChanged(); } }

        private ObservableCollection<string> _ProvinceNameList;
        public ObservableCollection<string> ProvinceNameList { get => _ProvinceNameList; set { _ProvinceNameList = value; OnPropertyChanged(); } }

        //List Place
        private ObservableCollection<DIADIEM> _PLACELIST;
        public ObservableCollection<DIADIEM> PLACELIST { get => _PLACELIST; set { _PLACELIST = value; OnPropertyChanged(); } }

        private ObservableCollection<PLACE> _PLACELISTDTG;
        public ObservableCollection<PLACE> PLACELISTDTG { get => _PLACELISTDTG; set { _PLACELISTDTG = value; OnPropertyChanged(); } }

        private string _PlaceNameFind;
        public string PlaceNameFind { get => _PlaceNameFind; set { _PlaceNameFind = value; OnPropertyChanged(); } }
        private string _ProvinceNamePlaceFind
;
        public string ProvinceNamePlaceFind { get => _ProvinceNamePlaceFind; set { _ProvinceNamePlaceFind = value; OnPropertyChanged(); } }
        #endregion

        #region Declare Command PlaceList
        public ICommand BackToAddTourCommand { get; set; }
        public ICommand DoubleClickSelectPlaceCommand { get; set; }
        #endregion

        #region Declare Binding Text WD_PlaceList
        private PLACE _SelectedPLACE;
        public PLACE SelectedPLACE { get => _SelectedPLACE; set { _SelectedPLACE = value; OnPropertyChanged(); } }
        #endregion

        
        public UC_ManageTourViewModel()
        {
            #region XỬ LÝ COMMAND CHUYẾN GRID CHỨC NĂNG
            BackToManageTourCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ChucNang = (int)CHUCNANG.ManageTour;
            });
            BtnManagePlaceCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ChucNang = (int)CHUCNANG.ManagePlace;
                LoadPlaceList();
            });
            #endregion

            #region XỬ LÝ COMMAND QUẢN LÝ TOUR - MANAGE TOUR
            TourFindCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                FilterTour();
            });

            DefaultTourFindCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ResetFilterTour();
            });
            AddTourCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_AddTour addtour = new WD_AddTour();
                var addtourDT = addtour.DataContext as WD_AddTourViewModel;
                addtourDT.ResetParameter();
                addtour.ShowDialog();
                addtour.Close();
                LoadTourList();
            });
            EditTourCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_EditTour edittour = new WD_EditTour();
                var edittour_DT = edittour.DataContext as WD_EditTourViewModel;
                edittour_DT.SelectedTourID = (int)p;
                edittour_DT.LoadSelectedTour();
                edittour.ShowDialog();
                edittour.Close();
                LoadTourList();
            });
            #endregion
            #region XỬ LÝ COMMAND QUẢN LÝ ĐIỂM THAM QUAN - MANAGE PLACE
            FindPlaceCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                FilterPlace();
            });
            DefaultPlaceCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ResetFilterPlace();
            });
            AddPlaceCommand = new RelayCommand<WD_AddPlace>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_AddPlace addplace = new WD_AddPlace();
                var addplaceDT = addplace.DataContext as WD_AddPlaceViewModel;
                addplaceDT.Reset();
                addplace.ShowDialog();
                addplace.Close();
                LoadPlaceList();
            });
            EditPlaceCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_EditPlace wd_editplace = new WD_EditPlace();
                var ct_wd_editplace = wd_editplace.DataContext as WD_EditPlaceViewModel;
                ct_wd_editplace.SelectedIDPlace = (int)p;
                ct_wd_editplace.LoadEditPlace();
                wd_editplace.ShowDialog();
                wd_editplace.Close();
                LoadPlaceList();
            });
            DeletePlaceCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {

            });
            #endregion
            #region XỬ LÝ COMMAND WD_PLACELIST
            BackToAddTourCommand = new RelayCommand<Window>((p) =>
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
            DoubleClickSelectPlaceCommand = new RelayCommand<WD_PlaceList>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                if(SelectedPLACE == null)
                {
                    return;
                }    
                else
                {
                    p.Close();
                }    
            });
            #endregion
            
        }


        #region Function ManagePlace
        public void LoadPlaceList()
        {
            PLACELIST = new ObservableCollection<DIADIEM>(DataProvider.Ins.DB.DIADIEM);
            PLACELISTDTG = new ObservableCollection<PLACE>();
            foreach (var item in PLACELIST)
            {
                PLACE temp = new PLACE();
                temp.diadiem = item;
                if (item.ACTIVE == true)
                {

                    temp.TRANGTHAI = "Hoạt động";
                }
                else
                {
                    temp.TRANGTHAI = "Không hoạt động";
                }
                PLACELISTDTG.Add(temp);
            }
            LoadProvinceList();
        }

        public void FilterPlace()
        {
            if(string.IsNullOrEmpty(PlaceNameFind) && string.IsNullOrEmpty(ProvinceNamePlaceFind))
            {
                CollectionViewSource.GetDefaultView(PLACELISTDTG).Filter = (all) => { return true; };
            }
            else if(string.IsNullOrEmpty(ProvinceNamePlaceFind))
            {
                CollectionViewSource.GetDefaultView(PLACELISTDTG).Filter = (placefind) =>
                {
                    return (placefind as PLACE).diadiem.TENDIADIEM.IndexOf(PlaceNameFind, StringComparison.OrdinalIgnoreCase) >= 0;
                };
            }
            else if(string.IsNullOrEmpty(PlaceNameFind))
            {
                CollectionViewSource.GetDefaultView(PLACELISTDTG).Filter = (placefind) =>
                {
                    return (placefind as PLACE).diadiem.TINHTHANH.IndexOf(ProvinceNamePlaceFind, StringComparison.OrdinalIgnoreCase) >= 0;
                };
            }
            else
            {
                CollectionViewSource.GetDefaultView(PLACELISTDTG).Filter = (placefind) =>
                {
                    return (placefind as PLACE).diadiem.TINHTHANH.IndexOf(ProvinceNamePlaceFind, StringComparison.OrdinalIgnoreCase) >= 0 &&
                           (placefind as PLACE).diadiem.TENDIADIEM.IndexOf(PlaceNameFind, StringComparison.OrdinalIgnoreCase) >= 0;
                };
            }    
        }
        public void ResetFilterPlace()
        {
            PlaceNameFind = null;
            ProvinceNamePlaceFind = null;
            CollectionViewSource.GetDefaultView(PLACELISTDTG).Filter = (all) => { return true; };
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
       
        #region Function ManageTour
        public void LoadTourList()
        {
            TOURLIST = new ObservableCollection<TOUR>(DataProvider.Ins.DB.TOUR);
            TOURLISTDTG = new ObservableCollection<TOURs>();
            foreach (var item in TOURLIST)
            {
                TOURs temp = new TOURs();
                temp.tour = item;
                if (item.ACTIVE == true)
                {

                    temp.STATUS = "Hoạt động";
                }
                else
                {
                    temp.STATUS = "Không hoạt động";
                }
                TOURLISTDTG.Add(temp);
            }
        }
        public void FilterTour()
        {
            if (string.IsNullOrEmpty(TourNameFind))
            {
                CollectionViewSource.GetDefaultView(TOURLISTDTG).Filter = (all) => { return true; };
            }
            else
            {
                CollectionViewSource.GetDefaultView(TOURLISTDTG).Filter = (tourfind) =>
                {
                    return (tourfind as TOURs).tour.TENTOUR.IndexOf(TourNameFind, StringComparison.OrdinalIgnoreCase) >= 0;
                };
            }
        }
        public void ResetFilterTour()
        {
            TourNameFind = null;
            CollectionViewSource.GetDefaultView(TOURLISTDTG).Filter = (all) => { return true; };
        }

        #endregion
    }
}
