using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CorehrAut.CommonCommands;
using CorehrAut.Navigation;
using CorehrAut.Pages;



namespace CoreHrTest 
{
    [TestClass]
    public class Login : Include
    {
        
        [TestMethod]
        public void User_can_login()
        {
            Assert.IsTrue(IsAt.Page(Dashboard.pageItemCorehr), "failed to login");
            
        }
       
    }
}
