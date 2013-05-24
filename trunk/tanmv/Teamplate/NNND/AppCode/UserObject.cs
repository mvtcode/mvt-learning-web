using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.Caching;

namespace NNND.AppCode
{
    public class UserObject
    {
        private static string FILE_NAME = "~/App_Data/user.ini";
        private static string KeyCache = "user";

        public static Dictionary<string, UserInfo> LoadList()
        {
            object oCache = HttpContext.Current.Cache.Get(KeyCache);
            if (oCache != null) return ((Dictionary<string, UserInfo>)oCache);

            if (!File.Exists(HttpContext.Current.Server.MapPath(FILE_NAME)))
            {
                return null;
            }
            Stream fileStream = null;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            fileStream = File.Open(HttpContext.Current.Server.MapPath(FILE_NAME), FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                Dictionary<string, UserInfo> obj = (Dictionary<string, UserInfo>)binaryFormatter.Deserialize(fileStream);
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

        public static UserInfo LoadInfo(string sUsername)
        {
            Dictionary<string, UserInfo> oList = LoadList();
            if (oList != null && oList.Count > 0)
            {
                if (oList.ContainsKey(sUsername)) return oList[sUsername];
            }
            return null;
        }

        public static UserInfo Login(string username, string password)
        {
            Dictionary<string, UserInfo> oList = LoadList();
            if (oList != null && oList.Count > 0)
            {
                if (oList.ContainsKey(username))
                {
                    UserInfo oUser = oList[username];
                    if (oUser.sPassword == password) return oUser;
                }
            }
            return null;
        }

        public static bool UpdateInfo(UserInfo obj)
        {
            Dictionary<string, UserInfo> oList = LoadList();
            if (oList != null && oList.Count > 0)
            {
                if (oList.ContainsKey(obj.sUsername))
                {
                    oList[obj.sUsername] = obj;
                    if (UpdateList(oList)) return true;
                }
            }
            return false;
        }

        public static bool InsertItem(UserInfo obj)
        {
            Dictionary<string, UserInfo> oList = LoadList();
            if (oList != null && oList.Count > 0)
            {
                if (oList.ContainsKey(obj.sUsername)) return false;

                int MaxId = 0;
                foreach (var newsInfo in oList)
                {
                    if (MaxId < newsInfo.Value.id) MaxId = newsInfo.Value.id;
                }
                obj.id = MaxId + 1;
                oList.Add(obj.sUsername, obj);
                if (UpdateList(oList)) return true;
            }
            return false;
        }

        public static bool UpdateList(Dictionary<string, UserInfo> obj)
        {
            if (obj == null) return false;
            if (SaveSetting(obj))
            {
                HttpContext.Current.Cache.Remove(KeyCache);
                return true;
            }
            return false;
        }

        private static bool SaveSetting(Dictionary<string, UserInfo> obj)
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