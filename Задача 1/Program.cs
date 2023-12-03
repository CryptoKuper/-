using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 10 целых чисел
        int[] numbers = new int[] { 15, 25, 30, 40, 50, 60, 70, 80, 90, 100 };

        // Находим количество элементов в массиве, значения которых лежат в отрезке [20, 90]
        int countInRange = CountElementsInRange(numbers, 20, 90);

        // Выводим результат
        Console.WriteLine($"Количество элементов в отрезке [20, 90]: {countInRange}");
    }

    // Метод для подсчета элементов в массиве, значения которых лежат в заданном диапазоне
    static int CountElementsInRange(int[] array, int min, int max)
    {
        int count = 0;

        foreach (var number in array)
        {
            if (number >= min && number <= max)
            {
                count++;
            }
        }

        return count;
    }
}
