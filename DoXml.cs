using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Xml;
using System.Net;
using System.Web.UI;
using WebFileCommunitySystem.App_Code;

namespace WebFileCommunitySystem.App_Code
{
    public class DoXml
    {
        public static void CreateXmlDocOnlyNode(string rootname,Dictionary <string,string > SetRootAttributeDic, string rootchilname, Dictionary<string, string> SetChildAttributeDic,string FileName)
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0","gb2312",null);
            xmldoc.AppendChild(xmldecl);
            XmlElement rootNode = xmldoc.CreateElement("",rootname,"");
            foreach (string key in SetRootAttributeDic.Keys )
            {
                rootNode.SetAttribute(key,SetRootAttributeDic[key]);
            }
            xmldoc.AppendChild(rootNode);
            XmlElement node1 = xmldoc.CreateElement(rootchilname);
            foreach (string key in SetChildAttributeDic.Keys)
            {
                node1.SetAttribute(key, SetChildAttributeDic[key]);
            }
            rootNode.AppendChild(node1);
            xmldoc.Save(HttpContext.Current.Server.MapPath("~/App_Data/"+FileName + ".xml"));
        }
        public static void CreateXmlDocForUserRegister (string username,string id,string pw)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmldecl = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            xmlDoc.AppendChild(xmldecl);
            XmlElement rootNode = xmlDoc.CreateElement("","user", "");
            rootNode.SetAttribute("CreatTime",new Time("all",false).GetTime());
            rootNode.SetAttribute("user", username);
            rootNode.SetAttribute("id", id);
            rootNode.SetAttribute("pw", pw);
            xmlDoc.AppendChild(rootNode);
            XmlElement node = xmlDoc.CreateElement("webnote");
            XmlElement xdc = xmlDoc.CreateElement("webpage");
            xdc.SetAttribute("title","We ROOM");
            xdc.SetAttribute("url", "");
            xdc.InnerText="WE Room !WE Share!";
            node.AppendChild(xdc);
            rootNode.AppendChild(node);
            xmlDoc.Save(HttpContext.Current.Server.MapPath("~/App_Data/users/" +id+".xml"));
        }

        public static void AddXmlDocNodeForWebNote(string id, string title, string url, string contenttxt, string type)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(HttpContext.Current.Server.MapPath("~/App_Data/users/" + id + ".xml"));
            XmlNode root = xmlDoc.SelectSingleNode("user");//查找<webnote>
            XmlElement webnode=(XmlElement)root.SelectSingleNode("webnote");
            XmlElement node = xmlDoc.CreateElement(type);
            node.SetAttribute("title", title);
            node.SetAttribute("url", url);
            node.InnerText = contenttxt;
            webnode.AppendChild(node);
            xmlDoc.Save(HttpContext.Current.Server.MapPath("~/App_Data/users/" + id + ".xml"));
        }

        public static void ReadXml()
        {


        }
    }
}