using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using WebFileCommunitySystem.App_Code;
using System.Web.UI.WebControls;

namespace WebFileCommunitySystem
{
    public partial class _Default : Page
    {
        public string filetxt = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            filetxt = filedir();

        }



        public string filedir()
        {
            string str = "";
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/file/"));
            foreach (FileInfo fi in dir.GetFiles())
            {
                str += "<a  target=\"_blank\"  href='" + "file/" + @fi.Name + "'  >" + fi.Name + "</a><br/>";
            }
            return str;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                   
                    string path = Server.MapPath("~/file/") +new Time("ymdhfs",true).GetTime()+FileUpload1.FileName;
                    FileUpload1.SaveAs(path);
                    Label1.Text = "上传成功";
                    Response.Redirect("Default.aspx");

                }
                else
                {
                    Label1.Text = "不能上传空文件";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "发生错误" + ex;
            }
        }
    }
}