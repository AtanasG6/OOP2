namespace OOPTask2
{
	public class Person : IPerson
	{
		private readonly string _name;

		public Person(string name)
		{
			this.Name = name;
		}

		public string Name
		{
			get 
			{ 
				return this._name;
			}
			private init 
			{
                if (string.IsNullOrWhiteSpace(value))
                {
					throw new ArgumentException("Invalid input!");
                }
                this._name = value; 
			}
		}

	}
}
