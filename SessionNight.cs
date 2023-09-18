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

        // int value1;
        // Console.WriteLine("Value after conductive: {0}", value1);
        // ShowResultTwoParameter(out value1);
        // Console.WriteLine("Value after conductive: {0}", value1);

        // Tính giai thừa
        // int valueFactorial = Convert.ToInt32(Console.ReadLine());
        // int valueResult = Factorial(valueFactorial);
        // Console.WriteLine("Value factorial of {0} is: {1}", valueFactorial, valueResult);

        // Tính Fibonacci
        int valueFibonacci = Convert.ToInt32(Console.ReadLine());
        int valueResult = Fibonacci(valueFibonacci);
        Console.WriteLine("{0}: {1}",valueFibonacci ,valueResult);

        // Tính lũy thừa
        // int valueBase = Convert.ToInt32(Console.ReadLine());
        // int valuePower = Convert.ToInt32(Console.ReadLine());
        // int valueResultExponentiation = Exponential(valueBase, valuePower);
        // Console.WriteLine("Value exponentiation of {0} with power is {1}: {2}", valueBase, valuePower, valueResultExponentiation);

        // Sum 
        // int value = Convert.ToInt32(Console.ReadLine());
        // int resultValue = Sum(value);
        // Console.WriteLine("Sum value of {0} is: {1}", value, resultValue);
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
        value1 = 100;
        value1 += value1;
        Console.WriteLine("Value in function: {0}", value1);
    }

    private int Factorial(int value)
    {
        if (value == 0)
        {
            return 1;
        }
        else
        {
            return value * Factorial(value - 1);
        }
    }

    private int Fibonacci(int value)
    {
        if (value <= 2)
        {
            return 1;
        }
        else
        {
            return Fibonacci(value - 1) + Fibonacci(value - 2);
        }
    }

    private int Exponential(int number, int raised)
    {
        int result = 1;
        for (int a = 1; a <= raised; a++)
        {
            result *= number;
        }
        return result;
    }

    // private int Sum(int a)
    // {
    //     if (a == 0)
    //     {
    //         return 0;
    //     }
    //     else
    //     {
    //         return a + Sum(a - 1);
    //     }
    // }
}