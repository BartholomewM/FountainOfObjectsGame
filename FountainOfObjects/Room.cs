namespace FountainOfObjects;

public class Room : IRoom {
	private string _state = "";

	public RoomType Type { get => RoomType.Normal; }
	public string Sense { get => _state; }
}
