   M S B A M L   `   `   `  ����P  LWpfAppBuoi10_22082023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfAppBuoi10_22082023WpfAppBuoi10_22082023  5   	   &     WpfAppBuoi10_22082023.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WpfAppBuoi10_22082023     5   	   
�������  � Title$  Starfield in WPF��5	   	   $	��400��6"   $	��600��6/   .��5
      ]� .+�5   
   ]� $	��Top=�6   .+�5      �� $
��Left=�6   .+�5      	� $��	500 stars��6   $��5 7 0 0q�62    d� 	IsChecked$
 TrueY�6C   	� 5      $��100,000 stars��6   $��5 7 0 0q�66   5      �� 5      $��Right=�6   .+�5      �� $��Alpha��6   $��14(�6(   $��0 -5 0 0q�66   �� 5      $��26(�6   $��80��6&   $��	0 -15 0 0q�61    �� ContentStringFormat$ {0:0}%��5      ��5      ��  �� ElementName$ mySlider�� �� Path$ Value�5      5      �� 5      -   5         ��Name$ mySlider��5       � Maximum$	 100Q�6'    � Value$	 100Q�65    �� TickPlacement$ BottomRight=�6A   $��10q�6]   5      �� 5   
   -   5        	 ��Name$	 myCanvas��5      
���� ��$��
10 0 10 10q�6<   .+�5      �� -   5        
 ��Name$
 myImage��5      5      5      5      