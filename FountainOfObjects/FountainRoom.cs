namespace FountainOfObjects;


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
