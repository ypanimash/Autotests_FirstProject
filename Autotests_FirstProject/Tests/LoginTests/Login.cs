using Autotests_FirstProject.Main;
using Autotests_FirstProject.Main.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotests_FirstProject.Tests.LoginTests
{
    public class Login : Config
    {


        [Test]
        public void SuccessfullyLogin()
        {
           // LoggerConst.TestName = "SuccessfullyLogin";

           // LoginMainPage();
            

            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(TimeConst.IMPLICIT_WAIT);

            //ActDisplayDropDownList = GetDisplayData(_getLoginPageP.GetDropDownList());
            //ActDisplayMenuServices = GetDisplayData(_getLoginPageP.GetMenuServices());
            //ActDisplayMenuMain = GetDisplayData(_getLoginPageP.GetMenuMain());

            //_getLoginPageP.AssertSuccessfullyLogin();
        }

    }
}
