   M S B A M L   `   `   `  ����J  FMultiplayerMain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MultiplayerMainMultiplayerMain  5   	       MultiplayerMain.Game1   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:MultiplayerMain     5   	   -   5          � Title$  Words��5   	   $��309.609��6   $��614.646��6(    � 
ResizeMode$ NoResize=�6Q   $��Disabled=�6g    � WindowStartupLocation$ CenterScreen=�6�    J� SnapsToDevicePixels . .��5	      � -   5         �Name$ MainGrid��5	      ���	#FF343434 � RowDefinitions 5
   
   .+�5   
   � -   5        $ Client1��5      $
��Left=�6    $	��249��6;   $��	10,10,0,0q�6H   $	��Top=�6[   $	��287��6s   ���	#FFA4A4A4$��2��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .+�5      �� -   5         ��Name$ 
City_tb_p1��5      $
��Left=�6*   $��53��6E   $��
10,113,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��267��6�   $��30(�6�   
	 � Tag$	 
city_input��6�   $��0��6�   �� 5      -   5        
 ��Name$
 	button_P1��5      $��	Your turn��6(   $
��Left=�6<   $��
10,183,0,0q�6W   $	��Top=�6k   $	��267��6�   $��56��6�   $��30(�6�   �� 5      -   5         ��Name$ City_label_p1��5      $�� ��6+   $
��Left=�66   $��	10,62,0,0q�6Q   $	��Top=�6d   $��46��6|   $	��267��6�   $��24(�6�   $��Center=�6�   $	 city_lbl��6�   �� 5      -   5        $ 	scores_P1��5      $��0��6'   $��Center=�63   $��177,10,10,0q�6P   $	��Top=�6e   $	 
scores_lbl��6}   $��20(�6�   $
��100 ��6�   $��Right=�5      �� 5      -   5        $ label_P1��5      $��Your scores��6&   $
��Left=�6<   $��	10,19,0,0q�6W   $	��Top=�6j   $	��130��6�   5      � 5   
   -	   5        $ Client2��5      $
��Left=�6    $	��249��6;   $��
302,10,0,0q�6H   $	��Top=�6\   $	��287��6t   ���	#FFA4A4A4$��2��6�    5        5      .+�5      �� -
   5        $ 
City_tb_p2��5      $
��Left=�6*   $��53��6E   $��
10,113,0,0q�6Q   $
 Wrap=�6e   $	��Top=�6y   $	��267��6�   $��30(�6�   $	 
city_input��6�   $��0��6�   �� 5      -   5        $
 	button_P2��5      $��	Your turn��6(   $
��Left=�6<   $��
10,183,0,0q�6W   $	��Top=�6k   $	��267��6�   $��56��6�   $��30(�6�   �� 5      -   5        $ City_label_p2��5      $�� ��6+   $
��Left=�66   $��	10,62,0,0q�6Q   $	��Top=�6d   $��46��6|   $	��267��6�   $��24(�6�   $��Center=�6�   $	 city_lbl��6�   �� 5      -   5        $ 	scores_P2��5      $��0��6'   $
��Left=�63   $��
177,10,0,0q�6N   $	��Top=�6b   $	 
scores_lbl��6z   $��20(�6�   $	��100��6�   $��Right=�6�   �� 5      -   5        $ label_P2��5      $��Your scores��6&   $
��Left=�6<   $��	10,19,0,0q�6W   $	��Top=�6j   $	��130��6�   5       5"      5#      