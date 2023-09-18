internal class SessionTen
{
    public void ShowResult()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("So do la: {0}", Average(a));
    }

    private int Average(int a)
    {
        // Khai báo mảng muốn nhập
        int[] array = new int[100];
        // Tìm tổng
        double S = 0;
        for (int b = 0; b < a; b++)
        {
            array[b] = Convert.ToInt32(Console.ReadLine());
            S += array[b];
        }
        S = S / a;
        double[] arrayMin = new double[a];
        for (int b = 0; b < a; b++)
        {
            if (S < array[b])
            {
                arrayMin[b] = array[b] - S;
            }
            if (S > array[b])
            {
                arrayMin[b] = S - array[b];
            }
        }

        double min = arrayMin[0];

        for (int b = 1; b < a; b++)
        {
            if (arrayMin[b] < min)
            {
                min = arrayMin[b];
            }
        }
        int wantNumber = 0;
        for (int b = 0; b < a; b++)
        {
            if (min == arrayMin[b])
            {
                wantNumber = b;
            }
        }
        return array[wantNumber];
    }
}