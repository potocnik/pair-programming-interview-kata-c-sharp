using NUnit.Framework;

namespace Tests.Unit
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Should_be_true()
        {
            Assert.That(true, Is.EqualTo(false));
        }
    }
}
