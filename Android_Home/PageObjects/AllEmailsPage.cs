using Android_Home.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_Home.PageObjects
{
    public class AllEmailsPage : BasePageObject
    {
        [FindsBy(How = How.XPath, Using = "//android.view.ViewGroup//android.widget.ImageView[contains(@resource-id, 'contact_image')]")]
        private IList<IWebElement> _emailsList;

        [FindsBy(How = How.Id, Using = "com.google.android.gm:id/delete")]
        private IWebElement _deleteBtn;

        public int GetEmailsCount()
        {
            return _emailsList.ToList().Count;
        }

        public AllEmailsPage PerformLongTapOnFirstLetter()
        {
            var firstEmail = _emailsList.ToList().FirstOrDefault();
            firstEmail.Click();
            _deleteBtn.Click();


            return this;
        }
    }
}
