<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="ThreeTierExample.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Modern</title>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="keywords" content="" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- Bootstrap Core CSS -->
    <link href="css/bootstrap.min.css" rel='stylesheet' type='text/css' />
    <!-- Custom CSS -->
    <link href="css/style.css" rel='stylesheet' type='text/css' />
    <link href="css/font-awesome.css" rel="stylesheet"/>
    <!-- jQuery -->
    <script src="js/jquery.min.js"></script>
    <!----webfonts--->
    <link href='http://fonts.googleapis.com/css?family=Roboto:400,100,300,500,700,900' rel='stylesheet' type='text/css'/>
    <!---//webfonts--->
    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>
</head>
<body id="login">
  <div class="login-logo">
    <a href="index.html"><img src="images/logo.png" alt=""/></a>
  </div>
  <h2 class="form-heading">Register</h2>
  <form runat="server" class="form-signin app-cam" id="form1">
      <p>Enter your personal details below</p>
     <asp:TextBox runat="server" id="txtUserName" CssClass="form-control1" placeholder="enter user name"/> 
       <asp:TextBox runat="server" id="txtemail" CssClass="form-control1" placeholder="enter user email"/>
      <asp:TextBox runat="server"  id="txtpassword" CssClass="form-control1" placeholder="enter user password"/>
<asp:FileUpload  ID="fpUpload" CssClass="form-control1" runat="server" />
	
      <asp:Button Text="Register" CssClass="btn btn-lg btn-success1 btn-block" ID="btnRegister" OnClick="btnRegister_Click" runat="server" />
      <div class="registration">
          Already Registered.
          <a class="" href="#">
              Login
          </a>
      </div>
  </form>
   <div class="copy_layout login register">
      <p>Copyright &copy; 2015 Modern. All Rights Reserved | Design by <a href="http://w3layouts.com/" target="_blank">W3layouts</a> </p>
   </div>
</body>
</html>
