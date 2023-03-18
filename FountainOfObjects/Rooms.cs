

namespace FountainOfObjects; 

public interface IRoom {
	public RoomType Type { get; }
	public string Sense { get; }
}


public class Room : IRoom {
	public RoomType Type { get => RoomType.Normal; }
	public string Sense { get => ""; }
}


public class EntranceRoom : IRoom {
	public RoomType Type { get => RoomType.Entrance; }

	public string Sense { get => "You see light coming from the cavern entrance.\n"; }
}


//public class Maelstroms : IRoom {

//}


public class FountainRoom : IRoom {
	private bool _isFountainActivated = false;
	public RoomType Type { get => RoomType.Fountain; }
	public bool IsFountainActivated { get => _isFountainActivated; set => _isFountainActivated = value; }


	public string Sense {
		get {
			string s = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!\n";
			if (_isFountainActivated) {
				s = "You hear the rushing waters from the Fountain of Objects. It has been reactivated!\n";
			}
			else {
				s = "You hear water dripping in this room. The Fountain of Objects is here!\n";
			}

			return s;
		}
	}
}


public enum RoomType { Normal, Fountain, Entrance }
