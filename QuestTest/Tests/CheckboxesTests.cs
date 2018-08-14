
namespace QuestTest
{
    using NUnit.Framework;

    public class CheckboxesTests
    {
        [OneTimeSetUp]
        public static void Start() => SessionManager.Open(SessionManager.Path);

        [Test]
        [Order(order: 0)]
        public void TestAttentionCheckboxInDetailsBlock()
        {
            new MainPage.DetailsBlock(SessionManager.getDriver())
                .ClickAttentionCheckbox()
                .ClickAttentionCheckbox();
                
            Assert.IsTrue(new MainPage.DetailsBlock(SessionManager.getDriver()).HiddenAttentionCheckbox.Selected);
        }

        [Test]
        [Order(order: 1)]
        public void TestLogicCheckboxInDetailsBlock()
        {
            new MainPage.DetailsBlock(SessionManager.getDriver())
                .ClickLogicCheckbox()
                .ClickLogicCheckbox();

            Assert.IsTrue(new MainPage.DetailsBlock(SessionManager.getDriver()).HiddenLogicCheckbox.Selected);
        }

        [Test]
        [Order(order: 2)]
        public void TestEyeCheckboxInErrorsBlock()
        {
            new MainPage(SessionManager.getDriver())
                .ClickErrorsBlockLink()
                .ClickEyeCheckbox()
                .ClickEyeCheckbox();

            Assert.IsTrue(new MainPage.ErrorsBlock(SessionManager.getDriver()).HiddenEyeCheckbox.Selected);
        }

        [Test]
        [Order(order: 3)]
        public void TestBeautifulCheckboxInErrorsBlock()
        {
            new MainPage.ErrorsBlock(SessionManager.getDriver())
                .ClickBeautifulCheckbox()
                .ClickBeautifulCheckbox();

            Assert.IsTrue(new MainPage.ErrorsBlock(SessionManager.getDriver()).HiddenBeautifulCheckbox.Selected);
        }

        [Test]
        [Order(order: 4)]
        public void TestTasksCheckboxInErrorsBlock()
        {
            new MainPage.ErrorsBlock(SessionManager.getDriver())
                .ClickTasksCheckbox()
                .ClickTasksCheckbox();

            Assert.IsTrue(new MainPage.ErrorsBlock(SessionManager.getDriver()).HiddenTasksCheckbox.Selected);
        }

        [Test]
        [Order(order: 5)]
        public void TestSoftCheckboxInErrorsBlock()
        {
            new MainPage.ErrorsBlock(SessionManager.getDriver())
                .ClickSoftCheckbox()
                .ClickSoftCheckbox();

            Assert.IsTrue(new MainPage.ErrorsBlock(SessionManager.getDriver()).HiddenSoftCheckbox.Selected);
        }

        [Test]
        [Order(order: 6)]
        public void TestAttentionCheckboxInSupportBlock()
        {
            new MainPage(SessionManager.getDriver())
                .ClickSupportBlockLink()
                .ClickAttentionCheckbox()
                .ClickAttentionCheckbox();

            Assert.IsTrue(new MainPage.SupportBlock(SessionManager.getDriver()).HiddenAttentionCheckbox.Selected);
        }

        [Test]
        [Order(order: 7)]
        public void TestResponsibilityCheckboxInSupportBlock()
        {
            new MainPage.SupportBlock(SessionManager.getDriver())
                .ClickResponsibilityCheckbox()
                .ClickResponsibilityCheckbox();

            Assert.IsTrue(new MainPage.SupportBlock(SessionManager.getDriver()).HiddenResponsibilityCheckbox.Selected);
        }

        [Test]
        [Order(order: 8)]
        public void TestParallelCheckboxInSupportBlock()
        {
            new MainPage.SupportBlock(SessionManager.getDriver())
                .ClickParallelCheckbox()
                .ClickParallelCheckbox();

            Assert.IsTrue(new MainPage.SupportBlock(SessionManager.getDriver()).HiddenParallelCheckbox.Selected);
        }

        [Test]
        [Order(order: 9)]
        public void TestLogicCheckboxInSupportBlock()
        {
            new MainPage.SupportBlock(SessionManager.getDriver())
                .ClickLogicCheckbox()
                .ClickLogicCheckbox();

            Assert.IsTrue(new MainPage.SupportBlock(SessionManager.getDriver()).HiddenLogicCheckbox.Selected);
        }

        [Test]
        [Order(order: 10)]
        public void TestChaosCheckboxInFilesBlock()
        {
            new MainPage(SessionManager.getDriver())
                .ClickFilesBlockLink()
                .ClickChaosCheckbox()
                .ClickChaosCheckbox();

            Assert.IsTrue(new MainPage.FilesBlock(SessionManager.getDriver()).HiddenChaosCheckbox.Selected);
        }

        [Test]
        [Order(order: 11)]
        public void TestBeautifulCheckboxInFilesBlock()
        {
            new MainPage.FilesBlock(SessionManager.getDriver())
                .ClickBeautifulCheckbox()
                .ClickBeautifulCheckbox();

            Assert.IsTrue(new MainPage.FilesBlock(SessionManager.getDriver()).HiddenBeautifulCheckbox.Selected);
        }

        [OneTimeTearDown]
        public static void Clean() => SessionManager.Close();

    }
}
