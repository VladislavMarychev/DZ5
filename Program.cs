//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
using System;

namespace programm
{
    class Program
    {
        static void Main(string[] args)
        {
            int Vvod(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());

            }


            void Task34()
            {
                int count = 0;
                int[] numbers = new int[Vvod("Введите размер массива  ")];
                Random rnd = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(0, 1000);
                    if (numbers[i] % 2 == 0)
                    {
                        count++;
                    }
                    Console.Write($"{numbers[i]}  ");
                }

                Console.WriteLine($"\nКоличество четных чисел у массива {count}");

            }
            Console.Clear();
            //Task34();           Задача 34


            void Task36()    //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
            {
                int[] numbers = new int[Vvod("Введите размер массива  ")];
                Random rnd = new Random();
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rnd.Next(0,9);
                        

                }
            }
        }
    }

}


