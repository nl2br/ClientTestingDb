   M S B A M L   `   `   `  ����@  <WpfB3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfB3WpfB3  5   	       WpfB3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:WpfB3     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ lbClient��5      $
��Left=�6$   $	��365��6?   $	��Top=�6L   $	��397��6d   $��2��6p   �� 5   
   -   5         ��Name$ btnAjout��5      $��Ajouter��6#   $
��Left=�65   $��220.2,175,0,0q�6P   $	��Top=�6g   $��80��6   $��19��6�   $��1��6�   �� 5   
   -   5         ��Name$ tbMtEnCours��5      $��1��6'   $
��Left=�67   $��23��6R   $��98.2,139,0,0q�6^    �� TextWrapping$
 Wrap=�6t   $	��Top=�6�   $	��202��6�   ��6�   �� *SelectedItem.MtEncours+ �� ElementName$ lbClient��6�   �� 5   
   -   5        $ tbNom��5      $��1��6!   $
��Left=�61   $��23��6L   $��98.2,69,0,0q�6X   $
 Wrap=�6m   $	��Top=�6�   $	��202��6�   ��6�   �� *SelectedItem.Name+$ lbClient��6�   �� 5   
   -   5        $ btDelete��5      $��	Supprimer��6#   $
��Left=�67   $��	0,365,0,0q�6R   $	��Top=�6e   $	��196��6}   $��55��6�   �� 5   
   -   5        $ btSave��5      $
��Save��6!   $
��Left=�60   $��196,365,0,0q�6K   $	��Top=�6`   $	��201��6x   $��2��6�   $��55��6�   6�   �� 5   
   $	��Nom��6   $��1��6   $
��Left=�6.   $��29.2,66,0,0q�6I   $	��Top=�6^   �� 5   
   $
��Type��6   $��1��6   $
��Left=�6/   $��29.2,104,0,0q�6J   $	��Top=�6`   �� 5   
   $��En cours��6   $��1��6#   $
��Left=�63   $��30.2,139,0,0q�6N   $	��Top=�6d   �� 5   
   -   5        $ tbType��5      $��1��6"   $
��Left=�62   $��23��6M   $��98.2,104,0,0q�6Y   $
 Wrap=�6o   $	��Top=�6�   $	��202��6�   ��6�   �� *SelectedItem.Name+$ lbClient��6�   5      5      