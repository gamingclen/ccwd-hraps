   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      	 HRaPS   HRaPS.HR.view.main   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      -   5          � Title$  HR��5      $	��600��5      $
��1405��5       � WindowState$ 	Maximized=�5	      $��0q�5      (   "MahApps.Metro.Controls.MetroWindow   	GlowBrush$ Black��5       � 
ResizeMode$ CanResizeWithGrip=�5         WindowTransitionsEnabled .   � WindowStartupLocation$ CenterScreen=�5         ShowCloseButton .     ShowMaxRestoreButton .     RightWindowCommands 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5        $��btnMenu��5      .��5      �� 	 �� Orientation$	 
Horizontal=�6   .+�5      �� $��20��6    $��20��5      ��5      �� 
 �� RelativeSource
 ��  �� AncestorType$ ButtonL� �� Path$ 
Foreground� J� OpacityMask 5      !� 5       j� Stretch$
 Fill=�6*      appbar_user !� Visual# [  69   5      �� 5       -   5        $��
user_login��5    1   $��4 0 5 0q�6    $��Center=�5!      $��	 Username��5"       � ToolTip$ Username��6%   5#      5$      5&      .��5*      � -   5         �Name$ 	grid_main��5*      .+�5+   
   � .+�5-      �� $��Center=�6   $��Center=�64   .+�5.      �� $+��%/HRaPS;component/Pictures/hr-icon.png��6   $	��250��6G   5/      53      #   MahApps.Metro.Controls.Flyout  55   
   -   5          Name$ foSide��55   K      Position$ Bottom=�6   $	��200��6-      Theme$ Inverse=�6:   .��56      � .+�57      � -   5        $��gridMenu��57      $y�Visible=�6'   .+�59      �� $
��Auto=�6#   $��Hidden=�6H   .��5;      �� $	 
Horizontal=�6%   .+�5=      �� -   5         ��Name$ 	btnCreate��5?        SquareButtonStyle#��[ 5@      $
��Left=�5B      $��Center=�5C      $	��140��64   $	��200��6@   $ Create Employee��6M   $��1q�6g    � Cursor$
 Hand��6�   ��6{   Z� .��5D   "   �� .+�5E   &   �� $*��$/HRaPS;component/Pictures/create.png��6,   �� 5F   &   $��Create��60   $��Center=�6>    �� TextAlignment$ Center=�6Y   
�������6�   5G   #   5H      �� 5K      -   5        $ btnView��5M      #��[ 5N      $
��Left=�5P      $��Center=�5Q      $	��140��64   $	��200��6@   $ View Employee��6M   $��1q�6e   $
 Hand��6�   ��6y   Z� .��5R   "   �� .+�5S   &   �� $(��"/HRaPS;component/Pictures/View.png��6,   �� 5T   &   $
��View��60   $��Center=�6<   $ Center=�6W   
�������6�   5U   #   5V      �� 5Y      -	   5        $ btnDTR��5[      #��[ 5\      $
��Left=�5^      $��Center=�5_      $	��140��64   $	��200��6@   $	 DTR��6M   $��1q�6[   $
 Hand��6�   ��6o   Z� .��5`   "   �� .+�5a   &   �� $'��!/HRaPS;component/Pictures/dtr.png��6,   �� 5b   &   $	��DTR��60   $��Center=�6;   $ Center=�6V   
�������6�   5c   #   5d      �� 5g      -
   5        $ btnCreateAttendance��5i      #��[ 5j      $
��Left=�5l      $��Center=�5m      $	��140��64   $	��200��6@   $ Create Attendance��6M   $��1q�6i   $
 Hand��6�   ��6}   Z� .��5n   "   �� .+�5o   &   �� $.��(/HRaPS;component/Pictures/attendance.png��6,   �� 5p   &   $��
Attendance��60   $��Center=�6B   $ Center=�6]   
�������6�   5q   #   5r      �� 5u      -   5        $ btnSchedule��5w      #��[ 5x      $
��Left=�5z      $��Center=�5{      $	��140��64   $	��200��6@   $ Create Schedule��6M   $��1q�6g   $
 Hand��6�   ��6{   Z� .��5|   "   �� .+�5}   &   �� $,��&/HRaPS;component/Pictures/schedule.png��6,   �� 5~   &   $��Schedule��60   $��Center=�6@   $ Center=�6[   
�������6�   5   #   5�      �� 5�      -   5        $ btnLeave��5�   !   #��[ 5�   !   $
��Left=�5�   !   $��Center=�5�   !   $	��140��6<   $	��200��6H   $ Create Leave��6U   $��1q�6l   $
 Hand��6�   ��6�   Z� .��5�   *   �� .+�5�   .   �� $)��#/HRaPS;component/Pictures/leave.png��64   �� 5�   .   $��Leave��68   $��Center=�6E   $ Center=�6`   
�������6�   5�   +   5�      �� 5�      -   5        $ btnClose��5�      #��[ 5�      $��Right=�5�      $��Center=�5�      $	��140��64   $	��200��6@   $ Close��6M   $��1q�6]   $
 Hand��6�   ��6q   Z� .��5�   "   �� .+�5�   &   �� $)��#/HRaPS;component/Pictures/close.png��6,   �� 5�   &   $��Close��60   $��Center=�6=   $ Center=�6X   
�������6�   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      