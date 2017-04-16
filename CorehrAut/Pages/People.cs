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
                return Keywords.coreHrPeoplePageAreaHook;
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
                    Commands.Click(Keywords.addButtonHook);
                    Thread.Sleep(5000);
                    Commands.TypeText(Keywords.employeeFirstNameHook, firstName);
                    Commands.TypeText(Keywords.employeeLastNameHook, lastName);
                    Commands.TypeText(Keywords.employeeEmailHook, firstName + Driver.dateAndTime + "@avanishmail.com");
                    Commands.TypeText(Keywords.employeeNumberHook, Driver.dateAndTime);
                    Commands.Click(Keywords.employementStatusLookupHook, ".aut-area-xEmploymentStatusLookup table tbody tr[role]:nth-of-type(1) td:nth-of-type(3)");
                    Commands.TypeText(Keywords.employeeStartDateHook, "02/19/2017" + Keys.Enter);
                    Commands.Click(Keywords.employeePositionLookupHook, ".aut-area-xPositionLookup table tbody tr[role]:nth-of-type(1) td:nth-of-type(3)");
                    Commands.Click(Keywords.employeeLocationLookupHook, ".aut-area-xLocationLookup table tbody tr[role]:nth-of-type(1) td:nth-of-type(3)");
                    Commands.Click(Keywords.employeeRecordStatusLookupHook, Keywords.activeOptionHook );
                    Commands.Click(Keywords.saveButtonHook);
                    Thread.Sleep(5000);
                  
                }
            }
                public void EditEmployee()
            {
                
                while (!Driver.Instance.Title.Equals("People"));
                Commands.TypeText("input[type='text']", firstName);
                Commands.Click(".aut-button-xEmployeeDetail:nth-of-type(1)");
                Commands.Click(Keywords.employeeEditHook);
                Commands.TypeText(Keywords.employeeFirstNameHook, firstName + Driver.dateAndTime);
                Commands.Click(Keywords.saveButtonHook);
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

