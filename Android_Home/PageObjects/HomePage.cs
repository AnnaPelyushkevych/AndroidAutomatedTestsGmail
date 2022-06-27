using Android_Home.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.MultiTouch;
using SeleniumExtras.PageObjects;

namespace Android_Home.PageObjects
{
    public class HomePage : BasePageObject
    {
        [FindsBy(How = How.Id, Using = "com.google.android.gm:id/compose_button")]
        private IWebElement _composeEmailBtn;

        [FindsBy(How = How.XPath, Using = "//android.widget.ImageButton[@content-desc='Open navigation drawer']")]
        private IWebElement _openMenuBtn;

        [FindsBy(How = How.XPath, Using = "//android.widget.FrameLayout[contains(@resource-id, 'drawer_content')]//android.widget.TextView[contains(@text, 'Sent')]")]
        private IWebElement _sentLettersBtn;

        [FindsBy(How = How.XPath, Using = "//android.widget.FrameLayout[contains(@resource-id, 'drawer_content')]//android.widget.TextView[contains(@text, 'All mail')]")]
        private IWebElement _allLettersBtn;

        public HomePage ClickComposeEmailBtn()
        {
            AndroidDriverSingleton.WaitForElementVisibility(By.Id("com.google.android.gm:id/compose_button"));
            _composeEmailBtn.Click();
            return this;
        }

        public HomePage ClickOpenMenuBtn()
        {
            _openMenuBtn.Click();
            return this;
        }

        public HomePage ClickOnSentLettersMenuOption()
        {
            _sentLettersBtn.Click();
            return this;
        }

        public HomePage ClickOnAllemailsMenuOption()
        {
            _allLettersBtn.Click();
            return this;
        }
    }
}
