   M S B A M L   `   `   `  ����I  EApplicationWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ApplicationWPFApplicationWPF  5   	       ApplicationWPF.WindowEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ApplicationWPF     5   	   -   5          � ShowInTaskbar  .   � Icon$ ../Pictures/logo.ico��5
   	    � Title$ Fenêtre de modification��5   	   
 � Top$	 250��6)    � Left$ 50��63   ���#151515
��� ���$��2q�6g   $	��550��6{   $	��600��6�    � 
ResizeMode$ NoResize=�6�   .��5      ]� .+�5   
   �� $��Bottom=�6   .+�5      �� $��Center=�6   $��Bottom=�66    �� Orientation$ 
Horizontal=�6N   .+�5      �� -   5         ��Name$ button��5   �    � ToolTip$6 0Cliquer pour rechercher un fichier dans votre pc��6m   $��Browse��6�   $��25��6�   $	��150��6�   $
��Left=�6�   $��20q�6  $��Trebuchet MS)�6   4  .System.Windows.Automation.AutomationProperties	   Name	 6   �� *	ToolTip+
 �� RelativeSource
 �� *Self+6   �� 5      -   5         ��Name$ Im��5      $	��170��6&   $��25��62   $��10q�6>   ��6J   �� *	Pathimg+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5      -   5        $ button1��5   �   $5 /Cliquer si vous avez terminé vos modifications��6i   $��Finish��6�   $��25��6�   $��5 5 5 5q�6�   $��Trebuchet MS)�6�   	 6   �� *	ToolTip+
 �� *Self+6�   5      �� 5   
   $��Bottom=�6   
������ ��6+   �� *Ing+��5      �� 5      .R�5      �� $ 
Horizontal=�6!   .+�5      �� $, &Saisir le nouveau nom de l'ingrédient��6v   $	��150��6�   $��90 0 0 0q�6�   	 6"   �� *	ToolTip+
 �� *Self+��6�   �� *Nom+$ TwoWay=�$ PropertyChanged=�6�   �� 5      $< 6Saisir le nouveau nombre d'exemplaire de l'ingrédient��6v   $��30��6�   $��25 0 0 0q�6  	 6"   �� *	ToolTip+
 �� *Self+��6�   �� *Nb+$ TwoWay=�$ PropertyChanged=�6  5      5      5      �� 5!   
   $��Ingrédients :��6   $��Bottom=�6(   
�������$
��Bold"�6S   $��Trebuchet MS)�6e   �� 5$   
   $��Bottom=�6   
������ ��6+   �� *Outils+��5%      �� 5&      .R�5'      �� $ 
Horizontal=�6!   .+�5(      �� $&  Saisir le nouveau nom de l'outil��6v   $��90 0 0 0q�6�   $	��150��6�   	 6"   �� *	ToolTip+
 �� *Self+��6�   �� *Nom+$ TwoWay=�$ PropertyChanged=�6�   �� 5)      $7 1Saisir le nouveau nombre d'exemplaires de l'outil��6v   $��25 0 0 0q�6�   $��30��6
  	 6"   �� *	ToolTip+
 �� *Self+��6�   �� *Nb+$ TwoWay=�$ PropertyChanged=�6
  5*      5+      5-      �� 5/   
   $��Outils :��6   $��Bottom=�6#   
�������$
��Bold"�6N   $��Trebuchet MS)�6`   �� 51   
   .+�52      �� $��Plat :��6   
�������$
��Bold"�68   $��Trebuchet MS)�6J   �� 53      $ 
Horizontal=�6   $��Center=�62   .+�54      �� $��Name :��6   $��Center=�6)   $��Center=�6F   
�������$	��100��6t   $��Trebuchet MS)�6�   �� 55      $ Saisir le nouveau nom��6n   $��Right=�6�   $	��150��6�   $��10q�6�   	 6   �� *	ToolTip+
 �� *Self+��6�   �� *Name+$ TwoWay=�$ PropertyChanged=�56      �� 57      $ 
Horizontal=�6   $��Center=�62   .+�58      �� $��Categorie :��6   $��Center=�6.   $��Center=�6K   
�������$	��100��6y   $��Trebuchet MS)�6�   �� 59      $# Saisir la nouvelle catégorie��6n   $��Right=�6�   $	��150��6�   $��10q�6  	 6   �� *	ToolTip+
 �� *Self+��6�   �� *Categ+$ TwoWay=�$ PropertyChanged=�6  5:      �� 5;      $ 
Horizontal=�6   $��Center=�62   .+�5<      �� $��Recipe :��6   $��Center=�6+   $��Center=�6H   
�������$	��100��6v   $��Trebuchet MS)�6�   �� 5=      $  Saisir la nouvelle recette��6n   $��Right=�6�   $��10q�6�   	 6   �� *	ToolTip+
 �� *Self+��6�   �� *Recipe+$ TwoWay=�$ PropertyChanged=�6�   5>      �� 5?      -   5         ��Name$ MonLabelErreur2��5?      $y�Hidden=�6-   $��Center=�6A   
���  ��$��Il n'y a pas de champs��6o   5@      5A      5B      