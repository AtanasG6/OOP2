namespace OOPTask2
{
	public class House : Building
	{
		private readonly IReadOnlyCollection<Room> _rooms;
		private readonly Person _owner;

		public House(double height, string color, List<Room> rooms, Person owner) 
			: base(1, height, color)
		{
			this.Rooms = rooms;
			this.Area = this.Rooms.Sum(r => r.Area); 
			this.Owner = owner;
		}


		public IReadOnlyCollection<Room> Rooms 
		{
			get
			{
				return this._rooms;
			}
				 
			private init
			{
				if (value is null || value.Any(r => r is null))
				{
					throw new ArgumentException("Invalid input!");
				}
				this._rooms = value;
			} 
		}

		public Person Owner
		{
			get 
			{ 
				return  this._owner; 
			}
			private init 
			{
				if (value is null)
				{
					throw new ArgumentException("Invalid input!");
				}
				this._owner = value;
			}
		}

		public override string ToString()
		{
			return base.ToString() + $" The rooms are {string.Join(", ", this.Rooms.Select(r=>r.GetType().Name))} and the owner is {this.Owner.Name}.";
		}
	}
}
