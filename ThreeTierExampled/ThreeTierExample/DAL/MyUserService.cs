using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using ThreeTierExample.BEL;

namespace ThreeTierExample.DAL
{
    public class MyUserService
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        Gateway gw = new Gateway();

        public int AddStudent(MyUser user)
        {
            try
            {
                cmd = new SqlCommand("AddStudent", gw.con);
                cmd.Parameters.AddWithValue("@username", user.username);
                cmd.Parameters.AddWithValue("@useremail", user.useremail);
                cmd.Parameters.AddWithValue("@userpass", user.userpass);
                cmd.Parameters.AddWithValue("@userphoto", user.userphoto);
                cmd.CommandType = CommandType.StoredProcedure;
                gw.con.Open();
                cmd.ExecuteNonQuery();
                gw.con.Close();
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
            finally
            {
                gw.con.Dispose();
                cmd.Dispose();
            }
        }
    }
}