Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

a = (a / 10) % 10;

Console.WriteLine($"Вторая цифра числа = {a}");