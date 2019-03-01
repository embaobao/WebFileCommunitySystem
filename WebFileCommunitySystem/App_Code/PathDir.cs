using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebFileCommunitySystem.App_Code
{
    public class PathDir
    {
        public static string AppPath =string.Empty;

        public PathDir(Page page,string path )
        {
          AppPath=page.Server.MapPath(path);
        }
        public static string GetPath(string repath)
        {
         return   HttpContext.Current.Server.MapPath(repath);
        }
        // HttpRuntime.AppDomainAppPath
        //  HttpContext.Current.Server.MapPath(@"\"); 这个就是在页面中的MapPath了.一样用法
        //HttpRuntime.AppDomainAppPath //这个是新发现的,很好用.
    }
}