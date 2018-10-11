using Xunit;
using Xunit.Gherkin.Quick;

namespace QuickTest.StepDefinitions
{
    [FeatureFile("./FeatureFiles/FeatureOne.feature")]
    public sealed class FeatureOneSteps : Feature
    {
        private int _Answer = 0;

        [When(@"I add 1 plus 1")]
        public void IAdd1Plus1()
        {
            _Answer = 1 + 1;
        }

        [Then(@"the answer should be 2")]
        public void TheAnswerShouldBe2()
        {
            Assert.Equal(2, _Answer);
        }
    }
}