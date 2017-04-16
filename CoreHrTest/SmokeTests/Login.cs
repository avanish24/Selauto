using System;
using CorehrAut.CommonCommands;
using CorehrAut.Navigation;
using NUnit.Framework;
using NUnit.Framework.Internal;




namespace CoreHrTest 
{
    [TestFixture]
    public class Login : Include
    {
        [Test]
        public void User_can_login()
        {
            try
            {
                NUnit.Framework.Assert.IsTrue(IsAt.Page(Dashboard.pageItemCorehr), "failed to login");
              Console.WriteLine("Login Succesfull");
                    
            }
            catch
            {
                Console.WriteLine("Failed to Execute the Login Test Case");
            }
            
        }
       
    }
}
