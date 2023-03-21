It is a game specified in The C# Player’s Guide, 5th Edition. 
Here is aouthor implementation :
https://csharpplayersguide.com/solutions/5th-edition/fountain-of-objects-combined

And heres specification from the book:

The Fountain of Objects game is a 2D grid-based world full of rooms. Most rooms are empty, but a few 
are unique rooms. One room is the cavern entrance. Another is the fountain room, containing the 
Fountain of Objects.
The player moves through the cavern system one room at a time to find the Fountain of Objects. They 
activate it and then return to the entrance room. If they do this without falling into a pit, they win the 
game.
Unnatural darkness pervades the caverns, preventing both natural and human-made light. The player 
must navigate the caverns in the dark, relying on their sense of smell and hearing to determine what 
room they are in and what dangers lurk in nearby rooms.
This challenge serves as the basis for the other challenges in this level. It must be completed before the 
others can be started. The requirements of this game are listed below

Objectives:
- The world consists of a grid of rooms, where each room can be referenced by its row and column. 
North is up, east is right, south is down, and west is left

- The game’s flow works like this: The player is told what they can sense in the dark (see, hear, smell). 
Then the player gets a chance to perform some action by typing it in. Their chosen action is resolved (the player moves, state of things in the game changes, checking for a win or a loss, etc.). Then the 
loop repeats

- Most rooms are empty rooms, and there is nothing to sense

- The player is in one of the rooms and can move between them by typing commands like the 
following: “move north”, “move south”, “move east”, and “move west”. The player should not be able 
to move past the end of the map

- The room at (Row=0, Column=0) is the cavern entrance (and exit). The player should start here.The 
player can sense light coming from outside the cavern when in this room. (“You see light in this room
coming from outside the cavern. This is the entrance.”)

- The room at (Row=0, Column=2) is the fountain room, containing the Fountain of Objects itself. The 
Fountain can be either enabled or disabled. The player can hear the fountain but hears different 
things depending on if it is on or not. (“You hear water dripping in this room. The Fountain of Objects 
is here!” or “You hear the rushing waters from the Fountain of Objects. It has been reactivated!”) The 
fountain is off initially. In the fountain room, the player can type “enable fountain” to enable it. If the 
player is not in the fountain room and runs this, there should be no effect, and the player should be 
told so.

- The player wins by moving to the fountain room, enabling the Fountain of Objects, and moving back 
to the cavern entrance. If the player is in the entrance and the fountain is on, the player wins

- Use different colors to display the different types of text in the console window. For example, 
narrative items (intro, ending, etc.) may be magenta, descriptive text in white, input from the user 
in cyan, text describing entrance light in yellow, messages about the fountain in blue.

- An example of what the program might look like is shown below:
___

Additional features:

Pits:

The Cavern of Objects is a dangerous place. Some rooms open up to bottomless pits. Entering a pit 
means death. The player can sense a pit is in an adjacent room because a draft of air pushes through the 
pits into adjacent rooms. Add pit rooms to the game. End the game if the player stumbles into one.
Objectives:
- Add a pit room to your 4×4 cavern anywhere that isn’t the fountain or entrance room. 
- Players can sense the draft blowing out of pits in adjacent rooms (all eight directions): “You feel a 
draft. There is a pit in a nearby room.”
- If a player ends their turn in a room with a pit, they lose the game.
- Note: When combined with the Small, Medium, or Large challenge, add one pit to the 4×4 world,two
pits to the 6×6 world, and four pits to the 8×8 world, in locations of your choice.
____

Maelstroms:

The Uncoded One knows the significance of the Fountain of Objects and has placed minions in the 
caverns to defend it. One of these is the maelstrom—a sentient, malevolent wind. Encountering a 
maelstrom does not result in instant death, but entering a room containing a maelstrom causes the 
player to be swept away to another room. The maelstrom also moves to a new location. If the player is 
moved to another dangerous location, such as a pit, that room’s effects will happen upon landing in that 
room.
A player can hear the growling and groaning of a maelstrom from a neighboring room (including 
diagonals), which gives them a clue to be careful.
Modify the basic Fountain of Objects game in the ways below to add maelstroms to the game.
Objectives:
- Add a maelstrom to the small 4×4 game in a location of your choice.
- The player can sense maelstroms by hearing them in adjacent rooms. (“You hear the growling and 
groaning of a maelstrom nearby.”)
- If a player enters a room with a maelstrom, the player moves one space north and two spaces east, 
while the maelstrom moves one space south and two spaces west. When the player is moved like 
this, tell them so. If this would move the player or maelstrom beyond the map’s edge, ensure they 
stay on the map. (Clamp them to the map, wrap around to the other side, or any other strategy.)
- Note: When combined with the Small, Medium, or Large challenge, place one maelstrom into the 
medium-sized game and two into the large-sized game.
__________________________________________

Amaroks:

The Uncoded One has also placed amaroks in the caverns to protect the fountain from people like you.
Amaroks are giant, rotting, wolf-like creatures that stalk the caverns.When players enter a room with an 
amarok, they are instantly killed, and the game is over. Players can smell an amarok in any adjacent room 
(all eight directions), which tells them that an amarok is nearby.
Modify the basic Fountain of Objects game as described below.
Objectives:
- Amarok locations are up to you. Pick a room to place an amarok aside from the entrance or fountain 
room in the small 4×4 world.
- When a player is in one of the eight spaces adjacent to an amarok, a message should be displayed 
when sensing surroundings that indicate that the player can smell the amarok nearby. For example, 
“You can smell the rotten stench of an amarok in a nearby room.”
- When a player enters a room with an amarok, the player dies and loses the game.
- Note: When combined with the Small, Medium, or Large challenge, place two amaroks in the medium 
level and three in the large level in locations of your choosing
___

Getting Armed:

Note: 

Requires doing the Maelstroms or Amaroks challenge first.
The player brings a bow and several arrows with them into the Caverns.The player can shoot arrows into 
the rooms around them, and if they hit a monster, they kill it, and it should no longer impact the game.

Objectives:
- Add the following commands that allow a player to shoot in any of the four directions: shoot north, 
shoot east, shoot south, and shoot west.When the player shoots in one of the four directions, an arrow 
is fired into the room in that direction. If a monster is in that room, it is killed and should not affect 
the game anymore. They can no longer sense it, and it should not affect the player.
- The player only has five arrows and cannot shoot when they are out of arrows. Display the number 
of arrows the player has when displaying the game’s status before asking for their action.
___


Getting Help:


The player should not be left guessing about how to play the game. This challenge requires adding two 
key elements that make playing the Fountain of Objects easier: introductory text that explains the game 
and a help command that lists all available commands and what they each do.
Objectives:
- When the game starts, display text that describes the game shown below:
- If you chose to do the Pits challenge, add the following to the description: “Look out for pits. You 
will feel a breeze if a pit is in an adjacent room. If you enter a room with a pit, you will die.”
- If you chose to do the Maelstroms challenge, add the following to the description: “Maelstroms are 
violent forces of sentient wind. Entering a room with one could transport you to any other location 
in the caverns. You will be able to hear their growling and groaning in nearby rooms.”
- If you chose to do the Amaroks challenge, add the following to the description: “Amaroks roam the 
caverns. Encountering one is certain death, but you can smell their rotten stench in nearby rooms.”
- If you chose to do the Getting Armed challenge, add the following to the description: “You carry with 
you a bow and a quiver of arrows. You can use them to shoot monsters in the caverns but be warned: 
you have a limited supply.”
- When the player types the command help, display all available commands and a short description 
of what each does. The complete list of commands will depend on what challenges you complete.
____
