<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="Company.aspx.cs" Inherits="Admin_Company" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .mandatory {
            color: #FF0000;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <div id="content-header">
        <%--   <div id="breadcrumb"><a href="#" title="Go to Home" class="tip-bottom"><i class="icon-home"></i>Branch Master</a></div>--%>
        <div id="breadcrumb">
            <a href="~/Users/Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">Company Master</a>
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
                        <h5>New Company</h5>
                    </div>
                    <div class="widget-content">
                        <div class="controls">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            <asp:HiddenField ID="hf_CompanyId" runat="server" Value="0" />
                            <asp:HiddenField ID="hfImageLogo" runat="server" />
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Company Name</label>
                            <div class="span3 m-wrap">

                                <asp:TextBox ID="txtCompanyName" runat="server" CssClass="form-control" MaxLength="30" placeholder="Company Name" />
                                <asp:RequiredFieldValidator ControlToValidate="txtCompanyName" runat="server" ID="rfvtxtCompanyName" ValidationGroup="Company"
                                    ErrorMessage="Enter Company Name" SetFocusOnError="true" Display="Dynamic" ForeColor="Red" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Company Logo </label>
                            <div class="span3 m-wrap">

                                <asp:FileUpload ID="CompanyLogoUpload" runat="server" />
                                <a id="logoview" href="#" runat="server">
                                    <asp:Label ID="lblLogo" runat="server" /></a>
                                <asp:RequiredFieldValidator ControlToValidate="CompanyLogoUpload" runat="server" ID="rfvCompanyLogoUpload" ValidationGroup="Company"
                                    ErrorMessage="Select Logo" SetFocusOnError="true" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Email</label>
                            <div class="span3 m-wrap">

                                <asp:TextBox ID="txtEmailId" runat="server" CssClass="form-control" MaxLength="30" placeholder=" Company Email ID" />
                                <asp:RequiredFieldValidator ControlToValidate="txtEmailId" runat="server" ID="rfvtxtEmailId" ValidationGroup="Company"
                                    ErrorMessage="Enter Company Email ID" SetFocusOnError="true" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revEmail" ValidationGroup="Company" Display="Dynamic"
                                    ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w{2,4}([-.]\w{2,4})*([,;]\s*\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w{2,4}([-.]\w{2,4})*)*"
                                    ControlToValidate="txtEmailId"
                                    runat="server"
                                    ErrorMessage="Enter data in email format" ForeColor="Red" SetFocusOnError="true"></asp:RegularExpressionValidator>

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Phone No</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtPhoneNo" runat="server" CssClass="form-control" MaxLength="50" placeholder="Phone Number" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Web Site</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtWebSite" runat="server" CssClass="form-control" MaxLength="30" placeholder="Company Web Site" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Fax No</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtFaxNo" runat="server" CssClass="form-control" MaxLength="50" placeholder="Company Fax Number" />

                            </div>
                        </div>
                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Country</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLCountry" runat="server" CssClass="form-control" OnSelectedIndexChanged="DDLCountry_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCountry" runat="server" ID="rfvDDLCountry" ValidationGroup="Company"
                                    ErrorMessage="Select Country" Display="Dynamic" InitialValue="0" ForeColor="Red" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">State</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLProvince" runat="server" CssClass="form-control" OnSelectedIndexChanged="DDLProvince_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLProvince" runat="server" ID="rfvDDLProvince" ValidationGroup="Company"
                                    ErrorMessage="Select Province" Display="Dynamic" InitialValue="-1" ForeColor="Red" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">City</label>
                            <div class="span3 m-wrap">

                                <asp:DropDownList ID="DDLCity" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCity" runat="server" ID="rfvDDLCity" ValidationGroup="Company"
                                    ErrorMessage="Select City" Display="Dynamic" InitialValue="-1" ForeColor="Red" />
                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Currency</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLCurrency" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCurrency" runat="server" ID="rfvDDLCurrency" ValidationGroup="Company"
                                    ErrorMessage="Select City" Display="Dynamic" InitialValue="-1" ForeColor="Red" />
                            </div>
                        </div>


                        <div class="form-actions">
                            <div class="span5 m-wrap"></div>
                            <div class="span4 m-wrap">
                                <asp:Button ID="Submit_Company" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="Submit_Company_Click" ValidationGroup="Company" />
                                <asp:Button ID="Cancel_Company" runat="server" CssClass="btn btn-danger" Text="Cancel" OnClick="Cancel_Company_Click" />
                                <asp:Button ID="Reset_Company" runat="server" CssClass="btn btn-info" Text="Reset" OnClick="Reset_Company_Click" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>

