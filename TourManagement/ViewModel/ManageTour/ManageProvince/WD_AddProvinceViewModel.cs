using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TourManagement.Model;
using TourManagement.Model.Tour;
using TourManagement.View.ManageTour.ManageProvince;
using TourManagement.ViewModel.ManageTour.ManagePlace;

namespace TourManagement.ViewModel.ManageTour.ManageProvince
{
    public class WD_AddProvinceViewModel : BaseViewModel
    {
        #region Text Binding
        private string _ProvinceName;
        public string ProvinceName { get => _ProvinceName; set { _ProvinceName = value; OnPropertyChanged(); } }
        #endregion
        #region COMMAND
        public ICommand AddProvinceCommand { get; set; }
        public ICommand QuitCommand { get; set; }
        #endregion

        public WD_AddProvinceViewModel()
        {
            AddProvinceCommand = new RelayCommand<WD_AddProvince>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                if (string.IsNullOrEmpty(ProvinceName))
                {
                    MessageBox.Show("Hãy nhập thông tin còn thiếu!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (DataProvider.Ins.DB.TINHTHANH.Where(x => x.TENTT == ProvinceName).SingleOrDefault() != null)
                {
                    MessageBox.Show("Tỉnh thành này đã có trong cơ sở dữ liệu, không được thêm");
                }
                else
                {
                    PROVINCE newProvince = new PROVINCE();
                    newProvince.AddNewProvince(ProvinceName);
                    MessageBox.Show("Thêm tỉnh thành thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    p.Close();
                }
            });
            QuitCommand = new RelayCommand<WD_AddProvince>((p) =>
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
        }
        public void Reset()
        {
            ProvinceName = null;
        }
    }
}
