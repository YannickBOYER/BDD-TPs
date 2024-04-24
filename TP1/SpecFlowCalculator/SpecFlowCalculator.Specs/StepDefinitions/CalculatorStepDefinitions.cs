using FluentAssertions;
namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly Calculator _calculator = new Calculator();


        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        private int _result;
        private String _resultString;

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Substract();
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            try { 
                _resultString = _calculator.Divide().ToString(); 
            }
            catch (Exception e) {
                _resultString = e.Message;
            }
        }


        [Then(@"the result string should be (.*)")]
        public void ThenTheResultStringShouldBe(string s)
        {
            _resultString.Should().Be(s);
        }

        [Given(@"the new number is (.*)")]
        public void GivenTheNewNumberIs(int number)
        {
            _calculator.Numbers.Add(number);
        }

        [When(@"the numbers are added")]
        public void WhenTheNumbersAreAdded()
        {
            _result = _calculator.AddAll();
        }

        [When(@"the numbers are subtracted")]
        public void WhenTheNumbersAreSubtracted()
        {
            _result = _calculator.SubtractAll();
        }

        [When(@"the numbers are multiplied")]
        public void WhenTheNumbersAreMultiplied()
        {
            _result = _calculator.MultiplyAll();
        }

        [When(@"the numbers are divided")]
        public void WhenTheNumbersAreDivided()
        {
            try
            {
                _resultString = _calculator.DivideAll().ToString();
            }
            catch (Exception e)
            {
                _resultString = e.Message;
            }
        }

    }
}
