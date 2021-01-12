using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TourManagement.Model;
using TourManagement.Model.Tour;
using TourManagement.View.ManageTour.ManagePlace;
using TourManagement.View.ManageTour.WD_ManageTour;
using TourManagement.ViewModel.ManageTour.ManagePlace;
using TourManagement.ViewModel.ManageTrip;

namespace TourManagement.ViewModel.ManageTour.WD_ManageTour
{
    public class WD_AddTourViewModel : BaseViewModel
    {
        #region COMMAND ADDTOUR
        public ICommand QuitCommand { get; set; }
        public ICommand AddNewTourCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        #endregion

        #region BING TEXT ADDTOUR
        private string _TourName;
        public string TourName { get => _TourName; set { _TourName = value; OnPropertyChanged(); } }
        private string _TourPrice;
        public string TourPrice { get => _TourPrice; set { _TourPrice = value; OnPropertyChanged(); } }
        private string _TourType;
        public string TourType { get => _TourType; set { _TourType = value; OnPropertyChanged(); } }
        private string _TourDescription;
        public string TourDescription { get => _TourDescription; set { _TourDescription = value; OnPropertyChanged(); } }
        #endregion

        #region COMMAND PLACE IN WD_ADDTOUR
        public ICommand AddPlaceToListCommand { get; set; }
        public ICommand SelectPlaceCommand { get; set; }
        public ICommand DeletePlaceFromListCommand { get; set; }
        #endregion

        #region COMMAND HOTEL
        public ICommand AddHotelCommand { get; set; }
        public ICommand SelectHotelCommand { get; set; }
        public ICommand DeleteHotelFromListCommand { get; set; }
        #endregion

        #region BINDING TEXT PLACE
        private PLACE _SelectedPLACE;
        public PLACE SelectedPLACE { get => _SelectedPLACE; set { _SelectedPLACE = value; OnPropertyChanged(); } }

        private ObservableCollection<PLACE> _TOUR_PLACELISTDTG;
        public ObservableCollection<PLACE> TOUR_PLACELISTDTG { get => _TOUR_PLACELISTDTG; set { _TOUR_PLACELISTDTG = value; OnPropertyChanged(); } }

        private string _PlaceName;
        public string PlaceName { get => _PlaceName; set { _PlaceName = value; OnPropertyChanged(); } }
        #endregion

        #region BINDING TEXT HOTEL
        private HOTEL _SelectedHOTEL;
        public HOTEL SelectedHOTEL { get => _SelectedHOTEL; set { _SelectedHOTEL = value; OnPropertyChanged(); } }

        private ObservableCollection<HOTEL> _TOUR_HOTELLISTDTG;
        public ObservableCollection<HOTEL> TOUR_HOTELLISTDTG { get => _TOUR_HOTELLISTDTG; set { _TOUR_HOTELLISTDTG = value; OnPropertyChanged(); } }
        private string _HotelName;
        public string HotelName { get => _HotelName; set { _HotelName = value; OnPropertyChanged(); } }
        #endregion
        public void ResetParameter()
        {
            TourName = null;
            TourPrice = null;
            TourType = null;
            TourDescription = null;
            TOUR_PLACELISTDTG = new ObservableCollection<PLACE>();
            TOUR_HOTELLISTDTG = new ObservableCollection<HOTEL>();
        }

        public WD_AddTourViewModel()
        { 
            TOUR_PLACELISTDTG = new ObservableCollection<PLACE>();

            TOUR_HOTELLISTDTG = new ObservableCollection<HOTEL>();

            AddNewTourCommand = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                TOURs newTour = new TOURs();
                if(DataProvider.Ins.DB.TOUR.Where(x=>x.TENTOUR == TourName).Count() != 0)
                {
                    MessageBox.Show("Tên tour đã trùng lặp, vui lòng chọn tên tour khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                }    
                newTour.AddNewTour(TourName, TourPrice, TourType, TourDescription, TOUR_PLACELISTDTG);
                MessageBox.Show("Thêm lịch trình TOUR thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                p.Close();
            });

            QuitCommand = new RelayCommand<WD_AddTour>((p) =>
            {
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
            ResetCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá hết thông tin đã nhập?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if(result == MessageBoxResult.Yes)
                {
                    ResetParameter();
                }    
                else
                {
                    return;
                }    
            });

            #region COMMAND PLACE
            SelectPlaceCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                WD_PlaceList wd_placelist = new WD_PlaceList();
                var wd_placelist_DT = wd_placelist.DataContext as UC_ManageTourViewModel;
                wd_placelist_DT.LoadPlaceList();
                wd_placelist.ShowDialog();
                wd_placelist.Close();

                if (wd_placelist_DT.SelectedPLACE == null)
                {
                    return;
                }
                else
                {
                    SelectedPLACE = wd_placelist_DT.SelectedPLACE;
                    PlaceName = SelectedPLACE.diadiem.TENDIADIEM.ToString();
                }
            });
            AddPlaceToListCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (SelectedPLACE == null)
                {
                    return;
                }
                else
                {
                    if (TOUR_PLACELISTDTG.Where(x => x.diadiem.IDDIADIEM == SelectedPLACE.diadiem.IDDIADIEM).Count() != 0)
                    {
                        MessageBox.Show("Địa điểm đã tồn tại trong lịch trình, vui lòng chọn địa điểm khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        SelectedPLACE = null;
                        PlaceName = null;
                    }
                    else
                    {
                        TOUR_PLACELISTDTG.Add(SelectedPLACE);
                        PlaceName = null;
                        SelectedPLACE = null;
                    }
                }
            });
            DeletePlaceFromListCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Bạn chắc chắn muốn xoá địa điểm khỏi lịch trình tour?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    var place = TOUR_PLACELISTDTG.Where(x => x.diadiem.IDDIADIEM == (int)p).SingleOrDefault();
                    TOUR_PLACELISTDTG.Remove(place);
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    return;
                }    
            });
            #endregion

            #region COMMAND HOTEL
            SelectHotelCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                WD_HotelList wd_hotellist = new WD_HotelList();
                var wd_hotellist_DT = wd_hotellist.DataContext as UC_ManageTripViewModel;
                wd_hotellist_DT.LoadHotelList();
                wd_hotellist.ShowDialog();
                wd_hotellist.Close();
                if (wd_hotellist_DT.SelectedHOTEL == null)
                {
                    return;
                }
                else
                {
                    SelectedHOTEL = wd_hotellist_DT.SelectedHOTEL;
                    HotelName = SelectedHOTEL.khachsan.TENKS.ToString();
                }
            });
            AddHotelCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                if (SelectedHOTEL == null)
                {
                    return;
                }
                else
                {
                    if (TOUR_HOTELLISTDTG.Where(x => x.khachsan.IDKS == SelectedHOTEL.khachsan.IDKS).Count() != 0)
                    {
                        MessageBox.Show("Khách sạn đã tồn tại trong lịch trình, vui lòng chọn khách sạn khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                        SelectedHOTEL = null;
                        HotelName = null;
                    }
                    else
                    {
                        TOUR_HOTELLISTDTG.Add(SelectedHOTEL);
                        HotelName = null;
                        SelectedHOTEL = null;
                    }
                }
            });
            DeleteHotelFromListCommand = new RelayCommand<object>((p) =>
            {
                return true;
            }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Bạn chắc chắn muốn xoá khách sạn khỏi lịch trình tour?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    var hotel = TOUR_HOTELLISTDTG.Where(x => x.khachsan.IDKS == (int)p).SingleOrDefault();
                    TOUR_HOTELLISTDTG.Remove(hotel);
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
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
