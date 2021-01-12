using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TourManagement.View.ManageCustomer;
using TourManagement.View.ManageStaff;
using TourManagement.View.ManageTour;
using TourManagement.View.ManageTour.WD_ManageTour;
using TourManagement.ViewModel.ManageCustomer;
using TourManagement.ViewModel.ManageStaff;
using TourManagement.ViewModel.ManageTour;
using TourManagement.ViewModel.ManageTour.WD_ManageTour;

namespace TourManagement.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region Chức năng Button
        public enum CHUCNANG
        {
            DashBoard, ManageTour, ManageTrip, ManageCustomer, ManageStaff, ManageReport, ManageAccount
        }
        private int _ChucNang;
        public int ChucNang { get => _ChucNang; set { _ChucNang = value; OnPropertyChanged(); } }
        #endregion

        #region Declare Binding Command
        public ICommand BtnDashboardCommand { get; set; }
        public ICommand BtnManageTourCommand { get; set; }
        public ICommand BtnManageTripCommand { get; set; }
        public ICommand BtnManageCustomerCommand { get; set; }
        public ICommand BtnManageStaffCommand { get; set; }
        public ICommand BtnManageReportCommand { get; set; }
        public ICommand BtnManageAccountCommand { get; set; }
        public ICommand QuitCommand { get; set; }

        #endregion
        public MainViewModel()
        {
            #region Binding Command
            BtnDashboardCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ChucNang = (int)CHUCNANG.DashBoard;
            });
            BtnManageTourCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                //Set chức năng GRID
                ChucNang = (int)CHUCNANG.ManageTour;

                //Gọi hàm LoadTourList() từ UC_ManageTourViewModel
                UC_ManageTour uc_ManageTour = new UC_ManageTour();
                var uc_ManageTour_DT = uc_ManageTour.DataContext as UC_ManageTourViewModel;
                uc_ManageTour_DT.LoadTourList();
            });
            BtnManageTripCommand = new RelayCommand<object>((p) =>
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
            BtnManageCustomerCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ChucNang = (int)CHUCNANG.ManageCustomer;
                UC_ManageCustomer uc_ManageCustomer = new UC_ManageCustomer();
                var uc_ManageCustomer_DT = uc_ManageCustomer.DataContext as UC_ManageCustomerViewModel;
                uc_ManageCustomer_DT.LoadCustomerList();
            });
            BtnManageStaffCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ChucNang = (int)CHUCNANG.ManageStaff;
                UC_ManageStaff uc_ManageStaff = new UC_ManageStaff();
                var uc_ManageStaff_DT = uc_ManageStaff.DataContext as UC_ManageStaffViewModel;
                uc_ManageStaff_DT.LoadStaffList();
            });
            BtnManageReportCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ChucNang = (int)CHUCNANG.ManageReport;
            });
            BtnManageAccountCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                ChucNang = (int)CHUCNANG.ManageAccount;
            });

            QuitCommand = new RelayCommand<MainWindow>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    p.Close();
                }
                else
                {
                    return;
                }
            });
            #endregion
        }
        
    }
}
