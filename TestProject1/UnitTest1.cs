
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
            Assert.That(new Vector(4, 7, 5), Is.EqualTo(vector3));

        }
        [Test]
        public void SubNumberTest()
        {
            var vector = new Vector(1, 2, 3);
            var vector2 = new Vector(3, 5, 2);
            var vector3 = vector - vector2;
            Assert.That(new Vector(-2,-3,1), Is.EqualTo(vector3));
        }

        [Test]
        public void MulByTest()
        {
            var vector = new Vector(1, 2, 3);
            var vector2 = new Vector(3, 5, 2);
            var scalyre = vector * vector2;
            Assert.That(19, Is.EqualTo(scalyre));
        }
        [Test]
        public void VectorMultiplyNumberTest()
        {
            var vector = new Vector(1, 2, 3);
            var vector2 = new Vector(3, 5, 2);
            var vector3 = vector & vector2;
            Assert.That(new Vector(-11, 7, -1), Is.EqualTo(vector3));
        }
        [Test]
        public void LenVectorTest()
        {
            var vector = new Vector(4, 2, 8);
            double testValue = 9.17;
            Assert.That(testValue, Is.EqualTo(vector.Len()).Within(1e-2));
        }
    }
}
