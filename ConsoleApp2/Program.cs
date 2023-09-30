int a;
int b;
int d;
int i;
do
{
    Console.WriteLine("Список действий");
    Console.WriteLine("1. Игра 'Угадай число'");
    Console.WriteLine("2. Вывод делителей числа");
    Console.WriteLine("3. таблица умножения");
    Console.WriteLine("4. Выход из программы");
    Console.WriteLine("выберите действие:");
    a = Convert.ToInt32(Console.ReadLine());
    if (a == 1)
    {
        Random g = new Random();
        int c = g.Next(101);
        while (true)
        {
            Console.WriteLine("Угадайте число от 1 до 100");
            Console.WriteLine("Введите ваше число:");
            d = Convert.ToInt32(Console.ReadLine());
            if (c == d)
            {
                Console.WriteLine("Вы победили!!!");
                break;
            }
            if (c > d)
            {
                Console.WriteLine("Ответ не верен, загаданное число больше, чем число введённое вами");
            }
            if (c < d)
            {
                Console.WriteLine("Ответ не верен, загаданное число менеше, чем число введённое вами");
            }
        }
    }
    if (a == 2)
    {
        Console.WriteLine("Введи число: ");
        i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ответ: ");
        for (int j = 1; j <= i; j++)
        {
            if (i % j == 0)
            {
                Console.WriteLine("{0}", j);
            }
        }
        Console.WriteLine("");
    }
    if (a == 3)
    {
        for (int x = 2; x <= 9; x++)
        {
            for (int j = 2; j <= 9; j++)
            {
                Console.Write((x * j).ToString() + "\t");
            }
            Console.WriteLine();
        }
    }
}
while (a < 4);
