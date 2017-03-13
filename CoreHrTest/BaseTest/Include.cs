using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CorehrAut.CommonCommands;
using CorehrAut.Navigation;
using CorehrAut.Pages;
using CorehrAut;

namespace CoreHrTest
{
    
    public class Include
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
            LoginPage.Goto();
            LoginPage.LoginAs(Driver.UserName).WithPassword(Driver.Password).Login();
         }
        [TestCleanup]
        public void CleanUp()
        {
            LoginPage.CloseBrowser();
        }

    }
}
