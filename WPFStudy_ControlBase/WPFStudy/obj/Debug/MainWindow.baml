   M S B A M L   `   `   `  ����C  ?WPFStudy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPFStudyWPFStudy  5   	       WPFStudy.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPFStudy     5   	   -   5          �Name$  ___无名称_��5   	    � Title$ 	主页面��5   	   $	��450��6   $	��800��6"    � ShowInTaskbar .  � WindowStartupLocation$ CenterScreen=�5	   	    � WindowState$ Normal=�5
   	    � Topmost .   � Icon$ asset/images/globe.jpg��5   	   .��5      � $��0,0,-6.4,-4q�6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��账号��6   $	��Top=�6   $��
100,60,0,0q�65   $
��Left=�6I   �� 5   
   -   5         ��Name$ 	inputText��5      $��25��6%   	 �� TextWrapping$	 NoWrap=�61   $	��120��6H   $
��Left=�6�   $	��Top=�6�   $��
150,60,0,0q�6�   ��6T   �� *Name+
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   �� 5   
   $��密码��6   $
��Left=�6   $	��Top=�68   $��100,100,0,0q�6P   G� 5   
   -   5         G�Name$ inputPassword��5       G� PasswordChar$ *��6-   $��150,100,0,0q�6h   $
��Left=�6}   $	��Top=�6�   $	��120��6�   $��25��6�   ��6>   �� *PasswordErrorColor+6�   �� 5!   
   $	��Top=�6   $��Center=�6)   $��	0,200,0,0q�6F   $��登录��5"      $	��226��6   $��30��6+   
��� ���$��2q�5#   %   ��5"   7   �� *ButtonCommand+��5%      �� 5&       �� ImageSource$ asset/images/globe.jpg��6   5(      �� 5)   
   $��类型��6   $
��Left=�6   $	��Top=�68   $��	10,10,0,0q�6P   6e   	� 5*   
   $��	管理员��6    	� 	GroupName$
 type��6$    d� 	IsChecked$
 TrueY�65   $
��Left=�6F   $	��Top=�6a   $��	10,50,0,0q�6y   6�   	� 5+   
   -   5        $��学生��5+      $
 type��6#   $
��Left=�6N   $	��Top=�6i   $��	10,80,0,0q�6�   6�   	� 5,   
   $��教师��6   $
 type��6#   $
��Left=�64   $	��Top=�6O   $��
10,110,0,0q�6g   6}   �� 5-   
   $��性别��6   $
��Left=�6   $	��Top=�68   $��
10,140,0,0q�6P   6f   	� 5.   
   $	��男��6   $	 sex��6"   $
��Left=�62   $	��Top=�6M   $��
10,170,0,0q�6e   6{   	� 5/   
   $	��女��6   $	 sex��6"   $
��Left=�62   $	��Top=�6M   $��
10,200,0,0q�6e   6{   �� 50   
   $��1��6   
���������6'   �� *
ItemList+52      53      54      