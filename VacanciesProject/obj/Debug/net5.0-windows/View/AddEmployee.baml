   M S B A M L   `   `   `  ����K  GVacanciesProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:VacanciesProject.ViewVacanciesProject.View  5   	   '    !VacanciesProject.View.AddEmployee   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:VacanciesProject.View     5   	   -   5          �Name$  addEmployeeWindow��5   	    � Title$ AddEmployee��5	   	   $	��250��6   $	��400��6*   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��0.3* �6   6.   �� 5      $
��0.7* �6   6.    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��First Name:��6   $��20(�6&   $��0��64   6C   �� 5   
   $��
Last Name:��6   $��20(�6%   $��1��63   6B   �� 5   
   $��Birth Date:��6   $��20(�6&   $��2��64   6C   �� 5   
   $��	Position:��6   $��20(�6$   $��3��62   6A   �� 5   
   -   5         ��Name$ fNameTextBox��5      $��1��6(   $��0��68   $��5q�6E   $��18(�6P    � DataContext 6^   �� *NewEmployee+��6�   �� *	FirstName+ �� Mode$ OneWayToSource=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $ lNameTextBox��5      $��1��6(   $��1��68   $��5q�6E   $��18(�6P    6^   �� *NewEmployee+��6�   �� *
LastName+$ OneWayToSource=�$ PropertyChanged=�6�   �� 5   
   -   5        $ birthDateTextBox��5      $��1��6,   $��2��6<   $��5q�6I   $��18(�6T    6b   �� *NewEmployee+��6�   �� *	BirthDate+$ OneWayToSource=�$ 	LostFocus=�.��6�   6�   �� 5    
   -   5         ��Name$ positionComboBox��5       $��1��6O   $��3��6_   $��5q�6l   $��18(�6w   ��6-   �� *	Positions+	 �� SelectedItem	 6�   �� *NewEmployee.Position+$ OneWayToSource=�$ PropertyChanged=�6�   �� 5"   
   -   5        
 ��Name$
 cancelButton��5"      $��4��6'   $��5q�64   $��Cancel��6?   $��18(�6P   $��1��6^   ��6r   �� *CancelCommand+��6�   ��  �� ElementName$ addEmployeeWindow��6�   �� 5#   
   -   5        $
 	addButton��5#      $��4��6$   $��1��61   $��5q�6A   $	��Add��6L   $��18(�6Z   ��6h   �� *
AddCommand+6�   5$      5%      