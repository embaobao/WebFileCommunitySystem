using DotNet.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFileCommunitySystem.App_Code;
namespace WebFileCommunitySystem
{
    public partial class _Default : Page
    {

        public static string filetxt = "";
        protected void Page_Load(object sender, EventArgs e)
        {
          
            filetxt = filedir();
           
            if (!IsPostBack)
            {


               
                

            }
            //   BaseDo.show(this.Page,"ｏｋ");

        }
        //public string filedir()
        //{

        //    string str = "";
        //    DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/file/"));
        //    foreach (FileInfo fi in dir.GetFiles())
        //    {
        //        str += "上传时间: " + fi.LastWriteTime + "&nbsp;&nbsp; <a  target=\"_blank\"  href='" + "file/" + @fi.Name + "' >" + fi.Name + "" +
        //            "</a>  &nbsp; <a href='H.ashx?com=delete&path=" +
        //            "" + fi.FullName + "' onclick='return dele()'>删除</a> <br/>";
        //    }
        //    return str;
        //}

        public string filedir()
        {

            StringBuilder str = new StringBuilder();
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/file/"));
            foreach (FileInfo fi in dir.GetFiles())
            {
                str.Append("<tr> <td>" + fi.LastWriteTime + "</td>");
                str.Append("<td>");
                str.Append("<a  target=\"_blank\"  href='" + "file/" + @fi.Name + "' >" + fi.Name);
                str.Append("</td>");
                str.Append("<td>");
                str.Append(" <a class='h' href='H.ashx?com=delete&path=" + fi.FullName + "&page=0' onclick='return dele()'>删除</a> <br/>");
                str.Append("</td></tr>");
            }
            return str.ToString();
        }



        public string pageDir()
        {
            string str = "";
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/file/text/"));
            foreach (FileInfo fi in dir.GetFiles())
            {
                str += "<tr><td>"
                    + fi.LastWriteTime
                    + "</td><td  style='width: auto'><a  href='./editor/Editor.aspx?"
                   + "txt=" + "~/file/text/"
                    + fi.Name
                    + "&title=" + fi.Name.Replace(Path.GetExtension(fi.Name), "") + "&status=1'>"
                    + fi.Name
                    + "</a></td>" +
                    "<td><a  target=\"_blank\"  href='" + @"file/text/"
                    + fi.Name + "'  >" + "浏览" + "</a></br> <a class='h' href='H.ashx?com=delete&path=" +
                    "" + fi.FullName + "&page=0' onclick='return dele()'>删除</a></td>";

            }
            return str;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)

                {
                    string pathtends = Path.GetExtension(FileUpload1.FileName);
                    string path = Server.MapPath("~/file/") + FileUpload1.FileName.Replace(pathtends, "") + "UpTime_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Second + pathtends;
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length <= 0 || TextBox1.Text.Length > 4)
            {
                BaseDo.show(this, "Key 操作码格式不正确");
                WebFileCommunitySystem.SiteMaster.passjs = "1";
            }
            else if (TextBox1.Text == "3520")
            {
            
              WebFileCommunitySystem.SiteMaster.passjs= "0";
            }
            else
            {
                BaseDo.show(this, "Key 操作码不正确");
                WebFileCommunitySystem.SiteMaster.passjs = "1";
            }
        }
    }
}