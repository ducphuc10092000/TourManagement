using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TourManagement.View.ManageTour.ManagePlace;
using TourManagement.Model;
using System.Collections.ObjectModel;
using TourManagement.Model.Tour;
using System.Windows.Media;
using Microsoft.Win32;

namespace TourManagement.ViewModel.ManageTour.ManagePlace
{
    public class WD_AddPlaceViewModel : BaseViewModel
    {
        private ObservableCollection<TINHTHANH> _PROVINCELIST;
        public ObservableCollection<TINHTHANH> PROVINCELIST { get => _PROVINCELIST; set { _PROVINCELIST = value; OnPropertyChanged(); } }

        private List<string> _ProvinceNameList;
        public List<string> ProvinceNameList { get=>_ProvinceNameList; set { _ProvinceNameList = value; OnPropertyChanged(); } }

        private ImageSource _AvatarSource;
        public ImageSource AvatarSource { get => _AvatarSource; set { _AvatarSource = value; OnPropertyChanged(); } }

        private string _Avatar;
        public string Avatar { get => _Avatar; set { _Avatar = value; OnPropertyChanged(); } }

        #region Binding Text
        private string _PlaceName;
        public string PlaceName { get => _PlaceName; set { _PlaceName = value; OnPropertyChanged(); } }

        private string _PlaceDescription;
        public string PlaceDescription { get => _PlaceDescription; set { _PlaceDescription = value; OnPropertyChanged(); } }

        private string _ProvinceName;
        public string ProvinceName { get => _ProvinceName; set { _ProvinceName = value; OnPropertyChanged(); } }
        #endregion

        #region Command 
        public ICommand QuitCommand { get; set; }
        public ICommand AddPlaceCommand { get; set; }
        public ICommand ChangePictureCommand { get; set; }
        public ICommand DeletePictureCommand { get; set; }
        #endregion

        public WD_AddPlaceViewModel()
        {
            LoadProvinceList();

            QuitCommand = new RelayCommand<WD_AddPlace>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát","Thông báo",MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes)
                {

                    p.Close();
                }
                else 
                {
                        
                }
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
                if(PlaceName == null || PlaceDescription == null || ProvinceName == null)
                {
                    MessageBox.Show("Lỗi kìa tml");
                    return;
                }    
                else
                {
                    PLACE newplace = new PLACE();
                    newplace.AddNewPlace(PlaceName, PlaceDescription, ProvinceName,Avatar);
                    MessageBox.Show("Thêm thông tin địa điểm tham quan thành công", "Thông báo", MessageBoxButton.OK);
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

        public void LoadProvinceList()
        {
            PROVINCELIST = new ObservableCollection<TINHTHANH>(DataProvider.Ins.DB.TINHTHANH);
            ProvinceNameList = new List<string>();
            foreach(var item in PROVINCELIST)
            {
                ProvinceNameList.Add(item.TENTT);
            }    
        }
        
    }
}
