namespace FountainOfObjects;

public class EntranceRoom : IRoom {
	public RoomType Type { get => RoomType.Entrance; }

	public string Sense { get => "You see light coming from the cavern entrance.\n"; }
}
