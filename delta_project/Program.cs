static double countDelta(double a, double b, double c)
{
    double delta = Math.Pow(b, 2) - (4 * a * c);
    return delta;
}


static double linear_equation(double b, double c)
{
    double result = -c / b;
    return result;
}


static void show_result(Dictionary<string, double> result)
{
    // Wyświetla wyniki równania.

    foreach (KeyValuePair<string, double> entry in result)
    {
        Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
    }
}


static double count_x1(double a, double b, double delta)
{
    double delta_sqrt = Math.Sqrt(delta);
    double result = (-b - delta_sqrt) / (2 * a);
    return result;
}


static double count_x2(double a, double b, double delta)
{
    double delta_sqrt = Math.Sqrt(delta);
    double result = (-b + delta_sqrt) / (2 * a);
    return result;
}


static double count_x_for_delta_0(double a, double b)
{
    double result = -b / (2 * a);
    return result;
}



static Dictionary<string, double> quadratic_quation()
{
    Dictionary<string, double> results = new Dictionary<string, double>();

    Console.WriteLine("Podane jest wyrażenie: ax2+bx+c=0");

    Console.WriteLine("Podaj a");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Podaj b");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Podaj c");
    double c = Convert.ToDouble(Console.ReadLine());


    /* Sprawdzam czy jest to wyrażenie kwadratowe 
       Jeśli nie jest liczy x dla wyrażenia liniowego
    */
    if (a == 0)
    {
        double x = linear_equation(b, c);
        results.Add("x", x);

        show_result(results);
        return results;
    };

    double delta = countDelta(a, b, c);

    if (delta > 0)
    {
        results.Add("x1", count_x1(a, b, delta));
        results.Add("x2", count_x2(a, b, delta));
        show_result(results);
        return results;
    } 
    else if (delta == 0)
    {
        results.Add("x", count_x_for_delta_0(a, b));
        show_result(results);
        return results;
    }
    else
    {
        Console.WriteLine("Delta jest ujemna, brak wyników");
        return results;
    }
}

quadratic_quation();