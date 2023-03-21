namespace FountainOfObjects;

public class DecisionEast : IDecision {
	public void DoDecison(Player player, Caverns maze) {
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
