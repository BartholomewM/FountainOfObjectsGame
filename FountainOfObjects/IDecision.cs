using FountainOfObjects;
using System.Security.Cryptography.X509Certificates;

namespace FountainOfObjects;


public interface IDecision {

	public void DoDecison(Player player, Caverns maze);
}
