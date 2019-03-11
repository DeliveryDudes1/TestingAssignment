using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }

    class InsuranceService
    {
        public float CalcPremium(int age, string gender)
        {
            float premium;

            if (gender == "female")
                if ((age >= 18) && (age <= 30))
                    premium = 5.0f;
                else
                    if (age >= 31)
                    premium = 2.0f;
                else
                    premium = 0.0f;
            else
                 if (gender == "male")
                if ((age >= 18) && (age <= 35))
                    premium = 6.0f;
                else
                    if (age >= 36)
                    premium = 5.0f;
                else
                    premium = 0.0f;
            else
                premium = 0.0f;

            if (age >= 50)
                premium = premium * 0.15f;
            return premium;
        }
    }
}