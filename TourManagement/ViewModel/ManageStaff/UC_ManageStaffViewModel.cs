using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourManagement.Model;
using TourManagement.Model.Staff;
using TourManagement.View.ManageStaff;

namespace TourManagement.ViewModel.ManageStaff
{
    public class UC_ManageStaffViewModel : BaseViewModel
    {
        private ObservableCollection<NHANVIEN> _STAFFLIST;
        public ObservableCollection<NHANVIEN> STAFFLIST { get => _STAFFLIST; set { _STAFFLIST = value; OnPropertyChanged(); } }

        private ObservableCollection<STAFF> _STAFFLISTDTG;
        public ObservableCollection<STAFF> STAFFLISTDTG { get => _STAFFLISTDTG; set { _STAFFLISTDTG = value; OnPropertyChanged(); } }
        
        private STAFF _SelectedSTAFF;
        public STAFF SelectedSTAFF { get => _SelectedSTAFF; set { _SelectedSTAFF = value; OnPropertyChanged(); } }

        public ICommand AddStaffCommand { get; set; }
        public ICommand EditStaffCommand { get; set; }

        public  UC_ManageStaffViewModel()
        {
            LoadStaffList();
            AddStaffCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                WD_AddStaff wd_AddStaff = new WD_AddStaff();
                wd_AddStaff.ShowDialog();
                wd_AddStaff.Close();
                LoadStaffList();
            });
            EditStaffCommand = new RelayCommand<object>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                if(SelectedSTAFF == null)
                {
                    return;
                }    
                else
                {
                    WD_EditStaff wd_EditStaff = new WD_EditStaff();
                    var wd_EditStaff_DT = wd_EditStaff.DataContext as WD_EditStaffViewModel;
                    wd_EditStaff_DT.SelectedSTAFF = SelectedSTAFF;
                    wd_EditStaff_DT.LoadEditStaff();
                    wd_EditStaff.ShowDialog();
                    wd_EditStaff.Close();
                    LoadStaffList();
                }    
            });

        }

        public void LoadStaffList()
        {
            STAFFLIST = new ObservableCollection<NHANVIEN>(DataProvider.Ins.DB.NHANVIEN);
            STAFFLISTDTG = new ObservableCollection<STAFF>();
            foreach (var item in STAFFLIST)
            {
                STAFF temp = new STAFF();
                temp.nhanvien = item;
                STAFFLISTDTG.Add(temp);
            }
        }

    }
}
