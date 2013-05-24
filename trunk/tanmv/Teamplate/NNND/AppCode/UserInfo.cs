﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NNND.AppCode
{
    [Serializable]
    public class UserInfo
    {
        public int id { get; set; }
        public string sUsername { get; set; }
        public string sPassword { get; set; }
        public string sFullName { get; set; }
        public string sEmail { get; set; }
        public string sMobile { get; set; }
        public string sAddress { get; set; }
        public DateTime CreateDate { get; set; }
        public bool active { get; set; }
    }
}