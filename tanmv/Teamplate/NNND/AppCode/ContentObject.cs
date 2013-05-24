using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.Caching;

namespace NNND.AppCode
{
    public class ContentObject
    {
        private static string FILE_NAME = "~/App_Data/content.ini";
        private static string KeyCache = "content";

        public static Dictionary<int,NewsInfo> LoadList()
        {
            object oCache = HttpContext.Current.Cache.Get(KeyCache);
            if (oCache != null) return ((Dictionary<int, NewsInfo>)oCache);
            
            if (!File.Exists(HttpContext.Current.Server.MapPath(FILE_NAME)))
            {
                return null;
            }
            Stream fileStream = null;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            fileStream = File.Open(HttpContext.Current.Server.MapPath(FILE_NAME), FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                Dictionary<int, NewsInfo> obj = (Dictionary<int, NewsInfo>)binaryFormatter.Deserialize(fileStream);
                HttpContext.Current.Cache.Insert(KeyCache, obj, null, DateTime.Now.AddHours(12), Cache.NoSlidingExpiration);
                return obj;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
        }

        public static NewsInfo LoadItem(int id)
        {
            Dictionary<int, NewsInfo> oList = LoadList();
            if(oList!=null && oList.Count>0)
            {
                if (oList.ContainsKey(id)) return oList[id];
            }
            return null;
        }

        public static bool UpdateItem(NewsInfo obj)
        {

            Dictionary<int, NewsInfo> oList = LoadList();
            if (oList != null && oList.Count > 0)
            {
                if (oList.ContainsKey(obj.Id))
                {
                    oList[obj.Id] = obj;
                    if (UpdateList(oList)) return true;
                }
            }
            return false;
        }

        public static bool InsertItem(NewsInfo obj)
        {
            Dictionary<int, NewsInfo> oList = LoadList();
            if (oList != null && oList.Count > 0)
            {
                int MaxId = 0;
                foreach (var newsInfo in oList)
                {
                    if (MaxId < newsInfo.Value.Id) MaxId = newsInfo.Value.Id;
                }
                obj.Id = MaxId + 1;
                oList.Add(MaxId + 1, obj);
                if (UpdateList(oList)) return true;
            }
            return false;
        }

        public static bool UpdateList(Dictionary<int, NewsInfo> obj)
        {
            if (obj == null) return false;
            if (SaveSetting(obj))
            {
                HttpContext.Current.Cache.Remove(KeyCache);
                return true;
            }
            return false;
        }

        private static bool SaveSetting(Dictionary<int, NewsInfo> obj)
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