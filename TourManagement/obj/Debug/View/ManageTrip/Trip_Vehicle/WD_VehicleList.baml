   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:TourManagement.View.ManageTrip.Trip_Vehicle+TourManagement.View.ManageTrip.Trip_Vehicle  5   	   @    :TourManagement.View.ManageTrip.Trip_Vehicle.WD_VehicleList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Klocal9clr-namespace:TourManagement.View.ManageTrip.Trip_Vehicle     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  wd_VehicleList��5   	    � WindowStyle$
 None=�5	   	    � WindowState$ 	Maximized=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	      UC_ManageTripVM � DataContext# [  5   	    � Title$ WD_VehicleList��5   	   $
��1080��6    $
��1920��6.   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $	��59* �6#   �� 5      $
��101* �6#   .+�5      �� 	 �� Orientation$	 
Horizontal=�6   $��2��5      .+�5      ��  * &MaterialDesignFloatingActionMiniButton#���  6   $��5q�5      
����ح�+  %MaterialDesignThemes.Wpf.ShadowAssist
   ShadowDepth$
 Depth3=�5#      ��5       �� *Quit_WD_ManageVehicle_Command+��5!      ��  �� ElementName$ wd_VehicleList��.��5$      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ KeyboardBackspace=�6.   5%      #  MaterialDesignThemes.Wpf.Card  5'      $
 Depth2=�6&   $��
20,10,0,10q�5(   &   .��5*      �� $
��Left=�6   $	��200��5+      $��14(�5,      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ BKS - Loại PT��5-       �� TextAlignment$
 Left=�5.      $��5,0,0,0q�5/      ���#E4E4E4��50      �� *VehicleNameFind+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated . 51      52        53      $
 Depth2=�6&   $��
20,10,0,10q�54   &   55      �� 58      $��Tìm kiếm��6    �� 	IsDefault .   MaterialDesignRaisedButton#���  5;      $
 Depth4=�5<      
���   �$
��Auto��5>      $��0q�5?      $
��Left=�5@      ���	#FFF0EFEF$��
10,10,0,10q�5B      ��5:      ��  �� Path$ FindVehicleCommand�5B      �� 5D      $��Mặc định��6   #���  5F      $
 Depth4=�5G      
���   �$
��Auto��5I      $��0q�5J      $
��Left=�5K      ���	#FFF0EFEF$��
10,10,0,10q�5M      ��5E      �� $ DefaultFindVehicleCommand�5M      �� 5O      #���  6   $
 Depth2=�5Q      $��Thêm PT��5R      $	��100��5S      
����ح�$
��Left=�5U      $��0q�5V      $��20,0,0,0q�5W      $��30��5X      ��5P      �� $ AddVehicleCommand�5X   '   5Y      5Z      � 5]   
   $��1��6   $��5,5,10,5q�5^      .+�5_      �� .��5`      &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5d         AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5`      �� *VEHICLELISTDTG+ . $ PropertyChanged=� �� SelectedItem 5c      �� *SelectedVEHICLE+ J� InputBindings 5h      d� 5i       d� Gesture$ LeftDoubleClicka�6'    �� Command 5j   '   �� *!DoubleClickSelectVehicleCommand+ �� CommandParameter 5k   '   �� $ wd_VehicleList�� � 	Resources 5m      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property  �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '        '  �     �� 5n      "  6    .�5o      ��  � ��$  35��5p   %   62   �� 5q       � ��$  13(�5r   %   62   �� 5s       � ��$  Arial)�5t   %   65   5u      �� 5v      "  6    .�5w      ��  � ��$  30��5x   %   62   �� 5y       � ��$  Times New Roman)�5z   %   6?   �� 5{       � ��$  15(�5|   %   62   �� 5}       � ��$
  Bold"�5~   %   64   �� 5       � ��$  Center=�5�   %   66   �� 5�       � ��$  Center=�5�   %   66   �� 5�       � ��  �#e2e2e25�   7   �� 5�       � ��
  �   �5�   5   �� 5�       � ��$  1,2,1,2q�5�   %   67   5�      5�      !   Columns! 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,	  &System.Windows.Controls.DataGridColumn" 	  Header$" Mã PT��6-   # 	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	# 100
 5�   -   1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ 5�   -   �� *phuongtien.IDPT+5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $" 	Thao tác��61   $	# 110
 5�   1   %   CellTemplate% 5�      �� 5�   "   .R�5�   &   � $��0,0,12,0q�6+    5�   *   �� 5�   .   $��30 �6?   6L   �� 5�   .   $��30 �6?   6L   .+�5�   *   �� $��0��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��6,0,5,0q�5�   1   ��5�   1   Z� ��5�   1   �� $$ DataContext.EditVehicleCommand�& �� RelativeSource& �� *FindAncestor+' �� AncestorType"'  ��5�   1   �� $ phuongtien.IDPT�.��5�   .   � .+�5�   2   �� $"��..\..\..\Photo\edit_icon.png��68   $��-17,-4,1,-4q�5�   8   ( J� RenderTransformOrigin$( 0.5,0.5&�5�   8   z�5�   6   V� 5�   :   .~�5�   >   �� ) �� ScaleX$) -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   �� 5�   *   $��1��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��11,0,0,0q�5�   1   ��5�   1   Z� ��5�   1   �� $&  DataContext.DeleteVehicleCommand�& �� *FindAncestor+"'  ��5�   1   �� $ phuongtien.IDPT�.��5�   .   � .+�5�   2   �� $$��..\..\..\Photo\delete_icon.png��68   $��-17,-15,-4,-15q�5�   8   $( 0.5,0.5&�5�   8   z�5�   6   V� 5�   :   .~�5�   >   �� $) -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   5�   '   5�   #   5�        5�      $" Loại phương tiện��6-   $	# 250
 5�   -   $ 5�   -   �� *phuongtien.LOAIPT+5�   ;     5�      $" Biển kiểm soát��6-   $	# 200
 5�   -   $ 5�   -   �� *phuongtien.BKS+5�        5�      $" Phương tiện��6-   $	# 200
 5�   -   $ 5�   -   �� *BELONGTOCOMPANY+5�        5�      $" 
Số ghế��6-   $	# 200
 5�   -   $ 5�   -   �� *phuongtien.SOGHE+5�        5�      $" 
Giá thuê��6-   $	# 200
 5�   -   $ 5�   -   �� *phuongtien.GIATHUE+5�   ;   5�      5�      5�      5�      5�      