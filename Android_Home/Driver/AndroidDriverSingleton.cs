//using OpenQA.Selenium.Appium.Android;
using Android_Home.CapabilitiesFactory;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Android_Home.Driver
{
    public class AndroidDriverSingleton
    {
        //private static AndroidDriver<AndroidElement> driver; 
        private static AndroidDriver _driver;

        private AndroidDriverSingleton() { }

        //public static AndroidDriver<AndroidElement> GetAndroidDriver()
        public static AndroidDriver GetAndroidDriver()
        {
            if (_driver == null)
            {
                //driver = new AndroidDriver<AndroidElement>(CapabilitiesFactoryHelper.GetAppiumServerURL(), CapabilitiesFactoryHelper.GetCapabilities());
                _driver = new AndroidDriver(CapabilitiesFactoryHelper.GetAppiumServerURL(), CapabilitiesFactoryHelper.GetCapabilities());
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
            return _driver;
        }

        public static void WaitForElementVisibility(By locator)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            //wait.Until(ExpectedConditions.ElementIsVisible(By.Id("com.google.android.gm:id/setup_addresses_list")));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void QuitDriver()
        {
            _driver.Quit(); 
        }
    }
}
