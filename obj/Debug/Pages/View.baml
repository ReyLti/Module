   M S B A M L   `   `   `  ����M  Ipr20.102k_LazarevD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:pr20._102k_LazarevD.Pagespr20._102k_LazarevD.Pages  5      $    pr20._102k_LazarevD.Pages.View   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:pr20._102k_LazarevD.Pages     5        N� Title$
  View��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��260 �6   �� 5      $	��260 �6   �� 5      $	��260 �6    � RowDefinitions 5   
   �� 5      $	��300 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��0��6;   $��3��6K   $��Center=�6_   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgMain��5         AutoGenerateColumns .    
IsReadOnly .    SelectionMode$ Single=�6T   
�������$	��600��6}   6�   5      �� 5   
   -   5         ��Name$ btnAdd��5      $��1��6!   $��0��6.   $��Добавить��6>   6h   �� 5   
   -   5        $ btnEdit��5      $��1��6"   $��1��6/   $��Изменить��6?   6j   �� 5   
   -   5        $ 	btnDelete��5      $��1��6$   $��2��61   $��Удалить��6A   6m   5      5      