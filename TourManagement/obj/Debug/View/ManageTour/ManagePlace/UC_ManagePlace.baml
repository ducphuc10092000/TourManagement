   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:TourManagement.View.ManageTour.ManagePlace*TourManagement.View.ManageTour.ManagePlace  5      ?    9TourManagement.View.ManageTour.ManagePlace.UC_ManagePlace   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jlocal8clr-namespace:TourManagement.View.ManageTour.ManagePlace     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         UC_ManageTourVM  � DataContext#  [  5	      
�������.��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  * &MaterialDesignFloatingActionMiniButton#���  6   $��5q�5      
����ح�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5      ��5      �� *BackToManageTourCommand+.��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ KeyboardBackspace=�6.   5      #  MaterialDesignThemes.Wpf.Card  5      $ Depth2=�6&   $��
20,10,0,10q�5   *   .��5       �� $
��Left=�6   $	��200��5!   "   $��14(�5"   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$# Nhập tên Điểm tham quan��5#   "    �� TextAlignment$
 Left=�5$   "   $��5,0,0,0q�5%   "   ���#E4E4E4��5&   "   �� *PlaceNameFind+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated . 5'   "   5(        5)      $ Depth2=�6&   $��
20,10,0,10q�6W   .��5*      �� $ Tỉnh thành��6   $	��200��5,      	 �� 
IsEditable	 . ���#E4E4E4$��5,0,0,0q�5/      $��Center=�50      $
��Left=�51      $��14(�53      $��30��6-   ��5+      �� *ProvinceNameList+$ PropertyChanged=� . 
 �� Mode$
 TwoWay=� �� Text 52      �� *ProvinceNamePlaceFind+$ PropertyChanged=� . $
 TwoWay=�53   -   54      �� 57      $��Tìm kiếm��6    �� 	IsDefault .   MaterialDesignRaisedButton#���  5:      $ Depth4=�5;      
���   �$
��Auto��5=      $��0q�5>      $
��Left=�5?      ���	#FFF0EFEF$��
10,10,0,10q�5@   ,   ��59      ��  �� Path$ FindPlaceCommand�5@   ,   �� 5B      $��Mặc định��6   #���  5D      $ Depth4=�5E      
���   �$
��Auto��5G      $��0q�5H      $
��Left=�5I      ���	#FFF0EFEF$��
10,10,0,10q�5J   ,   ��5C      �� $ DefaultPlaceCommand�5J   ,   �� 5L      #���  6   $ Depth2=�5N      $��Thêm mới��5O      $	��100��5P      
����ح�$
��Left=�5R      $��0q�5S      $��20,0,0,0q�5T      $��30��5U      ��5M      �� $ AddPlaceCommand�5U   #   5V      5W      � 5Z   
   $��1��6   $��5,5,10,5q�6   .+�5[      �� .��5\      &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5_         AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5\      �� *PLACELISTDTG+ . $ PropertyChanged=� � 	Resources 5c      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%e  '        '  �     �� 5d      "  6    .�5e      ��  � ��$ 35��67   6D   �� 5f       � ��$ 13(�69   6F   �� 5g       � ��$ Arial)�6;   6K   5h      �� 5i      "  6    .�5j      ��  � ��$ 30��67   6D   �� 5k       � ��$ Times New Roman)�6;   6U   �� 5l       � ��$ 15(�69   6F   �� 5m       � ��$
 Bold"�6;   6J   �� 5n       � ��$ Center=�6K   6\   �� 5o       � ��$ Center=�6I   6Z   �� 5p       � �� �#e2e2e26M   �� 5q       � ��
 �   �6L   �� 5r       � ��$ 1,1,0,1q�6@   6R   5s      5t         Columns 5u      0  *System.Windows.Controls.DataGridTextColumn  5w      ,	  &System.Windows.Controls.DataGridColumn 	  Header$ Mã ĐTQ��6-    	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	 100
 5x   -   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5y   -   �� *diadiem.IDDIADIEM+5z      4  .System.Windows.Controls.DataGridTemplateColumn  5|      $ 	Thao tác��61   $	 110
 5}   )      CellTemplate 5      �� 5�   "   .R�5�   &   � $��0,0,12,0q�6+    � ColumnDefinitions 5�   *   �� 5�   .   $��30 �6?   6L   �� 5�   .   $��30 �6?   6L   .+�5�   *   �� $��0��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��6,0,5,0q�6<   ��5�   1   Z� ��5�   1   �� $" DataContext.EditPlaceCommand� �� RelativeSource �� *FindAncestor+ �� AncestorType"  ��5�   1   �� $ diadiem.IDDIADIEM�.��5�   .   � .+�5�   2   �� $"��..\..\..\Photo\edit_icon.png��68   $��-17,-4,1,-4q�6^    J� RenderTransformOrigin$ 0.5,0.5&�6s   z�5�   6   V� 5�   :   .~�5�   >   ��   �� ScaleX$  -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   �� 5�   *   $��1��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��11,0,0,0q�5�   1   ��5�   1   Z� ��5�   1   �� $$ DataContext.DeletePlaceCommand� �� *FindAncestor+"  ��5�   1   �� $ diadiem.IDDIADIEM�.��5�   .   � .+�5�   2   �� $$��..\..\..\Photo\delete_icon.png��68   $��-17,-15,-4,-15q�6`   $ 0.5,0.5&�6x   z�5�   6   V� 5�   :   .~�5�   >   �� $  -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   5�   '   5�   #   5�        5�      $ Tên điểm tham quan��6-   $	 250
 5�   %    5�   %   �� *diadiem.TENDIADIEM+5�   3     5�      $ Tỉnh thành��6-   $	 350
 5�   %    5�   -   �� *diadiem.TINHTHANH+5�   3     5�      $ Trạng thái��6-   $	 200
 5�   -    5�   -   �� *	TRANGTHAI+5�        5�      $ Mô tả��6-   $	 520
 5�   -    5�   -   �� *diadiem.MOTA+5�   ;   5�      5�      5�      5�      5�      