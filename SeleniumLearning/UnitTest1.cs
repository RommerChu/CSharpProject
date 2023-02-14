namespace SeleniumLearning
{
    public class SampleTests
    {
        [SetUp]
        public void Setup()
        {
            TestContext.Progress.WriteLine("Setup method execution");
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            TestContext.Progress.WriteLine("This is Test 1");
        }

        [Test]
        public void Test2()
        {
            //Assert.Pass();
            TestContext.Progress.WriteLine("This is Test 2");
        }

        [TearDown]
        public void CloseBrowser() 
        {
            TestContext.Progress.WriteLine("Tear down method");
        }
    }
}