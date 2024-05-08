using System.Text;

namespace Task1
{
	public class Student
	{
		private const string ERROR_MESSAGE = "Invalid input!";
		private string _name;
		private string _facultyNum;
		private Dictionary<Subject,double> _grades;

        public Student(string name, string facultyNum)
        {
            this.Name = name;
			this.FacultyNum = facultyNum;
			this.Grades = new Dictionary<Subject,double>();
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

		public string FacultyNum
		{
			get
			{
				return this._facultyNum;
			}

			private init
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._facultyNum = value;
			}
		}



		public Dictionary<Subject, double> Grades
		{
			get 
			{ 
				return this._grades; 
			}
			private set
			{
				if (value is null || value.Any(kv => kv.Key == null || kv.Value < 2 || kv.Value > 6))
				{
					throw new ArgumentException(ERROR_MESSAGE);
				}
				this._grades = value;
			}
		}

		public void AddSubjectAndGrade(Subject subject, double grade)
		{
			bool isValid = true;
			if (!this.Grades.ContainsKey(subject))
			{
                foreach (var sub in this.Grades.Keys)
                {
					if (sub.Name==subject.Name)
					{
						isValid = false;
						break;
					}
                }
                if (isValid)
                {
					this.Grades.Add(subject, grade);
                }
				else
				{
					throw new InvalidOperationException("This subject already exists!");
				}
			}
			else
			{
				throw new InvalidOperationException("This subject already exists!");
			}
        }

		public string NumberOfSubjects()
		{
            return $"{this.Name}'s number of subjects is {this.Grades.Keys.Count}.";
        }
		
		public string Subjects()
		{
			var subjects = this.Grades.Keys.ToList();
			var sb = new StringBuilder();

			foreach ( var subject in subjects ) 
			{
				sb.Append(subject.Name);
				sb.Append(' ');
			}

			return sb.ToString();
		}

		public string GradeOfSubject(Subject subject)
		{
			if (this.Grades.ContainsKey(subject))
			{
                return this.Grades[subject].ToString();
            }
			else
			{
				throw new InvalidOperationException("No such subject");
			}
		}

		public string AverageGrade()
		{
			double result = 0;

            foreach (var grade in this.Grades.Values)
            {
				result += grade;
            }

			result/=this.Grades.Values.Count;

            return $"{this.Name}'s average grade is {result:f2}.";
        }

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendLine($"This student's name is {this.Name}. His faculty number is {this.FacultyNum}.");
			sb.AppendLine(this.NumberOfSubjects());
			sb.AppendLine(this.AverageGrade());

			return sb.ToString();

				
		}
	}
}
