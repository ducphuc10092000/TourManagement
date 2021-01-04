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
using TourManagement.View.ManageTour.ManagePlace;

namespace TourManagement.ViewModel.ManageTour.ManagePlace
{
    public class WD_EditPlaceViewModel : BaseViewModel
    {
        private ObservableCollection<TINHTHANH> _PROVINCELIST;
        public ObservableCollection<TINHTHANH> PROVINCELIST { get => _PROVINCELIST; set { _PROVINCELIST = value; OnPropertyChanged(); } }

        private List<string> _ProvinceNameList;
        public List<string> ProvinceNameList { get => _ProvinceNameList; set { _ProvinceNameList = value; OnPropertyChanged(); } }

        private ImageSource _AvatarSource;
        public ImageSource AvatarSource { get => _AvatarSource; set { _AvatarSource = value; OnPropertyChanged(); } }

        private string _Avatar;
        public string Avatar { get => _Avatar; set { _Avatar = value; OnPropertyChanged(); } }

        private bool _ActiveIsChecked;
        public bool ActiveIsChecked { get => _ActiveIsChecked; set { _ActiveIsChecked = value; OnPropertyChanged(); } }

        private bool _InactiveIsChecked;
        public bool InactiveIsChecked { get => _InactiveIsChecked; set { _InactiveIsChecked = value; OnPropertyChanged(); } }

        private int _SelectedIDPlace;
        public int SelectedIDPlace { get => _SelectedIDPlace; set { _SelectedIDPlace = value; OnPropertyChanged(); } }

        #region Binding Text
        private string _PlaceName;
        public string PlaceName { get => _PlaceName; set { _PlaceName = value; OnPropertyChanged(); } }

        private string _PlaceDescription;
        public string PlaceDescription { get => _PlaceDescription; set { _PlaceDescription = value; OnPropertyChanged(); } }

        private string _ProvinceName;
        public string ProvinceName { get => _ProvinceName; set { _ProvinceName = value; OnPropertyChanged(); } }
        #endregion

        #region Command
        public ICommand EditPlaceCommand { get; set; }
        public ICommand QuitCommand { get; set; }
        public ICommand ChangePictureCommand { get; set; }
        public ICommand DeletePictureCommand { get; set; }
        #endregion
        public WD_EditPlaceViewModel()
        {
            LoadProvinceList();
            QuitCommand = new RelayCommand<WD_EditPlace>((p) =>
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

                }
            });
            EditPlaceCommand = new RelayCommand<WD_EditPlace>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Xác nhận thay đổi thông tin!", "Thông báo", MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes)
                {
                    PLACE SelectedPlace = new PLACE();
                    SelectedPlace.EditPlace(SelectedIDPlace, PlaceName, PlaceDescription, ProvinceName,Avatar,ActiveIsChecked);
                    p.Close();
                }
                else
                {
                    return;
                }    
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
        public void LoadEditPlace()
        {
            DIADIEM SelectedPlace = DataProvider.Ins.DB.DIADIEM.Where(x => x.IDDIADIEM == SelectedIDPlace).Single();
            PlaceName = SelectedPlace.TENDIADIEM;
            PlaceDescription = SelectedPlace.MOTA;
            ProvinceName = SelectedPlace.TINHTHANH;
            Avatar = SelectedPlace.AVATAR;
            if(SelectedPlace.ACTIVE == true)
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
            ProvinceNameList = new List<string>();
            foreach (var item in PROVINCELIST)
            {
                ProvinceNameList.Add(item.TENTT);
            }
        }
    }
}
