   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:TourManagement.View.ManageTour.ManagePlace*TourManagement.View.ManageTour.ManagePlace  5   	   O,clr-namespace:TourManagement.View.ManageTripTourManagement.View.ManageTrip  5   	   0    *TourManagement.View.ManageTrip.WD_TourList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   TviewManagePlace8clr-namespace:TourManagement.View.ManageTour.ManagePlace     5   	   >local,clr-namespace:TourManagement.View.ManageTrip     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          �Name$  wd_TourList��5   	    � WindowStyle$
 None=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowState$ 	Maximized=�5   	      UC_ManageTourVM � DataContext# [  5   	    � Title$ WD_TourList��5   	   $	��900��6   $
��1600��6*   .��5      � .+�5   
   � .+�5      � .+�5      �� 
���   �$��2q�5      $��5,5,5,5q�5      ._�5      � ��5      �� 5       �� 
TargetType" �6$   .�5   "   ��  �� Property � y�	 �� Value$	 	Collapsed=�5   )   6=   
 �� Triggers
 5   "   �� 5   &    �� Binding 62   �� *
ChucNang+ �� Value 05   2   .a�5    *   ��  � y�$	 Visible=�5!   1   6C   5"   '   5$       � RowDefinitions 5&      �� 5'      $��50 �6,   6:   �� 5(      6.   .+�5+      � $��0��6   .+�5,      ��  �� Orientation$ 
Horizontal=�6)   .+�5.   "   ��  * &MaterialDesignFloatingActionMiniButton#���  6)   $��5q�5/   )   
����ح�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�53   )   ��50   )   �� *WD_TourList_QuitCommand+��51   )   ��  �� ElementName$ wd_TourList��.��54   &   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ KeyboardBackspace=�6>   55   #   #  MaterialDesignThemes.Wpf.Card  57   "   $ Depth2=�66   $��
20,10,0,10q�58   6   .��5:   &   �� $
��Left=�6.   $	��200��5;   .   $��16(�5<   .   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nhập tên tour��5=   .    �� TextAlignment$
 Left=�5>   .   $��5,0,0,0q�5?   .   ���#E4E4E4��5@   .   �� *TourNameFind+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated .  �� Mode$ TwoWay=�5A   .   5B   #   �� 5D   "   $��Tìm kiếm��6)   $��0q�5E   )    �� 	IsDefault .   MaterialDesignRaisedButton#���  5H   )   $ Depth4=�5I   )   
���   �$
��Auto��5K   )   $
��Left=�5L   )   ���	#FFF0EFEF$��
10,10,0,10q�5N   )   ��5G   )   ��  �� Path$ TourFindCommand�5N   )   �� 5P   "   $��Mặc định��6)   #���  5R   )   $ Depth4=�5S   )   
���   �$
��Auto��5U   )   $��0q�5V   )   $
��Left=�5W   )   ���	#FFF0EFEF$��
10,10,0,10q�5Y   )   ��5Q   )   �� $ DefaultTourFindCommand�5Y   )   �� 5[   "   #���  6)   $ Depth2=�5]   )   $��Thêm mới��5^   )   $	��100��5_   )   
����ح�$
��Left=�5a   )   $��0q�5b   )   $��20,0,0,0q�5c   )   $��30��5d   )   ��5\   )   �� $ AddTourCommand�5d   7   �� 5g   "   $��QL ĐIỂM THAM QUAN��6)    . #���  5j   )   $ Depth4=�5k   )   
���   �$
��Auto��5m   )   $��0q�5n   )   $
��Left=�5o   )   ���	#FFFFBC5B$��789,10,0,10q�5q   )   ��5i   )   �� $ BtnManagePlaceCommand�5q   )   5s      5t      � 5v      $��1��6   $��0,5,5,5q�5w      .+�5x      �� .��5y   "   &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5}   +      AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5y   +   �� *TOURLISTDTG+ . $ PropertyChanged=� �� SelectedItem 5|   +   �� *SelectedTOURs+ . $ PropertyChanged=� J� InputBindings 5�   &   d� 5�   *     d� Gesture$  LeftDoubleClicka�67   ! �� Command! 5�   7   �� *DoubleClickSelectTourCommand+" �� CommandParameter" 5�   7   �� $ wd_TourList��# � 	Resources# 5�   &   )  #System.Windows.Controls.DataGridRow=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%d  '        '  �     �� 5�   *   "  60   .�5�   .   ��  � ��$	 35��5�   5   6B   �� 5�   .    � ��$	 13(�5�   5   6B   �� 5�   .    � ��$	 Arial)�5�   5   6E   5�   +   �� 5�   *   "  60   .�5�   .   ��  � ��$	 30��5�   5   6B   �� 5�   .    � ��$	 Times New Roman)�5�   5   6O   �� 5�   .    � ��$	 15(�5�   5   6B   �� 5�   .    � ��$
	 Bold"�5�   5   6D   �� 5�   .    � ��$	 Center=�5�   5   6F   �� 5�   .    � ��	 �#e2e2e25�   G   �� 5�   .    � ��
	 �   �5�   E   �� 5�   .    � ��$	 2,2,1,2q�5�   5   6G   5�   +   5�   '   $   Columns$ 5�   &   0  *System.Windows.Controls.DataGridTextColumn  5�   *   ,	  &System.Windows.Controls.DataGridColumn% 	  Header$% Mã Tour��6=   & 	  Width5
  /System.Windows.Controls.DataGridLengthConverter$& 90
 5�   =   1  +System.Windows.Controls.DataGridBoundColumn'   Binding' 5�   =   �� *tour.IDTOUR+5�   +   4  .System.Windows.Controls.DataGridTemplateColumn  5�   *   $% 	Thao tác��6A   $	& 110
 5�   A   (   CellTemplate( 5�   .   �� 5�   2   .R�5�   6   � $��0,0,12,0q�6;   ) � ColumnDefinitions) 5�   :   �� 5�   >   $��30 �6O   6\   �� 5�   >   $��30 �6O   6\   .+�5�   :   �� $��0��6A   $��0q�5�   A   $
��Auto��5�   A   $��20��5�   A   $��6,0,5,0q�5�   A   ��5�   A   Z� ��5�   A   �� $! DataContext.EditTourCommand�* �� RelativeSource* �� *FindAncestor++ �� AncestorType"+  ��5�   A   �� $ tour.IDTOUR�.��5�   >   � .+�5�   B   �� $��..\..\Photo\edit_icon.png��6H   $��-17,-4,1,-4q�5�   H   , J� RenderTransformOrigin$, 0.5,0.5&�5�   H   z�5�   F   V� 5�   J   .~�5�   N   �� - �� ScaleX$- -1Q�6]   �� 5�   N   �� 5�   N   T� 5�   N   5�   K   5�   C   5�   ?   5�   ;   �� 5�   :   $��1��6A   $��0q�5�   A   $
��Auto��5�   A   $��20��5�   A   $��11,0,0,0q�5�   A   ��5�   A   Z� ��5�   A   �� $# DataContext.DeleteTourCommand�* �� *FindAncestor+"+  ��5�   A   �� $ tour.IDTOUR�.��5�   >   � .+�5�   B   �� $!��..\..\Photo\delete_icon.png��6H   $��-17,-15,-4,-15q�5�   H   $, 0.5,0.5&�5�   H   z�5�   F   V� 5�   J   .~�5�   N   �� $- -1Q�6]   �� 5�   N   �� 5�   N   T� 5�   N   5�   K   5�   C   5�   ?   5�   ;   5�   7   5�   3   5�   +     5�   *   $% 	Tên Tour��6=   $	& 250
 5�   =   ' 5�   =   �� *tour.TENTOUR+5�   K     5�   *   $% Loại hình��6=   $	& 250
 5�   =   ' 5�   =   �� *tour.LOAIHINH+5�   K     5�   *   $% 	Giá Tour��6=   $	& 200
 5�   =   ' 5�   =   �� *tour.GIATOUR+5�   K     5�   *   $% Trạng thái��6=   $	& 200
 5�   =   ' 5�   =   �� *STATUS+5�   K     5�   *   $% Mô tả��6=   $	& 450
 5   =   ' 5�   =   �� *	tour.MOTA+5   K   5  #   5     5     5     5     5     � 5
     ��5     �� 5     " �6   .�5     ��  � y�$	 	Collapsed=�5  !   65   
 5     �� 5      6*   �� *
ChucNang+ 15  *   .a�5  "   ��  � y�$	 Visible=�5  )   6;   5     5     .+�5     ?   9TourManagement.View.ManageTour.ManagePlace.UC_ManagePlace  63   5     5     5     5     