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
        //Select Lang
        private readonly By _btnUaLang = By.XPath("//div[@class='modal-content']//div[@class='modal-body clearfix']//a[@href='https://telemart.ua/ua/?change_language=1']");
        public By GetBtnUaLang()
        {
            return _btnUaLang;
        }
        private readonly By _btnRuLang = By.XPath("//div[@class='modal-content']//div[@class='modal-body clearfix']//a[@href='javascript: void(0);']");
        public By GetBtnRuLang()
        {
            return _btnRuLang;
        }

        //Login Window
        private readonly By _bntLoginToAcc = By.XPath("//div[@class='b-hts-col-userbox']//a[@href='#cPopupEnterTab']");
        public By GetBntLoginToAcc()
        {
            return _bntLoginToAcc;
        }
        private readonly By _fldEnterEMail = By.XPath("//div[@id='cPopupEnterTab']//input[@id='popupInputEnterMail']");
        public By GetFldEnterEMail()
        {
            return _fldEnterEMail;
        }
        private readonly By _fldPass = By.XPath("//div[@id='cPopupEnterTab']//input[@id='popupInputEnterPasw']");
        public By GetFldPass()
        {
            return _fldPass;
        }
        private readonly By _submitLogin = By.XPath("//div[@id='cPopupEnterTab']//button[@value='submitLogin']");
        public By GetSubmitLogin()
        {
            return _submitLogin;
        }

        //Main Page
        private readonly By _ddlUserNav = By.XPath("//div[@class='b-hts-col-userbox']//a[@id='dropdownUserNav']");
        public By GetDDLUserNav()
        {
            return _ddlUserNav;
        }



        

        private readonly By _loginField = By.XPath("//input[@id='swal-input1']");
        public By GetLoginField()
        {
            return _loginField;
        }


    }
}
