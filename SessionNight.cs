internal class SessionNight
{
    public void ShowResult()
    {
        // int a = Convert.ToInt32(Console.ReadLine());
        // int b = Convert.ToInt32(Console.ReadLine());
        // int sum = SumTwoNumbers(a, b);
        // Console.WriteLine("Question 1: {0}", sum);

        // ExportData();

        // string input = Console.ReadLine() ?? "Unknown";
        // ExportDataInput(input);

        // int value = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Value after conductive: {0}", value);
        // ShowResultOneParameter(ref value);
        // Console.WriteLine("Value before conductive: {0}", value);

        // int value1 = 0;
        // Console.WriteLine("Value after conductive: {0}", value1);
        // ShowResultTwoParameter(out value1);
        // Console.WriteLine("Value after conductive: {0}", value1);

        // Tính giai thừa
        int valueFactorial = Convert.ToInt32(Console.ReadLine());
        int valueResult = Factorial(valueFactorial);
        Console.WriteLine("Value factorial of {0} is: {1}", valueFactorial, valueResult);
    }
    private int SumTwoNumbers(int a, int b)
    {
        return a + b;
    }

    private void ExportData()
    {
        Console.WriteLine("Question 2: Ú òa");
    }

    private void ExportDataInput(string input)
    {
        Console.WriteLine("Question 3: {0}", input);
    }

    private void ShowResultOneParameter(ref int value)
    {
        value += value;
        Console.WriteLine("Value in function: {0}", value);
    }

    private void ShowResultTwoParameter(out int value1)
    {
        int value2 = 100;
        value1 = value2;
        Console.WriteLine("Value in function: {0}", value1);
    }

    private int Factorial(int value)
    {
        if (value == 0)
        {
            return 1;
        }
        else { 
            return value * Factorial(value - 1);
        }
    }
}