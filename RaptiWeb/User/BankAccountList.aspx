<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="BankAccountList.aspx.cs" Inherits="User_BankAccountList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

       <asp:ScriptManager ID="scr1" runat="server"></asp:ScriptManager>
    <div id="content-header">
        <div id="breadcrumb">
            <a href="Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">BankAccount List</a><a href="BankAccount.aspx">Add</a>
        </div>

 </div>
    <!--End-breadcrumbs-->
    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-align-justify"></i></span>
                        <h5>BankAccount List</h5>
                    </div>
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    <asp:UpdatePanel ID="uplist" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="widget-content">
                                <div class="widget-content nopadding">
                                    <asp:HiddenField ID="hf_BankAccountId" runat="server" Value="0" />

                                    <asp:GridView ID="gvBankAccountList" runat="server" AllowPaging="true" Width="100%" PageSize="10" OnRowCommand="gvBankAccountList_RowCommand"
                                        AutoGenerateColumns="False" DataKeyNames="" OnRowDataBound="gvBankAccountList_RowDataBound" CssClass="table table-bordered data-table"
                                        ShowHeaderWhenEmpty="true">
                                        <PagerStyle BackColor="#efefef" ForeColor="black" HorizontalAlign="Left" />
                                        <Columns>

                                            <asp:TemplateField HeaderText="Bank Key">
                                                <ItemTemplate>
                                                    <%#Eval("BankKey")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="AccountName">
                                                <ItemTemplate>
                                                    <%#Eval("AccountName")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="AccountNo">
                                                <ItemTemplate>
                                                    <%#Eval("AccountNo")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="AccountHolder">
                                                <ItemTemplate>
                                                    <%#Eval("AccountHolder")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="DeActivate">
                                                <ItemTemplate>
                                                    <%#Eval("DeActivate")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Actions">
                                                <ItemTemplate>
                                                    <table>
                                                        <tr></tr>
                                                        <td>
                                                            <asp:ImageButton ID="imgEdit" ToolTip="Edit" runat="server" ImageUrl="../Images/icon-edit.png" Height="20" Width="20"
                                                                CommandName="Edit Bank" CommandArgument='<%#Eval("BankId")%>' />
                                                            <asp:ImageButton ID="imgDelete" ToolTip="Delete" runat="server" ImageUrl="../Images/icon-delete.png" Height="20" Width="20"
                                                                CommandName="Delete Bank" CommandArgument='<%#Eval("BankId")%>' OnClientClick="javascript:return confirm('Are You Sure To Delete AirSupplier Details')" />

                                                        </td>
                                                    </table>
                                                </ItemTemplate>
                                            </asp:TemplateField>
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

