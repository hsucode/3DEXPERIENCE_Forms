   M S B A M L   `   `   `  ����   Windows.InformationBox*    $DSMessageBoxSpace.DSMessageBoxWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  InformationBox��$	��500��$	��400��
������  � WindowStyle$
 None=� � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=� � ShowInTaskbar .   � Topmost .  � 	Resources  �� Source�� $) #/Windows.Theme;component/Theme.xaml?�%    .��� .+���    DialogPanelStyle#��[  ._�� 	 � RowDefinitions	 �� $��24 ��� $��1 ��� $��* ��� $��1 ��� $��40 �.+�� -   $��0��.+���   DialogTitleStyle#��[ ._�� 
 � ColumnDefinitions
 �� $��5 ��� $��25 ��� $��3 ��� $��* ��� $��24 ��� $��3 �.+�� $��1��$
��Left=�$��Center=�.+��� -    ��Name$	 sss��  DialogTitleFontStyle#��[ 提示� $��4��.+��� -    ��Name$ CloseApp��$��2q�  Dlg_Close_Button#��[ � $��1�����#D1D4D4� $��3�����#D1D4D4� $��2��
�������.+��� $��10q�
������ $��2q�$
��Auto=�$��Disabled=�.���� $	��Top=�$
��Left=�$
��Wrap=� �� TextAlignment$
 Left=�$��12(����� *MessageBoxText+� $��4��.+���   DialogBottomStyle#��[ ._�� 
 �� $��* ��� $��68 ��� $��68 ��� $��68 ��� $��5 �.+�� $��2��.+��� -   $ cmdOk��$	�� OK��  OkButton#��[ ��Z� � $��3��.+��� -   $ 	cmdCancel��$��Cancel��  CancelButton#��[ 