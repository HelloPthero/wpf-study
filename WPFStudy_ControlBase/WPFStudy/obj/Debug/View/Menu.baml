   M S B A M L   `   `   `  ����C  ?WPFStudy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFStudy.ViewWPFStudy.View  5   	       WPFStudy.View.Menu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFStudy.View     5   	     � Title$
  Menu��5   	   $	��450��6   $	��800��6#    � 	Resources 5	         routeCommand �� 
TargetType �� Property �� Value��%�   &	        'Q�      �� 5   
   6   �� 5   
   " Q�6   .�5      ��  � ��
 �/���6A   �� 5       � ��$ 13(�6)   66   5      5       J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command# [  5      6i    J� InputBindings 5      �� 5   
    �� Command# [  6   	 �� Gesture$	 Ctrl+C��6=   .��5       � 
 � ColumnDefinitions
 5!   
   �� 5"      �� 5#      �� 5$      .+�5&   
   o� $��0��6   $��30��6   $	��Top=�6+    o� 
IsMainMenu . .@�5'      m� $��基础资料��6   .@�5(      m� $��客户��6   m� 5)      $��部门��6   5+      m� 5,      $��系统管理��6   .@�5-      m� $��用户管理��6   m� 5.      $��角色管理��6   m� 5/      $��权限管理��6   50      m� 51      $��应用中心��6   .@�52      m� -   5         m�Name$ linkContralIntraView��52       m� Command# [  69   $��基础控件��6a    m� InputGestureText$ Ctrl+C��6o   m� 53      -   5        $ linkPanelView��53   )   $��布局控件��6   $ Ctrl+P��6\   m� 54      -   5        $ linkListView��54   )   $��表格控件��6   $ Ctrl+L��6Z   m� 55      $��其他��6    m� Icon 57      �� 58      $��../asset/images/globe.jpg��6    5:      5<      m� 5=      $��BI中心��6   6'   5>      �� 5?   
   -   5         ��Name$	 lbl��5?      $��1��6   $��右键菜单��6-   $
��Left=�6<   $	��Top=�6W   
������� �� 	Placement$	 Top=�5@   P    � ContextMenu 5A      �� 5B      -   5         ��Name$ lblMenu��5B       �� IsOpen .   �� HorizontalOffset$ 10��6>    �� VerticalOffset$ 10��6T    �� HasDropShadow .  .@�5C      m� $��菜单1��6   m� 5D      $��菜单2��6   5E      5G      R� 5H   
   -   5         R�Name$ treeView��5H      $��2��6%   $
��Left=�65   $	��200��6P   
��� ���.@�5L      Q� $��学生管理系统��6    Q� 
IsExpanded . .@�5M      Q� $��系统管理��6    . .@�5N      Q� $��角色管理��6#   Q� 5O      $��用户管理��6#    Q� 
IsSelected . 61   5P      Q� 5Q      $��数据管理��6   .@�5R      Q� $��学生档案��6#   Q� 5S      $��教师档案��6#   5T      5V      5W      5f      5g      