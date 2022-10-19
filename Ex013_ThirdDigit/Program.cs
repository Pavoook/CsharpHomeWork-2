Console.WriteLine("Введите целое число (цифрами):"); // Ввод данных
string value = Console.ReadLine();

bool check = int.TryParse(value, out int number); // Проверка, что введено целочисленное цифровое значение
if (check)
{
    number = int.Parse(value); // Парсинг в целочисленный формат
    if (number > 99 || number < -99) // Проверка наличия в числе третьего разряда
    {
        while (number > 999 || number < -999) number = number / 10; // Нахождение третьей цифры
        number = number % 10;
        Console.Write("Третья цифра этого числа: "); //Вывод результата, с учетом отрицательных значений
        Console.Write(Math.Abs(number));
    }
    else
    {
        Console.Write("Третьей цифры нет.");
    }
}
else
{
    Console.Write("Ошибка: введены не целочисленные или не цифровые данные.");
}