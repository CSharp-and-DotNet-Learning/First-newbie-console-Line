Console.WriteLine("Bonjour! comment t'appeles-tu ?");
string? rep = Console.ReadLine();

Console.WriteLine("Bonjour " + rep + " !");

Console.WriteLine("Quelle est ton année de naissance ?");
rep = Console.ReadLine();

int birthDay = int.Parse(rep);

int age = DateTime.Today.Year - birthDay;

Console.WriteLine($"Tu as ou vas avoir {age} ans en {DateTime.Today.Year}.");