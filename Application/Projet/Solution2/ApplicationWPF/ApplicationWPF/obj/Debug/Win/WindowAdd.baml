   M S B A M L   `   `   `  ����I  EApplicationWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	       WpfApplication1.WindowAdd   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	   -   5          � ShowInTaskbar  .   � Icon$ ../Pictures/logo.ico��5	   	    � Title$ Cookination��5   	   
 � Top$	 280��6    � Left$ 20��6'   ���#151515
��� ���$��2q�6[   $	��500��6o   $	��500��6|    � 
ResizeMode$ NoResize=�6�   .��5      �� $��Hidden=�6   .��5   
   ]� $��10q�6   .+�5      �� $��Bottom=�6   .+�5      �� -   5         ��Name$ MonLabelErreur��5      $y�Hidden=�60   $��Center=�6D   
���  ��$)��#Veuillez compléter tous les champs��6r   � 5      $��10q�6    � ColumnDefinitions 5      �� 5      $��1* �6+   �� 5      $��2* �6+   .+�5      �� -   5         � ToolTip$6 0Cliquez pour rechercher un fichier dans votre pc��5   q   $��Browse��6�   $��25��6�   $��2��6�   $��
40,0,249,0q�6�   $��Trebuchet MS)�6	  4  .System.Windows.Automation.AutomationProperties	   Name	 6   �� *	ToolTip+
 �� RelativeSource
 �� *Self+6	  �� 5      -   5         ��Name$ 	textBox13��5   3   
��� ���$��1��6F    �� TextWrapping$
 Wrap=�6V   $	��200��6j   $��	61,0,28,0q�6�   5      �� 5      -   5         ��Name$ button��5   �   $. (Créer le plat avec les données saisies��6m   $	��Add��6�   $��25��6�   $��Trebuchet MS)�6�   	 6   �� *	ToolTip+
 �� *Self+6�   �� 5      -   5        $ button1��5   �   $&  Retour à la fenêtre principale��6m   $��Cancel��6�   $��25��6�   $��Trebuchet MS)�6�   	 6   �� *	ToolTip+
 �� *Self+6�   5      �� 5      .+�5      �� $��Plats :��6   $
��Bold"�6+   
�������$��25��6P   $��	underline{�6\   $��Trebuchet MS)�6x   � 5        5!      �� 5"      $��1* �6+   �� 5#      $��2* �6+    � RowDefinitions 5%      �� 5&      $��1* �6(   �� 5'      $��1* �6(   �� 5(      $��1* �6(   .+�5+      �� $��Name :��6   
�������$
��Bold"�6@   $��25��6R   $��5q�6^   $��Trebuchet MS)�6i   �� 5,      -   5        $
 name��5,   �   $% Saisissez le nom de votre plat.��6r   
��� ���$��1��6�   $
 Wrap=�6�   $��25��6�   	 6   �� *	ToolTip+
 �� *Self+6�   �� 5.      $��Categorie :��6   $��1��62   
�������$
��Bold"�6R   $��25��6d   $��5q�6p   $��Trebuchet MS)�6{   �� 5/      -   5        $	 cat��5/   �   $+ %Saisissez la catégorie de votre plat��6r   
��� ���$��1��6�   $��1��6�   $
 Wrap=�6�   $��25��6�   	 6   �� *	ToolTip+
 �� *Self+6   �� 51      $��5q�6   $��Recipe :��6'   $��2��6:   
�������$
��Bold"�6Z   $��25��6l   $��Trebuchet MS)�6x   �� 52      -	   5        $
 Rece��52   �   $ Saisir la recette��6r   
��� ���$��2��6�   $��1��6�   $
 Wrap=�6�   $	��100��6�   	 6   �� *	ToolTip+
 �� *Self+6�   54      �� 56      $��Ingredients :��6   $
��Bold"�61   
�������$��25��6V   $��	underline{�6b   $��Trebuchet MS)�6~   �� 57      -
   5         ��Name$ MyGrid��57      �� 58       �� Orientation$ 
Horizontal=�6   .+�59      �� -   5        $$ Ajouter un champ d'ingrédient��59   q   $	��✚��6�   $��20��6�   $
��Left=�6�   	 6   �� *	ToolTip+
 �� *Self+6�   �� 5:      -   5        $&  Supprimer un champ d'ingrédient��5:   q   $	��⚊��6�   $��20��6�   $
��Left=�6�   	 6   �� *	ToolTip+
 �� *Self+6�   �� 5;      -   5        $ MonLabelErreur2��5;      $y�Hidden=�65   $��Center=�6I   
���  ��$��Il n'y a pas de champs��6w   5<      �� 5=      $��Tools :��6   $
��Bold"�6+   
�������$��25��6P   $��	underline{�6\   $��Trebuchet MS)�6x   �� 5>      -   5        $ MyGrid2��5>      �� 5?      $ 
Horizontal=�6   .+�5@      �� -   5        $ Ajouter un champ d'outil��5@   q   $	��✚��6�   $��20��6�   $
��Left=�6�   	 6   �� *	ToolTip+
 �� *Self+6�   �� 5A      -   5        $  Supprimer un champ d'outil��5A   q   $	��⚊��6�   $��20��6�   $
��Left=�6�   	 6   �� *	ToolTip+
 �� *Self+6�   �� 5B      -   5        $ MonLabelErreur3��5B      $��Right=�65   
���  ��$��Il n'y a pas de champs��6b   $y�Hidden=�6�   �� 5C      -   5        $ MonLabelErreur4��5C      $��Right=�65   
���  ��$��Champ(s) invalide(s)��6b   $y�Hidden=�6�   5D      5E      5F      5G      5H      