
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
        public void AddNumberTest()
        {
            var vector = new Vector(1, 2, 3);
            var vector2 = new Vector(3, 5, 2);
            var vector3 = vector + vector2;
            Assert.That("4;7;5", Is.EqualTo(vector3.Verbose()));
        }
        [Test]
        public void SubNumberTest()
        {
            var vector = new Vector(1, 2, 3);
            var vector2 = new Vector(3, 5, 2);
            var vector3 = vector - vector2;
            Assert.That("-2;-3;1", Is.EqualTo(vector3.Verbose()));
        }
        [Test]
        public void MulByNumberTest()
        {
            var vector = new Vector(1, 2, 3);
            var vector2 = new Vector(3, 5, 2);
            var scalyr = vector * vector2;
            Assert.That(19, Is.EqualTo(scalyr));
        }
    }
}
