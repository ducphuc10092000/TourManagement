using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TourManagement.Model.Customer;
using TourManagement.Model.Tour;
using TourManagement.View.ManageTrip;
using TourManagement.ViewModel.ManageCustomer;
using TourManagement.ViewModel.ManageTour;

namespace TourManagement.ViewModel.ManageTrip
{
    public class WD_AddTripViewModel : BaseViewModel
    {

        private TOURs _SelectedTOURs;
        public TOURs SelectedTOURs { get => _SelectedTOURs; set { _SelectedTOURs = value; OnPropertyChanged(); } }

        private CUSTOMER _SelectedCUSTOMER;
        public CUSTOMER SelectedCUSTOMER { get => _SelectedCUSTOMER; set { _SelectedCUSTOMER = value; OnPropertyChanged(); } }

        private ObservableCollection<CUSTOMER> _TRIP_CUSTOMERLISTDTG;
        public ObservableCollection<CUSTOMER> TRIP_CUSTOMERLISTDTG { get => _TRIP_CUSTOMERLISTDTG; set { _TRIP_CUSTOMERLISTDTG = value; OnPropertyChanged(); } }

        

        #region Command WD_AddTrip
        public ICommand QuitCommand { get; set; }

        public ICommand SelectCustomerCommand { get; set; }

        public ICommand AddCustomerToTripCommand { get; set; }

        public ICommand SelectTourCommand { get; set; }
        #endregion
        public WD_AddTripViewModel()
        {
            TRIP_CUSTOMERLISTDTG = new ObservableCollection<CUSTOMER>();

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
                SelectedTOURs = wd_TourList_DT.SelectedTOURs;
                wd_TourList.Close();
            });

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
                    if(TRIP_CUSTOMERLISTDTG.Where(x=>x.khachhang.IDKH == SelectedCUSTOMER.khachhang.IDKH).Count() != 0)
                    {
                        MessageBox.Show("Khách hàng đã tồn tại trong đoàn, vui lòng chọn khách hàng khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        SelectedCUSTOMER = null;
                        return;
                    }    
                    else
                    {

                        TRIP_CUSTOMERLISTDTG.Add(SelectedCUSTOMER);
                        SelectedCUSTOMER = null;
                    }    
                }    
            });
        }
    }
}
