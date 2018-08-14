

namespace QuestTest
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using JetBrains.Annotations;

    public class MainPage : AbstractPage
    {
        public MainPage(IWebDriver driver) : base(driver) {}

        [FindsBy(How = How.CssSelector, Using = "a[href*='hr@csssr.com']")]
        private IWebElement MailLink { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using = "a[href*='vk.com/csssr']")]
        private IWebElement VkLink { get; [UsedImplicitly] set; }

        [FindsBy(How = How.CssSelector, Using = ".graphs-details>a")]
        private IWebElement DetailsBlockLink { get; [UsedImplicitly] set; }
        
        [FindsBy(How = How.CssSelector, Using = ".graphs-error>a")]
        private IWebElement ErrorsBlockLink { get; [UsedImplicitly] set; }
        
        [FindsBy(How = How.CssSelector, Using = ".graphs-support>a")]
        private IWebElement SupportBlockLink { get; [UsedImplicitly] set; }
        
        [FindsBy(How = How.CssSelector, Using = ".graphs-files>a")]
        private IWebElement FilesBlockLink { get; [UsedImplicitly] set; }

        public MainPage CLickMailLink()
        {
            MailLink.Click();
            return this;
        }

        public VkPage ClickVkLink()
        {
            VkLink.Click();
            return new VkPage(SessionManager.getDriver());
        }

        public DetailsBlock ClickDetailsBlockLink()
        {
            DetailsBlockLink.Click();
            return new DetailsBlock(SessionManager.getDriver());
        }

        public ErrorsBlock ClickErrosBlockLink()
        {
            ErrorsBlockLink.Click();
            return new ErrorsBlock(SessionManager.getDriver());
        }

        public SupportBlock ClickSupportBlockLink()
        {
            SupportBlockLink.Click();
            return new SupportBlock(SessionManager.getDriver());
        }

        public FilesBlock ClickFilesBlockLink()
        {
            FilesBlockLink.Click();
            return new FilesBlock(SessionManager.getDriver());
        }
        
        public class DetailsBlock : AbstractPage
        {
            public DetailsBlock(IWebDriver driver) : base(driver) { }

            [FindsBy(How = How.Id, Using = "attention")]
            private IWebElement AttentionCheckbox { get; [UsedImplicitly] set; }

            [FindsBy(How = How.Id, Using = "logic")]
            private IWebElement LogicCheckbox { get; [UsedImplicitly] set; }

            public DetailsBlock ClickAttentionCheckbox()
            {
                AttentionCheckbox.Click();
                return this;
            }

            public DetailsBlock ClickLogicCheckbox()
            {
                LogicCheckbox.Click();
                return this;
            }

        }

        public class ErrorsBlock : AbstractPage
        {
            public ErrorsBlock(IWebDriver driver) : base(driver) { }

            [FindsBy(How = How.Id, Using = "eye")]
            private IWebElement EyeCheckbox { get; [UsedImplicitly] set; }

            [FindsBy(How = How.Id, Using = "beautiful")]
            private IWebElement BeautifulCheckbox { get; [UsedImplicitly] set; }

            [FindsBy(How = How.Id, Using = "tasks")]
            private IWebElement TasksCheckbox { get; [UsedImplicitly] set; }

            [FindsBy(How = How.Id, Using = "soft")]
            private IWebElement SoftCheckbox { get; [UsedImplicitly] set; }

            [FindsBy(How = How.CssSelector, Using = "a[target=_blank")]
            private IWebElement SoftLink { get; [UsedImplicitly] set; }

            public ErrorsBlock ClickEyeCheckbox()
            {
                EyeCheckbox.Click();
                return this;
            }

            public ErrorsBlock ClickBeautifulCheckbox()
            {
                BeautifulCheckbox.Click();
                return this;
            }

            public ErrorsBlock ClickTasksCheckbox()
            {
                TasksCheckbox.Click();
                return this;
            }

            public ErrorsBlock ClickSoftCheckbox()
            {
                SoftCheckbox.Click();
                return this;
            }

            public SoftPage ClickSoftLink()
            {
                SoftLink.Click();
                return new SoftPage(SessionManager.getDriver());
            }
        }

        public class SupportBlock : AbstractPage
        {
            public SupportBlock(IWebDriver driver) : base(driver) { }

            [FindsBy(How = How.Id, Using = "attention2")]
            private IWebElement AttentionCheckbox { get; [UsedImplicitly] set; }

            [FindsBy(How = How.Id, Using = "responsibility")]
            private IWebElement ResponsibilityCheckbox { get; [UsedImplicitly] set; }

            [FindsBy(How = How.Id, Using = "parallel")]
            private IWebElement ParallelCheckbox { get; [UsedImplicitly] set; }

            [FindsBy(How = How.Id, Using = "logic2")]
            private IWebElement LogicCheckbox { get; [UsedImplicitly] set; }

            public SupportBlock ClickAttentionCheckbox()
            {
                AttentionCheckbox.Click();
                return this;
            }

            public SupportBlock ClickResponsibilityCheckbox()
            {
                ResponsibilityCheckbox.Click();
                return this;
            }

            public SupportBlock ClickParallelCheckbox()
            {
                ParallelCheckbox.Click();
                return this;
            }

            public SupportBlock ClickLogicCheckbox()
            {
                LogicCheckbox.Click();
                return this;
            }
        }

        public class FilesBlock : AbstractPage
        {
            public FilesBlock(IWebDriver driver) : base(driver) { }

            [FindsBy(How = How.Id, Using = "chaos")]
            private IWebElement ChaosCheckbox { get; [UsedImplicitly] set; }

            [FindsBy(How = How.Id, Using = "beautiful2")]
            private IWebElement BeautifulCheckbox { get; [UsedImplicitly] set; }

            public FilesBlock ClickChaosCheckbox()
            {
                ChaosCheckbox.Click();
                return this;
            }

            public FilesBlock ClickBeautifulCheckbox()
            {
                BeautifulCheckbox.Click();
                return this;
            }

        }
    }
}
