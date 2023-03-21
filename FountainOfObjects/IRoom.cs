namespace FountainOfObjects;


public interface IRoom {
	public RoomType Type { get; }
	public string Sense { get; }
}


/// <summary>
/// simple enumeration to different types of rooms
/// </summary>
public enum RoomType { Normal, Fountain, Entrance }
