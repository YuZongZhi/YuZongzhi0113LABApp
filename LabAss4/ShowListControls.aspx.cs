using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabAss4
{
    public partial class ShowListControls :System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] twons = { "Sofia", "Plovdiv", "Varna" };

           /* ListBox1.DataSource = twons;
            ListBox1.DataBind();

            DropDownList1.DataSource = twons;
            DropDownList1.DataBind();

            BulletedList1.DataSource = twons;
            BulletedList1.DataBind();

            CheckBoxList1.DataSource = twons;
            CheckBoxList1.DataBind();

            RadioButtonList1.DataSource = twons;
            RadioButtonList1.DataBind();
          */
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}