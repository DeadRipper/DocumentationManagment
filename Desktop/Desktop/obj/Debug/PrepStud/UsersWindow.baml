   M S B A M L   `   `   `  ����  Desktop    Desktop.UsersWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   $	��450��5   	   $	��800��6   .��5      � $��0,0,0,-1q�6   $
��Left=�6   $
��1187��68   .+�5   
   � $	��Top=�5      $	��310��5	      $��
0,0,-668,0q�6    .+�5      &   System.Windows.Controls.DataGrid  -   5        $��dataGridCustomers��5          AutoGenerateColumns  .  $
��Left=�5      $��
10,55,0,46q�5      $	��624��5         CanUserResizeRows .  ��5      �� *LoadDataBinding+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ User #��5   )      Width5  /System.Windows.Controls.DataGridLengthConverter$ 75 5   )      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   )   ��  �� Path$ UserID�5   )     5      $ First��5   )   $	 100 5   )    .  5   )   �� $ 	firstname�5   )     5      $ Middle��5   )   $	 100 5   )    .  5   )   �� $ 
middlename�5    )     5!      $
 last��5"   )   $	 100 5#   )    .  5!   )   �� $ lastname�5$   )     5%      $ Email��5&   )   $	 150 5'   )    .  5%   )   �� $ email�5(   )     5)      $ Phone��5*   )   $	 100 5+   )    .  5)   )   �� $ phonenumber�5,   )   5.      �� 50      -   5        $��btnLoadDataGrid��51      $��Load Data Grid��50      $��25��52      $
��Left=�53      $��
244,25,0,0q�54      $	��Top=�55      $	��100��56      6!   57      58      59      