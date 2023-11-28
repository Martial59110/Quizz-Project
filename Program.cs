namespace MyApp;

internal class Program
{

    static void Main(string[] args)
    {
        Random random = new Random();
        int nombreAleatoire;
       
        string themeQuizz = "";
        int score = 0;
        string[][] SportPrincipal = new string[2][];
        SportPrincipal[0] = new string[] {
                                        "Question : Quel joueur de basket-ball est souvent surnommé \"King James\" ?",
                                         "Question : En quelle année les Jeux olympiques d'été modernes ont-ils été relancés ?",
                                        "Question : Quel est le seul pays à avoir participé à chaque Coupe du Monde de la FIFA depuis son commencement en 1930 ?", 
                                        " Question : Qui détient le record du monde du saut à la perche en athlétisme (hommes) ?",
                                         "Question : Quelle équipe de football a remporté le plus grand nombre de Ligues des champions de l'UEFA ?",
                                         "Question : Quel est le sport principal des Jeux olympiques d'hiver ?",
                                         "Question : Qui est souvent appelé \"The Greatest\" et est considéré comme l'un des plus grands boxeurs de tous les temps ?",
                                         "Question : Quel pays a remporté le plus grand nombre de médailles d'or aux Jeux olympiques d'été de 2016 ?",
                                         "Question : Quel est le seul golfeur à avoir remporté les quatre tournois majeurs au cours de la même année calendaire ?",
                                         "Question : Combien de joueurs composent une équipe de water-polo dans l'eau lors d'un match ?"
                                         };

        SportPrincipal[1] = new string[] {"Lebron James", "1896", "Brésil", "Renaud Lavillenie", "Real Madrid", "Le ski", "Muhammad Ali", "États-Unis", "Bobby Jones", "Six"};
        string[][] LanguePrincipal = new string[2][];
        LanguePrincipal[0] = new string[] {
                                            "Question : Qui est l'auteur de la série de romans \"Harry Potter\" ?",
                                            "Question : Quel est le titre du célèbre roman de George Orwell décrivant une dystopie totalitaire ?",
                                            "Question : Qui a écrit la tragédie classique \"Roméo et Juliette\" ?",
                                            "Question : Quel est le nom du héros dans le roman \"Le Comte de Monte-Cristo\" d'Alexandre Dumas ? ",
                                            "Question : Quel auteur a écrit \"Orgueil et Préjugés\" ?",
                                            "Question : Quel écrivain français est célèbre pour ses œuvres \"Les Misérables\" et \"Notre-Dame de Paris\" ?",
                                            "Question : Qui est l'auteur de la série de livres fantastiques \"Le Seigneur des Anneaux\" ?",
                                            "Question : Quelle écrivaine britannique a créé le détective Hercule Poirot ?",
                                            "Question : Quel roman d'Aldous Huxley décrit une société future où la population est sous contrôle total ?",
                                            "Question : Qui a écrit le roman épistolaire \"Les Liaisons Dangereuses\" ?"
                                            
        };
         LanguePrincipal[1] = new string[] {"J.K. Rowling", "1984", " William Shakespeare", "Edmond Dantès", "Jane Austen", "Victor Hugo", "J.R.R. Tolkien", "Agatha Christie", "Le Meilleur des mondes", "Pierre Choderlos de Laclos"};
         string[][] TechnologiePrincipal = new string[2][];
         TechnologiePrincipal[0] = new string[]{
                                            "Question : Quelle entreprise est derrière le développement du système d'exploitation Windows ?",
                                            "Question : Quel fondateur de SpaceX et Tesla est également cofondateur de PayPal ?",
                                            "Question : Qu'est-ce que le terme \"URL\" signifie en informatique ?",
                                            "Question : Quelle est la plus grande plateforme de médias sociaux au monde en termes d'utilisateurs actifs ?",
                                            "Question : Quel est le langage de programmation souvent utilisé pour le développement web côté serveur ?",
                                            "Question : Quelle technologie sans fil permet le transfert de données sur de courtes distances entre des appareils tels que des téléphones, des ordinateurs et des enceintes ?",
                                            "Question : Quel est le nom du système d'exploitation open source basé sur le noyau Linux, utilisé par de nombreux smartphones ?",
                                            "Question : Quel terme désigne une attaque informatique où des pirates bloquent l'accès à un système ou à des fichiers jusqu'à ce qu'une rançon soit payée ?",
                                            "Question : Quel est le nom de la première programmation informatique basée sur des instructions symboliques plutôt que sur des signaux électriques directs ?",
                                            "Question : Quelle entreprise a été fondée par Steve Jobs, Steve Wozniak et Ronald Wayne en 1976 ?"

         };
         TechnologiePrincipal[1] = new string[]{"Microsoft", "Elon Musk", "Uniform Resource Locator", "Facebook", "PHP", "Bluetooth", "Android", "Ransomware", "Fortran", "Apple Inc"};
         string[][] SciencesPrincipal = new string[2][];
         SciencesPrincipal[0] = new string[] {
                                            "Question : Quel est l'élément le plus abondant dans l'univers ?",
                                            "Question : Quelle est l'unité de mesure de la force dans le système international ?",
                                            "Question : Quelle est la plus grande planète du système solaire ?",
                                            "Question : Quel est le processus par lequel les plantes fabriquent leur propre nourriture en utilisant la lumière du soleil ?",
                                            "Question : Quel physicien a formulé la théorie de la relativité restreinte ?",
                                            "Question : Quel est l'organe du corps humain responsable de la production d'insuline et de la régulation du taux de glucose sanguin ?",
                                            "Question : Quelle est la couche la plus externe de l'atmosphère terrestre ?",
                                            "Question : Quel est le nom de la réaction nucléaire qui alimente le soleil ?",
                                            "Question : Quelle est la particule subatomique chargée négativement ?",
                                            "Question : Quel inventeur et scientifique a développé la théorie de l'électromagnétisme et a formulé les lois de l'induction électromagnétique ?"
                                            
                                            };
        SciencesPrincipal[1] = new string[] {
                                            "L'hydrogène",
                                            "Le newton",
                                            "Jupiter",
                                            "La photosynthèse",
                                            "Albert Einstein",
                                            "Le pancréas",
                                            "La thermosphère",
                                            "La fusion nucléaire",
                                            "L'électron",
                                            "Michael Faraday"
        };
        string[][] CuisinePrincipal = new string[2][];
        do{
        Console.WriteLine("Tapez 1 pour choisir un quiz aléatoire, tapez 2 pour choisir une catégorie, et tapez 3 pour quitter l'application.");
        string? userInput = Console.ReadLine();
        string? userInputLow = userInput?.ToLower();
        if(userInputLow == "1" || userInputLow == "2" || userInputLow == "3"){
        switch (userInput)
        {
            case "1":
                nombreAleatoire = random.Next(1, 5);
                userInputLow = nombreAleatoire.ToString();
                

                break;
            case "2":
                Console.WriteLine("Liste des quiz : \n 1) Sport \n 2) Littérature \n 3) Technologie \n 4) Sciences \n 5) Gastronomie ");
                userInput = Console.ReadLine();
                userInputLow = userInput?.ToLower();

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
                Console.WriteLine( SportPrincipal[0][i] );
                userInput = Console.ReadLine();
                string? userInputLower = userInput?.ToLower();
                  if (userInputLower == SportPrincipal[1][i].ToLower())
                {
                    Console.WriteLine("Bravo");
                    score++;
                }
                else
                {
                    Console.WriteLine($"La réponse est {SportPrincipal[1][i]}");
                }
                }
                Console.WriteLine($"-------------------------------------------");
                Console.WriteLine($"\nVotre Score est de {score}.");
                Console.ReadLine();
                return;

             case "Langues et littérature":
                for(int i = 0; i<10;i++){
                Console.WriteLine( LanguePrincipal[0][i] );
                userInput = Console.ReadLine();
                string? userInputLower = userInput?.ToLower();
                  if (userInputLower == LanguePrincipal[1][i].ToLower())
                {
                    Console.WriteLine("Bravo");
                    score++;
                }
                else
                {
                    Console.WriteLine($"La réponse est {LanguePrincipal[1][i]}");
                }
                }
                Console.WriteLine($"-------------------------------------------");
                Console.WriteLine($"\nVotre Score est de {score}.");
                Console.ReadLine();
                return;

            case "Technologie et informatique":
             for(int i = 0; i<10;i++){
                Console.WriteLine( TechnologiePrincipal[0][i] );
                userInput = Console.ReadLine();
                string? userInputLower = userInput?.ToLower();
                  if (userInputLower == TechnologiePrincipal[1][i].ToLower())
                {
                    Console.WriteLine("Bravo");
                    score++;
                }
                else
                {
                    Console.WriteLine($"La réponse est {TechnologiePrincipal[1][i]}");
                }
                }
                Console.WriteLine($"-------------------------------------------");
                Console.WriteLine($"\nVotre Score est de {score}.");
                Console.ReadLine();
                return;

            case "Sciences et nature":
             for(int i = 0; i<10;i++){
                Console.WriteLine( SciencesPrincipal[0][i] );
                userInput = Console.ReadLine();
                string? userInputLower = userInput?.ToLower();
                  if (userInputLower == SciencesPrincipal[1][i].ToLower())
                {
                    Console.WriteLine("Bravo");
                    score++;
                }
                else
                {
                    Console.WriteLine($"La réponse est {SciencesPrincipal[1][i]}");
                }
                }
                 Console.WriteLine($"-------------------------------------------");
                Console.WriteLine($"\nVotre Score est de {score}.");
                Console.ReadLine();
                return;

        }
    }else{
        Console.WriteLine("Entrée non valide, veuillez choisir 1, 2 ou 3");
    }}while (true);
}
}