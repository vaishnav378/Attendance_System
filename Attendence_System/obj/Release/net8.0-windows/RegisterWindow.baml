   M S B A M L   `   `   `  ����   Attendence_System&     Attendance_System.RegisterWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Register Employee�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � 
ResizeMode$ 	CanResize=����#F0F0F0 � 	Resources 3  -System.Windows.Media.Effects.DropShadowEffect   DropShadowEffect   
BlurRadius   ShadowDepth   Opacity   Color  RoundedButtonStyle	 �� 
TargetType
 �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value �� Padding ��Name��%�  &	        &	 ,     '�� �    'G�       $ 10Q�$ 4Q�$	 0.5Q�$ Black���� "	 ��.��� 
 � ��$
 10,5q��� 
 � ��
 ���� �� 
 � �� �#4CAF50�� 
 � ��
 ������� 
 � ��$
 Bold"��� 
 � �� �� " ��.R��� #��z��$ 10��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� 
 � �� �#66BB6AP�  � ��$
 True��. ��� 
 � �� �#388E3C�� "	 ��.��� 
 � �� �� " ��.R��� 
����������#CCCCCC$��1q�$ 5��$ 4q�._��� $ PART_ContentHost��$��0q��� "	 G�.��� 
 � �� �� " G�.R��� 
����������#CCCCCC$��1q�$ 5��$ 4q�._��� $ PART_ContentHost��$��0q�.��� .+��� 
�������$ 15��$ 30q�$��Center=�$��Center=�$	��400�� J� Effect# [  ._��� .+��� $��Register Employee��$��24(�$
��Bold"�$��Center=�$��0,0,0,20q����#333��  �� Orientation$ 
Horizontal=�$��0,0,0,10q�.+��� $��
Full Name:��$��Center=�$��80���� -    ��Name$ txtFullName��$	��200���� $ 
Horizontal=�$��0,0,0,10q�.+��� $��	Username:��$��Center=�$��80���� -   $ txtUsername��$	��200���� $ 
Horizontal=�$��0,0,0,10q�.+��� $��	Password:��$��Center=�$��80��G� -    G�Name$ txtPassword��$	��200���� $ 
Horizontal=�$��0,0,0,10q�.+��� $��Email:��$��Center=�$��80���� -   $ txtEmail��$	��200���� $ 
Horizontal=�$��0,0,0,20q�.+��� $��Role:��$��Center=�$��80���� -    ��Name$ cbRole��$	��200��.@��� $��Admin���� $
��User���� -   $��Capture Face��$	��200��$��30��$��Center=�#��[ �� -   $��Register��$	��120��$��40��$��15q�$��Center=�#��[ 