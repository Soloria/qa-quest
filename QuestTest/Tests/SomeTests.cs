
namespace QuestTest
{
    using NUnit.Framework;

    public class SomeTests
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

        
      

        [OneTimeTearDown]
        public static void Clean() => SessionManager.Close();

    }
}
