<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="ReceiptType.aspx.cs" Inherits="User_ReceiptType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="content-header">
        <%--   <div id="breadcrumb"><a href="#" title="Go to Home" class="tip-bottom"><i class="icon-home"></i>Branch Master</a></div>--%>
        <div id="breadcrumb">
            <a href="Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">Receipt Type</a>
        </div>
    </div>
    <!--End-breadcrumbs-->
    <!--Action boxes-->

    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-align-justify"></i></span>
                        <h5>Receipt Type Details</h5>
                    </div>
                    <div class="widget-content">
                        <div class="controls">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            <asp:HiddenField ID="hf_ReceiptTypeid" runat="server" Value="0" />
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Key</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtReceiptTypeKey" runat="server" CssClass="span12 m-wrap" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Is Active</label>
                            <div class="span3 m-wrap">
                                <%--<asp:TextBox ID="txtKey" runat="server" CssClass="span12 m-wrap" />--%>
                                <asp:CheckBox ID="ChkIsActive" runat="server" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Description</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtDescription" runat="server" CssClass="span12 m-wrap" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Dep list Method</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLDepListMethod" runat="server" CssClass="span12 m-wrap">
                                    <asp:ListItem Value="-1" Text="Item 1"></asp:ListItem>
                                    <asp:ListItem Value="0" Text="Item 2"></asp:ListItem>
                                    <asp:ListItem Value="1" Text="Item 3"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Item 4"></asp:ListItem>
                                </asp:DropDownList>

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Bank Account</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLBankAccounts" runat="server" CssClass="span12 m-wrap">
                                    <asp:ListItem Value="-1" Text="Item 1"></asp:ListItem>
                                    <asp:ListItem Value="0" Text="Item 2"></asp:ListItem>
                                    <asp:ListItem Value="1" Text="Item 3"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Item 4"></asp:ListItem>
                                </asp:DropDownList>

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Credit/Card Type</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLCreditCardType" runat="server" CssClass="span12 m-wrap">
                                    <asp:ListItem Value="-1" Text="Item 1"></asp:ListItem>
                                    <asp:ListItem Value="0" Text="Item 2"></asp:ListItem>
                                    <asp:ListItem Value="1" Text="Item 3"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Item 4"></asp:ListItem>
                                </asp:DropDownList>

                            </div>
                        </div>
                        <div class="controls controls-row">
                            <%--  <div class="m-wrap"></div>--%>
                            <label class="span3 m-wrap">Set as a default for new payments</label>
                            <div class="span3 m-wrap">
                                <%--<asp:TextBox ID="txtKey" runat="server" CssClass="span12 m-wrap" />--%>
                                <asp:CheckBox ID="ChkDefault" runat="server" />
                            </div>
                        </div>


                        <div class="form-actions">
                            <div class="span5 m-wrap"></div>
                            <div class="span4 m-wrap">
                                <asp:Button ID="btnSubmit" runat="server" Text="Save" ValidationGroup="ReceiptType" OnClick="btnSubmit_Click"
                                    CssClass="btn btn-success" />
                                <%--  <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" ValidationGroup="Loc" Visible="false"
                                    CssClass="btn btn-success" />--%>
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" CssClass="btn btn-danger" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>

