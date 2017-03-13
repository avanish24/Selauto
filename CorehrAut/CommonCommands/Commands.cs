using System;
using OpenQA.Selenium;

namespace CorehrAut.CommonCommands
{
    class Commands
    {
        public static void Element(string hookName)
        {
            Driver.Instance.FindElement(By.CssSelector(hookName));
            Driver.Instance.FindElements(By.CssSelector(hookName));
            Driver.wait(TimeSpan.FromSeconds(5));
        }
        public static void Click(string hookName)
        {
            Driver.Instance.FindElement(By.CssSelector(hookName)).Click(); 
            Driver.wait(TimeSpan.FromSeconds(5));
          
        }
        public static void Click(string hookName, int number)
        {
            Driver.Instance.FindElements(By.CssSelector(hookName))[number].Click();
            Driver.wait(TimeSpan.FromSeconds(5));
        }
        public static void TypeText(string hookName, string text)
        {
            Driver.Instance.FindElement(By.CssSelector(hookName)).SendKeys(text);
            Driver.wait(TimeSpan.FromSeconds(5));
        }
        public static void Click(string outerHookName, string innerHookName)
        {
            Driver.Instance.FindElement(By.CssSelector(outerHookName)).Click();
            Driver.wait(TimeSpan.FromSeconds(10));
            Driver.Instance.FindElement(By.CssSelector(innerHookName)).Click();
            Driver.wait(TimeSpan.FromSeconds(10));
        }
        public enum SelectorType
        {
            CssSelector,
            LinkText,
            Xpath,
            PartialLinkText,
            ClassName,
            Id,
            TagName,
            Name

        }
    }
}
