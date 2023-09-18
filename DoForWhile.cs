internal class DoForWhile
{
    // Tính tổng dãy số trong C#
    public void LessonOne()
    {
        int a, b, S = 0;
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < a; i++)
        {
            b = Convert.ToInt32(Console.ReadLine());
            S += b;
        }
        Console.WriteLine(S);
    }

    // Chương trình C# để hiển thị các số Hex có giá trị từ 0 - 255
    public void LessonTwo()
    {
        for (int i = 0; i < 256; i++)
        {
            if (i < 16)
            {
                Console.Write("0");
            }
            Console.Write("{0} ", Convert.ToString(i, 16));
            if (i % 16 == 15)
            {
                Console.WriteLine();
            }
        }
    }

    // In bảng cửu chương trong C#
    public void LessonThree()
    {
        int s = 0;
        for (int i = 2; i < 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                s = i * j;
                Console.Write("{0} * {1} = {2} ", i, j, s);
            }
            Console.WriteLine();
        }
    }

    // Kiểm tra số nguyên tố trong C#
    public void LessonFour()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int S = 2 * (a / 2);
        if (a == 2)
        {
            Console.WriteLine("{0} la so nguyen to.", a);
        }
        else
        if (a > S)
        {
            Console.WriteLine("{0} la so nguyen to.", a);
        }
        else
        if (a == S)
        {
            Console.WriteLine("{0} khong la so nguyen to.", a);
        }
    }

    // Tìm số nguyên tố trong C#

    // Kiểm tra số hoàn hảo
    public void Lesson()
    {
        int a, S = 0;
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i < a; i++)
        {
            if (a % i == 0)
            {
                S = S + i;
            }
        }
        S = S + 1;
        if (a % 2 == 0 && a == S)
        {
            Console.WriteLine("Perfect: {0}", S);
        }
        else
        {
            Console.WriteLine("Hmmm... imperfect");
        }
    }
}

