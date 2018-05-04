<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="Branch.aspx.cs" EnableEventValidation="false" Inherits="Admin_Branch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <style type="text/css">
        .style1 {
            color: #FF0000;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="panel">

        <h4 class="page-header" style="margin: -4px;">New Branch</h4>
        <div class="panel-body">
            <div class="form-horizontal">
                <fieldset>
                    <legend>
                        <h4><b>Branch Details</b></h4>
                    </legend>
                    <asp:HiddenField ID="hf_BranchId" runat="server" Value="0" />
                     <asp:HiddenField ID="hf_ConfigurationId" runat="server" Value="0" />

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">
                                    Branch Name(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">

                                <asp:TextBox ID="txtBranchName" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtBranchName" runat="server" ID="rfvtxtBranchName" ValidationGroup="branch"
                                    ErrorMessage="Enter Branch Name" Text="Enter Branch Name" class="validationred" Display="Dynamic" ForeColor="Red" />
                            </div>
                            <div class="col-sm-1">
                                <label>
                                    IsActive
                                </label>
                            </div>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsactive" runat="server" />
                            </div>
                            <div class="col-sm-2">
                                <label>
                                    Branch Code(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-2">
                                <asp:TextBox ID="txtBranchCode" runat="server" CssClass="form-control" MaxLength="5" />
                                <asp:RequiredFieldValidator ControlToValidate="txtBranchCode" runat="server" ID="rfvtxtBranchCode" ValidationGroup="branch"
                                    ErrorMessage="Enter Branch Code" Text="Enter Branch Code" class="validationred" Display="Dynamic" ForeColor="Red" />
                            </div>

                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">
                                    Phone No
                                </label>
                            </div>
                            <div class="col-sm-4">

                                <asp:TextBox ID="txtPhoneno" runat="server" CssClass="form-control" MaxLength="30" />
                            </div>

                            <div class="col-sm-2">
                                <label>
                                    Alternative No
                                </label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtAlternativeNo" runat="server" CssClass="form-control" MaxLength="50" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">
                                    Email(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">

                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtEmail" runat="server" ID="rfvtxtEmail" ValidationGroup="branch"
                                    ErrorMessage="Please Enter Email" Text="Please Enter Email" class="validationred" Display="Dynamic" ForeColor="Red" />

                                <asp:RegularExpressionValidator ControlToValidate="txtEmail" runat="server" ForeColor="Red"
                                    ID="revtxtEmail" ValidationGroup="branch" ErrorMessage="Enter Valid Email."
                                    Text="Enter Valid Email." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                    Display="Dynamic"></asp:RegularExpressionValidator>
                            </div>

                            <div class="col-sm-2">
                                <label>
                                    Physical Address
                                </label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtPhysicalAddress" runat="server" OnTextChanged="txtPhysicalAddress_TextChanged" AutoPostBack="true" CssClass="form-control multipleLine" MaxLength="200" TextMode="MultiLine" />

                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-5">
                                <label class="control-label">
                                    Check Physical Address is same as  Postal Address
                                </label>
                            </div>
                            <div class="col-sm-1">
                                <asp:CheckBox runat="server" ID="chkcheckphysicaladdress" AutoPostBack="true" OnCheckedChanged="chkcheckphysicaladdress_CheckedChanged" />
                            </div>

                            <div class="col-sm-2">
                                <label>
                                    Postal Address
                                </label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtPostalAddress" runat="server" CssClass="form-control multipleLine" MaxLength="200" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">
                                    Country(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="DDLCountry"  AutoPostBack="true" OnSelectedIndexChanged="DDLCountry_SelectedIndexChanged" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCountry" runat="server" ID="rfvDDLCountry" ValidationGroup="branch"
                                    ErrorMessage="Please Select Country" Text="Please Select Country" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                            </div>

                            <div class="col-sm-2">
                                <label>
                                    Province(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">
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
                                <label class="control-label">
                                    City(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">
                                <asp:DropDownList ID="DDLCity" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCity" runat="server" ID="rfvDDLCity" ValidationGroup="branch"
                                    ErrorMessage="Please Select City" Text="Please Select City" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />


                            </div>

                            <div class="col-sm-2">
                                <label>
                                    Co Reg No(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtCoRegNo" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtCoRegNo" runat="server" ID="rfvtxtCoRegNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Co Reg No" Text="Enter Co Reg No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">
                                    IATARegNo
                                </label>
                            </div>
                            <div class="col-sm-4">

                                <asp:TextBox ID="txtIATARegNo" runat="server" CssClass="form-control" MaxLength="50" />
                            </div>

                            <div class="col-sm-2">
                                <label>
                                    Vat Reg No(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtVatRegNo" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtVatRegNo" runat="server" ID="rfvtxtVatRegNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Vat Reg No" Text="Enter Vat Reg No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>
                    </div>


                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">
                                    DoCex
                                </label>
                            </div>
                            <div class="col-sm-4">

                                <asp:TextBox ID="txtDoCex" runat="server" CssClass="form-control" MaxLength="50" />
                            </div>

                            <div class="col-sm-2">
                                <label>
                                    MemberOfAsata
                                </label>
                            </div>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkMemberOfAsata" runat="server" />
                            </div>

                            <div class="col-sm-1">
                                <label class="control-label">
                                    Currency(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-2">

                                <asp:DropDownList ID="DDLCurrency" runat="server" CssClass="form-control">
                                </asp:DropDownList>

                                <asp:RequiredFieldValidator ControlToValidate="DDLCurrency" runat="server" ID="rfvDDLCurrency" ValidationGroup="branch"
                                    ErrorMessage="Please Currency" Text="Please Select Currency" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0"/>


                            </div>

                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">


                            <div class="col-sm-2">
                                <label>
                                    Branch Logo
                                </label>
                            </div>
                            <div class="col-sm-4 ">

                                <div class="input-group">
                                    <label class="input-group-btn">
                                        <span class="btn btn-primary">Browse&hellip;
                                <input type="file" runat="server" style="display: none;">
                                        </span>
                                    </label>
                                    <input type="text" runat="server" class="form-control input-group-text" readonly>
                                </div>
                            </div>
                        </div>
                    </div>

                </fieldset>

                <fieldset>
                    <legend>
                        <h4><b>Configuration</b></h4>
                    </legend>
                    <%--<h4><b>Configuration</b></h4>--%>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">
                                    Vat Percentage
                                </label>
                            </div>
                            <div class="col-sm-4">

                                <asp:TextBox ID="txtVatPercentage" runat="server" CssClass="form-control" MaxLength="30" />
                            </div>

                            <div class="col-sm-3">
                                <label>
                                    Invoice Starting No(<span class="style1">*</span>)
                                </label>
                            </div>
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
                            <div class="col-sm-3">
                                <label class="control-label">
                                    CreditNote Starting No(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-3">

                                <asp:TextBox ID="txtCreditNoteStartNo" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtCreditNoteStartNo" runat="server" ID="rfvtxtCreditNoteStartNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Credit Note Starting No" Text="Enter Credit Note Starting No" class="validationred" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revtxtCreditNoteStartNo"
                                    ControlToValidate="txtCreditNoteStartNo" runat="server" ForeColor="Red"
                                    ErrorMessage="Only Numbers allowed"
                                    ValidationExpression="\d+" />
                            </div>

                            <div class="col-sm-4">
                                <label>
                                    ZeroCommForSuppliers
                                </label>
                            </div>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkZeroCommForSuppliers" runat="server" />
                            </div>
                        </div>
                    </div>


                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-5">
                                <label class="control-label">
                                    Convert ProformaInvoice To Invoice
                                </label>
                            </div>
                            <div class="col-sm-1">

                                <asp:CheckBox ID="chkConvertProInvToInv" runat="server" />
                            </div>

                            <div class="col-sm-4">
                                <label>
                                    ServiceFeeMerge
                                </label>
                            </div>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkServiceFeeMerge" runat="server" AutoPostBack="true" OnCheckedChanged="chkServiceFeeMerge_CheckedChanged" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-5">
                                <label class="control-label">
                                    IsSerFeeAddToAirportTax
                                </label>
                            </div>
                            <div class="col-sm-1">

                                <asp:CheckBox ID="chkIsSerFeeAddToAirportTax" runat="server" />
                            </div>

                            <div class="col-sm-4">
                                <label>
                                    IsSerFeeMergePaymentMatch
                                </label>
                            </div>
                            <div class="col-sm-1">
                                <asp:CheckBox ID="chkIsSerFeeMergePaymentMatch" runat="server" />
                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">
                                    PreFixDebtors(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">

                                <asp:TextBox ID="txtPreFixDebtors" runat="server" MaxLength="2" CssClass="form-control" />
                                <asp:RequiredFieldValidator ControlToValidate="txtPreFixDebtors" runat="server" ID="rfvtxtPreFixDebtors" ValidationGroup="branch"
                                    ErrorMessage="Enter PrefixNo of Debtors" Text="Enter PrefixNo of Debtors" class="validationred" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revtxtPreFixDebtors" ForeColor="Red" runat="server" ControlToValidate="txtPreFixDebtors"
                                    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Only Enter Characters" />
                            </div>

                            <div class="col-sm-2">
                                <label>
                                    PreFixCorporates(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">
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
                            <div class="col-sm-2">
                                <label class="control-label">
                                    PreFixLiesures(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">

                                <asp:TextBox ID="txtPreFixLiesures" runat="server" MaxLength="2" CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtPreFixLiesures" runat="server" ID="rfvtxtPreFixLiesures" ValidationGroup="branch"
                                    ErrorMessage="Enter PrefixNo of Liesures" Text="Enter PrefixNo of Liesures" class="validationred" Display="Dynamic" ForeColor="Red" />
                                 <asp:RegularExpressionValidator ID="revtxtPreFixLiesures" ForeColor="Red" runat="server" ControlToValidate="txtPreFixLiesures"
                                    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Only Enter Characters" />
                            </div>

                            <div class="col-sm-2">
                                <label>
                                    Rounding Decimal(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtRoundingDecimal" runat="server" MaxLength="5" CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtRoundingDecimal" runat="server" ID="rfvtxtRoundingDecimal" ValidationGroup="branch"
                                    ErrorMessage="Enter Rounding Decimal" Text="Enter Rounding Decimal" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-sm-12">
                            <div class="col-sm-2">
                                <label class="control-label">
                                    SupplierMainAcNo(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">

                                <asp:TextBox ID="txtSupplierMainAcNo" runat="server" MaxLength="5" CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtSupplierMainAcNo" runat="server" ID="rfvtxtSupplierMainAcNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Supplier MainAcc No" Text="Enter Supplier MainAcc No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>

                            <div class="col-sm-2">
                                <label>
                                    ClientMainAcNo(<span class="style1">*</span>)
                                </label>
                            </div>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtClientMainAcNo" runat="server" MaxLength="5" CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtClientMainAcNo" runat="server" ID="rfvtxtClientMainAcNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Client MainAcc No" Text="Enter Client MainAcc No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>
                    </div>

                </fieldset>
                <div class="form-group">
                    <div class="col-sm-12">
                        <div class="col-sm-3">
                        </div>
                        <div class="col-sm-2">
                            <asp:Button ID="Submit_Branch" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="Submit_Branch_Click" ValidationGroup="branch" />
                        </div>
                        <div class="col-sm-2">
                            <asp:Button ID="Cancel_Branch" runat="server" CssClass="btn btn-danger" OnClick="Cancel_Branch_Click" Text="Cancel" />
                        </div>

                        <div class="col-sm-2">
                            <asp:Button ID="Reset_Branch" runat="server" CssClass="btn btn-info" OnClick="Reset_Branch_Click" Text="Reset" />
                        </div>
                        <div class="col-sm-3">
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>
</asp:Content>



