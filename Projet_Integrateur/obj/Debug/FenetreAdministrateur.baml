   M S B A M L   `   `   `  ����M  IProjet_Integrateur, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Projet_IntegrateurProjet_Integrateur  5   	   .    (Projet_Integrateur.FenetreAdministrateur   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Projet_Integrateur     5   	   -   5          � Title$  FenetreAdministrateur��5   	   $��550.4��6(   $��706.8��67    � WindowStartupLocation$ CenterScreen=�6G    � 
ResizeMode$ NoResize=�6l    � 	Resources 5
       �� 
TargetType   	TabButton �� Property �� Value �� 
TargetType �� CornerRadius	 ��Name
 �� Triggers P� Property P� Value �� 
StartPoint �� EndPoint � Color � Offset T� Y  
TabButton3��%�  &	        &	 Y    �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       �@��TextAlignment$ Center=�68   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 10��6!   
��� ������#ccc$��0,1,1,0q�6Z   ._�5      �� $	 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  5      
 5      P� 5       �@J�IsMouseOver . . �5   "   ��  � ��
 �����6?   5      P� 5       � �� . . �5   "   ��  � �� 5   &   �� 5   *   $	 0,0&�6>   $	 0,1&�6O   .��5   .   � $ 	#FFFFD190��6;   $
 0.35Q�6M   � 5   .   $ Orange��6;   $
 0.95Q�6J   � 5   .   $ 	#FFFFD190��6;   $ 1Q�6M   5   +   5!   #   �� 5"   "    � z� 5#   &   T� 5$   *   $	 1.0Q�6=   5&   #   5'      5*      5,      5-      �� 5.   
   " ��6   .�5/      ��  � ��
 �����6+   �� 50       �@��TextAlignment$ Center=�68   �� 51       � �� 52      �� 53      " ��6&   .R�55      �� $ 	0,0,10,10��6!   
����d����#ccc$��0,1,1,0q�6i   ._�56      �� $	 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6  57      
 58      P� 59       �@J�IsMouseOver . . �5:   "   ��  � ��
 �����6?   5;      P� 5<       � �� . . �5=   "   ��  � �� 5>   &   �� 5?   *   $	 0,0&�6>   $	 0,1&�6O   .��5@   .   � $ 	#FFFFD190��6;   $
 0.35Q�6M   � 5A   .   $ Orange��6;   $
 0.95Q�6J   � 5B   .   $ 	#FFFFD190��6;   $ 1Q�6M   5C   +   5E   #   �� 5F   "    � z� 5G   &   T� 5H   *   $	 1.0Q�6=   5J   #   5K      5O      5R      5T      5V      .��5W      � .+�5Z   
   �� $��Consultations��6   $
��Left=�6*   $	��234��6E   $��420,207,0,0q�6R   $	��Top=�6g   $	��223��6   �� 5]   
   $��	Médecins��6   $
��Left=�6%   $	��234��6@   $��
40,207,0,0q�6M   $	��Top=�6a   $	��225��6y   �� 5`   
   $��images/consult.jpg��6   $��0��6,   $��463,226,105.8,193.8q�69   �� 5a   
   $��Images/medecinss.jpg��6   $��0��6.   $��73,226,479.8,171.8q�6;   �� 5c   
   -   5         ��Name$ 
btnNouvMed��5c   4   #��[  6   $��Gestion Medecins��6H   $
��Left=�6c   $��
61,361,0,0q�6~   $	��Top=�6�   $	��172��6�   $��58��6�   6�   �� 5d   
   -   5        $ btnModifMed��5d   4   #��[  6   $��Tableau de consultations��6I   $
��Left=�6l   $��451,360,0,0q�6�   $	��Top=�6�   $	��174��6�   $��58��6�    J� RenderTransformOrigin$ 0.019,4.952&�6�   6�   �� 5e   
   -   5        $ 
btnQuitter��5e   5   #��[ 6   $��Quitter��6I   $
��Left=�6[   $��
40,446,0,0q�6v   $	��Top=�6�   $	��603��6�   $��40��6�    �� IsCancel . 6�   &   System.Windows.Controls.DataGrid  5f   
   -   5          Name$ 	dgMedecin��5f         AlternatingRowBackground
 � ���   RowBackground
 �����$��37,43,57.8,327.8q�6_      AutoGenerateColumns .     
IsReadOnly . ��6�   ��    Columns 5g      0  *System.Windows.Controls.DataGridTextColumn  5h      ,  &System.Windows.Controls.DataGridColumn   Header$ 
ID Medecin��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	idMedecin+  5i      $	 Nom��6%    62   �� *nom+  5j      $ Prénom��6%    65   �� *prenom+  5k      $ Spécialite��6%    69   �� *descSpecialite+5o      o� 5p   
   $
��Left=�6   $��29��6*   $	��Top=�66   $	��701��6N   $��
0,0,-0.2,0q�6Z   
����d�.@�5q      m� $��_Administration��6   .@�5r      m� -   5        $��Gestion Medecins��5r      65   m� 5s      -   5        $��Tableau de consultations��5s      6=   �� 5t      m� 5u      -   5        $��_Exit��5u      6*   5v      5y      5{      5}      