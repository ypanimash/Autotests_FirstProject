using Autotests_FirstProject.Main;
using Autotests_FirstProject.Main.Constants;
using Autotests_FirstProject.Main.ProjectObject;

namespace Autotests_FirstProject.Tests.LoginTests
{
    public class Login : Config
    {
        private readonly TimeMethods timeMethods = new();
        private readonly LoginPO _getLoginPO = new();

        [Test]
        public void SuccessfullyLogin()
        {
            LoginMainPage(LoginConst.UserLogin, LoginConst.UserPass);

            timeMethods.ExplicitWait(_getLoginPO.GetDDLUserNav());
            Assert.IsTrue(driver.FindElement(_getLoginPO.GetDDLUserNav()).Enabled);  
        }

        [Test]
        public void NotSuccessfullyLogin_NotValidPass()
        {
            LoginMainPage(LoginConst.UserLogin, LoginConst.NotValidUserPass);

            timeMethods.ExplicitWait(_getLoginPO.GetNotificationNotValidPassOrLogin());
            Assert.IsTrue(driver.FindElement(_getLoginPO.GetNotificationNotValidPassOrLogin()).Enabled);
        }

        [Test]
        public void NotSuccessfullyLogin_NotValidLogin()
        {
            LoginMainPage(LoginConst.NotValidUserLogin, LoginConst.UserPass);

            timeMethods.ExplicitWait(_getLoginPO.GetNotificationNotValidPassOrLogin());
            Assert.IsTrue(driver.FindElement(_getLoginPO.GetNotificationNotValidPassOrLogin()).Enabled);
        }

        [Test]
        public void NotSuccessfullyLogin_NotValidLoginAndPass()
        {
            LoginMainPage(LoginConst.NotValidUserLogin, LoginConst.NotValidUserPass);

            timeMethods.ExplicitWait(_getLoginPO.GetNotificationNotValidPassOrLogin());
            Assert.IsTrue(driver.FindElement(_getLoginPO.GetNotificationNotValidPassOrLogin()).Enabled);
        }

        [Test]
        public void NotSuccessfullyLogin_EmptyLoginAndPass()
        {
            LoginMainPage(String.Empty, String.Empty);

            timeMethods.ExplicitWait(_getLoginPO.GetNotificationNotValidPassOrLogin());
            Assert.IsTrue(driver.FindElement(_getLoginPO.GetNotificationNotValidPassOrLogin()).Enabled);
        }
    }
}
