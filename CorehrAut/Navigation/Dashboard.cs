using System;
using OpenQA.Selenium;
using System.Threading;
using CorehrAut.CommonCommands;


namespace CorehrAut.Navigation
{
    public class Dashboard 
    {
        public static string pageItemCorehr
        {
            get
       
            { return ".aut-area-dashboard"; }
        }
        public static string pageItemSocial
        {
            get

            { return ".aut-area-social"; }
        }
        public class PeopleApp
        {
            public static void Select()
            {
                Dashboard.Select("People");
            }
        }

        public class TimeOffApp
        {
            public static void Select()
            {
                Dashboard.Select("Time Off");
            }
        }

        public static void Select(string tag)
        {

           Driver.Instance.FindElement(By.LinkText(tag)).Click();
            if (!Driver.Instance.FindElement(By.LinkText(tag)).Displayed)
            {
                Driver.wait(TimeSpan.FromMilliseconds(5));
                if (!Driver.Instance.FindElement(By.LinkText(tag)).Displayed)
                    {
                        throw new Exception("Element Not Found ");

                    }
                
            }
        }
        
        public static void Post()
        {
            Commands.TypeText(".aut-textarea-socialFeed-post", "Test Post");
            Commands.Click(".aut-button-socialFeed-post");
            Thread.Sleep(10000);

        }
        public static bool PostIsPresent
        {
            get
            {
                var post = Driver.Instance.FindElements(By.CssSelector(".aut-label-userMessage"));

                if (post.Count > 0)
                {
                    return post[0].Text == "Test Post";
                }
                return false;
            }
        }
            public static void DeletePost()
        {
 
                var postPresent = Driver.Instance.FindElements(By.CssSelector(".aut-label-userMessage"));
            if (postPresent.Count>0)
            {
                if (postPresent[0].Text=="Test Post")
                {
                    Commands.Click(".aut-button-socialFeed-post-actions", 1);
                    Driver.wait(TimeSpan.FromSeconds(6));
                    Commands.Click(".aut-button-socialFeed-post-action-delete", 0);
                    Commands.Click(".aut-button-socialFeed-dialog-delete", 0);
                }
                else
                {
                    return ;
                }
            }
            else
            {
                return;
            }
            Thread.Sleep(4000);
        }

    }
        
}

