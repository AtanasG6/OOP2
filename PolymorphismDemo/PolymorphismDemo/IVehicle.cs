using System.Threading.Tasks;

namespace PolymorphismDemo
{
	public interface IVehicle
	{
		string Model { get; }

		string Drive();
	}
}
