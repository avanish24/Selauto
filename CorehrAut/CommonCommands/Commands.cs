using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;



namespace CorehrAut.CommonCommands
{
    class Commands
    {
       
        public static void Element(string hookName)
        {
            try
            {
                Driver.Instance.FindElement(By.CssSelector(hookName));
                Driver.Instance.FindElements(By.CssSelector(hookName));
                Driver.wait(TimeSpan.FromSeconds(60));
                Console.WriteLine("Status : OK");
            }
            catch
            {
                Console.WriteLine($"Element : {0}, not found even after 60 seconds", hookName);
            }
            

        }
        public static void Click(string hookName)
        {
            try
            {

                Driver.Instance.FindElement(By.CssSelector(hookName)).Click();
                Driver.wait(TimeSpan.FromSeconds(5));
                Console.WriteLine($"Element : {0} found, Status : OK", hookName);
            }
            catch
            {
                Console.WriteLine($"Element : {0}, not found even after 60 seconds", hookName);
            }


        }
        public static void Click(string hookName, int number)
        {
            try
            {

                Driver.Instance.FindElements(By.CssSelector(hookName))[number].Click();
                Driver.wait(TimeSpan.FromSeconds(5));
                Console.WriteLine($"Element : {0} found, Status : OK", hookName);
            }

             catch
            {
                Console.WriteLine($"Element : {0} {1}, not found even after 60 seconds", hookName + number);
            }

        }
        public static void TypeText(string hookName, string text)
        {
            try
            {

                Driver.Instance.FindElement(By.CssSelector(hookName)).SendKeys(text);
                Driver.wait(TimeSpan.FromSeconds(5));
                Console.WriteLine($"Element : {0} found, Status : OK", hookName);
            }

            catch
            {
                Console.WriteLine($"Unable to send : {0}, to : {1}", text + hookName);
                //throw new Exception("Error Occured");
               
            }
        }
        public static void Click(string outerHookName, string innerHookName)
        {

            Driver.Instance.FindElement(By.CssSelector(outerHookName)).Click();
            Driver.wait(TimeSpan.FromSeconds(10));
            Driver.Instance.FindElement(By.CssSelector(innerHookName)).Click();
            Driver.wait(TimeSpan.FromSeconds(10));
        }
    }
}
