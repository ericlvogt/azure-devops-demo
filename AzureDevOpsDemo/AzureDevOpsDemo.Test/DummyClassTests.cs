using AzureDevOpsDemo;

namespace AzureDevOpsDemo.Test
{
    public class DummyClassTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SayHelloWorld_WhenCalled_ReturnsHelloWorld()
        {
            var dummy = new DummyClass();
            Assert.AreEqual("Hello World!", dummy.SayHelloWorld());
        }

        [Test]
        public void SayGoodbyeWorld_WhenCalled_ReturnsGoodbyeWorld()
        {
            var dummy = new DummyClass();
            Assert.AreEqual("Goodbye World", dummy.SayGoodbyeWorld());
        }
    }
}