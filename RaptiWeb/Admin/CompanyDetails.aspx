<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" EnableEventValidation="false" AutoEventWireup="true" CodeFile="CompanyDetails.aspx.cs" Inherits="Admin_CompanyDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h3>Company Details</h3>
    <hr />
    Comming Soon.....

    <div>
        <asp:HiddenField ID="hf_CompanyId" runat="server" Value="0" />
        <asp:GridView ID="GvCompanyDetails" runat="server" AllowPaging="true" Width="100%" PageSize="10" OnRowCommand="GvCompanyDetails_RowCommand"
            AutoGenerateColumns="False" DataKeyNames="" CssClass="table table-striped table-bordered"  
               ShowHeaderWhenEmpty="true">
            <PagerStyle BackColor="#efefef" ForeColor="black" HorizontalAlign="Left"   />
            <Columns>
                <asp:TemplateField HeaderText="Code">
                    <ItemTemplate>
                        <%#Eval("CompanyId")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <%#Eval("CompanyName")%>
                    </ItemTemplate>
                </asp:TemplateField>
                 
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td>
                                    <asp:ImageButton ID="imgEdit" ToolTip="Edit" runat="server" ImageUrl="~/images/icon-edit.png" Height="20" Width="20"
                                        CommandName="Edit Currency Details" CommandArgument='<%#Eval("CompanyId") %>' />
                                   <%-- <asp:ImageButton ID="imgDelete" ToolTip="Delete" runat="server" ImageUrl="~/images/icon-delete.png" Height="20" Width="20"
                                        CommandName="Delete Currency Details" CommandArgument='<%#Eval("Id") %>' OnClientClick="javascript:return confirm('Are You Sure You Want To Delete Currency Details')" />--%>
                                </td>
                            </tr>
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
</asp:Content>

