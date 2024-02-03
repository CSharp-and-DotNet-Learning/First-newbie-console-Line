// Les crochets après le type indiquent qu’il s’agit d’un tableau. La deuxième partie de l’instruction après le signe égal permet de réserver la place en mémoire pour les éléments du tableau. Ici nous réservons 5 places pour des bytes. J’utilise le type byte, car le score d’un joueur ne dépassera jamais 255 (valeur maxi d’un byte).
byte?[] scoresJ1 = new byte?[5];
byte?[] scoresJ2 = {2, 6, 7, 3, 5};

scoresJ1[0] = 6;
scoresJ1[1] = 3;
scoresJ1[2] = 5;
scoresJ1[3] = 6;
scoresJ1[4] = 7;

Console.WriteLine(scoresJ2.Length); //5

string[] list = { "chou", "riz", "cacao"};

string sentence = "Le c# est une langage moderne et puissant !";

char car = sentence[4]; //#

//Chaque joueur a un score pour chaque set, donc le tableau est de taille [2, 5], où 2 représente les deux joueurs et 5 les cinq sets.
byte?[,] scores = new byte?[2, 5];
// Initialisation des scores pour le Joueur 1
scores[0, 0] = 6; // Score du Joueur 1 dans le Set 1
scores[0, 1] = 3; // Score du Joueur 1 dans le Set 2
scores[0, 2] = 5; // Score du Joueur 1 dans le Set 3
scores[0, 3] = 4; // Score du Joueur 1 dans le Set 4
scores[0, 4] = 9; // Score du Joueur 1 dans le Set 5

// Initialisation des scores pour le Joueur 2
scores[1, 0] = 2; // Score du Joueur 2 dans le Set 1
scores[1, 1] = 6; // Score du Joueur 2 dans le Set 2
scores[1, 2] = 7; // Score du Joueur 2 dans le Set 3
scores[1, 3] = 8; // Score du Joueur 2 dans le Set 4
scores[1, 4] = 1; // Score du Joueur 2 dans le Set 5

byte?[,] scores2 = { { 6, 2 }, { 3, 6 }, { 5, 7 }, { 6, 3 }, { 7, 5 } };