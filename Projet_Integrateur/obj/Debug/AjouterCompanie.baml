   M S B A M L   `   `   `  ����M  IProjet_Integrateur, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Projet_IntegrateurProjet_Integrateur  5   	   (    "Projet_Integrateur.AjouterCompanie   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Projet_Integrateur     5   	   -   5          � Title$  AjouterCompanie��5   	   $��264.532��6!   $��600.384��62    � WindowStartupLocation$ CenterScreen=�6Y    � 
ResizeMode$ NoResize=�6~    � 	Resources 5	       �� 
TargetType   	TabButton �� Property �� Value �� 
TargetType �� CornerRadius	 ��Name
 �� Triggers P� Property P� Value �� 
StartPoint �� EndPoint � Color � Offset T� Y  
TabButton3��%�  &	        &	 Y    �� 5
   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       �@��TextAlignment$ Center=�68   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 10��6!   
��� ������#ccc$��0,1,1,0q�6Z   ._�5      �� $	 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  5      
 5      P� 5       �@J�IsMouseOver . . �5   "   ��  � ��
 �����6?   5      P� 5       � �� . . �5   "   ��  � �� 5   &   �� 5   *   $	 0,0&�6>   $	 0,1&�6O   .��5   .   � $ 	#FFFFD190��6;   $
 0.35Q�6M   � 5   .   $ Orange��6;   $
 0.95Q�6J   � 5   .   $ 	#FFFFD190��6;   $ 1Q�6M   5   +   5    #   �� 5!   "    � z� 5"   &   T� 5#   *   $	 1.0Q�6=   5%   #   5&      5)      5+      5,      �� 5-   
   " ��6   .�5.      ��  � ��
 �����6+   �� 5/       �@��TextAlignment$ Center=�68   �� 50       � �� 51      �� 52      " ��6&   .R�54      �� $ 	0,0,10,10��6!   
����d����#ccc$��0,1,1,0q�6i   ._�55      �� $	 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  56      
 57      P� 58       �@J�IsMouseOver . . �59   "   ��  � ��
 �����6?   5:      P� 5;       � �� . . �5<   "   ��  � �� 5=   &   �� 5>   *   $	 0,0&�6>   $	 0,1&�6O   .��5?   .   � $ 	#FFFFD190��6;   $
 0.35Q�6M   � 5@   .   $ Orange��6;   $
 0.95Q�6J   � 5A   .   $ 	#FFFFD190��6;   $ 1Q�6M   5B   +   5D   #   �� 5E   "    � z� 5F   &   T� 5G   *   $	 1.0Q�6=   5I   #   5J      5N      5Q      5S      5T      .��5U      � $��0,0,2.8,5.8q�6   .+�5V   
   �� $��	Assurance��6   $
��Left=�6&   $	��129��6A   $��	24,28,0,0q�6N   $	��Top=�6a   $	��259��6y   $
��Bold"�6�   $��Italic$�6�   $��Times New Roman)�6�   �� 5X   
   -   5         ��Name$ tbnAjout��5X   4   #��[  6   $��Ajouter��6F   $
��Left=�6X   $��
27,200,0,0q�6s   $	��Top=�6�   $	��110��6�    J� RenderTransformOrigin$ 
0.194,0.57&�6�    �� 	IsDefault . 6�   �� 5Y   
   -   5        $ 
tbnQuitter��5Y   4   #��[  6   $��Quitter��6H   $
��Left=�6Z   $��452,200,0,0q�6u   $	��Top=�6�   $	��118��6�    �� IsCancel . 6�   �� 5Z   
   $��ID Companie:��6   $
��Left=�6'   $��	24,56,0,0q�6B   $	��Top=�6U   $��Times New Roman)�6m   $
��Bold"�6�   $��Italic$�6�   �� 5[   
   $��Nom Companie:��6   $
��Left=�6(   $��	24,87,0,0q�6C   $	��Top=�6V   $��Times New Roman)�6n   $
��Bold"�6�   $��Italic$�6�   �� 5\   
   -   5         ��Name$ 	txtIdComp��5\      $
��Left=�6'   $��26��6B   $��
126,56,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��127��6�   6�   �� 5]   
   -   5        $ 
txtNomComp��5]      $
��Left=�6'   $��23��6B   $��
126,87,0,0q�6N   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��127��6�   &   System.Windows.Controls.DataGrid  5^   
   -   5          Name$ dgAssurance��5^         AlternatingRowBackground �#FEFEE2   RowBackground �#FDF1B8$
��Left=�6d   $	��143��6   $��
304,38,0,0q�6�   $	��Top=�6�   $	��266��6�      AutoGenerateColumns .  ��6�   ��    Columns 5_      0  *System.Windows.Controls.DataGridTextColumn  5a      ,  &System.Windows.Controls.DataGridColumn   Header$ ID Assurance��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
idCompanie+  5b      $ Nom Companie ��6%    6<   �� *nomCompagnie+ � ContextMenu 5d      �� 5e      .@�5f      m� -   5        $��	Supprimer��5f        m� Icon  5g      �� 5h      $��Images/delete.png��6$   5j      �� 5k      5l      5n      �� 5o   
   -   5        $ 
tbnAnnuler��5o   4   #��[  6   $��Annuler��6H   $
��Left=�6Z   $��173,200,0,0q�6u   $	��Top=�6�   $	��110��6�   $ 
0.194,0.57&�6�   6�   5q      5r      