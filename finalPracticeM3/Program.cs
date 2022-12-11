Console.Write("Введите имя: ");
string myName = Console.ReadLine();

Console.Write("Введите возраст: ");
int myAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ваше имя {myName}, Вам {myAge} лет.");

Console.Write("Введите дату рождения: ");
DateTime myBirthDate = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine($"Дата Вашего роождения - {myBirthDate.ToShortDateString()}");