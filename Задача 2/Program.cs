using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 целых чисел
        int[] numbers = new int[] { 2, 7, 14, 19, 26, 33, 40, 55, 68, 77 };

        // Находим количество чётных чисел в массиве
        int countEven = CountEvenNumbers(numbers);

        // Выводим результат
        Console.WriteLine($"Количество чётных чисел в массиве: {countEven}");
    }

    // Метод для подсчета чётных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}
