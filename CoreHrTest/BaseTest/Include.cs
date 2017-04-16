using System;
using CorehrAut.CommonCommands;
using CorehrAut.Navigation;
using NUnit.Framework;
using CorehrAut.Pages;
using CorehrAut;
using CorehrAut.Interfaces;
using CorehrAut.Configuration;
using CoreHrTest.Reporting;

namespace CoreHrTest
{
   [TestFixture]
    public class Include : SetupTearDown
    {
       [SetUp]
        public void Init()
        {
            IConfig config = new AppConfigReader();

            Driver.Initialize(config.GetBrowser());
            LoginPage.Goto();
            LoginPage.LoginAs(config.GetUsername()).WithPassword(config.GetPassword()).Login();
         }
        [TearDown]
        public void CleanUp()
        {
            LoginPage.CloseBrowser();
        }

    }
}
