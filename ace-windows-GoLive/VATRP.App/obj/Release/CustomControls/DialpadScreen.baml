   M S B A M L   `   `   `  ���� ?  ;ACE, Version=0.0.62.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:com.vtcsecure.ace.windows.Properties$com.vtcsecure.ace.windows.Properties  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem [2clr-namespace:com.vtcsecure.ace.windows.Converters$com.vtcsecure.ace.windows.Converters  <    6com.vtcsecure.ace.windows.CustomControls.DialPadScreen   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     I
properties2clr-namespace:com.vtcsecure.ace.windows.Properties     9System&clr-namespace:System;assembly=mscorlib     Cconv2clr-namespace:com.vtcsecure.ace.windows.Converters     -     � 	Resources  D   >com.vtcsecure.ace.windows.Converters.CallStateToBrushConverter   cstb��%   &	          .���  � ShowGridLines .  
������� � RowDefinitions �� $��* ��� $��55 ��� $��55 ��� $��55 ��� $��55 ��� $��55 � � ColumnDefinitions �� $	��100 ��� $	��100 ��� $	��100 �.+�� $��0��$��3��$��0,1,0,0q�  AppMainWindowBrush#���   �� $��* ��� $
��Auto �.+��� -   $"��RemotePartyNumberPlaceHolder��$��19(�$��0��$��1,5,0,0q�$��0q�
������ $��Enter Number/User Name��
��������� -     DialpadPageRemotePartyFont#���  $��35(� �� MaxLines$ 1��$��0�� �� 
CaretBrush
 �����$��5,0,0,0q� �� AcceptsReturn .  $��0q�
������  �� CharacterCasing$ Lower=����� *RemotePartyNumber+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� -   $��45��
�������$��30��$��10q�$��1��
 J� OpacityMask
 ��  �� ImageSource$, &/ACE;component/Resources/backspace.png�� j� Stretch$ UniformToFill=��� -    ��Name$ buttonKeyPad1��$��0��  KeypadButtonStyle#���  $��0,1,0.5,0.5q�$��1��.����  �� Orientation$ 
Horizontal=�.+��� $��0,8,0,8q�$��Center=�$��Center=�$��30(��� $�1���� -   $ buttonKeyPad2��#���  $��0,1,0.5,0.5q�$��1��$��1��.���� $ Vertical=�.+��� $��Center=�$��Center=�$��30(�$��2��$
��0,-4q��� $��0,0,0,2q�$��Center=�$��Center=�$��14(�$��25���� $	�ABC���� -   $ buttonKeyPad3��#���  $��0.5,1,0,0.5q�$��1��$��2��.���� $ Vertical=�.+��� $��Center=�$��Center=�$��30(�$��3��$
��0,-4q��� $��0,0,0,-2q�$��Center=�$��Center=�$��14(�$��25���� $	�DEF���� -   $ buttonKeyPad4��$��0��#���  $��0,0.5,0.5,0.5q�$��2��.���� $ Vertical=�.+��� $��Center=�$��Center=�$��30(�$��4��$
��0,-4q��� $��0,0,0,-2q�$��Center=�$��Center=�$��14(�$��25���� $	�GHI���� -	   $ buttonKeyPad5��#���  $��0.5,0.5,0.5,0.5q�$��2��$��1��.���� $ Vertical=�.+��� $��Center=�$��Center=�$��30(�$
��0,-4q�$��5���� $��0,0,0,-2q�$��Center=�$��Center=�$��14(�$��25���� $	�JKL���� -
   $ buttonKeyPad6��#���  $��0.5,0.5,0,0.5q�$��2��$��2��.���� $ Vertical=�.+��� $��Center=�$��Center=�$��30(�$
��0,-4q�$��6���� $��0,0,0,-2q�$��Center=�$��Center=�$��14(�$��25���� $	�MNO���� -   $ buttonKeyPad7��$��0��#���  $��0,0.5,0.5,0.5q�$��3��.���� $ Vertical=�.+��� $��Center=�$��Center=�$��30(�$
��0,-4q�$��7���� $��0,0,0,-2q�$��Center=�$��Center=�$��14(�$��25���� $
�PQRS���� -   $ buttonKeyPad8��#���  $	��0.5q�$��3��$��1��.���� $ Vertical=�.+��� $��Center=�$��Center=�$��30(�$
��0,-4q�$��8���� $��0,0,0,-2q�$��Center=�$��Center=�$��14(�$��25���� $	�TUV���� -   $ buttonKeyPad9��#���  $��0.5,0.5,0,0.5q�$��3��$��2��.���� $ Vertical=�.+��� $��Center=�$��Center=�$��30(�$
��0,-4q�$��9���� $��0,0,0,-2q�$��Center=�$��Center=�$��14(�$��25���� $
�WXYZ���� -   $ buttonKeyPadStar��#���  $��0,0.5,0.5,0.5q�$��4��.���� $ 
Horizontal=�$��Center=�$��Center=�.+��� $��Center=�$��Center=�$��30(��� $�*���� -   $ buttonKeyPad0��#���  $	��0.5q�$��4��$��1��.���� $ 
Horizontal=�$
��Left=�$��Center=�.+��� $��Center=�$��Center=�$��30(�$��0q��� $�0���� -    ��Name$ textBlockKeyPad0Plus��$��2,0,0,0q�$��Center=�$��Center=�$��14(��� $�+���� -   $ buttonKeyPadSharp��#���  $��4��$��2��$��0.5,0.5,0,0.5q�.���� $ vertical=�$��Center=�$��Center=�.+��� $��Center=�$��Center=�$��30(�$��0,0,0,0q��� $�#���� $��0��$��5��$��0,0.5,0.5,0q� $  DialpadProviderComboBoxItemStyle#��[   ProviderComboStyle#��[ #��[ #��[   AppMainBorderBrush#��[  �� SelectedItem �� *SelectedProvider+$ TwoWay=�$	 PropertyChanged=����� *	Providers+  ��%    ���� .R��� $ 
Horizontal=�
������ $��Center=�$��Center=�.+��� $��50��$��50��$��Center=�$��Center=�$��UniformToFill=����� *Provider.ImagePath+�� -   $ buttonAudioCall��$��0.5,0.5,0,0q�$��1��$��5��$��2�� � Cursor$
 Hand��    CallButtonNormal �� 	Converter & "DialpadPageKeyButtonNormalTextFont "	 NavigationBarPressedButtonFont��%:  &	       7   � ���� *	CallState+8    �� $��* ��� $��* �.+��� $��Center=�$��Right=�$��0,0,10,0q�$��0��.+��� $��38��$��21��#���  $	��Top=�$��0��$��2��
 �� $! ..\Resources\cameraview.png���� $��1��$
��Call��$
��Left=�$��33(�$��Center=�$��5,-3,0,0q�#��� 	 ����  �� 
TargetType" ��.���  �� Property �@J�Opacity �� Value$ 1Q���  � ��$ 0q���  � ��$ 0q���  �@J�SnapsToDevicePixels . ��  � ��$ Stretch=���  � ��$ Stretch=���  � ��# �  ��  � �� ��  �� 
TargetType" ��.R�� 
������ .+���  ��Name$ ButtonBackground��#��z��#��z��#��z�� �� CornerRadius$ 0��$��0q�._���  ��Name$ ContentContainer��#��z��#��z��#��z��#��z��#��z��#��z�� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � ��# �  P�  � �� . . ���  � ��# �  ^�  ^� 
Conditions ��  �� Binding ��  �� RelativeSource �� *Self+  �� Path$  IsMouseOver�! �� Value! True��  ��  �� *Self+$  	IsPressed�! True.0���  �@J�Opacity$	 0.7Q���  � ��# �  