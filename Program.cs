using System.Runtime.InteropServices;
using Data;
using Newtonsoft.Json;
using System.IO;

namespace MyApp;

internal class Program
{


    static void Main(string[] args)
    {
        Random random = new Random();



        string? userChoice;
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
                          
                                Console.WriteLine($" Réponse 1 : {d.SportSecondaire[i][0]} \n Réponse 2 : {d.SportSecondaire[i][1]} \n Réponse 3 : {d.SportSecondaire[i][2]} ");
                                userInput = Console.ReadLine();
                                string? userInputLower = userInput?.ToLower();
                                if (userInputLower == d.SportNumber[i] || userInputLower == d.SportPrincipal[1][i].ToLower())
                                {
                                    d.ScoringUpdate(d);
                                }
                                else
                                {
                                    d.BadAnswer(d.SportPrincipal[1][i]);
                                }
                            } 
                               
                        d.ScoringView();
                        return;

                    case "Langues et littérature":
                           for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(d.LanguePrincipal[0][i]);
                          
                                Console.WriteLine($" Réponse 1 : {d.LangueSecondaire[i][0]} \n Réponse 2 : {d.LangueSecondaire[i][1]} \n Réponse 3 : {d.LangueSecondaire[i][2]} ");
                                userInput = Console.ReadLine();
                                string? userInputLower = userInput?.ToLower();
                                if (userInputLower == d.LangueNumber[i] || userInputLower == d.LanguePrincipal[1][i].ToLower())
                                {
                                    d.ScoringUpdate(d);
                                }
                                else
                                {
                                    d.BadAnswer(d.LanguePrincipal[1][i]);
                                }
                            } 
                               
                        d.ScoringView();
                        return;

                    case "Technologie et informatique":
                           for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(d.TechnologiePrincipal[0][i]);
                          
                                Console.WriteLine($" Réponse 1 : {d.TechnologieSecondaire[i][0]} \n Réponse 2 : {d.TechnologieSecondaire[i][1]} \n Réponse 3 : {d.TechnologieSecondaire[i][2]} ");
                                userInput = Console.ReadLine();
                                string? userInputLower = userInput?.ToLower();
                                if (userInputLower == d.TechnologieNumber[i] || userInputLower == d.TechnologiePrincipal[1][i].ToLower())
                                {
                                    d.ScoringUpdate(d);
                                }
                                else
                                {
                                    d.BadAnswer(d.TechnologiePrincipal[1][i]);
                                }
                            } 
                               
                        d.ScoringView();
                        return;

                    case "Sciences et nature":
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(d.SciencesPrincipal[0][i]);
                          
                                Console.WriteLine($" Réponse 1 : {d.SciencesSecondaire[i][0]} \n Réponse 2 : {d.SciencesSecondaire[i][1]} \n Réponse 3 : {d.SciencesSecondaire[i][2]} ");
                                userInput = Console.ReadLine();
                                string? userInputLower = userInput?.ToLower();
                                if (userInputLower == d.SciencesNumber[i] || userInputLower == d.SciencesPrincipal[1][i].ToLower())
                                {
                                    d.ScoringUpdate(d);
                                }
                                else
                                {
                                    d.BadAnswer(d.SciencesPrincipal[1][i]);
                                }
                            } 
                               
                        d.ScoringView();
                        return;

                    case "Cuisine et gastronomie":
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(d.CuisinePrincipal[0][i]);
                          
                                Console.WriteLine($" Réponse 1 : {d.CuisineSecondaire[i][0]} \n Réponse 2 : {d.CuisineSecondaire[i][1]} \n Réponse 3 : {d.CuisineSecondaire[i][2]} ");
                                userInput = Console.ReadLine();
                                string? userInputLower = userInput?.ToLower();
                                if (userInputLower == d.CuisineNumber[i] || userInputLower == d.CuisinePrincipal[1][i].ToLower())
                                {
                                    d.ScoringUpdate(d);
                                }
                                else
                                {
                                    d.BadAnswer(d.CuisinePrincipal[1][i]);
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