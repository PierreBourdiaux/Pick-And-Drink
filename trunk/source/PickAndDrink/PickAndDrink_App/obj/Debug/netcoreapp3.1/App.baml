   M S B A M L   `   `   `  ����K  GPickAndDrink_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PickAndDrinkPickAndDrink  5      I)clr-namespace:PickAndDrink_App.convertersPickAndDrink_App.converters  5          PickAndDrink.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ,localclr-namespace:PickAndDrink     5      :conv)clr-namespace:PickAndDrink_App.converters     5        �� 	Resources  5      7  1PickAndDrink_App.converters.String2ImageConverter   string2ImageConverter:   4PickAndDrink_App.converters.Func2WindowPartConverter  func2WindowPartConverter �� 
TargetType  buttonStyle �� Property �� Value  defaultButton  	MainTitle 	 Title  text  TemplateMediumCocktail � RowDefinitions �� 	Converter �� TextAlignment��%�  &	        &	      &	 &     &	 e    &	 �    &	 �    &	 �    &	 J    7   7    5   
   6%     5	   
   6(   �� 5
   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 80��6)   �� 5       � ��$
 10,5q�6'   �� 5       � ��$
 5,10q�6(   �� 5       � ��$ Bahnschrift Condensed)�6+   �� 5       � ��$ 16(�6)   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   5      �� 5   
   " ��6   .�5      ��  � ��$ Bahnschrift Condensed)�6+   �� 5       � ��$ 42(�6)   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�62   �� 5       � ��$ Center=�64   5      �� 5   
   " ��6   .�5      ��  � ��$ 	Underline{�60   �� 5        � ��$ Bahnschrift Condensed)�6+   �� 5!       � ��$ 36(�6)   �� 5"       � ��$ 5,10,0,0q�6'   5#      �� 5$   
   " ��6   .�5%      ��  � ��$ Bahnschrift Condensed)�6+   �� 5&       � ��$ 24(�6)   �� 5'       � ��$ 2,3,0,0q�6'   5(      �� 5+   
   .R�5,      �  5-      �� 5.      �� 5/      .+�51      �� $
��auto��6c   $	��200��6p   $��0��6}   $
��20,5q�6�   ��6   �� *Image+8   6�   �� 52      $��1��61   $ Center=�6>   $��Center=�6U   $��	10,3,10,6q�6p   8�� ��6   �� *Nom+6�   53      54      55      56      