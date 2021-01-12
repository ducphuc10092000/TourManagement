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
using TourManagement.Model.Customer;
using TourManagement.View.ManageCustomer;

namespace TourManagement.ViewModel.ManageCustomer
{
    public class UC_ManageCustomerViewModel : BaseViewModel
    {
        #region BINDING TEXT WD_CustomerList
        private string _SelectedCustomerID;
        public string SelectedCustomerID { get => _SelectedCustomerID; set { _SelectedCustomerID = value; OnPropertyChanged(); } }

        private CUSTOMER _SelectedCUSTOMER;
        public CUSTOMER SelectedCUSTOMER { get => _SelectedCUSTOMER; set { _SelectedCUSTOMER = value; OnPropertyChanged(); } }
        #endregion

        private ObservableCollection<KHACHHANG> _CUSTOMERLIST;
        public ObservableCollection<KHACHHANG> CUSTOMERLIST { get => _CUSTOMERLIST; set { _CUSTOMERLIST = value; OnPropertyChanged(); } }

        private ObservableCollection<CUSTOMER> _CUSTOMERLISTDTG;
        public ObservableCollection<CUSTOMER> CUSTOMERLISTDTG { get => _CUSTOMERLISTDTG; set { _CUSTOMERLISTDTG = value; OnPropertyChanged(); } }

        private string _CustomerNameFind;
        public string CustomerNameFind { get => _CustomerNameFind; set { _CustomerNameFind = value; OnPropertyChanged(); } }

        #region Command 
        public ICommand AddCustomerCommand { get; set; }
        public ICommand EditCustomerCommand { get; set; }
        public ICommand CustomerFindCommand { get; set; }
        public ICommand DefaultCustomerFindCommand { get; set; }
        #endregion

        #region DECALRE COMMAND WD_CUSTOMERLIST
        public ICommand QuitCommand { get; set; }
        public ICommand DoubleClickSelectCustomerCommand { get; set; }
        #endregion

        public UC_ManageCustomerViewModel()
        {
            #region COMMAND UC_MANAGECUSTOMER
            CustomerFindCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                if (string.IsNullOrEmpty(CustomerNameFind))
                {
                    return;
                }

                CollectionViewSource.GetDefaultView(CUSTOMERLISTDTG).Filter = (customerfind) =>
                {
                    return (customerfind as CUSTOMER).khachhang.TENKH.IndexOf(CustomerNameFind, StringComparison.OrdinalIgnoreCase) >= 0;
                };
            });
            DefaultCustomerFindCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                CustomerNameFind = null;
                CollectionViewSource.GetDefaultView(CUSTOMERLISTDTG).Filter = (all) => { return true; };
            });
            AddCustomerCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_AddCustomer wd_addcustomer = new WD_AddCustomer();
                var wd_addcustomer_DT = wd_addcustomer.DataContext as WD_AddCustomerViewModel;

                wd_addcustomer.ShowDialog();
                wd_addcustomer.Close();
                LoadCustomerList();
            });
            EditCustomerCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_EditCustomer wd_editcustomer = new WD_EditCustomer();
                var wd_editcustomer_DT = wd_editcustomer.DataContext as WD_EditCustomerViewModel;
                wd_editcustomer_DT.SelectedCustomerID = (int)p;
                wd_editcustomer_DT.LoadInfoSelectedCustomer();
                wd_editcustomer.ShowDialog();
                wd_editcustomer.Close();

                LoadCustomerList();
            });
            #endregion
            #region COMMAND WD_CUSTOMERLIST
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
                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(result == MessageBoxResult.Yes)
                {
                    p.Close();
                }    
                else
                {
                    return;
                }    
            });
            DoubleClickSelectCustomerCommand = new RelayCommand<Window>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                if(SelectedCUSTOMER == null)
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
        public void LoadCustomerList()
        {
            CUSTOMERLIST = new ObservableCollection<KHACHHANG>(DataProvider.Ins.DB.KHACHHANG.Where(x=>x.ACTIVE == true));
            CUSTOMERLISTDTG = new ObservableCollection<CUSTOMER>();
            foreach(var item in CUSTOMERLIST)
            {
                CUSTOMER temp = new CUSTOMER();
                temp.khachhang = item;
                if(item.ACTIVE == true)
                {
                    temp.GIOITINH = "Nam";
                }    
                else
                {
                    temp.GIOITINH = "Nữ";
                }    
                CUSTOMERLISTDTG.Add(temp);
            }    
        }
    }
}
