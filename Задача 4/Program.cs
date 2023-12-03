using System;

class Program
{
    static void Main()
    {
        // Вводим натуральное число в диапазоне от 1 до 100000
        Console.Write("Введите натуральное число от 1 до 100000: ");
        int number = GetValidNumber();

        // Создаем массив из цифр числа
        int[] digitsArray = ConvertNumberToDigitsArray(number);

        // Выводим результат
        Console.WriteLine("Массив из цифр числа:");
        PrintArray(digitsArray);
    }

    // Метод для ввода натурального числа в заданном диапазоне
    static int GetValidNumber()
    {
        int number;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= 100000)
            {
                break;
            }
            else
            {
                Console.Write("Пожалуйста, введите корректное натуральное число от 1 до 100000: ");
            }
        }
        return number;
    }

    // Метод для преобразования числа в массив цифр
    static int[] ConvertNumberToDigitsArray(int num)
    {
        // Определяем количество цифр в числе
        int numDigits = (int)Math.Floor(Math.Log10(num) + 1);

        // Создаем массив цифр
        int[] digitsArray = new int[numDigits];

        // Заполняем массив цифрами числа
        for (int i = numDigits - 1; i >= 0; i--)
        {
            digitsArray[i] = num % 10;
            num /= 10;
        }

        return digitsArray;
    }

    // Метод для вывода массива на экран
    static void PrintArray(int[] array)
    {
        foreach (var digit in array)
        {
            Console.Write($"{digit} ");
        }
        Console.WriteLine();
    }
}
