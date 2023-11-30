using Data;

namespace meth;

class Methodes
{
    public string ThemeQuizz { get; set; }
    public int Score { get { return score; } set { score = value; } }
    public int NombreAleatoire { get; set; }
    



    private int score;
    public void SetThemeQuizz(Methodes m, string userInputLow)
    {
        switch (userInputLow)
        {
            case "1":
            case "sport":
                m.ThemeQuizz = "Sport";
                break;
            case "2":
            case "littérature":
                m.ThemeQuizz = "Langues et littérature";
                break;
            case "3":
            case "technologie":
                m.ThemeQuizz = "Technologie et informatique";
                break;
            case "4":
            case "sciences":
            case "science":
                m.ThemeQuizz = "Sciences et nature";
                break;
            case "5":
            case "cuisine":
            case "gastronomie":
                m.ThemeQuizz = "Cuisine et gastronomie";
                break;
            default:
                m.ThemeQuizz = "Rien du tout";
                break;
        }

        Console.WriteLine($"La catégorie sélectionné est {m.ThemeQuizz}");


    }
    public Methodes()
    {
        ThemeQuizz = "";

    }


    public void ScoringFinalView()
    {
        Console.WriteLine("Le quizz est maintenant terminé.");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine($"\nVotre Score est de {score}.");
        Console.ReadLine();
    }


    public void ScoringUpdate(Methodes m)
    {

        Score++;
        Console.Write($"Bravo, votre score est maintenant de {m.Score} !");
        Console.ReadLine();
        Console.Clear();
    }


    public void BadAnswer(string tableau)
    {
        Console.WriteLine($"Faux, la réponse est {tableau}");
        Console.ReadLine();
        Console.Clear();
    }


    public void IfExit()
    {
        Console.WriteLine("A bientôt");
        Console.ReadLine();
    }



    public string UserLower()
    {

        string? userInput = Console.ReadLine();
        string? userInputLow = userInput?.ToLower();
        return userInputLow;
    }



    public void ProcessQuiz(string[][] principal, string[][] secondaire, string[] numbers)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(principal[0][i]);

            Console.WriteLine($" Réponse 1 : {secondaire[i][0]} \n Réponse 2 : {secondaire[i][1]} \n Réponse 3 : {secondaire[i][2]} ");
            string userInputLow = UserLower();
            if (userInputLow == numbers[i] || userInputLow == principal[1][i].ToLower())
            {
                ScoringUpdate(this);
            }
            else
            {
                BadAnswer(principal[1][i]);
            }
        }

        ScoringFinalView();
    }

    public void QuizContainer(Methodes m, Quizz d)
    {
switch (m.ThemeQuizz)
                {
                    case "Sport":
                        m.ProcessQuiz(d.SportPrincipal, d.SportSecondaire, d.SportNumber);
                        return;

                    case "Langues et littérature":
                        m.ProcessQuiz(d.LanguePrincipal, d.LangueSecondaire, d.LangueNumber);
                        return;

                    case "Technologie et informatique":
                        m.ProcessQuiz(d.TechnologiePrincipal, d.TechnologieSecondaire, d.TechnologieNumber);
                        return;

                    case "Sciences et nature":
                        m.ProcessQuiz(d.SciencesPrincipal, d.SciencesSecondaire, d.SciencesNumber);
                        return;

                    case "Cuisine et gastronomie":
                        m.ProcessQuiz(d.CuisinePrincipal, d.CuisineSecondaire, d.CuisineNumber);
                        return;

                }



    }
 

}