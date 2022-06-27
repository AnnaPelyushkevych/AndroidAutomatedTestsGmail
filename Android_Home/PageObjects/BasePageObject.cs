using Android_Home.Driver;
using SeleniumExtras.PageObjects;

namespace Android_Home.PageObjects
{
    public class BasePageObject
    {
        public BasePageObject()
        {
            PageFactory.InitElements(AndroidDriverSingleton.GetAndroidDriver(), this);
        }
    }
}
