using arv_och_objektorientering_interface;
internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Area(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    }
}