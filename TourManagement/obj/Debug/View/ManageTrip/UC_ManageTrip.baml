   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:TourManagement.View.ManageTripTourManagement.View.ManageTrip  5      g8clr-namespace:TourManagement.View.ManageTour.ManageHotel*TourManagement.View.ManageTour.ManageHotel  5
      k:clr-namespace:TourManagement.View.ManageTrip.ManageVehicle,TourManagement.View.ManageTrip.ManageVehicle  5      2    ,TourManagement.View.ManageTrip.UC_ManageTrip   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:TourManagement.View.ManageTrip     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      NviewManageHotel8clr-namespace:TourManagement.View.ManageTour.ManageHotel  5
      RviewManageVehicle:clr-namespace:TourManagement.View.ManageTrip.ManageVehicle  5      
�������   UC_ManageTripVM  � DataContext#  [  5      .��5      � .+�5   
   � ��5      �� 5       �� 
TargetType" �6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�63   6G    �� Triggers 5      �� 5       �� Binding 6&   �� *
ChucNang+ �� Value 06C   .a�5      ��  � y�$ Visible=�6;   6M   5      5      .+�5      �� 
���   �$��2q�5      $��5q�5      ._�5      �  � RowDefinitions 5      �� 5       $��50 �6(   66   �� 5!      6*   .+�5$      � $��0��6   .+�5%      ��  �� Orientation$ 
Horizontal=�6%   .+�5'      #  MaterialDesignThemes.Wpf.Card  +  %MaterialDesignThemes.Wpf.ShadowAssist	   ShadowDepth$	 Depth2=�62   $��
20,10,0,10q�5(   *   .��5*   "   �� $
��Left=�6*   $	��300��5+   "   $��16(�5,   "   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$"
 Nhập tên đoàn du lịch��5-   "    �� TextAlignment$
 Left=�5.   "   $��5,0,0,0q�5/   "   ���#E4E4E4��50   "   �� *TripNameFind+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated . 51   "   52      �� 5A      $��Tìm kiếm��6%    �� 	IsDefault .   MaterialDesignRaisedButton#���  5D      $	 Depth4=�5E      
���   �$
��Auto��5G      $��0q�5H      $
��Left=�5I      ���	#FFF0EFEF$��
10,10,0,10q�5J   ,   ��5C      ��  �� Path$ TripFindCommand�5J   ,   �� 5L      $��Mặc định��6%   #���  5N      $	 Depth4=�5O      
���   �$
��Auto��5Q      $��0q�5R      $
��Left=�5S      ���	#FFF0EFEF$��
10,10,0,10q�5T   ,   ��5M      �� $ DefaultTripFindCommand�5T   ,   �� 5V      #���  6%   $	 Depth2=�5X      $��Thêm mới��5Y      $	��100��5Z      
����ح�$
��Left=�5\      $��0q�5]      $��20,0,0,0q�5^      $��30��5_      ��5W      �� $ AddTripCommand�5_   #   �� 5a      $��QL KHÁCH SẠN��6%    . #���  5d      $	 Depth4=�5e      
���   �$
��Auto��5g      $��0q�5h      $
��Left=�5i      ���	#FFFFBC5B$��520,10,0,10q�5j   ,   ��5c      �� $ BtnManageHotelCommand�5j   ,   �� 5l      $��QL PHƯƠNG TIỆN��6%    . $��
20,10,0,10q�5n      #���  5p      $	 Depth4=�5q      
���   �$
��Auto��5s      $��0q�5t      $
��Left=�5u      ���	#FFFFBC5B��5o      �� $ BtnManageVehicleCommand�5v      5w      5x      � 5z      $��1��6   $��5,5,10,5q�6(   .+�5{      �� .��5|      &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5�   '   
���   �$��0,0,2,0q�5�   '      AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5|   '   �� *TRIPLISTDTG+ . $ PropertyChanged=� �� SelectedItem 5   '   �� *SelectedTRIP+$ PropertyChanged=� .  �� Mode$ TwoWay=� � 	Resources 5�   "   )  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%e  '        '  �     �� 5�   &   "  6,   .�5�   *   ��  � ��$ 35��6C   6P   �� 5�   *    � ��$ 13(�6E   6R   �� 5�   *    � ��$ Arial)�6G   6W   5�   '   �� 5�   &   "  6,   .�5�   *   ��  � ��$ 30��6C   6P   �� 5�   *    � ��$ Times New Roman)�6G   6a   �� 5�   *    � ��$ 15(�6E   6R   �� 5�   *    � ��$
 Bold"�6G   6V   �� 5�   *    � ��$ Center=�6W   6h   �� 5�   *    � ��$ Center=�6U   6f   �� 5�   *    � �� �#e2e2e26Y   �� 5�   *    � ��
 �   �6X   �� 5�   *    � ��$ 1,1,0,1q�6L   6^   5�   '   5�   #      Columns 5�   "   0  *System.Windows.Controls.DataGridTextColumn  5�   &   ,  &System.Windows.Controls.DataGridColumn   Header$ 
Mã đoàn��69      Width5	  /System.Windows.Controls.DataGridLengthConverter$	 100	 5�   -   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 5�   -   �� *doan.IDDOAN+5�   '   4  .System.Windows.Controls.DataGridTemplateColumn  5�   &   $ 	Thao tác��6=   $	 110	 5�   )      CellTemplate 5�   *   �� 5�   .   .R�5�   2   � $��0,0,12,0q�67    � ColumnDefinitions 5�   6   �� 5�   :   $��30 �6K   6X   �� 5�   :   $��30 �6K   6X   .+�5�   6   �� $��0��6=   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��6,0,5,0q�6<   ��5�   1   Z� ��5�   1   �� $! DataContext.EditTripCommand� �� RelativeSource �� *FindAncestor+ �� AncestorType"  ��5�   1   �� $ doan.IDDOAN�.��5�   :   � .+�5�   >   �� $��..\..\Photo\edit_icon.png��6D   $��-17,-4,1,-4q�6g     J� RenderTransformOrigin$  0.5,0.5&�6|   z�5�   B   V� 5�   F   .~�5�   J   �� ! �� ScaleX$! -1Q�6Y   �� 5�   J   �� 5�   J   T� 5�   J   5�   G   5�   ?   5�   ;   5�   7   �� 5�   6   $��1��6=   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��11,0,0,0q�5�   1   ��5�   1   Z� ��5�   1   �� $$ DataContext.DeletePlaceCommand� �� *FindAncestor+"  ��5�   1   �� $ khachhang.IDKH�.��5�   :   � .+�5�   >   �� $!��..\..\Photo\delete_icon.png��6D   $��-17,-15,-4,-15q�6i   $  0.5,0.5&�6�   z�5�   B   V� 5�   F   .~�5�   J   �� $! -1Q�6Y   �� 5�   J   �� 5�   J   T� 5�   J   5�   G   5�   ?   5�   ;   5�   7   5�   3   5�   /   5�   '     5�   &   $ Tên đoàn du lịch��69   $	 300	 5�   %    5�   %   �� *doan.TENDOAN+5�   3     5�   &   $ 	Doanh thu��69   $	 150	 5�   9    5�   9   �� *doan.DOANHTHU+5�   G     5�   &   $ SL khách hàng��69   $	 150	 5�   %    5�   -   �� *doan.SOLUONGKH+5�   3     5�   &   $ SL phương tiện��69   $	 150	 5�   %    5�   -   �� *doan.SOLUONGPT+5�   3     5�   &   $ Ngày bắt đầu��69   $	 250	 5�   -    5�   -   �� *doan.NGAYBATDAU+5�   '     5�   &   $ Ngày kết thúc��69   $	 250	 5�   -    5�   -   �� *doan.NGAYKETTHUC+5�   ;   5�      5�      5�      5�      5�      5�      � 5   
   ��5     �� 5     " �6   .�5     ��  � y�$ 	Collapsed=�63   6G    5     �� 5      6&   �� *
ChucNang+ 16C   .a�5     ��  � y�$ Visible=�6;   6M   5     5	     .+�5     ?   9TourManagement.View.ManageTour.ManageHotel.UC_ManageHotel  6/   5     � 5  
   ��5     �� 5     " �6   .�5     ��  � y�$ 	Collapsed=�5     61    5     �� 5      6&   �� *
ChucNang+ 25  &   .a�5     ��  � y�$ Visible=�5  %   67   5     5     .+�5     C   =TourManagement.View.ManageTrip.ManageVehicle.UC_ManageVehicle  63   5     5     5      