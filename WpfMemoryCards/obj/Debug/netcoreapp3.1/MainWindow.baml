   M S B A M L   `   `   `  ����I  EWpfMemoryCards, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfMemoryCardsWpfMemoryCards  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	       WpfMemoryCards.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfMemoryCards     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	   -   5          � Title$  
MainWindow��5   	   $
��15cm��6   $
��25cm��6*    � 	Resources 5      (   "WpfMemoryCards.PercentageConverter   PercentageConverter��%   &	          5   
   6$   5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��Cards��6   $��0��6"   $��0��62   $��5��6?   $��0.2cmq�6P   .��5      �  5      �� 5      6)   �� 5       6)   �� 5!      6)   �� 5"      6)    5$      �� 5%      $��5* �6$   62   �� 5&      $��1* �6$   62   .+�5(      �� -   5        $��CardsListView��5(      $��0��60   $��0��6@   $��4��6M    �� View 5)      �� 5*      .P�5+      ��  �� DisplayMemberBinding 6-   ��  �� Path$ Id�.��6V   Id6Z   �� 5,       6-   �� $	 Tag�.��6W   Tag6\   �� 5-       6-   �� $ Text1�.��6Y   
Question6c   5.      50      �� 51      -   5         ��Name$ 
PlusBorder��51      $��0��6-   $��1��6=   ._�52      �� -   5        $��PlusCardButton��52      
����� ���53      ��  �� 	Converter# [  	 �� ElementName$	 
PlusBorder��$ ActualWidth�
 �� ConverterParameter$	
 0.1��.��55      �� $X��RC:\Users\USeR-050716\Documents\Visual Studio 2019\Projects\WpfMemoryCards\plus.png��6    6~   56      57      �� 58      -   5        $ MinusBorder��58      $��1��6.   $��1��6>   ._�59      �� -   5        $��MinusCardButton��59      
��������5:      �� # [  $	 MinusBorder��$ ActualWidth�$	
 0.1��.��5<      �� $��Center=�6    $Y��SC:\Users\USeR-050716\Documents\Visual Studio 2019\Projects\WpfMemoryCards\minus.png��6;   6�   5=      5>      �� 5?      -   5        $ 
EditBorder��5?      $��2��6-   $��1��6=   ._�5@      �� -   5        $��EditCardButton��5@      
��� �����5A      �� # [  $	 
EditBorder��$ ActualWidth�$	
 0.1��.��5C      �� $��Bottom=�6    $X��RC:\Users\USeR-050716\Documents\Visual Studio 2019\Projects\WpfMemoryCards\edit.png��6;   6�   5D      5E      5F      5G      �� 5H   
   -	   5        $��NullTagCheckBox��5H      $��1��6*   $��0��6:   $��Center=�6G   $��0.2cmq�6b    d� 	IsChecked$ FalseY�6�   .��6�   Tag is null6�   5I      5J      