using System;
using System.Threading;
using OpenQA.Selenium;
using CorehrAut.CommonCommands;
using CorehrAut.Navigation;


namespace CorehrAut.Pages
{
    public class People
    {
        public static string pageItem
        {
            get
            {
                return ".aut-area-coreHr";
            }
        }
        public static void GoToPeople(PeopleAppFrom pageType)
        {

            Driver.wait(TimeSpan.FromSeconds(10));
            switch (pageType)
            {
                case PeopleAppFrom.Dashboard:
                    Dashboard.PeopleApp.Select();
                    break;
                case PeopleAppFrom.AppSwitcher:
                    Sidebar.AppSwitcher.PeoplePage.Select();
                    break;
            }


        }
        
        public static EmployeeCommand EmployeeFirstName(string firstName)
        {
            return new EmployeeCommand(firstName);
        }



        public class EmployeeCommand
        {
            public string firstName;
            public string lastName;

            public EmployeeCommand(string firstName)
            {
                this.firstName = firstName;
            }
            public EmployeeCommand WithLastName(string lastName)
            {
                this.lastName = lastName;
                return this;
            }
            public void AddEmployee()
            {
                if (Driver.Instance.Title.Equals("People"))
                {
                    Commands.Click(".aut-button-add");
                    Thread.Sleep(5000);
                    Commands.TypeText(".aut-input-xFirstName", firstName);
                    Commands.TypeText(".aut-input-xLastName", lastName);
                    Commands.TypeText(".aut-input-xEmail", firstName + Driver.dateAndTime + "@avanishmail.com");
                    Commands.TypeText(".aut-input-xEmployeeNumber", Driver.dateAndTime);
                    Commands.Click(".aut-input-xEmploymentStatusLookup", ".aut-area-xEmploymentStatusLookup table tbody tr[role]:nth-of-type(1) td:nth-of-type(3)");
                    Commands.TypeText(".aut-input-xStartDate", "02/19/2017" + Keys.Enter);
                    Commands.Click(".aut-input-xPositionLookup", ".aut-area-xPositionLookup table tbody tr[role]:nth-of-type(1) td:nth-of-type(3)");
                    Commands.Click(".aut-input-xLocationLookup", ".aut-area-xLocationLookup table tbody tr[role]:nth-of-type(1) td:nth-of-type(3)");
                    Commands.Click(".aut-dropdown-xEmployee-xRecordStatus", ".aut-button-activeOption");
                    Commands.Click(".aut-button-save");
                    Thread.Sleep(5000);
                  
                }
            }
                public void EditEmployee()
            {
                
                while (!Driver.Instance.Title.Equals("People"));
                Commands.TypeText("input[type='text']", firstName);
                Commands.Click(".aut-button-xEmployeeDetail:nth-of-type(1)");
                Commands.Click(".aut-button-edit");
                Commands.TypeText(".aut-input-xFirstName", firstName + Driver.dateAndTime);
                Commands.Click(".aut-button-save");
                Thread.Sleep(10000);
            }
            }
        }
    public enum PeopleAppFrom
    {
        Dashboard,
        AppSwitcher
    }
}

