using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;
using fit;

namespace FixtureTest
{
    public class Fixturetest : ColumnFixture
    {
        public static InsuranceService SUT;
        public static int age;
        public static string gender;

        public float Premium()
        {
            SUT = new InsuranceService();
            return SUT.CalcPremium(age,gender);
        }

    }
}
