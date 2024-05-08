using Task1;

public class Pogram
{
	public static void Main()
	{
		var student = new Student("Ivan", "2301321013");
		var subject1 = new Subject("Matematika");
		var subject2 = new Subject("Angliiski ezik");
		student.AddSubjectAndGrade(subject1, 5.80);
		student.AddSubjectAndGrade(subject2, 6);
        Console.WriteLine(student);
    }
}