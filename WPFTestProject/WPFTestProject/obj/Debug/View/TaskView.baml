   M S B A M L   `   `   `  ����I  EWPFTestProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPFTestProject.ViewWPFTestProject.View  5   	   "    WPFTestProject.View.TaskView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPFTestProject.View     5   	     � Title$
  Task��5   	   $	��300��6   $	��300��6#   $��Microsoft YaHei)�5	   	   $��
ExtraLight"�6&    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�6    � WindowStyle$
 None=�5   	    � AllowsTransparency . ��66   Z� .��5      �� ���	#FFE26969 �� Orientation$ Vertical=�6(   .+�5   
   �� $ Vertical=�6   $��Center=�6,   $	��200��6I   $��	0,50,0,10q�6U   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��60��6   $��名称��6'   $��5q�61   6>   �� 5      $	��120��6   $��1q�6&   ���	#EED3CBCB �� CornerRadius$ 2��6R   $��10,5,5,5q�6c   ._�5      �� -   5         ��Name$ taskName��5      $��0q�6K   ��60   �� *	Task.Name+6K   5      5      5      �� 5   
   $ Vertical=�6   $��Center=�6,   $	��200��6I   $
��0,10q�6U   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��60��6   $��介绍��6'   $��5q�61   6>   �� 5      $	��120��6   $��1q�6&   ���	#EED3CBCB$ 2��6R   $��10,5,5,5q�6c   ._�5      �� -   5        $ 	introduce��5      $��0q�6Q   ��61   �� *Task.Introduce+6Q   5      5      5      �� 5   
   $ Vertical=�6   $��Center=�6,   $	��200��6I   $
��0,10q�6U   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��60��6   $��链接��6'   $��5q�61   6>   �� 5       $	��120��6   $��1q�6&   ���	#EED3CBCB$ 2��6R   $��10,5,5,5q�6c   ._�5!      �� -   5        $
 link��5!      $��0q�6G   ��6,   �� *	Task.Link+6G   5"      5#      5$      �� 5%   
   $ Vertical=�6   $��Center=�6,   $	��200��6I   $
��0,10q�6U   .+�5&      �� $ 
Horizontal=�6   .+�5'      �� $��60��6   $��技术类型��6'   $��5q�63   6@   �� 5(      -   5         ��Name$ combobox��5(      $	��Top=�6-   $
��Left=�6E   $	��120��6`   	 �� IsDropDownOpen	 . 
 �� SelectedValuePath$
 Id��5)   (    �� DisplayMemberPath$ TechName��6?    �� SelectedValue 5(   l   �� *Task.TechType+��5)   \   �� *CategoryList+5*      5+      5,      �� 5-   
   $	��100��6   ._�5.      �� $��创建��6   $	��100��6"   ��5/      �� *CreateTaskCommand+��50      ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" ���52      �� 53      .R�54      � 
��� � �.+�55      �� 
�������$��Center=�6�   $��Center=�6�   ��6@   �� *	Content+ �� $ FindAncestor=�$ ButtonL�6�   56      58      5:      5;      5=      5>      