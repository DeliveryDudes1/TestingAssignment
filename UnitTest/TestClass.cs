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

        [Test(Description ="Male 12, premium 0")]
        public void Test1()
        {
            float result = SUT.CalcPremium(12, "male");

            Assert.That(result, Is.EqualTo(0f));
        }

        [Test(Description = "Male 19, premium 6")]
        public void Test2()
        {
            float result = SUT.CalcPremium(19, "male");

            Assert.That(result, Is.EqualTo(6.0f));
        }

        [Test(Description = "Male 38, premium 5")]
        public void Test3()
        {
            float result = SUT.CalcPremium(38, "male");

            Assert.That(result, Is.EqualTo(5.0f));

        }

        [Test(Description = "Male 52, premium 2.5")]
        public void Test4()
        {
            float result = SUT.CalcPremium(52, "male");

            Assert.That(result, Is.EqualTo(2.5f));

        }

        [Test(Description = "female 17, premium 0")]
        public void Test5()
        {
            float result = SUT.CalcPremium(17, "female");

            Assert.That(result, Is.EqualTo(0f));

        }

        [Test(Description = "female 25, premium 5")]
        public void Test6()
        {
            float result = SUT.CalcPremium(25, "female");

            Assert.That(result, Is.EqualTo(5f));

        }

        [Test(Description = "female 32, premium 3.50")]
        public void Test7()
        {
            float result = SUT.CalcPremium(32, "female");

            Assert.That(result, Is.EqualTo(3.5f));

        }

        [Test(Description = "female 52, premium 2.5")]
        public void Test8()
        {
            float result = SUT.CalcPremium(52, "female");

            Assert.That(result, Is.EqualTo(1.75f));

        }

        [Test(Description = "hello 52, premium 2.5")]
        public void Test9()
        {
            float result = SUT.CalcPremium(52, "hello");

            Assert.That(result, Is.EqualTo(0f));

        }

        [Test(Description = "man 10, premium 2.5")]
        public void Test10()
        {
            float result = SUT.CalcPremium(10, "man");

            Assert.That(result, Is.EqualTo(0f));

        }
    }
}
