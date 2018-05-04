<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="NewTemplateIndex.aspx.cs" Inherits="Admin_NewTemplateIndex" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="content-header">
        <%--   <div id="breadcrumb"><a href="#" title="Go to Home" class="tip-bottom"><i class="icon-home"></i>Branch Master</a></div>--%>
        <div id="breadcrumb">
            <a href="Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">Agent Master</a>
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
                        <h5>Agent Details</h5>
                    </div>
                    <div class="widget-content">
                        <div class="controls">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            <asp:HiddenField ID="hf_agent_id" runat="server" Value="0" />
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">User Id</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtUserId" runat="server" CssClass="span12 m-wrap" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Full Name</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtFullName" runat="server" CssClass="span12 m-wrap" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Password</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtPassword" runat="server" CssClass="span12 m-wrap" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Confirm Password</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtConformPassword" runat="server" CssClass="span12 m-wrap" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Company Name</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtCompanyName" runat="server" CssClass="span12 m-wrap" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Company Address</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtCompanyAddress" runat="server" CssClass="span12 m-wrap" TextMode="MultiLine"></asp:TextBox>

                            </div>
                        </div>
                        <div class="controls controls-row">
                            <label class="span2 m-wrap">City</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="ddlCity" runat="server" CssClass="span12 m-wrap" AppendDataBoundItems="true" AutoPostBack="true">
                                    <asp:ListItem Value="-1" Text="Select" />
                                </asp:DropDownList>

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">State</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="ddlState" runat="server" CssClass="span12 m-wrap" AppendDataBoundItems="true">
                                    <asp:ListItem Value="-1" Text="Select" />
                                </asp:DropDownList>

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Country</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="ddlCountry" runat="server" CssClass="span12 m-wrap" AppendDataBoundItems="true">
                                    <asp:ListItem Text="-Select-" Value="-1" />
                                </asp:DropDownList>

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Identity Code</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtIdentityCode" runat="server" CssClass="span12 m-wrap"></asp:TextBox>

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Mobile</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtMobile" runat="server" CssClass="span12 m-wrap" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Land Phone</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtLandPhone" runat="server" CssClass="span12 m-wrap" MaxLength="15" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Email</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="span12 m-wrap"></asp:TextBox>

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Fax</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtFax" runat="server" CssClass="span12 m-wrap" MaxLength="15" />

                            </div>
                        </div>




                        <div class="form-actions">
                            <div class="span5 m-wrap"></div>
                            <div class="span4 m-wrap">
                                <asp:Button ID="btnSubmit" runat="server" Text="Save" ValidationGroup="agent"
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

