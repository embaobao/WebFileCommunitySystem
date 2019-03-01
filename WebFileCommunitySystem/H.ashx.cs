using DotNet.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebFileCommunitySystem
{
    /// <summary>
    /// H 的摘要说明
    /// </summary>
    public class H : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

          

            if (context.Request.QueryString.Count > 0)
            {
                
                if (context.Request.QueryString["com"] == "delete")
                {
                 

                    if (context.Request.QueryString["path"].Length > 0)
                    {
                        
                        string path = context.Request.QueryString["path"].ToString();
                        if (File.Exists(path))
                        {
                           
                            FileOperate.FileDel(path);
                            if (context.Request.QueryString["page"] == "1")
                            {
                                context.Response.Redirect("~/editor/Editor.aspx");

                            }
                            else
                            {
                                context.Response.Redirect("~/");
                            }
                          
                           
                        }



                    }
                }




            }


          
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}