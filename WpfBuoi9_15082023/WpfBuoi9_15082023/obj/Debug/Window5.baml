   M S B A M L   `   `   `  ����L  HWpfBuoi9_15082023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfBuoi9_15082023WpfBuoi9_15082023  5   	       WpfBuoi9_15082023.Window5   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WpfBuoi9_15082023     5   	     � Title$  Window5��5   	   $	��450��6   $	��800��6&   .��5	      ]� $��10q�6   .+�5
   
   � $��	0, 10,0,0q�6   $��Bottom=�6'   $��Center=�6?   .+�5      �� -   5        $��btnSelectNext��5      $	��120��6F   .��6R   Select next6_   �� 5      -   5        $��btnToggleExpansion��5      $	��120��6P   $��10,0,0,0q�6\   .��6o   	Toggle Ex6z   5      R� 5   
   -   5        $��
trvPersons��5      ��5      �� 5       �� ItemsSource 6+   �� *
Children+.R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��/Images/light_red.png��6    $��0,0,5,0q�6@   $��30��6Q   $��30��6\   �� 5      $��0,0,4,0q�6:   ��6$   �� *Name+6:   5      5      ��5      �� 5       �� 
TargetType" Q�6   .�5      ��  �� Property �@Q�
IsSelected �� Value 63   �� *
IsSelected+�� 5       �@Q�
IsExpanded 63   �� *
IsExpanded+5      5      5      5!      