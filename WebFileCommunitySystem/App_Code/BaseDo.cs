using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
namespace WebFileCommunitySystem.App_Code
{
    public class BaseDo
    {

        public static void show(Page page ,string message)
        {
           page.Response.Write("<script>alert('" + message+ "')</script>");
        }

    }
}