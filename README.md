# 2d-Shooter-RogueLike-MasterPiece

(>*.*)>,<(*.*<),(>*.*)>,<(*.*<),(>*.*)>,<(*.*<),(>*.*)>,<(*.*<),(>*.*)>,<(*.*<),(>*.*)>,<(*.*<),

//---------------------------------------------------------------------------------------//

I'm an Analyst Programmer , i will use this project to strenghten my knowledge of english, database, uml design, IA , networking. If you are interested by this project, drop-by and say hi.

It will mostly be a project that I will complete on free times over 1 year or 2  maybe from now so I will be there for a while.

//--------------------------------------------//

Requirement for this project :

You must have basic knowledge of OOP.

Having Visual Studio 2015 with XNA framework.

Wanting to learn and work with people of different language as I mainly speak french , but I can do fine in english.

Knowledge of design patterns and component driven programming would help.

//---------------------------------------------------//

Bonus points if you come from Québec :)

----------------------------------------------------The Project-----------------------------------------

This repository will posses several C# project in different folder, because of that every issue will need a specific description what system it is linked to.

Objectives :

1-Learning more of component programming in c#.
2-Learning more of network gaming.
3-Learning more of project versionning trought GitHub.
4-Learning more about IA.
5-Developping a full Multiplayer-Game with RPG and Shooter-Like Element a bit in the style of RealmOfTheMadDogs.

Tool : Vs 2015 , XNA framework;

If you are asking yourself , why not make one solution per project its because it will be easier to test and modify component on the fly if its all in the same place.And if someone have more interest in only one part of the rep he can allways delete what he dont want.

Here will Follow all the different systems that still need to be developed in case you have particular interest and also for me to keep track. They are put in order of needs;

--- Sprite Loader System --- (Allready have a similar thing in java) --------- Not Started

Descritpion : The game will most-likely end-up having too much assets, as so it will need to be classified and by the same way if we can put all the io function for loading sprite/animation into several different XMl like file it will clean alot the code and help having a low coupling with the application and the game itself.

1. Load from XML like format whatever the disposition of sprite.
2. Be able to do some change to sprite in some rare case.
3. Load Once in memory every sprite.
4. Sub-System to link renderable object with their proper image/animation.
5. Optionnal (some kind of loading progress bar to let the user know how long it will take).

--- Client Version of The game --- (Allready have a similar thing in java but not complete) ---------- Not Started

Description : This part of the developement will need heavy threading due to the high number of sounds and collisions in the game in order to avoid lag in the display,maybe 2 to 4 thread in total.Else than that this part is mostly component integration.

1. Map (Loader/Creator) for new level of map to be displayable.
2. Rendering every sprite properly.
3. Capturing player input to move character.
4. Throwing event like collisions when it occurs;
5. Throwing event like sounds effect properly only once even if 10 similar should happen.
6. Will have to run game-logic system (and later send the info to server when needed)
7. Optional (2d polygon renderer to optimize the game loop) 

--- Game Logic System --- (Allready have few part of it in java) -------- Not Started

Description : This part will old what I call the funniest part of a game. What I mean by an attack pattern is that every player will be able to build is on attack system with the skill/item he have unlocked, so they need to be controled in some sort so that no classes/players are advantaged for example : More attack power = More cooldown ... or more slowness ... something like this idea.....

That part of the game will make it eitheir a success or a fail , all others part are fairly easily doable.

1. Attack Pattern Construction system linked to an UI.
2. IA PATH FINDING.
3. Developping skill system to add more dmg speed and such to players attacks with level up.
4. Movement System for IA.
5. Targeting System for IA.
6. Attack Pattern for IA.
7. Weird Algorithm for boss like and half-boss like to make them feel retro-like not just circling around and shooting
8. Action-like systems to allow players know that a big attack is coming in that direction or in that area even unvoidable attack to make player panik... who knows ? xD

--- Menu/Text Renderer Component ---  ------ Not Started

Description : It will help when making npc talking and when creating new menu. It must help to avoiding playing with pixel everytime we change size of the screen, so it must be relative to the screen size (to a certain limit).

1. Draw fixed sized panel at different location inside an other panel.
2. Able to write text inside those panel without much effort.
3. Able to change the color of those component easily.

--- Collissions Systems --- ----------- Not Started

Description  : This System can be done trought the model folder of the game linked to all other game object;

1. Generate Defaults collisions box to every object depending of their size.
2. Optimisation possible to make it more real.

--- Server version --- (Not much information about it as I need to do reasearch) -----------  Not Started

Description : Multiple thread server.

1. The Server version will need to transmit the less data possible. (Few game-logic might have to be optimized to avoid transfering tons useless informations)
2. Accept multiple client to move around in the most real time possible.
