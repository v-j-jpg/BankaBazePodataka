   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF.ViewWPF.View  5   	   #clr-namespace:WPF.ViewWPF.View  5   	   -clr-namespace:WPF.ViewModelWPF.ViewModel  5   	       WPF.View.KlijentiWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPF.View     5   	   (viewsclr-namespace:WPF.View     5   	   1	viewModelclr-namespace:WPF.ViewModel     5   	     � Title$  KlijentiWindow��5
   	   $	��450��6    $	��800��6-    � DataContext 5      +   %WPF.ViewModel.KlijentiWindowViewModel  5   
    � 	Resources 5       �� DataType$   WPF.ViewModel.KlijentViewModel   WPF.View.KlijentView!   WPF.ViewModel.HomeViewModel   WPF.View.HomeView#   WPF.ViewModel.ZirantViewModel   WPF.View.ZirantView&    WPF.ViewModel.SluzbenikViewModel	   WPF.View.SluzbenikView!
   WPF.ViewModel.RiskViewModel   WPF.View.Risk#   WPF.ViewModel.OdlukaViewModel   WPF.View.OdlukaView&    WPF.ViewModel.OdobrenjeViewModel   WPF.View.OdobrenjeView*   $WPF.ViewModel.IzdatiKreditiViewModel    WPF.View.IzdatiKreditiView��%X  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5      *, +)(�� �     5      *,
 +)(�� �     5       *, +)(�� ,    5#      *, +)(�� ^    5&      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5      	  5      �� 5   
   " 
 6   .R�5        5      �� 5    
   "  6   .R�5!        5"      �� 5#   
   "  6   .R�5$        5%      �� 5&   
   "  6   .R�5'        5(      5)      .��5*      �  � RowDefinitions 5+   
   �� 5,      $
��Auto �6   �� 5-      $
��Auto �6   .+�50   
   ]� $��0��6   $��5q�6!   .+�51      o� $	��Top=�6   .@�53      m� $
��Home��6    m� CommandParameter$
 home��54       m� Command 53   )   �� *
NavCommand+54      m� 55      $��Lista klijenata��6   $ klijent��56       55   4   �� *
NavCommand+56      m� 57      $��Lista ziranata��6   $ zirant��58       57   3   �� *
NavCommand+58      m� 59      $��Lista sluzbenika��6   $ 	sluzbenik��5:       59   5   �� *
NavCommand+5:      m� 5;      $��
Lista risk��6   $
 risk��5<       5;   /   �� *
NavCommand+5<      m� 5=      $��Lista odluka��6   $ odluka��5>       5=   1   �� *
NavCommand+5>      m� 5?      $��Lista odobrenja��6   $ 	odobrenje��5@       5?   4   �� *
NavCommand+5@      m� 5A      $��Lista izdatih kredita��6   $ izdati��5B       5A   :   �� *
NavCommand+5B      5C      5D      � 5E   
   $��1��6   .+�5F      �� ��6   �� *CurrentViewModel+5G      5H      5I      