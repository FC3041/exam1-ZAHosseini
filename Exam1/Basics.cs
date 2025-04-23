
using System.Net.Security;

namespace Exam1;
public class Q1_Add
{
    public static int Add(int a, int b)
    {
        return a + b;

    }
}
public class Basics
{
    public static void Q2MultiplyAndReset(ref int a, ref int b)
    {
        a = a * b;
        b = 1;


    }

    public static void Q5TryCatchFinally(bool v1, List<string> list, bool v2)
    {
        try
        {
            if (v1 == true)
            {
                throw new InvalidOperationException();
            }


        }
        catch (Exception)
        {
            if (v2 == true)
            {
                throw;
            }


        }
    }

    public static void Q5TryCatchFinally(bool v, List<string> log)
    {

        log.Add("Try");
        try
        {
            if (v == false)
            {
                log.Add("AfterTry");
            }
            if (v == true)
            {
                throw new Exception();
            }

        }

        catch (Exception)
        {
            log.Add("Catch");

        }
        finally
        {
            log.Add("Finally");

        }
    }
}

public struct Type1
{
    public int Count { get; set; }
}
public class Type2
{
    public int Count { get; set; }
}

public class Q4Person
{
    public string Name;
    public int Age;
    public Q4Person(string Name, int Age)
    {
        this.Name = Name;
        this.Age = Age;
    }

    public string Introduce()
    {
        return $"Hello, my name is {this.Name} and I am {this.Age} years old.";
    }
}

// public struct Q6Temperature
// {
//     public double _celsius;
//     public double Celsius
//     {
//         get
//         {
//             return _celsius;
//         }
//         set
//         {
//             _celsius = value;

//             _fahrenheit = 32 + (9 / 5) * value;

//         }
//     }
//     public double _fahrenheit;
//     public double Fahrenheit
//     {
//         get
//         {
//             return _fahrenheit;
//         }
//         set
//         {
//             _fahrenheit = value;
//             _celsius = (5 / 9) * (value - 32);
//         }
//     }

// }

public class Q7Circle : IShape
{
    private double v;

    public Q7Circle(double v)
    {
        this.v = v;
    }

    public double GetArea()
    {
        return Math.PI * v * v;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * v;
    }
}
public class Q7Rectangle : IShape
{
    private double v1;
    private double v2;

    public Q7Rectangle(double v1, double v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public double GetArea()
    {
        return v1 * v2;
    }

    public double GetPerimeter()
    {
        return 2 * v1 + 2 * v2;
    }
}

public interface IShape
{
    public double GetArea();
    public double GetPerimeter();


}
public class ShapeUtils
{
    public static double Q7TotalArea(IShape[] shapes)
    {
        double total = 0;
        foreach (var item in shapes)
        {
            total += item.GetArea();
        }
        return total;
    }
}

