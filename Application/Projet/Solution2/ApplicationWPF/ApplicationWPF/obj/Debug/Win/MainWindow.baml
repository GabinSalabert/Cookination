   M S B A M L   `   `   `  ����I  EApplicationWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfApplication1     5   	   -   5        $
��Root��5   	     � Icon$  ../Pictures/logo.ico��5	   	   ���#151515
��� ���$	��0.7q�5   	    � Title$ Cookination��5   	   $	��600��6   $	��850��6*    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ NoResize=�6[   .��5      ]� .+�5   
   �� $	��Top=�6   
��� ���$��1q�6;   ._�5      �� $��../Pictures/Ban.jpg��6   5      ]� 5   
   .+�5      ]� $	��180��6   .+�5      �� -   5         ��Name$ Dishes��5      $	��Top=�6(   
�������
��� ���
���   �$��1q�6|   $��Center=�6�   $��29��6�   $��10 20 10 10q�6�   $	��Top=�6�   $��96��6�   {�.  $��Dishes��6  $��Center=�6  $
��Bold"�68  $��Trebuchet MS)�6J  �� 5      $��Bottom=�6    �� Orientation$ 
Horizontal=�65   $��Center=�6N   $��10q�6k   .+�5      �� -   5         � ToolTip$ Supprimer un plat��5   q   $��1q�6�   
��� ���$	��⚊��6�   $��Center=�6�   $��Center=�6�   $��30��6  $��30��6  4  .System.Windows.Automation.AutomationProperties   Name 6   �� *	ToolTip+ �� RelativeSource �� *Self+6  �� 5      -   5        $ Ajouter un plat��5   q   $��1q�6�   
��� ���$	��✚��6�   $��Center=�6�   $��Center=�6�   $��30��6
  $��30��6   6   �� *	ToolTip+ �� *Self+6  �� 5      -   5        $ Modifier un plat��5   q   $��1q�6�   
��� ���$	��✎��6�   $��Center=�6�   $��Center=�6�   $��30��6  $��30��6   6   �� *	ToolTip+ �� *Self+6  �� 5      -   5        $ Trier les plats��5   q   $��1q�6�   
��� ���$	��⌨��6�   $��Center=�6�   $��Center=�6�   $��30��6
  $��30��6   6   �� *	ToolTip+ �� *Self+6  5       �� 5"      -   5        	 ��Name$	 listBox��5"      $	��150��6,   $��
15 5 15 15q�68   
�������$
��Left=�6_   
���   �
��� ���$��Trebuchet MS)�6�   $
��Bold"�6�   ��6u   �� *
mDishesG+��5#      �� 5$      .R�5%      �� $
��Wrap=�69   ��6(   �� 69   5&      5(      5)      �� 5+      $ 
Horizontal=�6   $	��Top=�62   $��2q�6G   $��Center=�6R   .+�5,      �� -   5        
 ��Name$
 Check1��5,   �   $ Chercher par nom��6o   $��2q�6�   $��Search with name��6�   
�������$
��Left=�6�    �� 	ClickMode$ Press=�6  $��Trebuchet MS)�6   6   �� *	ToolTip+ �� *Self+6  �� 5-      -	   5        $
 Check2��5-   �   $ Chercher par catégorie��6o   $��2 2 12 2q�6�   $��Search with categ ↬��6�   
�������$��Right=�6�   $��Trebuchet MS)�6   6   �� *	ToolTip+ �� *Self+6  �� 5.      -
   5         ��Name$ Search2��5.   �   $ Barre de recherche��6n   $��2q�6�   $��Right=�6�   $	��250��6�    6   �� *	ToolTip+ �� *Self+6�   5/      �� 51      $ 
Horizontal=�6   $	��Top=�62   $��Right=�6G   .+�52      �� -   5        $ c��52      
�������$��Categories ↬��66   $	��Top=�6M   $��4q�6b   $
��Left=�6m   $��Trebuchet MS)�6�   �� 53      -   5         ��Name$ comboBox��53   �   $% Liste déroulante de catégorie��6o   
���   �$	��Top=�6�   $��4q�6�   $��Right=�6	   �� MaxDropDownHeight$	 100��6%  $	��250��6=  $��Visible=�6I   6   �� *	ToolTip+ �� *Self+.@�54      ��  �� 
IsSelected . $�� ��65   �� 55      $��Régime��6#   �� 56      $	��Bio��6#   �� 57      $��Grand-mère��6#   �� 58      $��Rapides��6#   �� 59      $��Léger��6#   �� 5:      $��Prise de masse��6#   �� 5;      $��Sucré-Salé��6#   �� 5<      $��Légumes��6#   �� 5=      $��Nutritionnel��6#   �� 5>      $��Plaisir��6#   �� 5?      $��Etranger��6#   5@      5A      ]� 5C      .+�5E      � $��Bottom=�6   $��10q�6/    � ColumnDefinitions 5F      �� 5G      $��1* �6+   �� 5H      $��1* �6+   �� 5I      $��1* �6+   .+�5K      �� -   5         ��Name$ button3��5K   �   $% Changer de thème de background��6q   $��2��6�   $��Right=�6�   $	��☀��6�   $��20��6�   $��20��6   6   �� *	ToolTip+ �� *Self+6  �� 5L      -   5        $ Slogan��5L      $��Trebuchet MS)�6,   
�������$��Bottom=�6Y   $-��'When imagination becomes reality... ℗��6t   $��15(�6�   $��3��6�   $��165,0,183,0q�6�   5M      �� 5O      -   5         ��Name$ 
tabControl��5O      
��� ���$��15q�6F   
���   �.@�5Q      �� -   5         ��Name$ Welcome��5Q   �   $ Onglet Welcome��6r   $��	0,10,-8,0q�6�   $��Welcome��6�   $��Trebuchet MS)�6�    6   �� *	ToolTip+ �� *Self+.��5R      �� -   5         ��Name$ 	InnerText��5R   $   $��Center=�67   
�������$��Center=�6e   $����Bienvenue sur Cookination,
Voici une application permettant de créer son propre plat et de le partager avec
d'autres utilisateurs. 
Des idées de régime ? De prise de masse? 
N'hésitez plus, voilà le logiciel qu'il vous faut.  
N'attendez plus, faites déborder votre imagination!��6�   $
��Bold"�6�  $
��Wrap=�6�  $��14(�6�  $��Trebuchet MS)�6�   �� TextAlignment$ Center=�6  $��Italic$�6  5S      �� 5U      -   5        $ General��5U   �   $ Onglet General��6r   $��	General
��6�   $��	5,10,-9,0q�6�   $��Trebuchet MS)�6�    6   �� *	ToolTip+ �� *Self+.��5V         WpfApplication1.Usrctrl  -   5          Name$ Us��5V   (      	MyListBox 64   ��  �� ElementName$ listBox�� � DataContext 6_   �� $ listBox�� �� Path$ SelectedItem���6�   �� $ 
tabControl��$ ActualWidth�5W      �� 5Y      -   5        $ Gallery��5Y   �   $ Onglet Gallerie��6r   $��	Gallery
��6�   $��	5,10,-9,0q�6�   $��Trebuchet MS)�6
   6   �� *	ToolTip+ �� *Self+ 6�   �� $ listBox��$ SelectedItem�.��5Z      �� -   5         ��Name$ Image��5Z       $��0��6/   $
��Fill=�6W   $��30 30 30 30q�6f   ��6<   �� *	Pathimg+6f   5[      �� 5]      -   5        $ Stats��5]   �   $ Onglet Statistiques��6r   $��Statistics
��6�   $��	5,10,-9,0q�6�   $��Trebuchet MS)�6�    6   �� *	ToolTip+ �� *Self+.��5^      �� $��Hidden=�6'   .��5_      �� .+�5`   "   �� -   5         ��Name$ pt��5`   -   $ 
Horizontal=�69   $��Center=�6R   
���   �.+�5a   &   �� $��15q�61   $
��Left=�6=   .+�5b   *   �� -   5        $ p��5b   0   $��Votre poids ↬��6;   
�������$
��Bold"�6f   $��Trebuchet MS)�6x   $��14(�6�   �� 5c   *   -   5        $ poids��5c   �   $ Saisir poids��6�   
��� ���$	��150��6�    62   �� *	ToolTip+ �� *Self+6�   �� 5d   *   -   5        $ t��5d   0   $��Votre taille ↬��6;   
�������$
��Bold"�6g   $��Trebuchet MS)�6y   $��14(�6�   �� 5e   *   -   5        $ taille��5e   �   $ Saisir taille��6�   
��� ��� 62   �� *	ToolTip+ �� *Self+6�   5f   '   �� 5g   &   $ 
Horizontal=�61   $��Right=�6J   .+�5h   *   �� -   5        $
 checkBox��5h   �   $, &Checker si vous êtes un grand sportif��6�   $��Center=�6�   
�������$��5q�6�   $��Grand sportif��6  $��14(�6  $
��Bold"�6)  $��Trebuchet MS)�6;  $	��127��6U   63   �� *	ToolTip+ �� *Self+6U  �� 5i   *   -   5        $ calcul��5i   �   $% Cliquez pour calculer votre IMC��6�   
��� ���$��10q�6�   $��Calculer IMC��6�   
���   �$
��Bold"�6  $��Trebuchet MS)�61  $��48��6K   61   �� *	ToolTip+ �� *Self+6K  5j   '   5k   #   �� 5l   "   $��Center=�6-   $ Vertical=�6J   .+�5m   &   �� $ Vertical=�61   .+�5n   *   �� -   5        $
 Imcc��5n   �   $$ Votre IMC est juste en dessous��6�   $��Votre IMC ↬��6�   
�������$
��Bold"�6�   $��Trebuchet MS)�6�   $��14(�6   60   �� *	ToolTip+ �� *Self+6  �� 5o   *   -   5        $	 Res��5o   g   $��	underline{�64   $ Center=�6P   
�������$
��Wrap=�6�   $��12(�6�   5p   '   �� 5q   &   -    5        $	 Imc��5q   ,   $��14(�69   �� 5r   &   -!   5        $	 Rec��5r   �   $* $Catégories recommandées en dessous��6�   
�������$ ��Categories recommended ↬��6�   $
��Bold"�6�   $��Trebuchet MS)�6  $��14(�6   6,   �� *	ToolTip+ �� *Self+6  �� 5s   &   -"   5        $ Proposition��5s   0   $��	underline{�6E   
�������$��10q�6t   5t   #   5u      5v      5w      �� 5x      -#   5        $ Recipe��5x   �   $ Onglet Recette��6r   $��Recipe
��6�   $��	5,10,-9,0q�6�   $��Trebuchet MS)�6   6   �� *	ToolTip+ �� *Self+ 6�   �� $ listBox��$ SelectedItem�.��5y      �� $��Hidden=�6'   .��5z      �� -$   5        $
 Reci��5z   <   $
��Wrap=�6(   
�������$
��Bold"�6u   ��6J   �� *Recipe+6u   5{      5|      5}      5~      5�      5�      5�      