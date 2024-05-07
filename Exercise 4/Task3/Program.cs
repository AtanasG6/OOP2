using Task3;

public class Program
{
	public static void Main()
	{
		List<Shape> shapes = new List<Shape> {
												new Circle(10),
												new IsoscelesTriangle(10, (Math.PI / 180) * 120),
												new IsoscelesTriangle(10, (Math.PI / 180) * 35),
												new Circle(15),
												new Rhombus(20,10),
												new Rectangle(20,30),
												new Rectangle(5,10),
												new Rectangle(6,9),
												new Square(20)
												};

		Shape.ShowGroupedAreaAndPerimeter(shapes);
    }
}