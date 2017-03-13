using System;
using OpenQA.Selenium;
using CorehrAut.CommonCommands;

namespace CorehrAut.Navigation
{
    public class Sidebar
    {
        public class AppSwitcher
        {
            public class PeoplePage
            {
                public static void Select()
                {
                    AppSwitcher.Select(".aut-button-application-switcher");
                }
            }
            public static void Select(string tag)
            {
                var appSwitcher = Driver.Instance.FindElement(By.CssSelector(tag));
                while (!appSwitcher.Displayed)
                {
                    Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                }
                appSwitcher.Click();
            }
        }
    }
}