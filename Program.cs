using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива:");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
        {
            Console.WriteLine("Некорректный ввод. Размер массива должен быть положительным целым числом.");
            return;
        }
