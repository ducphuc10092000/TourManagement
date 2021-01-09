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
using TourManagement.View.ManageTour.WD_ManageTour;

namespace TourManagement.ViewModel.ManageTour.WD_ManageTour
{
    public class WD_EditTourViewModel : BaseViewModel
    {
        private int _SelectedTourID;
        public int SelectedTourID { get { return _SelectedTourID; } set { _SelectedTourID = value; OnPropertyChanged(); }}

        #region COMMAND EDITTOUR
        public ICommand QuitCommand { get; set; }
        public ICommand ConfirmEditTourCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        #endregion
        #region BING TEXT EDITTOUR
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

        #region BINDING TEXT PLACE
        private PLACE _SelectedPLACE;
        public PLACE SelectedPLACE { get => _SelectedPLACE; set { _SelectedPLACE = value; OnPropertyChanged(); } }

        private ObservableCollection<PLACE> _TOUR_PLACELISTDTG;
        public ObservableCollection<PLACE> TOUR_PLACELISTDTG { get => _TOUR_PLACELISTDTG; set { _TOUR_PLACELISTDTG = value; OnPropertyChanged(); } }


        private ObservableCollection<CT_DIADIEM_TOUR> _TOUR_PLACE_DETAIL;
        public ObservableCollection<CT_DIADIEM_TOUR> TOUR_PLACE_DETAIL { get => _TOUR_PLACE_DETAIL; set { _TOUR_PLACE_DETAIL = value; OnPropertyChanged(); } }


        private string _PlaceName;
        public string PlaceName { get => _PlaceName; set { _PlaceName = value; OnPropertyChanged(); } }
        #endregion

        

        public WD_EditTourViewModel()
        {
            #region
            QuitCommand = new RelayCommand<WD_EditTour>((p) =>
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
                MessageBoxResult result = MessageBox.Show("Bạn có chắc chắn muốn đặt lại thông tin như cũ?", "Thông báo", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    LoadSelectedTour();
                }
                else
                {
                    return;
                }
                
            });
            ConfirmEditTourCommand = new RelayCommand<Window>((p) =>
            {
                return true;
            }, (p) =>
            {
                TOURs selectedTour = new TOURs();

                if (DataProvider.Ins.DB.TOUR.Where(x => x.TENTOUR == TourName && x.IDTOUR != SelectedTourID).Count() != 0)
                {
                    MessageBox.Show("Tên tour đã trùng lặp, vui lòng chọn tên tour khác!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                selectedTour.EditTour(SelectedTourID,TourName, TourPrice, TourType, TourDescription, TOUR_PLACELISTDTG);


                MessageBoxResult result = MessageBox.Show("Chỉnh sửa lịch trình TOUR thành công!"+  Environment.NewLine + "Bạn có muốn tiếp tục chỉnh sửa?", "Thông báo", MessageBoxButton.YesNo,MessageBoxImage.Information);
                if (result == MessageBoxResult.No)
                {

                    p.Close();
                }
                else
                {
                    return;
                }

                LoadTOUR_PLACELISTDTG();
            });

            #endregion

            #region COMMAND PLACE IN WD_EDITTOUR
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
        }

        public void LoadSelectedTour()
        {
            TOURs selectedTOURs = new TOURs();
            selectedTOURs.tour = DataProvider.Ins.DB.TOUR.Where(x => x.IDTOUR == SelectedTourID).SingleOrDefault();
            if(selectedTOURs.tour.ACTIVE == true)
            {
                selectedTOURs.STATUS = "Hoạt động";
            }    
            else
            {
                selectedTOURs.STATUS = "Không hoạt động";
            }    
            TourName = selectedTOURs.tour.TENTOUR;
            TourPrice = selectedTOURs.tour.GIATOUR;
            TourType = selectedTOURs.tour.LOAIHINH;
            TourDescription = selectedTOURs.tour.MOTA;

            //LOAD PLACELIST 
            LoadTOUR_PLACELISTDTG();
        }
        public void LoadTOUR_PLACELISTDTG()
        {
            TOUR_PLACELISTDTG = new ObservableCollection<PLACE>();
            TOUR_PLACE_DETAIL = new ObservableCollection<CT_DIADIEM_TOUR>(DataProvider.Ins.DB.CT_DIADIEM_TOUR.Where(x => x.IDTOUR == SelectedTourID));

            foreach (var item in TOUR_PLACE_DETAIL)
            {
                PLACE temp = new PLACE();
                temp.diadiem = item.DIADIEM;
                if (item.DIADIEM.ACTIVE == true)
                {
                    temp.TRANGTHAI = "Hoạt động";
                }
                else
                {
                    temp.TRANGTHAI = "Không hoạt động";
                }
                TOUR_PLACELISTDTG.Add(temp);
            }

        }

    }
}
