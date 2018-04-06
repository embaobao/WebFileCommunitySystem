using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WebFileCommunitySystem.App_Code
{
    public class Time
    {
       public static string split="_";
        public string nowtime=string.Empty;
        public  Time(string type,bool havasplit)
        {
            if (type == "all")
            {
                type = "ymdhfs";
            }
            
            string y = DateTime.Now.Year.ToString()+"年";
            string m = DateTime.Now.Month.ToString()+"月";
            string d = DateTime.Now.Day.ToString()+"日";
            string h = DateTime.Now.Hour.ToString() + "点";
            string f = DateTime.Now.Minute.ToString()+"分";
            string s = DateTime.Now.Second.ToString()+"秒";
          
            if (type.Contains("y"))
            {
                if (havasplit)
                {
                    nowtime += y + split;
                }
                else
                {
                    nowtime += y;
                }
            }
            if (type.Contains("m"))
            {
                if (havasplit)
                {
                    nowtime += m + split;
                }
                else
                {
                    nowtime += m;
                }
            }
            if (type.Contains("d"))
            {
                if (havasplit)
                {
                    nowtime += d + split;
                }
                else
                {
                    nowtime += d;
                }
            }
            if (type.Contains("h"))
            {
                nowtime +=split+h + split;
            }
            if (type.Contains("f"))
            {
                nowtime += f+ split;
            }
            if (type.Contains("s"))
            {
                nowtime += s + split;
            }
        }
        public string GetTime()
        {
            return nowtime;
        }
    }
}