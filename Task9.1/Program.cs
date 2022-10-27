﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите целое число Х=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число Y=");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное");
                int operCode = Convert.ToInt32(Console.ReadLine());

                if (operCode == 1) Console.WriteLine("Результат вычислений={0}", x + y);
                else if (operCode == 2) Console.WriteLine("Результат вычислений={0}", x - y);
                else if (operCode == 3) Console.WriteLine("Результат вычислений={0}", x * y);
                else if (operCode == 4) Console.WriteLine("Результат вычислений={0}", x / y);
                else Console.WriteLine("Нет операции с указанным номером");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Попытка деления на нуль");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}