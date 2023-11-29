
using Data;



namespace MyApp;

internal class Program
{


    static void Main(string[] args)
    {
        Random random = new Random();
        Quizz d = new Quizz();
        string userInputLow;
        
        do
        {
            Console.WriteLine("Tapez 1 pour choisir un quiz aléatoire, tapez 2 pour choisir une catégorie, et tapez 3 pour quitter l'application.");
            userInputLow = d.UserLower();
            Console.Clear();
            if (userInputLow == "1" || userInputLow == "2" || userInputLow == "3")
            {
                switch (userInputLow)
                {
                    case "1":
                        d.NombreAleatoire = random.Next(1, 6);
                        userInputLow = d.NombreAleatoire.ToString();
                        break;
                    case "2":
                        Console.WriteLine("Liste des quiz : \n 1) Sport \n 2) Littérature \n 3) Technologie \n 4) Sciences \n 5) Gastronomie ");
                        userInputLow = d.UserLower();
                        Console.Clear();
                        break;
                    case "3":
                        d.IfExit();
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
                    case "technologie":
                        d.ThemeQuizz = "Technologie et informatique";
                        break;
                    case "4":
                    case "sciences":
                    case "science":
                        d.ThemeQuizz = "Sciences et nature";
                        break;
                    case "5":
                    case "cuisine":
                    case "gastronomie":
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
                           d.ProcessQuiz(d.SportPrincipal, d.SportSecondaire, d.SportNumber);
                           return;

                    case "Langues et littérature":
                           d.ProcessQuiz(d.LanguePrincipal, d.LangueSecondaire, d.LangueNumber);
                        return;

                    case "Technologie et informatique":
                         d.ProcessQuiz(d.TechnologiePrincipal, d.TechnologieSecondaire, d.TechnologieNumber);
                        return;

                    case "Sciences et nature":
                        d.ProcessQuiz(d.SciencesPrincipal, d.SciencesSecondaire, d.SciencesNumber);
                        return;

                    case "Cuisine et gastronomie":
                       d.ProcessQuiz(d.CuisinePrincipal, d.CuisineSecondaire, d.CuisineNumber);
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