using DotNet.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using WebFileCommunitySystem.App_Code;
using System.IO;


namespace WebFileCommunitySystem
{
    public partial class Editor : System.Web.UI.Page
    {


       public static string  status;
        protected void Page_Load(object sender, EventArgs e)
        {
           


            if (!IsPostBack)
            {
               

                if (Request.QueryString.Count > 0)
                {
                    if (Request.QueryString["txt"].Length > 0)
                    {
                        string Text = FileOperate.ReadFile(Server.MapPath( Request.QueryString["txt"].ToString()));
                        try
                        {
                            Text = Text.Substring(Text.IndexOf("<body>"), Text.Length - Text.IndexOf("<body>"));
                        }
                        catch (Exception ex)
                        {

                            BaseDo.show(this,"读取文件失败 :"+ex);
                        }
                     
                        FreeTextBox1.Text = Text;
                    }
                    if (Request.QueryString["title"].Length > 0)
                    {
                        TextBox1.Text = Request.QueryString["title"].ToString();
                    }
                    if (Request.QueryString["status"].Length > 0)
                    {
                        status = Request.QueryString["status"].ToString();
                        switch (status)
                        {
                            case "0":
                                DropDownList1.SelectedValue = "0";
                                break;
                            case "1":
                                DropDownList1.SelectedValue = "1";
                                break;
                            default:
                                DropDownList1.SelectedValue = "0";
                                break;


                        }
                    }
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BaseDo.show(this, " 以模式" + DropDownList1.SelectedItem.ToString() + "保存");
            TextBox1_TextChanged(null, null);
            string title = "Test";
            if (!string.IsNullOrEmpty(TextBox1.Text.Trim().ToString()))
            {
                title = TextBox1.Text.ToString();
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(@"<!DOCTYPE html><html lang='zh-cn'>
<head>
<meta charset='UTF-8'>
<meta http-equiv='content - type' content='text/html; charset=UTF-8'>
<metaname='viewport' content='width=device-width,initial-scale=1.0'/> 
<title>");

            string time = "T_" + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + "_" + DateTime.Now.Minute.ToString() + "_" + DateTime.Now.Minute.ToString();
            sb.Append(title);
            sb.Append("</title></head><body>");
            sb.Append(FreeTextBox1.Text.ToString());
            sb.Append("</body></html>");
            if (status == "1")
            {
                FileOperate.WriteFile(Server.MapPath("../file/text/" + title + ".html"), sb.ToString(), false);
            }
            else
            {
                FileOperate.WriteFile(Server.MapPath("../file/text/" + title + time + ".html"), sb.ToString(), false);
            }
           
            BaseDo.show(this, "Save ok");

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string[] chars = new string[] { "!", "@", "#", "%", "$", "^", "&", "*", "(", ")", "-", "=", "+", "~", @"<", ">", "{", "}", "\"", "?", "/", @"\" };
            foreach (string str in chars)
            {
                if (TextBox1.Text.Contains(str))
                {
                    TextBox1.Text = "Test";
                    BaseDo.show(this, "Title 包含非法字符");
                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
          status= DropDownList1.SelectedValue.ToString();
          BaseDo.show(this, "保存状态 码："+status+"  "+DropDownList1.SelectedItem.ToString()
              +"覆盖模式文档没有时间名" +
              "副本则建议修改标题自带时间的文件" +
              "否则文件名过长！");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
          
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Panel1.CssClass == "")
            {
                Panel1.CssClass = "fulltxt";
                Button3.Text = "◣";
            }
            else
            {
                Panel1.CssClass = "";
                Button3.Text = "↕";
            }
           

        }


        public string filedir()
        {

            StringBuilder str = new StringBuilder();
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/file/"));
            foreach (FileInfo fi in dir.GetFiles())
            {
                str.Append("<tr> <td>" + fi.LastWriteTime + "</td>");
                str.Append("<td>");
                str.Append("<a  target=\"_blank\"  href='" + "../file/" + @fi.Name + "' >" + fi.Name);
                str.Append("</td>");
                str.Append("<td>");
                str.Append(" <a class='h' href='../H.ashx?com=delete&path=" + fi.FullName + "&page=1' onclick='return dele()'>删除</a> <br/>");
                str.Append("</td></tr>");
            }
            return str.ToString();
        }

        public string pageDir()
        {
            StringBuilder str = new StringBuilder();
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/file/text/"));
            foreach (FileInfo fi in dir.GetFiles())
            {

                str.Append("<tr> <td>" + fi.LastWriteTime + "</td>");

                str.Append("<td>");
                str.Append("<a href='./Editor.aspx?"
                    + "txt="+"../file/text/"
                    + fi.Name
                    + "&title=" + fi.Name.Replace(Path.GetExtension(fi.Name), "") + "&status=1'>"
                    + fi.Name
                    + "</a></td>");
                str.Append("<td><a target=\"_blank\"  href='" + @"./../file/text/"
                    + fi.Name + "'>" + "浏览" + "</a> <a class='h' href='../H.ashx?com=delete&path=" +
                    "" + fi.FullName + "&page=1' onclick='return dele()'>删除</a>");
                str.Append("</td></tr>");
            

            }
            return str.ToString();
        }


    }
}