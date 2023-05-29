using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания по if_else (1-5): ");
            int if_else = int.Parse(Console.ReadLine());
            switch (if_else)
            {
                case 1:
                    Console.WriteLine("Введите число");
                    int c = int.Parse(Console.ReadLine());
                    if (c < 0)
                    {
                        c -= 5;
                        Console.WriteLine("Число отрицательное " + c);
                    }
                    else if (c > 0)
                    {
                        c += 5;
                        Console.WriteLine("Число положительное " + c);
                    }
                    break;



                case 2:

                    Console.WriteLine("Задайте значения");
                    Console.WriteLine("Первое число");
                    int first = int.Parse(Console.ReadLine());
                    Console.WriteLine("Второе число");
                    int second = int.Parse(Console.ReadLine());
                    Console.WriteLine("Третье число");
                    int third = int.Parse(Console.ReadLine());
                    if (first > second)
                    {
                        if (first > third)
                        {
                            Console.WriteLine("Первое число наибольшее " + first);
                        }
                        else
                        {
                            Console.WriteLine("Третье число наибольшее " + third);

                        }
                    }
                    else
                    {
                        if (second > first)
                        {
                            if (second > third)
                            {
                                Console.WriteLine("Второе число наибольшее " + second);
                            }
                            else
                            {
                                Console.WriteLine("Третье число наибольшее " + third);

                            }
                        }
                    }

                    break;

                case 3:
                    Console.WriteLine("Задайте значения ");
                    Console.WriteLine("Введите первое число");
                    int kazenak = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Введите второе число ");
                    int sgush = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Введите третье число ");
                    int tea = Convert.ToInt16(Console.ReadLine());
                    int summ;
                    if (kazenak < 0)
                    {
                        kazenak = 0;
                    }
                    if (sgush < 0)
                    {
                        sgush = 0;
                    }
                    if (tea < 0)
                    {
                        tea = 0;
                    }
                    summ = kazenak + sgush + tea;
                    Console.WriteLine("Сумма положительных чисел:" + summ);

                    break;



                case 4:
                    Console.WriteLine("Введите значение x ");
                    int x = int.Parse(Console.ReadLine());
                    int bam;
                    if (x > 10)
                    {
                        bam = x * 2;
                        Console.WriteLine("Удвоенное значение " + bam);
                    }
                    else
                    if (x < 10)
                    {
                        Console.WriteLine("X > 10 = " + x);
                    }
                    break;

                case 5:
                    Console.WriteLine("Задайте день ");
                    int day = int.Parse(Console.ReadLine());

                    switch (day)
                    {
                        case 1:
                            Console.WriteLine("Понедельник");
                            break;
                        case 2:
                            Console.WriteLine("Вторник");
                            break;
                        case 3:
                            Console.WriteLine("Среда");
                            break;
                        case 4:
                            Console.WriteLine("Четверг");
                            break;
                        case 5:
                            Console.WriteLine("Пятница");
                            break;
                        case 6:
                            Console.WriteLine("Субботу");
                            break;
                        case 7:
                            Console.WriteLine("Воскресенье");
                            break;
                    }
                    break;
            }
            Console.WriteLine("Введите номер задания по циклам (1-4): ");


            int cikl = int.Parse(Console.ReadLine());
            switch (cikl)
            {
                case 1:

                    int i;
                    for (i = 200; ; i++)
                    {
                        if (i % 17 == 0)
                        {
                            Console.WriteLine("Наименьшее число больше 200 делящееся нацело на 17: " + i);
                            break;
                        }
                    }
                    break;

                case 2:



                    double a;
                    int count = 0;
                    double b;
                    int count1 = 0;
                    for (a = 10; ; count++)
                    {
                        if (a >= 20)
                        {
                            Console.WriteLine("Дней" + count + " " + "КМ" + a);
                            break;
                        }
                        else
                        {
                            a = a * 1.05;
                        }
                    }

                    for (b = 10; ; count1++)
                    {
                        if (b >= 100)
                        {
                            Console.WriteLine("Дней" + count1 + " " + "КМ" + b);
                            break;
                        }
                        else
                        {
                            b = b * 1.05;
                        }
                    }
                    break;

                case 3:


                    Console.WriteLine("Введите факториал");
                    int n = int.Parse(Console.ReadLine());
                    int fact = 1;
                    int d;

                    for (d = 2; d <= n; d++)
                    {
                        fact = fact * d;
                    }
                    Console.WriteLine("факториал числа {0} равен {1}", n, fact);

                    break;
                case 4:


                    Console.WriteLine("Введите число ");
                    int e = int.Parse(Console.ReadLine());
                    int f;

                    for (f = 2; ; f++)
                    {
                        if (e % f == 0)
                        {
                            Console.WriteLine("Наименьший делитель числа " + e + " " + "равен: " + f);
                            break;
                        }
                    }
                    break;
            }

        
        Console.ReadKey();
        }
    }
}
