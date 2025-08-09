namespace Task2_AbstractClasses
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return 3.14 * radius * radius;
        }
    }


    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(15);
            Shape rectangle = new Rectangle(100, 56);

            Console.WriteLine($"Circle area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        }
    }
}
