   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:TourManagement.View.ManageTour.WD_ManageTour,TourManagement.View.ManageTour.WD_ManageTour  5   	   ?    9TourManagement.View.ManageTour.WD_ManageTour.WD_HotelList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Llocal:clr-namespace:TourManagement.View.ManageTour.WD_ManageTour     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  wd_HotelList��5   	    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	      UC_ManageTourVM � DataContext# [  5   	    � Title$ WD_HotelList��5   	   $	��900��6   $
��1600��6+   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  * &MaterialDesignFloatingActionMiniButton#���  6   $��5q�5      
����ح�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5      ��5      �� *QuitCommand+��5      �� 	 �� ElementName$	 wd_HotelList��.��5      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 KeyboardBackspace=�6.   5      #  MaterialDesignThemes.Wpf.Card  5!      $ Depth2=�6&   $��
20,10,0,10q�5"   *   .��5$      �� $
��Left=�6   $	��200��5%   "   $��14(�5&   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nhập tên Khách sạn��5'   "    �� TextAlignment$
 Left=�5(   "   $��5,0,0,0q�5)   "   ���#E4E4E4��5*   "   �� *HotelNameFind+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated . 5+   "   5,        5-      $ Depth2=�6&   $��
20,10,0,10q�6W   .��5.      �� $ Tỉnh thành��6   $	��200��50      ���#E4E4E4$��5,0,0,0q�52      $��Center=�53      $
��Left=�54      $��14(�56      $��30��6-   ��5/      �� *ProvinceNameList+$ PropertyChanged=� .  �� Text 55      �� *ProvinceNameHotelFind+ �� Mode$ TwoWay=�56   -   57      �� 5:      $��Tìm kiếm��6    �� 	IsDefault .   MaterialDesignRaisedButton#���  5=      $ Depth4=�5>      
���   �$
��Auto��5@      $��0q�5A      $
��Left=�5B      ���	#FFF0EFEF$��
10,10,0,10q�5C   ,   ��5<      ��  �� Path$ FindHotelCommand�5C   ,   �� 5E      $��Mặc định��6   #���  5G      $ Depth4=�5H      
���   �$
��Auto��5J      $��0q�5K      $
��Left=�5L      ���	#FFF0EFEF$��
10,10,0,10q�5M   ,   ��5F      �� $ DefaultFindHotelCommand�5M   ,   �� 5O      #���  6   $ Depth2=�5Q      $��Thêm mới��5R      $	��100��5S      
����ح�$
��Left=�5U      $��0q�5V      $��20,0,0,0q�5W      $��30��5X      ��5P      �� $ AddHotelCommand�5X   #   5Y      5Z      � 5]   
   $��1��6   $��5,5,10,5q�6   .+�5^      �� .��5_      &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5d         AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5_      �� *HOTELLISTDTG+ . $ PropertyChanged=� �� SelectedItem 5b      �� *SelectedHOTEL+$ PropertyChanged=� .  J� InputBindings 5h      d� 5i       d� Gesture$ LeftDoubleClicka�5j   !    �� Command 5k   !   �� *DoubleClickSelectHotelCommand+ �� CommandParameter 5l   !   �� $	 wd_HotelList�� � 	Resources 5n      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property  �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%e  '        '  �     �� 5o      "  6    .�5p      ��  � ��$  35��67   6D   �� 5q       � ��$  13(�69   6F   �� 5r       � ��$  Arial)�6;   6K   5s      �� 5t      "  6    .�5u      ��  � ��$  30��67   6D   �� 5v       � ��$  Times New Roman)�6;   6U   �� 5w       � ��$  15(�69   6F   �� 5x       � ��$
  Bold"�6;   6J   �� 5y       � ��$  Center=�6K   6\   �� 5z       � ��$  Center=�6I   6Z   �� 5{       � ��  �#e2e2e26M   �� 5|       � ��
  �   �6L   �� 5}       � ��$  1,2,1,2q�6@   6R   5~      5      !   Columns! 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,	  &System.Windows.Controls.DataGridColumn" 	  Header$" Mã KS��6-   # 	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	# 100
 5�   -   1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ 5�   -   �� *khachsan.IDKS+5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $" 	Thao tác��61   $	# 110
 5�   )   %   CellTemplate% 5�      �� 5�   "   .R�5�   &   � $��0,0,12,0q�6+   & � ColumnDefinitions& 5�   *   �� 5�   .   $��30 �6?   6L   �� 5�   .   $��30 �6?   6L   .+�5�   *   �� $��0��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��6,0,5,0q�6<   ��5�   1   Z� ��5�   1   �� $" DataContext.EditHotelCommand�' �� RelativeSource' �� *FindAncestor+( �� AncestorType"(  ��5�   1   �� $ khachsan.IDKS�.��5�   .   � .+�5�   2   �� $"��..\..\..\Photo\edit_icon.png��68   $��-17,-4,1,-4q�6^   ) J� RenderTransformOrigin$) 0.5,0.5&�6s   z�5�   6   V� 5�   :   .~�5�   >   �� * �� ScaleX$* -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   �� 5�   *   $��1��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��11,0,0,0q�5�   1   ��5�   1   Z� ��5�   1   �� $$ DataContext.DeleteHotelCommand�' �� *FindAncestor+"(  ��5�   1   �� $ khachsan.IDKS�.��5�   .   � .+�5�   2   �� $$��..\..\..\Photo\delete_icon.png��68   $��-17,-15,-4,-15q�6`   $) 0.5,0.5&�6x   z�5�   6   V� 5�   :   .~�5�   >   �� $* -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   5�   '   5�   #   5�        5�      $" Tên KS��6-   $	# 250
 5�   %   $ 5�   %   �� *khachsan.TENKS+5�   3     5�      $" Tỉnh thành��6-   $	# 250
 5�   %   $ 5�   -   �� *khachsan.TINHTHANH+5�   3     5�      $" Trạng thái��6-   $	# 200
 5�   -   $ 5�   -   �� *	TRANGTHAI+5�        5�      $" Mô tả��6-   $	# 558
 5�   -   $ 5�   -   �� *khachsan.MOTA+5�   ;   5�      5�      5�      5�      5�      