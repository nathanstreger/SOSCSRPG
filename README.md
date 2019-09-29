# my-first-rpg
This project followed Scott Lilly's tutorial on learning C# by building a simple RPG game. The purpose here was not to create an amazing game, but to learn industry standard design techniques for OOP, like Publish/Subscribe patterns and such. I added several things of my own and have tried to include all of my contributions in the Readme file.

In order to run this on a clone in Visual Studios, it must on a Window's operating system.

Here is a list of my contributions to the tutorials provided by Scott Lilly:

1. Reformatted the UI to display a 9X9 map of the surrounding area. Currently, the player is located in the center square, although no graphic is displayed for the user to see that.

2. Added attributes of strength, intelligence, etc. to the character. Intelligence affects how quickly skill level increases. Constitution increases hit points. Currently no uses for the other attributes are implemented, but that will come at a later time.

3. Added the Skill class and the SkillFactory class, which is used to instantiate the skills that the player learns at the start of the game. Added a feature that allows the player's skill level to increase, thereby increasing the damage of the skill as the player gets better at using it. Displays the level of the skill, and its minimum and maximum damage on the UI.
  
4. Modified the level-up process. User can now choose when to level up instead of it happening automatically. Created a new window for assigning attribute points upon leveling up.
