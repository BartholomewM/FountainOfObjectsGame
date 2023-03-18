namespace FountainOfObjects;




public class CavernsOfObjects {
	// fields
	// the maze where game take place
	private IRoom[,] _rooms;
	// bound of the world, useful in asserting player does not move outside maze
	// boun is greater than max idx
	private int _bound;
	private int _fountainHorizontalPosition;
	private int _fountainVerticalPosition;

	// getters and eventually setters
	public IRoom[,] Rooms { get => _rooms; }
	public int Bound { get => _bound; }
	public (int x, int y) MainchamberCoor { get => (_fountainHorizontalPosition, _fountainVerticalPosition); }
	public bool IsFountainActivated {
		get {
			return (_rooms[_fountainHorizontalPosition, _fountainVerticalPosition] as FountainRoom)!.IsFountainActivated;
		}

		set {
			(_rooms[_fountainHorizontalPosition, _fountainVerticalPosition] as FountainRoom)!.IsFountainActivated = value;
		}
	}


	public CavernsOfObjects(string size) {
		int sizeNum = 4;

		sizeNum = size switch { "small" => 4, "medium" => 6, "large" => 8 };

		_rooms = new IRoom[sizeNum, sizeNum];
		_rooms[0, 0] = new EntranceRoom();
		_bound = sizeNum;

		// This gives True
		//IRoom[,] r = new IRoom[2, 2];
		//Console.WriteLine(r[1, 1] == null);

		Random rnd = new Random();
		int x_pos = rnd.Next(1, _bound);
		int y_pos = rnd.Next(1, _bound);

		_rooms[x_pos, y_pos] = new FountainRoom();
		_setDeafultRooms();
	}


	public CavernsOfObjects(int x = 0, int y = 2, int sizeNum = 4) {
		_rooms = new IRoom[sizeNum, sizeNum];
		_rooms[0, 0] = new EntranceRoom();
		_bound = sizeNum;

		// This gives True
		//IRoom[,] r = new IRoom[2, 2];
		//Console.WriteLine(r[1, 1] == null);

		_fountainHorizontalPosition = x;
		_fountainVerticalPosition = y;

		_rooms[_fountainHorizontalPosition, _fountainVerticalPosition] = new FountainRoom();
		_setDeafultRooms();
	}


	private void _setDeafultRooms() {
		for (int i = 0; i < _bound; i++) {
			for (int j = 0; j < _bound; j++) {
				if (_rooms[i, j] is null) {
					_rooms[i, j] = new Room();
				}
			}
		}
	}

}
