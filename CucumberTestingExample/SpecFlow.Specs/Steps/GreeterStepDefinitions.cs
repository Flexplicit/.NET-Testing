using FluentAssertions;
using Services;
using TechTalk.SpecFlow;

namespace SpecFlow.Specs.Steps
{
    [Binding]
    public sealed class GreeterStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private string _name;
        private string _actualGreetingMessage;


        public GreeterStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am ""(.*)""")]
        public void GivenIAm(string name)
        {
            _name = name;
            ;
        }

        [When("I use greeter")]
        public void WhenIUseGreeter()
        {
            var greeter = new Greeter();

            _actualGreetingMessage = greeter.Greet(_name);
        }


        [Then(@"I Should see ""(.*)""")]
        public void ThenIShouldSee(string greetingMessage)
        {
            greetingMessage.Should().Be(_actualGreetingMessage);
        }
    }
}