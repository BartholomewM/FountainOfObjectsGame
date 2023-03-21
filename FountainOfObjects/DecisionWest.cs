namespace FountainOfObjects;

public class DecisionWest : IDecision {
	public void DoDecison(Player player, Caverns maze) {
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
