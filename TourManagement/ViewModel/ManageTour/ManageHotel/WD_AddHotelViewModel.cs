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
    public class WD_AddHotelViewModel : BaseViewModel
    {
        #region Command 
        public ICommand QuitCommand { get; set; }
        public ICommand AddHotelCommand { get; set; }
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

        private string _SingleRoomPrice;
        public string SingleRoomPrice { get => _SingleRoomPrice; set { _SingleRoomPrice = value; OnPropertyChanged(); } }

        private string _DoubleRoomPrice;
        public string DoubleRoomPrice { get => _DoubleRoomPrice; set { _DoubleRoomPrice = value; OnPropertyChanged(); } }
        

        

        public WD_AddHotelViewModel()
        {
            QuitCommand = new RelayCommand<WD_AddHotel>((p) =>
            {
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
            AddNewProvinceCommand = new RelayCommand<WD_AddHotel>((p) =>
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
            AddHotelCommand = new RelayCommand<WD_AddHotel>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (HotelName == null || HotelAddress == null || HotelPhoneNumber == null)
                {
                    MessageBox.Show("Lỗi kìa tml");
                    return;
                }
                else
                {
                    HOTEL newhotel = new HOTEL();
                    newhotel.AddNewHotel(HotelName, HotelAddress, HotelPhoneNumber, ProvinceNameHotel, HotelDescription, Avatar,SingleRoomPrice,DoubleRoomPrice);
                    MessageBox.Show("Thêm thông tin khách sạn thành công", "Thông báo", MessageBoxButton.OK);
                }
                p.Close();
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

        public void Reset()
        {
            HotelName = null;
            HotelAddress = null;
            HotelPhoneNumber = null;
            ProvinceNameHotel = null;
            HotelDescription = null;
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
    }
}
