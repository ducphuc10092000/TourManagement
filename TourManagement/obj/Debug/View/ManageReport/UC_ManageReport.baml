   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:TourManagement.View.ManageReport TourManagement.View.ManageReport  5      6    0TourManagement.View.ManageReport.UC_ManageReport   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      @local.clr-namespace:TourManagement.View.ManageReport     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Language$  vi-VN�5	      
�������   UC_ManageTripVM � DataContext# [  5      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��5q�5      
���   �$��2q�5      ._�5      � .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6+   $��50��5   +   .��5      ]� .+�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $��Center=�6(   $��20(�5   (   $��16 0 0 0q�5   (   Thống kê doanh số TOUR5      5       5!      5"      � 5#      $��0,50,0,0q�6    � RowDefinitions 5$      �� 5%      $��70 �6(   66   �� 5&      $��70 �6(   66   �� 5'      6*   �� 5(      $��70 �6(   66   .+�5*      �� $��0��6!   $ 
Horizontal=�5+   !   .+�5,      �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Tên tour��6"   /  )MaterialDesignThemes.Wpf.ValidationAssist   HasError . $	��300��5.   "   $��0,-5,0,0q�50   "   $��
20,15,0,10q�51   "   $��20(�52   "    % !MaterialDesignFloatingHintTextBox#��[ 53   "   ��5/   "   �� *SelectedTOURs.tour.TENTOUR+53   "   �� 54      $��35��6!   $	��120��55   !   $��15(�56   !   $��5,0,20,0q�57   !   ���	#FFADD8E6$��Center=�59   !   $��Center=�5:   !   +  %MaterialDesignThemes.Wpf.RippleAssist   Feedback �	#FF03A9F4  MaterialDesignRaisedButton#���  5=   !   +  %MaterialDesignThemes.Wpf.ShadowAssist	   ShadowDepth$	 Depth1=�5>   !   ��5<   !   �� *SelectTourCommand+.��5>   R   Chọn Tour5@      �� 5A      $��40��6!   $	��150��5B   !   $��30,0,0,0q�5C   !   ���	#FFADD8E6#���  5G   !   $	 Depth3=�5H   !   ��5E   !   �� *ResetTourCommand+��5F   !   �� 
 �� ElementName$
 wd_AddCustomer��.��5H   R   Reset5J      5K      �� 5L      
���   �$��1��5M      $��0,1,0,0q�5N      $��0,2,0,2q�5O      ._�5P      �� $ 
Horizontal=�6&   $��Center=�5Q   %   $
��Left=�5R   %   .+�5S      (  "System.Windows.Controls.DatePicker  $ 
Từ ngày��6)   
�������$��55��5U   )   $	��200��5V   )      SelectedDateFormat$ Short=�5X   )   $��	20,0,20,0q�5Y   )   $��30,10,10,10q�5Z   )   $
��Left=�5[   )    ( $MaterialDesignFloatingHintDatePicker#��[ 5\   )   $��20(�5]   )      Text 5W   )   �� *TripStart_ReportTour_DT+ �� StringFormat$ 
dd/MM/yyyy�� �� Mode$ TwoWay=� �� NotifyOnSourceUpdated .  �� UpdateSourceTrigger$ Default=�5]   )     5^      $ Đến ngày��6)   
�������$��55��5`   )   $	��200��5a   )   $ Short=�5c   )   $��35,0,0,0q�5d   )   $��30,10,10,10q�5e   )   $
��Left=�5f   )   #��[ 5g   )   $��20(�5h   )    5b   )   �� *TripEnd_ReportTour_DT+$ 
dd/MM/yyyy��$ TwoWay=� . $ Default=�5h   )   �� 5i      $��40��6%   $	��150��5j   %   $��30,0,0,0q�5k   %   ���	#FFADD8E6#���  5o   %   $	 Depth3=�5p   %   ��5m   %   �� *ReportTourCommand+��5n   %   �� $
 wd_AddCustomer��.��5p   V   Thống kê5r      5s      5t      � 5u      $��2��6   $��5,5,10,5q�5v      .+�5w      �� .��5x      &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5}   '   
���   �$��2,0,2,2q�5   '      AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5x   '   �� *TRIPLISTDTG_REPORTTOUR+ . $ PropertyChanged=� �� SelectedItem 5{   '   �� *SelectedTRIP+$ PropertyChanged=� . $ TwoWay=� � 	Resources 5�   "   )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property �� Value=	  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '        '	  �     �� 5�   &   "  6,   .�5�   *   ��  � ��$ 35��5�   1   6>   �� 5�   *    � ��$ 13(�5�   1   6>   �� 5�   *    � ��$ Arial)�5�   1   6A   5�   '   �� 5�   &   " 	 6,   .�5�   *   ��  � ��$ 30��5�   1   6>   �� 5�   *    � ��$ Times New Roman)�5�   1   6K   �� 5�   *    � ��$ 15(�5�   1   6>   �� 5�   *    � ��$
 Bold"�5�   1   6@   �� 5�   *    � ��$ Center=�5�   1   6B   �� 5�   *    � ��$ Center=�5�   1   6B   �� 5�   *    � �� �#e2e2e25�   C   �� 5�   *    � ��
 �   �5�   A   �� 5�   *    � ��$ 1,1,0,1q�5�   1   6C   5�   '   5�   #      Columns 5�   "   0
  *System.Windows.Controls.DataGridTextColumn
  5�   &   ,  &System.Windows.Controls.DataGridColumn   Header$ 
Mã đoàn��69      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 5�   9   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5�   9   �� *doan.IDDOAN+5�   '   4  .System.Windows.Controls.DataGridTemplateColumn  5�   &   $ 	Thao tác��6=   $	 110 5�   =      CellTemplate 5�   *   �� 5�   .   .R�5�   2   � .+�5�   6   �� $��0��6=   $��0q�5�   =   $
��Auto��5�   =   $��20��5�   =   $��6,0,5,0q�5�   =   ��5�   =   Z� ��5�   =   ��   �� Path$!  DataContext.EditTripCommand�! �� RelativeSource! �� *FindAncestor+" �� AncestorType""  ��5�   =   �� $  doan.IDDOAN�.��5�   :   � .+�5�   >   �� $��..\..\Photo\edit_icon.png��6D   $��-17,-4,1,-4q�5�   D   # J� RenderTransformOrigin$# 0.5,0.5&�5�   D   z�5�   B   V� 5�   F   .~�5�   J   �� $ �� ScaleX$$ -1Q�6Y   �� 5�   J   �� 5�   J   T� 5�   J   5�   G   5�   ?   5�   ;   5�   7   5�   3   5�   /   5�   '   
  5�   &   $ Tên đoàn du lịch��69   $	 300 5�   9    5�   9   �� *doan.TENDOAN+5�   G   
  5�   &   $ 	Doanh thu��69   $	 370 5�   9    5�   9   �� *doan.DOANHTHU+5�   G   5�      5�      5�      �� 5�      $��3��6   
���   �$��2q�5�      ._�5�      �� $��0��6%   $ 
Horizontal=�5�   %   .+�5�      �� $ Số đoàn tham quan��6&    . $	��200��5�   &   $��0,-5,0,0q�5�   &   $��
20,10,0,10q�5�   &   $��20(�5�   &   #��[ 5�   &   ��5�   &   �� *NumberOfTrip_ReportTour+5�   &   �� 5�      $ Tổng doanh số��6&    . $	��300��5�   &   $��0,-5,0,0q�5�   &   $��
20,10,0,10q�5�   &   $��20(�5�   &   #��[ 5�   &   ��5�   &   �� *TotalSalesOfTrip_ReportTour+5�   &   5�      5�      5�      5�      5�      �� 5�   
   $��1��6   $��5q�5�      
���   �$��2q�5�      ._�5�      � .+�5�        $ 
PrimaryMid=�6+   $��50��5�   +   .��5�      ]� .+�5�      �� $ 
Horizontal=�6%   .+�5�      �� $��Center=�6(   $��20(�5�   (   $��16 0 0 0q�5�   (   31Thống kê số lần đi TOUR của nhân viên5�      5      5     5     � 5     $��0,50,0,0q�6    5     �� 5     $��70 �6(   66   �� 5     $��70 �6(   66   �� 5     6*   �� 5     $��70 �6(   66   .+�5
     �� $��0��6!   $ 
Horizontal=�5  !   .+�5     �� $ Tên nhân viên��6"    . $	��300��5  "   $��0,-5,0,0q�5  "   $��
20,15,0,10q�5  "   $��20(�5  "   #��[ 5  "   ��5  "   �� *SelectedSTAFF.nhanvien.TENNV+5  "   �� 5     $��35��6!   $	��150��5  !   $��15(�5  !   $��5,0,20,0q�5  !   ���	#FFADD8E6$��Center=�5  !   $��Center=�5  !    �	#FF03A9F4#���  5  !   $	 Depth1=�5  !   ��5  !   �� *SelectStaffCommand+.��5  R   Chọn nhân viên5      �� 5!     $��40��6!   $	��150��5"  !   $��30,0,0,0q�5#  !   ���	#FFADD8E6#���  5'  !   $	 Depth3=�5(  !   ��5%  !   �� *ResetStaffCommand+��5&  !   �� $
 wd_AddCustomer��.��5(  R   Reset5*     5+     �� 5,     
���   �$��1��5-     $��0,1,0,0q�5.     $��0,2,0,2q�5/     ._�50     �� $ 
Horizontal=�6&   $��Center=�51  &   $
��Left=�52  &   .+�53       $ 
Từ ngày��6)   
�������$��55��55  )   $	��200��56  )   $ Short=�58  )   $��	20,0,20,0q�59  )   $��30,10,10,10q�5:  )   $
��Left=�5;  )   #��[ 5<  )   $��20(�5=  )    57  )   �� *TripStart_ReportStaff_DT+$ 
dd/MM/yyyy��$ TwoWay=� . $ Default=�5=  )     5>     $ Đến ngày��6)   
�������$��55��5@  )   $	��200��5A  )   $ Short=�5C  )   $��35,0,0,0q�5D  )   $��30,10,10,10q�5E  )   $
��Left=�5F  )   #��[ 5G  )   $��20(�5H  )    5B  )   �� *TripEnd_ReportStaff_DT+$ 
dd/MM/yyyy��$ TwoWay=� . $ Default=�5H  )   �� 5I     $��40��6%   $	��150��5J  %   $��30,0,0,0q�5K  %   ���	#FFADD8E6#���  5O  %   $	 Depth3=�5P  %   ��5M  %   �� *ReportStaffCommand+��5N  %   �� $
 wd_AddCustomer��.��5P  V   Thống kê5R     5S     5T     � 5U     $��2��6   $��5,5,10,5q�5V     .+�5W     �� .��5X        �#e2e2e2 . $
��Auto=�5]  '   
���   �$��0,0,2,0q�5_  '    .   .   .  ��5X  '   �� *TRIPLISTDTG_REPORTSTAFF+ . $ PropertyChanged=� 5[  '   �� *SelectedTRIP+$ PropertyChanged=� . $ TwoWay=� 5c  "   ��%�  '        '	  �     �� 5d  &   "  6,   .�5e  *   ��  � ��$ 35��5f  1   6>   �� 5g  *    � ��$ 13(�5h  1   6>   �� 5i  *    � ��$ Arial)�5j  1   6A   5k  '   �� 5l  &   " 	 6,   .�5m  *   ��  � ��$ 30��5n  1   6>   �� 5o  *    � ��$ Times New Roman)�5p  1   6K   �� 5q  *    � ��$ 15(�5r  1   6>   �� 5s  *    � ��$
 Bold"�5t  1   6@   �� 5u  *    � ��$ Center=�5v  1   6B   �� 5w  *    � ��$ Center=�5x  1   6B   �� 5y  *    � �� �#e2e2e25z  C   �� 5{  *    � ��
 �   �5|  A   �� 5}  *    � ��$ 1,1,0,1q�5~  1   6C   5  '   5�  #    5�  "   
  5�  &   $ 
Mã đoàn��69   $	 100 5�  9    5�  9   �� *doan.IDDOAN+5�  '     5�  &   $ 	Thao tác��6=   $	 110 5�  =    5�  *   �� 5�  .   .R�5�  2   � .+�5�  6   �� $��0��6=   $��0q�5�  =   $
��Auto��5�  =   $��20��5�  =   $��6,0,5,0q�5�  =   ��5�  =   Z� ��5�  =   �� $!  DataContext.EditTripCommand�! �� *FindAncestor+""  ��5�  =   �� $  doan.IDDOAN�.��5�  :   � .+�5�  >   �� $��..\..\Photo\edit_icon.png��6D   $��-17,-4,1,-4q�5�  D   $# 0.5,0.5&�5�  D   z�5�  B   V� 5�  F   .~�5�  J   �� $$ -1Q�6Y   �� 5�  J   �� 5�  J   T� 5�  J   5�  G   5�  ?   5�  ;   5�  7   5�  3   5�  /   5�  '   
  5�  &   $ Tên đoàn du lịch��69   $	 300 5�  9    5�  9   �� *doan.TENDOAN+5�  G   
  5�  &   $ 	Doanh thu��69   $	 370 5�  9    5�  9   �� *doan.DOANHTHU+5�  G   5�     5�     5�     �� 5�     $��3��6   
���   �$��2q�5�     ._�5�     �� $��0��6%   $ 
Horizontal=�5�  %   .+�5�     �� $  Tổng số lần đi tour��6&    . $	��200��5�  &   $��0,-5,0,0q�5�  &   $��
20,10,0,10q�5�  &   $��20(�5�  &   #��[ 5�  &   ��5�  &   �� *NumberOfTrip_ReportStaff+5�  &   5�     5�     5�     5�     5�     5�     5�     