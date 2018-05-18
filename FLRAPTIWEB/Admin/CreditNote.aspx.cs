﻿using BusinessManager;
using DataManager;
using EntityManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_CreditNote : System.Web.UI.Page
{
    DOUtility _doUtilities = new DOUtility();
    BOUtiltiy _objBOUtiltiy = new BOUtiltiy();
    EmAirTicket _objAirTicket = new EmAirTicket();
    EMCommission _objCommission = new EMCommission();
    EmAirticketRouting _objAirtickRouting = new EmAirticketRouting();
    BALInvoice objBALInvoice = new BALInvoice();

    EmInvoice _objEmInvoice = new EmInvoice();
    DALInvoice _objDalInvoice = new DALInvoice();
    BALInvoice _objBalInvoice = new BALInvoice();
    BALAirTicket _objBALAirTicket = new BALAirTicket();

    BALServicefee _objBalservice = new BALServicefee();
    BACommission _objBalCommission = new BACommission();
    DALServicefee _objDalService = new DALServicefee();
    DALGeneralCharge _objDalGenchrge = new DALGeneralCharge();
    EMGeneralCharge _objEmGenCharge = new EMGeneralCharge();

    EMServicefee _objEmService = new EMServicefee();
    decimal ExclusiveAmount;

    //land

    EMLandarrangement objEMLandarrangement = new EMLandarrangement();
    DALandarrangement objDALandarrangement = new DALandarrangement();
    //Acm
    DALAgencyCreditMemo objDALACM = new DALAgencyCreditMemo();
    EMAgencyCreditMemo objEMACM = new EMAgencyCreditMemo();
    //ADM
    DALAgencyDebitMemo objDALADM = new DALAgencyDebitMemo();
    EMAgencyDebitMemo objEMADM = new EMAgencyDebitMemo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
         //   BindSerTicketNumber();
         //   BIndRefundType();
         //   lblRoutes1.Enabled = false;
         //   lblRoutes2.Enabled = false;
         //   lblRoutes3.Enabled = false;
         //   lblRoutes4.Enabled = false;
         //   txtAirCommInclu.Enabled = false;
         //   txtVatPer.Enabled = false;
         //   txtAirVatOnFare.Enabled = false;
         //   txtAirClientTot.Enabled = false;
         //   txtAirDueToBsp.Enabled = false;
         //   txtAirCommVat.Enabled = false;
         //   txtAirAgentVat.Enabled = false;
         //   ddlInvMesg.Enabled = false;
         //   DDLACMSupplier.Enabled = false;
         //   DDLACMType.Enabled = false;
         //   txtRefundAmt.Enabled = false;

         //   BindTypes();
         //   BindAirServiceTypes();
         //   BindAirLine();
         //   //general Charge
         //   DataSet objDs = null; // Single sp
         //   //  BindGenServiceTypes();

         //   //   BindGenCreditCardType();
         //   //txtRateNet.Enabled = false;
         //   //txtVatAmount.Enabled = false;
         //   //txtExcluAmount.Enabled = false;
         //   //txtClientTotal.Enabled = false;
         //   //service fee---
         //   BindSerServiceTypes();
         //   ddlPassengerName.Enabled = false;
         
         //   BindPaymentType();

         //   ddlCreditCardType.Enabled = false;
         //   ddlCollectVia.Enabled = false;
         //   txtTASFMPD.Enabled = false;
         //   //txtClientTotal.Enabled = false;
         //   rfvtxtTASFMPD.Enabled = false;
         //   rfvddlCollectVia.Enabled = false;
         //   rfvddlCreditCardType.Enabled = false;
         //   ddlTicketno.Enabled = false;

         //   //land
         //   BindLandSuppliers();
         //   BindType();
         //   BindLandPaymentType();
         //   BindLandService();
         //   DDlandCreditCard.Enabled = false;
         //   txtLandVatPer.Enabled = false;
         //   txtLandExlVatPer.Enabled = false;
         //   txtlandExclVatAmount.Enabled = false;
         //   txtlandDuefromclient.Enabled = false;
         //   txtlandLessComm.Enabled = false;
         //   txtlandDuetoSupplier.Enabled = false;
         //   txtlandCommIncl.Enabled = false;
         //   txtlandVatAmount.Enabled = false;
         //   txtlandCommExcl.Enabled = false;

         //   txtlandCmblIncl.Enabled = false;
         //   txtlandcmblExcl.Enabled = false;
         //   txtlandTotalcmblIncl.Enabled = false;
         //   Session["TempUniqCode"] = "";
         //   Session["RoutTempID"] = "";
         //   BindInvoiceLineItems();
         
         //   //invoice Loading
         //   AirTicketType();
         //   BindInvoiceDropDown();
         //   //Acm
         //   BindAcmType();
      
         //   //Adm
         ////   BindADMCreditCrard();
         //   BindADMType();
         //   BindAdmSuppliers();
         //   //edit for Invoice
         //   if (!string.IsNullOrEmpty(Request.QueryString["InvId"]))
         //   {
         //       int InvId = Convert.ToInt32(Request.QueryString["InvId"]);
         //       btnInvSave.Text = "Update";
         //       //Button1.Style.Add("display", "none");
         //       InvListGrid.Columns[6].Visible = false;
         //       drpInvClientType.Enabled = false;
         //       drpInvClientName.Enabled = false;
         //       txtInvDate.Enabled = false;
         //       ddlInvCosultant.Enabled = false;
         //       txtInvBookNo.Enabled = false;
         //       drpInvBookingSrc.Enabled = false;
         //       drpInvBookDest.Enabled = false;
         //       ddlInvPdfPrintStyle.Enabled = false;
              
         //   }
         //   //AirTicket ROuting

         //   AirticketRouting_Disabled();

         //   BindPrintStyle();


        }
    }
    //private void AirticketRouting_Disabled()
    //{

    //    try
    //    {
    //        txtDate1.Enabled = false;
    //        txtDate2.Enabled = false;
    //        txtDate3.Enabled = false;
    //        txtDate4.Enabled = false;
    //        txtFlightNo1.Enabled = false;
    //        txtFlightNo2.Enabled = false;
    //        txtFlightNo3.Enabled = false;
    //        txtFlightNo4.Enabled = false;
    //        txtClass1.Enabled = false;
    //        txtClass2.Enabled = false;
    //        txtClass3.Enabled = false;
    //        txtClass4.Enabled = false;

    //        rfvtxtFlightNo1.Enabled = false;
    //        rfvtxtClass1.Enabled = false;
    //        rfvtxtDate1.Enabled = false;

    //        rfvtxtFlightNo2.Enabled = false;
    //        rfvtxtClass2.Enabled = false;
    //        rfvtxtDate2.Enabled = false;

    //        rfvtxtFlightNo3.Enabled = false;
    //        rfvtxtClass3.Enabled = false;
    //        rfvtxtDate3.Enabled = false;

    //        rfvtxtFlightNo4.Enabled = false;
    //        rfvtxtClass4.Enabled = false;
    //        rfvtxtDate4.Enabled = false;
    //    }

    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //        ExceptionLogging.SendExcepToDB(ex);
    //    }
    //}
    protected void cmdClose_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            VASPopupExtender.Hide();
            AirticketClear();
            LandArrangemntsClear();
            ServiceFeeClear();
            //GeneralChargeClear();
            //GenSubmit.Text = "Submit";
            SerSubmit.Text = "Submit";
            LandArrSubmit.Text = "Submit";
            btnAirSubmit.Text = "Submit";
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
        }
    }

    protected void txtExcluisvefare_TextChanged(object sender, EventArgs e)
    {
        try
        {
            exclVatCal();
            // routingLablesShow();
            VASPopupExtender.Show();
            if (txtAirCommisionper.Text != "")
            {
                txtAirCommisionper_TextChanged(null, null);
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            BindVatByType();
            exclVatCal();
            if (txtAirCommisionper.Text != "")
            {
                txtAirCommisionper_TextChanged(null, null);
            }

            VASPopupExtender.Show();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }


    }
    private void BindAirServiceTypes()
    {
        try
        {
            string Type = "Air";
            DataSet ds = new DataSet();
            ds = _doUtilities.GetServiceTypeByType(Type);

            if (ds.Tables[0].Rows.Count > 0)
            {

                ddlAirService.DataSource = ds.Tables[0];
                ddlAirService.DataTextField = "ComDesc";
                ddlAirService.DataValueField = "ComId";
                ddlAirService.DataBind();
                ddlAirService.Items.Insert(0, new ListItem("--Select Service--", "0"));

            }
            else
            {
                ddlAirService.DataSource = null;
                ddlAirService.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    private void BindAirLine()
    {
        try
        {
            int supplierid = 0;
            BAAirSuppliers _boAirSupplier = new BAAirSuppliers();
            DataSet ds = new DataSet();
            ds = _boAirSupplier.GetAirSuppliers(supplierid);

            if (ds.Tables[0].Rows.Count > 0)
            {

                ddlAirLine.DataSource = ds.Tables[0];
                ddlAirLine.DataTextField = "SupplierName";
                ddlAirLine.DataValueField = "SupplierId";
                ddlAirLine.DataBind();
                ddlAirLine.Items.Insert(0, new ListItem("--Select AirLine--", "0"));



                DDLACMSupplier.DataSource = ds.Tables[0];
                DDLACMSupplier.DataTextField = "SupplierName";
                DDLACMSupplier.DataValueField = "SupplierId";
                DDLACMSupplier.DataBind();
                DDLACMSupplier.Items.Insert(0, new ListItem("--Select AirLine--", "0"));
            }
            else
            {
                ddlAirLine.DataSource = null;
                ddlAirLine.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    protected void ddlAirLine_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            ddlAirService.Items.Clear();

            int supplierid = Convert.ToInt32(ddlAirLine.SelectedValue.ToString());
            BAAirSuppliers _boAirSupplier = new BAAirSuppliers();
            DataSet ds = new DataSet();
            ds = _boAirSupplier.GetAirSuppliers(supplierid);

            if (ds.Tables[1].Rows.Count > 0)
            {

                ddlAirService.DataSource = ds.Tables[1];
                int ComId = Convert.ToInt32(ds.Tables[1].Rows[0]["ComId"].ToString());

                ddlAirService.SelectedValue = ComId.ToString();
                ddlAirService.DataBind();
                ddlAirService.Items.Insert(0, new ListItem("--Select Service--", "0"));
                VASPopupExtender.Show();
            }
            else
            {
                VASPopupExtender.Show();
                BindAirServiceTypes();
                ddlAirService.DataSource = null;
                ddlAirService.DataBind();
            }

            int commId = Convert.ToInt32(ddlAirService.SelectedItem.Value);
            DataSet comds = _objBOUtiltiy.GetCommissionPerc(commId);

            decimal commperc = string.IsNullOrEmpty(comds.Tables[0].Rows[0]["ComDComm"].ToString()) ? 0 : Convert.ToDecimal(comds.Tables[0].Rows[0]["ComDComm"].ToString());

            txtAirCommisionper.Text = _objBOUtiltiy.FormatTwoDecimal(commperc.ToString());

        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }
    private void exclVatCal()
    {
        try
        {

            decimal clientmount;

            if (txtAirExcluisvefare.Text != "")
            {
                decimal exclusiveFare = Convert.ToDecimal(txtAirExcluisvefare.Text);
                txtAirExcluisvefare.Text = _objBOUtiltiy.FormatTwoDecimal(txtAirExcluisvefare.Text);
                if (txtAirportTax.Text != "")
                {
                    clientmount = Convert.ToDecimal(txtAirExcluisvefare.Text) + Convert.ToDecimal(txtAirportTax.Text);
                    txtAirClientTot.Text = _objBOUtiltiy.FormatTwoDecimal(clientmount.ToString());
                }
                else
                {
                    txtAirClientTot.Text = txtAirExcluisvefare.Text;
                }
            }

            if (txtVatPer.Text != "" && txtAirExcluisvefare.Text != "")
            {
                decimal inclusiveAmount = Convert.ToDecimal(GlobalClass.exclVatSum(txtAirExcluisvefare.Text, txtVatPer.Text));
                // decimal inclusiveAmount = (exclusiveFare * Convert.ToDecimal(txtVatPer.Text)) / 100;
                txtAirVatOnFare.Text = inclusiveAmount.ToString();
                if (txtAirportTax.Text != "")
                {

                    txtAirClientTot.Text = (inclusiveAmount + Convert.ToDecimal(txtAirExcluisvefare.Text) + Convert.ToDecimal(txtAirportTax.Text)).ToString();
                }
                else
                {
                    txtAirClientTot.Text = (inclusiveAmount + Convert.ToDecimal(txtAirExcluisvefare.Text)).ToString();
                }

            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }
    private void BindTypes()
    {
        try
        {
            DataSet ds = new DataSet();
            ds = _doUtilities.get_Type();

            if (ds.Tables[0].Rows.Count > 0)
            {

                ddlType.DataSource = ds.Tables[0];
                ddlType.DataTextField = "TypeName";
                ddlType.DataValueField = "TypeId";
                ddlType.DataBind();
                ddlType.Items.Insert(0, new ListItem("--Select Type--", "0"));
            }
            else
            {
                ddlType.DataSource = null;
                ddlType.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    private void BindVatByType()
    {
        //try
        //{
        //    DataSet ds = new DataSet();
        //    string vatRate = Convert.ToString(_doUtilities.getVatByType(Convert.ToInt32(ddlType.SelectedValue)));
        //    txtAirCommVat.Text = vatRate;
        //    txtVatPer.Text = vatRate;

        //}
        //catch (Exception ex)
        //{
        //    lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
        //    ExceptionLogging.SendExcepToDB(ex);
        //}
    }

    private void commExcAmount()
    {
        try
        {


            if (txtAirExcluisvefare.Text != "" && txtAirCommisionper.Text != "")
            {
                decimal exclusiveFare = Convert.ToDecimal(txtAirExcluisvefare.Text);
                string AirCommExclu = ((Convert.ToDecimal(txtAirCommisionper.Text) * exclusiveFare) / 100).ToString();
                txtAirCommExclu.Text = _objBOUtiltiy.FormatTwoDecimal(AirCommExclu.ToString());



            }

            if (txtAirCommExclu.Text != "" && txtAirCommVat.Text != "")
            {
                decimal commisionInclAmount = Convert.ToDecimal(GlobalClass.exclVatSum(txtAirCommExclu.Text, txtAirCommVat.Text));
                // decimal inclusiveAmount = (exclusiveFare * Convert.ToDecimal(txtVatPer.Text)) / 100;
                txtAirAgentVat.Text = commisionInclAmount.ToString();
                txtAirCommInclu.Text = (commisionInclAmount + Convert.ToDecimal(txtAirCommExclu.Text)).ToString();
                txtAirDueToBsp.Text = (Convert.ToDecimal(txtAirClientTot.Text) - Convert.ToDecimal(txtAirCommInclu.Text)).ToString();
            }

        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void btnInvSave_Click(object sender, EventArgs e)
    {

        try
        {
            InsertInvoice();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }

    public void BindPrintStyle()
    {
        try
        {
            DataSet ds = new DataSet();
            ds = _objBalInvoice.Get_printstyle();

            if (ds.Tables[0].Rows.Count > 0)
            {

                ddlInvPdfPrintStyle.DataSource = ds.Tables[0];
                ddlInvPdfPrintStyle.DataTextField = "Name";
                ddlInvPdfPrintStyle.DataValueField = "PrintstyleId";
                ddlInvPdfPrintStyle.DataBind();
                ddlInvPdfPrintStyle.Items.Insert(0, new ListItem("--Select Print Style--", "0"));
            }
            else
            {
                ddlInvPdfPrintStyle.Items.Insert(0, new ListItem("--Select Print Style--", "0"));
                ddlInvPdfPrintStyle.DataSource = null;
                ddlInvPdfPrintStyle.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }


    private void GetInvDetails(int InvId)
    {
        try
        {
         
            _objEmInvoice.InvId = InvId;

            DataSet ds = _objBalInvoice.GetInvoice(InvId);


            if (ds.Tables.Count > 0)
            {

                hf_InvId.Value = ds.Tables[0].Rows[0]["InvId"].ToString();
                txtInvDate.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[0].Rows[0]["InvDate"].ToString());
                drpInvClientType.SelectedIndex = drpInvClientType.Items.IndexOf(drpInvClientType.Items.FindByValue(ds.Tables[0].Rows[0]["ClientTypeId"].ToString()));
                BindClientNames();

                drpInvClientName.SelectedIndex = drpInvClientName.Items.IndexOf(drpInvClientName.Items.FindByValue(ds.Tables[0].Rows[0]["ClientNameId"].ToString()));

                ddlInvCosultant.SelectedIndex = ddlInvCosultant.Items.IndexOf(ddlInvCosultant.Items.FindByValue(ds.Tables[0].Rows[0]["ConsultantId"].ToString()));
                txtInvOrder.Text = ds.Tables[0].Rows[0]["InvOrder"].ToString();
                txtInvBookNo.Text = ds.Tables[0].Rows[0]["BookingNo"].ToString();
                drpInvBookingSrc.SelectedIndex = drpInvBookingSrc.Items.IndexOf(drpInvBookingSrc.Items.FindByValue(ds.Tables[0].Rows[0]["BookSourceId"].ToString()));
                drpInvBookDest.SelectedIndex = drpInvBookDest.Items.IndexOf(drpInvBookDest.Items.FindByValue(ds.Tables[0].Rows[0]["BookDestinationId"].ToString()));
                BindInvoiceMessage();
                ddlInvMesg.SelectedIndex = ddlInvMesg.Items.IndexOf(ddlInvMesg.Items.FindByValue(ds.Tables[0].Rows[0]["Message"].ToString()));
                txtInvClntMesg.Text = ds.Tables[0].Rows[0]["Message"].ToString();
                ddlInvPdfPrintStyle.SelectedIndex = ddlInvPdfPrintStyle.Items.IndexOf(ddlInvPdfPrintStyle.Items.FindByValue(ds.Tables[0].Rows[0]["PrintStyleId"].ToString()));
             
            
                // ButtonAssociateRules.Style["visibility"] = "hidden";

              


                updatepanelContacts.Update();

            }
        }
        catch(Exception ex)
        {
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    private void InsertInvoice()
    {

        try
        {
            int InvoiceId=0;string type="";

            foreach (GridViewRow row in InvListGrid.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    TextBox txtThisEntry = row.FindControl("txtThisEntry") as TextBox;
                    HiddenField hfTicketId = row.FindControl("hfTicketId") as HiddenField;
                    HiddenField hfInvId = row.FindControl("hfInvId") as HiddenField;
                    HiddenField hfType = row.FindControl("hfType") as HiddenField;

                    if (!_objBOUtiltiy.TryParseCheckValue(txtThisEntry.Text, "Decimal"))
                    {
                        txtThisEntry.Text = "0";

                    }
                    if (txtThisEntry.Text != "" && txtThisEntry.Text != "0" && txtThisEntry.Text != "0.00")
                    {


                        int ticketId = Convert.ToInt32(hfTicketId.Value);
                         InvoiceId = Convert.ToInt32(hfInvId.Value);
                         type = hfType.Value;
                        decimal refundAmount = Convert.ToDecimal(txtThisEntry.Text);
                         _objBalInvoice.CreditNote_Insert(InvoiceId, ticketId, type, refundAmount);


                    }

                }
            }


            int result = _objBalInvoice.CreditNote_Insert(InvoiceId, 0, "Invoice", Convert.ToDecimal(lblInvoiceRefundAmt.Text));
           if (result > 0)
           {
            
               Response.Redirect("InvoiceList.aspx");
               Session["TempUniqCode"] = "";

           }


        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    private void routingLablesShow()
    {
        try
        {
            string routing = txtAirRouting.Text;
            if (routing.Contains("/"))
            {

                String[] RoutingArray = routing.Split('/');
                for (int i = 0; i < RoutingArray.Length - 1; i++)
                {

                    if (i == 0)
                    {
                        lblRoutes1.Text = RoutingArray[0] + "/" + RoutingArray[1];
                        txtFlightNo1.Enabled = true;
                        txtDate1.Enabled = true;
                        txtClass1.Enabled = true;

                        rfvtxtFlightNo1.Enabled = true;
                        rfvtxtClass1.Enabled = true;
                        rfvtxtDate1.Enabled = true;

                    }
                    if (i == 1)
                    {
                        lblRoutes2.Text = RoutingArray[1] + "/" + RoutingArray[2];
                        txtDate2.Enabled = true;
                        txtFlightNo2.Enabled = true;
                        txtClass2.Enabled = true;

                        rfvtxtFlightNo2.Enabled = true;
                        rfvtxtClass2.Enabled = true;
                        rfvtxtDate2.Enabled = true;

                    }

                    if (i == 2)
                    {
                        lblRoutes3.Text = RoutingArray[2] + "/" + RoutingArray[3];
                        txtDate3.Enabled = true;
                        txtFlightNo3.Enabled = true;
                        txtClass3.Enabled = true;

                        rfvtxtFlightNo3.Enabled = true;
                        rfvtxtClass3.Enabled = true;
                        rfvtxtDate3.Enabled = true;

                    }

                    if (i == 3)
                    {
                        lblRoutes4.Text = RoutingArray[3] + "/" + RoutingArray[4];
                        txtDate4.Enabled = true;
                        txtFlightNo4.Enabled = true;
                        txtClass4.Enabled = true;

                        rfvtxtFlightNo4.Enabled = true;
                        rfvtxtClass4.Enabled = true;
                        rfvtxtDate4.Enabled = true;
                    }

                }
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }



    protected void txtDate_TextChanged(object sender, EventArgs e)
    {
        txtAirTravelDate.Text = txtDate1.Text;
        VASPopupExtender.Show();
    }


    private void InsertAirTicket()
    {
        //hf_Air_TicketNo
        try
        {
            _objAirTicket.TicketId = 0;
            if (btnAirSubmit.Text == "Update")
            {
                _objAirTicket.TicketId = Convert.ToInt32(hf_Air_TicketNo.Value);
            }
            _objAirTicket.AirTicketNo = string.IsNullOrEmpty(txtAirTicketNo.Text) ? "" : txtAirTicketNo.Text;
            _objAirTicket.Type = Convert.ToInt32(ddlType.SelectedValue.ToString());
            _objAirTicket.AirPnr = string.IsNullOrEmpty(txtPnr.Text) ? "" : txtPnr.Text;
            _objAirTicket.AirPassenger = string.IsNullOrEmpty(drpAirPassenger.Text) ? "" : drpAirPassenger.Text;

            _objAirTicket.Conjunction = string.IsNullOrEmpty(txtAirConjunction.Text) ? "" : txtAirConjunction.Text;

            _objAirTicket.Airline = Convert.ToInt32(ddlAirLine.SelectedValue.ToString());
            _objAirTicket.AirService = Convert.ToInt32(ddlAirService.SelectedValue.ToString());
            _objAirTicket.AirTicketType = Convert.ToInt32(drpTicketType.SelectedValue.ToString());

            _objAirTicket.AirRouting = string.IsNullOrEmpty(txtAirRouting.Text) ? "" : txtAirRouting.Text;



            _objAirTicket.AirMiles = string.IsNullOrEmpty(txtAirMiles.Text) ? "" : txtAirMiles.Text;

            _objAirTicket.AirTravelDate = string.IsNullOrEmpty(txtAirTravelDate.Text) ? (DateTime?)null : Convert.ToDateTime(txtAirTravelDate.Text);
            _objAirTicket.AirReturnDate = string.IsNullOrEmpty(txtAirReturnDate.Text) ? (DateTime?)null : Convert.ToDateTime(txtAirReturnDate.Text);

            _objAirTicket.AirExclusiveFare = string.IsNullOrEmpty(txtAirExcluisvefare.Text) ? (0.0M) : Convert.ToDecimal(txtAirExcluisvefare.Text);
            _objAirTicket.AirVatonFare = string.IsNullOrEmpty(txtAirVatOnFare.Text) ? (0.0M) : Convert.ToDecimal(txtAirVatOnFare.Text);

            _objAirTicket.AirportTaxes = string.IsNullOrEmpty(txtAirportTax.Text) ? (0.0M) : Convert.ToDecimal(txtAirportTax.Text);
            _objAirTicket.AirVatInTaxes = string.IsNullOrEmpty(txtAirVatinclTax.Text) ? (0.0M) : Convert.ToDecimal(txtAirVatinclTax.Text);
            _objAirTicket.AirClientTotal = string.IsNullOrEmpty(txtAirClientTot.Text) ? (0.0M) : Convert.ToDecimal(txtAirClientTot.Text);
            _objAirTicket.AirPayment = Convert.ToInt32(ddlAirPayment.SelectedValue.ToString());


            // _objAirTicket.AirCreditCardType = Convert.ToDecimal(txtAirportTax.Text);
            _objAirTicket.AirCommPer = string.IsNullOrEmpty(txtAirCommisionper.Text) ? (0.0M) : Convert.ToDecimal(txtAirCommisionper.Text);
            _objAirTicket.AirCommExcl = string.IsNullOrEmpty(txtAirCommExclu.Text) ? (0.0M) : Convert.ToDecimal(txtAirCommExclu.Text);
            _objAirTicket.AirCommVatPer = string.IsNullOrEmpty(txtAirCommVat.Text) ? (0.0M) : Convert.ToDecimal(txtAirCommVat.Text);

            _objAirTicket.AirAgentVat = string.IsNullOrEmpty(txtAirAgentVat.Text) ? (0.0M) : Convert.ToDecimal(txtAirAgentVat.Text);
            _objAirTicket.AirCommInclu = string.IsNullOrEmpty(txtAirCommInclu.Text) ? (0.0M) : Convert.ToDecimal(txtAirCommInclu.Text);
            _objAirTicket.AirDueToBsp = string.IsNullOrEmpty(txtAirDueToBsp.Text) ? 0 : Convert.ToDecimal(txtAirDueToBsp.Text);
            _objAirTicket.SupplOpenAmount = string.IsNullOrEmpty(txtAirDueToBsp.Text) ? 0 : Convert.ToDecimal(txtAirDueToBsp.Text);
            _objAirTicket.InvoiceType = "Air";
            _objAirTicket.invDocumentNo = "0";
            _objAirTicket.IsCreditNote = 1;
            //
            if (Session["RoutTempID"] == null || Session["RoutTempID"] == "")
            {
                _objAirTicket.AirRoutTempID = uniqueIdSession();
            }
            else
            {
                _objAirTicket.AirRoutTempID = Session["RoutTempID"].ToString();
            }

            if (Session["TempUniqCode"] == null || Session["TempUniqCode"] == "")
            {
                _objAirTicket.TempUniqCode = uniqueIdSession();
            }
            else
            {
                _objAirTicket.TempUniqCode = Session["TempUniqCode"].ToString();
            }


            _objAirTicket.CreatedBy = 0;


            int Result = _objBALAirTicket.InsertAirTicket(_objAirTicket);


            if (Result > 0)
            {
                lblMsg.Text = _objBOUtiltiy.ShowMessage("success", "Success", "ServiceFee created Successfully");
                // clearcontrols();



                Session["TempUniqCode"] = _objAirTicket.TempUniqCode;

                Session["RoutTempID"] = _objAirTicket.AirRoutTempID;

                for (int i = 1; i <= 4; i++)
                {
                    // TextBox flight = FindControl(string.Concat("txtFlightNo", i.ToString())) as TextBox;

                    TextBox Routs = (TextBox)updatepanelContacts.FindControl("lblRoutes" + i);

                    _objAirtickRouting.Routs = string.IsNullOrEmpty(Routs.Text) ? "" : Routs.Text;


                    TextBox txt = (TextBox)updatepanelContacts.FindControl("txtFlightNo" + i);

                    _objAirtickRouting.FlightNo = string.IsNullOrEmpty(txt.Text) ? "" : txt.Text;

                    TextBox classes = (TextBox)updatepanelContacts.FindControl("txtClass" + i);



                    _objAirtickRouting.Class = string.IsNullOrEmpty(classes.Text) ? "" : classes.Text;


                    TextBox routing = (TextBox)updatepanelContacts.FindControl("txtAirRouting");

                    _objAirtickRouting.Routing = string.IsNullOrEmpty(routing.Text) ? "" : routing.Text;


                    TextBox miles = (TextBox)updatepanelContacts.FindControl("txtAirMiles");
                    _objAirtickRouting.Miles = string.IsNullOrEmpty(miles.Text) ? "" : miles.Text;

                    //    _objAirtickRouting.AirticketId = _objAirTicket.TicketId;
                    _objAirtickRouting.InvoiceId = 0;
                    _objAirtickRouting.TicketType = "Air";
                    _objAirtickRouting.TempUniqCode = Session["RoutTempID"].ToString();

                    TextBox date = (TextBox)updatepanelContacts.FindControl("txtDate" + i);
                    //_objAirtickRouting.Date = Convert.ToDateTime(string.IsNullOrEmpty(date.Text) ? "0" : date.Text);

                    _objAirtickRouting.Date = string.IsNullOrEmpty(date.Text) ? (DateTime?)null : Convert.ToDateTime(date.Text);
                    if (txt.Text == "" && classes.Text == "" && date.Text == "")
                    {

                    }
                    else
                    {
                        int airrouting = _objBALAirTicket.InsertAirticketRouting(_objAirtickRouting);

                    }
                }
                int UpdateAirResult = _objBALAirTicket.updateAirticketId(Result, Session["RoutTempID"].ToString()); ;

                //Session["RoutTempID"] = "";
                //BindInvoiceLineItems();
                //();
                //AirticketClear();
                //ddlSoureceref.Items.Clear();
                //ddlPassengerName.Items.Clear();
                //BindSerTicketNumber();
                //ddlPassengerNames.Items.Clear();
                //BindGenPassengerNames();

            }
            else
            {
                lblMsg.Text = _objBOUtiltiy.ShowMessage("info", "Info", "AirTckt Routing Details was not created plase try again");
            }
            Session["RoutTempID"] = "";
            BindInvoiceLineItems();
          
            AirticketClear();
            ddlSoureceref.Items.Clear();
            ddlPassengerName.Items.Clear();
            BindSerTicketNumber();
            //ddlPassengerNames.Items.Clear();
            //BindGenPassengerNames();
            VASPopupExtender.Hide();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }



    private static string uniqueIdSession()
    {
        //try
        //{
        var now = DateTime.Now;
        DateTime zeroDate = DateTime.MinValue.AddDays(now.Day).AddHours(now.Hour).AddMinutes(now.Minute).AddSeconds(now.Second).AddMilliseconds(now.Millisecond);
        string uniqueId = (zeroDate.Ticks / 10000).ToString();
        return uniqueId;
        //  }
        // catch (Exception ex)
        //  {
        //      lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);

        //  }
    }
    protected void txtAirCommisionper_TextChanged(object sender, EventArgs e)
    {
        try
        {
            commExcAmount();
            //routingLablesShow();
            VASPopupExtender.Show();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void txtAirRouting_TextChanged(object sender, EventArgs e)
    {
        //try
        //{
        //    AirticketRouting_Disabled();
        //    //divRouteHead.Visible = true;
        //    //divRouting.Visible = true;
        //    routingLablesShow();

        //    VASPopupExtender.Show();
        //    txtFlightNo1.Text = "";
        //    txtFlightNo2.Text = "";
        //    txtFlightNo3.Text = "";
        //    txtFlightNo4.Text = "";
        //    txtClass1.Text = "";
        //    txtClass2.Text = "";
        //    txtClass3.Text = "";
        //    txtClass4.Text = "";
        //    txtDate1.Text = "";
        //    txtDate2.Text = "";
        //    txtDate3.Text = "";
        //    txtDate4.Text = "";
        //}
        //catch (Exception ex)
        //{
        //    lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
        //    ExceptionLogging.SendExcepToDB(ex);
        //}

    }

    protected void ddlAirService_SelectedIndexChanged(object sender, EventArgs e)
    {
        int commId = Convert.ToInt32(ddlAirService.SelectedItem.Value);
        DataSet ds = _objBOUtiltiy.GetCommissionPerc(commId);

        decimal commperc = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["ComDComm"].ToString()) ? 0 : Convert.ToDecimal(ds.Tables[0].Rows[0]["ComDComm"].ToString());

        txtAirCommisionper.Text = _objBOUtiltiy.FormatTwoDecimal(commperc.ToString());

        VASPopupExtender.Show();
    }

    protected void btnAirSubmit_Click1(object sender, EventArgs e)
    {

        try
        {
            InsertAirTicket();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    //general Charge And service fee
    /////---------General Charge------------------///////////////////

    //private void InsertGeneralCharge()
    //{
    //    try
    //    {//hf_GC_TicketNo
    //        _objEmGenCharge.GenChgId = Convert.ToInt32(hf_GC_TicketNo.Value);
    //        _objEmGenCharge.Type = Convert.ToInt32(ddlGenchrgType.SelectedValue.ToString());
    //        _objEmGenCharge.PassengerName = ddlPassengerNames.SelectedValue.ToString();
    //        _objEmGenCharge.Details = txtDetails.Text;
    //        _objEmGenCharge.CreditCard = Convert.ToInt32(ddlCrdCardType.SelectedValue.ToString());
    //        _objEmGenCharge.Units = Convert.ToInt32(txtUnits.Text);
    //        _objEmGenCharge.RateNet = Convert.ToDecimal(txtRateNet.Text);
    //        _objEmGenCharge.VatPer = string.IsNullOrEmpty(txtgenvat.Text) ? 0 : Convert.ToDecimal(txtgenvat.Text);
    //        _objEmGenCharge.VatAmount = string.IsNullOrEmpty(txtVatAmount.Text) ? 0 : Convert.ToDecimal(txtVatAmount.Text);

    //        _objEmGenCharge.ExcluAmt = Convert.ToDecimal(txtExcluAmount.Text);
    //        _objEmGenCharge.ClientTot = Convert.ToDecimal(txtClientTotal.Text);
    //        _objEmGenCharge.InvoiceType = "GC";
    //        _objEmGenCharge.invDocumentNo = "0";
    //        _objEmGenCharge.CreatedBy = 0;
    //        if (Session["TempUniqCode"] == null || Session["TempUniqCode"] == "")
    //        {
    //            _objEmGenCharge.GenTempUniqCode = uniqueIdSession();
    //        }
    //        else
    //        {
    //            _objEmGenCharge.GenTempUniqCode = Session["TempUniqCode"].ToString();
    //        }
    //        int Result = _objDalGenchrge.InsertGencharge(_objEmGenCharge);

    //        if (Result > 0)
    //        {
    //            if (Session["TempUniqCode"] == null || Session["TempUniqCode"] == "")
    //            {
    //                Session["TempUniqCode"] = _objEmGenCharge.GenTempUniqCode;
    //            }
    //            lblMsg.Text = _objBOUtiltiy.ShowMessage("success", "Success", "ServiceFee created Successfully");
    //            clearcontrols();
    //            BindInvoiceLineItems();
    //            ();
    //            GeneralChargeClear();

    //        }
    //        else
    //        {
    //            lblMsg.Text = _objBOUtiltiy.ShowMessage("info", "Info", "ServiceFee Details was not created plase try again");
    //        }
    //        GenPopupExtender.Hide();
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}

    private void clearcontrols()
    {

    }

    //private void BindGenPassengerNames()
    //{
    //    try
    //    {
    //        DataSet ds = new DataSet();
    //        string tempuniqcode = Session["TempUniqCode"].ToString();
    //        int airtickno = 0;
    //        ds = _objBalservice.BindPassengerNames(tempuniqcode, airtickno);

    //        if (ds.Tables[0].Rows.Count > 0)
    //        {

    //            ddlPassengerNames.DataSource = ds.Tables[0];
    //            ddlPassengerNames.DataTextField = "AirPassenger";
    //            ddlPassengerNames.DataValueField = "TicketId";
    //            ddlPassengerNames.DataBind();
    //            ddlPassengerNames.Items.Insert(0, new ListItem("--Select Passenger Name--", "0"));
    //        }
    //        else
    //        {
    //            ddlPassengerNames.DataSource = null;
    //            ddlPassengerNames.DataBind();
    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}
    //private void BindGenServiceTypes()
    //{
    //    try
    //    {
    //        string Type = "GC";
    //        DataSet ds = new DataSet();
    //        ds = _doUtilities.GetServiceTypeByType(Type);

    //        if (ds.Tables[0].Rows.Count > 0)
    //        {

    //            ddlGenchrgType.DataSource = ds.Tables[0];
    //            ddlGenchrgType.DataTextField = "ComDesc";
    //            ddlGenchrgType.DataValueField = "ComId";
    //            ddlGenchrgType.DataBind();
    //            ddlGenchrgType.Items.Insert(0, new ListItem("--Select Service Type--", "0"));

    //        }
    //        else
    //        {
    //            ddlGenchrgType.DataSource = null;
    //            ddlGenchrgType.DataBind();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}

    //private void BindGenCreditCardType()
    //{
    //    try
    //    {
    //        DataSet ds = new DataSet();
    //        ds = _doUtilities.BindCreditCardType();

    //        if (ds.Tables[0].Rows.Count > 0)
    //        {
    //            ddlCrdCardType.DataSource = ds.Tables[0];
    //            ddlCrdCardType.DataTextField = "CardDescription";
    //            ddlCrdCardType.DataValueField = "CrdCardId";
    //            ddlCrdCardType.DataBind();
    //            ddlCrdCardType.Items.Insert(0, new ListItem("--Select CreditCard --", "0"));
    //        }
    //        else
    //        {
    //            ddlCrdCardType.DataSource = null;
    //            ddlCrdCardType.DataBind();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}

    //private void BindGenTicketNumber()
    //{
    //    try
    //    {
    //        DataSet ds = new DataSet();
    //        string tempuniqcode = Session["TempUniqCode"].ToString();

    //        ds = _objDalService.BindTicketNumber(tempuniqcode);

    //        if (ds.Tables[0].Rows.Count > 0)
    //        {

    //            ddlPassengerName.DataSource = ds.Tables[0];
    //            ddlPassengerName.DataTextField = "TktNumber";
    //            ddlPassengerName.DataValueField = "TktIdId";
    //            ddlPassengerName.DataBind();
    //            ddlPassengerName.Items.Insert(0, new ListItem("--Select TicketNumber--", "0"));


    //        }
    //        else
    //        {
    //            ddlPassengerName.DataSource = null;
    //            ddlPassengerName.DataBind();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}

    //protected void ddlGenchrgType_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        string ddlText = ddlGenchrgType.SelectedItem.Text;
    //        int ddlValue = Convert.ToInt32(ddlGenchrgType.SelectedItem.Value);
    //        txtDetails.Text = ddlText;
    //        var VatPer = _objDalService.getVatPercentage(ddlValue, ddlText);
    //        if (VatPer != "" && VatPer != null)
    //        {
    //            txtgenvat.Text = VatPer.ToString();
    //        }
    //        if (txtUnits.Text != "")

    //            txtRateNet_TextChanged(null, null);
    //        GenPopupExtender.Show();
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}
    //protected void txtRateNet_TextChanged(object sender, EventArgs e)
    //{

    //    try
    //    {
    //        decimal units = Convert.ToDecimal(txtUnits.Text);
    //        txtRateNet.Text = _objBOUtiltiy.FormatTwoDecimal(txtRateNet.Text);
    //        decimal RateNet = Convert.ToDecimal(txtRateNet.Text);
    //        decimal ExclTotal = (units) * (RateNet);
    //        txtExcluAmount.Text = ExclTotal.ToString();
    //        if (txtgenvat.Text == "" || txtgenvat.Text == "0")
    //        {
    //            txtClientTotal.Text = ExclTotal.ToString();

    //        }
    //        else
    //        {

    //            txtExcluAmount.Text = _objBOUtiltiy.FormatTwoDecimal(ExclTotal.ToString());
    //            decimal Vatper = Convert.ToDecimal(txtgenvat.Text);
    //            decimal vatAmount = ((Vatper / 100) * ExclTotal);
    //            txtVatAmount.Text = _objBOUtiltiy.FormatTwoDecimal(vatAmount.ToString());
    //            decimal clientTotal = ExclTotal + vatAmount;
    //            txtClientTotal.Text = _objBOUtiltiy.FormatTwoDecimal(clientTotal.ToString());
    //        }
    //        GenPopupExtender.Show();
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}
    //protected void btnGencharge_click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        InsertGeneralCharge();
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        VASPopupExtender.Hide();
        AirticketClear();
        btnAirSubmit.Text = "Submit";
    }
    //protected void txtUnits_TextChanged(object sender, EventArgs e)
    //{
    //    try
    //    {

    //        txtRateNet.Enabled = true;
    //        if (txtRateNet.Text != "")

    //            txtRateNet_TextChanged(null, null);

    //        GenPopupExtender.Show();
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}

    //------------Service Fee--------//


    protected void ServFee_click(object sender, EventArgs e)
    {
        try
        {
            InsertUpdateServiceFee();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }

    protected void btnSerCancel_Click(object sender, EventArgs e)
    {
        SerSubmit.Text = "Submit";
        SerPopupExtender.Hide();
        ServiceFeeClear();
    }
    private void InsertUpdateServiceFee()
    {
        try
        {

            //hf_SF_TicketNo
            _objEmService.ServiceFeeId = Convert.ToInt32(hf_SF_TicketNo.Value);
            DateTime date = DateTime.ParseExact(txtSerTravelDate.Text, "yyyy-MM-dd", null);

            _objEmService.Type = Convert.ToInt32(ddlServiceType.SelectedValue.ToString());
            _objEmService.SourceRef = ddlSoureceref.SelectedValue.ToString();

            if (chkMerge.Checked)
                _objEmService.MergeC = Convert.ToInt32(chkMerge.Checked);

            decimal mergeAmt = 0;

            if (chkMerge.Checked == true)
            {
                var mergeAmount = _objDalService.GetSFMergeAmount(Convert.ToInt32(ddlSoureceref.SelectedValue.ToString()), Convert.ToInt32(chkMerge.Checked));

                mergeAmt = (Convert.ToDecimal(string.IsNullOrEmpty(mergeAmount.ToString().Trim()) ? "0" : mergeAmount.ToString().Trim())) + Convert.ToDecimal(txtSerClientTotal.Text);
            }

            _objAirTicket.AirTravelDate = string.IsNullOrEmpty(txtAirTravelDate.Text) ? (DateTime?)null : Convert.ToDateTime(txtAirTravelDate.Text);

            // _objEmService.TravelDate = System.DateTime.Now;
            _objEmService.TravelDate = date;
            _objEmService.PassengerName = Convert.ToInt32(string.IsNullOrEmpty(ddlPassengerName.SelectedValue.ToString()) ? "0" : ddlPassengerName.SelectedValue.ToString().Trim());
            string Exclusu = string.IsNullOrEmpty(txtExclusAmount.Text.Trim()) ? ".0000" : txtExclusAmount.Text.Trim();
            _objEmService.ExcluAmount = Convert.ToDecimal(Exclusu);
            _objEmService.Details = txtserDetails.Text;
            string Vartxt = string.IsNullOrEmpty(txtSerVatPer.Text.Trim()) ? "0" : txtSerVatPer.Text.Trim();
            _objEmService.VatPer = Convert.ToDecimal(Vartxt);
            _objEmService.VatAmount = Convert.ToDecimal(txtSerVatAmount.Text);
            _objEmService.PaymentMethod = Convert.ToInt32(ddlPaymentMethod.SelectedValue.ToString());
            string clientTotal = string.IsNullOrEmpty(txtSerClientTotal.Text.Trim()) ? ".0000" : txtSerClientTotal.Text.Trim();
            _objEmService.ClientTot = Convert.ToDecimal(clientTotal);
            _objEmService.CreditCardType = Convert.ToInt32(string.IsNullOrEmpty(ddlCreditCardType.SelectedValue.ToString().Trim()) ? "0" : ddlCreditCardType.SelectedValue.ToString().Trim());
            _objEmService.CollectVia = Convert.ToInt32(string.IsNullOrEmpty(ddlCollectVia.SelectedValue.ToString().Trim()) ? "0" : ddlCollectVia.SelectedValue.ToString().Trim());

            _objEmService.TasfMpd = txtTASFMPD.Text;
            _objEmService.CreatedBy = 0;
            _objEmService.InvoiceType = "SF";
            _objEmService.invDocumentNo = "0";
            _objEmService.IsCreditNote = 1;
            if (Session["TempUniqCode"] == null || Session["TempUniqCode"] == "")
            {
                _objEmService.SerTempUniqCode = uniqueIdSession();
            }
            else
            {
                _objEmService.SerTempUniqCode = Session["TempUniqCode"].ToString();
            }

            int Result = _objDalService.InsertUpdateSerfee(_objEmService, mergeAmt);

            if (Result > 0)
            {
                if (Session["TempUniqCode"] == null || Session["TempUniqCode"] == "")
                {
                    Session["TempUniqCode"] = _objEmService.SerTempUniqCode;
                }

                lblMsg.Text = _objBOUtiltiy.ShowMessage("success", "Success", "ServiceFee created Successfully");
                BindInvoiceLineItems();
              
                ServiceFeeClear();

            }
            else
            {
                lblMsg.Text = _objBOUtiltiy.ShowMessage("info", "Info", "ServiceFee Details was not created plase try again");
            }
            SerPopupExtender.Hide();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }


    private void BindSerServiceTypes()
    {
        try
        {
            string Type = "SF";
            DataSet ds = new DataSet();
            ds = _doUtilities.GetServiceTypeByType(Type);

            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlServiceType.DataSource = ds.Tables[0];
                ddlServiceType.DataTextField = "ComDesc";
                ddlServiceType.DataValueField = "ComId";
                ddlServiceType.DataBind();
                ddlServiceType.Items.Insert(0, new ListItem("--Select Type--", "0"));
            }
            else
            {
                ddlServiceType.DataSource = null;
                ddlServiceType.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }

    public void BindPaymentType()
    {
        try
        {
            DataSet ds = new DataSet();
            int paymentId = 0;
            ds = _doUtilities.BindPaymentType(paymentId);

            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlPaymentMethod.DataSource = ds.Tables[0];
                ddlPaymentMethod.DataTextField = "PaymentName";
                ddlPaymentMethod.DataValueField = "PaymentId";
                ddlPaymentMethod.DataBind();
                ddlPaymentMethod.Items.Insert(0, new ListItem("--Select--", "0"));

                ddlAirPayment.DataSource = ds.Tables[0];
                ddlAirPayment.DataTextField = "PaymentName";
                ddlAirPayment.DataValueField = "PaymentId";
                ddlAirPayment.DataBind();
                ddlAirPayment.Items.Insert(0, new ListItem("--Select Payment--", "0"));


            }
            else
            {
                ddlPaymentMethod.DataSource = null;
                ddlPaymentMethod.DataBind();
                ddlAirPayment.DataSource = null;
                ddlAirPayment.DataBind();
                ddlPaymentMethod.Items.Insert(0, new ListItem("Select Payment", "0"));
                ddlAirPayment.Items.Insert(0, new ListItem("Select Payment", "0"));

            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }


    private void BindSerCreditCardType()
    {
        try
        {
            DataSet ds = new DataSet();
            ds = _doUtilities.BindCreditCardType();

            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlCreditCardType.DataSource = ds.Tables[0];
                ddlCreditCardType.DataTextField = "CardDescription";
                ddlCreditCardType.DataValueField = "CrdCardId";
                ddlCreditCardType.DataBind();
                ddlCreditCardType.Items.Insert(0, new ListItem("--Select--", "0"));

            }
            else
            {
                ddlCreditCardType.DataSource = null;
                ddlCreditCardType.DataBind();
                ddlCreditCardType.Items.Insert(0, new ListItem("--Select--", "0"));
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    private void BindSerTicketNumber()
    {
        try
        {
            DataSet ds = new DataSet();

            string tempuniqcode = Session["TempUniqCode"].ToString();
            ds = _objDalService.BindTicketNumber(tempuniqcode);

            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlSoureceref.DataSource = ds.Tables[0];
                ddlSoureceref.DataTextField = "AirTicketNo";
                ddlSoureceref.DataValueField = "TicketId";
                ddlSoureceref.DataBind();
                ddlSoureceref.Items.Insert(0, new ListItem("--Select Ticket No--", "0"));
            }

            if (ds.Tables[1].Rows.Count > 0)
            {
                ddlACMTicketNO.DataSource = ds.Tables[1];
                ddlACMTicketNO.DataTextField = "AirTicketNo";
                ddlACMTicketNO.DataValueField = "TicketId";
                ddlACMTicketNO.DataBind();
                ddlACMTicketNO.Items.Insert(0, new ListItem("--Select Ticket No--", "0"));


                ddlTicketno.DataSource = ds.Tables[1];
                ddlTicketno.DataTextField = "AirTicketNo";
                ddlTicketno.DataValueField = "TicketId";
                ddlTicketno.DataBind();
                ddlTicketno.Items.Insert(0, new ListItem("--Select Ticket No--", "0"));

            }

            else
            {
                ddlSoureceref.DataSource = null;
                ddlSoureceref.DataBind();
                ddlACMTicketNO.DataSource = null;
                ddlACMTicketNO.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    private void BindSerPassengerNames()
    {
        try
        {
            DataSet ds = new DataSet();
            int airtickno = Convert.ToInt32(ddlSoureceref.SelectedItem.Value.ToString());
            string tempuniqcode = " ";
            ds = _objBalservice.BindPassengerNames(tempuniqcode, airtickno);

            if (ds.Tables[1].Rows.Count > 0)
            {
                ddlPassengerName.DataSource = ds.Tables[1];
                ddlPassengerName.DataTextField = "AirPassenger";
                ddlPassengerName.DataValueField = "TicketId";
                ddlPassengerName.DataBind();

            }
            else
            {
                ddlPassengerName.DataSource = null;
                ddlPassengerName.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    private void BindCollectVia()
    {
        try
        {
            DataSet ds = new DataSet();
            ds = _objDalService.BindCollectVia();

            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlCollectVia.DataSource = ds.Tables[0];
                ddlCollectVia.DataTextField = "CollectName";
                ddlCollectVia.DataValueField = "ColletViaId";
                ddlCollectVia.DataBind();
                ddlCollectVia.Items.Insert(0, new ListItem("--Select Collect Via--", "0"));
            }
            else
            {
                ddlCollectVia.DataSource = null;
                ddlCollectVia.DataBind();
                ddlCollectVia.Items.Insert(0, new ListItem("--Select Collect Via-", "0"));
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }


    protected void ddlPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlPaymentMethod.SelectedValue == "2")
            {
                BindCollectVia();

                BindSerCreditCardType();

                ddlCreditCardType.Enabled = true;
                ddlCollectVia.Enabled = true;
                txtTASFMPD.Enabled = false;

                rfvddlCollectVia.Enabled = true;
                rfvddlCreditCardType.Enabled = true;
                rfvtxtTASFMPD.Enabled = false;
            }
            else
            {
                ddlCreditCardType.Items.Clear();
                ddlCollectVia.Items.Clear();
                txtTASFMPD.Text = "";
                ddlCreditCardType.Enabled = false;
                ddlCollectVia.Enabled = false;
                txtTASFMPD.Enabled = false;

                rfvddlCollectVia.Enabled = false;
                rfvddlCreditCardType.Enabled = false;
                rfvtxtTASFMPD.Enabled = false;
            }
            SerPopupExtender.Show();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void ddlCollectVia_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (ddlCollectVia.SelectedItem.ToString() != "General")
            {
                txtTASFMPD.Enabled = true;
                rfvtxtTASFMPD.Enabled = true;
            }
            else
            {
                txtTASFMPD.Enabled = false;
                rfvtxtTASFMPD.Enabled = false;
            }

            SerPopupExtender.Show();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void ddlServiceType_SelectedIndexChanged(object sender, EventArgs e)
    {

        //try
        //{
        //    txtserDetails.Text = ddlServiceType.SelectedItem.Text;
        //    var VatPer = _objDalService.getVatPercentage(Convert.ToInt32(ddlServiceType.SelectedItem.Value), txtserDetails.Text);


        //    if (VatPer != null)
        //    {
        //        txtSerVatPer.Text = VatPer.ToString();
        //    }
        //    else
        //    {
        //        txtSerVatPer.Text = "0.00";
        //        txtSerVatAmount.Text = "0.00";
        //        //txtDetails.Text = "";
        //        txtExclusAmount.Text = txtSerClientTotal.Text;

        //    }

        //    if (txtSerClientTotal.Text != "")
        //    {

        //        getClientTotal();
        //    }
        //    SerPopupExtender.Show();
        //}
        //catch (Exception ex)
        //{
        //    lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
        //    ExceptionLogging.SendExcepToDB(ex);
        //}
    }
    //protected void txtExclusAmount_TextChanged(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        txtExclusAmount.Text = _objBOUtiltiy.FormatTwoDecimal(txtExclusAmount.Text.ToString());

    //        getClientTotal();
    //        SerPopupExtender.Show();
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}

    protected void getClientTotal()
    {
        try
        {
            ExclusiveAmount = Convert.ToDecimal(txtExclusAmount.Text);

            // txtSerClientTotal.Text = txtExclusAmount.Text;

            if (txtSerVatPer.Text == "")
            {
                //txtClientTotal.Text = ExclusiveAmount.ToString();
            }
            else
            {
                ExcusiveAmount();
                //decimal Vatper = Convert.ToDecimal(txtSerVatPer.Text);
                //decimal vatAmount = ((Vatper / 100) * ExclusiveAmount);
                ////decimal clientTotal = ExclusiveAmount + vatAmount;
                //decimal clientTotal = ExclusiveAmount;
                //txtSerVatAmount.Text = _objBOUtiltiy.FormatTwoDecimal(vatAmount.ToString());
                //txtSerClientTotal.Text = _objBOUtiltiy.FormatTwoDecimal(clientTotal.ToString());
                SerPopupExtender.Show();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    //land methods
    protected void DDType_SelectedIndexChanged(object sender, EventArgs e)
    {
        //try
        //{
        //    txtLandExlVatPer.Text = _doUtilities.getVatByType(DDlandType.SelectedIndex).ToString();


        //    txtLandVatPer.Text = _doUtilities.getVatByType(DDlandType.SelectedIndex).ToString();
        //    if (txtLandVatPer.Text != "0.00")
        //    {
        //        txtlandExclVatAmount.Text = ((Convert.ToDecimal(txtlandTotalExcl.Text) * Convert.ToDecimal(txtLandVatPer.Text)) / 100).ToString();
        //        txtlandTotalIncl.Text = (Convert.ToDecimal(txtlandExclVatAmount.Text) + Convert.ToDecimal(txtlandTotalExcl.Text)).ToString();

        //        if (txtlandCommPer.Text != "")
        //        {
        //            txtlandTotalExcl_TextChanged(null, null);
        //            txtlandCommPer_TextChanged(null, null);
        //        }


        //    }
        //    else
        //    {
        //        txtlandTotalIncl.Text = txtlandTotalExcl.Text;

        //    }
        //    txtlandTotalIncl.Text = _objBOUtiltiy.FormatTwoDecimal(txtlandTotalIncl.Text);
        //    txtlandDuefromclient.Text = txtlandTotalIncl.Text;
        //}
        //catch (Exception ex)
        //{

        //    lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
        //    ExceptionLogging.SendExcepToDB(ex);
        //}
        //landPopExtender.Show();

    }

    private void LandPaymentMethod()
    {
        try
        {
            DDlandCreditCard.DataSource = _doUtilities.BindCreditCardType();
            DDlandCreditCard.DataTextField = "CardDescription";
            DDlandCreditCard.DataValueField = "CrdCardId";
            DDlandCreditCard.DataBind();
            DDlandCreditCard.Items.Insert(0, new ListItem("--Select Card--", "0"));



            var payment = Convert.ToDecimal(DDlandPayment.SelectedItem.Value);

            if (payment == 2)
            {
                DDlandCreditCard.Enabled = true;
            }
            else
            {
                DDlandCreditCard.Enabled = false;
            }
            landPopExtender.Show();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    // Payment Menthod Select Payment Bind Credit card
    protected void DDlandPayment_SelectedIndexChanged(object sender, EventArgs e)
    {

        LandPaymentMethod();
    }
    protected void DDlandService_SelectedIndexChanged(object sender, EventArgs e)
    {
        int commId = Convert.ToInt32(DDlandService.SelectedItem.Value);
        DataSet ds = _objBOUtiltiy.GetCommissionPerc(commId);

        decimal commperc = string.IsNullOrEmpty(ds.Tables[0].Rows[0]["ComDComm"].ToString()) ? 0 : Convert.ToDecimal(ds.Tables[0].Rows[0]["ComDComm"].ToString());

        txtlandCommPer.Text = _objBOUtiltiy.FormatTwoDecimal(commperc.ToString());

        landPopExtender.Show();
    }

    protected void LandArrSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            // hf_Land_TicketNo
            objEMLandarrangement.LandArrId = 0;
            if (LandArrSubmit.Text == "Update")
            {
                objEMLandarrangement.LandArrId = Convert.ToInt32(hf_Land_TicketNo.Value);
            }

            objEMLandarrangement.LandSupplier = Convert.ToInt32(DDlandSupplier.SelectedValue);
            objEMLandarrangement.Services = Convert.ToInt32(DDlandService.SelectedValue);
            objEMLandarrangement.Type = Convert.ToInt32(DDlandType.SelectedValue);
            objEMLandarrangement.PassengerName = txtlandPassName.Text.Trim();
            objEMLandarrangement.TravelFrDate = string.IsNullOrEmpty(txtlandTravelFrom.Text) ? (DateTime?)null : Convert.ToDateTime(txtlandTravelFrom.Text);
            objEMLandarrangement.TravelToDate = string.IsNullOrEmpty(txtlandTravelto.Text) ? (DateTime?)null : Convert.ToDateTime(txtlandTravelto.Text);


            objEMLandarrangement.BookRefNo = txtlandBookingRef.Text.Trim();
            objEMLandarrangement.Voucher = txtlandVocher.Text.Trim();
            objEMLandarrangement.SuppRef = txtlandSupplierRef.Text.Trim();
            objEMLandarrangement.SuppInvNo = txtlandSuppInvNo.Text.Trim();
            string Units = string.IsNullOrEmpty(txtlandUnits.Text.Trim()) ? "0" : txtlandUnits.Text.Trim();
            objEMLandarrangement.Units = Convert.ToInt32(Units);
            string CommabExclu = string.IsNullOrEmpty(txtlandUnits.Text.Trim()) ? "0" : txtlandUnits.Text.Trim();
            objEMLandarrangement.CommabExclu = Convert.ToDecimal(CommabExclu);
            string TotIncl = string.IsNullOrEmpty(txtlandTotalIncl.Text.Trim()) ? "0" : txtlandTotalIncl.Text.Trim();
            objEMLandarrangement.TotIncl = Convert.ToDecimal(TotIncl);
            string RateInclu = string.IsNullOrEmpty(txtlandRateIncl.Text.Trim()) ? "0" : txtlandRateIncl.Text.Trim();
            objEMLandarrangement.RateInclu = Convert.ToDecimal(RateInclu);
            string CommPer = string.IsNullOrEmpty(txtlandCommPer.Text.Trim()) ? "0" : txtlandCommPer.Text.Trim();
            objEMLandarrangement.CommPer = Convert.ToDecimal(CommPer);
            //   string CommPer = string.IsNullOrEmpty(txtlandCommPer.Text.Trim()) ? "0" : txtlandCommPer.Text.Trim();
            objEMLandarrangement.ExclVatPer = string.IsNullOrEmpty(txtLandExlVatPer.Text) ? 0 : Convert.ToDecimal(txtLandExlVatPer.Text);
            string ExclusiveVatAmount = string.IsNullOrEmpty(txtlandExclVatAmount.Text.Trim()) ? "0" : txtlandExclVatAmount.Text.Trim();
            objEMLandarrangement.ExclusiveVatAmount = Convert.ToDecimal(ExclusiveVatAmount);
            string CommissionableInclu = string.IsNullOrEmpty(txtlandCmblIncl.Text.Trim()) ? "0" : txtlandCmblIncl.Text.Trim();
            objEMLandarrangement.CommissionableInclu = Convert.ToDecimal(CommissionableInclu);
            string CommissionExclu = string.IsNullOrEmpty(txtlandCommExcl.Text.Trim()) ? "0" : txtlandCommExcl.Text.Trim();
            objEMLandarrangement.CommissionExclu = Convert.ToDecimal(CommissionExclu);
            string TotExclu = string.IsNullOrEmpty(txtlandTotalExcl.Text.Trim()) ? "0" : txtlandTotalExcl.Text.Trim();
            objEMLandarrangement.TotExclu = Convert.ToDecimal(TotExclu);
            string OthCommabInclu = string.IsNullOrEmpty(txtlandOtherCmblIncl.Text.Trim()) ? "0" : txtlandOtherCmblIncl.Text.Trim();
            objEMLandarrangement.OthCommabInclu = Convert.ToDecimal(OthCommabInclu);
            objEMLandarrangement.VatPer = string.IsNullOrEmpty(txtLandVatPer.Text.Trim()) ? 0 : Convert.ToDecimal(txtLandVatPer.Text);
            objEMLandarrangement.Payment = Convert.ToInt32(DDlandPayment.SelectedIndex);
            string TotCommabInclu = string.IsNullOrEmpty(txtlandTotalcmblIncl.Text.Trim()) ? "0" : txtlandTotalcmblIncl.Text.Trim();
            objEMLandarrangement.TotCommabInclu = Convert.ToDecimal(TotCommabInclu);
            string CommVatAmount = string.IsNullOrEmpty(txtlandVatAmount.Text.Trim()) ? "0" : txtlandVatAmount.Text.Trim();
            objEMLandarrangement.CommVatAmount = Convert.ToDecimal(CommVatAmount);
            objEMLandarrangement.CreditCard = Convert.ToInt32(DDlandCreditCard.SelectedIndex);
            string NonCommabInclu = string.IsNullOrEmpty(txtlandNoncmbl.Text.Trim()) ? "0" : txtlandNoncmbl.Text.Trim();
            objEMLandarrangement.NonCommabInclu = Convert.ToDecimal(NonCommabInclu);
            string CommissionInclu = string.IsNullOrEmpty(txtlandCommIncl.Text.Trim()) ? "0" : txtlandCommIncl.Text.Trim();
            objEMLandarrangement.CommissionInclu = Convert.ToDecimal(CommissionInclu);
            string DueToClient = string.IsNullOrEmpty(txtlandDuefromclient.Text.Trim()) ? "0" : txtlandDuefromclient.Text.Trim();
            objEMLandarrangement.DueToClient = Convert.ToDecimal(DueToClient);

            string LessCommission = string.IsNullOrEmpty(txtlandLessComm.Text.Trim()) ? "0" : txtlandLessComm.Text.Trim();
            objEMLandarrangement.LessCommission = Convert.ToDecimal(LessCommission);

            string DueTOSupplier = string.IsNullOrEmpty(txtlandDuetoSupplier.Text.Trim()) ? "0" : txtlandDuetoSupplier.Text.Trim();
            objEMLandarrangement.DueTOSupplier = Convert.ToDecimal(DueTOSupplier);
            if (Convert.ToDecimal(txtlandCommPer.Text) == 0 || txtlandCommPer.Text == " ")
            {
                objEMLandarrangement.DueTOSupplier = Convert.ToDecimal(DueToClient);
            }

            objEMLandarrangement.SupplOpenAmount = Convert.ToDecimal(DueTOSupplier);

            objEMLandarrangement.InvoiceType = "Land";
            objEMLandarrangement.invDocumentNo = "0";

            string CO2Emis = string.IsNullOrEmpty(txtlandCO2.Text.Trim()) ? "0" : txtlandCO2.Text.Trim();
            objEMLandarrangement.CO2Emis = Convert.ToDecimal(CO2Emis);
            objEMLandarrangement.IsCreditNote = 1;

            if (Session["TempUniqCode"] == null || Session["TempUniqCode"] == "")
            {
                objEMLandarrangement.LandTempUniqCode = uniqueIdSession();
            }
            else
            {
                objEMLandarrangement.LandTempUniqCode = Session["TempUniqCode"].ToString();
            }

            int Result = objDALandarrangement.InsertLandArrangement(objEMLandarrangement);

            if (Result > 0)
            {
                if (Session["TempUniqCode"] == null || Session["TempUniqCode"] == "")
                {
                    Session["TempUniqCode"] = objEMLandarrangement.LandTempUniqCode;
                }
                lblMsg.Text = _objBOUtiltiy.ShowMessage("success", "Success", "LandSupplier created Successfully");
                BindInvoiceLineItems();
           
                LandArrangemntsClear();
            }
            else
            {
                lblMsg.Text = _objBOUtiltiy.ShowMessage("info", "Info", "LandSupplier Details was not created plase try again");
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
        landPopExtender.Hide();
    }

    protected void Cancel_Click(object sender, EventArgs e)
    {
        LandArrSubmit.Text = "Submit";
        landPopExtender.Hide();
        LandArrangemntsClear();
    }
    protected void Reset_Click(object sender, EventArgs e)
    {

    }




    // Bind Land Supplier Name
    public void BindLandSuppliers()
    {
        try
        {
            BALandSuppliers objBalandSuppliers = new BALandSuppliers();
            int landSupId = 0;
            DataSet datasetland = new DataSet();
            datasetland = objBalandSuppliers.GetLandSupplier(landSupId);
            if (datasetland.Tables[0].Rows.Count > 0)
            {
                DDlandSupplier.DataSource = datasetland.Tables[0];
                DDlandSupplier.DataTextField = "LSupplierName";
                DDlandSupplier.DataValueField = "LSupplierId";
                DDlandSupplier.DataBind();
                DDlandSupplier.Items.Insert(0, new ListItem("--Select Supplier--", "0"));
            }
            else
            {
                DDlandSupplier.DataSource = null;
                DDlandSupplier.DataBind();
                DDlandSupplier.Items.Insert(0, new ListItem("--Select Supplier--", "0"));
            }
        }
        catch (Exception ex)
        {

            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }


    }

    protected void DDlandSupplier_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DDlandService.Items.Clear();
            DataSet ds = new DataSet();

            int supplierid = Convert.ToInt32(DDlandSupplier.SelectedValue.ToString());
            BALandSuppliers objBalandSuppliers = new BALandSuppliers();
            ds = objBalandSuppliers.GetLandSupplier(supplierid);



            if (ds.Tables[2].Rows.Count > 0)
            {

                DDlandService.DataSource = ds.Tables[2];
                int ComId = Convert.ToInt32(ds.Tables[2].Rows[0]["ComId"].ToString());

                DDlandService.SelectedValue = ComId.ToString();
                DDlandService.DataBind();
                landPopExtender.Show();
            }
            else
            {
                landPopExtender.Show();
                BindAirServiceTypes();
                DDlandService.DataSource = null;
                DDlandService.DataBind();
            }

            int commId = Convert.ToInt32(DDlandService.SelectedItem.Value);
            DataSet commds = _objBOUtiltiy.GetCommissionPerc(commId);

            decimal commperc = string.IsNullOrEmpty(commds.Tables[0].Rows[0]["ComDComm"].ToString()) ? 0 : Convert.ToDecimal(commds.Tables[0].Rows[0]["ComDComm"].ToString());

            txtlandCommPer.Text = _objBOUtiltiy.FormatTwoDecimal(commperc.ToString());
        }


        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    public void BindType()
    {
        try
        {

            DataSet ds = new DataSet();
            ds = _doUtilities.get_Type();

            if (ds.Tables[0].Rows.Count > 0)
            {

                DDlandType.DataSource = ds.Tables[0];
                DDlandType.DataTextField = "TypeName";
                DDlandType.DataValueField = "TypeId";
                DDlandType.DataBind();
                DDlandType.Items.Insert(0, new ListItem("--Select Type--", "0"));
            }
            else
            {
                DDlandType.DataSource = null;
                DDlandType.DataBind();
            }
        }
        catch (Exception ex)
        {

            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }


    }

    public void BindLandService()
    {
        try
        {
            string Type = "Land";
            DDlandService.DataSource = _doUtilities.GetServiceTypeByType(Type);
            DDlandService.DataTextField = "ComDesc";
            DDlandService.DataValueField = "ComId";
            DDlandService.DataBind();
            DDlandService.Items.Insert(0, new ListItem("--Select Service--", "0"));
        }
        catch (Exception ex)
        {

            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }


    }
    public void BindLandPaymentType()
    {
        try
        {
            DataSet ds = new DataSet();
            int payemntId = 0;
            ds = _doUtilities.BindPaymentType(payemntId);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DDlandPayment.DataSource = ds.Tables[0];
                DDlandPayment.DataTextField = "PaymentName";
                DDlandPayment.DataValueField = "PaymentId";
                DDlandPayment.DataBind();
                DDlandPayment.Items.Insert(0, new ListItem("--Select Payment--", "0"));
            }
            else
            {
                DDlandPayment.DataSource = null;
                DDlandPayment.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }


    protected void txtlandTotalIncl_TextChanged(object sender, EventArgs e)
    {


    }
    protected void txtlandTotalExcl_TextChanged(object sender, EventArgs e)
    {

        try
        {
            txtlandTotalExcl.Text = _objBOUtiltiy.FormatTwoDecimal(txtlandTotalExcl.Text);
            txtlandTotalIncl.Text = _objBOUtiltiy.ExcluAssignInclu(txtlandTotalExcl.Text);
            txtlandExclVatAmount.Text = _objBOUtiltiy.ExcluvatCau(txtlandTotalExcl.Text, txtLandExlVatPer.Text);
            txtlandcmblExcl.Text = txtlandTotalExcl.Text;
            if (txtlandTotalExcl.Text != "" && txtlandExclVatAmount.Text != "")
            {
                txtlandTotalIncl.Text = _objBOUtiltiy.FormatTwoDecimal((Convert.ToDecimal(txtlandTotalExcl.Text) + Convert.ToDecimal(txtlandExclVatAmount.Text)).ToString());

            }
            if (txtlandCommPer.Text != "")
            {
                txtlandCommPer_TextChanged(null, null);
            }
            landPopExtender.Show();

            txtlandDuefromclient.Text = txtlandTotalIncl.Text;

            if (Convert.ToDecimal(txtlandCommPer.Text) == 0)
            {
                txtlandDuetoSupplier.Text = txtlandTotalIncl.Text;
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void txtlandRateIncl_TextChanged(object sender, EventArgs e)
    {
        try
        {
            txtlandRateIncl.Text = _objBOUtiltiy.FormatTwoDecimal(txtlandRateIncl.Text);
            if (txtlandUnits.Text != "" && txtlandRateIncl.Text != "")
            {
                txtlandCmblIncl.Text = _objBOUtiltiy.FormatTwoDecimal((Convert.ToDecimal(txtlandUnits.Text) * Convert.ToDecimal(txtlandRateIncl.Text)).ToString());

                txtlandTotalcmblIncl.Text = txtlandCmblIncl.Text;
            }
            landPopExtender.Show();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void txtlandUnits_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (txtlandUnits.Text != "" && txtlandRateIncl.Text != "")
            {
                txtlandCmblIncl.Text = _objBOUtiltiy.FormatTwoDecimal((Convert.ToDecimal(txtlandUnits.Text) * Convert.ToDecimal(txtlandRateIncl.Text)).ToString());

                txtlandTotalcmblIncl.Text = txtlandCmblIncl.Text;
            }
            landPopExtender.Show();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void txtlandOtherCmblIncl_TextChanged(object sender, EventArgs e)
    {
        try
        {

            if (txtlandCmblIncl.Text != "" && txtlandOtherCmblIncl.Text != "")
            {
                txtlandTotalcmblIncl.Text = _objBOUtiltiy.FormatTwoDecimal((Convert.ToDecimal(txtlandCmblIncl.Text) + Convert.ToDecimal(txtlandOtherCmblIncl.Text)).ToString());

            }
            landPopExtender.Show();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void txtlandcmblExcl_TextChanged(object sender, EventArgs e)
    {
        try
        {
            landPopExtender.Show();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void txtlandCommPer_TextChanged(object sender, EventArgs e)
    {
        try
        {
            if (txtlandcmblExcl.Text != "" && txtlandCommPer.Text != "")
            {
                txtlandCommExcl.Text = _objBOUtiltiy.FormatTwoDecimal(_objBOUtiltiy.ExcluvatCau(txtlandcmblExcl.Text, txtlandCommPer.Text));
            }
            if (txtlandCommExcl.Text != "")
            {
                txtlandVatAmount.Text = _objBOUtiltiy.FormatTwoDecimal(_objBOUtiltiy.ExcluvatCau(txtlandCommExcl.Text, txtLandVatPer.Text));

            }
            else
            {

            }
            if (txtlandCommExcl.Text != "" && txtlandVatAmount.Text != "")
            {
                txtlandCommIncl.Text = _objBOUtiltiy.FormatTwoDecimal(_objBOUtiltiy.InclusiveAmount(txtlandCommExcl.Text, txtlandVatAmount.Text).ToString());
            }
            txtlandLessComm.Text = txtlandCommIncl.Text;
            txtlandDuetoSupplier.Text = (Convert.ToDecimal(txtlandDuefromclient.Text) - Convert.ToDecimal(txtlandLessComm.Text)).ToString();
            landPopExtender.Show();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    protected void InvListGrid_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
    }
    //protected void InvListGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    //{
    //    try
    //    {
    //        InvListGrid.PageIndex = e.NewPageIndex;
    //        BindInvoiceLineItems();
    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}
    //invoice Line items
    private void BindInvoiceLineItems()
    {
        try
        {

            string tempUniqueCode = (string)Session["TempUniqCode"] == "" ? "0" : Session["TempUniqCode"].ToString();

            DataSet ds = _objBalInvoice.getInvoiceLines(tempUniqueCode);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                InvListGrid.DataSource = ds;
                InvListGrid.DataBind();
            }
            else
            {
                InvListGrid.DataSource = ds;
                InvListGrid.DataBind();
            }


        }
        catch(Exception ex)
        {
            lblMsg.Text = "";
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

  
    private void CleanForm()
    {
        try
        {
            foreach (var item in Page.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }


    //invoice Bind Methods
    private void BindInvoiceDropDown()
    {
        try
        {
            DataSet ds = new DataSet();
            int clientTypeId = 0;
            ds = _objBOUtiltiy.InvoiceDdlBinding(clientTypeId);

            if (ds.Tables[0].Rows.Count > 0)
            {

                ddlInvCosultant.DataSource = ds.Tables[0];
                ddlInvCosultant.DataTextField = "Name";
                ddlInvCosultant.DataValueField = "ConsultantId";
                ddlInvCosultant.DataBind();
                ddlInvCosultant.Items.Insert(0, new ListItem("--Select Consultant--", "0"));

                //ddlInvMesg.DataSource = ds.Tables[1];
                //ddlInvMesg.DataTextField = "NpName";
                //ddlInvMesg.DataValueField = "NotePadId";
                //ddlInvMesg.DataBind();
                //ddlInvMesg.Items.Insert(0, new ListItem("--Select Messages--", "0"));

                drpInvClientType.DataSource = ds.Tables[2];
                drpInvClientType.DataTextField = "Name";
                drpInvClientType.DataValueField = "Id";
                drpInvClientType.DataBind();
                drpInvClientType.Items.Insert(0, new ListItem("--Select Client Type--", "0"));

                drpInvBookingSrc.DataSource = ds.Tables[3];
                drpInvBookingSrc.DataTextField = "BookingName";
                drpInvBookingSrc.DataValueField = "BookingId";
                drpInvBookingSrc.DataBind();
                drpInvBookingSrc.Items.Insert(0, new ListItem("--Select Booking Source--", "0"));


                drpInvBookDest.DataSource = ds.Tables[4];
                drpInvBookDest.DataTextField = "BookDestName";
                drpInvBookDest.DataValueField = "BookDestId";
                drpInvBookDest.DataBind();
                drpInvBookDest.Items.Insert(0, new ListItem("--Select Booking Destination--", "0"));

            }
            else
            {

                ddlInvCosultant.DataSource = null;
                ddlInvCosultant.DataBind();


                drpInvClientType.DataSource = null;
                drpInvClientType.DataBind();

                drpInvBookingSrc.DataSource = null;
                drpInvBookingSrc.DataBind();

                drpInvBookDest.DataSource = null;
                drpInvBookDest.DataBind();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }
    private void BindClientNames()
    {
        try
        {
            drpInvClientName.Items.Clear();

            int clientTypeId = Convert.ToInt32(drpInvClientType.SelectedItem.Value.ToString());
            if (clientTypeId > 0)
            {
                DataSet ds = new DataSet();
                ds = _objBOUtiltiy.InvoiceDdlBinding(clientTypeId);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    drpInvClientName.DataSource = ds.Tables[0];
                    drpInvClientName.DataTextField = "ClientName";
                    drpInvClientName.DataValueField = "ClientId";
                    drpInvClientName.DataBind();
                    drpInvClientName.Items.Insert(0, new ListItem("--Select Client--", "0"));
                }
                else
                {
                    drpInvClientName.Items.Insert(0, new ListItem("--Select Client--", "0"));
                    drpInvClientName.DataSource = null;
                    drpInvClientName.DataBind();
                }
            }
            else
            {
                drpInvClientName.Items.Insert(0, new ListItem("--Select Client--", "0"));
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }

    protected void drpInvClientType_TextChanged(object sender, EventArgs e)
    {
        BindClientNames();
    }
    private void BindInvoiceMessage()
    {
        try
        {
            ddlInvMesg.Items.Clear();

            int clientId = Convert.ToInt32(drpInvClientName.SelectedItem.Value.ToString());
            if (clientId > 0)
            {
                DataSet ds = new DataSet();
                ds = _objBalInvoice.Get_ClientmessageandNote(clientId);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    ddlInvMesg.DataSource = ds.Tables[0];
                    ddlInvMesg.DataTextField = "NpName";
                    ddlInvMesg.DataValueField = "NotePadId";
                    ddlInvMesg.DataBind();

                    txtInvClntMesg.Text = ds.Tables[0].Rows[0]["ClientMessage"].ToString();


                }
                else
                {
                    ddlInvMesg.Items.Insert(0, new ListItem("--Select Message--", "0"));
                    ddlInvMesg.DataSource = null;
                    ddlInvMesg.DataBind();
                }
            }
            else
            {
                ddlInvMesg.Items.Insert(0, new ListItem("--Select Message--", "0"));
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void drpInvClientName_TextChanged(object sender, EventArgs e)
    {
        BindInvoiceMessage();
    }



    //private void BindInvoiceACAnalysis()
    //{

    //    try
    //    {
    //        int TempuniqID = Convert.ToInt32(Session["TempUniqCode"]);
    //        DataSet ds = _objBalInvoice.GetInvoiceACAnalasis(TempuniqID);
    //        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
    //        {
    //            ACAnalysisGrid.DataSource = ds;
    //            ACAnalysisGrid.DataBind();
    //        }

    //        else
    //        {
    //            ACAnalysisGrid.DataSource = null;
    //            ACAnalysisGrid.DataBind();
    //        }
    //    }

    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}
    //// AC Analysis
    //protected void btnSubmitACAnalsys_Click(object sender, EventArgs e)
    //{
    //    try
    //    {
    //        BindInvoiceACAnalysis();

    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }
    //}
    protected void txtAirportTax_TextChanged(object sender, EventArgs e)
    {
        try
        {
            txtAirportTax.Text = _objBOUtiltiy.FormatTwoDecimal(txtAirportTax.Text);
            decimal clientTotal = Convert.ToDecimal(txtAirportTax.Text) + Convert.ToDecimal(txtAirExcluisvefare.Text);
            if (txtAirVatOnFare.Text != "")
            {
                clientTotal = clientTotal + Convert.ToDecimal(txtAirVatOnFare.Text);
            }
            txtAirClientTot.Text = _objBOUtiltiy.FormatTwoDecimal(clientTotal.ToString());
            if (txtAirCommisionper.Text != "")
            {
                txtAirCommisionper_TextChanged(null, null);
            }
            // routingLablesShow();
            VASPopupExtender.Show();
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    protected void btnDraftPdf_Click(object sender, EventArgs e)
    {
        try
        {
            string Tempuniqcode = Session["TempUniqCode"].ToString();

            // Response.Redirect("DraftPdf.aspx?TempuniqCode=" + Tempuniqcode);
            string url = "DraftPdf.aspx?TempuniqCode=" + Tempuniqcode;
            string fullURL = "window.open('" + url + "', '_blank');";
            ScriptManager.RegisterStartupScript(this, typeof(string), "_blank", fullURL, true);
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    private void AirticketClear()
    {
        try
        {

            txtAirTicketNo.Text = "";
            drpTicketType.SelectedIndex = -1;
            txtPnr.Text = "";
            ddlAirLine.SelectedIndex = -1;
            drpAirPassenger.Text = "";
            txtAirConjunction.Text = "";
            ddlAirService.SelectedIndex = -1;
            ddlType.SelectedIndex = -1;
            txtAirRouting.Text = "";
            txtAirMiles.Text = "";
            txtAirTravelDate.Text = "";
            txtAirReturnDate.Text = "";
            txtAirExcluisvefare.Text = "";
            txtAirCommisionper.Text = "";
            txtVatPer.Text = "";
            txtAirVatOnFare.Text = "";
            txtAirCommExclu.Text = "";
            txtAirportTax.Text = "";
            txtAirCommVat.Text = "";
            txtAirVatinclTax.Text = "";
            txtAirAgentVat.Text = "";
            txtAirClientTot.Text = "";
            txtAirCommInclu.Text = "";
            ddlAirPayment.SelectedIndex = -1;
            txtAirDueToBsp.Text = "";
            ddlSoureceref.SelectedIndex = -1;
            lblRoutes1.Text = "";
            lblRoutes2.Text = "";
            lblRoutes3.Text = "";
            lblRoutes4.Text = "";
            txtFlightNo1.Text = "";
            txtClass1.Text = "";
            txtDate1.Text = "";
            txtFlightNo2.Text = "";
            txtClass2.Text = "";
            txtDate2.Text = "";
            txtFlightNo3.Text = "";
            txtClass3.Text = "";
            txtDate3.Text = "";
            txtFlightNo4.Text = "";
            txtClass4.Text = "";
            txtDate4.Text = "";
            txtFlightNo1.Enabled = false;
            txtFlightNo2.Enabled = false;
            txtFlightNo3.Enabled = false;
            txtFlightNo4.Enabled = false;
            txtClass1.Enabled = false;
            txtClass2.Enabled = false;
            txtClass3.Enabled = false;
            txtClass4.Enabled = false;

        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }


    }

    private void LandArrangemntsClear()
    {
        try
        {

            DDlandSupplier.SelectedIndex = -1;
            DDlandService.SelectedIndex = -1;
            DDlandType.SelectedIndex = -1;
            txtlandPassName.Text = "";
            txtlandTravelFrom.Text = "";
            txtlandTravelto.Text = "";
            txtlandBookingRef.Text = "";
            txtlandVocher.Text = "";
            txtlandSupplierRef.Text = "";
            txtlandSuppInvNo.Text = "";
            txtlandUnits.Text = "";
            txtlandcmblExcl.Text = "";
            txtlandTotalExcl.Text = "";
            txtlandRateIncl.Text = "";
            txtlandCommPer.Text = "";
            txtLandExlVatPer.Text = "";
            txtlandExclVatAmount.Text = "";
            txtlandCmblIncl.Text = "";
            txtlandCommExcl.Text = "";
            txtlandTotalIncl.Text = "";
            txtlandOtherCmblIncl.Text = "";
            txtLandVatPer.Text = "";
            DDlandPayment.SelectedIndex = -1;
            txtlandTotalcmblIncl.Text = "";
            txtlandVatAmount.Text = "";
            DDlandCreditCard.SelectedIndex = -1;
            txtlandNoncmbl.Text = "";
            txtlandCommIncl.Text = "";
            txtlandDuefromclient.Text = "";
            txtlandLessComm.Text = "";
            txtlandDuetoSupplier.Text = "";
            txtlandCO2.Text = "";
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    private void ServiceFeeClear()
    {
        try
        {
            ddlServiceType.SelectedIndex = -1;
            ddlSoureceref.SelectedIndex = -1;
            txtSerTravelDate.Text = "";
            ddlPassengerName.Items.Clear();
            txtExclusAmount.Text = "";
            txtserDetails.Text = "";
            txtSerVatPer.Text = "";
            txtSerVatAmount.Text = "";
            ddlPaymentMethod.SelectedIndex = -1;
            chkMerge.Checked = false;


            txtSerClientTotal.Text = "";
            ddlCreditCardType.SelectedIndex = -1;
            ddlCollectVia.SelectedIndex = -1;
            txtTASFMPD.Text = "";

        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    //private void GeneralChargeClear()
    //{
    //    try
    //    {
    //        ddlGenchrgType.SelectedIndex = -1;
    //        ddlPassengerNames.SelectedIndex = -1;
    //        txtDetails.Text = "";
    //        ddlCrdCardType.SelectedIndex = -1;
    //        txtUnits.Text = "";
    //        txtRateNet.Text = "";
    //        txtgenvat.Text = "";
    //        txtVatAmount.Text = "";
    //        txtExcluAmount.Text = "";
    //        txtClientTotal.Text = "";

    //    }
    //    catch (Exception ex)
    //    {
    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }

    //}

    protected void ddlSoureceref_TextChanged(object sender, EventArgs e)
    {
        ddlPassengerName.Items.Clear();
        BindSerPassengerNames();
        SerPopupExtender.Show();
    }





    //Edit for Invoice
   
    private void BindInvoiceLineItemsEdit(int InvId)
    {
        try
        {

            DataSet ds = _objBalInvoice.GetInvoiceLinesEdit(InvId);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                InvListGrid.DataSource = ds;
                InvListGrid.DataBind();

            }
            else
            {
                InvListGrid.DataSource = ds;
                InvListGrid.DataBind();
            }


        }
        catch(Exception ex)
        {
            lblMsg.Text = "";
            ExceptionLogging.SendExcepToDB(ex);
        }
    }


   



    //protected void InvListGrid_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //    if (e.Row.RowType == DataControlRowType.DataRow)
    //    {
    //        e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(InvListGrid, "Select$" + e.Row.RowIndex);
    //        e.Row.Attributes["style"] = "cursor:pointer";
    //    }
    //}
    //protected void InvListGrid_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    int index = InvListGrid.SelectedRow.RowIndex;
    //    string name = InvListGrid.SelectedRow.Cells[0].Text;
    //    string country = InvListGrid.SelectedRow.Cells[1].Text;
    //    string message = "Row Index: " + index + "\\nName: " + name + "\\nCountry: " + country;
    //    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + message + "');", true);
    //}
    //protected void InvListGrid_SelectedIndexChanged(object sender, EventArgs e)
    //{

    //}



    protected void lnkView_Click(object sender, EventArgs e)
    {

        LinkButton btnDetails = sender as LinkButton;
        GridViewRow gvrow = (GridViewRow)btnDetails.NamingContainer;
        int TicketNo = Convert.ToInt32(InvListGrid.DataKeys[gvrow.RowIndex].Values[1]);
        string TicketType = InvListGrid.DataKeys[gvrow.RowIndex].Values[0].ToString();
        //  string TicketType = InvListGrid.DataKeys[gvrow.RowIndex].Value.ToString();

        if (TicketType == "Air")
        {
            btnAirSubmit.Text = "Update";
            VASPopupExtender.Show();
            GetTicketDetails(TicketNo, TicketType);


        }
        else if (TicketType == "Land")
        {
            LandArrSubmit.Text = "Update";
            landPopExtender.Show();
            GetTicketDetails(TicketNo, TicketType);
        }
        else if (TicketType == "SF")
        {
            SerSubmit.Text = "Update";
            SerPopupExtender.Show();
            GetTicketDetails(TicketNo, TicketType);
        }
        else if (TicketType == "ACM")
        {
            ACMSubmit.Text = "Update";
            ACMModalPopupExtender.Show();
            GetTicketDetails(TicketNo, TicketType);

            //ACMModalPopupExtender.Show();
            //GenSubmit.Text = "Update";
            //GenPopupExtender.Show();
            //GetTicketDetails(TicketNo, TicketType);
        }
        else
        {
            ADMSubmit.Text = "Update";
            ADMModalPopupExtender.Show();
            GetTicketDetails(TicketNo, TicketType);
        }

        //   TicketType == "Air" ? VASPopupExtender.Show() : VASPopupExtender.Show();

    }

    private void GetTicketDetails(int TicketNo, string TicketType)
    {

        DataSet ds = _objBalInvoice.GetTicket(TicketNo, TicketType);

        if (TicketType == "Air")
        {
            hf_Air_TicketNo.Value = ds.Tables[0].Rows[0]["TicketId"].ToString();
            txtAirTicketNo.Text = ds.Tables[0].Rows[0]["AirTicketNo"].ToString();
            drpTicketType.SelectedIndex = drpTicketType.Items.IndexOf(drpTicketType.Items.FindByValue(ds.Tables[0].Rows[0]["AirTicketType"].ToString()));
            txtPnr.Text = ds.Tables[0].Rows[0]["AirPnr"].ToString();
            ddlAirLine.SelectedIndex = ddlAirLine.Items.IndexOf(ddlAirLine.Items.FindByValue(ds.Tables[0].Rows[0]["AirLine"].ToString()));
            drpAirPassenger.Text = ds.Tables[0].Rows[0]["AirPassenger"].ToString();
            txtAirConjunction.Text = ds.Tables[0].Rows[0]["Conjunction"].ToString();
            ddlAirService.SelectedIndex = ddlAirService.Items.IndexOf(ddlAirService.Items.FindByValue(ds.Tables[0].Rows[0]["AirService"].ToString()));
            ddlType.SelectedIndex = ddlType.Items.IndexOf(ddlType.Items.FindByValue(ds.Tables[0].Rows[0]["Type"].ToString()));
            txtAirMiles.Text = ds.Tables[0].Rows[0]["AirMiles"].ToString();

            // txtAirExcluisvefare.Text= _objBOUtiltiy.FormatTwoDecimal((ds.Tables[0].Rows[0]["AirExclusiveFare"].ToString()));

            txtAirRouting.Text = ds.Tables[0].Rows[0]["AirRouting"].ToString();


            // Routing 
            if (ds.Tables[4].Rows.Count > 3)
            {
                lblRoutes1.Text = ds.Tables[4].Rows[0]["Routs"].ToString();
                txtFlightNo1.Text = ds.Tables[4].Rows[0]["FlightNo"].ToString();
                txtClass1.Text = ds.Tables[4].Rows[0]["Class"].ToString();
                txtDate1.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[4].Rows[0]["Date"].ToString());

                lblRoutes2.Text = ds.Tables[4].Rows[1]["Routs"].ToString();
                txtFlightNo2.Text = ds.Tables[4].Rows[1]["FlightNo"].ToString();
                txtClass2.Text = ds.Tables[4].Rows[1]["Class"].ToString();
                txtDate2.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[4].Rows[1]["Date"].ToString());

                lblRoutes3.Text = ds.Tables[4].Rows[2]["Routs"].ToString();
                txtFlightNo3.Text = ds.Tables[4].Rows[2]["FlightNo"].ToString();
                txtClass3.Text = ds.Tables[4].Rows[2]["Class"].ToString();
                txtDate3.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[4].Rows[2]["Date"].ToString());

                lblRoutes4.Text = ds.Tables[4].Rows[3]["Routs"].ToString();
                txtFlightNo4.Text = ds.Tables[4].Rows[3]["FlightNo"].ToString();
                txtClass4.Text = ds.Tables[4].Rows[3]["Class"].ToString();
                txtDate4.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[4].Rows[3]["Date"].ToString());
            }
            if (ds.Tables[4].Rows.Count > 2)
            {
                lblRoutes1.Text = ds.Tables[4].Rows[0]["Routs"].ToString();
                txtFlightNo1.Text = ds.Tables[4].Rows[0]["FlightNo"].ToString();
                txtClass1.Text = ds.Tables[4].Rows[0]["Class"].ToString();
                txtDate1.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[4].Rows[0]["Date"].ToString());

                lblRoutes2.Text = ds.Tables[4].Rows[1]["Routs"].ToString();
                txtFlightNo2.Text = ds.Tables[4].Rows[1]["FlightNo"].ToString();
                txtClass2.Text = ds.Tables[4].Rows[1]["Class"].ToString();
                txtDate2.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[4].Rows[1]["Date"].ToString());

                lblRoutes3.Text = ds.Tables[4].Rows[2]["Routs"].ToString();
                txtFlightNo3.Text = ds.Tables[4].Rows[2]["FlightNo"].ToString();
                txtClass3.Text = ds.Tables[4].Rows[2]["Class"].ToString();
                txtDate3.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[4].Rows[2]["Date"].ToString());


            }
            if (ds.Tables[4].Rows.Count > 1)
            {
                lblRoutes1.Text = ds.Tables[4].Rows[0]["Routs"].ToString();
                txtFlightNo1.Text = ds.Tables[4].Rows[0]["FlightNo"].ToString();
                txtClass1.Text = ds.Tables[4].Rows[0]["Class"].ToString();
                txtDate1.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[4].Rows[0]["Date"].ToString());

                lblRoutes2.Text = ds.Tables[4].Rows[1]["Routs"].ToString();
                txtFlightNo2.Text = ds.Tables[4].Rows[1]["FlightNo"].ToString();
                txtClass2.Text = ds.Tables[4].Rows[1]["Class"].ToString();
                txtDate2.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[4].Rows[1]["Date"].ToString());



            }
            if (ds.Tables[4].Rows.Count > 0)
            {
                lblRoutes1.Text = ds.Tables[4].Rows[0]["Routs"].ToString();
                txtFlightNo1.Text = ds.Tables[4].Rows[0]["FlightNo"].ToString();
                txtClass1.Text = ds.Tables[4].Rows[0]["Class"].ToString();
                txtDate1.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[4].Rows[0]["Date"].ToString());

            }

            //Routing 

            txtAirTravelDate.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[0].Rows[0]["AirTravelDate"].ToString());
            txtAirReturnDate.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[0].Rows[0]["AirReturnDate"].ToString());
            txtAirExcluisvefare.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirExclusiveFare"].ToString());
            txtAirCommisionper.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirCommPer"].ToString());
            txtVatPer.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirVatPer"].ToString());
            txtAirVatOnFare.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirVatonFare"].ToString());
            txtAirCommExclu.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirCommExcl"].ToString());
            txtAirportTax.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirportTaxes"].ToString());
            txtAirCommVat.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirVatPer"].ToString());
            txtAirVatinclTax.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirVatInTaxes"].ToString());
            txtAirAgentVat.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirAgentVat"].ToString());
            txtAirClientTot.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirClientTotal"].ToString());
            txtAirCommInclu.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirCommInclu"].ToString());
            ddlAirPayment.SelectedIndex = ddlAirPayment.Items.IndexOf(ddlAirPayment.Items.FindByValue(ds.Tables[0].Rows[0]["AirPayment"].ToString()));
            txtAirDueToBsp.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[0].Rows[0]["AirDueToBsp"].ToString());
        }
        else if (TicketType == "Land")
        {
            hf_Land_TicketNo.Value = ds.Tables[1].Rows[0]["LandArrId"].ToString();
            DDlandSupplier.SelectedIndex = DDlandSupplier.Items.IndexOf(DDlandSupplier.Items.FindByValue(ds.Tables[1].Rows[0]["LandSupplier"].ToString()));
            DDlandService.SelectedIndex = DDlandService.Items.IndexOf(DDlandService.Items.FindByValue(ds.Tables[1].Rows[0]["Services"].ToString()));
            DDlandType.SelectedIndex = DDlandType.Items.IndexOf(DDlandType.Items.FindByValue(ds.Tables[1].Rows[0]["Type"].ToString()));
            txtlandPassName.Text = ds.Tables[1].Rows[0]["PassengerName"].ToString();
            txtlandTravelFrom.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[1].Rows[0]["TravelFrDate"].ToString());
            txtlandTravelto.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[1].Rows[0]["TravelToDate"].ToString());
            txtlandBookingRef.Text = ds.Tables[1].Rows[0]["BookRefNo"].ToString();
            txtlandVocher.Text = ds.Tables[1].Rows[0]["Voucher"].ToString();
            txtlandSupplierRef.Text = ds.Tables[1].Rows[0]["SuppRef"].ToString();
            txtlandSuppInvNo.Text = ds.Tables[1].Rows[0]["SuppInvNo"].ToString();
            txtlandUnits.Text = ds.Tables[1].Rows[0]["Units"].ToString();
            txtlandcmblExcl.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["TotExclu"].ToString());
            txtlandTotalExcl.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["TotExclu"].ToString());
            txtlandRateIncl.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["RateInclu"].ToString());
            txtlandCommPer.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["CommPer"].ToString());
            txtLandExlVatPer.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["VatPer"].ToString());
            txtlandExclVatAmount.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["ExclusiveVatAmount"].ToString());
            txtlandCmblIncl.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["CommissionableInclu"].ToString());
            txtlandCommExcl.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["CommissionExclu"].ToString());
            txtlandTotalIncl.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["TotIncl"].ToString());
            txtlandOtherCmblIncl.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["OthCommabInclu"].ToString());
            txtLandVatPer.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["VatPer"].ToString());
            DDlandPayment.SelectedIndex = DDlandPayment.Items.IndexOf(DDlandPayment.Items.FindByValue(ds.Tables[1].Rows[0]["Payment"].ToString()));
            txtlandTotalcmblIncl.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["TotCommabInclu"].ToString());
            txtlandVatAmount.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["CommVatAmount"].ToString());
            DDlandCreditCard.SelectedIndex = DDlandCreditCard.Items.IndexOf(DDlandCreditCard.Items.FindByValue(ds.Tables[1].Rows[0]["CreditCard"].ToString()));
            txtlandNoncmbl.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["NonCommabInclu"].ToString());
            txtlandCommIncl.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["CommissionInclu"].ToString());
            txtlandDuefromclient.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["DueTOClient"].ToString());
            txtlandLessComm.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["LessCommission"].ToString());
            txtlandDuetoSupplier.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["DueTOSupplier"].ToString());
            txtlandCO2.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[1].Rows[0]["CO2Emis"].ToString());
        }
        else if (TicketType == "SF")
        {
            hf_SF_TicketNo.Value = ds.Tables[2].Rows[0]["ServiceFeeId"].ToString();
            if (ds.Tables[2].Rows[0]["MergeC"].ToString() == "0")
            {
                chkMerge.Checked = false;
            }
            else
            {
                chkMerge.Checked = true;
            }
            ddlServiceType.SelectedIndex = ddlServiceType.Items.IndexOf(ddlServiceType.Items.FindByValue(ds.Tables[2].Rows[0]["Type"].ToString()));
            ddlSoureceref.SelectedIndex = ddlSoureceref.Items.IndexOf(ddlSoureceref.Items.FindByValue(ds.Tables[2].Rows[0]["SourceRef"].ToString()));
            txtSerTravelDate.Text = _objBOUtiltiy.ConvertDateFormat(ds.Tables[2].Rows[0]["TravelDate"].ToString());
            BindSerPassengerNames();
            ddlPassengerName.SelectedIndex = ddlPassengerName.Items.IndexOf(ddlPassengerName.Items.FindByValue(ds.Tables[2].Rows[0]["PassengerName"].ToString()));
            txtExclusAmount.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[2].Rows[0]["ExcluAmount"].ToString());
            txtserDetails.Text = ds.Tables[2].Rows[0]["Details"].ToString();
            txtSerVatPer.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[2].Rows[0]["VatPer"].ToString());
            txtSerVatAmount.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[2].Rows[0]["VatAmount"].ToString());
            ddlPaymentMethod.SelectedIndex = ddlPaymentMethod.Items.IndexOf(ddlPaymentMethod.Items.FindByValue(ds.Tables[2].Rows[0]["PaymentMethod"].ToString()));
            BindCollectVia();
            BindSerCreditCardType();
            txtSerClientTotal.Text = _objBOUtiltiy.FormatTwoDecimal(ds.Tables[2].Rows[0]["ClientTot"].ToString());
            ddlCreditCardType.SelectedIndex = ddlCreditCardType.Items.IndexOf(ddlCreditCardType.Items.FindByValue(ds.Tables[2].Rows[0]["CreditCardType"].ToString()));
            ddlCollectVia.SelectedIndex = ddlCollectVia.Items.IndexOf(ddlCollectVia.Items.FindByValue(ds.Tables[2].Rows[0]["CollectVia"].ToString()));
            txtTASFMPD.Text = ds.Tables[2].Rows[0]["TasfMpd"].ToString();
        }
        else if (TicketType == "ACM")
        {
            hf_ACM_TicketNo.Value = ds.Tables[6].Rows[0]["CreditMemoRevId"].ToString();
            //ddlSoureceref.SelectedIndex = ddlSoureceref.Items.IndexOf(ddlSoureceref.Items.FindByValue(ds.Tables[2].Rows[0]["SourceRef"].ToString()));
            txtACMNO.Text = ds.Tables[6].Rows[0]["AcmNo"].ToString();
            ddlACMTicketNO.Items.FindByText(ds.Tables[6].Rows[0]["TicketNo"].ToString()).Selected = true;
           // ddlACMTicketNO.Text = ds.Tables[6].Rows[0]["TicketNo"].ToString();
            DDLACMSupplier.SelectedIndex = DDLACMSupplier.Items.IndexOf(DDLACMSupplier.Items.FindByValue(ds.Tables[6].Rows[0]["Supplier"].ToString()));
            DDLACMType.SelectedIndex = DDLACMType.Items.IndexOf(DDLACMType.Items.FindByValue(ds.Tables[6].Rows[0]["Type"].ToString()));
            txtACMPassengerName.Text = ds.Tables[6].Rows[0]["PassengerName"].ToString();
            txtACMExclFire.Text = ds.Tables[6].Rows[0]["ExcluFare"].ToString();
            txtACMCommission.Text = ds.Tables[6].Rows[0]["Commission"].ToString();
            txtFareVat.Text = ds.Tables[6].Rows[0]["FareVat"].ToString();
            txtACMagentVat.Text = ds.Tables[6].Rows[0]["AgentVat"].ToString();
            txtACMDepTaxes.Text = ds.Tables[6].Rows[0]["DepatureTaxes"].ToString();
            txtACMBSP.Text = ds.Tables[6].Rows[0]["BSP"].ToString();
          //  txtACMCrediCard.Text = ds.Tables[6].Rows[0]["CreditCard"].ToString();
            txtACMClientTotal.Text = ds.Tables[6].Rows[0]["ClientTotal"].ToString();

        }
        else
        {
            hf_ADM_TicketNo.Value = ds.Tables[7].Rows[0]["DebitMemoId"].ToString();
            //ddlSoureceref.SelectedIndex = ddlSoureceref.Items.IndexOf(ddlSoureceref.Items.FindByValue(ds.Tables[2].Rows[0]["SourceRef"].ToString()));
            txtADMNO.Text = ds.Tables[7].Rows[0]["AdmNo"].ToString();
            txtADMTicketNO.Text = ds.Tables[7].Rows[0]["TicketNo"].ToString();
            DDLADMSupplier.SelectedIndex = DDLADMSupplier.Items.IndexOf(DDLADMSupplier.Items.FindByValue(ds.Tables[7].Rows[0]["Supplier"].ToString()));
            
            DDLADMType.SelectedIndex = DDLADMType.Items.IndexOf(DDLADMType.Items.FindByValue(ds.Tables[7].Rows[0]["Type"].ToString()));
            txtADMPassengerName.Text = ds.Tables[7].Rows[0]["PassengerName"].ToString();
            txtADMExclFire.Text = ds.Tables[7].Rows[0]["ExcluFare"].ToString();
            txtADMCommission.Text = ds.Tables[7].Rows[0]["Commission"].ToString();
            DDLADMFarevat.SelectedIndex = DDLADMFarevat.Items.IndexOf(DDLADMFarevat.Items.FindByValue(ds.Tables[7].Rows[0]["FareVat"].ToString()));
            txtADMVat.Text = ds.Tables[7].Rows[0]["AgentVat"].ToString();
            txtADMDepTaxes.Text = ds.Tables[7].Rows[0]["DepatureTaxes"].ToString();
            txtADMClientTotal.Text = ds.Tables[7].Rows[0]["ClientTotal"].ToString();
       //     DDLADMCreditCard.SelectedIndex = DDLADMCreditCard.Items.IndexOf(DDLADMCreditCard.Items.FindByValue(ds.Tables[7].Rows[0]["CreditCard"].ToString()));
            txtADMBSP.Text = ds.Tables[7].Rows[0]["BSP"].ToString();
        }
    }
    //protected void GenCancel_Click(object sender, EventArgs e)
    //{
    //    GenSubmit.Text = "Submit";
    //    GenPopupExtender.Hide();
    //    GeneralChargeClear();
    //}
    protected void btnInvCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("InvoiceList.aspx");
    }

    protected void btnserFee_ServerClick(object sender, EventArgs e)
    {
        //  pnlServiceFee.Visible = false;

        //  SerPopupExtender.Hide();

        string tempUniqueCode = (string)Session["TempUniqCode"] == "" ? "0" : Session["TempUniqCode"].ToString();

        DataSet ds = _objBalInvoice.getInvoiceLines(tempUniqueCode);
        // first Check Table Count
        if (ds.Tables[0].Rows.Count > 0)
        {
            string TicketType = ds.Tables[0].Rows[0]["Type"].ToString();
            // Check Ticket Type === Air
            if (TicketType == "Air")
            {
                pnlServiceFee.Visible = true;
                SerPopupExtender.Show();
            }
            else
            {
                pnlServiceFee.Visible = false;
                string script = string.Format("alert('Please Book Air Ticket. ');");
                ScriptManager.RegisterClientScriptBlock(Page, typeof(System.Web.UI.Page), "redirect", script, true);

            }
        }
        else
        {
            // pnlServiceFee.Visible = false;
            string script1 = string.Format("alert('Please Book Air Ticket. ');");
            ScriptManager.RegisterClientScriptBlock(Page, typeof(System.Web.UI.Page), "redirect", script1, true);

        }

    }
    //protected void btnGencharge_ServerClick(object sender, EventArgs e)
    //{
    //    string tempUniqueCode = (string)Session["TempUniqCode"] == "" ? "0" : Session["TempUniqCode"].ToString();

    //    DataSet ds = _objBalInvoice.getInvoiceLines(tempUniqueCode);

    //    if (ds.Tables[0].Rows.Count > 0)
    //    {
    //        string TicketType = ds.Tables[0].Rows[0]["Type"].ToString();
    //        if (TicketType == "Air")
    //        {
    //            //GenPopupExtender.Show();
    //        }
    //        else
    //        {
    //            string script = string.Format("alert('Please Book Air Ticket. ');");
    //            ScriptManager.RegisterClientScriptBlock(Page, typeof(System.Web.UI.Page), "redirect", script, true);
    //            //GenPopupExtender.Hide();
    //        }
    //    }
    //    else
    //    {
    //        string script1 = string.Format("alert('Please Book Air Ticket. ');");
    //        ScriptManager.RegisterClientScriptBlock(Page, typeof(System.Web.UI.Page), "redirect", script1, true);
    //        //GenPopupExtender.Hide();
    //    }
    //}
    private void AirTicketType()
    {
        try
        {
            BATicketType objTicketType = new BATicketType();
            int TId = 0;
            DataSet dtTicketType = new DataSet();
            dtTicketType = objTicketType.GetTicketType(TId);
            if (dtTicketType.Tables[0].Rows.Count > 0)
            {
                drpTicketType.DataSource = dtTicketType.Tables[0];
                drpTicketType.DataTextField = "TDesc";
                drpTicketType.DataValueField = "TId";
                drpTicketType.DataBind();
                drpTicketType.Items.Insert(0, new ListItem("--Select Type--", "0"));
            }
            else
            {
                drpTicketType.DataSource = null;
                drpTicketType.DataBind();
                drpTicketType.Items.Insert(0, new ListItem("--Select Type--", "0"));
            }
        }
        catch (Exception ex)
        {

            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }

    protected void txtSerClientTotal_TextChanged(object sender, EventArgs e)
    {


        ExcusiveAmount();
    }


    private void ExcusiveAmount()
    {
        decimal ClientTotal = Convert.ToDecimal(txtSerClientTotal.Text);

        string VatPer = txtSerVatPer.Text;

        if (VatPer.Length > 1)
        {
            VatPer = VatPer.Substring(0, VatPer.Length - 3);
        }
        else
        {
            VatPer = "0";
        }
        var ts = "1." + VatPer;

        decimal dm = Convert.ToDecimal(ts.ToString());
        decimal exclAmount = (ClientTotal / dm);
        decimal vatamount = (ClientTotal - exclAmount);

        txtExclusAmount.Text = _objBOUtiltiy.FormatTwoDecimal(exclAmount.ToString());
        txtSerVatAmount.Text = vatamount.ToString();
        SerPopupExtender.Show();
    }

    // Acm 
    public void BindAcmType()
    {
        try
        {
            DDLACMType.DataSource = objDALACM.Get_Type();
            DDLACMType.DataTextField = "TypeName";
            DDLACMType.DataValueField = "TypeId";
            DDLACMType.DataBind();
            DDLACMType.Items.Insert(0, new ListItem("-Select-", "0"));
        }
        catch (Exception ex)
        {

            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }


    }





    protected void ClientTotal()
    {
        decimal vatAmount = 0;
        if (txtACMDepTaxes.Text != "" || txtACMCommission.Text != "" || txtACMagentVat.Text != "" || txtACMExclFire.Text != "")
        {
            if (txtFareVat.Text.ToString() != "")
            {
                decimal ExclFare = Convert.ToDecimal(txtACMExclFire.Text.ToString());

                decimal farevat = Convert.ToDecimal(txtFareVat.Text);

                vatAmount = (ExclFare * farevat) / 100;
            }
            vatAmount = Convert.ToDecimal(string.IsNullOrEmpty(vatAmount.ToString().Trim()) ? "0" : vatAmount.ToString().Trim());

            string airPorttax = string.IsNullOrEmpty(txtACMDepTaxes.Text.Trim()) ? "0" : txtACMDepTaxes.Text.Trim();
            txtACMDepTaxes.Text = airPorttax;

            string agentVat = string.IsNullOrEmpty(txtACMagentVat.Text.Trim()) ? "0" : txtACMagentVat.Text.Trim();
            txtACMagentVat.Text = agentVat;

            string commision = string.IsNullOrEmpty(txtACMCommission.Text.Trim()) ? "0" : txtACMCommission.Text.Trim();
            txtACMCommission.Text = commision;

            decimal clientTotal = Convert.ToDecimal(airPorttax) + Convert.ToDecimal(agentVat) + Convert.ToDecimal(commision) + vatAmount + Convert.ToDecimal(txtACMExclFire.Text);
            txtACMClientTotal.Text = clientTotal.ToString();
            decimal Bspamount = clientTotal - Convert.ToDecimal(txtACMCommission.Text);
            txtACMBSP.Text = Bspamount.ToString();
        }
    }
    protected void txtACMExclFire_TextChanged(object sender, EventArgs e)
    {
        ClientTotal();

        txtACMDepTaxes.Enabled = true;
        txtACMCommission.Enabled = true;
        txtACMagentVat.Enabled = true;
        ACMModalPopupExtender.Show();
    }
    protected void txtACMCommission_TextChanged(object sender, EventArgs e)
    {
        ClientTotal();
        ACMModalPopupExtender.Show();
    }
    protected void txtACMagentVat_TextChanged(object sender, EventArgs e)
    {
        ClientTotal();
        ACMModalPopupExtender.Show();
    }
    protected void txtACMDepTaxes_TextChanged(object sender, EventArgs e)
    {
        ClientTotal();
        ACMModalPopupExtender.Show();
    }
    private void InsertACM()
    {
        try
        {
            objEMACM.CreditMemoRevId = 0;
            if (ACMSubmit.Text == "Update")
            {
                objEMACM.CreditMemoRevId = Convert.ToInt32(hf_ACM_TicketNo.Value);
            }

            objEMACM.AcmNo = txtACMNO.Text.Trim();
            objEMACM.TicketNo = ddlACMTicketNO.SelectedItem.Text;
            objEMACM.Supplier = Convert.ToInt32(DDLACMSupplier.SelectedValue.ToString());

            objEMACM.Type = (string.IsNullOrEmpty(DDLACMType.SelectedValue.ToString())) ? 0 : Convert.ToInt32(DDLACMType.SelectedValue.ToString());
            objEMACM.PassengerName = txtACMPassengerName.Text.Trim();
            string ExcluFare = string.IsNullOrEmpty(txtACMExclFire.Text.Trim()) ? "0" : txtACMExclFire.Text.Trim();
            objEMACM.ExcluFare = Convert.ToDecimal(ExcluFare);
            objEMACM.InvId = Convert.ToInt32(txtACMInVid.Text);
            objEMACM.FareVat = Convert.ToDecimal(txtFareVat.Text.ToString());
            string Commission = string.IsNullOrEmpty(txtACMCommission.Text.Trim()) ? "0" : txtACMCommission.Text.Trim();
            objEMACM.Commission = Convert.ToDecimal(Commission);
            string DepatureTaxes = string.IsNullOrEmpty(txtACMDepTaxes.Text.Trim()) ? "0" : txtACMDepTaxes.Text.Trim();
            objEMACM.DepatureTaxes = Convert.ToDecimal(DepatureTaxes);
            string AgentVat = string.IsNullOrEmpty(txtACMagentVat.Text.Trim()) ? "0" : txtACMagentVat.Text.Trim();
            objEMACM.AgentVat = Convert.ToDecimal(AgentVat);
            string ClientTotal = string.IsNullOrEmpty(txtACMClientTotal.Text.Trim()) ? "0" : txtACMClientTotal.Text.Trim();
            objEMACM.ClientTotal = Convert.ToDecimal(ClientTotal);
            string BSP = string.IsNullOrEmpty(txtACMBSP.Text.Trim()) ? "0" : txtACMBSP.Text.Trim();
            objEMACM.BSP = Convert.ToDecimal(BSP);
           // string CreditCard = string.IsNullOrEmpty(txtACMCrediCard.Text.Trim()) ? "0" : txtACMCrediCard.Text.Trim();
          //  objEMACM.CreditCard = Convert.ToInt32(CreditCard);
            objEMACM.InvoiceType = "ACM";
            objEMACM.IsCreditNote = 1;
            if (Session["TempUniqCode"] == null || Session["TempUniqCode"] == "")
            {
                objEMACM.AcmTempUniqId = uniqueIdSession();
            }
            else
            {
                objEMACM.AcmTempUniqId = Session["TempUniqCode"].ToString();
            }

            int Result = objDALACM.InsertAgencycreditmemo(objEMACM);


            if (Result > 0)
            {

                lblMsg.Text = _objBOUtiltiy.ShowMessage("success", "Success", "Agency Cedit Memo created Successfully");
                Session["TempUniqCode"] = objEMACM.AcmTempUniqId;
                BindInvoiceLineItems();
             
                ACMClear();
            }
            else
            {
                lblMsg.Text = _objBOUtiltiy.ShowMessage("info", "Info", "Agency Cedit Memo Details was not created plase try again");
                BindInvoiceLineItems();
             
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void ACMSubmit_Click(object sender, EventArgs e)
    {
        InsertACM();
    }
    protected void Cancel_Click1(object sender, EventArgs e)
    {

    }

    public void BindAdmSuppliers()
    {

        try
        {
            BALandSuppliers objBalandSuppliers = new BALandSuppliers();
            int landSupId = 0;
            DataSet datasetland = new DataSet();
            datasetland = objBalandSuppliers.GetLandSupplier(landSupId);
            if (datasetland.Tables[0].Rows.Count > 0)
            {
                DDLADMSupplier.DataSource = datasetland.Tables[0];
                DDLADMSupplier.DataTextField = "LSupplierName";
                DDLADMSupplier.DataValueField = "LSupplierId";
                DDLADMSupplier.DataBind();
                DDLADMSupplier.Items.Insert(0, new ListItem("--Select Supplier--", "0"));
            }
            else
            {
                DDLADMSupplier.DataSource = null;
                DDLADMSupplier.DataBind();
                DDLADMSupplier.Items.Insert(0, new ListItem("--Select Supplier--", "0"));
            }
        }
        catch (Exception ex)
        {

            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }
    public void BindADMType()
    {
        try
        {
            DDLADMType.DataSource = objDALADM.Get_Type();
            DDLADMType.DataTextField = "TypeName";
            DDLADMType.DataValueField = "TypeId";
            DDLADMType.DataBind();
            DDLADMType.Items.Insert(0, new ListItem("-Select-", "0"));
        }
        catch (Exception ex)
        {

            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }


    }

    //public void BindADMCreditCrard()
    //{

    //    try
    //    {
    //        DDLADMCreditCard.DataSource = objDALADM.Get_CreditCard();
    //        DDLADMCreditCard.DataTextField = "CardDescription";
    //        DDLADMCreditCard.DataValueField = "CrdCardId";
    //        DDLADMCreditCard.DataBind();
    //        DDLADMCreditCard.Items.Insert(0, new ListItem("-Select-", "0"));
    //    }
    //    catch (Exception ex)
    //    {

    //        lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
    //    }

    //}





    protected void DDLADMType_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DDLADMFarevat.DataSource = objDALADM.Get_Vat(DDLADMType.SelectedIndex);
            DDLADMFarevat.DataTextField = "VatRate";
            DDLADMFarevat.DataValueField = "VatId";
            DDLADMFarevat.DataBind();
            DDLADMFarevat.Enabled = false;
            ADMModalPopupExtender.Show();

        }
        catch (Exception ex)
        {

            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }
    protected void ADMClientTotal()
    {
        decimal vatAmount = 0;
        if (txtADMDepTaxes.Text != "" || txtADMCommission.Text != "" || txtADMVat.Text != "" || txtADMExclFire.Text != "")
        {
            if (DDLADMFarevat.SelectedValue.ToString() != "")
            {
                decimal ExclFare = Convert.ToDecimal(txtADMExclFire.Text.ToString());

                decimal farevat = Convert.ToDecimal(DDLADMFarevat.SelectedItem.Text);

                vatAmount = (ExclFare * farevat) / 100;
            }
            vatAmount = Convert.ToDecimal(string.IsNullOrEmpty(vatAmount.ToString().Trim()) ? "0" : vatAmount.ToString().Trim());

            string airPorttax = string.IsNullOrEmpty(txtADMDepTaxes.Text.Trim()) ? "0" : txtADMDepTaxes.Text.Trim();
            txtADMDepTaxes.Text = airPorttax;

            string agentVat = string.IsNullOrEmpty(txtADMVat.Text.Trim()) ? "0" : txtADMVat.Text.Trim();
            txtADMVat.Text = agentVat;

            string commision = string.IsNullOrEmpty(txtADMCommission.Text.Trim()) ? "0" : txtADMCommission.Text.Trim();
            txtADMCommission.Text = commision;

            decimal clientTotal = Convert.ToDecimal(airPorttax) + Convert.ToDecimal(agentVat) + Convert.ToDecimal(commision) + vatAmount + Convert.ToDecimal(txtADMExclFire.Text);
            txtADMClientTotal.Text = clientTotal.ToString();
            decimal Bspamount = clientTotal - Convert.ToDecimal(txtADMCommission.Text);
            txtADMBSP.Text = Bspamount.ToString();
        }
    }
    protected void txtADMExclFire_TextChanged(object sender, EventArgs e)
    {
        ADMClientTotal();

        txtADMDepTaxes.Enabled = true;
        txtADMCommission.Enabled = true;
        txtADMVat.Enabled = true;
        ADMModalPopupExtender.Show();
    }
    protected void txtADMCommission_TextChanged(object sender, EventArgs e)
    {
        ADMClientTotal();
        ADMModalPopupExtender.Show();

    }
    protected void DDLADMFarevat_TextChanged(object sender, EventArgs e)
    {
        ADMClientTotal();
        ADMModalPopupExtender.Show();

    }
    protected void txtADMVat_TextChanged(object sender, EventArgs e)
    {
        ADMClientTotal();
        ADMModalPopupExtender.Show();

    }
    protected void txtADMDepTaxes_TextChanged(object sender, EventArgs e)
    {
        ADMClientTotal();
        ADMModalPopupExtender.Show();

    }

    private void InsertADM()
    {
        try
        {
            objEMADM.DebitMemoId = 0;
            if (ADMSubmit.Text == "Update")
            {
                objEMADM.DebitMemoId = Convert.ToInt32(hf_ADM_TicketNo.Value);
            }

            objEMADM.AdmNo = txtADMNO.Text.Trim();
            objEMADM.TicketNo = txtADMTicketNO.Text.Trim();
            objEMADM.Supplier = Convert.ToInt32(DDLADMSupplier.SelectedValue.ToString());
            string type = DDLADMType.SelectedValue.ToString();
            objEMADM.Type = Convert.ToInt32(type);
            objEMADM.PassengerName = txtADMPassengerName.Text.Trim();
            string ExcluFare = string.IsNullOrEmpty(txtADMExclFire.Text.Trim()) ? "0" : txtADMExclFire.Text.Trim();
            objEMADM.ExcluFare = Convert.ToDecimal(ExcluFare);
            //string FareVat = string.IsNullOrEmpty(txtFareVat.Text.Trim()) ? "0" : txtFareVat.Text.Trim();
            //objEMAgencydebitmemo.FareVat = Convert.ToInt32(FareVat);
            objEMADM.FareVat = Convert.ToInt32(DDLADMFarevat.SelectedValue.ToString());
            string Commission = string.IsNullOrEmpty(txtADMCommission.Text.Trim()) ? "0" : txtADMCommission.Text.Trim();
            objEMADM.Commission = Convert.ToDecimal(Commission);
            string DepatureTaxes = string.IsNullOrEmpty(txtADMDepTaxes.Text.Trim()) ? "0" : txtADMDepTaxes.Text.Trim();
            objEMADM.DepatureTaxes = Convert.ToDecimal(DepatureTaxes);
            string AgentVat = string.IsNullOrEmpty(txtADMVat.Text.Trim()) ? "0" : txtADMVat.Text.Trim();
            objEMADM.AgentVat = Convert.ToDecimal(AgentVat);
            string ClientTotal = string.IsNullOrEmpty(txtADMClientTotal.Text.Trim()) ? "0" : txtADMClientTotal.Text.Trim();
            objEMADM.ClientTotal = Convert.ToDecimal(ClientTotal);
            string BSP = string.IsNullOrEmpty(txtADMBSP.Text.Trim()) ? "0" : txtADMBSP.Text.Trim();
            objEMADM.BSP = Convert.ToDecimal(BSP);
            //string CreditCard = string.IsNullOrEmpty(txtCrediCard.Text.Trim()) ? "0" : txtCrediCard.Text.Trim();
            //objEMAgencydebitmemo.CreditCard = Convert.ToInt32(CreditCard);
          //  objEMADM.CreditCard = Convert.ToInt32(DDLADMCreditCard.SelectedIndex);
            objEMADM.InvoiceType = "ADM";
            objEMADM.IsCreditNote = 1;
            if (Session["TempUniqCode"] == null || Session["TempUniqCode"] == "")
            {
                objEMADM.AdmTempUniqId = uniqueIdSession();
            }
            else
            {
                objEMADM.AdmTempUniqId = Session["TempUniqCode"].ToString();
            }

            int Result = objDALADM.InsertAgencydebitmemo(objEMADM);


            if (Result > 0)
            {
                // lblMsg.Text = _objBOUtiltiy.ShowMessage("success", "Success", "Agency Debit Memo created Successfully");
                Session["TempUniqCode"] = objEMADM.AdmTempUniqId;
                BindInvoiceLineItems();
            
                ADMClear();
            }
            else
            {
                lblMsg.Text = _objBOUtiltiy.ShowMessage("info", "Info", "Agency Debit Memo Details was not created plase try again");
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }

    }
    protected void ADMSubmit_Click(object sender, EventArgs e)
    {
        InsertADM();
    }


    private void BindAcmTicktData()
    {
        try
        {
            DataSet ds = new DataSet();
            int airtickno = Convert.ToInt32(ddlACMTicketNO.SelectedItem.Value.ToString());
            string tempuniqcode = " ";
            ds = _objBalservice.BindPassengerNames(tempuniqcode, airtickno);

            if (ds.Tables[1].Rows.Count > 0)
            {
                ddlPassengerName.DataSource = ds.Tables[1];
                ddlPassengerName.DataTextField = "AirPassenger";
                ddlPassengerName.DataValueField = "TicketId";
                ddlPassengerName.DataBind();


                DDLACMType.DataSource = ds.Tables[1];

                DDLACMType.SelectedValue = ds.Tables[1].Rows[0]["Type"].ToString();
                DDLACMSupplier.SelectedValue = ds.Tables[1].Rows[0]["Airline"].ToString();
                txtACMPassengerName.Text = ds.Tables[1].Rows[0]["AirPassenger"].ToString();

                txtACMExclFire.Text = ds.Tables[1].Rows[0]["AirExclusiveFare"].ToString();
                txtACMCommission.Text = ds.Tables[1].Rows[0]["AirCommExcl"].ToString();
         
                txtACMDepTaxes.Text = ds.Tables[1].Rows[0]["AirportTaxes"].ToString();
                txtFareVat.Text = ds.Tables[1].Rows[0]["AirVatonFare"].ToString();
                txtACMagentVat.Text = ds.Tables[1].Rows[0]["AirAgentVat"].ToString();
                txtACMBSP.Text = ds.Tables[1].Rows[0]["AirDueToBsp"].ToString();
                txtACMClientTotal.Text = ds.Tables[1].Rows[0]["AirClientTotal"].ToString();
                txtACMInVid.Text = ds.Tables[1].Rows[0]["AirInvId"].ToString();
                ACMModalPopupExtender.Show();
            }
            else
            {
                ddlPassengerName.DataSource = null;
                ddlPassengerName.DataBind();
                ACMModalPopupExtender.Show();
            }
        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "Danger", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    private void ACMTiktNumbers()
    {

    }

    private void ACMClear()
    {
        txtACMNO.Text = "";
        ddlACMTicketNO.SelectedIndex = 0;
        DDLACMSupplier.SelectedIndex = 0;
        DDLACMType.SelectedIndex = 0;
        txtACMPassengerName.Text = "";
        txtACMExclFire.Text = "";
        txtACMCommission.Text = "";
        txtFareVat.Text = "";
        txtACMagentVat.Text = "";
        txtACMDepTaxes.Text = "";
        txtACMBSP.Text = "";
       
        txtACMClientTotal.Text = "";


    }
    private void ADMClear()
    {
        txtADMNO.Text = "";
        txtADMTicketNO.Text = "";
        DDLADMSupplier.SelectedIndex = 0;
        DDLADMType.SelectedIndex = 0;
        txtADMPassengerName.Text = "";
        txtADMExclFire.Text = "";
        txtADMCommission.Text = "";
        DDLADMFarevat.SelectedIndex = 0;
        txtADMVat.Text = "";
        txtADMDepTaxes.Text = "";
        txtADMClientTotal.Text = "";
       // DDLADMCreditCard.SelectedIndex = 0;
        txtADMBSP.Text = "";
    }
    protected void ddlACMTicketNO_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindAcmTicktData();
    }

    private void BIndRefundType()
    {

        ddlRefundtype.Items.Insert(0, new ListItem("-Select Refund Type-", "0"));
        ddlRefundtype.Items.Insert(1, new ListItem("Invoice Wise", "1"));
        ddlRefundtype.Items.Insert(2, new ListItem("Ticket No Wise", "2"));
    }
    protected void ddlRefundtype_TextChanged(object sender, EventArgs e)
    {
        int refundtype=Convert.ToInt32(ddlRefundtype.SelectedValue.ToString());
        if(refundtype == 1)
        {
            ddlTicketno.Enabled = false;
            int CreatedBy = Convert.ToInt32(Session["UserLoginId"].ToString());
            int BranchId = Convert.ToInt32(Session["BranchId"].ToString());
            int CompanyId = Convert.ToInt32(Session["UserCompanyId"].ToString());

            DataSet ds = objBALInvoice.GetInvoiceList(CompanyId,BranchId,CreatedBy);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                ddlInvoiceno.DataSource = ds;

                ddlInvoiceno.DataTextField = "InvDocumentNo";
                ddlInvoiceno.DataValueField = "InvId";
                ddlInvoiceno.DataBind();
                ddlInvoiceno.Items.Insert(0, new ListItem("--Select Invoice No--", "0"));
            }
            else
            {
                ddlInvoiceno.DataSource = null;
                ddlInvoiceno.DataBind();
                ddlInvoiceno.Items.Insert(0, new ListItem("--Select Invoice No--", "0"));
            }
        }

        else
        {

            ddlTicketno.Enabled = true;
        }

    }
   
    protected void ddlInvoiceno_TextChanged(object sender, EventArgs e)
    {
       int invoiceno= Convert.ToInt32(ddlInvoiceno.SelectedValue.ToString());
       GetInvDetails(invoiceno);
       DataSet ds = _objBalInvoice.GetInvoiceLinesEdit(invoiceno);
       if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
       {
           InvListGrid.DataSource = ds;
           InvListGrid.DataBind();

       }
       else
       {
           InvListGrid.DataSource = ds;
           InvListGrid.DataBind();
       }


    }
    protected void ddlTicketno_TextChanged(object sender, EventArgs e)
    {
        int ticketno = Convert.ToInt32(ddlTicketno.SelectedValue.ToString());
       string TicketType = " ";
        DataSet ds= _objBalInvoice.GetTicket(ticketno, TicketType);

        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
        {
            InvListGrid.DataSource = ds;
            InvListGrid.DataBind();
            int Invid = Convert.ToInt32(ds.Tables[0].Rows[0]["Invid"].ToString());

            GetInvDetails(Invid);
        }
        else
        {
            InvListGrid.DataSource = ds;
            InvListGrid.DataBind();
        }

    }

    protected void txtThisEntry_TextChanged(object sender, EventArgs e)
    {
        try
        {
      
            decimal OpenAmount = 0;

             decimal InvoiceOpenAmount = 0;


            decimal ThisEntryAmount = 0;
            foreach (GridViewRow row in InvListGrid.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {

                    TextBox txtThisEntry = row.FindControl("txtThisEntry") as TextBox;
                    HiddenField hfAllocatedAmount = row.FindControl("hfAllocatedAmount") as HiddenField;

                    if (!_objBOUtiltiy.TryParseCheckValue(txtThisEntry.Text, "Decimal"))
                    {
                        txtThisEntry.Text = "0";

                    }

                    if (txtThisEntry.Text != "" && txtThisEntry.Text != "0" && txtThisEntry.Text != "0.00")
                    {
                        if (txtThisEntry.Enabled == true)
                        {
                            ThisEntryAmount = Convert.ToDecimal(txtThisEntry.Text);

                            OpenAmount = OpenAmount + ThisEntryAmount;
                            txtRefundAmt.Text = OpenAmount.ToString();
                        }

                        ThisEntryAmount = Convert.ToDecimal(txtThisEntry.Text);

                        InvoiceOpenAmount = InvoiceOpenAmount + ThisEntryAmount;
                        lblInvoiceRefundAmt.Text = InvoiceOpenAmount.ToString();
                     
             GridViewRow gvRow = (GridViewRow)(sender as Control).Parent.Parent;
             int index = gvRow.RowIndex;
             Int32 lastindex = InvListGrid.Rows.Count - 1;
              
                 
                 if (lastindex > index)
                 {
             index = string.IsNullOrEmpty(index.ToString()) ? 1 : Convert.ToInt32(index.ToString());
             TextBox txtindex = (TextBox)InvListGrid.Rows[index + 1].FindControl("txtThisEntry");
             txtindex.Focus();
                    
                 }
                   
               }
                    
                }
            }


        }
        catch (Exception ex)
        {
            lblMsg.Text = _objBOUtiltiy.ShowMessage("danger", "error", ex.Message);
            ExceptionLogging.SendExcepToDB(ex);
        }
    }

    protected void InvListGrid_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            TextBox thisentry = (e.Row.FindControl("txtThisEntry") as TextBox);

            string refundamt = ((DataBoundLiteralControl)e.Row.Cells[9].Controls[0]).Text;
            refundamt = refundamt.Replace("\r\n", string.Empty);
            refundamt = refundamt.Trim();
           // string refundamt = e.Row.Cells[2].Text;
            refundamt = string.IsNullOrEmpty(refundamt) ? "0" : refundamt;
            if (Convert.ToDecimal(refundamt) != 0)
            {
                thisentry.Enabled = false;
                thisentry.Text = refundamt;
            }
        }

    }
}