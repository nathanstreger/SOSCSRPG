   M S B A M L   `   `   `  ���� 
  EngineE/clr-namespace:Engine.ViewModels;assembly=EngineEngine.ViewModels  	 WPFUI   WPFUI.LevelUpScreen   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     F
viewModels/clr-namespace:Engine.ViewModels;assembly=Engine       � WindowStartupLocation$  CenterOwner=�$
��11pt(� � Title$ LevelUpScreen��$	��480��$	��640��.���  � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto � � ColumnDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��2��$
��Left=�$��Center=�$��Skill Points Available:���� $��0��$��2��$��Center=����� *$"CurrentPlayer.AvailableSkillPoints+�� $��1��$��0��$��Center=�$��Strength���� $��1��$��1��$��Center=����� *CurrentPlayer.Strength+�� $��2��$��0��$��Center=�$��	Dexterity���� $��2��$��1��$��Center=����� *CurrentPlayer.Dexterity+�� $��3��$��0��$��Center=�$��Constitution���� $��3��$��1��$��Center=����� *CurrentPlayer.Constitution+�� $��4��$��0��$��Center=�$��Intelligence���� $��4��$��1��$��Center=����� *CurrentPlayer.Intelligence+�� $��5��$��0��$��Center=�$��Wisdom���� $��5��$��1��$��Center=����� *CurrentPlayer.Wisdom+�� $��6��$��0��$��Center=�$
��Luck���� $��6��$��1��$��Center=����� *CurrentPlayer.Luck+�� -   $��1��$��2��$��+1���� -   $��2��$��2��$��+1���� -   $��3��$��2��$��+1���� -   $��4��$��2��$��+1���� -   $��5��$��2��$��+1���� -   $��6��$��2��$��+1���� -   $��7��$��0��$��Close��