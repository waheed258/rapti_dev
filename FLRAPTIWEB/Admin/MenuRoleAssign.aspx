<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="MenuRoleAssign.aspx.cs" Inherits="Admin_MenuRoleAssign" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content-header">
        <%--   <div id="breadcrumb"><a href="#" title="Go to Home" class="tip-bottom"><i class="icon-home"></i>Branch Master</a></div>--%>
        <div id="breadcrumb">
            <a href="~/Users/Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">Role Assign</a>
        </div>
    </div>
      <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="fa fa-list"></i></span>
                        <h5>Menu Access By Role</h5>
                    </div>
                    <div class="widget-content">
                         <div>
                            <asp:Label ID="lblMsg" runat="server"></asp:Label>
                        </div>
                         <div class="controls controls-row">
                              <label class="span2 m-wrap">Role Name</label>
                             <asp:DropDownList ID="ddlRoles" runat="server" CssClass="span2 m-wrap" AppendDataBoundItems="true" AutoPostBack="true" 
                                  OnSelectedIndexChanged="ddlRoles_SelectedIndexChanged" >
                                <asp:ListItem Value="-1" Text="Select" />
                            </asp:DropDownList>
                             <label class="span2 m-wrap">Assign Role to </label>
                            <asp:DropDownList ID="ddlConsultants" runat="server" CssClass="span2 m-wrap" AppendDataBoundItems="true" >
                                <asp:ListItem Value="-1" Text="-Consultant-" />
                            </asp:DropDownList>
                            <div class="span1 m-wrap">
                                <asp:Button ID="btnAssign" runat="server" Text="Assign"   OnClick="btnAssign_Click"  
                                    CssClass="btn btn-success" />
                            </div>
                             </div>
                        </div>
                     <div class="widget-content nopadding">
                        <div class="form-horizontal">
                            <asp:GridView ID="gvRAL" runat="server" AllowPaging="true"  EmptyDataText="No records found" DataKeyNames="" 
                                AutoGenerateColumns="False" Width="100%" PageSize="15" OnRowCommand="gvRAL_RowCommand" 
                                OnRowDataBound="gvRAL_RowDataBound" OnRowEditing="gvRAL_RowEditing"
                                 OnPageIndexChanging="gvRAL_PageIndexChanging" OnRowUpdating="gvRAL_RowUpdating" OnRowCancelingEdit="gvRAL_RowCancelingEdit">
                            <PagerStyle BackColor="#efefef" ForeColor="black" HorizontalAlign="Left" CssClass="pagination" />
                                 <AlternatingRowStyle  BackColor="#ccffff"/>
                            <Columns>
                                <asp:TemplateField HeaderText="S.No" HeaderStyle-CssClass="panel-heading" ItemStyle-CssClass="gradeC">
                                    <ItemTemplate>
                                        <%#Container.DataItemIndex+1 %>
                                        <asp:Label ID="hfMenuId" runat="server" CssClass="hidden" Text='<%#Eval("MenuId")%>'></asp:Label>
                                        <asp:Label ID="hfMenuAccessId" runat="server" CssClass="hidden" Text='<%#Eval("MenuAccessId")%>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Menu Name">
                                    <ItemTemplate>
                                        <%#Eval("MenuName") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Menu Description">
                                    <ItemTemplate >
                                        <asp:Label ID="lblMeuDesc" runat="server" text='<%#Eval("MenuDescription") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Url">
                                    <ItemTemplate>
                                        <asp:Label ID="lblUrl" runat="server" text='<%#Eval("Url") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Sequence">
                                    <ItemTemplate>
                                        <%#Eval("Sequence")%>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Parent Menu Id">
                                    <ItemTemplate>
                                        <%#Eval("ParentMenuId")%>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Access">
                                    <ItemTemplate>
                                        <%#Eval("MenuAccess").ToString() == "1" ? "Yes" : "No"%>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:DropDownList Width="80px" ID="ddlMenuAccess" runat="server" SelectedValue='<%#Eval("MenuAccess").ToString() == "1" ? "1" : "0" %>'>
                                            <asp:ListItem Value="0" Text="No" />
                                            <asp:ListItem Value="1" Text="Yes" />
                                        </asp:DropDownList>
                                    </EditItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:ImageButton ID="imgEdit" ToolTip="Edit Record" runat="server" ImageUrl="~/images/Icons/icon-edit.png" Height="20" Width="20"
                                            CommandName="Edit" CommandArgument='<%#Eval("MenuId") %>' />
                                        <%--<span onclick="return confirm('Do you want to delete the record ?')">
                                            <asp:ImageButton ID="imgDelete" ToolTip="Edit Record" runat="server" ImageUrl="~/Admin/Images/icons/icon-delete.png" Height="20" Width="20"
                                                CommandName="Delete" CommandArgument='<%#Eval("MenuId") %>' />
                                        </span>--%>
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:ImageButton ID="imgUpdate" ToolTip="Edit Record" runat="server" ImageUrl="~/images/Icons/icon-update.png" Height="20" Width="20"
                                            CommandName="Update" CommandArgument='<%#Eval("MenuId") %>' />
                                        <asp:ImageButton ID="imgCancel" ToolTip="Edit Record" runat="server" ImageUrl="~/images/Icons/icon-cancel.png" Height="20" Width="20"
                                            CommandName="Cancel" CommandArgument='<%#Eval("MenuId") %>' />
                                    </EditItemTemplate>
                                </asp:TemplateField>
                            </Columns>

                        </asp:GridView>
                        </div>
                    </div>
                    </div>
                </div>
            </div>
          </div>
</asp:Content>

