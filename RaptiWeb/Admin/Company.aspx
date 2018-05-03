<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="Company.aspx.cs" Inherits="Admin_Company" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        .mandatory {
            color: #FF0000;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
    <asp:HiddenField ID="hf_CompanyId" runat="server" Value="0" />
     <asp:HiddenField ID="hfImageLogo" runat="server" />
    <section class="panel">
        <h2 class="page-header">New Company</h2>
        <div class="panel-body">
            <div class="form-horizontal">

                <div class="form-group">
                    <div class="col-sm-12">
                        <div class="col-sm-2">
                            <label class="control-label">
                                Company Name (<span class="mandatory">*</span>)
                            </label>
                        </div>
                        <div class="col-sm-4">

                            <asp:TextBox ID="txtCompanyName" runat="server" CssClass="form-control" MaxLength="30" placeholder="Company Name" />
                            <asp:RequiredFieldValidator ControlToValidate="txtCompanyName" runat="server" ID="rfvtxtCompanyName" ValidationGroup="Company"
                                ErrorMessage="Enter Company Name" SetFocusOnError="true" Display="Dynamic" ForeColor="Red" />

                        </div>

                        <div class="col-sm-2">
                            <label>
                                Company Logo (<span class="mandatory">*</span>)
                               
                            </label>
                        </div>
                        <div class="col-sm-4 ">
                            <asp:FileUpload ID="CompanyLogoUpload" runat="server" />
                             <a id="logoview" href="#" runat="server">
                            <asp:Label ID="lblLogo" runat="server" /></a>
                            <asp:RequiredFieldValidator ControlToValidate="CompanyLogoUpload" runat="server" ID="rfvCompanyLogoUpload" ValidationGroup="Company"
                                ErrorMessage="Select Logo" SetFocusOnError="true" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-sm-12">
                        <div class="col-sm-2">
                            <label class="control-label">
                                Email (<span class="mandatory">*</span>)
                            </label>
                        </div>
                        <div class="col-sm-4">

                            <asp:TextBox ID="txtEmailId" runat="server" CssClass="form-control" MaxLength="30" placeholder=" Company Email ID" />
                            <asp:RequiredFieldValidator ControlToValidate="txtEmailId" runat="server" ID="rfvtxtEmailId" ValidationGroup="Company"
                                ErrorMessage="Enter Company Email ID" SetFocusOnError="true" Display="Dynamic" ForeColor="Red" />
                            <asp:RegularExpressionValidator ID="revEmail" ValidationGroup="Company" Display="Dynamic"
                                ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w{2,4}([-.]\w{2,4})*([,;]\s*\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w{2,4}([-.]\w{2,4})*)*"
                                ControlToValidate="txtEmailId"
                                runat="server"
                                ErrorMessage="Enter data in email format" ForeColor="Red" SetFocusOnError="true"></asp:RegularExpressionValidator>
                        </div>

                        <div class="col-sm-2">
                            <label>
                                Phone No
                            </label>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="txtPhoneNo" runat="server" CssClass="form-control" MaxLength="50" placeholder="Phone Number" />
                            <%--  <asp:RegularExpressionValidator ID="revPhoneNo" ValidationGroup="Company" Display="Dynamic"
                                ValidationExpression="@(?<!\d)\d{10}(?!\d)"
                                ControlToValidate="txtPhoneNo"
                                runat="server"
                                ErrorMessage="Enter data in Phone format" SetFocusOnError="true" ForeColor="Red"></asp:RegularExpressionValidator>--%>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-sm-12">
                        <div class="col-sm-2">
                            <label class="control-label">
                                Web Site
                            </label>
                        </div>
                        <div class="col-sm-4">

                            <asp:TextBox ID="txtWebSite" runat="server" CssClass="form-control" MaxLength="30" placeholder="Company Web Site" />
                        </div>

                        <div class="col-sm-2">
                            <label>
                                Fax No
                            </label>
                        </div>
                        <div class="col-sm-4">
                            <asp:TextBox ID="txtFaxNo" runat="server" CssClass="form-control" MaxLength="50" placeholder="Company Fax Number" />
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-sm-12">
                        <div class="col-sm-2">
                            <label class="control-label">
                                Country (<span class="mandatory">*</span>)
                            </label>
                        </div>
                        <div class="col-sm-4">

                            <asp:DropDownList ID="DDLCountry" runat="server" CssClass="form-control" OnSelectedIndexChanged="DDLCountry_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ControlToValidate="DDLCountry" runat="server" ID="rfvDDLCountry" ValidationGroup="Company"
                                ErrorMessage="Select Country" Display="Dynamic" InitialValue="0" ForeColor="Red" />
                        </div>

                        <div class="col-sm-2">
                            <label>
                                Province (<span class="mandatory">*</span>)
                            </label>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="DDLProvince" runat="server" CssClass="form-control" OnSelectedIndexChanged="DDLProvince_SelectedIndexChanged" AutoPostBack="true">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ControlToValidate="DDLProvince" runat="server" ID="rfvDDLProvince" ValidationGroup="Company"
                                ErrorMessage="Select Province" Display="Dynamic" InitialValue="0" ForeColor="Red" />
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-sm-12">
                        <div class="col-sm-2">
                            <label class="control-label">
                                City (<span class="mandatory">*</span>)
                            </label>
                        </div>
                        <div class="col-sm-4">

                            <asp:DropDownList ID="DDLCity" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ControlToValidate="DDLCity" runat="server" ID="rfvDDLCity" ValidationGroup="Company"
                                ErrorMessage="Select City" Display="Dynamic" InitialValue="0" ForeColor="Red" />
                        </div>

                        <div class="col-sm-2">
                            <label>
                                Currency (<span class="mandatory">*</span>)
                            </label>
                        </div>
                        <div class="col-sm-4">
                            <asp:DropDownList ID="DDLCurrency" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ControlToValidate="DDLCurrency" runat="server" ID="rfvDDLCurrency" ValidationGroup="Company"
                                ErrorMessage="Select City" Display="Dynamic" InitialValue="0" ForeColor="Red" />
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-sm-12">
                        <div class="col-sm-3">
                        </div>
                        <div class="col-sm-2">
                            <asp:Button ID="Submit_Company" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="Submit_Company_Click" ValidationGroup="Company" />
                        </div>
                        <div class="col-sm-2">
                            <asp:Button ID="Cancel_Company" runat="server" CssClass="btn btn-danger" Text="Cancel" OnClick="Cancel_Company_Click" />
                        </div>

                        <div class="col-sm-2">
                            <asp:Button ID="Reset_Company" runat="server" CssClass="btn btn-info" Text="Reset" OnClick="Reset_Company_Click" />
                        </div>
                        <div class="col-sm-3">
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>
</asp:Content>

