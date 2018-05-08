using BusinessManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ReceiptTypeList : System.Web.UI.Page
{
    BALReceiptType _ObjBALReceiptType = new BALReceiptType();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetReceiptType();
        }
    }

    private void GetReceiptType()
    {
        int ReceiptId = 0;
        DataSet ds = _ObjBALReceiptType.GetReceiptType(ReceiptId);
        GvReceiptType.DataSource = ds.Tables[0];
        GvReceiptType.DataBind();
    }
    protected void GvConsultants_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string ReceiptTypeId = e.CommandArgument.ToString();
        if (e.CommandName == "Edit Receipt Type Details")
        {
            // int Id = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("ReceiptType.aspx?Id=" + ReceiptTypeId);
        }
        else if (e.CommandName == "Delete Receipt Type Details")
        {
            DeleteReceiptType(Convert.ToInt32(ReceiptTypeId));
            GetReceiptType();
        }

        //Delete Receipt Type Details
    }


    private void DeleteReceiptType(int ReceiptTypeId)
    {
        try
        {
            int Result = _ObjBALReceiptType.DeleteReceiptType(ReceiptTypeId);
        }
        catch (Exception ex)
        {

            //lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
           // ExceptionLogging.SendExcepToDB(ex);
        }
    }
}