   M S B A M L   `   `   `  ����A  =Engine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE/clr-namespace:Engine.ViewModels;assembly=EngineEngine.ViewModels  5   	   	 WPFUI   WPFUI.LevelUpScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   F
viewModels/clr-namespace:Engine.ViewModels;assembly=Engine     5   	     � WindowStartupLocation$  CenterOwner=�5	   	   $
��11pt(�5
   	    � Title$ LevelUpScreen��5   	   $	��480��6   $	��640��6,   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��2��5      $
��Left=�5       $��Center=�5!      $��Skill Points Available:��5"      �� 5#   
   $��0��6   $��2��5$      $��Center=�5%      ��5&      �� *$"CurrentPlayer.AvailableSkillPoints+�� 5(   
   $��1��6   $��0��5)      $��Center=�5*      $��Strength��5+      �� 5,   
   $��1��6   $��1��5-      $��Center=�5.      ��5/      �� *CurrentPlayer.Strength+�� 50   
   $��2��6   $��0��51      $��Center=�52      $��	Dexterity��53      �� 54   
   $��2��6   $��1��55      $��Center=�56      ��57      �� *CurrentPlayer.Dexterity+�� 58   
   $��3��6   $��0��59      $��Center=�5:      $��Constitution��5;      �� 5<   
   $��3��6   $��1��5=      $��Center=�5>      ��5?      �� *CurrentPlayer.Constitution+�� 5@   
   $��4��6   $��0��5A      $��Center=�5B      $��Intelligence��5C      �� 5D   
   $��4��6   $��1��5E      $��Center=�5F      ��5G      �� *CurrentPlayer.Intelligence+�� 5H   
   $��5��6   $��0��5I      $��Center=�5J      $��Wisdom��5K      �� 5L   
   $��5��6   $��1��5M      $��Center=�5N      ��5O      �� *CurrentPlayer.Wisdom+�� 5P   
   $��6��6   $��0��5Q      $��Center=�5R      $
��Luck��5S      �� 5T   
   $��6��6   $��1��5U      $��Center=�5V      ��5W      �� *CurrentPlayer.Luck+�� 5Y   
   -   5        $��1��5Y      $��2��5Z      $��+1��5[      5\      �� 5]   
   -   5        $��2��5]      $��2��5^      $��+1��5_      5`      �� 5a   
   -   5        $��3��5a      $��2��5b      $��+1��5c      5d      �� 5e   
   -   5        $��4��5e      $��2��5f      $��+1��5g      5h      �� 5i   
   -   5        $��5��5i      $��2��5j      $��+1��5k      5l      �� 5m   
   -   5        $��6��5m      $��2��5n      $��+1��5o      5p      �� 5r   
   -   5        $��7��5r      $��0��5s      $��Close��5t      5u      5w      5x      