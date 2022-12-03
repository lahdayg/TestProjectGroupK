using System;
using TechTalk.SpecFlow;
using TestProjectGroupK.PageObject;

namespace TestProjectGroupK.StepDefinition
{
    [Binding]
    public class DataDrivenWithExampleSteps
    {
        DataDrivenWithExamplePage dataDrivenWithExamplePage;

        public DataDrivenWithExampleSteps()
        {
            dataDrivenWithExamplePage = new DataDrivenWithExamplePage();
        }





        [Given(@"the user enter Username ""(.*)""")]
        public void GivenTheUserEnterUsername(string username)
        {
            dataDrivenWithExamplePage.EnterUsername(username);
        }
        
        [Given(@"the User enter Email ""(.*)""")]
        public void GivenTheUserEnterEmail(string email)
        {
            dataDrivenWithExamplePage.EnterEmail(email);
        }
        
        [Given(@"the User enter password ""(.*)""")]
        public void GivenTheUserEnterPassword(string password)
        {
            dataDrivenWithExamplePage.EnterPassword(password);
        }
    }
}
