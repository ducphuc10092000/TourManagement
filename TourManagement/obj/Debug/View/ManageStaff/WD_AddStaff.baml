   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:TourManagement.View.ManageStaffTourManagement.View.ManageStaff  5   	   1    +TourManagement.View.ManageStaff.WD_AddStaff   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:TourManagement.View.ManageStaff     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  wd_AddStaff��5   	      WD_AddStaffVM � DataContext# [  5   	    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ WD_AddStaff��5   	   $	��650��5   	   $	��900��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��29* �6   �� 5      $	��31* �6   .+�5   
   � $��2��6   .+�5      � ���	#FFADD8E6.+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6+   $��50��5   +   .��5      ]� .+�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $��Center=�6(   $��20(�5   (   $��16 0 0 0q�5   (   Thêm mới nhân viên5       5!      5"      5#      � 5$      .+�5%      #  MaterialDesignThemes.Wpf.Card  $��5,55,5,5q�6*   ���	#FFFBFBFB+  %MaterialDesignThemes.Wpf.ShadowAssist	   ShadowDepth$	 Depth5=�5'   *   .��5(      �  5)      �� 5*   "   $	��550 �63   6A   �� 5+   "   65   .+�5.      �� $ Vertical=�6)   $��0��5/   )   .+�50   "   �� )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tên nhân viên��6*   
�������/  )MaterialDesignThemes.Wpf.ValidationAssist   HasError . $��50��53   *   $	��500��54   *   $��5,-5,0,0q�56   *   $��0,10,0,0q�57   *   $��20(�58   *    % !MaterialDesignFloatingHintTextBox#��[ 59   *   ��55   *   �� *	StaffName+59   *   �� 5:   "   $
 	Số CMND��6*   
�������$��50��5<   *   $	��500��5=   *   $��5,-5,0,0q�5?   *   $��0,20,0,0q�5@   *   $��20(�5A   *   #��[ 5B   *   ��5>   *   �� *IdentificationStaff+5B   *   (  "System.Windows.Controls.DatePicker  5C   "   $
 
Ngày sinh��6-   
�������$��55��5E   -   $	��390��5F   -      SelectedDateFormat$ Short=�5H   -   $��	35,20,0,0q�5I   -   $��30,10,10,10q�5J   -   $
��Left=�5K   -    ( $MaterialDesignFloatingHintDatePicker#��[ 5L   -   $��20(�5M   -      Text 5G   -   �� *StaffBirthdayDT+ �� StringFormat$ 
dd/MM/yyyy�� �� Mode$ TwoWay=� �� NotifyOnSourceUpdated .  �� UpdateSourceTrigger$ Default=�5M   -   �� 5O   "   $
 Số điện thoại��6*   
�������$��50��5Q   *   $	��500��5R   *   $��5,-5,0,0q�5T   *   $��0,20,0,0q�5U   *   $��20(�5V   *   #��[ 5W   *   ��5S   *   �� *StaffPhoneNumber+5W   *   �� 5X   "   $
 Email��6*   
�������$��50��5Z   *   $	��500��5[   *   $��5,-5,0,0q�5]   *   $��0,20,0,0q�5^   *   $��20(�5_   *   #��[ 5`   *   ��5\   *   �� *
StaffEmail+5`   *   �� 5a   "   $
 Địa chỉ��6*   
�������$��50��5c   *   $	��500��5d   *   $��5,-5,0,0q�5f   *   $��0,20,0,0q�5g   *   $��20(�5h   *   #��[ 5i   *   ��5e   *   �� *StaffAddress+5i   *   �� 5j   "   $
 Chức vụ��6+   $
��Left=�5k   +   $	��390��5m   +    �� 
IsEditable . 
�������$��5,-5,0,0q�5p   +   $��	25,20,0,0q�5q   +   $��Center=�5r   +   $
��Left=�5s   +   $��20(�5u   +   $��50��5v   +   ��5l   +   �� *StaffRolesList+$ PropertyChanged=� . $ TwoWay=� �� Text 5t   +   �� *	StaffRole+$ PropertyChanged=� . $ TwoWay=�5v   +   �� 5x   "   $ 
Horizontal=�6-   $��0,20,0,0q�5y   -   $��Center=�5z   -   .+�5{   &   �� $��40��6-   $	��150��5|   -   $��30,0,0,0q�5}   -   ���	#FFADD8E6  MaterialDesignRaisedButton#���  5�   -   $	 Depth3=�5�   -   ��5   -   �� *AddNewStaffCommand+��5�   -   ��  �� ElementName$ wd_AddStaff��.��5�   ^   Thêm mới5�   '   �� 5�   &   $
��auto��6-   $	��150��5�   -   #���  5�   -   $��	100,0,0,0q�5�   -   ���	#FFF3A2A2$	 Depth3=�5�   -   ��5�   -   �� *QuitCommand+��5�   -   �� $ wd_AddStaff��.��5�   ^   Thoát5�   '   5�   #   5�      � 5�      $��1��6#    � RowDefinitions 5�   "   �� 5�   &   $	��300 �64   6C   �� 5�   &   66   �� 5�   &   66   .+�5�   "   �� $��0��6)   
�������$��5,5,5,5q�5�   )   
���   �$��2q�5�   )   ._�5�   &   �� $��2,2,2,2q�6,   ��5�   ,   �� *AvatarSource+6N   5�   #   �� 5�   "   $��1��6-   $ 
Horizontal=�5�   -   $��0,0,0,30q�5�   -   $��Center=�5�   -   .+�5�   &   �� #���  6-   ���	#FFADD8E6$	 Depth2=�5�   -   $��Chọn ảnh��5�   -   $��30��5�   -   $	��100��5�   -   ��5�   -   �� *ChangePictureCommand+5�   ;   �� 5�   &   #���  6-   $	 Depth2=�5�   -   $��
Xóa ảnh��5�   -   ���	#FFF3A2A2$��30��5�   -   $	��100��5�   -   $��50,0,0,0q�5�   -   ��5�   -   �� *DeletePictureCommand+5�   A   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      