using System;
using System.Security.Cryptography;
using NUnit.Framework;
using NUnit.Framework.Internal;
using PolinomLibrary;

namespace Test
{
    [TestFixture]
    public class Tests
    {
        // 3*x^2+2*x-1
        Polynomial pol1 = new Polynomial(-1, 2, 3);

        // 2*x-1
        Polynomial pol2 = new Polynomial(-1, 2);
        
        // 0
        Polynomial pol3 = new Polynomial(0, 0);
        
        [Test]
        public void TestAddition()
        {
            Assert.AreEqual("3*x^2+4*x-2", (pol1 + pol2).ToString());
        }

        [Test]
        public void TestSubtraction()
        {
            Assert.AreEqual("3*x^2", (pol1 - pol2).ToString());
        }

        [Test]
        public void TestMultiplication()
        {
            Assert.AreEqual("6*x^3+1*x^2-4*x+1", (pol1 * pol2).ToString());
        }

        [Test]
        public void TestDegree()
        {
            Assert.AreEqual(2, pol1.Degree);
        }
        
        [Test]
        public void TestDegree_On_Zero_Degree()
        {
            Assert.AreEqual(Double.NegativeInfinity, pol3.Degree);
        }
        
        [Test]
        public void TestAddition_Bad_Parameters()
        {
            var ex = Assert.Throws<NullReferenceException>(() => (pol1 + null).ToString());
            Assert.That(ex.Message, Is.EqualTo("Object reference not set to an instance of an object."));
            Console.Write(ex.Message);
        }
        
        [Test]
        public void TestSubtractio_Bad_Parameters()
        {
            var ex = Assert.Throws<NullReferenceException>(() => (null - pol1).ToString());
            Assert.That(ex.Message, Is.EqualTo("Object reference not set to an instance of an object."));
            Console.Write(ex.Message);
        }
        
        [Test]
        public void TestMultiplication_Bad_Parameters()
        {
            var ex = Assert.Throws<NullReferenceException>(() => (pol2 * null).ToString());
            Assert.That(ex.Message, Is.EqualTo("Object reference not set to an instance of an object."));
            Console.Write(ex.Message);
        }

    }
}