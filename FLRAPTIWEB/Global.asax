﻿<%@ Application Language="C#" %>
<%@ Import Namespace="SttSalesModule" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
       // BundleConfig.RegisterBundles(BundleTable.Bundles);
    }

    //  void Application_End(object sender, EventArgs e)  
    //{  
    //    //  Code that runs on application shutdown  
  
    //}  
  
    //void Application_Error(object sender, EventArgs e)  
    //{  
    //    // Code that runs when an unhandled error occurs  
  
    //}  
  
    //void Session_Start(object sender, EventArgs e)  
    //{  
    //    // Code that runs when a new session is started  
    //    if (Session["UserLoginId"] != null)  
    //    {  
    //        //Redirect to Welcome Page if Session is not null  
    //        Response.Redirect("Admin/Index.aspx");  
  
    //    }  
    //    else  
    //    {  
    //        //Redirect to Login Page if Session is null & Expires   
    //        Response.Redirect("/Login.aspx");  
  
    //    }  
  
  
    //}

    // void Session_End(object sender, EventArgs e)  
    //{  
    //    // Code that runs when a session ends.   
    //    // Note: The Session_End event is raised only when the sessionstate mode  
    //    // is set to InProc in the Web.config file. If session mode is set to StateServer   
    //    // or SQLServer, the event is not raised.  
  
    //}

</script>
