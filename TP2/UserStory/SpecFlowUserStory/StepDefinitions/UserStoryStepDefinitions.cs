using UserStory;

namespace SpecFlowUserStory.StepDefinitions

{
    [Binding]
    public sealed class UserStoryStepDefinitions
    {
        /*
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            throw new PendingStepException();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }
        */

        Scrutin scrutin = new Scrutin();
        int nombreVoixTotal;
        [Given(@"le nombre de voix exprimées est (.*)")]
        public void GivenLeNombreVoixTotalEst(int p0)
        {
            nombreVoixTotal = p0;
        }


        [Given(@"resultat du tour")]
        public void GivenResultatDuTour(Table table)
        {
            scrutin.candidats.Clear();
            foreach (var row in table.Rows)
            {
                // J'ai choisi d'afficher le pourcentage de vote blanc mais de ne pas le prendre en compte dans l'élection
                if (row["Nom"] == "Blanc")
                {
                    int pourcentageVoteBlanc = int.Parse(row["Nombre de voix"]) * 100 / (nombreVoixTotal + int.Parse(row["Nombre de voix"]));
                    Console.WriteLine("Pourcentage de vote blanc : " + pourcentageVoteBlanc);
                }
                else
                {
                    scrutin.candidats.Add(new Candidat(row["Nom"], int.Parse(row["Nombre de voix"]), nombreVoixTotal));
                }
            }
        }


        [When(@"le tour est terminé")]
        public void WhenLeTourEstTermine()
        {
            scrutin.AnalyserLeTour();
            scrutin.AfficherLesResultats();
        }

        [Then(@"le candidat gagnant doit être ""([^""]*)""")]
        public void ThenLeCandidatGagnantDoitEtre(string c)
        {
            scrutin.estCloture.Should().BeTrue();
            scrutin.aGagne(c).Should().BeTrue();
        }

        [Then(@"il doit y avoir une égalité entre ""([^""]*)"" et ""([^""]*)""")]
        public void ThenIlDoitYAvoirUneEgaliteEntreEt(string a, string c)
        {
            scrutin.estCloture.Should().BeTrue();
            scrutin.candidatGagnant.Should().BeNull();
        }

    }
}
