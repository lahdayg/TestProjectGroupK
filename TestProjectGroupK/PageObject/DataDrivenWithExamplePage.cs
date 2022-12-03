using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectGroupK.Utilities;

namespace TestProjectGroupK.PageObject
{
    class DataDrivenWithExamplePage
    {
        public DataDrivenWithExamplePage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.CssSelector("input[type='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));

        public void EnterUsername(string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys(username + randomInt);
            //Username.SendKeys(username);
        }

        public void EnterEmail(string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys(email + randomInt + "@demo.com");
            //Email.SendKeys(email);
        }


        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }










    }
}
