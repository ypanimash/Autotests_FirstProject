using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotests_FirstProject.Main.ProjectObject
{
    public class LoginPO
    {


        private readonly By _loginField = By.XPath("//input[@id='swal-input1']");
        public By GetLoginField()
        {
            return _loginField;
        }


    }
}
