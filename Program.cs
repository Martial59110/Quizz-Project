using Data;


namespace MyApp;

internal class Program
{

    static void Main(string[] args)
    {
        Random random = new Random();
        int nombreAleatoire;
       
        string themeQuizz = "";
        
        AllData d = new AllData();
        do{
        Console.WriteLine("Tapez 1 pour choisir un quiz aléatoire, tapez 2 pour choisir une catégorie, et tapez 3 pour quitter l'application.");
        string? userInput = Console.ReadLine();
        string? userInputLow = userInput?.ToLower();
        Console.Clear();
        if(userInputLow == "1" || userInputLow == "2" || userInputLow == "3"){
        switch (userInput)
        {
            case "1":
                nombreAleatoire = random.Next(1, 6);
                userInputLow = nombreAleatoire.ToString();
                

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
                themeQuizz = "Sport";
                
                break;
            case "2":
            case "littérature":
            case "litterature":
                themeQuizz = "Langues et littérature";
                break;
            case "3":
                themeQuizz = "Technologie et informatique";
                break;
            case "4":
                themeQuizz = "Sciences et nature";
                break;
            case "5":
                themeQuizz = "Cuisine et gastronomie";
                break;
            default:
                themeQuizz = "\"Rien du tout\"";
            break;
        }
        Console.WriteLine($"La catégorie sélectionné est {themeQuizz}");
        switch (themeQuizz)
        {
            case "Sport":
                for(int i = 0; i<10;i++){
                Console.WriteLine( d.SportPrincipal[0][i] );
                userInput = Console.ReadLine();
                string? userInputLower = userInput?.ToLower();
                  if (userInputLower == d.SportPrincipal[1][i].ToLower())
                {
                    Console.WriteLine("Bravo");
                    d.score++;
                }
                else
                {
                    Console.WriteLine($"Faux, la réponse est {d.SportPrincipal[1][i]}");
                    Console.ReadLine();
                    Console.Clear();
                }
                }
               d.Scoring();
                return;

             case "Langues et littérature":
                for(int i = 0; i<10;i++){
                Console.WriteLine( d.LanguePrincipal[0][i] );
                userInput = Console.ReadLine();
                string? userInputLower = userInput?.ToLower();
                  if (userInputLower == d.LanguePrincipal[1][i].ToLower())
                {
                    Console.WriteLine("Bravo");
                    d.score++;
                }
                else
                {
                    Console.WriteLine($"Faux, la réponse est {d.LanguePrincipal[1][i]}");
                    Console.ReadLine();
                    Console.Clear();
                }
                }
                d.Scoring();
                return;

            case "Technologie et informatique":
             for(int i = 0; i<10;i++){
                Console.WriteLine( d.TechnologiePrincipal[0][i] );
                userInput = Console.ReadLine();
                string? userInputLower = userInput?.ToLower();
                  if (userInputLower == d.TechnologiePrincipal[1][i].ToLower())
                {
                    Console.WriteLine("Bravo");
                    d.score++;
                }
                else
                {
                    Console.WriteLine($"Faux, la réponse est {d.TechnologiePrincipal[1][i]}");
                    Console.ReadLine();
                    Console.Clear();
                }
                }
                d.Scoring();
                return;

            case "Sciences et nature":
             for(int i = 0; i<10;i++){
                Console.WriteLine( d.SciencesPrincipal[0][i] );
                userInput = Console.ReadLine();
                string? userInputLower = userInput?.ToLower();
                  if (userInputLower == d.SciencesPrincipal[1][i].ToLower())
                {
                    Console.WriteLine("Bravo");
                    d.score++;
                }
                else
                {
                    Console.WriteLine($"Faux, la réponse est {d.SciencesPrincipal[1][i]}");
                    Console.ReadLine();
                    Console.Clear();
                }
                }
                 d.Scoring();
                return;

             case "Cuisine et gastronomie":
                for(int i = 0; i<10;i++){
                Console.WriteLine( d.CuisinePrincipal[0][i] );
                userInput = Console.ReadLine();
                string? userInputLower = userInput?.ToLower();
                  if (userInputLower == d.CuisinePrincipal[1][i].ToLower())
                {
                    Console.WriteLine("Bravo");
                    d.score++;
                }
                else
                {
                    Console.WriteLine($"Faux, la réponse est {d.CuisinePrincipal[1][i]}");
                    Console.ReadLine();
                    Console.Clear();
                }
                }
                d.Scoring();
                return;

        }
    }else{
        Console.WriteLine("Entrée non valide, veuillez choisir 1, 2 ou 3");
    }}while (true);
}
}