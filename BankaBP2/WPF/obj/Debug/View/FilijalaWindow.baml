   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF.ViewWPF.View  5   	       WPF.View.FilijalaWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPF.View     5   	     � Title$  FilijalaWindow��5   	   $	��450��6    $	��800��6-   .��5	      � $��0,0,0,20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	Filijalas��5         AutoGenerateColumns .  $��270,204,237,10q�6w   $��1��6�    �� SelectedItem 6&   ��  �� Path$ Filijala� �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%   	   Header$	 ID��6/   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *ID_FIL+  5      $ * 6&   $	 ADRESS��60   
 6@   �� *	ADR_FIL+  5      $ * 6%   $	 Bank_ID��6/   
 6@   �� *BankaID_Banka+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ * 6)      CellTemplate 5      5  -System.Windows.Controls.ItemContainerTemplate�  5      .R�5      ��  ��Name$ Delete��6%   -   5        $��Delete��5   5   6^   5      5   =   5      �� 5   
   $��Adresa filijale��6   $
��Left=�6*   $��0,71,0,0q�6E   $��1��6W   $	��Top=�6d   �� 5   
   -   5         ��Name$ ADR_FIL��5      $
��Left=�6#   $��23��6>   $��	75,75,0,0q�6J   $��1��6]    �� TextWrapping$
 Wrap=�6j   $	��Top=�6�   $	��120��6�   ��6~   �� *	ADR_FIL+6�   �� 5    
   -   5        $ FIL_ID��5        �� 
IsReadOnly . $
��Left=�64   $��23��6O   $��1��6\   $
 Wrap=�6i   $	��Top=�6�   $	��120��6�   $��	74,43,0,0q�6�   ��6}   �� *FIL_ID+6�   �� 5!   
   $��ID filijale��6   $
��Left=�6'   $��	10,40,0,0q�6B   $��1��6U   $	��Top=�6b   �� 5"   
   $��Banka��6   $
��Left=�6    $��1��6<   $	��Top=�6I   $��
10,102,0,0q�6a   �� 5#   
   -   5        $
��Edit��5#      $
��Left=�6    $��
25,150,0,0q�6;   $��1��6O   $	��Top=�6\   $��75��6t   4  .System.Windows.Automation.AutomationProperties   Name$
 Edit��6   6�   �� 5$   
   -   5        $��Save Change��5$      $
��Left=�6'   $��140,150,0,0q�6B   $��1��6W   $	��Top=�6d   $��75��6|   6�   �� 5%   
   -   5        $��Refresh��5%      $
��Left=�6:   $��165,350,0,0q�6U   $��1��6j   $	��Top=�6w   $��75��6�   �� 5&   
   $��Adresa filijale��6   $
��Left=�6*   $��
330,56,0,0q�6E   $��1��6Y   $	��Top=�6f   �� 5(   
   -   5        $ ADR_FIL_Copy��5(      $
��Left=�6(   $��23��6C   $��
415,60,0,0q�6O   $��1��6c   $
 Wrap=�6p   $	��Top=�6�   $	��120��6�   ��6�   �� *	ADR_FIL+6�   �� 5)   
   $��Banka��6   $
��Left=�6    $��1��6<   $	��Top=�6I   $��
350,87,0,0q�6a   �� 5*   
   -	   5        $��Add New��5*      $
��Left=�6#   $��
565,56,0,0q�6>   $��1��6R   $	��Top=�6_   $	��100��6w   $��20��6�   �� 5,   
   -
   5         ��Name$ listaBanaka��5,       �� DisplayMemberPath$ Naziv��5-       �� SelectedValuePath$ Naziv��5.      $
��Left=�5/   4   $��
415,91,0,0q�6O   $��1��6c   $	��Top=�6p   $	��120��6�   ��5,   (   �� $ listaBanaka� 5/      �� $ ID_Banka�6�   �� 51   
   -   5        $ listaBanakaEdit��51      $ Naziv��52      $ Naziv��53      $
��Left=�54   /   $��
74,106,0,0q�6J   $��1��6^   $	��Top=�6k   $	��120��6�   ��51   ,   �� *listaBanakaEdit+ 54      �� *
ID_Banka+6�   57      58      