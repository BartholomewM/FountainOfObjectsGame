namespace FountainOfObjects;

public class DecisionActivate : IDecision {
	public void DoDecison(Player player, Caverns maze) {
		(int x, int y) = maze.MainchamberCoor;

		if (x == player.X && y == player.Y) {
			maze.IsFountainActivated = true;

		}
	}
}