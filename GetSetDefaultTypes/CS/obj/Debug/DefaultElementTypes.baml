   M S B A M L   `   `   `  ����  GetSetDefaultTypesA    ;Revit.SDK.Samples.GetSetDefaultTypes.CS.DefaultElementTypes   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � 
�������  � ColumnDefinitions  5	   
   �� 5
      $	��39* �6   �� 5      $
��261* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $#��_dataGrid_DefaultElementTypes��5   
      AutoGenerateColumns .  $��Stretch=�5   
   $��12q�5   
   $��2��5   /      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Element Type Group��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6A      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6N   ��  �� Path$ ElementTypeGroupName�6|   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Element Types��6)   $
 Auto 6A    .    CellTemplate 5      �� 5      .R�5      �� -   5        	 �� SelectedValue	 5   '   �� $ DefaultElementType���5   %   �� $" DefaultElementTypeCandidates�5       5      5      5      5       5!      