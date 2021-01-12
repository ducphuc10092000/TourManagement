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
using TourManagement.Model.Staff;

namespace TourManagement.ViewModel.ManageStaff
{
    public class WD_EditStaffViewModel : BaseViewModel
    {
        private STAFF _SelectedSTAFF;
        public STAFF SelectedSTAFF { get => _SelectedSTAFF; set { _SelectedSTAFF = value; OnPropertyChanged(); } }

        private ImageSource _AvatarSource;
        public ImageSource AvatarSource { get => _AvatarSource; set { _AvatarSource = value; OnPropertyChanged(); } }

        private ObservableCollection<string> _StaffRolesList;
        public ObservableCollection<string> StaffRolesList { get => _StaffRolesList; set { _StaffRolesList = value; OnPropertyChanged(); } }

        private string _Avatar;
        public string Avatar { get => _Avatar; set { _Avatar = value; OnPropertyChanged(); } }

        private string _StaffName;
        public string StaffName { get => _StaffName; set { _StaffName = value; OnPropertyChanged(); } }
        private string _IdentificationStaff;
        public string IdentificationStaff { get => _IdentificationStaff; set { _IdentificationStaff = value; OnPropertyChanged(); } }
        private string _StaffBirthday;
        public string StaffBirthday { get => _StaffBirthday; set { _StaffBirthday = value; OnPropertyChanged(); } }
        private Nullable<DateTime> _StaffBirthdayDT;
        public Nullable<DateTime> StaffBirthdayDT { get => _StaffBirthdayDT; set { _StaffBirthdayDT = value; OnPropertyChanged(); } }

        private string _StaffPhoneNumber;
        public string StaffPhoneNumber { get => _StaffPhoneNumber; set { _StaffPhoneNumber = value; OnPropertyChanged(); } }
        private string _StaffEmail;
        public string StaffEmail { get => _StaffEmail; set { _StaffEmail = value; OnPropertyChanged(); } }
        private string _StaffAddress;
        public string StaffAddress { get => _StaffAddress; set { _StaffAddress = value; OnPropertyChanged(); } }
        private string _StaffRole;
        public string StaffRole { get => _StaffRole; set { _StaffRole = value; OnPropertyChanged(); } }

        #region Command 
        public ICommand QuitCommand { get; set; }
        public ICommand ConfirmEditStaffCommand { get; set; }
        public ICommand ChangePictureCommand { get; set; }
        public ICommand DeletePictureCommand { get; set; }
        #endregion
        public WD_EditStaffViewModel()
        {
            LoadRolesList();
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
            ConfirmEditStaffCommand = new RelayCommand<Window>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                StaffBirthday = StaffBirthdayDT?.ToString("dd/MM/yyyy");
                SelectedSTAFF.EditStaff(SelectedSTAFF.nhanvien.IDNV, StaffName, StaffAddress, StaffPhoneNumber, StaffEmail, StaffBirthday, StaffRole);
                MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
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
        public void LoadRolesList()
        {
            StaffRolesList = new ObservableCollection<string>();
            StaffRolesList.Add("Quản lý nhân sự");
            StaffRolesList.Add("Quản lý điều hành");
            StaffRolesList.Add("Kế toán");
            StaffRolesList.Add("Nhân viên phòng nhân sự");
            StaffRolesList.Add("Nhân viên phòng điều hành - hướng dẫn");
        }

        public void LoadEditStaff()
        {
            StaffAddress = SelectedSTAFF.nhanvien.DIACHI;
            StaffBirthday = SelectedSTAFF.nhanvien.NGAYSINH;
            StaffBirthdayDT = Convert.ToDateTime(StaffBirthday);
            StaffEmail = SelectedSTAFF.nhanvien.EMAIL;
            StaffName = SelectedSTAFF.nhanvien.TENNV;
            StaffPhoneNumber = SelectedSTAFF.nhanvien.SDT;
            StaffRole = SelectedSTAFF.nhanvien.CHUCVU;
        }
    }
}
