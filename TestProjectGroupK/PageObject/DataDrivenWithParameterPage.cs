using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectGroupK.Utilities;

namespace TestProjectGroupK.PageObject
{
    class DataDrivenWithParameterPage
    {
        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.CssSelector("input[type='email']"));
        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement Skills => driver.FindElement(By.XPath("//select[@id='Skills']"));


        public void EnterUsername(string username)
        {
            Username.SendKeys(username);
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }


        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void SelectSkillsFromDrpdown()
        {
            SelectElement select = new SelectElement(Skills);
            select.SelectByIndex(4);
        }






    }
}
