using arv_och_objektorientering_interface;
internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        Circle circle = new Circle();
        Triangle triangle = new Triangle();
        Console.WriteLine("Circle, triangle or rectangle?");
        string shape = Console.ReadLine();
        Console.WriteLine("Input width and height:");
        int W = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        if (shape == "rectangle")
        {
            rectangle.Area(W, H);
            rectangle.Circumference(W, H);
        }
        else if (shape == "triangle")
        {
            triangle.Area(W, H);
            triangle.Circumference(W, H);
        }
        else if (shape == "circle")
        {
            circle.Area(W, H);
            circle.Circumference(W, H);            
        }
        else
        {
            Console.WriteLine("Not a valid answer.");
        }
    }
}