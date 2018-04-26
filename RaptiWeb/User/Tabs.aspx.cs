﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_Tabs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
  
    if (!IsPostBack)
    {
      Tab1.CssClass = "Clicked";
      MainView.ActiveViewIndex = 0;
    }
  }

  protected void Tab1_Click(object sender, EventArgs e)
  {
    Tab1.CssClass = "Clicked";
    Tab2.CssClass = "Initial";
    Tab3.CssClass = "Initial";
    MainView.ActiveViewIndex = 0;
  }

  protected void Tab2_Click(object sender, EventArgs e)
  {
    Tab1.CssClass = "Initial";
    Tab2.CssClass = "Clicked";
    Tab3.CssClass = "Initial";
    MainView.ActiveViewIndex = 1;
  }

  protected void Tab3_Click(object sender, EventArgs e)
  {
    Tab1.CssClass = "Initial";
    Tab2.CssClass = "Initial";
    Tab3.CssClass = "Clicked";
    MainView.ActiveViewIndex = 2;
  }
  protected void txtName_TextChanged(object sender, EventArgs e)
  {
      txtName.Text = "ANitha";
  }
}
   