<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="BankAccount.aspx.cs" Inherits="User_BankAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
       <style type="text/css">
        .style1 {
            color: #FF0000;
        }

    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div id="content-header">       
        <div id="breadcrumb">
            <a href="~/Users/Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">BankAccount Master</a>
        </div>
    </div>

      <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-align-justify"></i></span>
                        <h5>New BankAccount</h5>
                    </div>
                    <div class="widget-content">
                        <div class="controls">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            <asp:HiddenField ID="hf_BankAccountId" runat="server" Value="0" />
                

                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Key(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtBankKey" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtBankKey" runat="server" ID="rfvtxtBankKey" ValidationGroup="bank"
                                    ErrorMessage="Enter Bank Key" Text="Enter Bank Key" class="validationred" Display="Dynamic" ForeColor="Red" />
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span1 m-wrap">DeActivate </label>
                            <div class="span1 m-wrap">
                                <asp:CheckBox ID="chkIsactive" runat="server" />
                            </div>
                        </div>

                           <div class="controls controls-row">
                            <label class="span2 m-wrap">Account Name(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtAccName" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtAccName" runat="server" ID="rfvtxtAccName" ValidationGroup="bank"
                                    ErrorMessage="Enter Account Name" Text="Enter Account Name" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Account Type</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtBankAccType" runat="server"  CssClass="form-control"  />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Account Number(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtBankAccNo" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtBankAccNo" runat="server" ID="rfvtxtBankAccNo" ValidationGroup="bank"
                                    ErrorMessage="Enter Account No" Text="Enter Account No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Branch Code(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtBranchCode" runat="server"  CssClass="form-control" />
                                   <asp:RequiredFieldValidator ControlToValidate="txtBranchCode" runat="server" ID="rfvtxtBranchCode" ValidationGroup="bank"
                                    ErrorMessage="Enter Branch Code" Text="Enter Branch Code" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Branch Name(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtBranchName" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtBranchName" runat="server" ID="rfvtxtBranchName" ValidationGroup="bank"
                                    ErrorMessage="Enter Branch Name" Text="Enter Branch Name" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Account Holder</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtbankAccHolder" runat="server"  CssClass="form-control" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Graphic</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtGraphic" runat="server" CssClass="form-control" MaxLength="30" />
                           
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Owner Branch(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                  <asp:DropDownList ID="DDLOwnerBranch" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLOwnerBranch" runat="server" ID="rfvDDLOwnerBranch" ValidationGroup="bank"
                                    ErrorMessage="Select Branch" Text="Select Branch" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">QuickGi Code</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtQuickGiCode" runat="server" CssClass="form-control" MaxLength="3" />
                           
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">QuickGi Deposits Batch</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtQuickGiDepBatch" runat="server" CssClass="form-control" MaxLength="3" />
                            </div>
                        </div>

                       <div class="controls controls-row">
                            <label class="span2 m-wrap">QuickGi Payment Batch</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtQuickGiPayBatch" runat="server" CssClass="form-control" MaxLength="3" />
                           
                            </div>
                        
                        </div>

                             <div class="form-actions">
                            <div class="span5 m-wrap"></div>
                            <div class="span4 m-wrap">
                                <asp:Button ID="Submit_BankAccount" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="Submit_BankAccount_Click" ValidationGroup="bank" />
                                <asp:Button ID="Cancel_BankAccount" runat="server" CssClass="btn btn-danger" OnClick="Cancel_BankAccount_Click" Text="Cancel" />
                                <asp:Button ID="Reset_BankAccount" runat="server" CssClass="btn btn-info" OnClick="Reset_BankAccount_Click" Text="Reset" />
                            </div>
                        </div>


                        </div>

                </div>
                </div>
            </div>
          </div>
    
</asp:Content>

