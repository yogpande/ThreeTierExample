using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreeTierExample.BEL
{
    public class MyUser
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string useremail{ get; set; }
        public string userpass{ get; set; }
        public string userphoto { get; set; }
        public bool isActive { get; set; }
        public DateTime regDate { get; set; }
    }
}