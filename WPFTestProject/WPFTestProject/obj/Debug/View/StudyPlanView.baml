   M S B A M L   `   `   `  ����I  EWPFTestProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WPFTestProject.ConverterWPFTestProject.Converter  5      R NWPFTestProject.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullbFclr-namespace:WPFTestProject.Controls;assembly=WPFTestProject.ControlsWPFTestProject.Controls 5      9!clr-namespace:WPFTestProject.ViewWPFTestProject.View  5      '    !WPFTestProject.View.StudyPlanView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <	converter&clr-namespace:WPFTestProject.Converter     5      UssFclr-namespace:WPFTestProject.Controls;assembly=WPFTestProject.Controls     5      3local!clr-namespace:WPFTestProject.View     5        � 	Resources  5      8   2WPFTestProject.Converter.DateTimeToStringConverter   dateTimeToStringConverter3   -WPFTestProject.Converter.BoolToColorConverter  boolToColorConverter  categrayRadioTemplate �� 
TargetType ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName	 �� Property
 �� Value�� 5   
   %  &	        &	      &	 &       5      62     5      6-   �� 5      " 	�6<   .R�5      �� $ 	RadioBack��6�   $	��5,0q�6   $ 5��6&   ���#EEE$��Center=�6I   $��Center=�6d   ._�5      �� $ 	RadioText��6�   #��z��6%   
���   �$��Center=�6\   $��Center=�6w   $
��10,4q�6�   $��12(�6�   6�   5       5      P� 5       �@d�	IsChecked$
 TrueY�63   . �5      �� $ 	RadioBack��6F   	 � ��

 � ����� 5      $ 	RadioText��6E   	 � ��

 �����5      5      5      .��5      �� 
�������$ 5��6     J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$
 Gray��6      ShadowDepth$ 10Q�6,      
BlurRadius$	 105Q�6=      Opacity$	 0.3Q�6N      	Direction$	 270Q�6\   ._�5!   
   �  � RowDefinitions 5"      �� 5#      $
��auto �6    �� 5$      .+�5&      ��  �� Orientation$ Vertical=�6   $��10,20q�60   .+�5'      �� $ 
Horizontal=�6   $��5q�66   .+�5(      �� $��课程分类��6    $��Center=�6,   $��12(�6G   $
��10,4q�6U   �� 5)      ��6#   �� *CategoryList1+��5*      �� 5+      .R�5,   "   �� $ 
Horizontal=�6-   5-      ��5/      �� 50      .R�51   "   	� #��[ 6G    	� 	GroupName$ type1��6y   ��6.   �� *Name+6y   52      54      55      �� 56      $ 
Horizontal=�6   $��5q�66   .+�57      �� $��技术分类��6    $��Center=�6,   $��12(�6G   $
��10,4q�6U   �� 58      ��6#   �� *TechnologyList+��59      �� 5:      .R�5;   "   �� $ 
Horizontal=�6-   5<      ��5>      �� 5?      .R�5@   "   	� #��[ 6�   $ type2��6  ��6.   �� *DataContext.FilterTechnology+ �� RelativeSource ��  �� AncestorType$ UserControlL� �� Mode$ FindAncestor=���6�   �� *Id+��6�   �� *
TechName+6  5A      5C      5D      �� 5E      $��30��6   $��40��6%   $ 10��60   ���#007DFA$��1q�6X   ���	#FF00A2FF$��Center=�6�   $��Right=�6�   $��0,0,35,0q�6�   ._�5F      �� ��6   �� *DataContext.CreateTask+ �� $ UserControlL�$ FindAncestor=���5G      �� 5H      .R�5I   "   �� 
�������$��新增��6A   $��Center=�6K   $��Center=�6f   6�   5J      5L      5N      5`      �� 5a      ���#DDD$��0,0,0,1q�6(   � 5b      $��1��6   $��10q�6    .+�5c      �� $��Hidden=�6   .��5d      �� $ Vertical=�6!   .+�5e      �� ��6'   �� *CourseFilterList+ �� UpdateSourceTrigger$ PropertyChanged=���5f      �� 5g   "   .R�5h   &   $� 5i   #   ��5k      �� 5l   "   .R�5m   &   � .+�5n   *   �� $ itemContent��6l   $��0,0,0,1q�61   ���#EEE$
��30,5q�6^   ._�5o   .   � $��80��63    5p   2   �� 5q   6   $��35 �6D   �� 5r   6   $��25 �6D   �� 5s   6   $��20 �6D    � ColumnDefinitions 5u   2   �� 5v   6   $	��140 �6G   �� 5w   6   �� 5x   6   $��60 �6G   .+�5z   2   �� $��3��68   $	��0,3q�6f   $
��Fill=�6s   ��6I   �� *	CoverLink+6s   �� 5{   2   $��1��6=   $ 
Horizontal=�6M   $
��10,0q�6f   $��Center=�6t   .+�5|   6   �� $��Bottom=�6V   $��16(�6q   ��6@   �� *Name+6q   �� 5~   6   $��Right=�6=   $��10��6Y   $��10��6e   $��10,0,0,0q�6p   $ 5��6�   ��6�   �� *
IsFinished+ �� 	Converter# [ 5   3   �� 5�   2   $��1��6=   $��1��6M   $ 
Horizontal=�6Z   $
��10,0q�6s   .+�5�   6   �� $��60��6=   $
��auto��6H   $ 4��6V   $��0q�6h   
��� � �._�5�   :   �� $��Center=�6D   $��Center=�6a   �� 5�   >    �� Command 6H   �� *DataContext.OpenCourseUrl+ �� $ UserControlL�$ FindAncestor=� �� CommandParameter 6�   �� *Link+.�6�   ��5�   B   �� 5�   F   .�5�   J   �� 	 � ��
 6v   Z� 5�   G   .�5�   S   .�5�   B   �� $��资料��6L   $��12(�6V   
�������$��Center=�6w   $��Center=�6�   5�   ?   5�   ;   5�   7   5�   3   �� 5�   2   $��2��69   $��1��6I   $��Right=�6�   ��6V   �� *DataContext.CourseFinish+ �� $ UserControlL�$ FindAncestor=���6�   �� *Id+��5�   6   �� 5�   :   .R�5�   >   �� ���#007DFA$��60��6[   ._�5�   B   �� 
�������$��Center=�6e   $��Center=�6�   $��完成��6�   5�   ?   5�   ;   5�   3   �� 5�   2   $��2��6<   $��1��6I   $��Center=�6t   $
��10,0q�6�   ��6Y   �� *	Introduce+6�   5�   /   5�   +   ,  &WPFTestProject.Controls.SkeletonScreen  5�   *     Name$ skeleton��6<   5�   '    �� Triggers 5�   &   �� 5�   *    �� Value$
 True��6Y    �� Binding 66   �� *IsShowSkeleton+.a�5�   .   �� $ skeleton��6[   	 � y�$
 Visible=�6K   6[   �� 5�   .   $ itemContent��6]   	 � y�$
 	Collapsed=�6K   6]   5�   +   �� 5�   *   $ False��6Y    66   �� *IsShowSkeleton+.a�5�   .   �� $ skeleton��6]   	 � y�$
 	Collapsed=�6K   6]   �� 5�   .   $ itemContent��6[   	 � y�$
 Visible=�6K   6[   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      