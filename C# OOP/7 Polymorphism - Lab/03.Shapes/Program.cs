using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                Shape rectangle = new Rectangle(4, 4);
                Shape circle = new Circle(5);

                Console.WriteLine(rectangle.Draw());
                Console.WriteLine(rectangle.CalculatePerimeter());
                Console.WriteLine(rectangle.CalculateArea());

                Console.WriteLine(circle.Draw());
                Console.WriteLine(circle.CalculatePerimeter());
                Console.WriteLine(circle.CalculateArea());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
