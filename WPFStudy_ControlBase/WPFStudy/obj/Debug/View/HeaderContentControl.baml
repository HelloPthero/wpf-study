   M S B A M L   `   `   `  ����C  ?WPFStudy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFStudy.ViewWPFStudy.View  5   	   (    "WPFStudy.View.HeaderContentControl   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFStudy.View     5   	     � Title$  HeaderContentControl��5   	   $	��450��6&   $	��800��63   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      .+�5   
   �� $��0��6   $��分组控件��6#   $	��200��61   $	��200��6=   
���  ��$��2q�6\   .��5      �� $ ��这是一个GroupBox控件��6   6/   5      9� 5   
   -   5        $��1��5      $	��200��6#   $	��200��6/   $��可折叠控件��6<   
���  ��$��2q�6]    9� 
IsExpanded . $��10q�5       9� ExpandDirection$
 Down=�6    .��5      �� $ ��这是一个Expander控件��6   6/   5      �� 5   
   -   5         ��Name$	 tab��5      $��2��6"    �� TabStripPlacement$	 Top=�62   .@�5      �� $��用户信息��6   .��5      ��  �� Orientation$ Vertical=�6   .+�5      �  � Orientation$ 
Horizontal=�6     � 	ItemWidth$ 70��69   .+�5      �� .��6    	用户名6%   �� 5      .��6    	手机号6%   �� 5      .��6    住址6$   5      � 5       $ 
Horizontal=�6    $ 70��69   .+�5!      �� .��6    Pthero6(   �� 5"      .��6    178587677576-   �� 5#      .��6    浙江省湖州市6(   5$      5%      5&      �� 5'      $��角色信息��6   	 �� 
IsSelected	 . .��5(      �� $ Vertical=�6   .+�5)      � $ 
Horizontal=�6    $ 70��69   .+�5*      �� .��6    	角色名6%   �� 5+      .��6    组织6$   �� 5,      .��6    级别6$   5-      � 5.      $ 
Horizontal=�6    $ 70��69   .+�5/      �� .��6    	管理员6%   �� 50      .��6    创源软件6&   �� 51      .��6    	第一级6%   52      53      54      �� 55      $��权限设置��6   6&   56      �� 57   
   -   5        
 ��Name$
 	tabButton��57      $��2��6$   $��Bottom=�64   $��40��6O   $	��140��6[   $��获取TabControl信息��6g   6�   58      59      