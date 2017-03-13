using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using CorehrAut.CommonCommands;
using CorehrAut.Navigation;

namespace CorehrAut.Pages
{
    public class LoginPage
    {
        //Refactor : should have a general menu system;
        public static void Goto()
        {
            Driver.Instance.Manage().Window.Maximize();
            Driver.Instance.Navigate().GoToUrl(Driver.BaseUrl);
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.Equals("Log In"));
        }

        public static void CloseBrowser()
        {
            Driver.Instance.Close();
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }
    }

    public class LoginCommand
    {
        public readonly string userName;
        public string password;
        public LoginCommand(string userName)
        {
            this.userName = userName;
        }
        
        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()
        {
            Commands.TypeText(".aut-input-username", userName);
            Commands.TypeText(".aut-input-password", password);
            Commands.Click(".aut-button-login");
            Driver.wait(TimeSpan.FromSeconds(10));
         }

        
    }
}
