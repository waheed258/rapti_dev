﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="GroupTypes.aspx.cs" Inherits="Admin_GroupTypes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1 {
            color: #FF0000;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
    <asp:HiddenField ID="hf_Id" runat="server" Value="0" />
    <section class="panel">
        <header class="panel-heading">
            <div class="panel-actions">
                <a href="#" class="panel-action panel-action-toggle" data-panel-toggle=""></a>
            </div>
            <h2 class="panel-title">New Group Type</h2>
        </header>
        <div class="panel-body">
            <div class="form-group">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label class="control-label">
                            Key(<span class="style1">*</span>)
                        </label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtKey" runat="server" CssClass="form-control" MaxLength="3" />
                        <asp:RequiredFieldValidator ControlToValidate="txtKey" runat="server" ID="rfvtxtKey"
                            Display="Dynamic" Text="Enter Key." ErrorMessage="Enter Key." ValidationGroup="grouptypes" ForeColor="Red" />
                    </div>


                    <div class="col-sm-1"></div>
                    <div class="col-sm-2">
                        <label class="control-label">
                            Description(<span class="style1">*</span>)
                        </label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" MaxLength="50" />
                        <asp:RequiredFieldValidator ControlToValidate="txtDescription" runat="server" ID="rfvtxtDescription"
                            Display="Dynamic" Text="Enter Description." ErrorMessage="Enter Description." ValidationGroup="grouptypes" ForeColor="Red" />
                        <asp:RegularExpressionValidator ControlToValidate="txtDescription" runat="server"
                            ID="revtxtDescription" ValidationGroup="grouptypes" ErrorMessage="Enter Only Characters.."
                            Text="Enter Only Characters.." ValidationExpression="[a-zA-Z][a-zA-Z ]+"
                            Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
                    </div>

                </div>
            </div>
            <div class="form-group">
                <div class="col-sm-12">
                    <div class="col-sm-2">
                        <label class="control-label">
                            GroupType
                        </label>
                    </div>
                    <div class="col-sm-3">
                        <asp:DropDownList ID="ddlGroupType" runat="server" CssClass="form-control">
                             <asp:ListItem Text="--Select--" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="Client" Value="Client"></asp:ListItem>
                            <asp:ListItem Text="Consultant" Value="Consultant"></asp:ListItem>
                        </asp:DropDownList>
                      <%--  <asp:RequiredFieldValidator ControlToValidate="ddlGroupType" runat="server" ID="rfvddlGroupType"
                            Display="Dynamic" Text="Select GroupType." ErrorMessage="Select GroupType." ValidationGroup="grouptypes" ForeColor="Red" InitialValue="-1" />--%>
                    </div>
                    <div class="col-sm-1"></div>
                </div>
            </div>

            <div class="form-group">
                <div class="col-sm-5">
                </div>
                <div class="col-sm-3">
                    <asp:Button runat="server" ID="cmdSubmit" class="btn btn-success" ValidationGroup="grouptypes"
                        Text="Submit" 
                          UseSubmitBehavior="false" 
                                                OnClientClick="this.disabled='true';this.value='Please Wait...' "
												
                        OnClick="cmdSubmit_Click"/>&nbsp;<asp:Button runat="server" ID="btnCancel"
                        class="btn btn-danger" Text="Cancel" OnClick="btnCancel_Click" />&nbsp;<asp:Button ID="btnreset" runat="server" CssClass="btn btn-primary blue" Text="Reset" OnClick="btnreset_Click"/>

                </div>
            </div>
        </div>
    </section>
</asp:Content>

