using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThreeTierExample.BEL;
using ThreeTierExample.BLL;

namespace ThreeTierExample
{
    public partial class signup : System.Web.UI.Page
    {
        MyUser user = new MyUser();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            user.username = txtUserName.Text;
            user.useremail = txtemail.Text;
            user.userpass = txtpassword.Text;
            if (fpUpload.HasFile)
            {
                user.userphoto = "~/UserPhotos/" + fpUpload.PostedFile.FileName;
                fpUpload.SaveAs(Server.MapPath(user.userphoto));
            }
            else
            {
                user.userphoto = "no image";
            }
            int data = new MyUserObject().AddUserInfo(user);

            if (data > 0)
            {
                Response.Write("user registration succesfully done");
            }
            else
            {
                Response.Write("user registration failed");
            }

        }
    }
}