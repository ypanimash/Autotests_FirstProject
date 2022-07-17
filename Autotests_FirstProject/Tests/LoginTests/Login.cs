using Autotests_FirstProject.Main;
using Autotests_FirstProject.Main.Constants;
using Autotests_FirstProject.Main.ProjectObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotests_FirstProject.Tests.LoginTests
{
    public class Login : Config
    {
        private readonly TimeMethods timeMethods = new TimeMethods();
        private readonly LoginPO _getLoginPO = new();

        [Test]
        public void SuccessfullyLogin()
        {
            LoginMainPage();

            Thread.Sleep(500);
            timeMethods.ExplicitWait(_getLoginPO.GetDDLUserNav());

            Assert.IsTrue(driver.FindElement(_getLoginPO.GetDDLUserNav()).Enabled);
        }



    }
}
