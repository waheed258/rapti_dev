<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="CashBookType.aspx.cs" Inherits="User_CashBookType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <style type="text/css">
        .style1 {
            color: #FF0000;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
 <div id="content-header">
        <%--   <div id="breadcrumb"><a href="#" title="Go to Home" class="tip-bottom"><i class="icon-home"></i>Branch Master</a></div>--%>
        <div id="breadcrumb">
            <a href="~/Users/Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">Cash Book Type Master</a>
        </div>
    </div>

    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-align-justify"></i></span>
                        <h5>New Cash Book Type</h5>
                    </div>
                    <div class="widget-content">
                        <div class="controls">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            <asp:HiddenField ID="hf_CashBookId" runat="server" Value="0" />
                   

                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Key(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtCashKey" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtCashKey" runat="server" ID="rfvtxtCashKey" ValidationGroup="cash"
                                    ErrorMessage="Enter Key" Text="Enter Key" class="validationred" Display="Dynamic" ForeColor="Red" />
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span1 m-wrap">Deactivate </label>
                            <div class="span1 m-wrap">
                                <asp:CheckBox ID="chkDeactivate" runat="server" />
                            </div>
                        

                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Description(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtCashDescription" runat="server" CssClass="form-control" MaxLength="30" />
                                      <asp:RequiredFieldValidator ControlToValidate="txtCashDescription" runat="server" ID="rfvtxtCashDescription" ValidationGroup="cash"
                                    ErrorMessage="Enter Description" Text="Enter Description" class="validationred" Display="Dynamic" ForeColor="Red" />
                              <asp:RegularExpressionValidator ControlToValidate="txtCashDescription" runat="server" ForeColor="Red"
                                    ID="revtxtCashDescription" ValidationGroup="cash" ErrorMessage="Enter Only Characters."
                                    Text="Enter Only Characters." ValidationExpression="[a-zA-Z][a-zA-Z ]+"
                                    Display="Dynamic"></asp:RegularExpressionValidator>

                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Default Action</label>
                            <div class="span3 m-wrap">
                               <asp:DropDownList ID="dropDefaultAction" runat="server" CssClass="form-control" AppendDataBoundItems="true" >
                                    <asp:ListItem Text="--Select--" Value="0" Selected="True"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Default GI Code(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtGICode" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtGICode" runat="server" ID="rfvtxtGICode" ValidationGroup="cash"
                                    ErrorMessage="Enter Default GI Code" Text="Enter Default GI Code" class="validationred" Display="Dynamic" ForeColor="Red" />
                                       <asp:RegularExpressionValidator ControlToValidate="txtGICode" runat="server" ForeColor="Red"
                                    ID="revtxtGICode" ValidationGroup="cash" ErrorMessage="Enter Only Numbers."
                                    Text="Enter Only Numbers." ValidationExpression="^(0|[1-9]\d*)$"
                                    Display="Dynamic"></asp:RegularExpressionValidator>
                            
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Format For Numeric References</label>
                            <div class="span3 m-wrap">
                               <asp:TextBox ID="txtRefFormat" runat="server" CssClass="form-control" MaxLength="50" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Allowable VAT Codes</label>
                            <div class="span2 m-wrap">
                            <asp:TextBox ID="txtVatCodes" runat="server" CssClass="form-control" MaxLength="50" />
                            
                            </div>
                       
                        </div>


                          <div class="form-actions">
                            <div class="span5 m-wrap"></div>
                            <div class="span4 m-wrap">
       <asp:Button ID="cmdSubmit" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="cmdSubmit_Click" ValidationGroup="cash" />
                                <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-danger" OnClick="btnCancel_Click" Text="Cancel" />
                                <asp:Button ID="btnreset" runat="server" CssClass="btn btn-info" OnClick="btnreset_Click" Text="Reset" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

</asp:Content>

