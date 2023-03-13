namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the lenght:");
                string legnhtString = Console.ReadLine();
                int lenghtInt = Convert.ToInt32(legnhtString);

                if (lenghtInt < 0)
                {
                    Console.WriteLine("Please write the pisitive number!");
                    return;
                }

                Console.WriteLine("Please enter the width:");
                string widthString = Console.ReadLine();
                int widthInt = Convert.ToInt32(widthString);

                if (widthInt < 0)
                {
                    Console.WriteLine("Please write the pisitive number!");
                    return;
                }
                var area = Rectangle.CalculateArea(widthInt, lenghtInt);

                Console.WriteLine("Area of your Rectangle is:" + area);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please Write the number!");
            }
        }
    }
}

public static class Rectangle
{
    public static int CalculateArea(int lenght, int width)
    {
        int area = lenght * width;
        return area;
    }
}