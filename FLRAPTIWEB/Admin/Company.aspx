<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Company.aspx.cs" Inherits="Admin_Company" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .style1 {
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="labelError" runat="server"></asp:Label>
    <asp:HiddenField ID="hf_CompanyId" runat="server" Value="0" />
    <asp:HiddenField ID="hfImageLogo" runat="server" />
    <section class="panel">
        <header class="panel-heading">
            <div class="panel-actions">
                <a href="#" class="panel-action panel-action-toggle" data-panel-toggle=""></a>
            </div>
            <h2 class="panel-title">Company Details</h2>
        </header>
        <div class="panel-body">

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">Company Name(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtCompanyName" runat="server" CssClass="form-control" MaxLength="30" placeholder="Company Name" />
                                <asp:RequiredFieldValidator ControlToValidate="txtCompanyName" runat="server" ID="rfvtxtCompanyName" ValidationGroup="Company"
                                    ErrorMessage="Enter Company Name" SetFocusOnError="true" Display="Dynamic" ForeColor="Red" />
                            </div>
                            <div class="col-sm-1"></div>
                            <div class="col-sm-2">
                                <label class="control-label">Company Logo(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
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
                                <label class="control-label">Email(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtEmailId" runat="server" CssClass="form-control" MaxLength="30" placeholder=" Company Email ID" />
                                <asp:RequiredFieldValidator ControlToValidate="txtEmailId" runat="server" ID="rfvtxtEmailId" ValidationGroup="Company"
                                    ErrorMessage="Enter Company Email ID" SetFocusOnError="true" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revEmail" ValidationGroup="Company" Display="Dynamic"
                                    ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w{2,4}([-.]\w{2,4})*([,;]\s*\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w{2,4}([-.]\w{2,4})*)*"
                                    ControlToValidate="txtEmailId"
                                    runat="server"
                                    ErrorMessage="Enter data in email format" ForeColor="Red" SetFocusOnError="true"></asp:RegularExpressionValidator>

                            </div>

                            <div class="col-sm-1"></div>

                            <div class="col-sm-2">
                                <label class="control-label">Phone No (<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtPhoneNo" runat="server" CssClass="form-control" MaxLength="50" placeholder="Phone Number" />
                            </div>
                        </div>
                    </div>



                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">Web Site(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtWebSite" runat="server" CssClass="form-control" MaxLength="30" placeholder="Company Web Site" />
                            </div>

                            <div class="col-sm-1"></div>

                            <div class="col-sm-2">
                                <label class="control-label">Fax No (<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtFaxNo" runat="server" CssClass="form-control" MaxLength="50" placeholder="Company Fax Number" />
                            </div>
                        </div>
                    </div>


                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">Country(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="DDLCountry" runat="server" CssClass="form-control" OnSelectedIndexChanged="DDLCountry_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCountry" runat="server" ID="rfvDDLCountry" ValidationGroup="Company"
                                    ErrorMessage="Select Country" Display="Dynamic" InitialValue="0" ForeColor="Red" />

                            </div>

                            <div class="col-sm-1"></div>

                            <div class="col-sm-2">
                                <label class="control-label">Province(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="DDLProvince" runat="server" CssClass="form-control" OnSelectedIndexChanged="DDLProvince_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLProvince" runat="server" ID="rfvDDLProvince" ValidationGroup="Company"
                                    ErrorMessage="Select Province" Display="Dynamic" InitialValue="-1" ForeColor="Red" />
                            </div>
                        </div>
                    </div>



                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">City(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="DDLCity" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCity" runat="server" ID="rfvDDLCity" ValidationGroup="Company"
                                    ErrorMessage="Select City" Display="Dynamic" InitialValue="-1" ForeColor="Red" />
                            </div>

                            <div class="col-sm-1"></div>

                            <div class="col-sm-2">
                                <label class="control-label">Currency(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="DDLCurrency" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCurrency" runat="server" ID="rfvDDLCurrency" ValidationGroup="Company"
                                    ErrorMessage="Select City" Display="Dynamic" InitialValue="-1" ForeColor="Red" />
                            </div>
                        </div>
                    </div>


                    <div class="form-group">
                        <br />
                    </div>

                    <div class="form-group">
                        <div class="col-sm-5">
                        </div>
                        <div class="col-sm-4">
                            <asp:Button runat="server" ID="Company_Submit" class="btn btn-success btn-lg" ValidationGroup="landsupplier"
                                Text="Submit"
                                UseSubmitBehavior="false"
                                OnClientClick="this.disabled='true';this.value='Please Wait...' "
                                OnClick="Company_Submit_Click" />&nbsp;
                        </div>
                    </div>


                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </section>
</asp:Content>

