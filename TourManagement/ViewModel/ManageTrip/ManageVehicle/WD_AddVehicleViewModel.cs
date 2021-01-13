using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TourManagement.Model.Trip;

namespace TourManagement.ViewModel.ManageTrip.ManageVehicle
{
    public class WD_AddVehicleViewModel : BaseViewModel
    {
        public ICommand QuitCommand { get; set; }
        public ICommand AddNewVehicleCommand { get; set; }
        public ICommand ConfirmEditVehicleCommand { get; set; }

        private VEHICLE _SelectedVEHICLE;
        public VEHICLE SelectedVEHICLE { get => _SelectedVEHICLE; set { _SelectedVEHICLE = value; OnPropertyChanged(); } }

        private string _VehicleNumber;
        public string VehicleNumber { get => _VehicleNumber; set { _VehicleNumber = value; OnPropertyChanged(); } }
        private string _VehicleType;
        public string VehicleType { get => _VehicleType; set { _VehicleType = value; OnPropertyChanged(); } }
        private int _VehicleSeatNumber;
        public int VehicleSeatNumber { get => _VehicleSeatNumber; set { _VehicleSeatNumber = value; OnPropertyChanged(); } }

        public WD_AddVehicleViewModel()
        {
            ConfirmEditVehicleCommand = new RelayCommand<Window>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                SelectedVEHICLE.EditVehicle(SelectedVEHICLE.phuongtien.IDPT, VehicleType, VehicleSeatNumber,VehicleNumber);
                MessageBox.Show("Chỉnh sửa thông tin phương tiện thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                p.Close();
            });
            AddNewVehicleCommand = new RelayCommand<Window>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                VEHICLE newvehicle = new VEHICLE();
                newvehicle.AddNewVehicle(VehicleType, VehicleSeatNumber, VehicleNumber);
                MessageBox.Show("Thêm thông tin phương tiện thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                p.Close();
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
                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if(result == MessageBoxResult.Yes)
                {
                    p.Close();
                }
                else
                {
                    return;
                }    
            });
        }

        public void LoadEditVehicle()
        {
            VehicleNumber = SelectedVEHICLE.phuongtien.BKS;
            VehicleSeatNumber = Convert.ToInt32(SelectedVEHICLE.phuongtien.SOGHE);
            VehicleType = SelectedVEHICLE.phuongtien.LOAIPT;
        }
    }
}
