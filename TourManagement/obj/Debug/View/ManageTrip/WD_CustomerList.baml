   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:TourManagement.View.ManageTripTourManagement.View.ManageTrip  5   	   4    .TourManagement.View.ManageTrip.WD_CustomerList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   8local,clr-namespace:TourManagement.View.ManageTrip  5   	   -   5          �Name$  wd_CustomerList��5   	    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � WindowState$ 	Maximized=�5   	    � WindowStartupLocation$ CenterScreen=�5   	      UC_ManageCustomerVM � DataContext# [  5   	    � Title$ WD_CustomerList��5   	   $	��900��6!   $
��1600��6.   .��5      � .+�5   
   �� 
���   �$��2q�5      $��5q�5      ._�5      �  � RowDefinitions 5      �� 5      $��50 �6$   62   �� 5      6&   .+�5      � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      ��  * &MaterialDesignFloatingActionMiniButton#���  6!   
����ح�$��10,0,0,0q�5    !   +  %MaterialDesignThemes.Wpf.ShadowAssist	   ShadowDepth$	 Depth3=�5!   !   ��5   !   �� *QuitCommand+��5   !   �� 
 �� ElementName$
 wd_CustomerList��.��5"      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ KeyboardBackspace=�66   5#      #  MaterialDesignThemes.Wpf.Card  5%      $	 Depth2=�6.   $��
20,10,0,10q�5&   .   .��5'      �� $
��Left=�6&   $	��200��5(   &   $��14(�5)   &   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nhập tên khách hàng��5*   &    �� TextAlignment$
 Left=�5+   &   $��5,0,0,0q�5,   &   ���#E4E4E4��5-   &   �� *CustomerNameFind+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated . 5.   &   5/      �� 5>      $��Tìm kiếm��6!    �� 	IsDefault .   MaterialDesignRaisedButton#���  5A   !   $	 Depth4=�5B   !   
���   �$
��Auto��5D   !   $��0q�5E   !   $
��Left=�5F   !   ���	#FFF0EFEF$��
10,10,0,10q�5H   !   ��5@   !   ��  �� Path$ CustomerFindCommand�5H   !   �� 5J      $��Mặc định��6!   #���  5L   !   $	 Depth4=�5M   !   
���   �$
��Auto��5O   !   $��0q�5P   !   $
��Left=�5Q   !   ���	#FFF0EFEF$��
10,10,0,10q�5S   !   ��5K   !   �� $  DefaultCustomerFindCommand�5S   !   �� 5U      #���  6!   $	 Depth2=�5W   !   $��Thêm mới��5X   !   $	��100��5Y   !   
����ح�$
��Left=�5[   !   $��0q�5\   !   $��20,0,0,0q�5]   !   $��30��5^   !   ��5V   !   �� $ AddCustomerCommand�5^   /   5_      5`      � 5c      $��1��6   $��5,5,10,5q�5d      .+�5e      �� .��5f      &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5k   #      AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5f   #   �� *CUSTOMERLISTDTG+ . $ PropertyChanged=� �� SelectedItem 5i   #   �� *SelectedCUSTOMER+$ PropertyChanged=� .  J� InputBindings 5o      d� 5p   "    d� Gesture$ LeftDoubleClicka�6/    �� Command 5q   /   �� *" DoubleClickSelectCustomerCommand+ �� CommandParameter 5r   /   �� $
 wd_CustomerList�� � 	Resources 5t      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '        '  �     �� 5u   "   "  6(   .�5v   &   ��  � ��$ 35��5w   -   6:   �� 5x   &    � ��$ 13(�5y   -   6:   �� 5z   &    � ��$ Arial)�5{   -   6=   5|   #   �� 5}   "   "  6(   .�5~   &   ��  � ��$ 30��5   -   6:   �� 5�   &    � ��$ Times New Roman)�5�   -   6G   �� 5�   &    � ��$ 15(�5�   -   6:   �� 5�   &    � ��$
 Bold"�5�   -   6<   �� 5�   &    � ��$ Center=�5�   -   6>   �� 5�   &    � ��$ Center=�5�   -   6>   �� 5�   &    � �� �#e2e2e25�   ?   �� 5�   &    � ��
 �   �5�   =   �� 5�   &    � ��$ 1,1,0,1q�5�   -   6?   5�   #   5�          Columns  5�      0  *System.Windows.Controls.DataGridTextColumn  5�   "   ,	  &System.Windows.Controls.DataGridColumn! 	  Header$! Mã KH��65   " 	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	" 100
 5�   5   1  +System.Windows.Controls.DataGridBoundColumn#   Binding# 5�   5   �� *khachhang.IDKH+5�   #   4  .System.Windows.Controls.DataGridTemplateColumn  5�   "   $! 	Thao tác��69   $	" 110
 5�   9   $   CellTemplate$ 5�   &   �� 5�   *   .R�5�   .   � $��0,0,12,0q�63   % � ColumnDefinitions% 5�   2   �� 5�   6   $��30 �6G   6T   �� 5�   6   $��30 �6G   6T   .+�5�   2   �� $��0��69   $��0q�5�   9   $
��Auto��5�   9   $��20��5�   9   $��6,0,5,0q�5�   9   ��5�   9   Z� ��5�   9   �� $% DataContext.EditCustomerCommand�& �� RelativeSource& �� *FindAncestor+' �� AncestorType"'  ��5�   9   �� $ khachhang.IDKH�.��5�   6   � .+�5�   :   �� $��..\..\Photo\edit_icon.png��6@   $��-17,-4,1,-4q�5�   @   ( J� RenderTransformOrigin$( 0.5,0.5&�5�   @   z�5�   >   V� 5�   B   .~�5�   F   �� ) �� ScaleX$) -1Q�6U   �� 5�   F   �� 5�   F   T� 5�   F   5�   C   5�   ;   5�   7   5�   3   �� 5�   2   $��1��69   $��0q�5�   9   $
��Auto��5�   9   $��20��5�   9   $��11,0,0,0q�5�   9   ��5�   9   Z� ��5�   9   �� $$ DataContext.DeletePlaceCommand�& �� *FindAncestor+"'  ��5�   9   �� $ khachhang.IDKH�.��5�   6   � .+�5�   :   �� $!��..\..\Photo\delete_icon.png��6@   $��-17,-15,-4,-15q�5�   @   $( 0.5,0.5&�5�   @   z�5�   >   V� 5�   B   .~�5�   F   �� $) -1Q�6U   �� 5�   F   �� 5�   F   T� 5�   F   5�   C   5�   ;   5�   7   5�   3   5�   /   5�   +   5�   #     5�   "   $! Tên khách hàng��65   $	" 250
 5�   5   # 5�   5   �� *khachhang.TENKH+5�   C     5�   "   $! 	Số CMND��65   $	" 150
 5�   5   # 5�   5   �� *khachhang.CMND+5�   C     5�   "   $! Email��65   $	" 300
 5�   5   # 5�   5   �� *khachhang.EMAIL+5�   #     5�   "   $! Địa chỉ��65   $	" 520
 5�   5   # 5�   5   �� *khachhang.DIACHI+5�   C   5�      5�      5�      5�      5�      5�      5�      