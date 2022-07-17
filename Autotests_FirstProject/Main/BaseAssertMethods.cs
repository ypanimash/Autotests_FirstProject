using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotests_FirstProject.Main
{
    public class BaseAssertMethods : Config
    {

        public string GetDisplayData(By element)
            => driver.FindElement(element).Displayed.ToString();
        public string GetEnabledData(By element)
            => driver.FindElement(element).Enabled.ToString();
        public string GetAttributeValue(By element)
            => driver.FindElement(element).GetAttribute("value");
    }
}
