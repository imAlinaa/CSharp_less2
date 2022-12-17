Console.WriteLine("Введите номер дня недели:");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay < 1 || numberDay > 7)
{
    Console.WriteLine("Вы ввели некорректное число!");
}
else if (numberDay > 5 && numberDay <= 7)
{
    Console.WriteLine("Это выходной день!");
}
else
{
    Console.WriteLine("Это не выходной день.");
}