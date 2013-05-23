using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.Caching;

namespace NNND.AppCode
{
    public class ConfigInfo
    {
        private static string FILE_NAME = "~/App_Data/config.ini";
        private static string KeyCache = "Config";

        private static Dictionary<string, string> NewConfig()
        {
            Dictionary<string, string>  obj = new Dictionary<string, string>();
            obj.Add("title","Ngoại ngữ Nam Du");
            obj.Add("description", "");
            obj.Add("keywords", "");
            obj.Add("content-language", "vi");
            obj.Add("content-type", "text/html; charset=utf-8");
            obj.Add("banner", "");
            obj.Add("footer", "");
            return obj;
        }

        public static bool Update(Dictionary<string, string> obj)
        {
            if (obj == null) return false;
            if (SaveSetting(obj))
            {
                HttpContext.Current.Cache.Remove(KeyCache);
                return true;
            }
            return false;
        }

        public static Dictionary<string, string> GetSetting()
        {
            object oCache = HttpContext.Current.Cache.Get(KeyCache);
            if (oCache != null) return (Dictionary<string, string>)oCache;

            Dictionary<string, string> obj;
            if (!File.Exists(HttpContext.Current.Server.MapPath(FILE_NAME)))
            {
                obj = NewConfig();
                HttpContext.Current.Cache.Insert(KeyCache, obj, null, DateTime.Now.AddHours(12), Cache.NoSlidingExpiration);
                return obj;
            }
            Stream fileStream = null;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            fileStream = File.Open(HttpContext.Current.Server.MapPath(FILE_NAME), FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                obj = (Dictionary<string, string>)binaryFormatter.Deserialize(fileStream);
                HttpContext.Current.Cache.Insert(KeyCache, obj, null, DateTime.Now.AddHours(12), Cache.NoSlidingExpiration);
                return obj;
            }
            catch
            {
                return NewConfig();
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
        }

        private static bool SaveSetting(Dictionary<string, string> obj)
        {
            if (obj == null)
                return false;
            Stream fileStream = File.Open(HttpContext.Current.Server.MapPath(FILE_NAME),
                FileMode.Create, FileAccess.ReadWrite, FileShare.None);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                binaryFormatter.Serialize(fileStream, obj);
                return true;
            }
            catch
            {
                return false;
                throw;
            }
            finally
            {
                fileStream.Flush();
                fileStream.Close();
            }
        }
    }
}