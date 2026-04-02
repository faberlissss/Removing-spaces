Console.WriteLine("Введіть декілька слів, розділених комою: ");

string userWords = Console.ReadLine();

string remSp = userWords.Replace(" ", "");

Console.WriteLine(remSp);