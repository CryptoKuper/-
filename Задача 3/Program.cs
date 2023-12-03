using System;

class Program
{
    static void Main()
    {
        // Создаем массив из вещественных чисел
        double[] numbers = new double[] { 12.34, 45.67, 89.12, 23.45, 56.78, 34.56, 78.90, 9.87, 65.43, 21.09 };

        // Находим разницу между максимальным и минимальным элементами массива
        double difference = FindDifference(numbers);

        // Выводим результат
        Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference:F2}");
    }

    // Метод для нахождения разницы между максимальным и минимальным элементами массива
    static double FindDifference(double[] array)
    {
        if (array.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым.");
        }

        double min = array[0];
        double max = array[0];

        // Находим минимальный и максимальный элементы массива
        foreach (var number in array)
        {
            if (number < min)
            {
                min = number;
            }

            if (number > max)
            {
                max = number;
            }
        }

        // Вычисляем разницу
        double difference = max - min;

        return difference;
    }
}
