namespace FountainOfObjects;

public class DecisionSouth : IDecision {
	public void DoDecison(Player player, Caverns maze) {
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
