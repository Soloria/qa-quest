

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

        //details class

        [FindsBy(How = How.CssSelector, Using = ".graphs-details>a")]
        private IWebElement DetailsBlock { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Id, Using = "attention")]
        private IWebElement AttentionCheckbox { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Id, Using = "logic")]
        private IWebElement LogicCheckbox { get; [UsedImplicitly] set; }


        //errors class
        [FindsBy(How = How.CssSelector, Using = ".graphs-error>a")]
        private IWebElement ErrorsBlock { get; [UsedImplicitly] set; }

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

        //support class
        [FindsBy(How = How.CssSelector, Using = ".graphs-support>a")]
        private IWebElement SupportBlock { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Id, Using = "attention2")]
        private IWebElement AttentionCheckbox2 { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Id, Using = "responsibility")]
        private IWebElement ResponsibilityCheckbox { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Id, Using = "parallel")]
        private IWebElement ParallelCheckbox { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Id, Using = "logic2")]
        private IWebElement LogicCheckbox2 { get; [UsedImplicitly] set; }
 
        //files class
        [FindsBy(How = How.CssSelector, Using = ".graphs-files>a")]
        private IWebElement FilesBlock { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Id, Using = "chaos")]
        private IWebElement ChaosCheckbox { get; [UsedImplicitly] set; }

        [FindsBy(How = How.Id, Using = "beautiful2")]
        private IWebElement BeautifulCheckbox2 { get; [UsedImplicitly] set; }
        
    }
}
