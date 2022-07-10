using Autotests_FirstProject.Main.Constants;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotests_FirstProject.Main
{
    public class TimeMethods : Config
    {
        public void ExplicitWait(By elementPath)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 05));
            wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = driver.FindElement(elementPath);
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
        }

        public void ThreadSleep()
        {
            Thread.Sleep(TimeConst.SLEEP);
            driver.Navigate().Refresh();
            Thread.Sleep(TimeConst.SLEEP);
        }
    }
}
