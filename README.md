# my-first-rpg
This project followed Scott Lilly's tutorial on learning C# by building a simple RPG game. The purpose here was not to create an amazing game, but to learn industry standard design techniques for OOP, like Publish/Subscribe patterns and such. I added several things of my own and have tried to include all of my contributions in the Readme file.

In order to run this on a clone in Visual Studios, it must on a Window's operating system. Run it using the WPFUI.

Here is a list of my contributions to the tutorials provided by Scott Lilly:

1. Reformatted the UI to display a 9X9 map of the surrounding area. Current total map size is 20X20. Currently, the player is located in the center square of the displayed 9X9 grid, although no graphic is displayed for the user to see that.

2. Added the Skill class and the SkillFactory class, which is used to instantiate the skills that the player learns at the start of the game. Added a feature that allows the player's skill level to increase, thereby increasing the damage of the skill as the player gets better at using it. Displays the level of the skill, and its minimum and maximum damage on the UI.

3. Added attributes of strength, intelligence, etc. to the character. Intelligence affects how quickly skill level increases. Constitution increases hit points. Currently no uses for the other attributes are implemented, but that will come at a later time.
  
4. Modified the level-up process. User can now choose when to level up instead of it happening automatically. Created a new window for assigning attribute points upon leveling up.

Future Plans:
  Adapt the UI code (keep the display the same though), and change the map variables to an array so that I don't have to create 81 separate variables. Current method works, but is a pain to have to change if I want to make the map bigger or smaller. This will require rewriting several different classes to accept the array.

  Add skills to the monsters. Monsters inherit from the living entity class, so this won't be difficult. Would need a way to figure out the enemy combat AI though, and when/how often they use the skills.
  
  Make the attributes, other than Constitution and Intelligence which have already been implemented, affect the character's abilities.
  
  Refactor the code. Dozens of functions need to be made into deterministic functions: minimal side effects, and always return an output.
