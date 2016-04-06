using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lession_5_2_Controllers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtBirthday_TextChanged(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtBirthday.Text = Calendar1.SelectedDate.ToString();
        }

        protected void rbtnBoy_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        protected void rbtnGirl_CheckedChanged(object sender, EventArgs e)
        {

            
        }
    }
}