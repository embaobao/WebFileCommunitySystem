using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFileCommunitySystem
{
	public partial class Mscontent : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            Timer1.Interval = 1000;
            Timer1.Enabled = true;
         
            if (!IsPostBack)
            {
                foreach (string str in (List<string>)Application["mslist"])
                {
                    ListBox1.Items.Add(str);
                }
            }
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> mslist = new List<string>();
            mslist = (List<string>)Application.Get("mslist");
            mslist.Add(TextBox1.Text);
            Application.Remove("mslist");
            Application.Add("mslist", mslist);
            TextBox1.Text = ""; 
        }

        protected void t1_trick(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            List<string> mslist = new List<string>();
            mslist = (List<string>)Application.Get("mslist");
            foreach (string s in mslist)
            {
                ListBox1.Items.Add(s);
            }
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1;

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}