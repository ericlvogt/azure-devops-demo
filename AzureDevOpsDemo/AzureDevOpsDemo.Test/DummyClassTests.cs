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
            Assert.That(dummy.SayHelloWorld(), Is.EqualTo("Hello World!"));
        }

        [Test]
        public void SayGoodbyeWorld_WhenCalled_ReturnsGoodbyeWorld()
        {
            var dummy = new DummyClass();
            Assert.That(dummy.SayGoodbyeWorld(), Is.EqualTo("Goodbye World"));
        }
    }
}