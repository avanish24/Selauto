using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using CorehrAut.Pages;
using CorehrAut.Navigation;
using CorehrAut.CommonCommands;
using CorehrAut;



namespace CoreHrTest
{
    [TestFixture]
    public class Reports : Include
    {
       [Test]
       public void User_can_login1()
        {

            Driver.Initialize();
            LoginPage.Goto();
            LoginPage.LoginAs(Driver.UserName).WithPassword(Driver.Password).Login();
            NUnit.Framework.Assert.IsTrue(IsAt.Page(Dashboard.pageItemCorehr), "Failed to Login");
            LoginPage.CloseBrowser();
            
         }

    }
}
