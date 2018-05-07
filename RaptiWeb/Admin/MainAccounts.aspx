<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="MainAccounts.aspx.cs" Inherits="Admin_MainAccounts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style>
        .mandatory {
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div id="content-header">
        <%--   <div id="breadcrumb"><a href="#" title="Go to Home" class="tip-bottom"><i class="icon-home"></i>Branch Master</a></div>--%>
        <div id="breadcrumb">
            <a href="Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>>
            <a href="#" class="current">Main Account</a>
        </div>
    </div>
    <!--End-breadcrumbs-->
    <!--Action boxes-->

    <asp:HiddenField ID="hf_MainAccountId" runat="server" Value="0" />

    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-align-justify"></i></span>
                        <h5>Main Accounts</h5>
                    </div>

                    <div class="widget-content">
                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Code (<span class="mandatory">*</span>)</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtMainAccCode" runat="server" CssClass="span12 m-wrap" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Account Name (<span class="mandatory">*</span>)</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtMainAccName" runat="server" CssClass="span12 m-wrap" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Department</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLMainAccDepartment" runat="server" CssClass="span12 m-wrap">
                                    <asp:ListItem Value="-1" Text="Item 1"></asp:ListItem>
                                    <asp:ListItem Value="0" Text="Item 2"></asp:ListItem>
                                    <asp:ListItem Value="1" Text="Item 3"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Item 4"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Branch (<span class="mandatory">*</span>)</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLMainAccBranch" runat="server" CssClass="span12 m-wrap">
                                    <asp:ListItem Value="-1" Text="Item 1"></asp:ListItem>
                                    <asp:ListItem Value="0" Text="Item 2"></asp:ListItem>
                                    <asp:ListItem Value="1" Text="Item 3"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Item 4"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Account Type</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLMainAccType" runat="server" CssClass="span12 m-wrap">
                                    <asp:ListItem Value="-1" Text="Item 1"></asp:ListItem>
                                    <asp:ListItem Value="0" Text="Item 2"></asp:ListItem>
                                    <asp:ListItem Value="1" Text="Item 3"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Item 4"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Category</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLMainAccCategory" runat="server" CssClass="span12 m-wrap">
                                    <asp:ListItem Value="-1" Text="Item 1"></asp:ListItem>
                                    <asp:ListItem Value="0" Text="Item 2"></asp:ListItem>
                                    <asp:ListItem Value="1" Text="Item 3"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Item 4"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>


                        <div class="form-actions">
                            <div class="span5 m-wrap"></div>
                            <div class="span4 m-wrap">
                                <asp:Button ID="btnSubmit" runat="server" Text="Save" ValidationGroup="agent"
                                    OnClick="btnSubmit_Click" CssClass="btn btn-success" />

                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" CssClass="btn btn-danger" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>

