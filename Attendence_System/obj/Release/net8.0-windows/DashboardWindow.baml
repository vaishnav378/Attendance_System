   M S B A M L   `   `   `  ����   Attendence_System'    !Attendence_System.DashboardWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  	DASHBOARD�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � 
ResizeMode$ NoResize=����#F5F5F5 � 	Resources 3  -System.Windows.Media.Effects.DropShadowEffect   DropShadowEffect   ShadowDepth   
BlurRadius   Opacity �� 
TargetType  RoundedButtonStyle	 �� Property
 �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value&   System.Windows.Controls.DataGrid  DataGridStyle��%
  &	        &	      7   &	 �    7     $ 3Q�$ 5Q�$	 0.3Q��� " ��.��� 	 � ��$

 10,5q��� 	 � ��

 ���� �� 	 � ��
 �#4CAF50�� 	 � ��

 ������� 	 � ��$

 Bold"��� 	 �@J�Effect8
   �� 	 � ��
 �� " ��.R��� #��z��#��z��$��0q�$ 20��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� 	 � ��
 �#66BB6AP�  � ��$
 True��. ��� 	 � ��
 �#388E3C�� "  .��� 	 � ��
 �#333�� 	 � ��

 ������� 	 � ��$
 0q��� 	 �@ ColumnHeaderHeight$
 35Q��� 	 �@ 	RowHeight$
 35Q��� 	 �@J�Effect8
   �� 	 �@ GridLinesVisibility$

 None=���  	 �@ HorizontalGridLinesBrush

 ������� 	 �@ VerticalGridLinesBrush

 �����.��� $��Center=�$��Center=�.+��� $ 15��
������� �� Padding$ 30q����#E0E0E0$��1q� J� Effect# [  ._��� $��Center=�$��Center=�$	��500��.+��� -    ��Name$ WelcomeLabel��$��Welcome, User!��$��24(�$
��Bold"����#333$��Center=�$��0,0,0,20q���  �� Orientation$ 
Horizontal=�$��Center=�$��0,0,0,20q�.+��� -   $��Clock In��$	��100��$
��10,0q�#��[ �� -   $��	Clock Out��$	��100��$
��10,0q�#��[ �� -   $��LogOut��$	��100��$
��10,0q�#��[ �� -   $��View Attendance��$	��150��$��	0,10,0,20q�$��Center=�#��[   -     Name$ AttendanceGrid��$	��860��$	��300��$y�	Collapsed=�#��[    AutoGenerateColumns$ False��   HeadersVisibility$ Column=�   CanUserAddRows$ False��   
IsReadOnly$
 True��$��0,20,0,0q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Employee ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
EmployeeID+  $ Clock In Time��$	 200  �� *ClockInTime+  $ Clock Out Time��$	 200  �� *ClockOutTime+  $
 Date��$	 150  �� *Date+  $ Status��$	 100  �� *Status+