using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NNND.AppCode
{
    [Serializable]
    public class NewsInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public int Sort { get; set; }
        public bool Active { get; set; }
    }
}