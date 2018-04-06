using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFileCommunitySystem.App_Code;

namespace WebFileCommunitySystem
{
    public partial class SiteMaster : MasterPage
    {
       public Time t = new Time("ymd",false);
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //DoXml.CreateXmlDocForUserRegister("baobao","0","zhumeng");
            //DoXml.AddXmlDocNodeForWebNote("0","w3c","www.w3cshool.com","w3cshool","note");
        }
    }
}