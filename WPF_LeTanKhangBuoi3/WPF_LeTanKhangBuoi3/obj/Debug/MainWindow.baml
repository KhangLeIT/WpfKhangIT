   M S B A M L   `   `   `  ����N  JWPF_LeTanKhangBuoi3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPF_LeTanKhangBuoi3WPF_LeTanKhangBuoi3  5   	   $    WPF_LeTanKhangBuoi3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPF_LeTanKhangBuoi3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5        $��label1��5
   J   $��30��6   $
��Left=�6   $��	10,15,0,0q�67   $	��Top=�6X   $��60��6p   .��6{   Họ đệm:6�   �� 5   
   -   5        $��label2��5   J   $��30��6   $
��Left=�6   $��	10,50,0,0q�67   $	��Top=�6X   $��60��6p   .��6{   Tên:6�   �� 5   
   -   5        $��textBox1��5   2   $��30��6   $��
80,17,30,0q�6   $	��Top=�6B   �� 5   
   -   5        $��textBox2��5   2   $��30��6   $��
80,52,30,0q�6   $	��Top=�6B   �� 5   
   -   5        $��button1��5   K   $��35��6   $
��Left=�6   $��	16,0,0,27q�68   $��Bottom=�6Z   $	��110��6u   .��6�   Xem thông tin6�   �� 5   
   -   5        $��button2��5   L   $��35��6   $��Right=�6   $��	0,0,24,27q�69   $��Bottom=�6[   $	��110��6v   .��6�   Nhập lại6�   �� 5   
   -   5        $��label3��5   J   $��30��6   $
��Left=�6   $��	10,94,0,0q�67   $	��Top=�6X   $��60��6p   .��6{   Giới tính:6�   	� 5   
   -   5        $��radioButton1��5   5   $��22��6   $��	80,99,0,0q�6"   $	��Top=�6I   $
��Left=�6a   $��79��6|    	� 	GroupName$ GioiTinh��6�    d� 	IsChecked$
 TrueY�6�   .��6�   Nam6�   	� 5   
   -	   5        $��radioButton2��5   Q   $��22��6   $��Right=�6"   $��	0,99,30,0q�6>   $	��Top=�6e   $��79��6}   $ GioiTinh��6�   .��6�   Nữ6�   �� 5   
   -
   5        $��label4��5   A   $
��Left=�6   $��10,127,0,232q�6+   $��69��6O   .��6Z   Ngoại ngữ:6f   �� 5   
   -   5        $��	checkBox1��5   )   $��84,0,209,232q�6   $��20��6:   $��Bottom=�6F   $
 TrueY�6a   .��6r   Tiếng Anh6}   �� 5   
   -   5        $��	checkBox2��5   F   $��Right=�6   $��10,127,50,232q�6/   $��85��6W   $��20��6b   $��Bottom=�6n   .��6�   Tiếng Trung6�   �� 5   
   -   5        $��label5��5   K   $��30��6   $
��Left=�6   $��
10,0,0,126q�67   $��Bottom=�6Y   $��69��6t   .��6   Quê quán:5      �� 5      -   5        $��	comboBox1��5   8   $��26��6   $��84,0,27,126q�6#   $��Bottom=�6I    �� SelectedIndex$ 0��6d   .@�5      �� .��6   	Hà nội6'   �� 5      .��6   TP. Hồ Chí Minh60   �� 5      .��6   Hải Phòng6*   �� 5      .��6   Đà Nẵng6(   5       5!      5#      