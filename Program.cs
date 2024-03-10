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
    string[] originalArray = new string[size];

        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.Write($"Введите элемент массива [{i}]: ");
            originalArray[i] = Console.ReadLine();
        }

        string[] newArray = FilterStrings(originalArray);

        Console.WriteLine("\nНовый массив строк, длина которых меньше или равна 3 символам:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
  
    static string[] FilterStrings(string[] originalArray)
    {
        int count = 0;
        foreach (string str in originalArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];