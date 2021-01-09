using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using TourManagement.Model;
using TourManagement.Model.Tour;
using TourManagement.View.ManageTour.ManageHotel;
using TourManagement.View.ManageTour.ManageProvince;
using TourManagement.ViewModel.ManageTour.ManageProvince;

namespace TourManagement.ViewModel.ManageTour.ManageHotel
{
    public class WD_EditHotelViewModel : BaseViewModel
    {
        #region Command
        public ICommand ConfirmEditHotel { get; set; }
        public ICommand QuitCommand { get; set; }
        public ICommand ChangePictureCommand { get; set; }
        public ICommand DeletePictureCommand { get; set; }
        public ICommand AddNewProvinceCommand { get; set; }
        #endregion
        private ObservableCollection<TINHTHANH> _PROVINCELIST;
        public ObservableCollection<TINHTHANH> PROVINCELIST { get => _PROVINCELIST; set { _PROVINCELIST = value; OnPropertyChanged(); } }

        private ObservableCollection<string> _ProvinceNameList;
        public ObservableCollection<string> ProvinceNameList { get => _ProvinceNameList; set { _ProvinceNameList = value; OnPropertyChanged(); } }

        private ImageSource _AvatarSource;
        public ImageSource AvatarSource { get => _AvatarSource; set { _AvatarSource = value; OnPropertyChanged(); } }

        private string _Avatar;
        public string Avatar { get => _Avatar; set { _Avatar = value; OnPropertyChanged(); } }
        private string _HotelName;
        public string HotelName { get => _HotelName; set { _HotelName = value; OnPropertyChanged(); } }
        private string _HotelAddress;
        public string HotelAddress { get => _HotelAddress; set { _HotelAddress = value; OnPropertyChanged(); } }
        private string _HotelPhoneNumber;
        public string HotelPhoneNumber { get => _HotelPhoneNumber; set { _HotelPhoneNumber = value; OnPropertyChanged(); } }
        private string _ProvinceNameHotel;
        public string ProvinceNameHotel { get => _ProvinceNameHotel; set { _ProvinceNameHotel = value; OnPropertyChanged(); } }
        private string _HotelDescription;
        public string HotelDescription { get => _HotelDescription; set { _HotelDescription = value; OnPropertyChanged(); } }
        private bool _ActiveIsChecked;
        public bool ActiveIsChecked { get => _ActiveIsChecked; set { _ActiveIsChecked = value; OnPropertyChanged(); } }

        private bool _InactiveIsChecked;
        public bool InactiveIsChecked { get => _InactiveIsChecked; set { _InactiveIsChecked = value; OnPropertyChanged(); } }

        private int _SelectedIDHotel;
        public int SelectedIDHotel { get => _SelectedIDHotel; set { _SelectedIDHotel = value; OnPropertyChanged(); } }

        public WD_EditHotelViewModel()
        {
            LoadProvinceList();
            ConfirmEditHotel = new RelayCommand<WD_EditHotel>((p) =>
            {
                return true;
            }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Xác nhận thay đổi thông tin!", "Thông báo", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    HOTEL SelectedHOTEL = new HOTEL();
                    SelectedHOTEL.EditHotel(SelectedIDHotel, HotelName, HotelAddress, HotelPhoneNumber, ProvinceNameHotel, HotelDescription, ActiveIsChecked, Avatar);
                    p.Close();
                }
                else
                {
                    return;
                }
            });
            QuitCommand = new RelayCommand<WD_EditHotel>((p) =>
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
            AddNewProvinceCommand = new RelayCommand<WD_EditHotel>((p) =>
            {
                return true;
            }, (p) =>
            {
                p.Hide();
                WD_AddProvince wd_addprovince = new WD_AddProvince();
                var wd_addprovince_DT = wd_addprovince.DataContext as WD_AddProvinceViewModel;
                wd_addprovince_DT.Reset();
                wd_addprovince.ShowDialog();
                wd_addprovince.Close();
                LoadProvinceList();
                p.ShowDialog();
            });
            ChangePictureCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = @"C:\",
                    Title = "Chọn ảnh đại diện",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "txt",
                    Filter = "Images (*.JPG;*.PNG)|*.JPG;*.PNG",
                    RestoreDirectory = true,
                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };

                if (openFileDialog.ShowDialog() == true)
                {
                    Avatar = ImageProvider.ImageToString(openFileDialog.FileName);
                    AvatarSource = ImageProvider.GetImage(Avatar);
                }

            });
            DeletePictureCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                AvatarSource = null;
                Avatar = null;
            });
        }   
        
        public void LoadEditHotel()
        {
            KHACHSAN selectedHotel = DataProvider.Ins.DB.KHACHSAN.Where(x => x.IDKS == SelectedIDHotel).SingleOrDefault();
            HotelName = selectedHotel.TENKS;
            HotelAddress = selectedHotel.DIACHI;
            HotelPhoneNumber = selectedHotel.SDT;
            ProvinceNameHotel = selectedHotel.TINHTHANH;
            HotelDescription = selectedHotel.MOTA;
            Avatar = selectedHotel.AVATAR;
            if(selectedHotel.ACTIVE == true)
            {
                ActiveIsChecked = true;
                InactiveIsChecked = false;
            }    
            else
            {
                ActiveIsChecked = false;
                InactiveIsChecked = true;
            }    
            if(Avatar == null)
            {
                AvatarSource = null;
            }    
            else
            {
                AvatarSource = ImageProvider.GetImage(Avatar);
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
        }
    }
}
