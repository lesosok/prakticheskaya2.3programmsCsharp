int Program = 0;

while (Program != 4)
{
    Console.WriteLine("Выберите программу, которую вы хотите запустить");
    Console.WriteLine("1. Угадай число");
    Console.WriteLine("2. Таблица умножения");
    Console.WriteLine("3. Вывод делителей числа");
    Console.WriteLine("4. Закрыть программу");

    try
    {
        Program = Convert.ToInt32(Console.ReadLine());
    }

    catch
    {
        Console.WriteLine("Вы ввели не тот тип данных. Повторите попытку\n");
        continue;
    }

    switch (Program)
    {
        case 1:
            guessNumber();
            break;

        case 2:
            tablica();
            break;

        case 3:
            vivodDeliteley();
            break;

        case 4:
            Console.WriteLine("Вы вышли из программы");
            break;

        default:
            Console.WriteLine("Операции с таким номером нет. Повторите попытку\n");
            break;
    }

    static void guessNumber()
    {
        Console.WriteLine("Угадай число от 0 до 100!");
        Random random = new Random();
        int value = random.Next(0, 101);
        int number = Convert.ToInt32(Console.ReadLine());
        while (number != value)
        {
            if (number < value)
            {
                Console.WriteLine("Надо больше");
                number = Convert.ToInt32(Console.ReadLine());
                continue;
            }
            else if (number > value)
            {
                Console.WriteLine("Надо меньше");
                number = Convert.ToInt32(Console.ReadLine());
                continue;
            }
            else
            {
                Console.WriteLine("Вы ввели не тот тип данных. Повторите попытку");
                continue;
            }
        }
        Console.WriteLine("Угадал!\n");
    }

    static void tablica()
    {
        int[,] massive = new int[9, 9];

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                massive[i, j] = (i + 1) * (j + 1);
            }
        }

        Console.WriteLine("Таблица умножения:");
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(massive[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void vivodDeliteley()
    {
        int input = -1;
        Console.WriteLine("Чтобы выйти в менюшку, введите число '0'");
        while (input != 0)
        {
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы ввели не тот тип данных. Повторите попытку");
                continue;
            }

            if (input == 0)
            {
                break;
            }

            Console.Write("Делители: ");
            if (input > 0)
            {
                for (int i = 1; i <= input / 2; i++)
                {
                    if (input % i == 0)
                    {
                        Console.Write(i.ToString());
                        Console.Write(", ");
                    }
                }
            }
            else if (input < 0)
            {
                for(int i = -1; i >= input / 2; i--)
                {
                    if (input % i == 0)
                    {
                        Console.Write(i.ToString());
                        Console.Write(", ");
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
