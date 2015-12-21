using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsMerOvningar
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "2spooky4me";
            DeadTextBox.Text = "Verily! The button hath been clicked!";
            TextLabel.Text = "In fealty to the code-emperor, our undying code and by the grace of the golden framework-";
            TextPanel.GroupingText = "I declare exterminatus upon the imperial panel of TextPanel.";
            HDHyperLink.NavigateUrl = "http://www.SOMAGAME.com";
            HDHyperLink.Text = "ASpookierLink.";
        }
    }
}