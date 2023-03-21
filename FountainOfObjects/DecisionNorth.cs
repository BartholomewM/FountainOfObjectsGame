namespace FountainOfObjects;

public class DecisionNorth : IDecision {
	public void DoDecison(Player player, Caverns maze) {
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
