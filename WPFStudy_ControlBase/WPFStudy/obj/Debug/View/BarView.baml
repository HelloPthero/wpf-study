   M S B A M L   `   `   `  ����C  ?WPFStudy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFStudy.ViewWPFStudy.View  5   	       WPFStudy.View.BarView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFStudy.View     5   	     � Title$  BarView��5   	   $	��450��6   $	��800��6&    � 	Resources 5	         setColor��%   &	        �� 5
   
   6   5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [  5      6e   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   c� $��0��6   $	��Top=�6"   $��50��6:   $��0,0,136.8,0q�6F   .@�5      �� $��新建��6   6$   �� 5      �� 5      $��../asset/images/globe.jpg��6   $��40��67   �� 5      �� 5      $��是否保存��6    d� 	IsChecked$
 TrueY�6&   $
��10,0q�67   �� 5      	� 5       � ToolTip$	 Red��6   #��[  6(   ��5      �� 5      $��10��6    $��10��6+   
���  ��67   5       	� 5!      $ Orange��6   #��[  6+   ��5"      �� 5#      $��10��6    $��10��6+   
��� ���67   5%      	� 5&      $ Green��6   #��[  6*   ��5'      �� 5(      $��10��6    $��10��6+   
��� � �67   5*      �� 5+      �� 5,      -   5        $��cbItem��5,      $��修改文本��6)   $��Center=�68   5.      5/      �� 50   
   
�������$��4q�6$   $
��Left=�68   $	��Top=�6S   $��
10 100 0 0q�6k   ._�51      �� -   5         ��Name$	 lbl��51      $��测试文本��6!   $
��Left=�60   $	��100��6K   $	��100��6X   6g   52      `� 54   
    `� Orientation$ 
Horizontal=�6   	 `� IsLocked	 . $��1��6?   $
��Left=�6O   $	��Top=�6j   $��50��6�   .�55      c� 
 c� Band$
 1��6    c� 	BandIndex$ 1��6   .@�56      	� $	 Red��6   #��[  6,   ��57      �� 58      $��10��6$   $��10��6/   
��� ���6;   5:      	� 5;      $	 Red��6   #��[  6,   ��5<      �� 5=      $��10��6$   $��10��6/   
��� � �6;   5?      5@      c� 5A      $
 0��6   $ 1��6   .@�5B      �� $��新增��6   �� 5C      $��修改��6   �� 5D      $��删除��6   5E      5F      �� 5H   
   $��0��6   $��2��6$   $��Bottom=�68   $��30��6S   .@�5I      �� $��当前用户:Pthero��6   64   �� 5J      .��5K      ��  �� Orientation$ 
Horizontal=�6   .+�5L      �� $��当前时间：��6   �� 5M      $��2021-11-30 22:16��6    $��Center=�68   5N      5O      �� 5P      .��5Q      �� $ 
Horizontal=�6   .+�5R      �� $��加载进度:��6   � 5S      -   5        $��progress��5S   "    � Minimum$ 0Q�62    � Maximum$	 100Q�6>    � Value$ 20Q�6L   $	��100��6W    � Triggers 5T      :� 5U       :� RoutedEvent$ ProgressBar.Loaded��6+   .[�5V   "   �� .��5W   &   �� .��5X   *   W�  W� From$ 20X�6:   	 W� To$	 100X�6D    �� 
TargetName$ progress��5Y   :    �� TargetProperty$ Value�5Z   :    g� Duration$ 0:0:5D�5[   :   5\   =   5]   '   5^   #   5_      5a      5b      5c      5d      5e      5f      