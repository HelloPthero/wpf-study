   M S B A M L   `   `   `  ����I  EWPFTestProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFTestProjectWPFTestProject  5   	   C&clr-namespace:WPFTestProject.ConverterWPFTestProject.Converter  5   	       WPFTestProject.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WPFTestProject     5   	   <	converter&clr-namespace:WPFTestProject.Converter     5   	     � Title$  	主页面��5	   	   $	��800��6   $
��1250��6"   $��Microsoft YaHei)�5
   	   $��
ExtraLight"�6&    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6    � WindowStyle$
 None=�5   	    � AllowsTransparency . ��66   Z�  � 	Resources 5       �� Source �� MergedDictionaries.   (WPFTestProject.Converter.GenderConverter   Key �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName �� Color J� SnapsToDevicePixels � ColumnDefinitions ��Name ��Name  TextBox.MouseOver.Border  TextBox.Focus.Border �� Value �� Binding �� RelativeSource �� Mode g� Duration	 W� To �� 
TargetName �� TargetProperty�� 5   
   $( "../Assets/Styles/DefaultStyle.xaml?�6    5      �� 5        5      genderConverter  60   �� 5      NavButtonStyle  " 	�63   .�5      �� 	 � ��

 �����67   �� 5      	 � ��
 5      �� 5   "   " 	�62   .R�5   &   �� $ navBack��6W   
������ $ 8��6F   ._�5   *   �� #��z��69   $��Center=�6]   $��Center=�6x   $
��20,4q�6�   $��12(�6�   5   +   5   '    5   &   P� 5   *    �@d�	IsChecked$
 TrueY�6G   . �5   .   �� $ navBack��6K   	 � ��
 �	#44FFFFFF6`   5    +   5"   #   5$      5%      �� 5&      TextBox.Static.Border  $ 	#FFABAdB3��6D   �� 5'      TextBox.MouseOver.Border  $ 	#FF7EB4EA��6G   �� 5(      TextBox.Focus.Border  $ 	#FF569DE5��6C   �� 5)      " ��6&   SearchTextBoxTemplate  .R�5*      �� $ border��6!   $ 7��61   $��0q�5+   !   ���	#22000000 . ._�5.      �  5/   "   �� 50   &   $��30 �67   �� 51   &   .+�53   "   �� $��5,0,0,0q�6,   $��Center=�6=   $	����6X   $��../Assets/Fonts/#iconfont)�6h   $��20��6�   
�������6�   �� 54   "   $ 
searchInfo��6<   $��1��6,   $y�	Collapsed=�6P   $��Center=�6g   $��Search for what you like��6�   ���	#44ffffff6�   �� 55   "   $ PART_ContentHost��6g   $��1��6/   $��Center=�6?   $
��auto��6Z   |�.  $��Hidden=�6�   $��Hidden=�6�   56      59       5:      P� 5;       � {� .  . �5<   "   �� $ border��6<   	 �@J�Opacity$

 0.56Q�6P   5=      P� 5>       �@J�IsMouseOver . . �5?   "   �� $ border��6@   #
 [ 6T   	 � ��5@      P� 5A       �@J�IsKeyboardFocused . . �5B   "   �� $ border��6@   #
 [ 6T   	 � ��5C      �� 5D      $  ��6m    6*   �� *Text+ �� $
 Self=�.a�5E   "   �� $ 
searchInfo��6O   	 � y�$
 Visible=�6?   6O   5F      5H      �� 5K      UserInfoRightSide  .��5L      W� $ 0:0:0.2D�6*   $ 0X�6=   $ 	rightSide��5M   *   $ X�5N   *   5O      �� 5P      UserInfoRightSideClose  .��5Q      W� $ 0:0:0.2D�6*   $	 245X�6=   $ 	rightSide��5R   *   $ X�5S   *   5T      �� 5W      " 	�6&   GenderRadioButtonTemplate  .R�5X      �  5Y      �� 5Z   "   �� 5[   "   .+�5]      �� $��14��6%   $��14��60   $ 7��6<   $��1q�6M   ���#007DFA
�������._�5^   "   �� $ radioDot��6)   $y�	Collapsed=�6;   $��6��6R   $��6��6\   $ 3��6g   ���#007DFA6x   5_      �� 5`      $��1��6-   $��5,0,0,5q�6=   $��Center=�6N   #��z��6i   5a       5b      P� 5c       �@d�	IsChecked$
 TrueY�6;   . �5d   "   �� $ radioDot��6O   	 � y�$
 Visible=�6?   6O   5e      5g      5h      %    5j       � Triggers 5l      :� 5m   
     :� RoutedEvent$  Button.Click��6   ! :� 
SourceName$! btnUserInfo��62   .[�5n      ��   UserInfoRightSide#��[ 6   5o      :� 5p   
   $  Button.Click��6   $! btnUserInfoClose��62   .[�5q      ��   UserInfoRightSideClose#��[ 6   5r      .��5t      �� $��5q�6   
�������$ 10��6+   " J� Effect" 5u   
   3  -System.Windows.Media.Effects.DropShadowEffect  5v      #   Color$
# Gray��6   $   ShadowDepth$$ 0Q�6,   %   
BlurRadius$% 5Q�6<   &   Opacity$	& 0.3Q�6K   '   	Direction$' 0Q�6Y   ._�5x   
   � .+�5y      �� -   5        ���#007DFA$	��200��5y   *   $	��Top=�67   $ 	10,10,0,0��6O   6h   �� 5z      ( �� Orientation$( 
Horizontal=�6   $	��Top=�62   $��Right=�6J   .+�5{      �� -   5          WindowControlButtonStyle#��[ 5{      $
��;��6K   6_   �� 5|      -   5        #��[ 5|      $	����6K   6^   �� 5}      -   5        #��[ 5}      $	����6K   6^   �� 5~      -   5        #��[ 5~      $	����6K   6^   5      � 5�      $��50,30q�6   ) � RowDefinitions) 5�      �� 5�      $��65 �6$   �� 5�      $��35 �6$   �� 5�      .+�5�      �� $( 
Horizontal=�6   $
��Left=�66   $��Center=�6Q   .+�5�      �� $��../Assets/Images/logo.jpg��6   $��40��6?   $��30��6J   �� 5�      $��10q�6!   $( Vertical=�6-   $
��Left=�6D   .+�5�      �� $��个人计划管理系统��6$   
�������64   �� 5�      $��	Hello WPF��6$   ���	#88DDDDDD$��10(�6M   5�      5�      �� 5�      $( 
Horizontal=�6   $��Right=�66   $��Center=�6R   .+�5�      �� $��30��6   $��30��6(   $ 15��64   ��5�      �� 5�      * �� ImageSource* 6)   �� *UserInfo.Avatar+5�      �� 5�      -   5        + ��Name$+ btnUserInfo��5�      
�������$��Center=�6k   $��10,0,0,0q�6�   , � Cursor$
, Hand��6�   ��62   �� *UserInfo.UserName+��5�      �� 5�      " ��6.   .R�5�   "   �� #��z��6,   5�      5�      5�      �� 5�      $��1��6   $( 
Horizontal=�6*   $
��Left=�6C   $��Center=�6^   .+�5�      	� $��首页��6"   $��FirstPageView��6T     NavButtonStyle#��[ 6v   - d� 	IsChecked$
- TrueY�6�   ��6/   �� *NavChangeCommand+6�   	� 5�      $��学习计划��6"   $��StudyPlanView��6W   #��[ 6x   ��62   �� *NavChangeCommand+6x   	� 5�      $��兴趣培养��6"   #��[ 61   $��WaterfallView��6~   ��6Y   �� *NavChangeCommand+6~   	� 5�      $��经济预算��6"   #��[ 61   5�      �� 5�      $��1��6   $��Right=�6'   $��Center=�6C   $	��200��5�      $��30��6'   
�������  SearchTextBoxTemplate#���  6F   ��6y   �� *
SearchText+6�   �� 5�      $��2��6!   ��6.   �� *MainContent+5�      �� 5�      ���	#EE444444$	��240��6,   $��Right=�68   $ 0,5,5,0��6T   z�5�      T� 5�      -   5        	rightSide��. T� X$	. 245Q�5�   <   5�      ._�5�      � ) 5�      �� 5�      $	��230 �6(   �� 5�      .+�5�      �� -   5        $+ btnUserInfoClose��5�      #��[ 67   
���  ��$	��Top=�6{   $
��Left=�6�   $	����6�   �� 5�      $��80��6   $��80��6(   $��Center=�64   $ 40��6Q   $��Center=�6c   ��5�      �� 5�      * 6)   �� *UserInfo.Avatar+5�      � 5�      $��1��6   $
��30,0q�6(    5�      ��%�   '	�       '�� n     �� 5�      " 	�6$   .�5�   "   �� 	 � ��

 �����6?   �� 5�   "   	 � ��$
 14(�6=   5�      �� 5�      " ��6$   .�5�   "   �� 	 � ��

 �����6?   �� 5�   "   	 � ��$
 14(�6=   5�      5�      ) 5�      �� 5�      $��40 �6,   �� 5�      $��40 �6,   .+�5�      �� $( 
Horizontal=�6%   $��Center=�6>   .+�5�      �� $��	用户名��6(   �� 5�      $��20,0,0,0q�6K   ��6(   �� *UserInfo.UserName+6K   5�      �� 5�      $��1��6%   $( 
Horizontal=�62   $��Center=�6K   .+�5�      �� $��性  别��6(   	� 5�      $��20,0,0,0q�6*   $	��男��6<     GenderRadioButtonTemplate#��[ 6H   - 6~   �� *UserInfo.Gender+ 	 genderConverter/ �� 	Converter#/ [	 0 �� ConverterParameter$0 1��	� 5�      $��10,0,0,0q�6*   $	��女��6<   #��[ 6H   - 6~   �� *UserInfo.Gender+#/ [	 $0 2��5�      5�      5�      5�      5�      5�      5�      