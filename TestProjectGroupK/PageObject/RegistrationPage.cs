using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectGroupK.Utilities;

namespace TestProjectGroupK.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.CssSelector("input[type='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));
        IWebElement GlobalFeed => driver.FindElement(By.XPath("(//a[@class='nav-link'])[5]"));


        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername()
        {
            Username.SendKeys("Williams15521134465");
        }

        public void EnterEmail()
        {
            Email.SendKeys("demo100677623234@example.com");
        }


        public void EnterPassword()
        {
            Password.SendKeys("PasswordSecure");
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }

        public bool IsGlobalFeedDisplayed()
        {
            return GlobalFeed.Displayed;
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }










    }
}
