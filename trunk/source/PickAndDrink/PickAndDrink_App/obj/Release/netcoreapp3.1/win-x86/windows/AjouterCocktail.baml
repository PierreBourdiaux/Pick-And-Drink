   M S B A M L   `   `   `  ���� K  GPickAndDrink_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:PickAndDrink_App.windowsPickAndDrink_App.windows  N JPickandDrink_Modele, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:PickandDrink_Modele;assembly=PickandDrink_ModelePickandDrink_Modele O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem .    (PickAndDrink_App.windows.AjouterCocktail   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     8local&clr-namespace:PickAndDrink_App.windows     Mmy>clr-namespace:PickandDrink_Modele;assembly=PickandDrink_Modele     9system&clr-namespace:System;assembly=mscorlib       � Title$  AjouterCocktail��$	��450��$	��800�� � 	Resources  S� 
MethodName S� 
ObjectTypeU QSystem.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a  System.Enum   difEnum S� MethodParameters M� Type   PickandDrink_Modele.Niveau  typeEnum#  PickandDrink_Modele.TypeUnite �� 
TargetType  text �� BasedOn��%�   &	        &	 (     '�� P     7  S� $ 	GetValues��"   M� "  S� $ 	GetValues��"   M� "  �� " ��8   .���� .��]� .+��� $��Ajout de cocktail��  	MainTitle#��[ $	��Top=�� $��Bottom=� � ColumnDefinitions �� �� .+��� -   $��Ajouter��  buttonStyle#��[ �� -   $��Annuler��$��1��#��[ �� $��Center=� 	 �� Property
 �� Value��%q   '��       �� " ��.��� 	 � ��$
 Bahnschrift Condensed)��� 	 � ��$
 24(��� 	 � ��$
 2,3,0,0q�.+��� $$��Information sur le cocktail : �� 	 Title#��[ $��Center=�� $��Center=�.+��� $��Nom : ��#��[ �� $	��150������ *cocktail.Nom+� $��Center=�$��4q�.+��� $��Image : ��#��[ �� -   $��	Parcourir��$
��Left=��� $��Detail de la recette�� �� TextAlignment$ Center=�#��[ �  ��%.  '��       '�� �     �� " ��.��� 	 � ��$
 Right=��� 	 � ��$
 Center=��� 	 � ��$
 Bahnschrift Condensed)��� 	 � ��$
 24(��� 	 � ��$
 2,3,0,0q��� " ��.��� 	 � ��$

 Left=��� 	 � ��$
 Center=��� 	 � ��$
 5q��� 	 � ��$
 5q��� 	 � ��$	
 150�� �� $��* ��� $��2* � � RowDefinitions �� �� �� �� �� �� �� �� �� .+��� $��Nom de la recette : ��$��0��$��0���� $��1��$��0������ *r.Nom+�� $��Description : ��$��0��$��1���� $��50��$��1��$��1������ *r.Desc+�� $��Degrès d'alcool : ��$��0��$��2���� $��1��$��2������ *
r.DegAlc+�� $��Difficulté : ��$��0��$��3���� $��1��$��3������  �� Source# [   �� SelectedItem �� *r.Difficulté+�� $��
Calorie : ��$��0��$��4���� $��1��$��4������ *	r.Calorie+�� $��Ingrédients :��#��[ $��2��$��5���� $��6��$��2������ *ing+���� .R��  �� $��3* ��� $��2* ��� $��2* �.+��� $��	0,0,10,10q����� *Nom+�� $��1��$��	0,0,10,10q����� *Qte+�� $��2��$��	0,0,10,10q�$��40������ # [  �� *Unite+�� $��Les étapes :��#��[ $��2��$��7���� $��2��$��8������ *etapes+���� .R��  �� $��* ��� $	��10* �.+��� $��0��$��	0,0,10,10q�$��Center=�#��[ ���� *Num+�� $��1��$��	0,0,10,10q�$	��400������ *Desc+