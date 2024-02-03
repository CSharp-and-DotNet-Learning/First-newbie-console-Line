byte?[] scoresJ1 = new byte?[5];
byte?[] scoresJ2 = { 2, 6, 7, 3, 5 };

scoresJ1[0] = 6;
scoresJ1[1] = 3;
scoresJ1[2] = 5;
scoresJ1[3] = 6;
scoresJ1[4] = 7;

// instruction for

for (int s = 0; s < scoresJ1.Length; s++)
{
    Console.WriteLine($"set {s + 1} : {scoresJ1[s]} - {scoresJ2[s]}");
}

int firstSetLoose = 0;
for (int i = 0; i < scoresJ1.Length; i++)
{
    Console.WriteLine(scoresJ1[i]);
    if (scoresJ1[i] < scoresJ2[i])
    {
        firstSetLoose = i + 1;
        break;
    }
}
Console.WriteLine($"N° du premier set perdu par le joueur 1 : {firstSetLoose}");

Console.WriteLine("Sets perdus par le joueur 1:");
for (int i = 0; i < scoresJ1.Length; i++)
{
    if (scoresJ1[i] > scoresJ2[i])
        continue;

    Console.WriteLine($"set {i + 1}");
}

//instruction foreach

int nbGamePoint = 0;
foreach (byte score in scoresJ1)
{
    nbGamePoint += score;
}

Console.WriteLine($"Le premier joueur a remporté {nbGamePoint} jeux.");

// Instruction do...while

bool inputOK = false;

do
{
    Console.WriteLine("Saisissez un chiffre entre 1 et 3.");
    string? rep = Console.ReadLine();
    if (rep == "1" || rep == "2" || rep == "3")
        inputOK = true;
} while (!inputOK);

while (!inputOK)
{
    Console.WriteLine("Saisissez un chiffre entre 1 et 3.");
    string? rep = Console.ReadLine();
    if (rep == "1" || rep == "2" || rep == "3")
        inputOK = true;
}