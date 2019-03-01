using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebFileCommunitySystem
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
          
            // 在应用程序启动时运行的代码
            List<string> mslist = new List<string>();
            mslist.Add("欢迎来到 WE RooM 我的世界频道！");
            mslist.Add("WE RooM 我的世界频道！ 您可以发信息到我的世界，交流分享！");
            mslist.Add("WE RooM 我的世界频道！ 您也可以发送文件We ROOM共同学习进步！");
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application.Add("mslist", mslist);
           
        }
    }
}