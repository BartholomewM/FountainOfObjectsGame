using FountainOfObjects;


namespace TestFountainOfObjects;

[TestClass]
public class TestIDecision {

	[TestMethod]
	public void TestHeadSouth() {
		Player player = new Player();
		Caverns maze = new Caverns();

		DecisionSouth south = new DecisionSouth();
		south.DoDecison(player, maze);

		Assert.AreEqual(1, player.Y);
	}


	public void TestHeadSouth2() {
		Player player = new Player();
		Caverns maze = new Caverns();

		DecisionSouth south = new DecisionSouth();
		south.DoDecison(player, maze);
		south.DoDecison(player, maze);

		Assert.AreEqual(2, player.Y);
	}


	public void TestHeadSouth3() {
		Player player = new Player();
		Caverns maze = new Caverns();

		DecisionSouth south = new DecisionSouth();
		south.DoDecison(player, maze);
		south.DoDecison(player, maze);
		south.DoDecison(player, maze);

		Assert.AreEqual(3, player.Y);
	}


	public void TestHeadSouth4() {
		Player player = new Player();
		Caverns maze = new Caverns();

		DecisionSouth south = new DecisionSouth();
		south.DoDecison(player, maze);
		south.DoDecison(player, maze);
		south.DoDecison(player, maze);
		south.DoDecison(player, maze);


		Assert.AreEqual(3, player.Y);
	}


	[TestMethod]
	public void TestHeadNorth1() {
		Player player = new Player();
		Caverns maze = new Caverns();

		DecisionNorth north = new DecisionNorth();
		north.DoDecison(player, maze);

		Assert.AreEqual(0, player.Y);
	}


	[TestMethod]
	public void TestHeadNorth2() {
		Player player = new Player();
		Caverns maze = new Caverns();

		DecisionSouth south = new DecisionSouth();
		south.DoDecison(player, maze);
		south.DoDecison(player, maze);
		south.DoDecison(player, maze);

		Assert.AreEqual(3, player.Y);

		DecisionNorth north = new DecisionNorth();
		north.DoDecison(player, maze);

		Assert.AreEqual(2, player.Y);
	}

	[TestMethod]
	public void TestHeadEast1() {
		Player player = new Player();
		Caverns maze = new Caverns();

		var east = new DecisionEast();
		east.DoDecison(player, maze);

		Assert.AreEqual(1, player.X);
	}

	[TestMethod]
	public void TestHeadEast2() {
		Player player = new Player();
		Caverns maze = new Caverns();

		var east = new DecisionEast();
		east.DoDecison(player, maze);
		east.DoDecison(player, maze);

		Assert.AreEqual(2, player.X);
	}

	[TestMethod]
	public void TestHeadEast3() {
		Player player = new Player();
		Caverns maze = new Caverns();

		var east = new DecisionEast();
		east.DoDecison(player, maze);
		east.DoDecison(player, maze);
		east.DoDecison(player, maze);

		Assert.AreEqual(3, player.X);

		east.DoDecison(player, maze);
		Assert.AreEqual(3, player.X);

	}

	[TestMethod]
	public void TestHeadWest1() {
		Player player = new Player();
		Caverns maze = new Caverns();

		DecisionWest west = new DecisionWest();
		west.DoDecison(player, maze);

		Assert.AreEqual(0, player.X);
	}

	[TestMethod]
	public void TestHeadWest2() {
		Player player = new Player();
		Caverns maze = new Caverns();

		var east = new DecisionEast();
		east.DoDecison(player, maze);
		east.DoDecison(player, maze);
		east.DoDecison(player, maze);

		Assert.AreEqual(3, player.X);

		var west = new DecisionWest();
		west.DoDecison(player, maze);

		Assert.AreEqual(2, player.X);
	}

	[TestMethod]
	public void TestFountainActivation1() {
		Player player = new Player();
		Caverns maze = new Caverns();
		(int x, int y) = maze.MainchamberCoor;

		Assert.IsNotNull(maze.Rooms[x, y]);
		Assert.IsNotNull(maze.Rooms[0, 0]);

		Assert.AreEqual(false, maze.IsFountainActivated);
	}
}
