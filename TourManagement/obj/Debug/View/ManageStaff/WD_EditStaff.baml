   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:TourManagement.View.ManageStaffTourManagement.View.ManageStaff  5   	   2    ,TourManagement.View.ManageStaff.WD_EditStaff   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:TourManagement.View.ManageStaff     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  wd_EditStaff��5   	      WD_EditStaffVM � DataContext# [  5	   	    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ WD_EditStaff��5   	   $	��650��6   $	��900��6+   .��5      � .+�5   
   � .+�5      � ���	#FFADD8E6.+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6+   $��50��5   +   .��5      ]� .+�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $��Center=�6(   $��20(�5   (   $��16 0 0 0q�5   (   &$Chỉnh sửa thông tin nhân viên5      5      5      5      � 5      .+�5      #  MaterialDesignThemes.Wpf.Card  $��5,55,5,5q�6*   ���	#FFFBFBFB+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth5=�5!   *   .��5"      � 	 � ColumnDefinitions	 5#      �� 5$   "   $	��550 �63   6A   �� 5%   "   65   .+�5(      �� $ Vertical=�6)   $��0��5)   )   .+�5*   "   �� )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Tên nhân viên��6*   
�������/  )MaterialDesignThemes.Wpf.ValidationAssist   HasError . $��50��5-   *   $	��500��5.   *   $��5,-5,0,0q�50   *   $��0,10,0,0q�51   *   $��20(�52   *    % !MaterialDesignFloatingHintTextBox#��[ 53   *   ��5/   *   �� *	StaffName+53   *   �� 54   "   $
 	Số CMND��6*   
�������$��50��56   *   $	��500��57   *   $��5,-5,0,0q�59   *   $��0,20,0,0q�5:   *   $��20(�5;   *   #��[ 5<   *   ��58   *   �� *IdentificationStaff+5<   *   (  "System.Windows.Controls.DatePicker  5=   "   $
 
Ngày sinh��6-   
�������$��55��5?   -   $	��390��5@   -      SelectedDateFormat$ Short=�5B   -   $��	35,20,0,0q�5C   -   $��30,10,10,10q�5D   -   $
��Left=�5E   -    ( $MaterialDesignFloatingHintDatePicker#��[ 5F   -   $��20(�5G   -      Text 5A   -   �� *StaffBirthdayDT+ �� StringFormat$ 
dd/MM/yyyy�� �� Mode$ TwoWay=� �� NotifyOnSourceUpdated .  �� UpdateSourceTrigger$ Default=�5G   -   �� 5I   "   $
 Số điện thoại��6*   
�������$��50��5K   *   $	��500��5L   *   $��5,-5,0,0q�5N   *   $��0,20,0,0q�5O   *   $��20(�5P   *   #��[ 5Q   *   ��5M   *   �� *StaffPhoneNumber+5Q   *   �� 5R   "   $
 Email��6*   
�������$��50��5T   *   $	��500��5U   *   $��5,-5,0,0q�5W   *   $��0,20,0,0q�5X   *   $��20(�5Y   *   #��[ 5Z   *   ��5V   *   �� *
StaffEmail+5Z   *   �� 5[   "   $
 Địa chỉ��6*   
�������$��50��5]   *   $	��500��5^   *   $��5,-5,0,0q�5`   *   $��0,20,0,0q�5a   *   $��20(�5b   *   #��[ 5c   *   ��5_   *   �� *StaffAddress+5c   *   �� 5d   "   $
 Chức vụ��6+   $
��Left=�5e   +   $	��390��5g   +    �� 
IsEditable . 
�������$��5,-5,0,0q�5j   +   $��	25,20,0,0q�5k   +   $��Center=�5l   +   $
��Left=�5m   +   $��20(�5o   +   $��50��5p   +   ��5f   +   �� *StaffRolesList+$ PropertyChanged=� . $ TwoWay=� �� Text 5n   +   �� *	StaffRole+$ PropertyChanged=� . $ TwoWay=�5p   +   �� 5r   "   $ 
Horizontal=�6-   $��0,20,0,0q�5s   -   $��Center=�5t   -   .+�5u   &   �� $��40��6-   $	��150��5v   -   $��30,0,0,0q�5w   -   ���	#FFADD8E6  MaterialDesignRaisedButton#���  5{   -   $ Depth3=�5|   -   ��5y   -   �� *ConfirmEditStaffCommand+��5z   -   ��  �� ElementName$ wd_EditStaff��.��5|   ^   Xác nhận5~   '   �� 5   &   $
��auto��6-   $	��150��5�   -   #���  5�   -   $��	100,0,0,0q�5�   -   ���	#FFF3A2A2$ Depth3=�5�   -   ��5�   -   �� *QuitCommand+��5�   -   �� $ wd_EditStaff��.��5�   ^   Thoát5�   '   5�   #   5�      � 5�      $��1��6#    � RowDefinitions 5�   "   �� 5�   &   $	��300 �64   6C   �� 5�   &   66   �� 5�   &   66   .+�5�   "   �� $��0��6)   
�������$��5,5,5,5q�5�   )   
���   �$��2q�5�   )   ._�5�   &   �� $��2,2,2,2q�6,   ��5�   ,   �� *AvatarSource+6N   5�   #   �� 5�   "   $��1��6-   $ 
Horizontal=�5�   -   $��0,0,0,30q�5�   -   $��Center=�5�   -   .+�5�   &   �� #���  6-   ���	#FFADD8E6$ Depth2=�5�   -   $��Chọn ảnh��5�   -   $��30��5�   -   $	��100��5�   -   ��5�   -   �� *ChangePictureCommand+5�   ;   �� 5�   &   #���  6-   $ Depth2=�5�   -   $��
Xóa ảnh��5�   -   ���	#FFF3A2A2$��30��5�   -   $	��100��5�   -   $��50,0,0,0q�5�   -   ��5�   -   �� *DeletePictureCommand+5�   A   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      