using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        public double tal1 = 0;
        public double tal2 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void DivideButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Input1.Text, out tal1) && double.TryParse(Input2.Text, out tal2))
            {
                double result = tal1 / tal2;
                ResultBox.Text = result.ToString();
            }
            else
                ResultBox.Text = "Not a number!";
        }
        protected void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Input1.Text, out tal1) && double.TryParse(Input2.Text, out tal2))
            {
                double result = tal1 * tal2;
                ResultBox.Text = result.ToString();
            }
            else
                ResultBox.Text = "Not a number!";
        }
        protected void SubtractButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Input1.Text, out tal1) && double.TryParse(Input2.Text, out tal2))
            {
                double result = tal1 - tal2;
                ResultBox.Text = result.ToString();
            }
            else
                ResultBox.Text = "Not a number!";
        }
        protected void AddButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Input1.Text, out tal1) && double.TryParse(Input2.Text, out tal2))
            {
                double result = tal1 + tal2;
                ResultBox.Text = result.ToString();
            }
            else
                ResultBox.Text = "Not a number!";
        }
    }
}