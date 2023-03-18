using FountainOfObjects;

namespace TestFountainOfObjects;


[TestClass]
public class TestPlayer {
	[TestMethod]
	public void TestPositionGetInit() {
		Player player = new Player();
		int x = player.X;
		int y = player.Y;

		Assert.AreEqual(0, x);
		Assert.AreEqual(0, y);
		Assert.AreEqual(x, player.X);
		Assert.AreEqual(y, player.Y);
		x += 1;
		y += 1;
		Assert.AreNotEqual(x, player.X);
		Assert.AreNotEqual(y, player.Y);
	}

	[TestMethod]
	public void TestPositionSet() {
		Player player = new Player();
		player.X = 20;
		player.Y = 10;


		Assert.AreEqual(20, player.X);
		Assert.AreEqual(10, player.Y);
	}

	
}