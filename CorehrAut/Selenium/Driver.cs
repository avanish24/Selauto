using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace CorehrAut
{
    public class Driver
    {
        public static DateTime d= DateTime.Now;
        public static IWebDriver Instance { get; set; }
        public static string BaseUrl
        {
            get { 
                return "https://corehr.qa.neogov.net"; }
        }

        public static void NoWait(Action action)
        {
            TurnOffWait();
            action();
            TurnOnWait();
        }

        public static void TurnOnWait()
        {
            wait(TimeSpan.FromSeconds(10));
        }

        public static void TurnOffWait()
        {
            wait(TimeSpan.FromSeconds(0));
        }

        public static string dateAndTime
        {
            get
            {
                return d.ToString("yyyyMMddHHmmssfff");
            }
        }
      
        public static string Password
        { get
            {return "Welcome$2u";
            }
        }
        public static string UserName
        {
            get
            {
                return "Admin+withwm@neogov.com";
            }
        }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
            TurnOnWait();
        }
        public static void wait(TimeSpan timeSpan)
        {
            Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds((int) timeSpan.TotalSeconds *1000);
            //Thread.Sleep((int) timeSpan.TotalSeconds * 1000);
        }
        }
    }