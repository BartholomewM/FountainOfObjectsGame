﻿
namespace FountainOfObjects;

public class Player {
	// position of the player
	private int _x;
	private int _y;

	public int X { get => _x; set => _x = value; }
	public int Y { get => _y; set => _y = value; }

	public Player() {
		_x = 0;
		_y = 0;
	}
}

