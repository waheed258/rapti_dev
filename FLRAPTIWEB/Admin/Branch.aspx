<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Branch.aspx.cs" Inherits="Admin_Branch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="labelError" runat="server"></asp:Label>
    <style type="text/css">
        .style1 {
            color: #FF0000;
        }
    </style>

    <section class="panel">
        <header class="panel-heading">
            <div class="panel-actions">
                <a href="#" class="panel-action panel-action-toggle" data-panel-toggle=""></a>
            </div>
            <h2 class="panel-title">New Branch</h2>
        </header>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <asp:HiddenField ID="hf_BranchId" runat="server" Value="0" />
        <asp:HiddenField ID="hf_ConfigurationId" runat="server" Value="0" />
        <asp:HiddenField ID="hf_MainAccId" runat="server" Value="0" />
        <asp:HiddenField ID="hfImageLogo" runat="server" />

        <div class="panel-body">
            <div class="col-sm-12">
            </div>
            <asp:UpdatePanel ID="UpdatePanel" runat="server">
                <ContentTemplate>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">Branch Name(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtBranchName" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtBranchName" runat="server" ID="rfvtxtBranchName" ValidationGroup="branch"
                                    ErrorMessage="Enter Branch Name" Text="Enter Branch Name" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                            <div class="col-sm-1"></div>
                            <div class="col-sm-1">
                                <label class="control-label">IsActive</label>
                            </div>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsactive" runat="server" />
                            </div>
                            <div class="col-sm-2">
                                <label class="control-label">Branch Code(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-1">
                                <asp:TextBox ID="txtBranchCode" runat="server" CssClass="form-control" MaxLength="5" Style="width: 135px;" />
                                <asp:RequiredFieldValidator ControlToValidate="txtBranchCode" runat="server" ID="rfvtxtBranchCode" ValidationGroup="branch"
                                    ErrorMessage="Enter Branch Code" Text="Enter Branch Code" class="validationred" Display="Dynamic" ForeColor="Red" />
                            </div>

                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                Phone No
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtPhoneno" runat="server" CssClass="form-control" MaxLength="30" />
                            </div>
                            <div class="col-sm-1"></div>
                            <div class="col-sm-3">
                                Alternative NoAlternative No
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtAlternativeNo" runat="server" CssClass="form-control" MaxLength="50" />
                            </div>
                        </div>

                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">Email(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtEmail" runat="server" ID="rfvtxtEmail" ValidationGroup="branch"
                                    ErrorMessage="Please Enter Email" Text="Please Enter Email" class="validationred" Display="Dynamic" ForeColor="Red" />

                                <asp:RegularExpressionValidator ControlToValidate="txtEmail" runat="server" ForeColor="Red"
                                    ID="revtxtEmail" ValidationGroup="branch" ErrorMessage="Enter Valid Email."
                                    Text="Enter Valid Email." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                    Display="Dynamic"></asp:RegularExpressionValidator>

                            </div>
                            <div class="col-sm-1"></div>
                            <div class="col-sm-3">
                                <label class="control-label">Physical Address</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtPhysicalAddress" runat="server" OnTextChanged="txtPhysicalAddress_TextChanged" AutoPostBack="true" CssClass="form-control multipleLine" MaxLength="200" TextMode="MultiLine" />

                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-4">
                                <label class="control-label">Check Physical Address is same as  Postal Address</label>
                            </div>
                            <div class="col-sm-1">
                                <asp:CheckBox runat="server" ID="chkcheckphysicaladdress" AutoPostBack="true" OnCheckedChanged="chkcheckphysicaladdress_CheckedChanged" />

                            </div>
                            <div class="col-sm-1"></div>
                            <div class="col-sm-3">
                                <label class="control-label">Postal Address</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtPostalAddress" runat="server" CssClass="form-control multipleLine" MaxLength="200" TextMode="MultiLine"></asp:TextBox>

                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">Country(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="DDLCountry" AutoPostBack="true" OnSelectedIndexChanged="DDLCountry_SelectedIndexChanged" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCountry" runat="server" ID="rfvDDLCountry" ValidationGroup="branch"
                                    ErrorMessage="Please Select Country" Text="Please Select Country" class="validationred" Display="Dynamic" ForeColor="Red" />
                            </div>

                            <div class="col-sm-1"></div>
                            <div class="col-sm-3">
                                <label class="control-label">Province(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="DDLProvince" OnSelectedIndexChanged="DDLProvince_SelectedIndexChanged" AutoPostBack="true" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLProvince" runat="server" ID="rfvDDLProvince" ValidationGroup="branch"
                                    ErrorMessage="Please Select Province" Text="Please Select Province" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

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
                                <asp:RequiredFieldValidator ControlToValidate="DDLCity" runat="server" ID="rfvDDLCity" ValidationGroup="branch"
                                    ErrorMessage="Please Select City" Text="Please Select City" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                            </div>

                            <div class="col-sm-1"></div>
                            <div class="col-sm-3">
                                <label class="control-label">Co Reg No(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtCoRegNo" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtCoRegNo" runat="server" ID="rfvtxtCoRegNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Co Reg No" Text="Enter Co Reg No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">IATARegNo(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtIATARegNo" runat="server" CssClass="form-control" MaxLength="50" />
                            </div>

                            <div class="col-sm-1"></div>
                            <div class="col-sm-3">
                                <label class="control-label">Vat Reg No(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtVatRegNo" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtVatRegNo" runat="server" ID="rfvtxtVatRegNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Vat Reg No" Text="Enter Vat Reg No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">DoCex</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtDoCex" runat="server" CssClass="form-control" MaxLength="50" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">MemberOfAsata</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:CheckBox ID="chkMemberOfAsata" runat="server" />
                            </div>
                            <div class="col-sm-1"></div>
                            <div class="col-sm-3">
                                <label class="control-label">Currency(<span class="style1">*</span>)</label>
                            </div>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="DDLCurrency" runat="server" CssClass="form-control">
                                </asp:DropDownList>

                                <asp:RequiredFieldValidator ControlToValidate="DDLCurrency" runat="server" ID="rfvDDLCurrency" ValidationGroup="branch"
                                    ErrorMessage="Please Select Currency" Text="Please Select Currency" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                Branch Logo
                            </div>
                            <div class="col-sm-3">
                                <label class="input-group-btn">
                                    <span class="btn btn-primary">Browse&hellip;
                                 <asp:FileUpload ID="BranchLogoUpload" runat="server" />
                                        <a id="logoview" href="#" runat="server" target="_blank">
                                            <asp:Label ID="lblLogo" runat="server" /></a>
                                        <asp:Button ID="btnUploadImage" runat="server" Text="Browse"
                                            OnClick="btnUploadImage_Click" />

                                    </span>
                                </label>

                            </div>


                        </div>
                    </div>



                    <h5>Configuration</h5>
                    <hr />
                    <div class="form-group">
                        <div class="col-sm-12">
                            <label class="col-sm-2">Vat Percentage</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtVatPercentage" runat="server" CssClass="form-control" MaxLength="30" />
                            </div>
                            <div class="col-sm-1"></div>
                            <label class="col-sm-3">Invoice Starting No(<span class="style1">*</span>)</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtInvStartNo" runat="server" CssClass="form-control" MaxLength="50" />
                                <asp:RequiredFieldValidator ControlToValidate="txtInvStartNo" runat="server" ID="rfvtxtInvStartNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Invoice Starting No" Text="Enter Invoice Starting No" class="validationred" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revtxtInvStartNo"
                                    ControlToValidate="txtInvStartNo" runat="server"
                                    ErrorMessage="Only Numbers allowed" ForeColor="Red"
                                    ValidationExpression="\d+" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <label class="col-sm-2">CreditNote Starting No(<span class="style1">*</span>)</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtCreditNoteStartNo" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtCreditNoteStartNo" runat="server" ID="rfvtxtCreditNoteStartNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Credit Note Starting No" Text="Enter Credit Note Starting No" class="validationred" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revtxtCreditNoteStartNo"
                                    ControlToValidate="txtCreditNoteStartNo" runat="server" ForeColor="Red"
                                    ErrorMessage="Only Numbers allowed"
                                    ValidationExpression="\d+" />
                            </div>
                            <div class="col-sm-1"></div>
                            <label class="col-sm-3">ZeroCommForSuppliers</label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkZeroCommForSuppliers" runat="server" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <label class="col-sm-4">Convert ProformaInvoice To Invoice</label>
                            <div class="col-sm-1">

                                <asp:CheckBox ID="chkConvertProInvToInv" runat="server" />
                            </div>
                            <div class="col-sm-1"></div>
                            <label class="col-sm-3">ServiceFeeMerge</label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkServiceFeeMerge" runat="server" AutoPostBack="true" OnCheckedChanged="chkServiceFeeMerge_CheckedChanged" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <label class="col-sm-4">IsSerFeeAddToAirportTax</label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsSerFeeAddToAirportTax" runat="server" />

                            </div>
                            <div class="col-sm-1"></div>
                            <label class="col-sm-3">IsSerFeeMergePaymentMatch</label>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsSerFeeMergePaymentMatch" runat="server" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <label class="col-sm-2">PreFixDebtors(<span class="style1">*</span>)</label>
                            <div class="col-sm-3">

                                <asp:TextBox ID="txtPreFixDebtors" runat="server" MaxLength="2" CssClass="form-control" />
                                <asp:RequiredFieldValidator ControlToValidate="txtPreFixDebtors" runat="server" ID="rfvtxtPreFixDebtors" ValidationGroup="branch"
                                    ErrorMessage="Enter PrefixNo of Debtors" Text="Enter PrefixNo of Debtors" class="validationred" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revtxtPreFixDebtors" ForeColor="Red" runat="server" ControlToValidate="txtPreFixDebtors"
                                    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Only Enter Characters" />
                            </div>
                            <div class="col-sm-1"></div>
                            <label class="col-sm-2">PreFixCorporates(<span class="style1">*</span>)</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtPreFixCorporates" runat="server" MaxLength="2" CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtPreFixCorporates" runat="server" ID="rfvtxtPreFixCorporates" ValidationGroup="branch"
                                    ErrorMessage="Enter PrefixNo of Corporates" Text="Enter PrefixNo of Corporates" class="validationred" Display="Dynamic" ForeColor="Red" />

                                <asp:RegularExpressionValidator ID="revtxtPreFixCorporates" ForeColor="Red" runat="server" ControlToValidate="txtPreFixCorporates"
                                    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Only Enter Characters" />
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <label class="col-sm-2">PreFixLiesures(<span class="style1">*</span>)</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtPreFixLiesures" runat="server" MaxLength="2" CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtPreFixLiesures" runat="server" ID="rfvtxtPreFixLiesures" ValidationGroup="branch"
                                    ErrorMessage="Enter PrefixNo of Liesures" Text="Enter PrefixNo of Liesures" class="validationred" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revtxtPreFixLiesures" ForeColor="Red" runat="server" ControlToValidate="txtPreFixLiesures"
                                    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Only Enter Characters" />
                            </div>
                            <div class="col-sm-1"></div>
                            <label class="col-sm-2">Rounding Decimal(<span class="style1">*</span>)</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtRoundingDecimal" runat="server" MaxLength="5" CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtRoundingDecimal" runat="server" ID="rfvtxtRoundingDecimal" ValidationGroup="branch"
                                    ErrorMessage="Enter Rounding Decimal" Text="Enter Rounding Decimal" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <label class="col-sm-2">SupplierMainAcNo(<span class="style1">*</span>)</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtSupplierMainAcNo" runat="server" MaxLength="5" CssClass="form-control"
                                    OnTextChanged="txtSupplierMainAcNo_TextChanged" AutoPostBack="true" />
                                <asp:Label ID="lblchecksupplacccode" runat="server"></asp:Label>
                                <asp:RequiredFieldValidator ControlToValidate="txtSupplierMainAcNo" runat="server" ID="rfvtxtSupplierMainAcNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Supplier MainAcc No" Text="Enter Supplier MainAcc No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                            <div class="col-sm-1"></div>
                            <label class="col-sm-2">SupplierMainAcName(<span class="style1">*</span>)</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtSupplierMainAccName" runat="server" CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtSupplierMainAccName" runat="server" ID="rfvtxtSupplierMainAccName" ValidationGroup="branch"
                                    ErrorMessage="Enter Supplier MainAcc Name" Text="Enter Supplier MainAcc Name" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <label class="col-sm-2">Supplier Account Type(<span class="style1">*</span>)</label>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="DDLSupplierMainAccType" runat="server" CssClass="form-control">
                                    <asp:ListItem Value="-1" Text="Item 1"></asp:ListItem>
                                    <asp:ListItem Value="0" Text="Item 2"></asp:ListItem>
                                    <asp:ListItem Value="1" Text="Item 3"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Item 4"></asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLSupplierMainAccType" runat="server" ID="rfvDDLSupplierMainAccType" ValidationGroup="branch"
                                    ErrorMessage="Select Supplier MainAccount Type" Text="Select Supplier MainAccount Type" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                            </div>
                            <div class="col-sm-1"></div>
                            <label class="col-sm-2">ClientMainAcNo(<span class="style1">*</span>)</label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtClientMainAcNo" runat="server" MaxLength="5" AutoPostBack="true" CssClass="form-control" OnTextChanged="txtClientMainAcNo_TextChanged" />
                                <asp:Label ID="lblcheckclientacccode" runat="server"></asp:Label>

                                <asp:RequiredFieldValidator ControlToValidate="txtClientMainAcNo" runat="server" ID="rfvtxtClientMainAcNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Client MainAcc No" Text="Enter Client MainAcc No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <label class="col-sm-2">Client MainAcName(<span class="style1">*</span>)</label>
                        <div class="col-sm-3">
                            <asp:TextBox ID="txtClientmainAccName" runat="server" CssClass="form-control" />
                            <asp:RequiredFieldValidator ControlToValidate="txtClientmainAccName" runat="server" ID="rfvtxtClientmainAccName" ValidationGroup="branch"
                                ErrorMessage="Enter Client MainAcc Name" Text="Enter Client MainAcc Name" class="validationred" Display="Dynamic" ForeColor="Red" />

                        </div>
                        <div class="col-sm-1"></div>
                        <label class="col-sm-2">Client Account Type(<span class="style1">*</span>)</label>
                        <div class="col-sm-3">
                            <asp:DropDownList ID="DDLClientaccType" runat="server" CssClass="form-control">
                                <asp:ListItem Value="-1" Text="Item 1"></asp:ListItem>
                                <asp:ListItem Value="0" Text="Item 2"></asp:ListItem>
                                <asp:ListItem Value="1" Text="Item 3"></asp:ListItem>
                                <asp:ListItem Value="2" Text="Item 4"></asp:ListItem>
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ControlToValidate="DDLClientaccType" runat="server" ID="rfvDDLClientaccType" ValidationGroup="branch"
                                ErrorMessage="Select Client MainAccount Type" Text="Select Client MainAccount Type" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                        </div>
                    </div>
                    <div class="col-sm-12"></div>
                    <div class="form-actions">
                        <div class="col-sm-12">
                            <div class="col-sm-4"></div>
                            <div class="col-sm-4">
                                <asp:Button ID="Submit_Branch" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="Submit_Branch_Click" ValidationGroup="branch" />
                                <asp:Button ID="Cancel_Branch" runat="server" CssClass="btn btn-danger" OnClick="Cancel_Branch_Click" Text="Cancel" />
                                <asp:Button ID="Reset_Branch" runat="server" CssClass="btn btn-info" OnClick="Reset_Branch_Click" Text="Reset" />
                            </div>
                        </div>
                    </div>


                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </section>
</asp:Content>


