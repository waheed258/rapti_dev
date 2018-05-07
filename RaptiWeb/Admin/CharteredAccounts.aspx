<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="CharteredAccounts.aspx.cs" Inherits="Admin_CharteredAccounts" %>

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
            <a href="#" class="current">Chartered Account Master</a>
        </div>
    </div>

    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-align-justify"></i></span>
                        <h5>New Chartered Account</h5>
                    </div>
                    <div class="widget-content">
                        <div class="controls">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            <asp:HiddenField ID="hf_CharteredofaccountId" runat="server" Value="0" />
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Name(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtchartofaccName" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtchartofaccName" runat="server" ID="rfvtxtchartofaccName" ValidationGroup="ChartofAccount"
                                    ErrorMessage="Enter Account Name" Text="Enter Branch Name" class="validationred" Display="Dynamic" ForeColor="Red" />
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Master Account(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">

                                <asp:DropDownList ID="DDLMasterAcc" AutoPostBack="true" OnSelectedIndexChanged="DDLMasterAcc_SelectedIndexChanged" runat="server" CssClass="form-control">                                 
                                     </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLMasterAcc" runat="server" ID="rfvDDLMasterAcc" ValidationGroup="ChartofAccount"
                                    ErrorMessage="Select MasterAccount" Text="Select MasterAccount" class="validationred" Display="Dynamic" ForeColor="Red" />
                            </div>
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">Account Code(<span class="style1">*</span>)</label>
                            <div class="span1 m-wrap">
                                <asp:TextBox ID="txtMainAccCode" runat="server" CssClass="form-control" ReadOnly="true" Style="width: 85px;" />
                            </div>
                            <%--<div class="span1 m-wrap"></div>--%>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtChartofAcc" runat="server" CssClass="form-control" AutoPostBack="true" OnTextChanged="txtChartofAcc_TextChanged" Style="width: 135px;" />
                                <asp:RequiredFieldValidator ControlToValidate="txtChartofAcc" runat="server" ID="rfvtxtChartofAcc" ValidationGroup="ChartofAccount"
                                    ErrorMessage="Enter Account Code" Text="Enter Account Code" class="validationred" Display="Dynamic" ForeColor="Red" />
                            <asp:Label ID="lblcheckacccode" runat="server"></asp:Label>
                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Category(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">                              
                                   <asp:DropDownList ID="DDLCategory" AutoPostBack="true"  runat="server" CssClass="form-control">
                                       <asp:ListItem Value="0" Text="--Select Category--"></asp:ListItem>
                                        <asp:ListItem Value="1" Text="AirTicket"></asp:ListItem>
                                        <asp:ListItem Value="2" Text="Land"></asp:ListItem>
                                </asp:DropDownList>
                                <asp:RequiredFieldValidator ControlToValidate="DDLCategory" runat="server" ID="rfvDDLCategory" ValidationGroup="ChartofAccount"
                                    ErrorMessage="Select Category" Text="Select Category" class="validationred" Display="Dynamic" InitialValue="0" ForeColor="Red" />

                            </div>

                        </div>

                        <div class="controls controls-row">
                            
                        </div>

                        <div class="form-actions">
                            <div class="span5 m-wrap"></div>
                            <div class="span4 m-wrap">
                                <asp:Button ID="Submit_ChartofAcc" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="Submit_ChartofAcc_Click" ValidationGroup="ChartofAccount" />
                                <asp:Button ID="Cancel_ChartofAcc" runat="server" CssClass="btn btn-danger" OnClick="Cancel_ChartofAcc_Click" Text="Cancel" />
                                <asp:Button ID="Reset_ChartofAcc" runat="server" CssClass="btn btn-info" OnClick="Reset_ChartofAcc_Click" Text="Reset" />
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

