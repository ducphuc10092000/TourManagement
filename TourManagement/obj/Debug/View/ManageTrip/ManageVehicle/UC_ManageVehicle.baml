   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:TourManagement.View.ManageTrip.ManageVehicle,TourManagement.View.ManageTrip.ManageVehicle  5      C    =TourManagement.View.ManageTrip.ManageVehicle.UC_ManageVehicle   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Llocal:clr-namespace:TourManagement.View.ManageTrip.ManageVehicle     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������   UC_ManageTripVM  � DataContext#  [  5
      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $	��59* �6#   �� 5      $
��101* �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��2��5      .+�5      ��  * &MaterialDesignFloatingActionMiniButton#���  6   $��5q�5      
����ح�+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5      ��5      �� *Quit_UC_ManageVehicle_Command+.��5       '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ KeyboardBackspace=�6.   5!      #  MaterialDesignThemes.Wpf.Card  5#      $ Depth2=�6&   $��
20,10,0,10q�5$   &   .��5&      �� $
��Left=�6   $	��200��5'      $��14(�5(      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ BKS - Loại PT��5)       �� TextAlignment$
 Left=�5*      $��5,0,0,0q�5+      ���#E4E4E4��5,      �� *VehicleNameFind+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� NotifyOnSourceUpdated	 . 5-      5.        5/      $ Depth2=�6&   $��
20,10,0,10q�50   &   51      �� 54      $��Tìm kiếm��6   
 �� 	IsDefault
 .   MaterialDesignRaisedButton#���  57      $ Depth4=�58      
���   �$
��Auto��5:      $��0q�5;      $
��Left=�5<      ���	#FFF0EFEF$��
10,10,0,10q�5>      ��56      ��  �� Path$ FindVehicleCommand�5>      �� 5@      $��Mặc định��6   #���  5B      $ Depth4=�5C      
���   �$
��Auto��5E      $��0q�5F      $
��Left=�5G      ���	#FFF0EFEF$��
10,10,0,10q�5I      ��5A      �� $ DefaultFindVehicleCommand�5I      �� 5K      #���  6   $ Depth2=�5M      $��Thêm mới��5N      $	��100��5O      
����ح�$
��Left=�5Q      $��0q�5R      $��20,0,0,0q�5S      $��30��5T      ��5L      �� $ AddVehicleCommand�5T   '   5U      5V      � 5Y   
   $��1��6   $��5,5,10,5q�5Z      .+�5[      �� .��5\      &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5`         AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5\      �� *VEHICLELISTDTG+	 . $ PropertyChanged=� �� SelectedItem 5_      �� *SelectedVEHICLE+ � 	Resources 5d      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '        '  �     �� 5e      "  6    .�5f      ��  � ��$ 35��5g   %   62   �� 5h       � ��$ 13(�5i   %   62   �� 5j       � ��$ Arial)�5k   %   65   5l      �� 5m      "  6    .�5n      ��  � ��$ 30��5o   %   62   �� 5p       � ��$ Times New Roman)�5q   %   6?   �� 5r       � ��$ 15(�5s   %   62   �� 5t       � ��$
 Bold"�5u   %   64   �� 5v       � ��$ Center=�5w   %   66   �� 5x       � ��$ Center=�5y   %   66   �� 5z       � �� �#e2e2e25{   7   �� 5|       � ��
 �   �5}   5   �� 5~       � ��$ 1,2,1,2q�5   %   67   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,	  &System.Windows.Controls.DataGridColumn 	  Header$ Mã PT��6-    	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	 100
 5�   -   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5�   -   �� *phuongtien.IDPT+5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $ 	Thao tác��61   $	 110
 5�   1      CellTemplate 5�      �� 5�   "   .R�5�   &   � $��0,0,12,0q�6+    5�   *   �� 5�   .   $��30 �6?   6L   �� 5�   .   $��30 �6?   6L   .+�5�   *   �� $��0��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��6,0,5,0q�5�   1   ��5�   1   Z� ��5�   1   �� $$ DataContext.EditVehicleCommand� �� RelativeSource �� *FindAncestor+ �� AncestorType"  ��5�   1   �� $ phuongtien.IDPT�.��5�   .   � .+�5�   2   �� $"��..\..\..\Photo\edit_icon.png��68   $��-17,-4,1,-4q�5�   8    J� RenderTransformOrigin$ 0.5,0.5&�5�   8   z�5�   6   V� 5�   :   .~�5�   >   ��  �� ScaleX$ -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   �� 5�   *   $��1��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��11,0,0,0q�5�   1   ��5�   1   Z� ��5�   1   �� $&  DataContext.DeleteVehicleCommand� �� *FindAncestor+"  ��5�   1   �� $ phuongtien.IDPT�.��5�   .   � .+�5�   2   �� $$��..\..\..\Photo\delete_icon.png��68   $��-17,-15,-4,-15q�5�   8   $ 0.5,0.5&�5�   8   z�5�   6   V� 5�   :   .~�5�   >   �� $ -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   5�   '   5�   #   5�        5�      $ Loại phương tiện��6-   $	 250
 5�   -    5�   -   �� *phuongtien.LOAIPT+5�   ;     5�      $ Biển kiểm soát��6-   $	 200
 5�   -    5�   -   �� *phuongtien.BKS+5�        5�      $ 
Số ghế��6-   $	 200
 5�   -    5�   -   �� *phuongtien.SOGHE+5�        5�      $ Phương tiện��6-   $	 200
 5�   -    5�   -   �� *BELONGTOCOMPANY+5�        5�      $ 
Giá thuê��6-   $	 200
 5�   -    5�   -   �� *phuongtien.GIATHUE+5�   ;   5�      5�      5�      5�      5�      