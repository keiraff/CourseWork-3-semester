   M S B A M L   `   `   `  ����E  ACourseWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:CourseWork
CourseWork  5   	   =#clr-namespace:CourseWork.ViewModelsCourseWork.ViewModels  5   	   M+clr-namespace:CourseWork.ViewModels.ContentCourseWork.ViewModels.Content  5   	   3clr-namespace:CourseWork.ViewsCourseWork.Views  5	   	       CourseWork.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:CourseWork     5   	   2vm#clr-namespace:CourseWork.ViewModels     5   	   ;vmc+clr-namespace:CourseWork.ViewModels.Content     5   	   ,vclr-namespace:CourseWork.Views     5	   	   $	��450��5       $	��800��6-     � WindowState$  	Maximized=�69    � Title 6	   �� *Temp+.��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��2* �6   5      �� 5      $��7* �6   5       � RowDefinitions 5   
   �� 5      $	��42* �6   5      �� 5      $
��309* �6   5      �� 5      $	��53* �6   5      �� 5      $	��15* �6   6+   .+�5   
   �� $��0��6    �� Orientation$ Vertical=�6"   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��30��6   $��30��6(   $U��OC:\Users\diana\source\repos\CourseWork\CourseWork\CourseWork\Images\search6.png��66   �� 5      $��25��5       $��45��6)   
�������$��16(�6O   $	��800��6]   ��5      ��  �� Path$ SynchronizedText� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWayToSource=�5    ]   5!      �� 5"      
�������$ ��Список тестов:��63   $��20(�6I   $��Oblique$�6W   $��50��6l   5#      �� 5$   
   $��0��6   $��3��6!   
�������$��1q�6E   �� 5%   
   
�������$��Oblique$�6*   $��1��6?   $	��Top=�6L   ��6e   �� *TestsCollection+$ PropertyChanged=� �� SelectedItem 6�   �� $ SelectedTest��� 5&   
   $��1��6   
�������$��1q�61   � 5'   
   $��2��6    5(      �� 5)      $��1* �6#   60   �� 5*      $��1* �6#   60    5,      �� 5-      $��1* �6    �� 5.      $��1* �6    .+�50      �� $��2��6   $��2��6)   
�������$��1q�6M   �� 51      $��0��6   $��1��6"   $��10,7,2,0q�63   $��Delete��6E   $��Stretch=�6�   $	��200��6�   $��85��6�   $	��Top=�6  ��6V   �� *DeleteCommand+��6x   �� *SelectedTest+$ PropertyChanged=�6  �� 52      $��0��6   $��Select��6"   $��2,7,10,0q�6�   $��Stretch=�6�   $	��Top=�6�   $	��200��6�   $��85��6�   ��63   �� *StartCommand+��6T   �� *SelectedTest+$ PropertyChanged=�6�   �� 53      $��1��6   $��Create��6"   $��5,0,10,7q�6U   $��Stretch=�6g   $��Bottom=�6�   $	��200��6�   $��85��6�   $��2��6�   ��63   �� *CreateCommand+6�   54      � 55   
   $��1��6   $��3��6   .+�56      �� -   5        	 ��Name$	 
OutputView��56      57      58      59      5:      