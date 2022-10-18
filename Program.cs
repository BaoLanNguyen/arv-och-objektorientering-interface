using arv_och_objektorientering_interface;
internal class Program
{
    private static void Main(string[] args)
    {
        int Height = int.Parse(Console.ReadLine());
        int Width = int.Parse(Console.ReadLine()); 
        IShape circle = new Circle(Width, Height);
        Console.WriteLine(circle.Area());      
    }
}