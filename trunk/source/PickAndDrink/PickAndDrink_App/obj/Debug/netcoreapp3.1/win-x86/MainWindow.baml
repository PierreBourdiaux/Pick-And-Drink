   M S B A M L   `   `   `  ����K  GPickAndDrink_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PickAndDrinkPickAndDrink  5   	       PickAndDrink.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:PickAndDrink     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType   buttonStyle �� BasedOn��%0   '��       7   �� 5
   
   " ��6   8   6$   5      .��5      ]� .+�5   
   � $��Bottom=�6   
���  �� � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��7* �6#   �� 5      $��3* �6#   �� 5      $��3* �6#   .+�5      �� $��img/Attention.png��6   $��20��6/   �� 5      $Q��KL'abus d'alcool est dangeraux pour la santé, à consommer avec modération��6   $��Center=�5      $��center=�63   ���	#FFFFF8F8$��	20,0,20,0q�5   0   $��10(�6C   $��1��6Q   �� 5      $*��$Alcool info service :  0 980 980 930��6   $��Center=�5      $��center=�63   $��2��5      
�������$��10(�6;   �� 5      -   5        $��Sauvegarder et quitter��5      $��3��66   $��	10,0,10,0q�6F   $��3q�6Z   6f   5      � 5   
   $	��Top=�6   
������� 5      �� 5       �� 5!      �� 5"      �� 5#      �� 5$      �� 5%      .+�5'      �� $��img/logo.png��6   $
��10,5q�6*   �� 5(      $��1��62   $
��10,5q�6B   $��Center=�6P   ��6   �� *
Man.Motcle+6P   �� 5)      $��2��6   $�� 10,5q�6'    �� SelectedIndex$ 0��67   $��Center=�6I    �� SelectedValue 6d   �� *Man.Condition+.@�5*      �� .��6   Nom6$   �� 5+      .��6   Ingrédient6+   �� 5,      .��6   Degré d'alcool6/   5-      �� 5.      -   5        $��3��5.      $
��Left=�6&   $��20��6A   $��20��6L   $��0q�6X     defaultButton#��[ 6{   .��5/      �� $��img/loupe.png��6   $��20��61   50      �� 51      -   5        $��Favoris et créations��51      $��4��64   6E   �� 52      -   5        $��Créer un cocktail��52      $��5��61   6B   54      �� 55   
   -   5        
���������55   )   �� *Man.AllCocktailROC+ �� SelectedItem 56      �� *Man.CocktailSélectionné+��57      �� 58      .R�59      �� 5:      ��5<      �� 5=      .R�5>         PickAndDrink.UCBoisson     Texte 6&   �� *Nom+	   	ImageName	 5?   *   �� *Image+5@      5B      �� 5E   
   
 � DataContext
 6   �� *	Navigator+��5F      �� *" SelectedUserControlCreator.Value+  func2WindowPartConverter �� 	Converter# [ 5G      5H      