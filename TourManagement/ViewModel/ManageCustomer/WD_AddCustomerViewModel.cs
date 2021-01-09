using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using TourManagement.Model.Customer;
using TourManagement.View.ManageCustomer;

namespace TourManagement.ViewModel.ManageCustomer
{
    public class WD_AddCustomerViewModel : BaseViewModel
    {
        #region BING TEXT EDITTOUR
        private string _CustomerName;
        public string CustomerName { get => _CustomerName; set { _CustomerName = value; OnPropertyChanged(); } }
        private string _IdentificationCustomer;
        public string IdentificationCustomer { get => _IdentificationCustomer; set { _IdentificationCustomer = value; OnPropertyChanged(); } }
        private string _CustomerBirthday;
        public string CustomerBirthday { get => _CustomerBirthday; set { _CustomerBirthday = value; OnPropertyChanged(); } }
        private Nullable<DateTime>  _CustomerBirthdayDT;
        public Nullable<DateTime> CustomerBirthdayDT { get => _CustomerBirthdayDT; set { _CustomerBirthdayDT = value; OnPropertyChanged(); } }
        private string _CustomerPhoneNumber;
        public string CustomerPhoneNumber { get => _CustomerPhoneNumber; set { _CustomerPhoneNumber = value; OnPropertyChanged(); } }
        private string _CustomerEmail;
        public string CustomerEmail { get => _CustomerEmail; set { _CustomerEmail = value; OnPropertyChanged(); } }
        private string _CustomerAddress;
        public string CustomerAddress { get => _CustomerAddress; set { _CustomerAddress = value; OnPropertyChanged(); } }
        private ImageSource _AvatarSource;
        public ImageSource AvatarSource { get => _AvatarSource; set { _AvatarSource = value; OnPropertyChanged(); } }

        private string _Avatar;
        public string Avatar { get => _Avatar; set { _Avatar = value; OnPropertyChanged(); } }
        #endregion

        #region Command 
        public ICommand QuitCommand { get; set; }
        public ICommand AddNewCustomerCommand { get; set; }
        public ICommand ChangePictureCommand { get; set; }
        public ICommand DeletePictureCommand { get; set; }
        #endregion
        public WD_AddCustomerViewModel()
        {
            LoadCurrentTime();

            QuitCommand = new RelayCommand<WD_AddCustomer>((p) =>
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
            AddNewCustomerCommand = new RelayCommand<WD_AddCustomer>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                CUSTOMER newCustomer = new CUSTOMER();

                //Check PARAMETER
                if(string.IsNullOrEmpty(CustomerName))
                {
                    MessageBox.Show("Tên khách hàng rỗng, vui lòng nhập lại","Thông báo",MessageBoxButton.OK,MessageBoxImage.Warning);
                }
                if(CustomerBirthdayDT == null)
                {
                    MessageBox.Show("CustomerBirthdayDT null");
                    return;
                }    
                CustomerBirthday = CustomerBirthdayDT?.ToString("dd/MM/yyyy");
                
                newCustomer.AddNewCustomer(CustomerName, IdentificationCustomer, CustomerAddress, CustomerPhoneNumber, CustomerEmail, CustomerBirthday,Avatar);
                MessageBox.Show("Thêm thông tin khách hàng thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
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
        public void LoadCurrentTime()
        {
            CustomerBirthdayDT = null;
        }
    }
}
