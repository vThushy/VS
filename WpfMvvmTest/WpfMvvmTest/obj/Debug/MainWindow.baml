   M S B A M L   `   `   `  ����F  BWpfMvvmTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfMvvmTest.ViewModelWpfMvvmTest.ViewModel  5   	       WpfMvvmTest.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   2vm#clr-namespace:WpfMvvmTest.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5      ,  &WpfMvvmTest.ViewModel.ProductViewModel   pvModel��%   &	          5   
   6   5      .��5	      � $	��314��6C    � DataContext 6   ��  �� Source# [   � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��ListViewEmployeeDetails��5      $��1��62   $��4,109,12,23q�6?   ��6U   �� *
Products+ �� View 5      �� 5      -   5        grdTest��.P�5      �� $��ID��6%    �� Width$	 100��6V    �� DisplayMemberBinding 61   �� *ID+6V   �� 5      $
��Name��6%   $	 100��6Z    63   �� *Name+6Z   �� 5      $��Price��6%   $	 100��6[    64   �� *Price+6[   5      5      �� 5   
   -   5        $��txtID��5   X   $��1��6   $��23��6   $
��Left=�6+   $��80,7,0,0q�6F   $	��Top=�6e   $	��178��6}   ��6�   ��  �� ElementName$ ListViewEmployeeDetails��	 �� Path$	 SelectedItem.ID��� 5   
   -   5        $��txtName��5   Y   $��1��6   $��23��6   $
��Left=�6+   $��	80,35,0,0q�6F   $	��Top=�6h   $	��178��6�   ��6�   �� $ ListViewEmployeeDetails��$	 SelectedItem.Name��� 5   
   -   5        $��txtPrice��5   Y   $��1��6   $��23��6   $
��Left=�6+   $��	80,61,0,0q�6F   $	��Top=�6i   $	��178��6�   ��6�   �� $ ListViewEmployeeDetails��$	 SelectedItem.Price��� 5   
   -   5        $��label1��5   Z   $��ID��6   $��1��6   $
��Left=�6*   $��12,12,0,274q�6E   6Z   �� 5   
   -   5        $��label2��5   g   $��Price��6   $��1��6    $��28��6-   $
��Left=�69   $��	12,59,0,0q�6T   $	��Top=�6u   �� 5   
   -   5        $��label3��5   f   $
��Name��6   $��1��6   $��28��6,   $
��Left=�68   $��	12,35,0,0q�6S   $	��Top=�6t   �� 5   
   -	   5        $��	btnUpdate��5   j   $��Update��6   $��1��6"   $��23��6/   $
��Left=�6;   $��
310,40,0,0q�6V   $	��Top=�5      $	��141��6)   ��5       �� $	 UpdateCommand�68   5"      5#      