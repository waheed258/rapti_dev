<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="CharteredAccountsList.aspx.cs" Inherits="Admin_CharteredAccountsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:ScriptManager ID="scr1" runat="server"></asp:ScriptManager>
    <div id="content-header">
        <div id="breadcrumb">
            <a href="Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">Chartered Accounts List</a><a href="CharteredAccounts.aspx">Add</a>
        </div>

    </div>

  <!--End-breadcrumbs-->
    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-align-justify"></i></span>
                        <h5>Chartered Accounts List</h5>
                    </div>
                    <asp:UpdatePanel ID="uplist" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="widget-content">
                                <div class="widget-content nopadding">
                                    <asp:HiddenField ID="hf_ChartofAccId" runat="server" Value="0" />

                                    <asp:GridView ID="gvChartofAccList" runat="server" AllowPaging="true" Width="100%" PageSize="10" OnRowCommand="gvChartofAccList_RowCommand"
                                        AutoGenerateColumns="False" DataKeyNames="" CssClass="table table-bordered data-table"
                                        ShowHeaderWhenEmpty="true">
                                        <PagerStyle BackColor="#efefef" ForeColor="black" HorizontalAlign="Left" />
                                        <Columns>

                                            <asp:TemplateField HeaderText="MainAccount Name">
                                                <ItemTemplate>
                                                    <%#Eval("MainAccountName")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                           
                                            <asp:TemplateField HeaderText="ChartedAccount Name">
                                                <ItemTemplate>
                                                    <%#Eval("ChartedAccName")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Charted AccountCode">
                                                <ItemTemplate>
                                                    <%#Eval("ChartofAccCode")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                  
                                            <%--<asp:TemplateField HeaderText="Actions">
                                                <ItemTemplate>
                                                    <table>
                                                        <tr></tr>
                                                        <td>
                                                            <asp:ImageButton ID="imgEdit" ToolTip="Edit" runat="server" ImageUrl="../Images/icon-edit.png" Height="20" Width="20"
                                                                CommandName="Edit Branch" CommandArgument='<%#Eval("BranchId")+","+ Eval("ConfigurationId")%>' />
                                                            <asp:ImageButton ID="imgDelete" ToolTip="Delete" runat="server" ImageUrl="../Images/icon-delete.png" Height="20" Width="20"
                                                                CommandName="Delete Branch" CommandArgument='<%#Eval("BranchId")+","+ Eval("ConfigurationId")%>' OnClientClick="javascript:return confirm('Are You Sure To Delete AirSupplier Details')" />

                                                        </td>
                                                    </table>
                                                </ItemTemplate>
                                            </asp:TemplateField>--%>
                                        </Columns>
                                        <EmptyDataTemplate>
                                            <h4>
                                                <asp:Label ID="lblEmptyMessage" Text="" runat="server" /></h4>
                                        </EmptyDataTemplate>
                                    </asp:GridView>
                                </div>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </div>


</asp:Content>

