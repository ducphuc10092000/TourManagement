   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:TourManagement.View.ManageTripTourManagement.View.ManageTrip  5   	   1    +TourManagement.View.ManageTrip.WD_HotelList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:TourManagement.View.ManageTrip     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  wd_HotelList��5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5   	      UC_ManageTripVM � DataContext# [  5   	    � WindowState$ 	Maximized=�5   	    � Title$ WD_HotelList��5   	   $	��900��6   $
��1600��6+   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  * &MaterialDesignFloatingActionMiniButton#���  6   $��5q�5      
����ح�+  %MaterialDesignThemes.Wpf.ShadowAssist	   ShadowDepth$	 Depth3=�5      ��5      �� *QuitCommand+��5      �� 
 �� ElementName$
 wd_HotelList��.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ KeyboardBackspace=�6.   5       #  MaterialDesignThemes.Wpf.Card  5"      $	 Depth2=�6&   $��
20,10,0,10q�5#   *   .��5%      �� $
��Left=�6   $	��200��5&   "   $��14(�5'   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nhập tên Khách sạn��5(   "    �� TextAlignment$
 Left=�5)   "   $��5,0,0,0q�5*   "   ���#E4E4E4��5+   "   �� *HotelNameFind+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated . 5,   "   5-        5.      $	 Depth2=�6&   $��
20,10,0,10q�6W   .��5/      �� $ Tỉnh thành��6   $	��200��51      ���#E4E4E4$��5,0,0,0q�53      $��Center=�54      $
��Left=�55      $��14(�57      $��30��6-   ��50      �� *ProvinceNameList+$ PropertyChanged=� .  �� Text 56      �� *ProvinceNameHotelFind+ �� Mode$ TwoWay=�57   -   58      �� 5;      $��Tìm kiếm��6    �� 	IsDefault .   MaterialDesignRaisedButton#���  5>      $	 Depth4=�5?      
���   �$
��Auto��5A      $��0q�5B      $
��Left=�5C      ���	#FFF0EFEF$��
10,10,0,10q�5D   ,   ��5=      ��  �� Path$ FindHotelCommand�5D   ,   �� 5F      $��Mặc định��6   #���  5H      $	 Depth4=�5I      
���   �$
��Auto��5K      $��0q�5L      $
��Left=�5M      ���	#FFF0EFEF$��
10,10,0,10q�5N   ,   ��5G      �� $ DefaultFindHotelCommand�5N   ,   �� 5P      #���  6   $	 Depth2=�5R      $��Thêm mới��5S      $	��100��5T      
����ح�$
��Left=�5V      $��0q�5W      $��20,0,0,0q�5X      $��30��5Y      ��5Q      �� $ AddHotelCommand�5Y   #   5Z      5[      � 5^   
   $��1��6   $��5,5,10,5q�6   .+�5_      �� .��5`      &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5e         AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5`      �� *HOTELLISTDTG+ . $ PropertyChanged=� �� SelectedItem 5c      �� *SelectedHOTEL+$ PropertyChanged=� .  J� InputBindings 5i      d� 5j       d� Gesture$ LeftDoubleClicka�5k   !    �� Command 5l   !   �� *DoubleClickSelectHotelCommand+ �� CommandParameter 5m   !   �� $
 wd_HotelList�� � 	Resources 5o      )  #System.Windows.Controls.DataGridRow �� 
TargetType  �� Property! �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%e  '        '  �     �� 5p      "  6    .�5q      ��   � ��$! 35��67   6D   �� 5r        � ��$! 13(�69   6F   �� 5s        � ��$! Arial)�6;   6K   5t      �� 5u      "  6    .�5v      ��   � ��$! 30��67   6D   �� 5w        � ��$! Times New Roman)�6;   6U   �� 5x        � ��$! 15(�69   6F   �� 5y        � ��$
! Bold"�6;   6J   �� 5z        � ��$! Center=�6K   6\   �� 5{        � ��$! Center=�6I   6Z   �� 5|        � ��! �#e2e2e26M   �� 5}        � ��
! �   �6L   �� 5~        � ��$! 1,2,1,2q�6@   6R   5      5�      "   Columns" 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,	  &System.Windows.Controls.DataGridColumn# 	  Header$# Mã KS��6-   $ 	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	$ 100
 5�   -   1  +System.Windows.Controls.DataGridBoundColumn%   Binding% 5�   -   �� *khachsan.IDKS+5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $# 	Thao tác��61   $	$ 110
 5�   )   &   CellTemplate& 5�      �� 5�   "   .R�5�   &   � $��0,0,12,0q�6+   ' � ColumnDefinitions' 5�   *   �� 5�   .   $��30 �6?   6L   �� 5�   .   $��30 �6?   6L   .+�5�   *   �� $��0��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��6,0,5,0q�6<   ��5�   1   Z� ��5�   1   �� $" DataContext.EditHotelCommand�( �� RelativeSource( �� *FindAncestor+) �� AncestorType")  ��5�   1   �� $ khachsan.IDKS�.��5�   .   � .+�5�   2   �� $"��..\..\..\Photo\edit_icon.png��68   $��-17,-4,1,-4q�6^   * J� RenderTransformOrigin$* 0.5,0.5&�6s   z�5�   6   V� 5�   :   .~�5�   >   �� + �� ScaleX$+ -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   �� 5�   *   $��1��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��11,0,0,0q�5�   1   ��5�   1   Z� ��5�   1   �� $$ DataContext.DeleteHotelCommand�( �� *FindAncestor+")  ��5�   1   �� $ khachsan.IDKS�.��5�   .   � .+�5�   2   �� $$��..\..\..\Photo\delete_icon.png��68   $��-17,-15,-4,-15q�6`   $* 0.5,0.5&�6x   z�5�   6   V� 5�   :   .~�5�   >   �� $+ -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   5�   '   5�   #   5�        5�      $# Tên KS��6-   $	$ 250
 5�   %   % 5�   %   �� *khachsan.TENKS+5�   3     5�      $# Tỉnh thành��6-   $	$ 250
 5�   %   % 5�   -   �� *khachsan.TINHTHANH+5�   3     5�      $# Trạng thái��6-   $	$ 200
 5�   -   % 5�   -   �� *	TRANGTHAI+5�        5�      $# Mô tả��6-   $	$ 558
 5�   -   % 5�   -   �� *khachsan.MOTA+5�   ;   5�      5�      5�      5�      5�      