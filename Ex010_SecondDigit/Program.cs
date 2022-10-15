Console.WriteLine("Введите целое трехзначное число (цифрами):"); //Ввод данных
string value = Console.ReadLine();

bool check = int.TryParse(value, out int number); //Проверка, что введено целочисленное цифровое значение
if (check)
{
    number = int.Parse(value); //Парсинг в целочисленный формат
    if ((number > 99  &  number < 1000) || (number < -99  &  number > -1000)) //Проверка числа на трехзначность
    {
        int decadeDigit = number / 10 % 10; //Вычисление значения второго разряда

        Console.Write("Вторая цифра этого числа: "); //Вывод результата, с учетом отрицательных значений
        Console.Write(Math.Abs(decadeDigit));
    }
    else
    {
        Console.Write("Ошибка: это не трехзначное число.");
    }
}
else
{
    Console.Write("Ошибка: введены не целочисленные или не цифровые данные.");
}