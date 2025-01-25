using System;

class Program
{
    static void Main()
    {
        // Запитуємо користувача про перше число
        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Запитуємо користувача про друге число
        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Обчислюємо суму
        double sum = num1 + num2;

        // Виводимо результат
        Console.WriteLine($"Сума двох чисел: {sum}");
    }
}