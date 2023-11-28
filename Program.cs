using System.Runtime.InteropServices;
using Data;


namespace MyApp;

internal class Program
{

    static void Main(string[] args)
    {
        Random random = new Random();




        Quizz d = new Quizz();
        do
        {
            Console.WriteLine("Tapez 1 pour choisir un quiz aléatoire, tapez 2 pour choisir une catégorie, et tapez 3 pour quitter l'application.");
            string? userInput = Console.ReadLine();
            string? userInputLow = userInput?.ToLower();
            Console.Clear();
            if (userInputLow == "1" || userInputLow == "2" || userInputLow == "3")
            {
                switch (userInput)
                {
                    case "1":
                        d.NombreAleatoire = random.Next(1, 6);
                        userInputLow = d.NombreAleatoire.ToString();


                        break;
                    case "2":
                        Console.WriteLine("Liste des quiz : \n 1) Sport \n 2) Littérature \n 3) Technologie \n 4) Sciences \n 5) Gastronomie ");
                        userInput = Console.ReadLine();
                        userInputLow = userInput?.ToLower();
                        Console.Clear();

                        break;
                    case "3":
                        Console.WriteLine("A bientôt");
                        Console.ReadLine();
                        return;
                }



                switch (userInputLow)
                {
                    case "1":
                    case "sport":
                        d.ThemeQuizz = "Sport";

                        break;
                    case "2":
                    case "littérature":
                    case "litterature":
                        d.ThemeQuizz = "Langues et littérature";
                        break;
                    case "3":
                        d.ThemeQuizz = "Technologie et informatique";
                        break;
                    case "4":
                        d.ThemeQuizz = "Sciences et nature";
                        break;
                    case "5":
                        d.ThemeQuizz = "Cuisine et gastronomie";
                        break;
                    default:
                        d.ThemeQuizz = "\"Rien du tout\"";
                        break;
                }
                Console.WriteLine($"La catégorie sélectionné est {d.ThemeQuizz}");
                switch (d.ThemeQuizz)
                {
                    case "Sport":
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(d.SportPrincipal[0][i]);
                            userInput = Console.ReadLine();
                            string? userInputLower = userInput?.ToLower();
                            string[] userInputSplit = userInput.Split(' ');

                            bool isCorrect = d.SportPrincipal[1][i]!.Split(' ')
                    .Any(expectedWord => userInputSplit.Any(userWord => userWord.ToLower() == expectedWord.ToLower()));
                            if (isCorrect)
                            {
                                Console.WriteLine("Bravo");
                                d.Score++;
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine($"Faux, la réponse est {d.SportPrincipal[1][i]}");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        d.ScoringView();
                        return;

                    case "Langues et littérature":
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(d.LanguePrincipal[0][i]);
                            userInput = Console.ReadLine();
                            string? userInputLower = userInput?.ToLower();
                            string[] userInputSplit = userInput.Split(' ');

                            bool isCorrect = d.LanguePrincipal[1][i]!.Split(' ')
                    .Any(expectedWord => userInputSplit.Any(userWord => userWord.ToLower() == expectedWord.ToLower()));
                            if (isCorrect)
                            {
                                Console.WriteLine("Bravo");
                                d.Score++;
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine($"Faux, la réponse est {d.LanguePrincipal[1][i]}");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        d.ScoringView();
                        return;

                    case "Technologie et informatique":
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(d.TechnologiePrincipal[0][i]);
                            userInput = Console.ReadLine();
                            string? userInputLower = userInput?.ToLower();
                            string[] userInputSplit = userInput.Split(' ');

                            bool isCorrect = d.TechnologiePrincipal[1][i]!.Split(' ')
                    .Any(expectedWord => userInputSplit.Any(userWord => userWord.ToLower() == expectedWord.ToLower()));
                            if (isCorrect)
                            {
                                Console.WriteLine("Bravo");
                                d.Score++;
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine($"Faux, la réponse est {d.TechnologiePrincipal[1][i]}");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        d.ScoringView();
                        return;

                    case "Sciences et nature":
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(d.SciencesPrincipal[0][i]);
                            userInput = Console.ReadLine();
                            string? userInputLower = userInput?.ToLower();
                            string[] userInputSplit = userInput.Split(' ');

                            bool isCorrect = d.SportPrincipal[1][i]!.Split(' ')
                    .Any(expectedWord => userInputSplit.Any(userWord => userWord.ToLower() == expectedWord.ToLower()));
                            if (isCorrect)
                            {
                                Console.WriteLine("Bravo");
                                d.Score++;
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine($"Faux, la réponse est {d.SciencesPrincipal[1][i]}");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        d.ScoringView();
                        return;

                    case "Cuisine et gastronomie":
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(d.CuisinePrincipal[0][i]);
                            Console.WriteLine("1) Trois propositions 2) Réponse libre");
                            userInput = Console.ReadLine();
                            if (userInput == "1" || userInput == "Trois propositions")
                            {
                                Console.WriteLine($" Réponse 1 : {d.CuisineSecondaire[i][0]} \n Réponse 2 : {d.CuisineSecondaire[i][1]} \n Réponse 3 : {d.CuisineSecondaire[i][2]} ");
                                userInput = Console.ReadLine();
                                if (userInput == d.CuisineNumber[i])
                                {
                                    Console.WriteLine("Bravo");
                                    d.Score++;
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine($"Faux, la réponse est {d.CuisinePrincipal[1][i]}");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            } else{ 
                                Console.WriteLine();
                                userInput = Console.ReadLine();
                            string? userInputLower = userInput?.ToLower();
                            string[] userInputSplit = userInput.Split(' ');

                            bool isCorrect = d.SportPrincipal[1][i]!.Split(' ')
                    .Any(expectedWord => userInputSplit.Any(userWord => userWord.ToLower() == expectedWord.ToLower()));
                            if (isCorrect)
                            {
                                Console.WriteLine("Bravo");
                                d.Score++;
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine($"Faux, la réponse est {d.CuisinePrincipal[1][i]}");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                             }


                            
                        d.ScoringView();
                        return;

                }
            }
            else
            {
                Console.WriteLine("Entrée non valide, veuillez choisir 1, 2 ou 3");
            }
        } while (true);
    }
}