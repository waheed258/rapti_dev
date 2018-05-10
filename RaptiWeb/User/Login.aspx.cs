using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityManager;
using BusinessManager;
using System.Data;
using System.Text;

public partial class User_Login : System.Web.UI.Page
{
    BoUtility _objBoUtility = new BoUtility();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Session["UserLoginId"] = null;
            Session["UserCompanyId"] = null;
            Session["UserBranchId"] = null;
            Session["captchaVerify"] = null;
            DynamicCreateCaptcha();
        }
    }


    protected void btnRefresh_Click(object sender, ImageClickEventArgs e)
    {
        DynamicCreateCaptcha();
    }
    protected void UserLogin_Click(object sender, EventArgs e)
    {
        try
        {
            if (Session["captchaVerify"] != null && txtCaptcha.Text == Session["captchaVerify"].ToString())
            {

               

           
            EMUser User = new EMUser();
            User.UserName = string.IsNullOrEmpty(userName.Text) ? "" : userName.Text.ToString();
            User.password = string.IsNullOrEmpty(UserPassword.Text) ? "" : UserPassword.Text.ToString();
            DataSet UserLoginReult = _objBoUtility.User_Login(User.UserName, User.password);
            if(UserLoginReult.Tables.Count>0)
            {
                Session["UserLoginId"] = UserLoginReult.Tables[0].Rows[0]["UserLoginId"].ToString();
                Session["UserCompanyId"] = UserLoginReult.Tables[0].Rows[0]["CompanyId"].ToString();
                Session["UserBranchId"] = UserLoginReult.Tables[0].Rows[0]["BranchId"].ToString();
                Response.Redirect("Index.aspx");
            }
            }

            else
            {

                lblMsg.ForeColor = Color.Red;

                lblMsg.Text = "Captcha code is wrong!!";

            }
        }
        catch (Exception ex)
        {
            
           
        }
    }

    private void DynamicCreateCaptcha()
    {
        Random random = new Random();

        string combination = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        StringBuilder captcha = new StringBuilder();

        for (int i = 0; i < 6; i++)
        {

            captcha.Append(combination[random.Next(combination.Length)]);

            

        }
        Session["captchaVerify"] = captcha.ToString();
        ImgCaptcha.ImageUrl = "Captcha.aspx?" + DateTime.Now.Ticks.ToString();
    }

    private void OtherLogin()
    {
        Response.Clear();

        int height = 30;

        int width = 100;

        Bitmap bmp = new Bitmap(width, height);

        RectangleF rectf = new RectangleF(10, 5, 0, 0);

        Graphics g = Graphics.FromImage(bmp);

        g.Clear(Color.White);

        g.SmoothingMode = SmoothingMode.AntiAlias;

        g.InterpolationMode = InterpolationMode.HighQualityBicubic;

        g.PixelOffsetMode = PixelOffsetMode.HighQuality;

        g.DrawString(Session["captcha"].ToString(), new Font("Thaoma", 12, FontStyle.Italic), Brushes.Chocolate, rectf);

        g.DrawRectangle(new Pen(Color.Blue), 1, 1, width - 2, height - 2);

        g.Flush();

        Response.ContentType = "image/jpeg";

        bmp.Save(Response.OutputStream, ImageFormat.Jpeg);

        g.Dispose();

        bmp.Dispose();
    }
}