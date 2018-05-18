﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CreditNote.aspx.cs" Inherits="Admin_CreditNote" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
      <style type="text/css">
        .modalBackground {
            /*filter: alpha(opacity=90);
            opacity: 0.8;*/
            border: 1px solid;
            background: #eee;
            padding: 2px;
            color: black;
        }

   #dropdown-list {
    height: auto !important;
    min-height: 120px;
    max-height: 210px;
}

        .hiddencol {
            display: none;
        }

        .decimalRight {
            text-align: right;
        }

        .style1 {
            color: #FF0000;
        }

        .uppercase {
            text-transform: uppercase;
        }
        
        .btncancle {
            float: right !important;
        }

        ContentPlaceHolder1_pnlFlight {
            left: -66px !important;
            top: -27px !important;
        }

        .test {
            color: white;
            border-radius: 4px;
        }
          #txtInvClntMesg
        {
            overflow-y:scroll;
             max-height: 40px;
           
        }
        #ContentPlaceHolder1_txtInvClntMesg
        {
            max-height: 40px !important;
        }

         .overlay {
            position: fixed;
            z-index: 999;
            top: 400px;
            left: 600px;
            filter: alpha(opacity=60);
            opacity: 0.6;
            -moz-opacity: 0.8;
        }
          .scrollable {
              overflow: auto;
              height:20px;
          }

    </style>

    <script type="text/javascript">


        function showProgress() {
            var updateProgress = $get("<%= UpdateProgress.ClientID %>");
            updateProgress.style.display = "block";
        }

        $(document).ready(function () {
            DatePickerSet();
            var prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_endRequest(function () {

                DatePickerSet();

            });

        });
        function DatePickerSet() {
            $('#ContentPlaceHolder1_txtInvDate').val('<%=System.DateTime.Now.ToShortDateString()%>');
            $("#ContentPlaceHolder1_txtInvDate").datepicker({
                format: 'yyyy-mm-dd',
                startDate: '-9d',
                endDate: '0d',
                autoclose: true
            }).attr('readonly', 'false');;
            //  $('#ContentPlaceHolder1_txtAirTravelDate').val('<%=System.DateTime.Now.ToShortDateString()%>');
            $("#ContentPlaceHolder1_txtAirTravelDate").datepicker({

                format: 'yyyy-mm-dd',

                autoclose: true

            }).attr('readonly', 'false');;
            //  $('#ContentPlaceHolder1_txtAirReturnDate').val('<%=System.DateTime.Now.ToShortDateString()%>');
            $("#ContentPlaceHolder1_txtAirReturnDate").datepicker({

                format: 'yyyy-mm-dd',

                autoclose: true

            }).attr('readonly', 'true');;
            // $('#ContentPlaceHolder1_txtDate').val('<%=System.DateTime.Now.ToShortDateString()%>');
            $("#ContentPlaceHolder1_txtDate4").datepicker({

                numberOfMonths: 1,
                dateFormat: 'yyyy-mm-dd',
                autoclose: true,

            }).attr('readonly', 'true');;
            //   $('#ContentPlaceHolder1_txtDate1').val('<%=System.DateTime.Now.ToShortDateString()%>');
            $("#ContentPlaceHolder1_txtDate1").datepicker({

                numberOfMonths: 1,
                dateFormat: 'yyyy-mm-dd',
                autoclose: true,

            }).attr('readonly', 'true');;
            //    $('#ContentPlaceHolder1_txtDate2').val('<%=System.DateTime.Now.ToShortDateString()%>');
            $("#ContentPlaceHolder1_txtDate2").datepicker({

                numberOfMonths: 1,
                dateFormat: 'yyyy-mm-dd',
                autoclose: true,

            }).attr('readonly', 'true');;
            //     $('#ContentPlaceHolder1_txtDate3').val('<%=System.DateTime.Now.ToShortDateString()%>');
            $("#ContentPlaceHolder1_txtDate3").datepicker({

                numberOfMonths: 1,
                dateFormat: 'yyyy-mm-dd',
                autoclose: true,

            }).attr('readonly', 'true');;
            $('#ContentPlaceHolder1_txtlandTravelFrom').val('<%=System.DateTime.Now.ToShortDateString()%>');
            $("#ContentPlaceHolder1_txtlandTravelFrom").datepicker({

                numberOfMonths: 1,
                dateFormat: 'yyyy-mm-dd',
                autoclose: true,

            }).attr('readonly', 'true');;

            // $('#ContentPlaceHolder1_txtlandTravelto').val('<%=System.DateTime.Now.ToShortDateString()%>');
            $("#ContentPlaceHolder1_txtlandTravelto").datepicker({

                numberOfMonths: 1,
                dateFormat: 'yyyy-mm-dd',
                autoclose: true,

            }).attr('readonly', 'true');;
            // $('#ContentPlaceHolder1_txtSerTravelDate').val('<%=System.DateTime.Now.ToShortDateString()%>');
            $("#ContentPlaceHolder1_txtSerTravelDate").datepicker({

                numberOfMonths: 1,
                dateFormat: 'yyyy-mm-dd',
                autoclose: true,

            }).attr('readonly', 'true');;
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
     <asp:Label ID="lblMsg" runat="server"></asp:Label>


       <asp:UpdatePanel ID="updatepanel1" runat="server">
        <ContentTemplate>

    <section class="panel">
        <header class="panel-heading">
             <div class="panel-actions">
                <a href="#" class="panel-action panel-action-toggle" data-panel-toggle=""></a>
            </div>
            <h2 class="panel-title">New Credit Note</h2>
        </header>
                 <asp:HiddenField ID="hf_InvId" runat="server" Value="0" />
        <div class="panel-body">

            <div class="form-group">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label class="control-label">
                            Refund Type<span class="style1">*</span>
                        </label>
                    </div>
                    <div class="col-sm-2">
                               
                          <asp:DropDownList ID="ddlRefundtype" runat="server" CssClass="form-control" OnTextChanged="ddlRefundtype_TextChanged" AutoPostBack="true">
                        </asp:DropDownList>

                        <asp:RequiredFieldValidator ControlToValidate="ddlRefundtype" runat="server" ID="rfvddlRefundtype" ValidationGroup="invoice"
                            ErrorMessage="Select Refund Type" Text="Select Refund Type" class="validationred" Display="Dynamic" ForeColor="Red" />
                    </div>

                    <div class="col-sm-2">
                        <label class="control-label">
                           Invoice No<span class="style1">*</span>
                        </label>
                    </div>
                 
                    <div class="col-sm-2 ">
                        <asp:DropDownList ID="ddlInvoiceno" runat="server" CssClass="form-control" OnTextChanged="ddlInvoiceno_TextChanged" Height="30px" AutoPostBack="true">
                        </asp:DropDownList>

                        <asp:RequiredFieldValidator ControlToValidate="ddlInvoiceno" runat="server" ID="rfvddlInvoiceno" ValidationGroup="invoice"
                            ErrorMessage="Select Invoice No" Text="Select Invoice No" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                  
                        </div>
                    <div class="col-sm-2">
                        <label class="control-label">
                            Ticket Wise
                        </label>
                    </div>
                    <div class="col-sm-2">
                      <div style="height:30px;" class="scrollable">
                          <asp:DropDownList ID="ddlTicketno" runat="server" CssClass="form-control" OnTextChanged="ddlTicketno_TextChanged" AutoPostBack="true">
                        </asp:DropDownList>

                       </div>
                    </div>

                   

                </div>
            </div>
        
                 <div class="form-group">
                    <div class="col-sm-12">
                       <div class="col-sm-2">
                        <label class="control-label">
                           Refund Amount
                        </label>
                    </div>
                    <div class="col-sm-2">
                               
             <asp:TextBox ID="txtRefundAmt" runat="server" CssClass="form-control" />

                    </div>
                        </div>
            </div>


            <div class="form-group">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label class="control-label">
                            Date<span class="style1">*</span>
                        </label>
                    </div>
                    <div class="col-sm-2">
                                <asp:TextBox ID="txtInvDate" runat="server" CssClass="form-control" MaxLength="50"  />
                        <asp:RequiredFieldValidator ControlToValidate="txtInvDate" runat="server" ID="rfvtxtInvDate" ValidationGroup="invoice"
                            ErrorMessage="Select Date" Text="Select Date" class="validationred" Display="Dynamic" ForeColor="Red" />
                    </div>

                    <div class="col-sm-2">
                        <label class="control-label">
                            Client Type<span class="style1">*</span>
                        </label>
                    </div>
                    <div class="col-sm-2">
                        <asp:DropDownList ID="drpInvClientType" runat="server" CssClass="form-control" OnTextChanged="drpInvClientType_TextChanged" AutoPostBack="true">
                            <asp:ListItem Text="" Value=""></asp:ListItem>
                        </asp:DropDownList>

                        <asp:RequiredFieldValidator ControlToValidate="drpInvClientType" runat="server" ID="RequiredFieldValidator1" ValidationGroup="invoice"
                            ErrorMessage="Select Client Type" Text="Select Client Type" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                    </div>
                    <div class="col-sm-2">
                        <label class="control-label">
                            Client <span class="style1">*</span>
                        </label>
                    </div>
                    <div class="col-sm-2">
                        <asp:DropDownList ID="drpInvClientName" runat="server" CssClass="form-control" OnTextChanged="drpInvClientName_TextChanged" AutoPostBack="true">
                            <asp:ListItem Text="--Select Client Name--" Value="-1" Selected="True"></asp:ListItem>
                         
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ControlToValidate="drpInvClientName" runat="server" ID="rfvdrpInvClientName" ValidationGroup="invoice"
                            ErrorMessage="Select Client Name" Text="Select Client Name" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="-1" />

                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label class="control-label">
                            Consultant<span class="style1">*</span>
                        </label>
                    </div>
                    <div class="col-sm-2">
                        <asp:DropDownList ID="ddlInvCosultant" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ControlToValidate="ddlInvCosultant" runat="server" ID="rfvdrpInvCosultant" ValidationGroup="invoice"
                            ErrorMessage="Select Consultant" Text="Select Consultant" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                    </div>

                    <div class="col-sm-2">
                        <label class="control-label">
                            Order<span class="style1">*</span>
                        </label>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox ID="txtInvOrder" runat="server" CssClass="form-control" MaxLength="5" />
                        <asp:RequiredFieldValidator ControlToValidate="txtInvOrder" runat="server" ID="rfvtxtInvOrder" ValidationGroup="invoice"
                            ErrorMessage="Enter Order Number" Text="Enter Order Number" class="validationred" Display="Dynamic" ForeColor="Red" />
                    </div>
                    <div class="col-sm-2">
                        <label class="control-label">
                            Booking No
                        </label>
                    </div>
                    <div class="col-sm-2">
                        <asp:TextBox ID="txtInvBookNo" runat="server" CssClass="form-control" MaxLength="50" />

                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label class="control-label">
                            Booking Source
                        </label>
                    </div>
                    <div class="col-sm-2">
                        <asp:DropDownList ID="drpInvBookingSrc" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                            <%--<asp:ListItem Text="--Select Booking Source--" Value="-1" Selected="True"></asp:ListItem>--%>
                        </asp:DropDownList>
                    </div>

                    <div class="col-sm-2">
                        <label class="control-label">
                            Booking Destination
                        </label>
                    </div>
                    <div class="col-sm-2">
                        <asp:DropDownList ID="drpInvBookDest" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                            <%--<asp:ListItem Text="--Select Booking Destination--" Value="-1" Selected="True"></asp:ListItem>--%>
                        </asp:DropDownList>

                    </div>
                </div>
            </div>
            <%-- model PopUp code Starts --%>
            <asp:UpdatePanel ID="updatepanelContacts" runat="server">
                <ContentTemplate>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-3"></div>
                            <div class="col-sm-5">

                                <button runat="server" id="btnOpenFP" class="btn btn-mini">
                                    <i class="fa fa-plane style1"></i>
                                </button>
                                <asp:Button ID="bntCancelFP"  runat="server" Text="Cancel" Style="display: none;" />
                                <%--<asp:Button ID="btnOpenFP" runat="server" Text="Open"  />--%>
                        &nbsp;&nbsp;&nbsp;
                         <button runat="server" id="btnLand" class="btn btn-mini">
                             <i class="fa  fa-university "></i>
                         </button>
                                &nbsp;&nbsp;
                         <button runat="server" id="btnserFee"  onserverclick="btnserFee_ServerClick"  class="btn btn-mini" title="Service Fee" >
                             <i class="fa fa-keyboard-o"></i>
                         </button>
                                &nbsp;&nbsp;
                         <%--<button runat="server" id="btnGencharge" onserverclick="btnGencharge_ServerClick" class="btn btn-mini" title="General Charge">
                             <i class="fa fa-cloud data-unicode"></i>
                         </button>--%>
                               &nbsp;&nbsp;
                         <button runat="server" id="btnACM" class="btn btn-mini style1"  title="Agency Credit Memo">
                             <i>ACM</i>
                         </button>
                                        &nbsp;&nbsp;
                         <button runat="server" id="btnADM" class="btn btn-mini" title="Agency Debit Memo">
                             <i>ADM</i>
                         </button>
                                        &nbsp;&nbsp;
                            </div>
                        </div>
                    </div>

                    <%-- AirTicket --%>

                            <cc1:ModalPopupExtender ID="VASPopupExtender" runat="server" TargetControlID="btnOpenFP"
                        BackgroundCssClass="popupextndrBg" BehaviorID="btnOpenFP" CancelControlID="bntCancelFP"
                        PopupControlID="pnlFlight">
                    </cc1:ModalPopupExtender>
                    <asp:Panel ID="pnlFlight" runat="server" CssClass="panelpopup " Width="1000px" Height="550px" Style="display: none;" BackgroundCssClass="modalBackground">
                        <div class="panelpopupheaderbox">
                            <%--<div style="float: right; padding-top: 3px; padding-right: 3px;">
                                <asp:ImageButton ID="cmdClose" runat="server" Height="20" Width="25" ImageUrl="~/images/close.png" OnClick="cmdClose_Click" />
                            </div>--%>
                        </div>
                        
                        <div id="popupdiv" class="modalBackground">
                           <header class="panel-heading">
                           <div style="padding-top: 3px; padding-right: 3px;">
                                            <asp:ImageButton ID="ImageButton5" CssClass="btncancle" runat="server" Height="20" Width="25" ImageUrl="~/images/close.png" OnClick="cmdClose_Click" />
                                            <h4 class="panel-title">AirTicket</h4>
                                        </div>
                                </header>
                                     <asp:HiddenField ID="hf_Air_TicketNo" runat="server" Value="0" />
                                     <asp:HiddenField ID="HiddenField1" runat="server" Value="0" />
                                     <asp:HiddenField ID="HiddenField2" runat="server" Value="0" />
                                     <asp:HiddenField ID="HiddenField3" runat="server" Value="0" />
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Ticket No<span class="style1">*</span>
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtAirTicketNo" runat="server" CssClass="form-control"  />
                                        <asp:RequiredFieldValidator ControlToValidate="txtAirTicketNo" runat="server" ID="rfvtxtAirTicketNo" ValidationGroup="airticket"
                                            ErrorMessage="Enter Ticket Number" Text="Enter Ticket Number" class="validationred" Display="Dynamic" ForeColor="Red" />
                                  
                          <%-- <asp:RegularExpressionValidator ControlToValidate="txtAirTicketNo" runat="server" ForeColor="Red"
                            ID="revtxtAirTicketNo" ValidationGroup="airticket" ErrorMessage="Enter Valid Ticket No."
                            Text="Enter Valid Ticket No." ValidationExpression="^[0-9]{10,15}$"
                            Display="Dynamic"></asp:RegularExpressionValidator>--%>

                                    </div>

                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Ticket Type
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:DropDownList ID="drpTicketType" runat="server" CssClass="form-control">
                                   
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ControlToValidate="drpTicketType" runat="server" ID="rfvdrpTicketType" ValidationGroup="airticket"
                                            ErrorMessage="Select Ticket Type" Text="Select Ticket Type" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="-1" />
                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            PNR<span class="style1">*</span>
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtPnr" runat="server" CssClass="form-control uppercase" MaxLength="6" />
                                        <asp:RequiredFieldValidator ControlToValidate="txtPnr" runat="server" ID="rfvtxtPnr" ValidationGroup="airticket"
                                            ErrorMessage="Enter Pnr" Text="Enter PNR" class="validationred" Display="Dynamic" ForeColor="Red" />

                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Air Line<span class="style1">*</span>
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:DropDownList ID="ddlAirLine" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlAirLine_SelectedIndexChanged" AutoPostBack="true">
                                            <%--<asp:ListItem Text="--Select Airline--" Value="-1" Selected="True"></asp:ListItem>--%>
                                        </asp:DropDownList>

                                        <asp:RequiredFieldValidator ControlToValidate="ddlAirLine" runat="server" ID="rfvddlAirLine" ValidationGroup="airticket"
                                                    ErrorMessage="Select Airline" Text="Select Airline" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />
                                   
                                    
                                    </div>

                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Passenger<span class="style1">*</span>
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="drpAirPassenger" runat="server" CssClass="form-control">
                                    
                                        </asp:TextBox>
                                        <asp:RequiredFieldValidator ControlToValidate="drpAirPassenger" runat="server" ID="rfvdrpAirPassenger" ValidationGroup="airticket"
                                                    ErrorMessage="Enter Passenger Name" Text="Enter Passenger Name" class="validationred" Display="Dynamic" ForeColor="Red" />

                                         <asp:RegularExpressionValidator ControlToValidate="drpAirPassenger" runat="server" ForeColor="Red"
                            ID="revdrpAirPassenger" ValidationGroup="airticket" ErrorMessage="Enter Only Characters."
                            Text="Enter Only Characters." ValidationExpression="[a-zA-Z][a-zA-Z ]+"
                            Display="Dynamic"></asp:RegularExpressionValidator>

                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Conjunction
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtAirConjunction" runat="server" CssClass="form-control" />

                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Service<span class="style1">*</span>
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:DropDownList ID="ddlAirService" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlAirService_SelectedIndexChanged" AutoPostBack="true">
                                            <%--<asp:ListItem Text="--Select Service--" Value="-1" Selected="True"></asp:ListItem>--%>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ControlToValidate="ddlAirService" runat="server" ID="rfvdrpAirService" ValidationGroup="airticket"
                                            ErrorMessage="Select Service" Text="Select Service" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />
                                    </div>

                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Type<span class="style1">*</span>
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:DropDownList ID="ddlType" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlType_SelectedIndexChanged" AutoPostBack="true">
                                            <%--<asp:ListItem Text="--Select Type--" Value="-1" Selected="True"></asp:ListItem>--%>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ControlToValidate="ddlType" runat="server" ID="rfvddlType" ValidationGroup="airticket"
                                            ErrorMessage="Select Type" Text="Select Type" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Routing<span class="style1">*</span>
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtAirRouting" runat="server" CssClass="form-control uppercase" OnTextChanged="txtAirRouting_TextChanged" AutoPostBack="true" />
                                        <asp:RequiredFieldValidator ControlToValidate="txtAirRouting" runat="server" ID="rfvtxtAirRouting" ValidationGroup="airticket"
                                            ErrorMessage="Enter Routing" Text="Enter Routing" class="validationred" Display="Dynamic" ForeColor="Red" />
                                    </div>
                                </div>
                            </div>

                            <div class="form-group"  id="divRouteHead" runat="server">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Routes
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Flight No
                                        </label>
                                    </div>

                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Class
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Date
                                        </label>

                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Miles
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtAirMiles" runat="server" CssClass="form-control" />

                                    </div>
                                </div>
                            </div>


                            <div class="form-group" id="divRouting" runat="server">
                                <div class="col-sm-12" id="divRoutingtxt" runat="server">
                                    <div class="col-sm-2" id="divlblRoute" runat="server">
                                        <%--<label class="control-label" id="lblRoutes1" runat="server"></label>--%>
                                        <asp:TextBox ID="lblRoutes1" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2" runat="server" id="divtxtFlightNo">
                                          <asp:TextBox ID="txtFlightNo1" runat="server" CssClass="form-control" />
                                                   <asp:RequiredFieldValidator ControlToValidate="txtFlightNo1" runat="server" ID="rfvtxtFlightNo1"
                                            ValidationGroup="airticket" ErrorMessage="Enter TASF MPD" Text="Enter Flight No" ForeColor="red" Display="Dynamic" />

                                    </div>

                                    <div class="col-sm-2" runat="server" id="divtxtClass" >

                                         <asp:TextBox ID="txtClass1" runat="server"  CssClass="form-control uppercase" MaxLength="2" />
                                                   <asp:RequiredFieldValidator ControlToValidate="txtClass1" runat="server" ID="rfvtxtClass1"
                                            ValidationGroup="airticket" ErrorMessage="Enter Class" Text="Enter Class" ForeColor="red" Display="Dynamic" />

                                    </div>
                                    <div class="col-sm-2" runat="server" id="divtxtDate">
                                          <asp:TextBox ID="txtDate1" runat="server" CssClass="form-control"  OnTextChanged="txtDate_TextChanged" AutoPostBack="true" placeholder="YYYY-MM-DD"/>
                                            <asp:RequiredFieldValidator ControlToValidate="txtDate1" runat="server" ID="rfvtxtDate1"
                                            ValidationGroup="airticket" ErrorMessage="Select Date" Text="Select Date" ForeColor="red" Display="Dynamic" />

                                           </div>

                                   
                                </div>

                                 <div class="col-sm-12" id="div1" runat="server">
                                     <div class="col-sm-2" id="div3" runat="server">
                                        <%--<label class="control-label" id="lblRoutes2" runat="server"></label>--%>
                                         <asp:TextBox ID="lblRoutes2" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                 <div class="col-sm-2" runat="server" id="divtxtFlightNo1">
                                          <asp:TextBox ID="txtFlightNo2" runat="server" CssClass="form-control" />
                                         <asp:RequiredFieldValidator ControlToValidate="txtFlightNo2" runat="server" ID="rfvtxtFlightNo2"
                                            ValidationGroup="airticket" ErrorMessage="Enter Flight No" Text="Enter Flight No" ForeColor="red" Display="Dynamic" />

                                      </div>

                                    <div class="col-sm-2" runat="server" id="divtxtClass1">

                                         <asp:TextBox ID="txtClass2" runat="server" CssClass="form-control uppercase" MaxLength="2"  />
                                              <asp:RequiredFieldValidator ControlToValidate="txtClass2" runat="server" ID="rfvtxtClass2"
                                            ValidationGroup="airticket" ErrorMessage="Enter Class" Text="Enter Class" ForeColor="red" Display="Dynamic" />

                                    </div>
                                    <div class="col-sm-2" runat="server" id="divtxtDate1">
                                          <asp:TextBox ID="txtDate2" runat="server" CssClass="form-control" placeholder="YYYY-MM-DD"  />
                                              <asp:RequiredFieldValidator ControlToValidate="txtDate2" runat="server" ID="rfvtxtDate2"
                                            ValidationGroup="airticket" ErrorMessage="Select Date" Text="Select Date" ForeColor="red" Display="Dynamic" />

                                    </div>

                                     </div>

                                 <div class="col-sm-12" id="div2" runat="server">
                                     <div class="col-sm-2" id="div4" runat="server">
                                        <%--<label class="control-label" id="lblRoutes3" runat="server"></label>--%>
                                         <asp:TextBox ID="lblRoutes3" runat="server" CssClass="form-control"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2" runat="server" id="divtxtFlightNo2">
                                          <asp:TextBox ID="txtFlightNo3" runat="server" CssClass="form-control" />

                                             <asp:RequiredFieldValidator ControlToValidate="txtFlightNo3" runat="server" ID="rfvtxtFlightNo3"
                                            ValidationGroup="airticket" ErrorMessage="Enter Flight No" Text="Enter Flight No" ForeColor="red" Display="Dynamic" />


                                    </div>

                                    <div class="col-sm-2" runat="server" id="divtxtClass2">

                                         <asp:TextBox ID="txtClass3" runat="server" CssClass="form-control uppercase" MaxLength="2" />

                                             <asp:RequiredFieldValidator ControlToValidate="txtClass3" runat="server" ID="rfvtxtClass3"
                                            ValidationGroup="airticket" ErrorMessage="Enter Class" Text="Enter Class" ForeColor="red" Display="Dynamic" />


                                    </div>
                                    <div class="col-sm-2" runat="server" id="divtxtDate2">
                                          <asp:TextBox ID="txtDate3" runat="server" CssClass="form-control"  placeholder="YYYY-MM-DD" />

                                             <asp:RequiredFieldValidator ControlToValidate="txtDate3" runat="server" ID="rfvtxtDate3"
                                            ValidationGroup="airticket" ErrorMessage="Enter Class" Text="Select Date" ForeColor="red" Display="Dynamic" />


                                    </div>
                            </div>

                                <div class="col-sm-12" id="div5" runat="server">
                                     <div class="col-sm-2" id="div6" runat="server">
                                        <%--<label class="control-label" id="lblRoutes4" runat="server"></label>--%>
                                         <asp:TextBox ID="lblRoutes4" runat="server" CssClass="form-control"> </asp:TextBox>
                                    </div>
                                 <div class="col-sm-2" runat="server" id="divtxtFlightNo3">
                                          <asp:TextBox ID="txtFlightNo4" runat="server" CssClass="form-control" />

                                        <asp:RequiredFieldValidator ControlToValidate="txtFlightNo4" runat="server" ID="rfvtxtFlightNo4"
                                            ValidationGroup="airticket" ErrorMessage="Enter Flight No" Text="Enter Flight No" ForeColor="red" Display="Dynamic" />


                                    </div>

                                    <div class="col-sm-2" runat="server" id="divtxtClass3">

                                         <asp:TextBox ID="txtClass4" runat="server" CssClass="form-control uppercase" MaxLength="2" />
                                           <asp:RequiredFieldValidator ControlToValidate="txtClass4" runat="server" ID="rfvtxtClass4"
                                            ValidationGroup="airticket" ErrorMessage="Enter Class" Text="Enter Class" ForeColor="red" Display="Dynamic" />


                                    </div>
                                    <div class="col-sm-2" runat="server" id="divtxtDate3">
                                          <asp:TextBox ID="txtDate4" runat="server" CssClass="form-control" placeholder="YYYY-MM-DD" />

                                           <asp:RequiredFieldValidator ControlToValidate="txtDate4" runat="server" ID="rfvtxtDate4"
                                            ValidationGroup="airticket" ErrorMessage="Select Date" Text="Select Date" ForeColor="red" Display="Dynamic" />

                                    </div>

                                </div>

                            </div>

                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Travel Date<span class="style1">*</span>
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtAirTravelDate" runat="server" CssClass="form-control" placeholder="YYYY-MM-DD" />
                                        <asp:RequiredFieldValidator ControlToValidate="txtAirTravelDate" runat="server" ID="rfvtxtAirTravelDate" ValidationGroup="airticket"
                                            ErrorMessage="Select Travel Date" Text="Select Travel Date" class="validationred" Display="Dynamic" ForeColor="Red" />
                                    </div>

                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Return Date
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtAirReturnDate" runat="server" CssClass="form-control" placeholder="YYYY-MM-DD" />
                                              </div>

                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Exclusive Fare<span class="style1">*</span>
                                        </label>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtAirExcluisvefare" runat="server" CssClass="form-control decimalRight" AutoPostBack="true" OnTextChanged="txtExcluisvefare_TextChanged" placeholder="0.00" />
                                        <asp:RequiredFieldValidator ControlToValidate="txtAirExcluisvefare" runat="server" ID="rfvtxtAirExcluisvefare" ValidationGroup="airticket"
                                            ErrorMessage="Enter Exclusive Amount" Text="Enter Exclusive Amount" class="validationred" Display="Dynamic" ForeColor="Red" />
                                  
                                        
               <asp:RegularExpressionValidator ID="revtxtAirExcluisvefare" ControlToValidate="txtAirExcluisvefare" runat="server" ForeColor="Red"
                  ErrorMessage="Enter only Numbers" Display="Dynamic" ValidationExpression="[0-9]*\.?[0-9]*"></asp:RegularExpressionValidator>

                                    </div>

                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Commision%
                                        </label>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtAirCommisionper" runat="server" CssClass="form-control decimalRight" placeholder="0.00" AutoPostBack="true" OnTextChanged="txtAirCommisionper_TextChanged" />
                                 
             <asp:RegularExpressionValidator ID="revtxtAirCommisionper" ControlToValidate="txtAirCommisionper" runat="server" ForeColor="Red"
                  ErrorMessage="Enter only Numbers" Display="Dynamic" ValidationExpression="[0-9]*\.?[0-9]*"></asp:RegularExpressionValidator>
                                    </div>

                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            VAT on Fare
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtVatPer" runat="server" CssClass="form-control decimalRight" placeholder="0.00" />
                                    </div>
                                    <div class="col-sm-2">

                                        <asp:TextBox ID="txtAirVatOnFare" runat="server" CssClass="form-control decimalRight" placeholder="0.00" />
                                    </div>

                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Commision(Exclusive)
                                        </label>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtAirCommExclu" runat="server" CssClass="form-control decimalRight" placeholder="0.00" />
                                    </div>

                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Airport Taxes
                                        </label>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtAirportTax" runat="server" CssClass="form-control decimalRight" placeholder="0.00" OnTextChanged="txtAirportTax_TextChanged" AutoPostBack="true" />
                                 
                                        <asp:RegularExpressionValidator ID="revtxtAirportTax" ControlToValidate="txtAirportTax" runat="server" ForeColor="Red"
                  ErrorMessage="Enter only Numbers" Display="Dynamic" ValidationExpression="[0-9]*\.?[0-9]*"></asp:RegularExpressionValidator>
               

                                    </div>

                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            VAT%
                                        </label>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtAirCommVat" runat="server" CssClass="form-control decimalRight" placeholder="0.00" />

                                    </div>

                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            VAT incl Taxes
                                        </label>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtAirVatinclTax" runat="server" CssClass="form-control decimalRight" placeholder="0.00" ReadOnly="true" />
                                    </div>

                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Agent VAT
                                        </label>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtAirAgentVat" runat="server" CssClass="form-control decimalRight" placeholder="0.00" />
                                    </div>

                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Client Total
                                        </label>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtAirClientTot" runat="server" CssClass="form-control decimalRight" placeholder="0.00" />
                                    </div>

                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Commision(inclusive)
                                        </label>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtAirCommInclu" runat="server" CssClass="form-control decimalRight" placeholder="0.00" />
                                    </div>

                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Payment
                                        </label>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:DropDownList ID="ddlAirPayment" runat="server" CssClass="form-control decimalRight">
                                            <asp:ListItem Text="--Select Payment--" Value="-1" Selected="True"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>

                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Due to BSP
                                        </label>
                                    </div>
                                    <div class="col-sm-4">
                                        <asp:TextBox ID="txtAirDueToBsp" runat="server" CssClass="form-control decimalRight" />
                                    </div>

                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-5">
                                </div>
                                <div class="col-sm-3">
                                    <asp:Button runat="server" ID="btnAirSubmit" OnClientClick="showProgress()" OnClick="btnAirSubmit_Click1" class="btn btn-primary" ValidationGroup="airticket"
                                        Text="Submit" />&nbsp;
                    <asp:Button runat="server" ID="btnCancel"
                        class="btn btn-danger" ValidationGroup=""  OnClick="btnCancel_Click" Text="Cancel" />

                                </div>
                            </div>

                            <div class="overlay">
                            <asp:UpdateProgress ID="UpdateProgress" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                <ProgressTemplate>
                                    <img src="../images/loading.gif" alt="" height="40" width="40" />
                                    <br />
                                    <h4>Please wait....</h4>
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </div>

                              
                        </div>
                    </asp:Panel>


                    <%-- Land Arrangemnts --%>

                    <cc1:ModalPopupExtender ID="landPopExtender" runat="server" TargetControlID="btnLand"
                        BackgroundCssClass="popupextndrBg" BehaviorID="btnLand" CancelControlID="bntCancelFP"
                        PopupControlID="landPanel">
                    </cc1:ModalPopupExtender>

                    <asp:Panel ID="landPanel" runat="server" CssClass="panelpopup modalBackground " Width="80%" Height="95%" Style="display: none;">
                        <div class="panelpopupheaderbox">
                            <%--<div style="float: right; padding-top: 3px; padding-right: 3px;">
                                <asp:ImageButton ID="ImageButton3" runat="server" Height="20" Width="25" ImageUrl="~/images/close.png" OnClick="cmdClose_Click" />
                            </div>--%>
                        </div>

                        <div class="form-group">
                            <header class="panel-heading">
                           <div style="padding-top: 3px; padding-right: 3px;">
                                            <asp:ImageButton ID="ImageButton3" CssClass="btncancle" runat="server" Height="20" Width="25" ImageUrl="~/images/close.png" OnClick="cmdClose_Click" />
                                            <h4 class="panel-title">Land Arrangements</h4>
                                        </div>
                                </header>
                                      <asp:HiddenField ID="hf_Land_TicketNo" runat="server" Value="0" />
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Land Supplier<span class="style1">*</span>
                                    </label>
                                </div>
                                <div class="col-sm-3">
                                    <asp:DropDownList ID="DDlandSupplier" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="DDlandSupplier_SelectedIndexChanged">
                                        <%--<asp:ListItem Text="--Select--" Value="-1" Selected="True"></asp:ListItem>--%>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ControlToValidate="DDlandSupplier" runat="server" ID="rfvDDlandSupplier" ValidationGroup="landsupplier"
                                        ErrorMessage="Select LandSupplier" Text="Select LandSupplier" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />
                                </div>
                                <div class="col-sm-1">
                                </div>
                                <div class="col-sm-2">
                                </div>
                                <div class="col-sm-3">
                                    <%-- <asp:TextBox ID="txtDivision" runat="server" CssClass="form-control" MaxLength="50" />--%>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Service<span class="style1">*</span>
                                    </label>
                                </div>
                                <div class="col-sm-3">
                                    <asp:DropDownList ID="DDlandService" runat="server" CssClass="form-control" AppendDataBoundItems="true" OnSelectedIndexChanged="DDlandService_SelectedIndexChanged" AutoPostBack="true">
                                         <%--<asp:ListItem Text="--Select--" Value="-1" Selected="True"></asp:ListItem>--%>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ControlToValidate="DDlandService" runat="server" ID="rfvDDlandService" ValidationGroup="landsupplier"
                                        ErrorMessage="Select Service" Text="Select Service" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />
                                </div>
                                <div class="col-sm-1"></div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Type<span class="style1">*</span>
                                    </label>
                                </div>
                                <%--<div class="col-sm-3">--%>
                                <div class="col-sm-3">
                                    <asp:DropDownList ID="DDlandType" runat="server" OnSelectedIndexChanged="DDType_SelectedIndexChanged" CssClass="form-control" AutoPostBack="true">
                                          </asp:DropDownList>
                                    <asp:RequiredFieldValidator ControlToValidate="DDlandType" runat="server" ID="rfvDDlandType" ValidationGroup="landsupplier"
                                        ErrorMessage="Select Type" Text="Select Type" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Passenger Name<span class="style1">*</span>
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                   
                                    <asp:TextBox ID="txtlandPassName" runat="server" CssClass="form-control" placeholder="Passenge Name" MaxLength="50" />
                                    <asp:RequiredFieldValidator ControlToValidate="txtlandPassName" runat="server" ID="rfvtxtlandPassName" ValidationGroup="landsupplier"
                                        ErrorMessage="Select Passenger" Text="Enter Passenger" class="validationred" Display="Dynamic" ForeColor="Red" />
                            
                                    <asp:RegularExpressionValidator ControlToValidate="txtlandPassName" runat="server" ForeColor="Red"
                            ID="revtxtlandPassName" ValidationGroup="airticket" ErrorMessage="Enter Only Characters."
                            Text="Enter Only Characters." ValidationExpression="[a-zA-Z][a-zA-Z ]+"
                            Display="Dynamic"></asp:RegularExpressionValidator>
                                    
                                    
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Travel Dates<span class="style1">*</span>
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <%--<asp:TextBox ID="txtlandTravelFrom" runat="server" CssClass="form-control" placeholder="mm/dd/yy" MaxLength="50" />--%>
                                     <asp:TextBox ID="txtlandTravelFrom" runat="server" CssClass="form-control"  />
                                    <asp:RequiredFieldValidator ControlToValidate="txtlandTravelFrom" runat="server" ID="rfvtxtlandTravelFrom" ValidationGroup="landsupplier"
                                        ErrorMessage="Select Travel Date" Text="Select Travel Date" class="validationred" Display="Dynamic" ForeColor="Red" />
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        to
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <%--<asp:TextBox ID="txtlandTravelto" runat="server" CssClass="form-control" placeholder="mm/dd/yy" MaxLength="50" />--%>
                                    <asp:TextBox ID="txtlandTravelto" runat="server" CssClass="form-control" placeholder="YYYY-MM-DD"  />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Booking Ref No<span class="style1">*</span>
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandBookingRef" runat="server" CssClass="form-control" placeholder="Book ref NO" MaxLength="50" />
                                    <asp:RequiredFieldValidator ControlToValidate="txtlandBookingRef" runat="server" ID="rfvtxtlandBookingRef" ValidationGroup="landsupplier"
                                        ErrorMessage="Enter Booking Ref No" Text="Enter Booking Ref No" class="validationred" Display="Dynamic" ForeColor="Red" />
                            
                                                           <asp:RegularExpressionValidator ID="revtxtlandBookingRef" ControlToValidate="txtlandBookingRef" runat="server" ForeColor="Red"
                  ErrorMessage="Enter only Numbers" Display="Dynamic" ValidationExpression="[0-9]*\.?[0-9]*"></asp:RegularExpressionValidator>

                                    
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Voucher
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandVocher" runat="server" CssClass="form-control" placeholder="Vocher No" MaxLength="50" />
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Supplier Ref No
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandSupplierRef" runat="server" CssClass="form-control" placeholder="Supplier Ref No" MaxLength="50" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Supplier Inv.No
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandSuppInvNo" runat="server" CssClass="form-control" placeholder="Supplier Invoice No" MaxLength="50" />
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Units
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandUnits" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" OnTextChanged="txtlandUnits_TextChanged" AutoPostBack="true" />

                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Commissionable(Excl)
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandcmblExcl" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" OnTextChanged="txtlandcmblExcl_TextChanged" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Total(Exclusive)<span class="style1">*</span>
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandTotalExcl" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" OnTextChanged="txtlandTotalExcl_TextChanged" AutoPostBack="true" />
                                    <asp:RequiredFieldValidator ControlToValidate="txtlandTotalExcl" runat="server" ID="rfvtxtlandTotalExcl" ValidationGroup="landsupplier"
                                        ErrorMessage="Enter TotalExclu" Text="Enter TotalExclu" class="validationred" Display="Dynamic" ForeColor="Red" />
                              
                                         <asp:RegularExpressionValidator ID="revtxtlandTotalExcl" ControlToValidate="txtlandTotalExcl" runat="server" ForeColor="Red"
                  ErrorMessage="Enter only Numbers" Display="Dynamic" ValidationExpression="[0-9]*\.?[0-9]*"></asp:RegularExpressionValidator>


                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Rate(Inclusive)
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandRateIncl" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" OnTextChanged="txtlandRateIncl_TextChanged" AutoPostBack="true" />
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Commission%
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandCommPer" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" OnTextChanged="txtlandCommPer_TextChanged" AutoPostBack="true" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        VAT
                                    </label>
                                </div>
                                <div class="col-sm-1">
                                    <asp:TextBox ID="txtLandExlVatPer" runat="server" CssClass="form-control decimalRight" placeholder="0.00" AutoPostBack="true">
                             <%--   <asp:ListItem Text="Select item" Value="0"></asp:ListItem>
                                <asp:ListItem Text="Test1" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Test2" Value="2"></asp:ListItem>--%>
                                    </asp:TextBox>


                                    <%--<asp:TextBox ID="txtVat" runat="server" CssClass="form-control" MaxLength="50" />--%>
                                    <%-- <asp:RegularExpressionValidator ID="revVat" runat="server" ControlToValidate="txtVat" ValidationExpression="^\d+" ErrorMessage="Enter Only Numbers" ForeColor="Red"></asp:RegularExpressionValidator>--%>
                                </div>
                                <div class="col-sm-1">
                                    <asp:TextBox ID="txtlandExclVatAmount" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" />
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Commissionable(Incl)
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandCmblIncl" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" />
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Commission(Excl)
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandCommExcl" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Total(Inclusive)
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandTotalIncl" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" OnTextChanged="txtlandTotalIncl_TextChanged" AutoPostBack="true" />
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Other Commissionable(Incl)
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandOtherCmblIncl" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" OnTextChanged="txtlandOtherCmblIncl_TextChanged" AutoPostBack="true" />
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        VAT%
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtLandVatPer" runat="server" CssClass="form-control decimalRight" AutoPostBack="true">
                                
                                    </asp:TextBox>
                                    <%-- <asp:TextBox ID="txtVatPer" runat="server" CssClass="form-control" MaxLength="50" />--%>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Payment
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:DropDownList ID="DDlandPayment" OnSelectedIndexChanged="DDlandPayment_SelectedIndexChanged" runat="server" CssClass="form-control" AutoPostBack="true">
                                    </asp:DropDownList>
                                    <%--  <asp:TextBox ID="txtPayment" runat="server" CssClass="form-control" MaxLength="50" />--%>
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Total Commissionable(Incl)
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandTotalcmblIncl" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" />
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        VAT Amount
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandVatAmount" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Credit Card
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:DropDownList ID="DDlandCreditCard" runat="server" CssClass="form-control ">
                                         <%--<asp:ListItem Text="--Select--" Value="-1" Selected="True"></asp:ListItem>--%>
                                    </asp:DropDownList>
                                    <%-- <asp:TextBox ID="txtCreditcard" runat="server" CssClass="form-control" MaxLength="50" />--%>
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Non Commissionable
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandNoncmbl" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" />
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Commission(Incl)
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandCommIncl" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Due from Client
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandDuefromclient" runat="server" CssClass="form-control  decimalRight" placeholder="0.00" MaxLength="50" />
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Less Commission
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandLessComm" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" />

                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Due to Supplier
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <asp:TextBox ID="txtlandDuetoSupplier" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" />

                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        CO2 Emission(actual)
                                    </label>
                                </div>
                                <div class="col-sm-1">
                                    <asp:TextBox ID="txtlandCO2" runat="server" CssClass="form-control decimalRight" placeholder="0.00" MaxLength="50" />
                                </div>
                                <div class="col-sm-1">
                                    <label class="control-label">
                                        Kgs
                                    </label>
                                </div>
                                <div class="col-sm-2">
                                    <%-- <label class="control-label">
                           Less Commission
                        </label>--%>
                                </div>
                                <div class="col-sm-2">
                                    <%-- <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" MaxLength="50" />--%>
                                </div>
                                <div class="col-sm-2">
                                    <%--  <label class="control-label">
                          Due to Supplier
                        </label>--%>
                                </div>
                                <div class="col-sm-2">
                                    <%-- <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" MaxLength="50" />--%>

                                    <%--hidden Fields Added--%>
                                    <input type="hidden" name="txtLandarrId" id="txtLandarrId" value="" />

                                    <%--END--%>
                                </div>
                            </div>
                        </div>


                        <div class="form-group">
                            <div class="col-sm-12">
                                <div class="col-sm-5">
                                </div>
                                <div class="col-sm-3">
                                      <asp:Button ID="LandArrSubmit" runat="server" class="btn btn-primary" OnClick="LandArrSubmit_Click" OnClientClick="showProgress()" Text="Submit" ValidationGroup="landsupplier" />&nbsp;&nbsp;
                                    <asp:Button ID="Cancle" runat="server" class="btn btn-danger" OnClick="Cancel_Click" Text="Cancel" />
                                </div>
                                <%--<div class="col-sm-4">

                                    <asp:Button ID="Reset" runat="server" class="btn btn-info" OnClick="Reset_Click" Text="Reset" />
                                </div>--%>
                            </div>
                        </div>

                         <div class="overlay">
                            <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                <ProgressTemplate>
                                    <img src="../images/loading.gif" alt="" height="40" width="40" />
                                    <br />
                                    <h4>Please wait....</h4>
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </div>


                    </asp:Panel>

                    <%-- Service Fee --%>

                    <cc1:ModalPopupExtender ID="SerPopupExtender"   runat="server" TargetControlID="btnserFee"
                        BackgroundCssClass="popupextndrBg" BehaviorID="btnserFee" CancelControlID="bntCancelFP"
                        PopupControlID="pnlServiceFee" >
                    </cc1:ModalPopupExtender>

                    <asp:Panel ID="pnlServiceFee"  runat="server" CssClass="panelpopup" Width="800px" Height="400px" Style="display: none;" BackgroundCssClass="modalBackground">
                        <div class="panelpopupheaderbox">
                            <%--<div style="float: right; padding-top: 3px; padding-right: 3px;">
                                <asp:ImageButton ID="ImageButton2" runat="server" Height="20" Width="25" ImageUrl="~/images/close.png" OnClick="cmdClose_Click" />
                            </div>--%>
                        </div>
                        <div id="Serpopupdiv"   class="modalBackground">

                            <div class="form-group">
                                <header class="panel-heading">
                                 <div style="padding-top: 3px; padding-right: 3px;">
                                            <asp:ImageButton ID="ImageButton2" CssClass="btncancle" runat="server" Height="20" Width="25" ImageUrl="~/images/close.png" OnClick="cmdClose_Click" />
                                            <h4 class="panel-title">Service Fee</h4>
                                        </div>
                                      </header>
                                          <asp:HiddenField ID="hf_SF_TicketNo" runat="server" Value="0" />
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Type<span class="style1">*</span></label>
                                    </div>
                                    <div class="col-sm-2">

                                        <asp:DropDownList ID="ddlServiceType" runat="server" Class="form-control" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlServiceType_SelectedIndexChanged">
                                            <%--<asp:ListItem Text="--Select Type--" Value="-1" Selected="True"></asp:ListItem>--%>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ControlToValidate="ddlServiceType" runat="server" ID="rfvddlServiceType" ValidationGroup="servicefee"
                                            ErrorMessage="Select Service Type" Text="Select Service Type" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />
                                    </div>
                                    <div class="col-sm-1">
                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Source Reference<span class="style1">*</span>
                                        </label>
                                    </div>

                                    <div class="col-sm-2">

                                        <asp:DropDownList ID="ddlSoureceref" runat="server" CssClass="form-control" AppendDataBoundItems="true" AutoPostBack="true" OnTextChanged="ddlSoureceref_TextChanged">
                                            <%--<asp:ListItem Text="--Select TicketNo--" Value="-1" Selected="True"></asp:ListItem>--%>
                                        </asp:DropDownList>
                                    </div>
                                    <asp:RequiredFieldValidator ControlToValidate="ddlSoureceref" runat="server" ID="rfvddlSoureceref" ValidationGroup="servicefee"
                                        ErrorMessage="Select Ticket Number" Text="Select Ticket Number" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />


                                    <div class="col-sm-1">
                                        <label class="control-label">
                                            Merge? 
                                        </label>
                                    </div>


                                    <div class="col-sm-2">

                                        <asp:CheckBox ID="chkMerge" runat="server" />

                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Travel Date<span class="style1">*</span></label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtSerTravelDate" runat="server" CssClass="form-control"  placeholder="YYYY-MM-DD"/>
                                         <%--<asp:TextBox ID="txtSerTravelDate" runat="server" CssClass="form-control" />--%>

                                        <asp:RequiredFieldValidator ControlToValidate="txtSerTravelDate" runat="server" ID="rfvtxtSerTravelDate"
                                            ValidationGroup="servicefee" ErrorMessage="Enter Travel Date." Text="Enter Travel Date." ForeColor="red" Display="Dynamic" />


                                    </div>
                                    <div class="col-sm-1">
                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Passenger Name<span class="style1">*</span>
                                        </label>
                                    </div>
                                    <div class="col-sm-2">

                                        <asp:DropDownList ID="ddlPassengerName" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                            <%--<asp:ListItem Text="--Select PaasengerName--" Value="-1" Selected="True"></asp:ListItem>--%>
                                        </asp:DropDownList>
                                        <%--<asp:RequiredFieldValidator ControlToValidate="ddlPassengerName" runat="server" ID="rfvddlPassengerName"
                                            ValidationGroup="servicefee" ErrorMessage="Select Passenger Name" Text="Select Passenger Name" ForeColor="red" Display="Dynamic" InitialValue="0" />--%>
                                    </div>

                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Exclusive Amount<span class="style1">*</span></label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtExclusAmount" runat="server" class="form-control" placeholder="0.00" Style="text-align: right;" ReadOnly="true"/>


                                        <asp:RequiredFieldValidator ControlToValidate="txtExclusAmount" runat="server" ID="rfvtxtExclusAmount" ValidationGroup="servicefee"
                                            ErrorMessage="Enter Exclusive Amount" Text="Enter Exclusive Amount" class="validationred" Display="Dynamic" ForeColor="Red" />
                                   
                                             <asp:RegularExpressionValidator ID="revtxtExclusAmount" ControlToValidate="txtExclusAmount" runat="server" ForeColor="Red"
                  ErrorMessage="Enter only Numbers" Display="Dynamic" ValidationExpression="[0-9]*\.?[0-9]*"></asp:RegularExpressionValidator>

                                    </div>


                                    <div class="col-sm-1">
                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Details
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtserDetails" runat="server" class="form-control" MaxLength="20" />

                                    </div>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            VAT(%)</label>
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:TextBox ID="txtSerVatPer" runat="server" class="form-control" Style="text-align: right; width: 60px;" ReadOnly="true" />
                                    </div>

                                    <div class="col-sm-1">
                                        <asp:TextBox ID="txtSerVatAmount" runat="server" class="form-control" ReadOnly="true" Style="text-align: right; width: 60px;" />

                                    </div>
                                    <div class="col-sm-1">
                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Payment Method<span class="style1">*</span>
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <%--<asp:DropDownList ID="ddlPaymentMethod" runat="server" CssClass="form-control" AppendDataBoundItems="true"  OnSelectedIndexChanged="ddlPaymentMethod_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Text="--Select  --" Value="-1" ></asp:ListItem>
                     </asp:DropDownList>--%>

                                        <asp:DropDownList ID="ddlPaymentMethod" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlPaymentMethod_SelectedIndexChanged" AutoPostBack="true"
                                            AppendDataBoundItems="true">
                                            <%--<asp:ListItem Value="-1" Text="-- Select Type --" />--%>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ControlToValidate="ddlPaymentMethod" runat="server" ID="rfvddlPaymentMethod"
                                            ValidationGroup="servicefee" ErrorMessage="Select Payment Type" InitialValue="0" Text="Select Payment Type" ForeColor="red" Display="Dynamic" />

                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Client Total</label>
                                    </div>
                                    <div class="col-sm-2">

                                        <asp:TextBox ID="txtSerClientTotal" runat="server" class="form-control" placeholder="0.00" Style="text-align: right;" OnTextChanged="txtSerClientTotal_TextChanged" AutoPostBack="true"  />

                                    </div>
                                    <div class="col-sm-1">
                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            CreditCard Type
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:DropDownList ID="ddlCreditCardType" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                            <%--<asp:ListItem Text="--Select Type--" Value="-1"></asp:ListItem>--%>
                                        </asp:DropDownList>

                                        <asp:RequiredFieldValidator ControlToValidate="ddlCreditCardType" runat="server" ID="rfvddlCreditCardType"
                                            ValidationGroup="servicefee" ErrorMessage="Select CreditCard Type" InitialValue="0" Text="Select CreditCard Type" ForeColor="red" Display="Dynamic" />

                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <div class="col-sm-12">
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            Collect Via</label>
                                    </div>
                                    <div class="col-sm-2">

                                        <asp:DropDownList ID="ddlCollectVia" runat="server" CssClass="form-control" AppendDataBoundItems="true" AutoPostBack="true" OnSelectedIndexChanged="ddlCollectVia_SelectedIndexChanged">
                                            <%--<asp:ListItem Text="--Select--" Value="-1"></asp:ListItem>--%>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ControlToValidate="ddlCollectVia" runat="server" ID="rfvddlCollectVia"
                                            ValidationGroup="servicefee" ErrorMessage="Select Collect Via" InitialValue="0" Text="Select Collect Via" ForeColor="red" Display="Dynamic" />

                                    </div>
                                    <div class="col-sm-1">
                                    </div>
                                    <div class="col-sm-2">
                                        <label class="control-label">
                                            TASF MPD
                                        </label>
                                    </div>
                                    <div class="col-sm-2">
                                        <asp:TextBox ID="txtTASFMPD" runat="server" class="form-control" />
                                        <asp:RequiredFieldValidator ControlToValidate="txtTASFMPD" runat="server" ID="rfvtxtTASFMPD"
                                            ValidationGroup="servicefee" ErrorMessage="Enter TASF MPD" Text="Enter TASFMPD" ForeColor="red" Display="Dynamic" />

                                    </div>
                                </div>

                            </div>


                            <div class="form-group">
                                <div class="col-sm-5">
                                </div>
                                <div class="col-sm-3">
                                    <asp:Button runat="server" ID="SerSubmit" class="btn btn-primary" OnClientClick="showProgress()" ValidationGroup="servicefee"
                                        Text="Submit" OnClick="ServFee_click" />&nbsp;
                    <asp:Button runat="server" ID="SerCancel"
                        class="btn btn-danger" ValidationGroup="" Text="Cancel" OnClick="btnSerCancel_Click" />


                                </div>
                            </div>


                            <div class="overlay">
                            <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                <ProgressTemplate>
                                    <img src="../images/loading.gif" alt="" height="40" width="40" />
                                    <br />
                                    <h4>Please wait....</h4>
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </div>
                        </div>
                    </asp:Panel>

                     <%-- ACM --%>

                            <cc1:ModalPopupExtender ID="ACMModalPopupExtender" runat="server" TargetControlID="btnACM"
                                BackgroundCssClass="popupextndrBg" BehaviorID="btnACM" CancelControlID="bntCancelFP"
                                PopupControlID="pnlACM">
                            </cc1:ModalPopupExtender>
                            <asp:Panel ID="pnlACM" runat="server" CssClass="panelpopup" Width="800px" Height="400px" Style="display: none;" BackgroundCssClass="modalBackground">
                                <div class="panelpopupheaderbox">
                                    <%--<div style="float: right; padding-top: 3px; padding-right: 3px;">
                                <asp:ImageButton ID="ImageButton2" runat="server" Height="20" Width="25" ImageUrl="~/images/close.png" OnClick="cmdClose_Click" />
                            </div>--%>
                                </div>
                                <div id="ACMpopupdiv" class="modalBackground">

                                    <%--  --%>
                                    <header class="panel-heading">

                                        <h2 class="panel-title">Agency Credit Memo</h2>
                                    </header>
                                      <asp:HiddenField ID="hf_ACM_TicketNo" runat="server" Value="0" />
                                    <div class="panel-body">
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        ACM No
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:TextBox ID="txtACMNO" runat="server" CssClass="form-control" MaxLength="50" />
                                                </div>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label>
                                                        Ticket No
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                                    <%--<asp:TextBox ID="txtACMTicketNO" runat="server" CssClass="form-control" MaxLength="50" />--%>
                                               
                                                    
                                                    <asp:DropDownList ID="ddlACMTicketNO" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlACMTicketNO_SelectedIndexChanged" AutoPostBack="true">
                                                    </asp:DropDownList>
                                                     </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Supplier
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:DropDownList ID="DDLACMSupplier" runat="server" CssClass="form-control" >
                                                    </asp:DropDownList>
                                                </div>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Type
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:DropDownList ID="DDLACMType" runat="server" CssClass="form-control" AutoPostBack="true">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <%--<div class="col-sm-2">
                            <label class="control-label">
                               Type
                            </label>
                        </div>
                        <div class="col-sm-3">
                          
                            <asp:DropDownList ID="DDLType" runat="server" CssClass="form-control" AutoPostBack="true">
                              
                            </asp:DropDownList>
                        </div>--%>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label>
                                                        Pax Name
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                                    <asp:TextBox ID="txtACMPassengerName" ReadOnly="true" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
                                                    <%--<asp:DropDownList ID="DDLPassengerName" runat="server" CssClass="form-control" AutoPostBack="true">
                              
                            </asp:DropDownList>--%>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Exclusive Fire
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:TextBox ID="txtACMExclFire" ReadOnly="true" runat="server" Style="text-align: right" OnTextChanged="txtACMExclFire_TextChanged" CssClass="form-control" MaxLength="50" AutoPostBack="true" />
                                                </div>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label>
                                                        Commission
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                                    <asp:TextBox ID="txtACMCommission" ReadOnly="true" runat="server" Style="text-align: right" OnTextChanged="txtACMCommission_TextChanged" CssClass="form-control" MaxLength="50" AutoPostBack="true" />
                                                </div>
                                            </div>
                                        </div>

                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Fare Vat
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                              
                                                     <asp:TextBox ID="txtFareVat" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50" ReadOnly="true"/>
                                                </div>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label>
                                                        VAT
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                                    <asp:TextBox ID="txtACMagentVat" ReadOnly="true" runat="server" Style="text-align: right" OnTextChanged="txtACMagentVat_TextChanged" CssClass="form-control" MaxLength="50" AutoPostBack="true" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Departure Taxes
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:TextBox ID="txtACMDepTaxes" OnTextChanged="txtACMDepTaxes_TextChanged" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50" AutoPostBack="true" />
                                                </div>
                             
                                                <div class="col-sm-2">
                                                    <label>
                                                        BSP
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                                    <asp:TextBox ID="txtACMBSP" ReadOnly="true" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div  class="col-sm-5"></div>
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Client Total
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:TextBox ID="txtACMClientTotal" ReadOnly="true" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50" />
                                            
                                                              <asp:TextBox ID="txtACMInVid" ReadOnly="true" Style="text-align: right;display:none" runat="server" CssClass="form-control" MaxLength="50" />
                                          
                                                        </div>
                                           

                                            </div>
                                        <br />
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-3">

                                                    <asp:Button ID="ACMSubmit" runat="server" OnClick="ACMSubmit_Click" class="btn btn-success" Text="Submit" />
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:Button ID="ACMCancel" runat="server" OnClick="Cancel_Click1" class="btn btn-danger" Text="Cancel" />
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:Button ID="ACMReset" runat="server" class="btn btn-info" Text="Reset" />
                                                </div>

                                            </div>
                                        </div>
                                    
                                    <%--  --%>
                                    <div class="overlay">
                                        <asp:UpdateProgress ID="UpdateProgress3" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                            <ProgressTemplate>
                                                <img src="../images/loading.gif" alt="" height="40" width="40" />
                                                <br />
                                                <h4>Please wait....</h4>
                                            </ProgressTemplate>
                                        </asp:UpdateProgress>
                                    </div>
                                </div>
                                    </div>
                                
                            </asp:Panel>

                            <%-- End ACM --%>

                            <%-- ADM --%>

                            <cc1:ModalPopupExtender ID="ADMModalPopupExtender" runat="server" TargetControlID="btnADM"
                                BackgroundCssClass="popupextndrBg" BehaviorID="btnADM" CancelControlID="bntCancelFP"
                                PopupControlID="pnlADM">
                            </cc1:ModalPopupExtender>
                            <asp:Panel ID="pnlADM" runat="server" CssClass="panelpopup" Width="800px" Height="400px" Style="display: none;" BackgroundCssClass="modalBackground">
                                <div class="panelpopupheaderbox">
                                    <%--<div style="float: right; padding-top: 3px; padding-right: 3px;">
                                <asp:ImageButton ID="ImageButton2" runat="server" Height="20" Width="25" ImageUrl="~/images/close.png" OnClick="cmdClose_Click" />
                            </div>--%>
                                </div>
                                <div id="ADMpopupdiv" class="modalBackground">

                                    <%--  --%>

                                    <header class="panel-heading">

                                        <h2 class="panel-title">Agency Debit Memo</h2>
                                    </header>
                                      <asp:HiddenField ID="hf_ADM_TicketNo" runat="server" Value="0" />

                                    <div class="panel-body">
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        ADM No
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:TextBox ID="txtADMNO" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50" />
                                                </div>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label>
                                                        Ticket No
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                                    <asp:TextBox ID="txtADMTicketNO" runat="server" CssClass="form-control" MaxLength="50" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Supplier
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:DropDownList ID="DDLADMSupplier" runat="server" CssClass="form-control" >
                                                    </asp:DropDownList>
                                                </div>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Type
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:DropDownList ID="DDLADMType" runat="server" OnSelectedIndexChanged="DDLADMType_SelectedIndexChanged" CssClass="form-control" AutoPostBack="true">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <%--<div class="col-sm-2">
                            <label class="control-label">
                               Type
                            </label>
                        </div>
                        <div class="col-sm-3">
                          
                            <asp:DropDownList ID="DDLType" runat="server" CssClass="form-control" AutoPostBack="true">
                              
                            </asp:DropDownList>
                        </div>--%>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label>
                                                        Passenger Name
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                                    <asp:TextBox ID="txtADMPassengerName" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
                                                    <%--<asp:DropDownList ID="DDLPassengerName" runat="server" CssClass="form-control" AutoPostBack="true">
                              
                            </asp:DropDownList>--%>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Exclusive Fire
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:TextBox ID="txtADMExclFire" Style="text-align: right" OnTextChanged="txtADMExclFire_TextChanged" runat="server" AutoPostBack="true" CssClass="form-control" MaxLength="50" />
                                                </div>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label>
                                                        Commission
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                                    <asp:TextBox ID="txtADMCommission" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50" OnTextChanged="txtADMCommission_TextChanged" AutoPostBack="true" />
                                                </div>
                                            </div>
                                        </div>

                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Fare Vat
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                                    <asp:DropDownList ID="DDLADMFarevat" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="DDLADMFarevat_TextChanged">
                                                    </asp:DropDownList>
                                                    <%-- <asp:TextBox ID="txtFareVat" runat="server" CssClass="form-control" MaxLength="50" />--%>
                                                </div>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label>
                                                        Agent VAT
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                                    <asp:TextBox ID="txtADMVat" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50" OnTextChanged="txtADMVat_TextChanged" AutoPostBack="true" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Airport Taxes
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:TextBox ID="txtADMDepTaxes" OnTextChanged="txtADMDepTaxes_TextChanged" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50" AutoPostBack="true" />
                                                </div>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label class="control-label">
                                                        Client Total
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:TextBox ID="txtADMClientTotal" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50" />
                                                </div>
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-sm-12">
                                              <%--  <div class="col-sm-2">
                                                    <label class="control-label">
                                                        CreditCard
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:DropDownList ID="DDLADMCreditCard" runat="server" CssClass="form-control">
                                                    </asp:DropDownList>
                                                    <%--<asp:TextBox ID="txtCrediCard" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50" />
                                                </div>--%>
                                                <%--     <div class="col-sm-1">
                        </div>--%>
                                                <div class="col-sm-2">
                                                    <label>
                                                        BSP
                                                    </label>
                                                </div>
                                                <div class="col-sm-3">
                                                    <asp:TextBox ID="txtADMBSP" Style="text-align: right" runat="server" CssClass="form-control" MaxLength="50" />
                                                </div>

                                            </div>
                                        </div>




                                        <div class="form-group">
                                            <div class="col-sm-12">
                                                <div class="col-sm-3">

                                                    <asp:Button ID="ADMSubmit" runat="server" class="btn btn-success" OnClick="ADMSubmit_Click" Text="Submit" />
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:Button ID="ADMCancel" runat="server" class="btn btn-danger" Text="Cancel" />
                                                </div>
                                                <div class="col-sm-3">

                                                    <asp:Button ID="ADMReset" runat="server" class="btn btn-info" Text="Reset" />
                                                </div>

                                            </div>
                                        </div>
                                    </div>


                                    <%--  --%>
                                    <div class="overlay">
                                        <asp:UpdateProgress ID="UpdateProgress5" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                            <ProgressTemplate>
                                                <img src="../images/loading.gif" alt="" height="40" width="40" />
                                                <br />
                                                <h4>Please wait....</h4>
                                            </ProgressTemplate>
                                        </asp:UpdateProgress>
                                    </div>
                                </div>
                            </asp:Panel>

                            <%--End ADM  --%>


                 
                    <asp:Panel ID="InvGridView" runat="server">
                        <div class="col-sm-12">
                            <div class="col-sm-8">
                                <asp:HiddenField ID="hf_InvListId" runat="server" Value="0" />
                                 <%--       <div style ="height:200px; width:617px; overflow:auto;">--%>
                                <asp:GridView ID="InvListGrid" runat="server" AllowPaging="true" Width="100%" PageSize="15"
                                            AutoGenerateColumns="False" HeaderStyle-BackColor="#0088cc" HeaderStyle-CssClass="test"
                                     DataKeyNames="Type,TicketId,Invid" CssClass="table table-striped table-bordered"
                                    ShowHeaderWhenEmpty="true" OnRowCommand="InvListGrid_RowCommand" OnRowDataBound="InvListGrid_RowDataBound">
                                            <PagerStyle HorizontalAlign="Left" CssClass="pagination1" />

                                    <Columns>
                                         <asp:TemplateField HeaderText="SN" HeaderStyle-CssClass="hiddencol" ItemStyle-CssClass="hiddencol" >
                                        <ItemTemplate >
                                            <asp:HiddenField ID="hfInvId" runat="server" Value='<%#Eval("Invid")%>' />
                                            <asp:HiddenField ID="hfTicketId" runat="server" Value='<%#Eval("TicketId")%>' />
                                              <asp:HiddenField ID="hfType" runat="server" Value='<%#Eval("Type")%>' />
                                            <%--<%# Container.DataItemIndex+1 %>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Type">
                                            <ItemTemplate>
                                                <%#Eval("Type")%>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Details">
                                            <ItemTemplate>
                                                <%#Eval("Details")%>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Client Total" ItemStyle-HorizontalAlign="Right">
                                            <ItemTemplate>
                                                <%#Eval("ClientTotal")%>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                          <asp:TemplateField HeaderText="Commission Total" HeaderStyle-CssClass="hiddencol" ItemStyle-CssClass="hiddencol">
                                            <ItemTemplate>
                                                <%#Eval("Comminclu")%>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Commission Exclusi" HeaderStyle-CssClass="hiddencol" ItemStyle-CssClass="hiddencol">
                                            <ItemTemplate>
                                                <%#Eval("CommiExclu")%>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Commission VatAmount" HeaderStyle-CssClass="hiddencol" ItemStyle-CssClass="hiddencol">
                                            <ItemTemplate>
                                                <%#Eval("CommiVatamount")%>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                               <asp:TemplateField  HeaderText="ThisEntry" ItemStyle-Width="100px" ItemStyle-HorizontalAlign="Right" >
                                                    <ItemTemplate>
                                            
                                              <asp:HiddenField ID="hfAllocatedAmount" runat="server" Value="0" />

                                            <asp:TextBox style="width:100px" ID="txtThisEntry" runat="server" CssClass="form-control" OnTextChanged="txtThisEntry_TextChanged" AutoPostBack="true"
                                                 ValidationGroup=""></asp:TextBox>
                                            <asp:RegularExpressionValidator ControlToValidate="txtThisEntry" runat="server" ID="rextxtThisEntry" ValidationGroup=""
                                                ErrorMessage="Enter  number only." Text="Enter  number only."
                                                ValidationExpression="^\-?[0-9]+(?:\.[0-9]+)?" class="validationred" Display="Dynamic"></asp:RegularExpressionValidator>
                                                    </ItemTemplate>


                                        </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Invoice Id" HeaderStyle-CssClass="hiddencol" ItemStyle-CssClass="hiddencol">
                                            <ItemTemplate>
                                                <%#Eval("Invid")%>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Refund Amount" HeaderStyle-CssClass="hiddencol" ItemStyle-CssClass="hiddencol">
                                            <ItemTemplate>
                                                <%#Eval("RefundAmount")%>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                    </Columns>
                                    <EmptyDataTemplate>No Record Available</EmptyDataTemplate>
                                </asp:GridView>

                                           <%-- </div>--%>
                            </div>
                            <div class="col-sm-4">
                               
                                &nbsp;&nbsp;
                                <div class="btncancle">
                                  <asp:Label ID="LBLInvoiceTotalAmount" runat="server"  Font-Bold="true" ForeColor="#666666">Invoice Total:</asp:Label>
                                &nbsp;
                                    <asp:Label ID="txtInvoiceTotalAmount" ForeColor="#ff0000" runat="server" Font-Bold="true"></asp:Label>
                                      </div>
                                 <asp:Label ID="lblcommissionInclu" runat="server" Font-Bold="true" class="hiddencol"></asp:Label>

                                 <asp:Label ID="lblcommissionExclu" runat="server" Font-Bold="true" class="hiddencol"></asp:Label>
                                 <asp:Label ID="lblcommissionVatamt" runat="server" Font-Bold="true" class="hiddencol"></asp:Label>

                                   <asp:Label ID="lblaircommiinclu" runat="server" Font-Bold="true" class="hiddencol"></asp:Label>

                                 <asp:Label ID="lbllandcommiInclu" runat="server" Font-Bold="true" class="hiddencol"></asp:Label>
                                 <asp:Label ID="lblservcommi" runat="server" Font-Bold="true" class="hiddencol"></asp:Label>

                                     <asp:Label ID="lblaircommType" runat="server" Font-Bold="true" class="hiddencol"></asp:Label>

                                 <asp:Label ID="lbllandcommType" runat="server" Font-Bold="true" class="hiddencol"></asp:Label>
                                 <asp:Label ID="lblsercommType" runat="server" Font-Bold="true" class="hiddencol"></asp:Label>
                                 <asp:Label ID="lblInvoiceRefundAmt" runat="server" Font-Bold="true" class="hiddencol"></asp:Label>
                            </div>

                        </div>
                        <div class="col-sm-12">
                            <div class="col-sm-8">
                            </div>
                            <div class="col-sm-4">
                            </div>
                        </div>
                    </asp:Panel>
                    <br>
                    <br /><br />
                    <%-- model PopUp code End --%>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">
                                    Messages
                                </label>
                            </div>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlInvMesg" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                    <%--<asp:ListItem Text="--Select Message Type--" Value="-1" Selected="True"></asp:ListItem>--%>
                                </asp:DropDownList>
                            </div>

                            <div class="col-sm-4">
                                        <asp:TextBox TextMode="MultiLine" CssClass="form-control" ID="txtInvClntMesg" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-sm-2">
                                <label class="control-label">
                                    Print Style
                                </label>
                            </div>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlInvPdfPrintStyle" runat="server" CssClass="form-control">
                                    <%--<asp:ListItem Text="--Select Print Style--" Value="-1" Selected="True"></asp:ListItem>--%>
                                </asp:DropDownList>



                            </div>
                        </div>
                    </div>

                  


                    <div class="form-group">
                        <div class="col-sm-5">
                        </div>
                        <div class="col-sm-5">
                            <asp:Button runat="server" ID="btnInvSave" class="btn btn-primary green" ValidationGroup="invoice" OnClientClick="showProgress()"
                                Text="Submit" OnClick="btnInvSave_Click" />&nbsp;
                              <%--<asp:Button ID="btnACAnalysis" runat="server" CssClass=" btn btn-info" ValidationGroup="analysis" Text="A/C Analysis" />--%>
                            <asp:Button runat="server" ID="btnInvCancel"
                                class="btn btn-primary red" ValidationGroup="" Text="Cancel" onclick="btnInvCancel_Click"/>
                            <%-- <asp:Button runat="server" ID="Button1"
                                class="btn btn-primary red" ValidationGroup="" Text="DraftPdf" OnClick="btnDraftPdf_Click" />--%>
                        </div>
                       <%-- <div class="col-sm-3">
                            <asp:Button runat="server" ID="btnDraftPdf"
                                class="btn btn-primary red" ValidationGroup="" Text="DraftPdf" OnClick="btnDraftPdf_Click" />
                        </div>--%>
                    </div>

                     <div class="overlay">
                            <asp:UpdateProgress ID="UpdateProgress4" runat="server" AssociatedUpdatePanelID="updatepanel1">
                                <ProgressTemplate>
                                    <img src="../images/loading.gif" alt="" height="40" width="40" />
                                    <br />
                                    <h4>Please wait....</h4>
                                </ProgressTemplate>
                            </asp:UpdateProgress>
                        </div>

                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </section>

               </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
