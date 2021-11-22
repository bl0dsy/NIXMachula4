using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIXMachula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Занятие2, Задача2. Определить максимальное число, которое можно получить, путем перестановки цифр произвольного трехзначного положительного целого числа n(100 <= n <= 999).Вывести полученное число, а также следующее и предыдущие числа.");
            Console.WriteLine("Введите положительное трехзначное число");
            int n, a, b, c, min, mid, max, x;
            n = Convert.ToInt32(Console.ReadLine());
            a = n % 10;
            b = n / 100;
            c = (n / 10) % 10;


            min = b < c ? b < a ? b : a : c < a ? c : a;
            max = b > c ? b > a ? b : a : c > a ? c : a;
            mid = (a + b + c) - min - max;


            x = (max * 100 + mid * 10 + min);
            Console.WriteLine(x);
            Console.WriteLine(x + 1);
            Console.WriteLine(x - 1);
        }
    }
}
