   M S B A M L   `   `   `  ����  Attendence_System'    !Attendence_System.DashboardWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	DASHBOARD��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ 	Maximized=�5   	    � 
ResizeMode$ NoResize=�5   	   ���#F5F5F5 � 	Resources 5
      3  -System.Windows.Media.Effects.DropShadowEffect   DropShadowEffect   ShadowDepth   
BlurRadius   Opacity �� 
TargetType  RoundedButtonStyle	 �� Property
 �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value&   System.Windows.Controls.DataGrid  DataGridStyle��%�  &	        &	 7     7   &	 �    7     5   
   $ 3Q�64   $ 5Q�6D   $	 0.3Q�6S   �� 5   
   " ��6   .�5      �� 	 � ��$

 10,5q�6(   �� 5      	 � ��

 ���� 6,   �� 5      	 � ��
 �#4CAF506+   �� 5      	 � ��

 �����6+   �� 5      	 � ��$

 Bold"�6+   �� 5      	 �@J�Effect8
   6'   �� 5      	 � ��
 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5   !   $��0q�5   !   $ 20��5   !   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5!       5"      P� 5$       �@J�IsMouseOver$
 True��61   . �5%      �� 	 � ��
 �#66BB6A63   5&      P� 5'       � ��$
 True��6/   . �5(      �� 	 � ��
 �#388E3C63   5)      5+      �� 5.   
   "  6   .�5/      �� 	 � ��
 �#3336+   �� 50      	 � ��

 �����6+   �� 51      	 � ��$
 0q�60   �� 52      	 �@ ColumnHeaderHeight$
 35Q�63   �� 53      	 �@ 	RowHeight$
 35Q�6*   �� 54      	 �@J�Effect8
   6'   �� 55      	 �@ GridLinesVisibility$

 None=�64   �� 56       	 �@ HorizontalGridLinesBrush

 �����69   �� 57      	 �@ VerticalGridLinesBrush

 �����67   58      59      .��5;      � $��Center=�6   $��Center=�6(   .+�5<   
   �� $ 15��6   
������� �� Padding$ 30q�66   ���#E0E0E0$��1q�5=   '    J� Effect# [  6;   ._�5?      �� $��Center=�6   $��Center=�66   $	��500��6Q   .+�5A      �� -   5         ��Name$ WelcomeLabel��5A      $��Welcome, User!��6.   $��24(�5B      $
��Bold"�6&   ���#333$��Center=�5C      $��0,0,0,20q�65   �� 5F       �� Orientation$ 
Horizontal=�6   $��Center=�66   $��0,0,0,20q�6S   .+�5G      �� -   5        $��Clock In��5G      $	��100��60   $
��10,0q�6<   #��[ 6J   6v   �� 5H      -   5        $��	Clock Out��5H      $	��100��61   $
��10,0q�6=   #��[ 6K   6w   �� 5I      -   5        $��LogOut��5I      $	��100��6.   $
��10,0q�6:   #��[ 6H   6t   5J      �� 5M      -   5        $��View Attendance��5M      $	��150��63   $��	0,10,0,20q�6?   $��Center=�5N      #��[ 66   5O        5R      -   5          Name$ AttendanceGrid��5R      $	��860��5S      $	��300��6'   $y�	Collapsed=�5T      #��[ 5U         AutoGenerateColumns$ False��5V         HeadersVisibility$ Column=�5W         CanUserAddRows$ False��5X         
IsReadOnly$
 True��5Y      $��0,20,0,0q�5Z         Columns 5[      0  *System.Windows.Controls.DataGridTextColumn  5\      ,  &System.Windows.Controls.DataGridColumn   Header$ Employee ID��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *
EmployeeID+6a     5]      $ Clock In Time��6-   $	 200 6d    6D   �� *ClockInTime+6d     5^      $ Clock Out Time��6-   $	 200 6f    6E   �� *ClockOutTime+6f     5_      $
 Date��6-   $	 150 6T    6;   �� *Date+6T     5`      $ Status��6-   $	 100 6X    6=   �� *Status+6X   5b      5c      5d      5e      5f      