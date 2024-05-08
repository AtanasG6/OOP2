namespace Task1
{
	public class Subject
	{
		private const string ERROR_MESSAGE = "Invalid input!";
		private string _name;

        public Subject(string name)
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
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._name = value;
			}
		}
	}
}
