using Android_Home.PageObjects;

namespace Android_Home.BusinessObjects
{
    public class GmailBusinessObject
    {
        private readonly InitialPage _initialPage;
        private readonly HomePage _homePage;
        private readonly ComposeEmailPage _composeEmailPage;
        private readonly SentLettersPage _sentLetterPage;
        private readonly AllEmailsPage _allEmailsPage;

        public GmailBusinessObject()
        {
            _initialPage = new InitialPage();
            _homePage = new HomePage(); 
            _composeEmailPage = new ComposeEmailPage();
            _sentLetterPage = new SentLettersPage();
            _allEmailsPage = new AllEmailsPage();
        }

        public GmailBusinessObject SkipInitialPage()
        {
            _initialPage.ClickGotItBtn().ClickTakeMeToGmailBtn();
            return this;
        }

        public GmailBusinessObject SendLetter(string emailTo, string emailSubject, string emailBody)
        {
            _homePage.ClickComposeEmailBtn();

            _composeEmailPage.EnterEmail_To(emailTo)
                .EnterEmail_Subject(emailSubject)
                .EnterEmailBody(emailBody)
                .ClickSendEmail();
            return this;
        }

        public GmailBusinessObject OpenSentLetters()
        {
            _homePage.ClickOpenMenuBtn().ClickOnSentLettersMenuOption();
            return this;
        }

        public bool IsLetterSent(string subject)
        {
            return _sentLetterPage.IsSentLetterDisplayed(subject);
        }

        public GmailBusinessObject OpenAllLetters()
        {
            _homePage.ClickOpenMenuBtn().ClickOnAllemailsMenuOption();
            return this;
        }

        public int GetEmailsCount()
        {
            return _allEmailsPage.GetEmailsCount();
        }

        public GmailBusinessObject SelectAndDeleteFirstEmailInList()
        {
            _allEmailsPage.PerformLongTapOnFirstLetter();
            return this;
        }
    }
}
