   M S B A M L   `   `   `  ����I  ETourManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle7clr-namespace:TourManagement.View.ManageTrip.Trip_Staff)TourManagement.View.ManageTrip.Trip_Staff  5   	   <    6TourManagement.View.ManageTrip.Trip_Staff.WD_StaffList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Ilocal7clr-namespace:TourManagement.View.ManageTrip.Trip_Staff     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          �Name$  wd_StaffList��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowState$ 	Maximized=�5   	      UC_ManageStaffVM � DataContext# [  5   	    � Title$ WD_StaffList��5   	   $	��900��6   $
��1600��6+   .��5      �� 
���   �$��2q�5      $��5q�5      ._�5   
   �  � RowDefinitions 5      �� 5      $��50 �6    6.   �� 5      6"   .+�5      � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      ��  * &MaterialDesignFloatingActionMiniButton#���  6   $��5q�5      
����ح�+  %MaterialDesignThemes.Wpf.ShadowAssist	   ShadowDepth$	 Depth3=�5!      ��5      �� *QuitCommand+��5      �� 
 �� ElementName$
 wd_StaffList��.��5"      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ KeyboardBackspace=�62   5#      #  MaterialDesignThemes.Wpf.Card  5%      $	 Depth2=�6*   $��
20,10,0,10q�5&   *   .��5(      �� $
��Left=�6"   $	��200��5)   "   $��14(�5*   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nhập tên nhân viên��5+   "    �� TextAlignment$
 Left=�5,   "   $��5,0,0,0q�5-   "   ���#E4E4E4��5.   "   �� *StaffNameFind+ �� UpdateSourceTrigger$ PropertyChanged=� �� NotifyOnSourceUpdated . 5/   "   50      �� 5?      $��Tìm kiếm��6    �� 	IsDefault .   MaterialDesignRaisedButton#���  5B      $	 Depth4=�5C      
���   �$
��Auto��5E      $��0q�5F      $
��Left=�5G      ���	#FFF0EFEF$��
10,10,0,10q�5I      ��5A      ��  �� Path$ StaffFindCommand�5I      �� 5K      $��Mặc định��6   #���  5M      $	 Depth4=�5N      
���   �$
��Auto��5P      $��0q�5Q      $
��Left=�5R      ���	#FFF0EFEF$��
10,10,0,10q�5T      ��5L      �� $ DefaultStaffFindCommand�5T      �� 5V      #���  6   $	 Depth2=�5X      $��Thêm mới��5Y      $	��100��5Z      
����ح�$
��Left=�5\      $��0q�5]      $��20,0,0,0q�5^      $��30��5_      ��5W      �� $ AddStaffCommand�5_   +   5`      5a      � 5c      $��1��6   $��5,5,10,5q�5d      .+�5e      �� .��5f      &   System.Windows.Controls.DataGrid     AlternatingRowBackground �#e2e2e2   
IsReadOnly . $
��Auto=�5k         AutoGenerateColumns .     CanUserResizeColumns .     CanUserReorderColumns .  ��5f      �� *STAFFLISTDTG+ . $ PropertyChanged=� �� Mode$ TwoWay=� �� SelectedItem 5i      �� *SelectedSTAFF+$ PropertyChanged=� . $ TwoWay=� J� InputBindings 5o      d� 5p       d� Gesture$ LeftDoubleClicka�6+    �� Command 5q   +   �� *DoubleClickSelectStaffCommand+ �� CommandParameter 5r   +   �� $
 wd_StaffList�� � 	Resources 5t      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Property  �� Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%�  '        '  �     �� 5u      "  6$   .�5v   "   ��  � ��$  35��5w   )   66   �� 5x   "    � ��$  13(�5y   )   66   �� 5z   "    � ��$  Arial)�5{   )   69   5|      �� 5}      "  6$   .�5~   "   ��  � ��$  30��5   )   66   �� 5�   "    � ��$  Times New Roman)�5�   )   6C   �� 5�   "    � ��$  15(�5�   )   66   �� 5�   "    � ��$
  Bold"�5�   )   68   �� 5�   "    � ��$  Center=�5�   )   6:   �� 5�   "    � ��$  Center=�5�   )   6:   �� 5�   "    � ��  �#e2e2e25�   ;   �� 5�   "    � ��
  �   �5�   9   �� 5�   "    � ��$  1,1,0,1q�5�   )   6;   5�      5�      !   Columns! 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,	  &System.Windows.Controls.DataGridColumn" 	  Header$" Mã NV��61   # 	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	# 100
 5�   1   1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ 5�   1   �� *nhanvien.IDNV+5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      $" 	Thao tác��65   $	# 110
 5�   5   %   CellTemplate% 5�   "   �� 5�   &   .R�5�   *   � $��0,0,12,0q�6/   & � ColumnDefinitions& 5�   .   �� 5�   2   $��30 �6C   6P   �� 5�   2   $��30 �6C   6P   .+�5�   .   �� $��0��65   $��0q�5�   5   $
��Auto��5�   5   $��20��5�   5   $��6,0,5,0q�5�   5   ��5�   5   Z� ��5�   5   �� $" DataContext.EditStaffCommand�' �� RelativeSource' �� *FindAncestor+( �� AncestorType"(  ��5�   5   �� $ nhanvien.IDNV�.��5�   2   � .+�5�   6   �� $��..\..\Photo\edit_icon.png��6<   $��-17,-4,1,-4q�5�   <   ) J� RenderTransformOrigin$) 0.5,0.5&�5�   <   z�5�   :   V� 5�   >   .~�5�   B   �� * �� ScaleX$* -1Q�6Q   �� 5�   B   �� 5�   B   T� 5�   B   5�   ?   5�   7   5�   3   5�   /   �� 5�   .   $��1��65   $��0q�5�   5   $
��Auto��5�   5   $��20��5�   5   $��11,0,0,0q�5�   5   ��5�   5   Z� ��5�   5   �� $$ DataContext.DeleteStaffCommand�' �� *FindAncestor+"(  ��5�   5   �� $ nhanvien.IDNV�.��5�   2   � .+�5�   6   �� $!��..\..\Photo\delete_icon.png��6<   $��-17,-15,-4,-15q�5�   <   $) 0.5,0.5&�5�   <   z�5�   :   V� 5�   >   .~�5�   B   �� $* -1Q�6Q   �� 5�   B   �� 5�   B   T� 5�   B   5�   ?   5�   7   5�   3   5�   /   5�   +   5�   '   5�        5�      $" Tên nhân viên��61   $	# 300
 5�   1   $ 5�   1   �� *nhanvien.TENNV+5�   ?     5�      $" Chức vụ��61   $	# 150
 5�   1   $ 5�   1   �� *nhanvien.CHUCVU+5�   ?     5�      $	" SDT��61   $	# 150
 5�   1   $ 5�   1   �� *nhanvien.SDT+5�        5�      $" Email��61   $	# 200
 5�   1   $ 5�   1   �� *nhanvien.EMAIL+5�        5�      $" Địa chỉ��61   $	# 400
 5�   1   $ 5�   1   �� *nhanvien.DIACHI+5�   ?   5�      5�      5�      5�      5�      5�      