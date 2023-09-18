internal class SessionOne
{
    public void ShowResult()
    {
        // Reverse display input 3 alphabet
        // LessonOne(); 

        // Lesson 2
        // LessonTwo();

        //Lesson 3
        LessonThree();
    }

    // Reverse display input 3 alphabet
    private static void LessonOne()
    {
        Console.Write("Input 1: ");
        string a = Console.ReadLine() ?? "";
        Console.Write("Input 2: ");
        string b = Console.ReadLine() ?? "";
        Console.Write("Input 3: ");
        string c = Console.ReadLine() ?? "";
        Console.WriteLine("input 3, 2, 1: {0}, {1}, {2}", c, b, a);
    }

    // Sum = 1 - x^2/2! + x^4/4! - ...
    private static void LessonTwo()
    {
        Console.Write("Input: ");
        int a = Convert.ToInt32(Console.ReadLine());
        double Sum = 1;
        double b = 1;
        double c;
        for (int i = 1; i < a ; i++)
        {
            c = (2*i)*(2*i-1);
            b = -b*a*a/c;
            Sum = Sum + b;
        }
        Console.WriteLine("Output: {0}", Sum);
    }

    // 9 + 99 + 999 + ...
    private static void LessonThree()
    {
        Console.Write("Input: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int sum = 9;
        int b = 9;
        Console.Write("9 ");
        for (int i = 1; i < a; i++)
        {
            b = b * 10 + 9; 
            if ( i < a )
            {
                Console.Write("+ {0} ", b);
            } 
            sum += b;
        }
        Console.WriteLine("\n"+sum);
    }
}