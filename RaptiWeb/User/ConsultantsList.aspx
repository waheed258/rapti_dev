<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="ConsultantsList.aspx.cs" Inherits="User_ConsultantsList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="scr1" runat="server"></asp:ScriptManager>
    <div id="content-header">
        <div id="breadcrumb">
            <a href="Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">Consultant List</a><a href="Consultant.aspx">Add</a>
        </div>

    </div>
    <!--End-breadcrumbs-->
    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <div class="widget-title">
                        <span class="icon"><i class="icon-align-justify"></i></span>
                        <h5>Consultant List</h5>
                    </div>
                    <asp:UpdatePanel ID="uplist" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="widget-content">
                                <div class="widget-content nopadding">
                                    <asp:HiddenField ID="hf_ConsultantId" runat="server" Value="0" />
                                    <asp:GridView ID="GvConsultants" runat="server" AllowPaging="true" Width="100%" PageSize="10"  OnRowCommand="GvCompanyDetails_RowCommand"
                                        AutoGenerateColumns="False" DataKeyNames="" CssClass="table table-bordered data-table"
                                        ShowHeaderWhenEmpty="true">
                                        <PagerStyle BackColor="#efefef" ForeColor="black" HorizontalAlign="Left" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="Code">
                                                <ItemTemplate>
                                                    <%#Eval("ConsultantKey")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Description">
                                                <ItemTemplate>
                                                    <%#Eval("ConsultantName")%>
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Actions">
                                                <ItemTemplate>
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                <asp:ImageButton ID="imgEdit" ToolTip="Edit" runat="server" ImageUrl="../Images/icon-edit.png" Height="20" Width="20"
                                                                    CommandName="Edit Consultant Details" CommandArgument='<%#Eval("ConsultantId") %>' />
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
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </div>
    <div>
    </div>
</asp:Content>

