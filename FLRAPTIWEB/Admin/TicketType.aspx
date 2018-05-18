﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="TicketType.aspx.cs" Inherits="Admin_TicketType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
            <h2 class="panel-title">New Ticket Type</h2>
       </header>
       <asp:HiddenField ID="hf_TId" runat="server" Value="0" />
       <div class="panel-body">
          <div class="col-sm-12"></div>
          <div class="form-group">
            <div class="col-sm-12">
               <div class="col-sm-2">
                        <label class="control-label">Key(<span class="style1">*</span>)</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtKey" runat="server" CssClass="form-control" MaxLength="3" OnTextChanged="txtKey_TextChanged" AutoPostBack="true"/>
                        <asp:RequiredFieldValidator ControlToValidate="txtKey" runat="server" ID="rfvtxtKey" ValidationGroup="Ticket"
                        ErrorMessage="Enter Key" Text="Enter Key" Display="Dynamic" ForeColor="Red"/>
                    </div>
                    <div class="col-sm-1"></div>
                    <div class="col-sm-2">
                        <label class="control-label">Description(<span class="style1">*</span>)</label>
                    </div>
                    <div class="col-sm-3">
                        <asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" MaxLength="40" OnTextChanged="txtDescription_TextChanged" AutoPostBack="true"/>
                        <asp:RequiredFieldValidator ControlToValidate="txtDescription" runat="server" ID="rfvtxtDescription" ValidationGroup="Ticket"
                        ErrorMessage="Enter Description" Text="Enter Description" Display="Dynamic" ForeColor="Red"/>
                         <asp:RegularExpressionValidator ControlToValidate="txtDescription" runat="server" ForeColor="Red"
                            ID="revtxtDescription" ValidationGroup="Ticket" ErrorMessage="Enter Only Characters."
                            Text="Enter Only Characters." ValidationExpression="[a-zA-Z][a-zA-Z ]+"
                            Display="Dynamic"></asp:RegularExpressionValidator>
                    </div>
            </div>
          </div>
          <div class="form-group">
            <div class="col-sm-4">
            </div>
            <div class="col-sm-4">
                <asp:Button runat="server" ID="btnSubmit" class="btn btn-success" ValidationGroup="Ticket"
                    Text="Submit"
                        UseSubmitBehavior="false" 
                                                OnClientClick="this.disabled='true';this.value='Please Wait...' "
                     OnClick="btnSubmit_Click"/>&nbsp;<asp:Button runat="server" ID="btnCancel"
                        class="btn btn-danger" Text="Cancel" OnClick="btnCancel_Click"/>&nbsp;<asp:Button runat="server" ID="btnReset"
                            class="btn btn-primary green" Text="Reset" OnClick="btnReset_Click"/>

            </div>
        </div>
       </div>
    </section>
</asp:Content>

