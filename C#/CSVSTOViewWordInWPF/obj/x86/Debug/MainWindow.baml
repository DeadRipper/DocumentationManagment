   M S B A M L   `   `   `  ����  CSVSTOViewWordInWPF$    CSVSTOViewWordInWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Documentation��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ 	Maximized=�5   	   ��5       �� *&$SystemParameters.PrimaryScreenHeight+��5   	   �� *%#SystemParameters.PrimaryScreenWidth+.��5      �  � RowDefinitions 5	   
   �� 5
      $��70 �6   6*   �� 5      6   .+�5   
   �� -   5        $��lable1��5      $��3,6,0,0q�6   $��Word Document :��6/   $	��Top=�6I   $
��Left=�6a   �� 5   
   -   5        $��txbSelectedWordFile��5      $	��Top=�6.   $��Stretch=�6G   $��110,10,300,0q�6e   $
��Left=�6{   �� 5   
   -   5        $��btnSelectWord��5   l   $��Right=�6   $	��Top=�6-   $	��150��6E   $��Select Word File��6Q   $��
0,10,130,0q�6�   6�   �� 5   
   -   5        $��
btnViewDoc��5   z   $
��Left=�6   $��3,40,0,0q�6,   $	��Top=�6>   $��View Word Doc��6V   $	��100��6n   6�   Z� 5   
   -   5        $��documentviewWord��5   &   $��1��6   $	��Top=�6>   $
��Left=�6V   �� 5   
   -   5         ��Name$ create��5      $��Create document��6!   $
��Left=�6;   $��
412,45,0,0q�6V   $	��Top=�6j   $	��150��6�   6�   5      5      