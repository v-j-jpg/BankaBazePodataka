   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF.ViewWPF.View  5   	       WPF.View.BankaWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPF.View     5   	     � Title$  BankaWindow��5   	   $	��450��6   $	��800��6*   .��5
      � $��0,0,0,20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��BankGrid��5      $��1��6#   $��4,178,12,13q�60   ��6F   �� *Banke+ �� View 5      �� 5      -   5        grdTest��.P�5      �� $��ID��6%    �� Width$ 50��6V    �� DisplayMemberBinding 61   �� *ID+6V   �� 5      $��Naziv��6%   $ 80��6\    64   �� *Naziv+6\   5      5      �� 5   
   -   5        $��txtID��5   X   $��1��6   $��23��6   $
��Left=�6+   $��80,7,0,0q�6F   $	��Top=�6e   $	��178��6}    �� 
IsReadOnly . ��6�   ��  �� ElementName$ BankGrid�� �� Path$ SelectedItem.ID��� 5   
   -   5        $��txtNaziv��5   Y   $��1��6   $��23��6   $
��Left=�6+   $��	80,35,0,0q�6F   $	��Top=�6i   $	��178��6�   ��6�   �� $ BankGrid��$ SelectedItem.Naziv��� 5   
   -   5        $��label1��5   Z   $��ID��6   $��1��6   $
��Left=�6*   $��12,12,0,336q�6E   6Z   �� 5   
   -   5        $��label3��5   g   $��Naziv��6   $��1��6    $��28��6-   $
��Left=�69   $��	12,35,0,0q�6T   $	��Top=�6u   �� 5   
   -   5        $��	btnUpdate��5   i   $��Update��6   $��1��6"   $��23��6/   $
��Left=�6;   $��	80,90,0,0q�6V   $	��Top=�5      $	��141��6)   ��5      �� $ UpdateCommad��� 5    
   -   5        $��	btnDelete��5    j   $��Delete��6   $��1��6"   $��23��6/   $
��Left=�6;   $��
82,136,0,0q�6V   $	��Top=�5!      $	��141��6)   ��5"      �� $ DeleteCommand��� 5$   
   -	   5        $��	NoviNaziv��5$   G   $��1��6   $��23��6   $
��Left=�6+   $	��Top=�6X   $	��178��6p   $��
370,40,0,0q�5%   N   ��6   �� $ Banka.NoviNaziv��$ 	NoviNaziv�6N   �� 5'   
   -
   5        $��labelNaz��5'   Y   $��New Bank-->Enter Name:��6   $��1��61   $
��Left=�6>   $��370,17,0,336q�6i   $	��178��6   �� 5)   
   -   5        $��	btnSubmit��5)   j   $��Submit��6   $��1��6"   $��23��6/   $
��Left=�6;   $��
373,82,0,0q�6V   $	��Top=�5*      $	��173��6)    J� RenderTransformOrigin$ 0.26,-0.478&�5+      65   5.      5/      