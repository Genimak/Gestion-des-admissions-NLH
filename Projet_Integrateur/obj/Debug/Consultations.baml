   M S B A M L   `   `   `  ����M  IProjet_Integrateur, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Projet_IntegrateurProjet_Integrateur  5   	   &     Projet_Integrateur.Consultations   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Projet_Integrateur     5   	   -   5          � Title$  Consultations��5   	   $��636.909��6   $��1059.706��60    � WindowStartupLocation$ CenterScreen=�6X    � 
ResizeMode$ NoResize=�6}    � 	Resources 5	       �� 
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
 0.95Q�6J   � 5   .   $ 	#FFFFD190��6;   $ 1Q�6M   5   +   5    #   �� 5!   "    � z� 5"   &   T� 5#   *   $	 1.0Q�6=   5%   #   5&      5)      5+      5,      5.      .��5/      � $��0,0,4.2,10.6q�6   .+�51   
   �� $'��!Patients du médecin selectionné��6   $
��Left=�6<   $	��226��6W   $��
35,312,0,0q�6d   $	��Top=�6x   $	��954��6�   ���	#FF1832F0$
��Bold"�6�   $��Italic$�6�   �� 53   
   $��	Médecins��6   $
��Left=�6%   $	��284��6@   $��	35,10,0,0q�6M   $	��Top=�6`   $	��289��6x   ���	#FF180AF0$
��Bold"�6�   $��Italic$�6�   �� 55   
   $��Statistiques��6   $
��Left=�6)   $	��270��6D   $��
388,24,0,0q�6Q   $	��Top=�6e   $	��601��6}   ���	#FF1B0DF0$
��Bold"�6�   $��Italic$�6�   .��56      �� $��Taux de lits occupés:��6   $
��Left=�64   $��	35,41,0,0q�6O   $	��Top=�6b   ���	#FF1F11F9$
��Bold"�6�   $��Italic$�6�   $��Times New Roman)�6�   $��14(�6�   57      &   System.Windows.Controls.DataGrid  59   
   -   5          Name$ 	dgMedecin��59         AlternatingRowBackground
 � ���   RowBackground
 �����$��54,62,746.4,290.8q�6_      AutoGenerateColumns .  ��6�   ��    Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ 
ID Medecin��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	idMedecin+  5<      $	 Nom��6%    62   �� *nom+  5=      $ Prénom��6%    65   �� *prenom+5B        5C   
   -   5        $ gvAdmission��5C       �#FEFEE2 �#FDF1B8$
��Left=�6e   $	��157��6�   $��
98,363,0,0q�6�   $	��Top=�6�   $	��856��6�    .     
IsReadOnly . ��6�   ��  5D        5F      $ ID Admission��6%    6;   �� *idAdmission+  5G      $	 NSS��6%    62   �� *nss+  5H      $	 Nom��6%    62   �� *nom+  5I      $ Prénom��6%    65   �� *prenom+  5J      $ Date d'admission��6%    6@   �� *dateAdmission+ �� StringFormat$ {0:dd/MM/yyyy}��  5K      $ Date chirurgie��6%    6=   �� *dateChirurgie+$ {0:dd/MM/yyyy}��  5L      $ Date congé��6%    69   �� *	dateConge+$ {0:dd/MM/yyyy}��5O      � 5P   
   -   5         �Name$ pbAdmiss��5P   0    � Minimum$ 0Q�6    � Maximum$	 100Q�6"   $
��Left=�6B   $��25��6]   $��
595,78,0,0q�6i   $	��Top=�6}   $	��378��6�   �� 5Q   
   $
��Left=�6   $��
793,84,0,0q�6/   $
��Wrap=�6C   $	��Top=�6�   ��6W   �� *Value+ �� ElementName$ pbAdmiss��$ {0:0}%��6�   �� 5R   
   $��Capacité de l'hôpital:��6   $
��Left=�61   $��426,143,0,0q�6L   $	��Top=�6a   ���	#FF1611F0$��Times New Roman)�6�   $
��Bold"�6�   $��Italic$�6�   $��14(�6�   �� 5S   
   $!��Nombre de lits disponibles:��6   $
��Left=�66   $��394,174,0,0q�6Q   $	��Top=�6f   ���	#FF1611F0$��Times New Roman)�6�   $
��Bold"�6�   $��Italic$�6�   $��14(�6�   �� 5T   
   -   5         ��Name$ capacite��5T      $�� ��6#   $
��Left=�6.   $��597,143,0,0q�6I   $	��Top=�6^   ���	#FFF31D0D6v   �� 5U   
   -   5        $ 
disponible��5U      $�� ��6%   $
��Left=�60   $��597,174,0,0q�6K   $	��Top=�6`   ���	#00000000$��14(�6�   ���	#FFF410106�   �� 5V   
   -   5        $ disponible_Copy��5V      $��Lit (s)��6*   $
��Left=�6<   $��657,143,0,0q�6W   $	��Top=�6l   $��Italic$�6�   ���	#FF5419F1$��Times New Roman)�6�   $
��Bold"�6�   �� 5W   
   $��Nombre de lits occupés:��6   $
��Left=�62   $��411,208,0,0q�6M   $	��Top=�6b   ���	#FF1611F0$��Times New Roman)�6�   $
��Bold"�6�   $��Italic$�6�   $��14(�6�   �� 5X   
   -   5        $ occupe��5X      $�� ��6!   $
��Left=�6,   $��595,208,0,0q�6G   $	��Top=�6\   ���	#00000000$��14(�6�   ���	#FFF410106�   �� 5Y   
   $��Specialité:��6   $
��Left=�6&   $��331,329,0,0q�6A   $	��Top=�6V   ���	#FF1611F0$��Times New Roman)�6�   $
��Bold"�6�   $��Italic$�6�   $��14(�6�   �� 5Z   
   -	   5        $ 
specialite��5Z      $�� ��6%   $
��Left=�60   $��426,326,0,0q�6K   $	��Top=�6`   ���	#00000000$��14(�6�   ���	#FFF410106�   �� 5[   
   -
   5          ��Name$  	btnQuiter��5[   4   #��[  6   $��Quitter��6H   $
��Left=�6Z   $��869,543,0,0q�6u   $	��Top=�6�   $	��147��6�   $��40��6�   $��Italic$�6�   $��14(�6�   ! �� IsCancel! . 6�   5]      5^      