   M S B A M L   `   `   `  ����M  IProjet_Integrateur, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Projet_IntegrateurProjet_Integrateur  5   	   *    $Projet_Integrateur.AjouterSpecialite   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Projet_Integrateur     5   	   -   5          � Title$  AjouterSpecialite��5   	   $��278.036��6#   $��583.014��64    � WindowStartupLocation$ CenterScreen=�6[    � 
ResizeMode$ NoResize=�6�    � 	Resources 5	       �� 
TargetType   	TabButton �� Property �� Value �� 
TargetType �� CornerRadius	 ��Name
 �� Triggers P� Property P� Value �� 
StartPoint �� EndPoint � Color � Offset T� Y��%c  &	        �� 5
   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       �@��TextAlignment$ Center=�68   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 10��6!   
��� ������#ccc$��0,1,1,0q�6Z   ._�5      �� $	 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  5      
 5      P� 5       �@J�IsMouseOver . . �5   "   ��  � ��
 �����6?   5      P� 5       � �� . . �5   "   ��  � �� 5   &   �� 5   *   $	 0,0&�6>   $	 0,1&�6O   .��5   .   � $ 	#FFFFD190��6;   $
 0.35Q�6M   � 5   .   $ Orange��6;   $
 0.95Q�6J   � 5   .   $ 	#FFFFD190��6;   $ 1Q�6M   5   +   5    #   �� 5!   "    � z� 5"   &   T� 5#   *   $	 1.0Q�6=   5%   #   5&      5)      5+      5,      5-      .��5.      � .+�5/   
   �� $��Spécialité��6   $
��Left=�6'   $	��153��6B   $��9,36,0,0q�6O   $	��Top=�6a   $	��259��6y   $
��Bold"�6�   $��Italic$�6�   $��Times New Roman)�6�   �� 51   
   -   5         ��Name$ tbnAjout��51   4   #��[  6   $��Ajouter��6F   $
��Left=�6X   $��	9,199,0,0q�6s   $	��Top=�6�   $	��110��6�    J� RenderTransformOrigin$ 
0.194,0.57&�6�    �� 	IsDefault . 6�   �� 52   
   -   5        $ 
tbnQuitter��52   4   #��[  6   $��Quitter��6H   $
��Left=�6Z   $��437,203,0,0q�6u   $	��Top=�6�   $	��118��6�    �� IsCancel . 6�   �� 53   
   $��ID Spécialité:��6   $
��Left=�6)   $��9,64,0,0q�6D   $	��Top=�6V   $��Times New Roman)�6n   $
��Bold"�6�   $��Italic$�6�   �� 54   
   $��Spécialité:��6   $
��Left=�6&   $��9,95,0,0q�6A   $	��Top=�6S   $��Times New Roman)�6k   $
��Bold"�6�   $��Italic$�6�   �� 55   
   -   5         ��Name$ txtIdSpecialite��55      $
��Left=�6-   $��26��6H   $��
111,64,0,0q�6T    �� TextWrapping$
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��127��6�   $��1��6�   �� 56   
   -   5        $ txtNomSpecialite��56      $
��Left=�6-   $��23��6H   $��
111,95,0,0q�6T   $
 Wrap=�6h   $�� ��6|   $	��Top=�6�   $	��127��6�   $��2��6�   &   System.Windows.Controls.DataGrid  57   
   -   5          Name$ dgSpecialite��57         AlternatingRowBackground �#FEFEE2   RowBackground �#FDF1B8$
��Left=�6e   $	��143��6�   $��
287,46,0,0q�6�   $	��Top=�6�   $	��266��6�      AutoGenerateColumns .  ��6�   ��    Columns 58      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ ID Spécialité��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *idSpecialite+  5;      $ Spécialité ��6%    6:   �� *descSpecialite+ � ContextMenu 5=      �� 5>      .@�5?      m� -   5        $��	Supprimer��5?        m� Icon  5@      �� 5A      $��Images/delete.png��6$   5C      �� 5D      5E      5G      �� 5H   
   -   5        $ 
tbnAnnuler��5H   4   #��[  6   $��Annuler��6H   $
��Left=�6Z   $��158,200,0,0q�6u   $	��Top=�6�   $	��110��6�   $ 
0.194,0.57&�6�   6�   5J      5K      