using DartGame;
namespace SpecFlowDartGame.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        DartBoard dartBoard;
        Player winner;
        private Exception _actualException;

        [Given(@"the game mode is '(.*)'")]
        public void CreateTheGame(string gameMode)
        {
            dartBoard = new DartBoard(gameMode);
        }

        [Given(@"player (.*) to play")]
        public void GivenPlayerToPlay(int playerId, Table table)
        {

            Round round = new Round();
            foreach (var row in table.Rows)
            {
                round.Areas.Add(int.Parse(row["Area"]));
                round.Multipliers.Add(int.Parse(row["Multiplier"]));
            }
            try
            {
                dartBoard.Players[playerId - 1].PlayATurn(round);
            }
            catch (Exception e)
            {
                _actualException = e;
            }
        }

        [When(@"the game is finished")]
        public void WhenTheGameIsFinished()
        {
            if (dartBoard.Players[0].Score == 0)
            {
                winner = dartBoard.Players[0];
            }
            else if (dartBoard.Players[1].Score == 0)
            {
                winner = dartBoard.Players[1];
            }
            else
            {
                throw new Exception("Error, there is no winner.");
            }
        }

        [Then(@"the winner should be the player (.*)")]
        public void ThenTheWinnerIsThePlayer(int p0)
        {
            Console.WriteLine("The winner is player " + winner.Id);
            winner.Id.Should().Be(p0);
        }

        [Then(@"the error '(.*)' should be raised")]
        public void ThenTheErrorShouldBeRaised(string expectedErrorMessage)
        {
            _actualException.Should().NotBeNull();
            _actualException.Message.Should().Be(expectedErrorMessage);
        }

        [Then(@"the player (.*) should need (.*) points to end the game")]
        public void ThenThePlayerShouldNeedPointsToEndTheGame(int p0, int p1)
        {
            dartBoard.Players[p0 - 1].Score.Should().Be(p1);
        }


    }
}
