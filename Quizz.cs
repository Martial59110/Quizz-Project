
namespace Data;

class Quizz
{
    public string[][] SportPrincipal { get; private set; } = new string[2][];
    public string[][] SportSecondaire { get; private set; } = new string[10][];
    public string[] SportNumber { get; private set; } = new string[] { };
    public string[][] LanguePrincipal { get; private set; } = new string[2][];
    public string[][] LangueSecondaire { get; private set; } = new string[10][];
    public string[] LangueNumber { get; private set; } = new string[] { };
    public string[][] TechnologiePrincipal { get; private set; } = new string[2][];
    public string[][] SciencesPrincipal { get; private set; } = new string[2][];
    public string[][] CuisinePrincipal { get; private set; } = new string[2][];
    public string[][] CuisineSecondaire { get; private set; } = new string[10][];
    public string[] CuisineNumber { get; private set; } = new string[] { };

    public int Score { get { return score; } set { score = value; } }
    public int NombreAleatoire { get; set; }

    public string ThemeQuizz { get; set; }

    private int score;
    private int i;



    public Quizz()
    {
        ThemeQuizz = "";
        InitialiserDonnees();
    }
    private void InitialiserDonnees()
    {

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

        SportPrincipal[1] = new string[] { "Lebron James", "1896", "Brésil", "Renaud Lavillenie", "Real Madrid", "Le ski", "Muhammad Ali", "États-Unis", "Tiger Woods", "Sept" };

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
        LanguePrincipal[1] = new string[] { "J.K. Rowling", "1984", " William Shakespeare", "Edmond Dantès", "Jane Austen", "Victor Hugo", "J.R.R. Tolkien", "Agatha Christie", "Le Meilleur des mondes", "Pierre Choderlos de Laclos" };

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
        TechnologiePrincipal[1] = new string[]{"Microsoft",
                                                "Elon Musk",
                                                "Uniform Resource Locator",
                                                 "Facebook",
                                                "PHP",
                                                "Bluetooth",
                                                "Android",
                                                 "Ransomware",
                                                "Fortran",
                                                    "Apple Inc"};

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
        CuisinePrincipal[0] = new string[]{
                                            "Question : Quel est l'ingrédient principal du guacamole mexicain ?",
                                            "Question : Quelle technique de cuisson implique l'utilisation de vapeur pour cuire les aliments ?",
                                            "Question : Quel type de pâtes longues et fines est souvent associé à la cuisine italienne ?",
                                            "Question : Quelle herbe aromatique est souvent utilisée dans la cuisine méditerranéenne, notamment dans le pesto ?",
                                            "Question : Quel est le plat traditionnel japonais de riz vinaigré garni de poisson cru, d'œufs et de légumes ?",
                                            "Question : Quelle technique de cuisson rapide utilise une grande quantité de chaleur et une poêle ou un wok ?",
                                            "Question : Quel est le nom du plat italien constitué de fines tranches de viande ou de légumes roulées et farcies ?",
                                            "Question : Quel est le principal ingrédient de la pâte feuilletée ?",
                                            "Question : Quelle boisson gazeuse, souvent utilisée comme ingrédient dans les cocktails, contient des extraits de cola et de la caféine ?",
                                            "Question : Quel est le plat traditionnel français à base de viande braisée, de lardons, de champignons et d'oignons cuits dans du vin rouge ?"

        };
        CuisinePrincipal[1] = new string[]{
                                            "Avocat",
                                            "Cuisson à la vapeur",
                                            "Spaghettis",
                                            "Basilic",
                                            "Sushi",
                                            "Sauté",
                                            "Involtinis",
                                            "Beurre",
                                            "Cola",
                                            "Boeuf bourguignon"
        };

        {

            CuisineSecondaire[0] = new string[] { "Tomate", "Citron vert", "Avocat" };


            CuisineSecondaire[1] = new string[] { "La cuisson à la vapeur", "Griller", "Friture" };


            CuisineSecondaire[2] = new string[] { "spaghettis", "Ravioli", "Farfalle" };


            CuisineSecondaire[3] = new string[] { "Cumin", "basilic", "Persil" };

            CuisineSecondaire[4] = new string[] { "Ramen", "Tempura", "sushi" };

            CuisineSecondaire[5] = new string[] { "Bouillir", "Mijoter", "sauté" };


            CuisineSecondaire[6] = new string[] { "Lasagne", "involtinis", "Cannelloni" };


            CuisineSecondaire[7] = new string[] { "Beurre", "Levure", "huile" };


            CuisineSecondaire[8] = new string[] { "Sprite", "Ginger Ale", "cola" };


            CuisineSecondaire[9] = new string[] { "boeuf bourguignon", "Coq au Vin", "Bouillabaisse" };

            CuisineNumber = new string[] { "3", "1", "1", "2", "3", "3", "2", "1", "3", "1" };


        };
        {

            SportSecondaire[0] = new string[] { "John James", "Lebron James", "Kévin James" };


            SportSecondaire[1] = new string[] { "1896", "1920", "1853" };


            SportSecondaire[2] = new string[] { "Espagne", "Brésil", "France" };


            SportSecondaire[3] = new string[] { "Ernest John Obiena", "Jacques Goldman", "Renaud Lavillenie" };

            SportSecondaire[4] = new string[] { "Le FC Milan ", "Les Smiley Kickers", "Real Madrid" };

            SportSecondaire[5] = new string[] { "Le Ski", "Le hockey sur glace", "La pétanque" };


            SportSecondaire[6] = new string[] { "Mike Tyson", "Muhammad Ali", "Joe Frazier" };


            SportSecondaire[7] = new string[] { "La Chine", "Les États-Unis", "La France" };


            SportSecondaire[8] = new string[] { "Phil Mickelson", "Bobby Jones", "Tiger Woods" };


            SportSecondaire[9] = new string[] { "Sept", "Huit", "Neuf" };

            SportNumber = new string[] { "2", "1", "2", "3", "3", "1", "2", "2", "3", "1" };


        };
        {

            LangueSecondaire[0] = new string[] { "Jk Rowling", "Stephen King", "Laétitia Colombani" };


            LangueSecondaire[1] = new string[] { "1984", "Le Monde d'hier", "VOYAGE AU BOUT DE LA NUIT" };


            LangueSecondaire[2] = new string[] { "William Wordsworth", "William Shakespeare", "Christopher Marlowe" };


            LangueSecondaire[3] = new string[] { "Athos", "Edmond Dantès", "Edmond Lavillenie" };

            LangueSecondaire[4] = new string[] { "Emily Dickinson", "Charlotte Brontë", "Jane Austen" };

            LangueSecondaire[5] = new string[] { "Victor Hugo", "Gustave Flaubert", "Fiodor Dostoïevski" };


            LangueSecondaire[6] = new string[] { "HP Lovecraft", "C.S. Lewis", "JRR Tolkien" };


            LangueSecondaire[7] = new string[] { "Dorothy L. Sayers", "Agatha Christie", "Thierry Landouillard" };


            LangueSecondaire[8] = new string[] { "Fahrenheit 451", "Le Meilleur des mondes", "Area 51" };


            LangueSecondaire[9] = new string[] { "Pierre Choderlos de Laclos", "Gustave Flaubert", "Victor Hugo" };

            LangueNumber = new string[] { "1", "1", "2", "2", "3", "1", "3", "2", "2", "1" };


        };
    }









    public void ScoringView()
    {
        Console.WriteLine($"-------------------------------------------");
        Console.WriteLine($"\nVotre Score est de {score}.");
        Console.ReadLine();
    }
    public void ScoringUpdate(Quizz d)
    {

        Score++;
        Console.WriteLine($"Bravo, votre score est maintenant de {d.Score} !");
        Console.ReadLine();
        Console.Clear();
    }
    public void BadAnswer(string tableau)
    {
        Console.WriteLine($"Faux, la réponse est {tableau}");
        Console.ReadLine();
        Console.Clear();
    }
}