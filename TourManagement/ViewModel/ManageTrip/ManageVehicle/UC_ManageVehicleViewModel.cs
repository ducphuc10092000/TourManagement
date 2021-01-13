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
    public class UC_ManageVehicleViewModel : BaseViewModel
    {
        public ICommand Quit_UC_ManageVehicle_Command { get; set; }
        public UC_ManageVehicleViewModel()
        {
            Quit_UC_ManageVehicle_Command = new RelayCommand<Window>((p) =>
            {
                //if (AccountPower == 0 || AccountPower == 1)
                //{
                //    MessageBoxResult result = MessageBox.Show("Bạn không đủ quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                //    return false;
                //}


                return true;
            }, (p) =>
            {
                p.Close();
            });
        }

        public void Setup()
        {
            VEHICLE temp = new VEHICLE();
        }
    }
}
