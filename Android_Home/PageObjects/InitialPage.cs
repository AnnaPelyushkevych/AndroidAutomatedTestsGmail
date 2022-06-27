using Android_Home.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Android_Home.PageObjects
{
    public class InitialPage : BasePageObject
    {
        private const string _registeredUsersLocator = "com.google.android.gm:id/setup_addresses_list";

        [FindsBy(How = How.Id, Using = "com.google.android.gm:id/welcome_tour_got_it")]
        private IWebElement _gotItBtn;

        [FindsBy(How = How.Id, Using = "com.google.android.gm:id/action_done")]
        private IWebElement _takeMeToGmailBtn;

        public InitialPage ClickGotItBtn()
        {
            _gotItBtn.Click();
            return this;
        }

        public InitialPage ClickTakeMeToGmailBtn()
        {
            AndroidDriverSingleton.WaitForElementVisibility(By.Id(_registeredUsersLocator));
            _takeMeToGmailBtn.Click();
            return this;
        }

    }
}
