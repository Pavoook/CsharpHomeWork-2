int[] weekdays = {1,2,3,4,5}; //Массивы, соответствующие типам дня недели
int[] weekends = {6,7};

bool Find(int[] collection, int find) //Метод, возвращающий логический результат успешности поиска значения в массиве
{
    bool result = false;
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        if (collection[index] == find)
        {
            result = true;
            break;
        }
        index++;
    }
    return result;
}

Console.WriteLine("Введите цифру, обозначающую день недели (где 1 - Пн):"); //Ввод данных
string value = Console.ReadLine();

bool check = int.TryParse(value, out int number); //Проверка, что введено целочисленное цифровое значение
if (check)
{
    number = int.Parse(value); //Парсинг в целочисленный формат
    if (number > 0  &  number < 8) //Проверка соответствия введенного значения дню недели
    {
        if (Find(weekdays, number)) Console.Write("Нет."); //Обработка и вывод результата
        if (Find(weekends, number)) Console.Write("Да.");
    }
    else Console.Write("Ошибка: введены некорректные данные.");
}
else Console.Write("Ошибка: введены некорректные данные.");