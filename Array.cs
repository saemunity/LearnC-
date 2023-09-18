using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

internal class Array
{
    // public void ArrayOne()
    // {
    //     // Tìm số lớn thứ hai của mảng
    //     int n = Convert.ToInt32(Console.ReadLine());

    //     int[] array = new int[n];

    //     for (int i = 0; i < n; i++)
    //     {
    //         array[i] = Convert.ToInt32(Console.ReadLine());
    //     }

    //     int a = 0;
    //     for (int i = 0; i < n; i++)
    //     {
    //         if (a < array[i])
    //         {
    //             a = array[i];
    //         }
    //     }
    //     Console.WriteLine("Max:{0}", a);

    //     int b = 0,
    //         c = 0,
    //         d = 0;
    //     for (int i = 0; i < n; i++)
    //     {
    //         if (array[i] == a)
    //         {
    //             i++;
    //         }
    //         else if (array[i] != a)
    //         {
    //             b = a + array[i];
    //             Console.WriteLine("a:{0}, b:{1}, c:{2}, d:{3}", a, b, c, d);
    //             if (c > b)
    //             {
    //                 c = b;
    //             }
    //             else
    //             {
    //                 d = b - a;
    //                 Console.WriteLine("a:{0}, b:{1}, c:{2}, d:{3}", a, b, c, d);
    //             }
    //         }
    //         Console.WriteLine("i:{0}", i);
    //     }

    //     Console.WriteLine("Max - 1: {0}", d);
    // }

    public void Tesst()
    {
        int n, bien_dem = 0;
            int[] arr1 = new int[100];
            int i, j, k;


            Console.Write("\nIn cac phan tu duy nhat cua mang trong C#:\n");
            Console.Write("------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu vao trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            /*kiem ta cac phan tu giong nhau*/
            Console.Write("\nCac phan tu duy nhat duoc tim thay trong mang la: \n");
            for (i = 0; i < n; i++)
            {
                bien_dem = 0;

                /*kiem tra cac phan tu giong nhau truoc vi tri hien tai va  
                tang bien_dem them 1 neu tim thay.*/
                for (j = 0; j < i - 1; j++)
                {
                    /*tang bien dem khi tim thay phan tu giong nhau.*/
                    if (arr1[i] == arr1[j])
                    {
                        bien_dem++;
                    }
                }
                /*kiem tra cac phan tu giong nhau sau vi tri hien tai va  
                tang bien_dem them 1 neu tim thay.*/
                for (k = i + 1; k < n; k++)
                {
                    /*tang bien dem khi tim thay phan tu giong nhau.*/
                    if (arr1[i] == arr1[k])
                    {
                        bien_dem++;
                    }
                }
                /*In gia tri cua vi tri hien tai trong mang - la gia tri duy nhat 
                khi con tro van chua gia tri ban dau cua no.*/
                if (bien_dem == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.Write("\n\n");       

            Console.ReadKey();
    }
}
