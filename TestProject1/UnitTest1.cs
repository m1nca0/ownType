
using NUnit.Framework;
using OwnType;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LenTest()
        {
            var ownVector = new Vector(0,0,2);
            Assert.That(ownVector.Len(), Is.EqualTo(2.0));
        }
    }
}
