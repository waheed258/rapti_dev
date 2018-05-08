<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="Branch.aspx.cs" EnableEventValidation="false" Inherits="Admin_Branch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <style type="text/css">
        .style1 {
            color: #FF0000;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="content-header">
        <%--   <div id="breadcrumb"><a href="#" title="Go to Home" class="tip-bottom"><i class="icon-home"></i>Branch Master</a></div>--%>
        <div id="breadcrumb">
            <a href="~/Users/Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">Branch Master</a>
        </div>
    </div>

    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-align-justify"></i></span>
                        <h5>New Branch</h5>
                    </div>
                    <div class="widget-content">
                        <div class="controls">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            <asp:HiddenField ID="hf_BranchId" runat="server" Value="0" />
                     <asp:HiddenField ID="hf_ConfigurationId" runat="server" Value="0" />
                            <asp:HiddenField ID="hf_MainAccId" runat="server" Value="0" />
                      <asp:HiddenField ID="hfImageLogo" runat="server" />

                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Branch Name(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtBranchName" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtBranchName" runat="server" ID="rfvtxtBranchName" ValidationGroup="branch"
                                    ErrorMessage="Enter Branch Name" Text="Enter Branch Name" class="validationred" Display="Dynamic" ForeColor="Red" />
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span1 m-wrap">IsActive </label>
                            <div class="span1 m-wrap">
                                <asp:CheckBox ID="chkIsactive" runat="server" />
                            </div>
                            <label class="span2 m-wrap">Branch Code(<span class="style1">*</span>) </label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtBranchCode" runat="server" CssClass="form-control" MaxLength="5" style="width:135px;"/>
                                <asp:RequiredFieldValidator ControlToValidate="txtBranchCode" runat="server" ID="rfvtxtBranchCode" ValidationGroup="branch"
                                    ErrorMessage="Enter Branch Code" Text="Enter Branch Code" class="validationred" Display="Dynamic" ForeColor="Red" />
                            </div>

                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Phone No</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtPhoneno" runat="server" CssClass="form-control" MaxLength="30" />
                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Alternative No</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtAlternativeNo" runat="server" CssClass="form-control" MaxLength="50" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Email(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtEmail" runat="server" ID="rfvtxtEmail" ValidationGroup="branch"
                                    ErrorMessage="Please Enter Email" Text="Please Enter Email" class="validationred" Display="Dynamic" ForeColor="Red" />

                                <asp:RegularExpressionValidator ControlToValidate="txtEmail" runat="server" ForeColor="Red"
                                    ID="revtxtEmail" ValidationGroup="branch" ErrorMessage="Enter Valid Email."
                                    Text="Enter Valid Email." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                    Display="Dynamic"></asp:RegularExpressionValidator>
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Physical Address</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtPhysicalAddress" runat="server" OnTextChanged="txtPhysicalAddress_TextChanged" AutoPostBack="true" CssClass="form-control multipleLine" MaxLength="200" TextMode="MultiLine" />

                            </div>
                        </div>
                        <div class="controls controls-row">
                            <label class="span4 m-wrap">Check Physical Address is same as  Postal Address</label>
                            <div class="span1 m-wrap">
                                <asp:CheckBox runat="server" ID="chkcheckphysicaladdress" AutoPostBack="true" OnCheckedChanged="chkcheckphysicaladdress_CheckedChanged" />
                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Postal Address</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtPostalAddress" runat="server" CssClass="form-control multipleLine" MaxLength="200" TextMode="MultiLine"></asp:TextBox>

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Country(<span class="style1">*</span>)</label>
                            <div class="span3 m-wrap">
                                <asp:DropDownList ID="DDLCountry" AutoPostBack="true" OnSelectedIndexChanged="DDLCountry_SelectedIndexChanged" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCountry" runat="server" ID="rfvDDLCountry" ValidationGroup="branch"
                                    ErrorMessage="Please Select Country" Text="Please Select Country" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Province(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:DropDownList ID="DDLProvince" OnSelectedIndexChanged="DDLProvince_SelectedIndexChanged" AutoPostBack="true" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLProvince" runat="server" ID="rfvDDLProvince" ValidationGroup="branch"
                                    ErrorMessage="Please Select Province" Text="Please Select Province" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">City(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:DropDownList ID="DDLCity" runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCity" runat="server" ID="rfvDDLCity" ValidationGroup="branch"
                                    ErrorMessage="Please Select City" Text="Please Select City" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Co Reg No(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                         <asp:TextBox ID="txtCoRegNo" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtCoRegNo" runat="server" ID="rfvtxtCoRegNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Co Reg No" Text="Enter Co Reg No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>


                        <div class="controls controls-row">
                            <label class="span2 m-wrap">IATARegNo(<span class="style1">*</span>)</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtIATARegNo" runat="server" CssClass="form-control" MaxLength="50" />
                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Vat Reg No(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtVatRegNo" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtVatRegNo" runat="server" ID="rfvtxtVatRegNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Vat Reg No" Text="Enter Vat Reg No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">DoCex</label>
                            <div class="span3 m-wrap">
                                 <asp:TextBox ID="txtDoCex" runat="server" CssClass="form-control" MaxLength="50" />
                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">MemberOfAsata</label>
                            <div class="span3 m-wrap">
                                  <asp:CheckBox ID="chkMemberOfAsata" runat="server" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Currency(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                               <asp:DropDownList ID="DDLCurrency" runat="server" CssClass="form-control">
                                </asp:DropDownList>

                                <asp:RequiredFieldValidator ControlToValidate="DDLCurrency" runat="server" ID="rfvDDLCurrency" ValidationGroup="branch"
                                    ErrorMessage="Please Select Currency" Text="Please Select Currency" class="validationred" Display="Dynamic" ForeColor="Red"  InitialValue="0"/>

                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Branch Logo</label>
                            <div class="span3 m-wrap">
                               <div class="input-group">
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

                        

<hr />
                            <h5>Configuration</h5>
                       

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Vat Percentage</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtVatPercentage" runat="server" CssClass="form-control" MaxLength="30" />
                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Invoice Starting No(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtInvStartNo" runat="server" CssClass="form-control" MaxLength="50" />
                                <asp:RequiredFieldValidator ControlToValidate="txtInvStartNo" runat="server" ID="rfvtxtInvStartNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Invoice Starting No" Text="Enter Invoice Starting No" class="validationred" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revtxtInvStartNo"
                                    ControlToValidate="txtInvStartNo" runat="server"
                                    ErrorMessage="Only Numbers allowed" ForeColor="Red"
                                    ValidationExpression="\d+" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">CreditNote Starting No(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtCreditNoteStartNo" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtCreditNoteStartNo" runat="server" ID="rfvtxtCreditNoteStartNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Credit Note Starting No" Text="Enter Credit Note Starting No" class="validationred" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revtxtCreditNoteStartNo"
                                    ControlToValidate="txtCreditNoteStartNo" runat="server" ForeColor="Red"
                                    ErrorMessage="Only Numbers allowed"
                                    ValidationExpression="\d+" />
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">ZeroCommForSuppliers</label>
                            <div class="span3 m-wrap">
                                <asp:CheckBox ID="chkZeroCommForSuppliers" runat="server" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span3 m-wrap">Convert ProformaInvoice To Invoice</label>
                            <div class="span2 m-wrap">
                               
                                <asp:CheckBox ID="chkConvertProInvToInv" runat="server" />
                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">ServiceFeeMerge</label>
                            <div class="span3 m-wrap">
                                <asp:CheckBox ID="chkServiceFeeMerge" runat="server" AutoPostBack="true" OnCheckedChanged="chkServiceFeeMerge_CheckedChanged" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span3 m-wrap">IsSerFeeAddToAirportTax</label>
                            <div class="span2 m-wrap">
                                <asp:CheckBox ID="chkIsSerFeeAddToAirportTax" runat="server" />

                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">IsSerFeeMergePaymentMatch</label>
                            <div class="span3 m-wrap">
                                <asp:CheckBox ID="chkIsSerFeeMergePaymentMatch" runat="server" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">PreFixDebtors(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">

                                <asp:TextBox ID="txtPreFixDebtors" runat="server" MaxLength="2" CssClass="form-control" />
                                <asp:RequiredFieldValidator ControlToValidate="txtPreFixDebtors" runat="server" ID="rfvtxtPreFixDebtors" ValidationGroup="branch"
                                    ErrorMessage="Enter PrefixNo of Debtors" Text="Enter PrefixNo of Debtors" class="validationred" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revtxtPreFixDebtors" ForeColor="Red" runat="server" ControlToValidate="txtPreFixDebtors"
                                    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Only Enter Characters" />
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">PreFixCorporates(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtPreFixCorporates" runat="server" MaxLength="2" CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtPreFixCorporates" runat="server" ID="rfvtxtPreFixCorporates" ValidationGroup="branch"
                                    ErrorMessage="Enter PrefixNo of Corporates" Text="Enter PrefixNo of Corporates" class="validationred" Display="Dynamic" ForeColor="Red" />

                                <asp:RegularExpressionValidator ID="revtxtPreFixCorporates" ForeColor="Red" runat="server" ControlToValidate="txtPreFixCorporates"
                                    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Only Enter Characters" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">PreFixLiesures(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtPreFixLiesures" runat="server" MaxLength="2" CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtPreFixLiesures" runat="server" ID="rfvtxtPreFixLiesures" ValidationGroup="branch"
                                    ErrorMessage="Enter PrefixNo of Liesures" Text="Enter PrefixNo of Liesures" class="validationred" Display="Dynamic" ForeColor="Red" />
                                <asp:RegularExpressionValidator ID="revtxtPreFixLiesures" ForeColor="Red" runat="server" ControlToValidate="txtPreFixLiesures"
                                    ValidationExpression="[a-zA-Z ]*$" ErrorMessage="Only Enter Characters" />
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Rounding Decimal(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtRoundingDecimal" runat="server" MaxLength="5" CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtRoundingDecimal" runat="server" ID="rfvtxtRoundingDecimal" ValidationGroup="branch"
                                    ErrorMessage="Enter Rounding Decimal" Text="Enter Rounding Decimal" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">SupplierMainAcNo(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtSupplierMainAcNo" runat="server" MaxLength="5" CssClass="form-control" 
                                    OnTextChanged="txtSupplierMainAcNo_TextChanged" AutoPostBack="true" />
                                 <asp:Label ID="lblchecksupplacccode" runat="server"></asp:Label>
                                <asp:RequiredFieldValidator ControlToValidate="txtSupplierMainAcNo" runat="server" ID="rfvtxtSupplierMainAcNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Supplier MainAcc No" Text="Enter Supplier MainAcc No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">SupplierMainAcName(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                              <asp:TextBox ID="txtSupplierMainAccName" runat="server"  CssClass="form-control" />

                                <asp:RequiredFieldValidator ControlToValidate="txtSupplierMainAccName" runat="server" ID="rfvtxtSupplierMainAccName" ValidationGroup="branch"
                                    ErrorMessage="Enter Supplier MainAcc Name" Text="Enter Supplier MainAcc Name" class="validationred" Display="Dynamic" ForeColor="Red" />
   
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Supplier Account Type(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                 <asp:DropDownList ID="DDLSupplierMainAccType" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="-1" Text="Item 1"></asp:ListItem>
                                    <asp:ListItem Value="0" Text="Item 2"></asp:ListItem>
                                    <asp:ListItem Value="1" Text="Item 3"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Item 4"></asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLSupplierMainAccType" runat="server" ID="rfvDDLSupplierMainAccType" ValidationGroup="branch"
                                    ErrorMessage="Select Supplier MainAccount Type" Text="Select Supplier MainAccount Type" class="validationred" Display="Dynamic" ForeColor="Red" InitialValue="0" />

                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">ClientMainAcNo(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtClientMainAcNo" runat="server" MaxLength="5" AutoPostBack="true" CssClass="form-control"  OnTextChanged="txtClientMainAcNo_TextChanged"/>
                                 <asp:Label ID="lblcheckclientacccode" runat="server"></asp:Label>

                                <asp:RequiredFieldValidator ControlToValidate="txtClientMainAcNo" runat="server" ID="rfvtxtClientMainAcNo" ValidationGroup="branch"
                                    ErrorMessage="Enter Client MainAcc No" Text="Enter Client MainAcc No" class="validationred" Display="Dynamic" ForeColor="Red" />

                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Client MainAcName(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                               <asp:TextBox ID="txtClientmainAccName" runat="server"  CssClass="form-control" />
                                <asp:RequiredFieldValidator ControlToValidate="txtClientmainAccName" runat="server" ID="rfvtxtClientmainAccName" ValidationGroup="branch"
                                    ErrorMessage="Enter Client MainAcc Name" Text="Enter Client MainAcc Name" class="validationred" Display="Dynamic" ForeColor="Red"  />

                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Client Account Type(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                               <asp:DropDownList ID="DDLClientaccType" runat="server" CssClass="form-control">
                                      <asp:ListItem Value="-1" Text="Item 1"></asp:ListItem>
                                    <asp:ListItem Value="0" Text="Item 2"></asp:ListItem>
                                    <asp:ListItem Value="1" Text="Item 3"></asp:ListItem>
                                    <asp:ListItem Value="2" Text="Item 4"></asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLClientaccType" runat="server" ID="rfvDDLClientaccType" ValidationGroup="branch"
                                    ErrorMessage="Select Client MainAccount Type" Text="Select Client MainAccount Type" class="validationred" Display="Dynamic" ForeColor="Red"  InitialValue="0"/>

                            </div>
                        </div>

                        <div class="form-actions">
                            <div class="span5 m-wrap"></div>
                            <div class="span4 m-wrap">
                                <asp:Button ID="Submit_Branch" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="Submit_Branch_Click" ValidationGroup="branch" />
                                <asp:Button ID="Cancel_Branch" runat="server" CssClass="btn btn-danger" OnClick="Cancel_Branch_Click" Text="Cancel" />
                                <asp:Button ID="Reset_Branch" runat="server" CssClass="btn btn-info" OnClick="Reset_Branch_Click" Text="Reset" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>


</asp:Content>



