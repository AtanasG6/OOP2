namespace Task3
{
	public abstract class Shape
	{
		public abstract double GetArea(); // Изчислява лицето на фигурата
		public abstract double GetPerimeter(); // Изчислява периметърът на фигурата
		public abstract string WhoAmI(); // Връща низ, който описва фигурата, например: Rhombus, Rectangle, Circle, etc...

		private static double circlesTotalArea = 0, circlesTotalPerimeter = 0,
			trianglesTotalArea = 0, trianglesTotalPerimeter = 0,
			squaresTotalArea = 0, squaresTotalPerimeter = 0,
			rhombusTotalArea = 0, rhombusTotalPerimeter = 0,
			isoscelesTriangleTotalArea = 0, isoscelesTriangleTotalPerimeter = 0,
			rectanglesTotalArea = 0, rectanglesTotalPerimeter = 0;

		public static void ShowGroupedAreaAndPerimeter(List<Shape> shapes)
		{
			if (shapes is not null)
			{
				foreach (var shape in shapes)
				{
					if (shape is not null)
					{
						if (shape is Circle)
						{
							circlesTotalArea += shape.GetArea();
							circlesTotalPerimeter += shape.GetPerimeter();
						}
						else if (shape is Rectangle)
						{
							rectanglesTotalArea += shape.GetArea();
							rectanglesTotalPerimeter += shape.GetPerimeter();
						}
						else if (shape is Square)
						{
							squaresTotalArea += shape.GetArea();
							squaresTotalPerimeter += shape.GetPerimeter();
						}
						else if (shape is Rhombus)
						{
							rhombusTotalArea += shape.GetArea();
							rhombusTotalPerimeter += shape.GetPerimeter();
						}
						else if (shape is IsoscelesTriangle)
						{
							isoscelesTriangleTotalArea += shape.GetArea();
							isoscelesTriangleTotalPerimeter += shape.GetPerimeter();
						}
					}
				}
			}

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Shape Circle: \n" +
							  $"total area: {circlesTotalArea} \n" +
							  $"total perimeter: {circlesTotalPerimeter}");

            Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"Shape IsoscelesTriangle: \n" +
							  $"total area: {isoscelesTriangleTotalArea} \n" +
							  $"total perimeter: {isoscelesTriangleTotalPerimeter}");
			
			Console.ForegroundColor= ConsoleColor.Red;
			Console.WriteLine($"Shape Rhombus: \n" +
							  $"total area: {rhombusTotalArea} \n" +
							  $"total perimeter: {rhombusTotalPerimeter}");

			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine($"Shape Rectangle: \n" +
							  $"total area: {rectanglesTotalArea} \n" +
							  $"total perimeter: {rectanglesTotalPerimeter}");

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine($"Shape Square: \n" +
							  $"total area: {squaresTotalArea} \n" +
							  $"total perimeter: {squaresTotalPerimeter}");
			Console.ResetColor();
		}

	}
}
