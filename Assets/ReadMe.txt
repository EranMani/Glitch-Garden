06/05/21
- Master branch
* Added new attacker named fox
* Organized prefabs in folders
* Added transition to game over scene
* Added timer with a UI slider
* Added behaviour which will stop the spawners when the timer is done, and when all attackers are dead the level will end
* Added visual representation to the player when the level is complete or lost
* When level is lost, the player can choose if to restart or go back to the main menu

05/05/21
- Master branch
* Added new defenders to the list - gnome and gravestone
* Defenders projectile now hit and destory objects with the Attacker script attached
* Added new projectile named Zucchini 
* Defenders animation is switching between idle and attack once an Attacker is in their line of sight
* Defenders attack animation has an animation event which instantiate the projectils 

04/05/21
- Master branch
* Added the ability to use the stars to buy defenders or to receive them from the trophy object

01/05/21
- Master branch
* Created parent - child relationship for cactus and lizard models to get more control over the animation placement in the scene
* Added buttons UI to spawn a defender type based on player selection. Each defender has a defender script attached
* In the buttons UI, added text to show a visual for how many stars the player currently have
* In the buttons UI, click on the defender sprite will highlight it with white color

29/04/21
- Master branch
* Added a big list of spritesheets to use
* Added prefabs for defenders, attackers and projectiles with their animations and animators
* Added scripts to handle basic health and damage management including particles when attacker dies
* Added defender spawner
* Added attacker spawner

26/04/21
- Master branch
* Added scenes - splash screen, main menu and level 1
* Adjusted canvas resoultion and scaling in each scene

24/04/21
- Master branch
* Initial commit