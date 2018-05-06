<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="BranchList.aspx.cs" EnableEventValidation="false" Inherits="Admin_BranchList" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:ScriptManager ID="scr1" runat="server"></asp:ScriptManager>
    <div id="content-header">
        <div id="breadcrumb">
            <a href="Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">Branch List</a><a href="Branch.aspx">Add</a>
        </div>

    </div>
    <!--End-breadcrumbs-->
    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-align-justify"></i></span>
                        <h5>Branch List</h5>
                    </div>
                    <asp:UpdatePanel ID="uplist" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="widget-content">
                                <div class="widget-content nopadding">
                                    <asp:HiddenField ID="hf_BranchId" runat="server" Value="0" />

                                    <asp:GridView ID="gvBranchList" runat="server" AllowPaging="true" Width="100%" PageSize="10" OnRowCommand="gvBranchList_RowCommand"
                                        AutoGenerateColumns="False" DataKeyNames="" CssClass="table table-bordered data-table"
                                        ShowHeaderWhenEmpty="true">
                                        <PagerStyle BackColor="#efefef" ForeColor="black" HorizontalAlign="Left" />
                                        <Columns>

                                            <asp:TemplateField HeaderText="Branch Name">
                                                <ItemTemplate>
                                                    <%#Eval("BranchName")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <%--  <asp:TemplateField HeaderText="Active">
                                    <ItemTemplate>
                                        <%#Eval("BranchIsActive")%>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>

                                            <asp:TemplateField HeaderText="Branch Code">
                                                <ItemTemplate>
                                                    <%#Eval("BranchCode")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Email">
                                                <ItemTemplate>
                                                    <%#Eval("BranchEmail")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Co Reg No">
                                                <ItemTemplate>
                                                    <%#Eval("BranchCoRegNo")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>



                                            <asp:TemplateField HeaderText="Vat Reg No">
                                                <ItemTemplate>
                                                    <%#Eval("BranchVatRegNo")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Country">
                                                <ItemTemplate>
                                                    <%#Eval("CountryName")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Actions">
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

