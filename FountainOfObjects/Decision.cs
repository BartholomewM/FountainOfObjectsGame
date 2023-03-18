using FountainOfObjects;
using System.Security.Cryptography.X509Certificates;

namespace FountainOfObjects;


public interface IDecision {
	public void DoDecison(Player player, CavernsOfObjects maze);
}


public class DecisionNorth : IDecision {
	public void DoDecison(Player player, CavernsOfObjects maze) {
		var y = player.Y;
		y -= 1;

		if (y < 0) {
			player.Y = 0;
		}
		else {
			player.Y = y;
		}
	}

	public override string ToString() {
		return "move north";
	}
}


public class DecisionSouth : IDecision {
	public void DoDecison(Player player, CavernsOfObjects maze) {
		var y = player.Y;
		var bound = maze.Bound;
		y += 1;

		if (y >= bound) {
			player.Y = bound-1;
		}
		else {
			player.Y = y;
		}
	}

	public override string ToString() {
		return "move south";
	}
}


public class DecisionEast : IDecision {
	public void DoDecison(Player player, CavernsOfObjects maze) {
		var x = player.X;
		var bound = maze.Bound;
		x += 1;

		if (x >= bound) {
			player.X = bound - 1;
		}
		else {
			player.X = x;
		}
	}


	public override string ToString() {
		return "move east";
	}
}


public class DecisionWest : IDecision {
	public void DoDecison(Player player, CavernsOfObjects maze) {
		var x = player.X;
		var bound = maze.Bound;
		x -= 1;

		if (x <= 0) {
			player.X = 0;
		}
		else {
			player.X = x;
		}
	}


	public override string ToString() {
		return "move west";
	}
}


public class DecisionActivate : IDecision {
	public void DoDecison(Player player, CavernsOfObjects maze) {
		(int x, int y) = maze.MainchamberCoor;

		if (x == player.X && y == player.Y) {
			maze.IsFountainActivated = true;

		}
	}
}