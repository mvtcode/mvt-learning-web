using System;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Provider;

/// <summary>
/// fix tanmv
/// quản lý Popup cho trang thông tin cá nhân
/// </summary>
public class PopupManager
{
    private static string FILE_NAME = "~/App_Data/popup.ini";

    public static bool GetInfo(int id)
    {
        Dictionary<int, bool> obj = GetSetting();
        if (obj.ContainsKey(id)) return obj[id];
        else return true;
    }

    public static bool Update(int id, bool value)
    {
        if (id == 0) return true;
        Dictionary<int, bool> obj = GetSetting();
        if (obj.ContainsKey(id)) obj[id] = value;
        else obj.Add(id, value);
        if (SaveSetting(obj))
        {
            object oCache = CacheProvider.Get(KeyCache.KeyPopup);
            if (oCache != null) CacheProvider.Update(KeyCache.KeyPopup,obj);
            return true;
        }
        return false;
    }

    private static Dictionary<int, bool> GetSetting()
    {
        object oCache = CacheProvider.Get(KeyCache.KeyPopup);
        if (oCache != null) return (Dictionary<int, bool>)oCache;
        
        Dictionary<int, bool> obj;
        if (!File.Exists(HttpContext.Current.Server.MapPath(FILE_NAME)))
        {
            obj = new Dictionary<int, bool>();
            obj.Add(0,true);//add giá trị mặc định cho người dùng ko đăng nhập
            CacheProvider.Add(KeyCache.KeyPopup, obj);
            return obj;
        }
        Stream fileStream = null;
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        fileStream = File.Open(HttpContext.Current.Server.MapPath(FILE_NAME), FileMode.Open, FileAccess.Read, FileShare.None);
        try
        {
            obj = (Dictionary<int, bool>)binaryFormatter.Deserialize(fileStream);
            CacheProvider.Add(KeyCache.KeyPopup, obj);
            return obj;
        }
        catch
        {
            return new Dictionary<int, bool>();
        }
        finally
        {
            if (fileStream != null)
                fileStream.Close();
        }
    }

    private static bool SaveSetting(Dictionary<int, bool> obj)
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