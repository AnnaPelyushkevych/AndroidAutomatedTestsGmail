using Android_Home.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Android_Home.PageObjects
{
    public class SentLettersPage : BasePageObject
    {
        public bool IsSentLetterDisplayed(string emailSubject)
        {
            var letterSubject = $"//android.view.ViewGroup[contains(@text, '{emailSubject}')]";
            return AndroidDriverSingleton.GetAndroidDriver().FindElement(By.XPath(letterSubject)).Displayed;
        }
    }
}
