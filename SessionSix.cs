internal class SessionSix
{
    // Homework lesson 7: Created a new array archers is class members. In there Dung, Quy, Tram, Bang has a level of 5.
    int numbersArc;
    string[,] archers = new string[4, 20];
    public void InfoArchers()
    {
        Console.Write("Nhap so luong xa thu: ");
        numbersArc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-----------------******----------------");
        Console.WriteLine("------ Nhap thong tin cac xa thu ------");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < numbersArc; j++)
            {
                Console.Write("Nhap ten xa thu thu {0}: ", (i + 1));
                archers[i, j] = Console.ReadLine() ?? "";

                string a = "Dung";
                string b = "Quy";
                string c = "Tram";
                string d = "Bang";
                string check = archers[i, j];

                if (check.Contains(a) || check.Contains(b) || check.Contains(c) || check.Contains(d))
                {
                    j++;
                    archers[i, j] = "Trung si";
                }
                else
                {
                    j++;
                    int level;
                    Console.Write("Nhap trinh do xa thu thu {0} la Linh moi/ Linh moi hang hai/" +
                    " Chuyen gia/ Ha si/ Trung si/ Trung si tham muu (0/1/2/3/4/5): ", (i + 1));
                    level = Convert.ToInt32(Console.ReadLine());

                    if (0 > level || level > 5)
                    {
                    repeatLevel:
                        Console.Write("Nhap lai trinh do xa thu thu {0}: ", (i + 1));
                        level = Convert.ToInt32(Console.ReadLine());
                        if (0 > level || level > 5)
                            goto repeatLevel;
                    }

                    switch (level)
                    {
                        case 0:
                            archers[i, j] = "Linh moi";
                            break;
                        case 1:
                            archers[i, j] = "Linh moi hang hai";
                            break;
                        case 2:
                            archers[i, j] = "Chuyen gia";
                            break;
                        case 3:
                            archers[i, j] = "Ha si";
                            break;
                        case 4:
                            archers[i, j] = "Trung si";
                            break;
                        case 5:
                            archers[i, j] = "Trung si tham muu";
                            break;
                    }
                }
            }
        }

        Console.WriteLine("-----------******-----------");
        Console.WriteLine("------ Thong tin cac xa thu ------");
        Console.WriteLine("{0, 14}{1,14}", "Ten xa thu", "Cap bac");
        for (int i = 0; i < 2; i++)
        {
            Console.Write("\n");
            for (int j = 0; j < numbersArc; j++)
                Console.Write("{0, 14}\t", archers[i, j]);
        }
        Console.WriteLine("\n");
    }
}