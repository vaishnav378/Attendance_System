   M S B A M L   `   `   `  ����   Attendence_System#    Attendence_System.LoginWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  LOGIN��$	��250��$	��300�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � 
ResizeMode$ 	CanResize=�
������� � 	Resources 3  -System.Windows.Media.Effects.DropShadowEffect   DropShadowEffect   ShadowDepth   
BlurRadius   Opacity  RoundedButtonStyle �� 
TargetType	 �� Property
 �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value��%�  &	        &	       7     $ 5Q�$ 10Q�$	 0.3Q��� " ��.��� 	 � ��$	
 5,2q��� 	 � ��

 ���� �� 	 �@J�Effect8
   �� 	 � ��
 �#4CAF50�� 	 � ��

 ������� 	 � ��$

 Bold"��� 	 � ��
 �� " ��.R��� #��z��#��z��$��0q�$ 15��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� 	 � ��
 �#66BB6A�� 	 � ��
 �#388E3CP�  � ��$
 True��. ��� 	 � ��
 �#388E3C.��� $��Center=�$��Center=�$	��400��$	��300��.+��� -    ��Name$ CameraPreview��$	��300��$	��200��$��	0,10,0,20q�$��Uniform=��� $ 15��
������� �� Padding$ 20q����#E0E0E0$��2q� J� Effect# [  ._��� .+��� $��Welcome Back��$��24(�$
��Bold"����#333$��Center=�$��0,0,0,20q���  �� Orientation$ 
Horizontal=�$��0,0,0,10q�.+��� $��	Username:��$��Center=����#555$
��Bold"��� -    ��Name$ UsernameTextBox��$	��200��$��10,0,0,0q�$��5q����#CCC���#F0F0F0$��1q��� $ 
Horizontal=�$��4,0,0,10q�.+��� $��	Password:��$��Center=����#555$
��Bold"�G� -    G�Name$ PasswordBox��$	��200��$��10,0,0,0q�$��5q����#CCC���#F0F0F0$��1q��� $ 
Horizontal=�$��Center=�.+��� -   $��Login��$	��100��$��35��$
��10,0q�#��[ �� -   $��Register��$	��100��$��35��$
��10,0q����#2196F3
�������$
��Bold"� � Cursor$
 Hand��#��[ �� -   $��Capture & Login��$	��150��$��35��$��13q����#FF9800
�������$
��Bold"�$
 Hand��#��[ 