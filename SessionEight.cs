using System.Collections;

internal class SessionEight
{
    // Bài tập mô phỏng tàu chở hàng. Tại 1 bến, cứ sau 5 - 10 s lại có 1 tàu chở hàng đi vào. Mất 3 - 7 s để xếp hàng và đi ra. 
    // Bến chỉ cho phép đỗ 1 tàu. Hiển thị liên tục số tàu đã chuyển hàng và số tàu đang đợi trong s đó. 
    public void SimulationShip()
    {
        Queue cargoShip = new Queue();
        Random arrivalTime = new Random();
        Random timeInLine = new Random();
        int[] shipArrivalTime = new int[100];
        int[] shipTimeInLine = new int[100];
        // Console.Write("Nhap so giay muon mo phong: ");
        // int time = Convert.ToInt32(Console.ReadLine());
        int time = 100;
        shipArrivalTime[0] = arrivalTime.Next(5, 10);
        shipTimeInLine[0] = timeInLine.Next(3, 7);
        Console.WriteLine("{0}, {1}", shipArrivalTime[0], shipTimeInLine[0]);
        for (int a = 1; a < time; a++)
        {
            int parameter = 0;
            if (a < shipArrivalTime[parameter])
            {
                Console.WriteLine("Giay thu {0} chua co tau den.", a);
            }
            else if (a == shipArrivalTime[parameter])
            {
                Console.WriteLine("Tau thu {0} da den ben.", (parameter+1));
                parameter++;
                shipArrivalTime[parameter] = arrivalTime.Next(5, 10);
                shipTimeInLine[parameter] = timeInLine.Next(3, 7);
                Console.WriteLine("Tau thu {0}. Di mat {1}. Roi di mat {2}", (parameter+1), shipArrivalTime[parameter], shipTimeInLine[parameter]);
            }
        }
    }

    // struct Student
    // {
    //     public int Id;
    //     public string FullName;
    //     public string Gender;
    //     public string Address;
    //     public string Level;
    // }
    // Student[,] student = new Student[5, 20];
    // public void InputDataStudent()
    // {
    //     int numberOfStudents;
    //     Console.WriteLine("Nhap so luong sinh vien: ");
    //     numberOfStudents = Convert.ToInt32(Console.ReadLine());
    //     for (int i = 0; i < numberOfStudents; i++)
    //     {
    //         for (int j = 0; j < 5; j++)
    //         {
    //             // Id
    //             student[i, j].Id = j;
    //             j++;
    //             // Full name
    //             Console.WriteLine("Nhap ho va ten sinh vien thu {0}: ", (i + 1));
    //             string convertName = Console.ReadLine() ?? "";
    //             student[i, j].FullName = StandardizeName(convertName);
    //             j++;
    //             // Gender
    //             Console.WriteLine("Lua chon gioi tinh la Nam/ Nu (0/ 1): ");
    //             int gender = Convert.ToInt32(Console.ReadLine());
    //             if (gender != 0 && gender != 1)
    //             {
    //             repeatGender:
    //                 Console.Write("Vui long chon lai gioi tinh la Nam/ Nu (0/ 1): ");
    //                 gender = Convert.ToInt32(Console.ReadLine());
    //                 if (gender != 0 && gender != 1)
    //                     goto repeatGender;
    //             }
    //             student[i, j].Gender = ChooseGender(gender);
    //             j++;
    //             // Address
    //             Console.WriteLine("Nhap dia chi que quan: ");
    //             student[i, j].Address = Console.ReadLine() ?? "Unknown";
    //             j++;
    //             // Level
    //             Console.WriteLine("Nhap diem tong ket: ");
    //             double pointAverage = Convert.ToDouble(Console.ReadLine());
    //             if (0 < pointAverage && pointAverage > 10)
    //             {
    //             repeatPoint:
    //                 Console.Write("Vui long nhap lai diem tong ket: ");
    //                 pointAverage = Convert.ToDouble(Console.ReadLine());
    //                 if (pointAverage < 0 && pointAverage > 10)
    //                     goto repeatPoint;
    //             }
    //             student[i, j].Level = RatingLevel(pointAverage);
    //         }
    //     }

    //     for (int i = 0; i < numberOfStudents; i++)
    //     {
    //         Console.Write("\n");
    //         for (int j = 0; j < 5; j++)
    //         {
    //             // Console.Write("\n{0}", student[i, j].Id);
    //             // j++;
    //             // Console.Write("\n{0}", student[i, j].FullName);
    //             // j++;
    //             // Console.Write("\n{0}", student[i, j].Gender);
    //             // j++;
    //             // Console.Write("\n{0}", student[i, j].Address);
    //             // j++;
    //             // Console.Write("\n{0}", student[i, j].Level);
    //         }
    //         Console.WriteLine("\n");
    //     }
    // }

    // private string StandardizeName(string nameStudent)
    // {
    //     nameStudent = nameStudent.Trim();
    //     nameStudent = nameStudent.ToLower();
    //     while (nameStudent.IndexOf("  ") != -1)
    //     {
    //         nameStudent = nameStudent.Remove(nameStudent.IndexOf("  "), 1);
    //     }
    //     string[] n = nameStudent.Split(" ");
    //     string afterName = "";
    //     for (int i = 0; i < n.Length; i++)
    //     {
    //         string firstChar = n[i].Substring(0, 1);
    //         string lastChar = n[i].Substring(1, n[i].Length - 1);
    //         afterName += firstChar.ToUpper() + lastChar + " ";
    //     }
    //     afterName = afterName.Remove(afterName.LastIndexOf(' '), 1);
    //     return afterName;
    // }

    // private string ChooseGender(int gender)
    // {
    //     switch (gender)
    //     {
    //         case 0:
    //             return "Nam";
    //         case 1:
    //             return "Nu";
    //         default:
    //             return "Unknown";
    //     }
    // }

    // private string RatingLevel(double pointAverage)
    // {
    //     if (8 <= pointAverage && pointAverage <= 10)
    //     {
    //         return "Gioi";
    //     }
    //     if (6.5 <= pointAverage && pointAverage < 8)
    //     {
    //         return "Kha";
    //     }
    //     if (3.5 <= pointAverage && pointAverage < 6.5)
    //     {
    //         return "Trung binh";
    //     }
    //     if (0 <= pointAverage && pointAverage < 3.5)
    //     {
    //         return "Yeu";
    //     }
    //     return "Unknown";
    // }

    //     // ArrayList itemsA = new ArrayList();
    //     // ArrayList itemsB = new ArrayList();

    //     // public void AddItems()
    //     // {
    //     //     itemsA.Add(10);
    //     //     itemsA.Add("Anh da on hon");
    //     //     itemsA.Add(7.89);
    //     //     itemsB.Add(true);
    //     //     itemsB.Add("Neu luc do");
    //     //     itemsB.Add(-10);
    //     //     itemsA.Insert(1, "Oke");
    //     //     itemsB.Insert(1, "Umum");
    //     //     foreach (var item in itemsA)
    //     //     {
    //     //         Console.Write(item + "\n");
    //     //     }

    //     //     foreach (var item in itemsB)
    //     //     {
    //     //         Console.Write(item + "\n");
    //     //     }

    //     //     itemsA.Remove(10);
    //     //     itemsB.Remove("Umum");
    //     //     itemsA.Remove(2);
    //     //     itemsB.Remove(2);
    //     // }

    //     // List<int> listA = new List<int>();
    //     // List<int> listB = new List<int>();

    //     // public void AddItems()
    //     // {
    //     //     for (int i = 0; i < 10; i++)
    //     //     {
    //     //         int a = i + 2;
    //     //         listA.Add(a);
    //     //         listB.Add(a + i);
    //     //     }

    //     //     listA.Add(5);
    //     //     listA.Add(5);
    //     //     listA.Add(3);
    //     //     listA.Add(0);

    //     //     listA.Reverse();    
    //     //     listB.Reverse();

    //     //     foreach (var item in listA)
    //     //     {
    //     //         if ( item == 5 )
    //     //         {
    //     //             listA.Remove(item);
    //     //             return;
    //     //         }
    //     //         Console.Write(item + "\n");
    //     //     }

    //     //     listA.Sort();
    //     // }
}