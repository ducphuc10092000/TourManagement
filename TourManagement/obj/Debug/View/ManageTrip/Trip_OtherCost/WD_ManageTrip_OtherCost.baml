   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:TourManagement.View.ManageTrip.Trip_OtherCost-TourManagement.View.ManageTrip.Trip_OtherCost  5   	   K    ETourManagement.View.ManageTrip.Trip_OtherCost.WD_ManageTrip_OtherCost   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Mlocal;clr-namespace:TourManagement.View.ManageTrip.Trip_OtherCost     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  wd_ManageTrip_OtherCost��5   	    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowStyle$
 None=�5   	      WD_AddTripVM � DataContext# [  5   	    � WindowState$ 	Maximized=�5   	    � Title$ WD_ManageTrip_OtherCost��5   	   $
��1080��6)   $
��1920��67   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $	��59* �6#   �� 5      $
��101* �6#   .+�5      �� 	 �� Orientation$	 
Horizontal=�6   $��2��5      .+�5      ��  * &MaterialDesignFloatingActionMiniButton#���  6   $��5q�5      
����ح�+  %MaterialDesignThemes.Wpf.ShadowAssist
   ShadowDepth$
 Depth3=�5#      ��5       �� *QuitCommand+��5!      ��  �� ElementName$ wd_ManageTrip_OtherCost��.��5$      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ KeyboardBackspace=�6.   5%      #  MaterialDesignThemes.Wpf.Card  5'      $
 Depth2=�6&   $��
20,10,0,10q�5(   &   .��5*      �� $
��Left=�6   $	��200��5+      $��14(�5,      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Mô tả chi phí khác��5-       �� TextAlignment$
 Left=�5.      $��5,0,0,0q�5/      ���#E4E4E4��50      �� *EatingDescriptionFind+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated . 51      52        53      $
 Depth2=�6&   $��
20,10,0,10q�54   &   55      �� 58      $��Tìm kiếm��6    �� 	IsDefault .   MaterialDesignRaisedButton#���  5;      $
 Depth4=�5<      
���   �$
��Auto��5>      $��0q�5?      $
��Left=�5@      ���	#FFF0EFEF$��
10,10,0,10q�5B      ��5:      ��  �� Path$ FindEatingCostCommand�5B      �� 5D      $��Mặc định��6   #���  5F      $
 Depth4=�5G      
���   �$
��Auto��5I      $��0q�5J      $
��Left=�5K      ���	#FFF0EFEF$��
10,10,0,10q�5M      ��5E      �� $" DefaultFindEatingCostCommand�5M      �� 5O      #���  6   $
 Depth2=�5Q      $��Thêm chi phí��5R      $	��150��5S      
����ح�$
��Left=�5U      $��0q�5V      $��20,0,0,0q�5W      $��30��5X      ��5P      �� $ AddOtherCostCommand�5X   '   5Y      5Z      � 5]   
   $��1��6   $��5,5,10,5q�5^      .+�5_      �� .��5`      &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5c         AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5`      �� *TRIP_OTHERCOSTLISTDTG+ . $ PropertyChanged=� �� Mode$ TwoWay=� � 	Resources 5g      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '        '  �     �� 5h      "  6    .�5i      ��  � ��$ 35��5j   %   62   �� 5k       � ��$ 13(�5l   %   62   �� 5m       � ��$ Arial)�5n   %   65   5o      �� 5p      "  6    .�5q      ��  � ��$ 30��5r   %   62   �� 5s       � ��$ Times New Roman)�5t   %   6?   �� 5u       � ��$ 15(�5v   %   62   �� 5w       � ��$
 Bold"�5x   %   64   �� 5y       � ��$ Center=�5z   %   66   �� 5{       � ��$ Center=�5|   %   66   �� 5}       � �� �#e2e2e25~   7   �� 5       � ��
 �   �5�   5   �� 5�       � ��$ 1,2,1,2q�5�   %   67   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,	  &System.Windows.Controls.DataGridColumn 	  Header$ Mã CT��6-    	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	 100
 5�   -   1  +System.Windows.Controls.DataGridBoundColumn    Binding  5�   -   �� 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $ 	Thao tác��61   $	 110
 5�   1   !   CellTemplate! 5�      �� 5�   "   .R�5�   &   � $��0,0,12,0q�6+    5�   *   �� 5�   .   $��30 �6?   6L   �� 5�   .   $��30 �6?   6L   .+�5�   *   �� $��0��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��6,0,5,0q�5�   1   ��5�   1   Z� ��5�   1   �� $$ DataContext.EditVehicleCommand�" �� RelativeSource" �� *FindAncestor+# �� AncestorType"#  .��5�   .   � .+�5�   2   �� $"��..\..\..\Photo\edit_icon.png��68   $��-17,-4,1,-4q�5�   8   $ J� RenderTransformOrigin$$ 0.5,0.5&�5�   8   z�5�   6   V� 5�   :   .~�5�   >   �� % �� ScaleX$% -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   �� 5�   *   $��1��61   $��0q�5�   1   $
��Auto��5�   1   $��20��5�   1   $��11,0,0,0q�5�   1   ��5�   1   Z� ��5�   1   �� $&  DataContext.DeleteVehicleCommand�" �� *FindAncestor+"#  ��5�   1   �� $ phuongtien.IDPT�.��5�   .   � .+�5�   2   �� $$��..\..\..\Photo\delete_icon.png��68   $��-17,-15,-4,-15q�5�   8   $$ 0.5,0.5&�5�   8   z�5�   6   V� 5�   :   .~�5�   >   �� $% -1Q�6M   �� 5�   >   �� 5�   >   T� 5�   >   5�   ;   5�   3   5�   /   5�   +   5�   '   5�   #   5�        5�      $ Chi phí��6-   $	 250
 5�   -     5�   -   �� *CHIPHI+5�   ;     5�      $ Mô tả��6-   $	 700
 5�   -     5�   -   �� *MOTA+5�   ;   5�      5�      5�      5�      5�      