   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:TourManagement.View.ManageTour.ManageHotel*TourManagement.View.ManageTour.ManageHotel  5      ?    9TourManagement.View.ManageTour.ManageHotel.UC_ManageHotel   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jlocal8clr-namespace:TourManagement.View.ManageTour.ManageHotel     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      
�������   UC_ManageTripVM  � DataContext#  [  5	      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  * &MaterialDesignFloatingActionMiniButton#���  6   $��5q�5      
����ح�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5      ��5      �� *Quit_UC_ManageHotelComand+.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ KeyboardBackspace=�6.   5      #  MaterialDesignThemes.Wpf.Card  5      $ Depth2=�6&   $��
20,10,0,10q�5   *   .��5       �� $
��Left=�6   $	��200��5!   "   $��14(�5"   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nhập tên Khách sạn��5#   "    �� TextAlignment$
 Left=�5$   "   $��5,0,0,0q�5%   "   ���#E4E4E4��5&   "   �� *HotelNameFind+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated . 5'   "   5(        5)      $ Depth2=�6&   $��
20,10,0,10q�6W   .��5*      �� $ Tỉnh thành��6   $	��200��5,      ���#E4E4E4$��5,0,0,0q�5.      $��Center=�5/      $
��Left=�50      $��14(�52      $��30��6-   ��5+      �� *ProvinceNameList+$ PropertyChanged=� . 	 �� Text	 51      �� *ProvinceNameHotelFind+
 �� Mode$
 TwoWay=�52   -   53      �� 56      $��Tìm kiếm��6    �� 	IsDefault .   MaterialDesignRaisedButton#���  59      $ Depth4=�5:      
���   �$
��Auto��5<      $��0q�5=      $
��Left=�5>      ���	#FFF0EFEF$��
10,10,0,10q�5?   ,   ��58      ��  �� Path$ FindHotelCommand�5?   ,   �� 5A      $��Mặc định��6   #���  5C      $ Depth4=�5D      
���   �$
��Auto��5F      $��0q�5G      $
��Left=�5H      ���	#FFF0EFEF$��
10,10,0,10q�5I   ,   ��5B      �� $ DefaultFindHotelCommand�5I   ,   �� 5K      #���  6   $ Depth2=�5M      $��Thêm mới��5N      $	��100��5O      
����ح�$
��Left=�5Q      $��0q�5R      $��20,0,0,0q�5S      $��30��5T      ��5L      �� $ AddHotelCommand�5T   #   5U      5V      � 5Y   
   $��1��6   $��5,5,10,5q�6   .+�5Z      �� .��5[      &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5^         AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5[      �� *HOTELLISTDTG+ . $ PropertyChanged=� � 	Resources 5b      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%e  '        '  �     �� 5c      "  6    .�5d      ��  � ��$ 35��67   6D   �� 5e       � ��$ 13(�69   6F   �� 5f       � ��$ Arial)�6;   6K   5g      �� 5h      "  6    .�5i      ��  � ��$ 30��67   6D   �� 5j       � ��$ Times New Roman)�6;   6U   �� 5k       � ��$ 15(�69   6F   �� 5l       � ��$
 Bold"�6;   6J   �� 5m       � ��$ Center=�6K   6\   �� 5n       � ��$ Center=�6I   6Z   �� 5o       � �� �#e2e2e26M   �� 5p       � ��
 �   �6L   �� 5q       � ��$ 1,2,1,2q�6@   6R   5r      5s         Columns 5t      0  *System.Windows.Controls.DataGridTextColumn  5v      ,	  &System.Windows.Controls.DataGridColumn 	  Header$ Mã KS��6-    	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	 100
 5w   -   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5x   -   �� *khachsan.IDKS+5y      4  .System.Windows.Controls.DataGridTemplateColumn  5{      $ 	Thao tác��61   $	 110
 5|   )      CellTemplate 5~      �� 5   "   .R�5�   &   � $��0,0,12,0q�6+    � ColumnDefinitions 5�   *   �� 5�   .   $��30 �6?   6L   �� 5�   .   $��30 �6?   6L   .+�5�   *   �� $��0��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��6,0,5,0q�6<   ��5�   1   Z� ��5�   1   �� $" DataContext.EditHotelCommand� �� RelativeSource �� *FindAncestor+ �� AncestorType"  ��5�   1   �� $ khachsan.IDKS�.��5�   .   � .+�5�   2   �� $"��..\..\..\Photo\edit_icon.png��68   $��-17,-4,1,-4q�6^    J� RenderTransformOrigin$ 0.5,0.5&�6s   z�5�   6   V� 5�   :   .~�5�   >   ��  �� ScaleX$ -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   �� 5�   *   $��1��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��11,0,0,0q�5�   1   ��5�   1   Z� ��5�   1   �� $$ DataContext.DeleteHotelCommand� �� *FindAncestor+"  ��5�   1   �� $ khachsan.IDKS�.��5�   .   � .+�5�   2   �� $$��..\..\..\Photo\delete_icon.png��68   $��-17,-15,-4,-15q�6`   $ 0.5,0.5&�6x   z�5�   6   V� 5�   :   .~�5�   >   �� $ -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   5�   '   5�   #   5�        5�      $ Tên KS��6-   $	 250
 5�   %    5�   %   �� *khachsan.TENKS+5�   3     5�      $ Tỉnh thành��6-   $	 250
 5�   %    5�   -   �� *khachsan.TINHTHANH+5�   3     5�      $ Trạng thái��6-   $	 200
 5�   -    5�   -   �� *	TRANGTHAI+5�        5�      $ Mô tả��6-   $	 558
 5�   -    5�   -   �� *khachsan.MOTA+5�   ;   5�      5�      5�      5�      5�      