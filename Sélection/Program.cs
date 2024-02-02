using System.Net.Http.Headers;

Console.WriteLine("Bonjour! comment t'appeles-tu ?");
string? rep = Console.ReadLine();

Console.WriteLine("Bonjour " + rep + " !");

Console.WriteLine("Quelle est ton année de naissance ?");
rep = Console.ReadLine();

int birthDay = int.Parse(rep);

const int yearMin = 1900;
if (birthDay >= yearMin && birthDay <= DateTime.Today.Year)
{
    int age = DateTime.Today.Year - birthDay;
    Console.WriteLine($"Tu as ou vas avoir {age} ans en {DateTime.Today.Year}");

    string tranche = string.Empty;
    /*
if (age <= 25)
    tranche = "moins de 25 ans";
else if (age >= 25 && age < 40)
    tranche = "25 - 40ans";
else if (age >= 40 && age < 55)
    tranche = "40 - 55 ans";
else
    tranche = "plus de 55 ans";
*/

    switch (age)
    {
        case < 25:
            tranche = "moins de 25 ans";
            break;

        case < 40:
            tranche = "25 - 40ans";
            break;

        case < 55:
            tranche = "40 - 55ans";
            break;

        default:
            tranche = "plus de 55ans";
            break;
    }

    Console.WriteLine($"Ta tranche d'$age est : {tranche}.");
}
else
{
    Console.WriteLine($"Ton année de naissance doit être comprise entre {yearMin} et {DateTime.Today.Year} !");
}

Console.WriteLine("As-tu un code de réduction (O/N) ?");
rep = Console.ReadLine();

bool reduc = (rep == "O") ? true : false;

Console.WriteLine(birthDay < 2000 ? "Tu est né au 20éme siècle" : "Tu es né au 21éme siècle");