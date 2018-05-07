<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="Admin_User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

       <style type="text/css">
        .style1 {
            color: #FF0000;
        }

    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content-header">
        <div id="breadcrumb">
            <a href="~/Users/Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">User Master</a>
        </div>
    </div>
        <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-align-justify"></i></span>
                        <h5>New User</h5>
                    </div>
                    <div class="widget-content">
                        <div class="controls">
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                            <asp:HiddenField ID="hf_UserId" runat="server" Value="0" />
                    
                        </div>

                        <div class="controls controls-row">
                            <label class="span2 m-wrap">User Name(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control" MaxLength="30" />
                                <asp:RequiredFieldValidator ControlToValidate="txtUserName" runat="server" ID="rfvtxtUserName" ValidationGroup="user"
                                    ErrorMessage="Enter User Name" Text="Enter User Name" class="validationred" Display="Dynamic" ForeColor="Red" />
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span1 m-wrap">IsActive </label>
                            <div class="span1 m-wrap">
                                <asp:CheckBox ID="chkIsactive" runat="server" />
                            </div>
                          

                        </div>

                          <div class="controls controls-row">
                            <label class="span2 m-wrap">User Email(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:TextBox ID="txtuserMail" runat="server" CssClass="form-control" MaxLength="30" />
                                 <asp:RequiredFieldValidator ControlToValidate="txtuserMail" runat="server" ID="rfvtxtuserMail" ValidationGroup="user"
                                    ErrorMessage="Enter Mail Id" Text="Enter Mail Id" class="validationred" Display="Dynamic" ForeColor="Red" />
                            
                            </div>
                            <div class="span2 m-wrap"></div>
                            <label class="span2 m-wrap">Phone No</label>
                            <div class="span3 m-wrap">
                                <asp:TextBox ID="txtPhoneNo" runat="server" CssClass="form-control" MaxLength="50" />
                              
                            </div>
                        </div>
                         <div class="controls controls-row">
                            <label class="span2 m-wrap">User Role(<span class="style1">*</span>)</label>
                            <div class="span3 m-wrap">
                              <asp:DropDownList ID="DDLRole" AutoPostBack="true"  runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                 <asp:RequiredFieldValidator ControlToValidate="DDLRole" runat="server" ID="rfvDDLRole" ValidationGroup="user"
                                    ErrorMessage="Select Role" Text="Select Role" class="validationred" Display="Dynamic" ForeColor="Red"  InitialValue="0"/>
                            
                            </div>
                            <div class="span1 m-wrap"></div>
                            <label class="span2 m-wrap">Branch(<span class="style1">*</span>)</label>
                            <div class="span2 m-wrap">
                                <asp:DropDownList ID="DDLBranch" AutoPostBack="true"  runat="server" CssClass="form-control">
                                </asp:DropDownList>
                                 <asp:RequiredFieldValidator ControlToValidate="DDLBranch" runat="server" ID="rfvDDLBranch" ValidationGroup="user"
                                    ErrorMessage="Select Branch" Text="Select Branch" class="validationred" Display="Dynamic" ForeColor="Red"  InitialValue="0"/>
                            
                            </div>
                        </div>

                             <div class="form-actions">
                            <div class="span5 m-wrap"></div>
                            <div class="span4 m-wrap">
                                <asp:Button ID="Submit_User" runat="server" CssClass="btn btn-success" Text="Submit" OnClick="Submit_User_Click" ValidationGroup="user" />
                                <asp:Button ID="Cancel_User" runat="server" CssClass="btn btn-danger" OnClick="Cancel_User_Click" Text="Cancel" />
                                <asp:Button ID="Reset_User" runat="server" CssClass="btn btn-info" OnClick="Reset_User_Click" Text="Reset" />
                            </div>
                        </div>

                        </div>
                    </div>
                </div>
            </div></div>
    

</asp:Content>

