using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace UnitTest
{
    [TestFixture]
    public class TestClass
    {
        //3 test for male and 3 for female

        public static InsuranceService SUT;

        [SetUp]
        public static void Init()
        {
            SUT = new InsuranceService();
        }

        [Test]
        public void Test1()
        {
            float result = SUT.CalcPremium(12, "male");

            Assert.That(result, Is.EqualTo(0f));
        }

        [Test]
        public void Test2()
        {
            float result = SUT.CalcPremium(12, "female");

            Assert.That(result, Is.EqualTo(0f));
        }

        [Test]
        public void Test3()
        {
            float result = SUT.CalcPremium(22, "male");

            Assert.That(result, Is.EqualTo(6f));

        }

        [Test]
        public void Test4()
        {
            float result = SUT.CalcPremium(22, "female");

            Assert.That(result, Is.EqualTo(5f));

        }
    }
}
