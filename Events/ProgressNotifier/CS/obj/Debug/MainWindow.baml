   M S B A M L   `   `   `  ����  ProgressNotifier6    0Revit.SDK.Samples.ProgressNotifier.CS.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��370��6   $	��650��6)   .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5	      $��30 �6   6*   �� 5
      $	��150 �6   6+   �� 5      $��30 �6   6*   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� -   5        $��button_Open��5      $��0��6$   $��0��61   .��6[   Open Document6j   �� 5   
   -   5        $��label_FileName��5      $��0��6'   $��1��64   .��6E   
FileName6O   �� 5   
   -   5        $��button_Cancel��5      $��1��6&   $��0��63   .��6_   Cancel6g   �� 5   
   -   5        $��label_ProgressStack��5      $��2��6+   $��0��68   .��6H   Progress Information Stack6d   �� 5   
   -   5        $��stackPanel_ProgressData��5      $��3��64   $��0��6A   $��2��6Q   6g   �� 5   
   -   5        $��	label_log��5      $��4��6!   $��0��6.   $	��Log��6>   6N   �� 5   
   -   5        $��textBox_log��5      $��5��6%   $��0��62   $��2��6B   " �� VerticalScrollBarVisibility$ Visible=�6V   6~   5      5      