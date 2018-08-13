

namespace QuestTest
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public static class SessionManager
    {
        private static IWebDriver _driver;

        public static void Open(string path)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Url = path;
        }

        public static void Close()
        {
            _driver.Quit();
        }

        public static string Path = "http://blog.csssr.ru/qa-engineer/";

        public static IWebDriver getDriver() => _driver;

    }
}
