<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="User_Login" EnableEventValidation="false" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rapti</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
		
    <link href="../Content/Css/UserMasterCss/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/Css/UserMasterCss/bootstrap-responsive.min.css" rel="stylesheet" />
        
    <link href="../Content/Css/UserMasterCss/matrix-login.css" rel="stylesheet" />
    <link href="../Scripts/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
        
		<link href='http://fonts.googleapis.com/css?family=Open+Sans:400,700,800' rel='stylesheet' type='text/css'/>
    <script src='https://www.google.com/recaptcha/api.js'></script>
</head>
<body>
  
     <div id="loginbox"   >           
            <form id="loginform"   runat="server" >
                 <asp:ScriptManager ID="SM1" runat="server">

        </asp:ScriptManager>
				 <div class="control-group normal_text"> <h3><img src="../Admin/CompanyLogos/20180503024807140.png" alt="Logo" /></h3></div>
                <div class="control-group">
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    <div class="controls">
                        <div class="main_input_box">
                            <asp:TextBox ID="userName" placeholder="Username" runat="server"></asp:TextBox>
                           
                        </div>
                    </div>
                </div>
                <div class="control-group">
                    <div class="controls">
                        <div class="main_input_box">
                            <asp:TextBox ID="UserPassword" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
                           
                        </div>
                    </div>
                </div>
                 <asp:UpdatePanel ID="UP1" runat="server">

                        <ContentTemplate>
                <div class="control-group">
                    <div class="controls">
                        <div class="main_input_box">
                             <asp:TextBox ID="txtCaptcha" placeholder="Captcha" runat="server" ></asp:TextBox>
                            

               <%--<div style="Height:35px;Width:326px">--%>
                    <asp:Image ID="ImgCaptcha" runat="server"  style="width: 73%;height: 49px;margin-left: 0px;padding-left: 0px;" />  
                  
                             <asp:ImageButton runat="server" id="btnRefresh"  OnClick="btnRefresh_Click" title="Refresh" ImageUrl="~/Images/Icons/icon-refresh.png"  style="width: 13px;height: 33px"  />
    
                            

                            <%--</div>--%>
               
                <asp:Label runat="server" ID="lblCaptchaMessage"></asp:Label> 
                            </div>
                        </div>
                    </div>
                             </ContentTemplate>
                       </asp:UpdatePanel>  
                 <%--<div class="control-group">
                    <div class="controls">
                        <div class="main_input_box">
                            <input type="text" runat="server" placeholder="Captcha" id="txtCaptcha" />
               
                           <div  style="margin-left:44px">
                <BotDetect:WebFormsCaptcha runat="server" ID="testCaprcha" />
               
                    </div>
                            </div>
                        </div>
                     </div>--%>
                
                
                       
                            <div class="control-group">
                    <div class="controls">
                        <div class="main_input_box">
                    <%--<span class="pull-left"><a href="#" class="flip-link btn btn-info" id="to-recover">Forgot password?</a></span>--%>
                   <asp:Button ID="UserLogin" runat="server" Text="Login" OnClick="UserLogin_Click" 
                                    CssClass="btn btn-danger" />
                            
                             
                         </div>
                        </div>
                   </div>
            </form>
            <%--<form id="recoverform" action="#" >
				<p class="normal_text">Enter your e-mail address below and we will send you instructions how to recover a password.</p>
				
                    <div class="controls">
                        <div class="main_input_box">
                            <span class="add-on bg_lo"><i class="icon-envelope"></i></span><input type="text" placeholder="E-mail address" />
                        </div>
                    </div>
               
                <div class="form-actions">
                    <span class="pull-left"><a href="#" class="flip-link btn btn-success" id="to-login">&laquo; Back to login</a></span>
                    <span class="pull-right"><a class="btn btn-info">Reecover</a></span>
                </div>
            </form>--%>
        </div>
         <script src="../Scripts/jquery.min.js"></script>
       <script src="../Scripts/matrix.login.js"></script>
  
</body>
</html>

