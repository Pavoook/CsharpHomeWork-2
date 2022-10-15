Console.WriteLine("Введите цифру, обозначающую день недели (где 1 - Пн):"); //Ввод данных
string value = Console.ReadLine();

bool check = int.TryParse(value, out int number); //Проверка, что введено целочисленное цифровое значение
if (check)
{
    number = int.Parse(value); //Парсинг в целочисленный формат
    if (number > 0  &  number < 6) //Обработка на соответствие будням
    {
        Console.Write("Нет.");
    }
    else
    {
        if (number == 6  ||  number == 7) //Обработка на соответсвие выходным
        {
            Console.Write("Да.");
        }
        else Console.Write("Ошибка: введены некорректные данные.");
    }
}
else Console.Write("Ошибка: введены некорректные данные.");