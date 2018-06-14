using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThreeTierExample.BEL;
using ThreeTierExample.DAL;

namespace ThreeTierExample.BLL
{
    public class MyUserObject
    {
        private MyUserService us = new MyUserService();

        public int AddUserInfo(MyUser user)
        {
            return us.AddStudent(user);            
        }
    }
}