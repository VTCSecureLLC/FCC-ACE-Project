   M S B A M L   `   `   `  ����?  ;ACE, Version=0.0.62.0, Culture=neutral, PublicKeyToken=null�Fclr-namespace:com.vtcsecure.ace.windows.CustomControls.UnifiedSettings8com.vtcsecure.ace.windows.CustomControls.UnifiedSettings  5      W    Qcom.vtcsecure.ace.windows.CustomControls.UnifiedSettings.UnifiedSettingsVideoCtrl   5   !   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      XlocalFclr-namespace:com.vtcsecure.ace.windows.CustomControls.UnifiedSettings     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5	      � .+�5
   
   �    RecentsPageMainBg#��[  6     � RowDefinitions  5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $	��240 �6#   �� 5      $
��120* �6#   �� 5      $��40 �6#   .+�5      �� $��0��6   $��0��6$   $��3��61   $��General Video Settings��6F   $��Center=�6g   
�������5      �� 5      -   5        $��AutomaticallyStartLabel��5   /   $��0��5      $��1��6$   $��2��61   $��Automatically Start��6E   $��Center=�6c   $
��Left=�5      5       �� 5!      -   5        $ ��AutomaticallyStartCheckBox��5!   �   $��2��6   $��1��6'   $��Center=�6u   $��Center=�6�   6�   �� 5$      -   5        $��AutomaticallyAcceptLabel��5%   /   $��0��5$      $��2��6$   $��2��61   $��Automatically Accept��6E   $��Center=�6d   $
��Left=�5%      5&      �� 5'      -   5        $!��AutomaticallyAcceptCheckBox��5'   �   $��2��6   $��2��6'   $��Center=�6v   $��Center=�6�   6�   �� 5*      -   5        $��ShowSelfViewLabel��5+   /   $��0��5*      $��3��6$   $��2��61   $��Show Self View��6E   $��Center=�6^   $
��Left=�5+      5,      �� 5-      -   5        $��ShowSelfViewCheckBox��5-   �   $��2��6   $��3��6'   $��Center=�6h   $��Center=�6�   6�   �� 50      -   5        $��PreferredFPSLabels��51   /   $��0��50      $��4��6$   $��Preferred FPS��61   $��Center=�6I   $
��Left=�51      52      �� 53      -   5        $��PreferredFPSTextBox��54   z   $��1��53      $��4��6&   $��2��63   $��Stretch=�6G   $��23��54      $��0,0,0,0q�6"    �� TextWrapping$
 Wrap=�63   $�� ��6G   $	��Top=�6P   
����  �6�   �� 56      -	   5        $��VideoPresetLabel��57   /   $��0��56      $��4��6$   $��Video Preset��61   $��Center=�6H   $
��Left=�57      $y�	Collapsed=�6G   58      �� 59      -
   5         ��Name$ VideoPresetComboBox��59   I   $��4��6   $��1��6%   $��2��65   $��14(�6f   $��0,3,0,3q�6t   $	��120��6�   $��24��6�   $��Center=�5:      $
��Left=�63   $y�	Collapsed=�6o   .@�5;      �� 	default6&   �� 5<      
high-fps6'   5=      �� 5?      -   5        $��RtcpFeedbackLabel��5@   /   $��0��5?      $��5��6$   $��RTCP Feedback��61   $��Center=�6I   $
��Left=�5@      5A      �� 5B      -   5        $ RtcpFeedbackComboBox��5B   I   $��5��6   $��1��6%   $��2��65   $��14(�6g   $��0,3,0,3q�6u   $	��120��6�   $��24��6�   $��Center=�5C      $
��Left=�63   .@�5D      �� Off6"   �� 5E      
Explicit6'   �� 5F      
Implicit6'   5G      �� 5J      $��0��6   $��6��6$   $��3��61   $��Video Codecs��6F   $��Center=�6]   
�������5K      �� 5M      -   5         ��Name$ VideoCodecsListView��5N      #��[  5M      $��0��6G   $��7��6W   $��3��6d   $	��200��6x   $	��280��6�   $
��Left=�6�    �� SelectionMode$ Single=�5N   4    �� View 5O      �� 5P      .P�5Q      �� $
��Name��6)    �� Width$ 95��67    �� DisplayMemberBinding 6B   �� 	 �� Path$	 	CodecName��� 5R      $��	Rate (Hz)��6)   $ 70��6<    6G   �� $
	 Rate��� 5S      $��Channels��6)   $ 70��6;    6F   �� $	 Channels��� 5T      $��Status��6)   $ 45��69   
 �� CellTemplate
 5U      �� 5V   "   .R�5W   &   �� $��50��61   .+�5X   *   �� -   5        $��Center=�5Z   3   $��Center=�6N    d� 	IsChecked 5X   3   �� $	 Status� �� Mode$ TwoWay=�5Z   N   5[   '   5\   #   5^      5_      5a      5d      5e      5f      