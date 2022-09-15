uint degree;
List<double> coefficients = new();
double point, value;
try
{
    Console.Write("Enter polynomial's degree : ");
    degree = uint.Parse(Console.ReadLine());
    for (int i = 0; i < degree; i++)
    {
        Console.Write($"Enter the coefficient standing by x^{degree - i} : ");
        coefficients.Add(double.Parse(Console.ReadLine()));
    }
    Console.Write("Enter constant term : ");
    coefficients.Add(double.Parse(Console.ReadLine()));
    Console.Write("Enter x, for which you want to evaluate the polynomial : ");
    point = double.Parse(Console.ReadLine());
    value = coefficients[0];
    for (int i = 0; i < degree; i++)
    {
        value = value * point + coefficients[i + 1];
    }
    Console.WriteLine($"The value of the given polynomial at point x = {point} equals to {value}");
}
catch (Exception)
{
    Console.WriteLine("Invalid data has been provided.");
}