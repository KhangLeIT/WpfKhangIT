   M S B A M L   `   `   `  ����P  LWpfAppBuoi10_22082023, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfAppBuoi10_22082023WpfAppBuoi10_22082023  5   	   $    WpfAppBuoi10_22082023.Window14   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:WpfAppBuoi10_22082023     5   	     � Title$  Window14��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5
   
   '� -   5        $��viewport3D1��5
       '� Camera 5      =� 5      -   5        camMain�� � Position$ 6 5 41�5   7    � LookDirection$ -6 -5 -45�6J   5      .x�5      g�  g� Content 5      t� 5      -   5        dirLightMain�� t� 	Direction$ -1,-1,-15�5   ?   5      5      g� 5      -   5        MyModel�� 5      � 5       � Geometry 5      k� 5      -   5        meshMain�� k� 	Positions! �    k� TriangleIndices. �$        5!      	 � Material	 5$      u� 5%      -   5        matDiffuseMain��
 u� Brush
 5&   "   �� 5'   &    �� Color$ Bisque��66   5)      5,       g� 	Transform 5/      �� 50       �� Rotation 51      �� 52      -   5        
rotate�� �� Axis$ 1 2 15�52   D   54      57      58      �� 5:   
   -   5        $��slider1��5;   !   $��23��5:      $
��Left=�6   $��145,271,0,0q�5;   
   $	��Top=�5<   
   $	��269��6$    � Maximum$	 360Q�5=   
    � Value 5>   
   ��  �� ElementName$ rotate�� �� Path$ Angle�5@      5B      