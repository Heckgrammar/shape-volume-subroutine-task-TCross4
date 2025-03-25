namespace ShapeAreaCalculatorTask
{
    public static void Main(string[] args)
    {
        int Base = 0;
        int Height = 0;
        int Sidelength = 0;
        Console.WriteLine("0: Circle, 1: Triangle, 2: Rectangle, 3: Pentagon, 4: Octagon");
        if (Convert.ToInt16(Console.ReadLine()) == 0)
        {
            Console.WriteLine("Radius?");
            areaOfCircle(Convert.ToInt16(Console.ReadLine()));
        }
        else if (Convert.ToInt16(Console.ReadLine()) == 1)
        {
            Console.WriteLine("Base?");
            Base = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Height?");
            Height = Convert.ToInt16(Console.ReadLine());
            areaOfTriangle(Base, Height);
        }
        else if (Convert.ToInt16(Console.ReadLine()) == 2)
        {
            Console.WriteLine("Base?");
            Base = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Height?");
            Height = Convert.ToInt16(Console.ReadLine());
            areaOfRectangle(Base, Height);
        }
        else if (Convert.ToInt16(Console.ReadLine()) == 3)
        {
            Console.WriteLine("Side length?");
            Sidelength = Convert.ToInt16(Console.ReadLine());
            areaOfPentagon(Sidelength);
        }
        else if (Convert.ToInt16(Console.ReadLine()) == 4)
        {
            Console.WriteLine("Side length?");
            Sidelength = Convert.ToInt16(Console.ReadLine());
            areaOfOctagon(Sidelength);
        }
    }
    static int areaOfCircle(int a)//Add the parameters
    {
       return Console.WriteLine($"Area is {3.14 * a * a}");
    }
    static int areaOfTriangle(int b, int c)//Add the parameters
    {
        return Console.WriteLine($"Area is {(b * c)/2}");
    }
    static int areaOfRectangle(int d, int e)//Add the parameters
    {
        return Console.WriteLine($"Area is {d * e}");
    }
    static int areaOfPentagon(int f)//Add the parameters
    {
        return Console.WriteLine($"Area is {Math.Sqrt(5(5+2 * Math.Sqrt(5)))/4 * f * f}");
    }
    static int areaOfOctagon(int g)//Add the parameters
    {
        return Console.WriteLine($"Area is {2(1+ Math.Sqrt(2)) * g * g}");
    }
}
