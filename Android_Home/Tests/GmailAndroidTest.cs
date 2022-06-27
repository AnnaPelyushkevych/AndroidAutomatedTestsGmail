using Android_Home.BusinessObjects;

namespace Android_Home.Tests
{
    public class GmailAndroidTest
    {
        private readonly string _email_To = "testqa.annap.2022@gmail.com";
        private readonly string _email_Subject = "EmailSubject_" + DateTime.Now.ToString();
        private readonly string _emailBody = "Some specific body";

        private readonly GmailBusinessObject gmailBO = new GmailBusinessObject();

        [Test]
        public void GmailSendLetterTest()
        {
            gmailBO.SkipInitialPage()
                .SendLetter(_email_To, _email_Subject, _emailBody)
                .OpenSentLetters();
            Assert.True(gmailBO.IsLetterSent(_email_Subject));
        }

        [Test]
        public void SelectAndDeleteFirstLetterIfThereIsAny()
        {
            gmailBO.SkipInitialPage().OpenAllLetters();
            var startCount = gmailBO.GetEmailsCount();
            if(startCount > 0)
            {
                gmailBO.SelectAndDeleteFirstEmailInList();
                var newCount = gmailBO.GetEmailsCount();
                Assert.That(newCount, Is.EqualTo(startCount - 1));
            }
        }
    }
}