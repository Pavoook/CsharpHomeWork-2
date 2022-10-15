Console.WriteLine("Введите целое число (цифрами):"); //Ввод данных
string value = Console.ReadLine();

bool check = int.TryParse(value, out int number); //Проверка, что введено целочисленное цифровое значение
if (check)
{
    number = int.Parse(value); //Парсинг в целочисленный формат
    if (number > 99 || number < -99) //Проверка наличия в числе третьего разряда
    {
        int decadeDigit = number / 100 % 10; //Вычисление значения третьего разряда

        Console.Write("Третья цифра этого числа: "); //Вывод результата, с учетом отрицательных значений
        Console.Write(Math.Abs(decadeDigit));
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