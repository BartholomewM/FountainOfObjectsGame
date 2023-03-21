using FountainOfObjects;


public class Program {
	public static void Main(string[] args) {
		ShowObjective();
		//string difficulty = ChooseDifficulty();

		// to test the game there is default constructor with hard coded location of fountain
		Caverns maze = new Caverns();
		Player player = new Player();

		//Console.WriteLine(maze.IsFountainActivated);

		MainGameProgram(player, maze);
	}

	/// <summary>
	/// Main program function to printing description of the game
	/// 
	/// </summary>
	private static void ShowObjective() {
		string s = "You enter the Cavern of Objects, a maze of rooms filled with dangerous pits in search\r\n" +
					"of the Fountain of Objects.\r\n" +
					"Light is visible only in the entrance, and no other light is seen anywhere in the caverns.\r\n" +
					"You must navigate the Caverns with your other senses.\r\n" +
					"Find the Fountain of Objects, activate it, and return to the entrance.";
		
		Console.WriteLine(s);
		Console.WriteLine();
		Console.WriteLine("Possible decisions are : west, east, north, south, activate");
		Console.WriteLine("activate command works only in Fountain room");
		Console.WriteLine("if you try using, for example north command, when you are at the north wall your character just won't do anything");
	}


	private static string ChooseDifficulty() {
		string? str = "";
		bool b = true;

		Console.WriteLine("Choose the size of the Labirynth (type it)");
		Console.WriteLine("The sizes are : ");
		Console.WriteLine("1. small");
		Console.WriteLine("2. medium");
		Console.WriteLine("3. large");

		while (b) {
			str = Console.ReadLine();

			if (str is null) {
				Console.WriteLine("Something wnt wrong, please try again");
			} 
			else {
				str = str.ToLower();

				switch (str) {
					case "small":
						b = false;
						break;

					case "medium":
						b = false;
						break;

					case "large":
						b = false;
						break;

					default:
						Console.WriteLine("Something went wrong, please try again");
						break;
				}
			}
		}

		return str!;
	}


	private static void CurrentSituation(Player player, Caverns maze) {
		int x = player.X; 
		int y = player.Y;

		string state = maze.Rooms[x, y].Sense;

		Console.WriteLine("----------------------------------------------------------------------------------");
		Console.WriteLine($"You are in the room at(Row = {x}, Column = {y}).");
		Console.Write(state);
		Console.WriteLine("What do you want to do?");
	}


	private static IDecision GetDecision() {
		while (true) {
			string? readStr = Console.ReadLine();

			switch (readStr) {
				case "east":
					return new DecisionEast();

				case "west":
					return new DecisionWest();

				case "north":
					return new DecisionNorth();

				case "south":
					return new DecisionSouth();

				case "activate":
					return new DecisionActivate();

				default: 
					Console.WriteLine("Something went wrong");
					Console.WriteLine("Please try again :) ");
					break;
			}
		}
	}


	private static void MainGameProgram(Player player, Caverns maze) {

		while (true) {
			CurrentSituation(player, maze);
			var decision  = GetDecision();
			decision.DoDecison(player, maze);

			if (maze.IsFountainActivated && player.X == 0 && player.Y == 0) {
				break;
			}
		}

		Console.WriteLine("You win!!!");
		Console.ReadKey();
	}
}