using FountainOfObjects;


namespace TestFountainOfObjects;

[TestClass]
public class TestMaze {

	[TestMethod]
	public void TestGetFountainActivation() {
		Caverns maze = new Caverns();

		var state = maze.IsFountainActivated;

		Assert.IsFalse(state);
	}

	[TestMethod]
	public void TestInit() {
		Caverns maze = new Caverns();

		Assert.IsNotNull(maze.Rooms[0, 0]);
		Assert.IsNotNull(maze.Rooms[1, 0]);
		Assert.IsNotNull(maze.Rooms[2, 0]);
		Assert.IsNotNull(maze.Rooms[3, 0]);

		Assert.IsNotNull(maze.Rooms[0, 3]);
		Assert.IsNotNull(maze.Rooms[1, 1]);
		Assert.IsNotNull(maze.Rooms[3, 0]);

	}
}
