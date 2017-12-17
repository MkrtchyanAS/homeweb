using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sname = string.Empty;
            LabelWelcome.Text = "Здравствуйте, " + TextBox1.Text + " " + TextBox2.Text + "!" + " " + " Добро пожаловать!";
            LabelWelcome.ForeColor = System.Drawing.Color.DarkRed;
            ViewState["FirstName"] = TextBox1.Text;
            ViewState["LastName"] = TextBox2.Text;
            //SaveTextInTextBox(TextBox1.Controls, true);
            //SaveTextInTextBox(TextBox2.Controls, true);
            //TextBox1.Text = " ";
            //TextBox2.Text = " ";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string a = TextBox1.Text;

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = (string)ViewState["FirstName"];
            TextBox2.Text = (string)ViewState["LastName"];
            //RestoreTextToTextBox(TextBox1.Controls, true);
            //RestoreTextToTextBox(TextBox2.Controls, true);

        }

        private void SaveTextInTextBox(ControlCollection controls, bool SaveNested)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    ViewState[control.ID] = ((TextBox)control).Text;
                }

                //if (control.Controls != null && SaveNested)
                //{
                  //  SaveTextInTextBox(control.Controls, true);
                //}
            }

        }

        private void RestoreTextToTextBox(ControlCollection controls, bool SaveNested)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    if (ViewState[control.ID] != null)
                    {
                        ((TextBox)control).Text = (string)ViewState[control.ID];

                    }
                    /*if (control.Controls != null && SaveNested)
                    {

                        RestoreTextToTextBox(control.Controls, true);
                    }*/
                }

            }

        }
    }
}