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
using TourManagement.View.ManageTour.ManagePlace;
using TourManagement.ViewModel.ManageTour.ManagePlace;

namespace TourManagement.ViewModel.ManageTour
{
    public class UC_ManageTourViewModel : BaseViewModel
    {

        #region Chức năng Button chuyển grid
        public enum CHUCNANG
        {
            ManageTour, ManagePlace, ManageHotel
        }
        private int _ChucNang;
        public int ChucNang { get => _ChucNang; set { _ChucNang = value; OnPropertyChanged(); } }
        #endregion

        #region Declare Binding Command ManageTour
        public ICommand BtnManagePlaceCommand { get; set; }

        #endregion

        #region Declare Binding Command ManagePlace
        public ICommand BackToManageTourCommand { get; set; }
        public ICommand AddPlaceCommand { get; set; }
        public ICommand EditPlaceCommand { get; set; }
        public ICommand DeletePlaceCommand { get; set; }
        public ICommand FindPlaceCommand { get; set; }
        public ICommand DefaultPlaceCommand { get; set; }
        #endregion

        #region Declare Binding ManagePlace
        private ObservableCollection<TINHTHANH> _PROVINCELIST;
        public ObservableCollection<TINHTHANH> PROVINCELIST { get => _PROVINCELIST; set { _PROVINCELIST = value; OnPropertyChanged(); } }

        private List<string> _ProvinceNameList;
        public List<string> ProvinceNameList { get => _ProvinceNameList; set { _ProvinceNameList = value; OnPropertyChanged(); } }
        //List Place
        private ObservableCollection<DIADIEM> _PLACELIST;
        public ObservableCollection<DIADIEM> PLACELIST { get => _PLACELIST; set { _PLACELIST = value; OnPropertyChanged(); } }

        private ObservableCollection<PLACE> _PLACELISTDTG;
        public ObservableCollection<PLACE> PLACELISTDTG { get => _PLACELISTDTG; set { _PLACELISTDTG = value; OnPropertyChanged(); } }

        private string _PlaceNameFind;
        public string PlaceNameFind { get => _PlaceNameFind; set { _PlaceNameFind = value; OnPropertyChanged(); } }
        private string _ProvinceNameFind
;
        public string ProvinceNameFind { get => _ProvinceNameFind; set { _ProvinceNameFind = value; OnPropertyChanged(); } }
        #endregion

        public UC_ManageTourViewModel()
        {

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
                LoadProvinceList();
                LoadPlaceList();
            });
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
        }

        public void FilterPlace()
        {
            LoadPlaceList();
            if(string.IsNullOrEmpty(PlaceNameFind) && string.IsNullOrEmpty(ProvinceNameFind))
            {
                CollectionViewSource.GetDefaultView(PLACELISTDTG).Filter = (all) => { return true; };
            }
            else if(string.IsNullOrEmpty(ProvinceNameFind))
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
                    return (placefind as PLACE).diadiem.TINHTHANH.IndexOf(ProvinceNameFind, StringComparison.OrdinalIgnoreCase) >= 0;
                };
            }
            else
            {
                CollectionViewSource.GetDefaultView(PLACELISTDTG).Filter = (placefind) =>
                {
                    return (placefind as PLACE).diadiem.TINHTHANH.IndexOf(ProvinceNameFind, StringComparison.OrdinalIgnoreCase) >= 0 &&
                           (placefind as PLACE).diadiem.TENDIADIEM.IndexOf(PlaceNameFind, StringComparison.OrdinalIgnoreCase) >= 0;
                };
            }    
        }
        public void ResetFilterPlace()
        {
            PlaceNameFind = null;
            ProvinceNameFind = null;
            CollectionViewSource.GetDefaultView(PLACELISTDTG).Filter = (all) => { return true; };
        }

        public void LoadProvinceList()
        {
            PROVINCELIST = new ObservableCollection<TINHTHANH>(DataProvider.Ins.DB.TINHTHANH);
            ProvinceNameList = new List<string>();
            foreach (var item in PROVINCELIST)
            {
                ProvinceNameList.Add(item.TENTT);
            }
        }
        #endregion
    }
}
