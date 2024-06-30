Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowUserStory/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Choisir le candidat gagnant au premier tour
	Given le nombre de voix exprimées est 100
	And resultat du tour
	| Nom | Nombre de voix |
	| A    | 30         |
	| B    | 15         |
	| C    | 55         |
	When le tour est terminé
	Then le candidat gagnant doit être "C"

Scenario: Choisir le candidat gagnant au deuxième tour
	Given le nombre de voix exprimées est 100
	And resultat du tour
	| Nom | Nombre de voix |
	| A    | 25         |
	| B    | 35         |
	| C    | 40         |
	When le tour est terminé
	Given le nombre de voix exprimées est 100
	And resultat du tour
	| Nom | Nombre de voix |
	| A   | 60          |
	| C   | 40          |
	When le tour est terminé
	Then le candidat gagnant doit être "A"

Scenario: Décider qu'il y a égalité au second tour
	Given le nombre de voix exprimées est 100
	And resultat du tour
	| Nom | Nombre de voix |
	| A    | 25         |
	| B    | 35         |
	| C    | 40         |
	When le tour est terminé
	Given le nombre de voix exprimées est 100
	And resultat du tour
	| Nom | Nombre de voix |
	| A   | 50          |
	| C   | 50          |
	When le tour est terminé
	Then il doit y avoir une égalité entre "A" et "C"

Scenario: Égaliter entre le 2ème et le 3ème candidat au premier tour
	Given le nombre de voix exprimées est 100
	And resultat du tour
	| Nom | Nombre de voix |
	| A    | 30         |
	| B    | 30         |
	| C    | 40         |
	When le tour est terminé
    Given le nombre de voix exprimées est 100
	And resultat du tour
	| Nom | Nombre de voix |
	| A   | 60          |
	| C   | 40          |
	When le tour est terminé
	Then le candidat gagnant doit être "A"

  Scenario: Gestion des votes blancs
	Given le nombre de voix exprimées est 100
	And resultat du tour
	| Nom | Nombre de voix |
	| A    | 40         |
	| B    | 60         |
	| Blanc| 100        |
	When le tour est terminé
	Then le candidat gagnant doit être "B"
