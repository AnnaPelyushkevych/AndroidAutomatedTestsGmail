using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_Home.CapabilitiesFactory
{
    public class CapabilitiesFactoryHelper
    {
        private static readonly string _platformName = "Android";
        private static readonly string _deviceName = "emulator-5554";
        //private static readonly string _udid = "emulator-5554";
        private static readonly string _appPackage = "com.google.android.gm";
        private static readonly string _appActivity = "com.google.android.gm.GmailActivity";
        private static readonly string _timeOut = "60";


        public static AppiumOptions GetCapabilities()
        {
            var capabilities = new AppiumOptions();
            
            //capabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, _platformName);
            capabilities.PlatformName = _platformName;
            //capabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, _deviceName);
            capabilities.DeviceName = _deviceName;
            //capabilities.AddAdditionalCapability(MobileCapabilityType.Udid, _udid);
            capabilities.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, _appPackage);
            capabilities.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, _appActivity);
            capabilities.AddAdditionalCapability(MobileCapabilityType.NewCommandTimeout, _timeOut);

            return capabilities;
        }

        public static Uri GetAppiumServerURL()
        {
            try
            {
                return new Uri("http://localhost:4723/wd/hub");
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
    }
}
