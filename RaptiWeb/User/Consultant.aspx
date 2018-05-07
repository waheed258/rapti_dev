<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="Consultant.aspx.cs" Inherits="User_Consultant" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="content-header">
        <%--   <div id="breadcrumb"><a href="#" title="Go to Home" class="tip-bottom"><i class="icon-home"></i>Branch Master</a></div>--%>
        <div id="breadcrumb">
            <a href="Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">Consultant</a>
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
                        <h5>Consultant Details</h5>
                    </div>
                    <div class="widget-content">
                        <div class="controls">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            <asp:HiddenField ID="hf_ConsultantId" runat="server" Value="0" />
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Key</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtConsultantKey" runat="server" CssClass="span12 m-wrap form-control" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Is Active</label>
                            <div class="span3 m-wrap">
                                <%--<asp:TextBox ID="txtKey" runat="server" CssClass="span12 m-wrap" />--%>
                                <asp:CheckBox ID="IsActive" runat="server" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Consultant Name</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtConsultantName" runat="server" CssClass="span12 m-wrap" placeholder="Consultant Name" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Group</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLGroup" runat="server" CssClass="span12 m-wrap" AppendDataBoundItems="true" AutoPostBack="true">
                                    <asp:ListItem Value="-1" Text="Select" />
                                </asp:DropDownList>

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Division</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLDivision" runat="server" CssClass="span12 m-wrap" AppendDataBoundItems="true" AutoPostBack="true">
                                    <asp:ListItem Value="-1" Text="Select" />
                                </asp:DropDownList>


                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Email</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="span12 m-wrap" placeholder="Email ID"></asp:TextBox>

                            </div>
                        </div>
                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Telephone No</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtTelephoneNo" runat="server" CssClass="span12 m-wrap" placeholder="Telephone No" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Cell No</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtCellNo" runat="server" CssClass="span12 m-wrap" placeholder="Cell No" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Fax No</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtFaxNo" runat="server" CssClass="span12 m-wrap" placeholder="Fax No"></asp:TextBox>

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Client Type</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLClientType" runat="server" CssClass="span12 m-wrap" AppendDataBoundItems="true" AutoPostBack="true">
                                    <asp:ListItem Value="-1" Text="Select" />
                                </asp:DropDownList>

                            </div>
                        </div>


                        <div class="form-actions">
                            <div class="span5 m-wrap"></div>
                            <div class="span4 m-wrap">
                                <asp:Button ID="Consultant_Submit" runat="server" Text="Submit" OnClick="Consultant_Submit_Click" ValidationGroup="Consultant"
                                    CssClass="btn btn-success" />
                                <asp:Button ID="Consultant_Cancel" runat="server" Text="Cancel" CssClass="btn btn-danger" />
                                <asp:Button ID="Consultant_Reset" runat="server" Text="Reset" CssClass="btn btn-info" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

</asp:Content>

