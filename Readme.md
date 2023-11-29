# Quiz en C#
Ce projet est un quiz en C# qui met à l'épreuve les connaissances des utilisateurs dans différentes catégories telles que le sport, la littérature, la technologie, les sciences et la gastronomie. Le quiz est implémenté en console, offrant une expérience utilisateur simple et interactive.

## Comment exécuter le projet
Assurez-vous d'avoir .NET Core installé sur votre machine.

## Récupérer le projet
Bienvenue! Pour récupérer le projet, suivez ces étapes :
1) Clonez le dépôt en utilisant la commande suivante :

![alt text](https://i.postimg.cc/bwxfMNQ9/github.png)

2) Accédez au répertoire du projet avec la commande :

"cd nom-du-repertoire"

## Lancer le projet

Pour lancer le projet, ouvrez un terminal, accédez au répertoire du projet, puis exécutez la commande :

"dotnet run" depuis un terminal.

###### Note: Assurez-vous d'exécuter la commande dotnet run depuis un terminal dans le répertoire du projet.

## Les étapes de mon quiz :


Choisissez entre un quiz aléatoire, une catégorie spécifique ou quittez l'application.

Si vous choisissez un quiz aléatoire, une catégorie est sélectionnée au hasard.

Si vous choisissez une catégorie, vous devez choisir entre 5 catégories disponibles.

Répondez aux questions posées dans la catégorie choisie.

Obtenez votre score à la fin du quiz.

Le quiz comprend les catégories suivantes :

- Sport
- Langues et littérature
- Technologie et informatique
- Sciences et nature
- Cuisine et gastronomie

Profitez du quiz et testez vos connaissances dans ces domaines passionnants !

### Récupérer la liste des questions

Pour récupérer la liste des questions du quizz, vous pouvez utiliser la méthode ProcessQuiz de la classe Quizz. Cette méthode prend en paramètres les tableaux principaux, secondaires et les nombres associés à chaque question. Voici comment vous pouvez l'utiliser dans votre code.

![alt text](https://i.postimg.cc/jqWsdTHy/obj.png)
![alt text](https://i.postimg.cc/RhG8LNfg/c1.png)

Répétez cette opération pour chaque thème que vous souhaitez inclure dans votre quizz, en remplaçant les arguments de la méthode par les tableaux correspondants.

N'oubliez pas de personnaliser l'appel de la méthode en fonction du thème que vous souhaitez utiliser dans votre quizz.