using Android_Home.Driver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Android_Home.PageObjects
{
    public class ComposeEmailPage : BasePageObject
    {
        [FindsBy(How = How.Id, Using = "com.google.android.gm:id/to")]
        private IWebElement _emailTo_input;

        [FindsBy(How = How.Id, Using = "com.google.android.gm:id/subject")]
        private IWebElement _emailSubject_input;

        [FindsBy(How = How.XPath, Using = "//android.widget.LinearLayout[contains(@resource-id, 'wc_body_layout')]//descendant::android.widget.EditText")]
        private IWebElement _emailBody_input;

        [FindsBy(How = How.Id, Using = "com.google.android.gm:id/send")]
        private IWebElement _email_SendBtn;

        public ComposeEmailPage EnterEmail_To(string toString)
        {
            _emailTo_input.SendKeys(toString);
            return this;
        }

        public ComposeEmailPage EnterEmail_Subject(string subject)
        {
            _emailSubject_input.SendKeys(subject);
            return this;
        }

        public ComposeEmailPage EnterEmailBody(string subject)
        {
            _emailBody_input.SendKeys(subject);
            return this;
        }

        public ComposeEmailPage ClickSendEmail()
        {
            _email_SendBtn.Click();
            return this;
        }
    }
}
