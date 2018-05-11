<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="CashBookList.aspx.cs" Inherits="User_CashBookList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="scr1" runat="server"></asp:ScriptManager>
    <div id="content-header">
        <div id="breadcrumb">
            <a href="Index.aspx" class="tip-bottom" data-original-title="Go to Home"><i class="icon-home"></i>Home</a>
            <a href="#" class="current">Cash Book Type List</a><a href="CashBookType.aspx">Add</a>
        </div>

    </div>
   <!--End-breadcrumbs-->
    <div class="container-fluid">
        <div class="row-fluid">
            <div class="span12">
                <div class="widget-box">
                    <asp:UpdateProgress ID="UpdateProgress1" runat="server" AssociatedUpdatePanelID="uplist">
                        <ProgressTemplate>
                            <div id="loadingDiv">
                                <div style="margin: 14% 40%;">
                                    <div class="ui yellow huge icon header" id="dimmmer">

                                        <div class="loading" style="padding: 50px 22px; font-weight: bold; color: rgb(40, 56, 145)">
                                            Please Wait..
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ProgressTemplate>
                    </asp:UpdateProgress>
                    <asp:UpdatePanel ID="uplist" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="widget-title">
                                <span class="icon" style="color: white;"><i class="icon-align-justify"></i></span>
                                <h5>Cash Book Type  List</h5>
                            </div>

                            <div class="widget-content">
                                <div>
                                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                                <asp:HiddenField ID="hf_CashBookId" runat="server" Value="0" />
                                </div>
                                <div class="controls controls-row">
                                    <div class="span1 m-wrap">
                                        <asp:DropDownList ID="ddlRecords" runat="server" AutoPostBack="true" CssClass="droprecords"
                                            OnSelectedIndexChanged="ddlRecords_SelectedIndexChanged" style="width:64px;">
                                            <asp:ListItem Text="10" Value="10" />
                                            <asp:ListItem Text="25" Value="25" />
                                            <asp:ListItem Text="50" Value="50" />
                                            <asp:ListItem Text="100" Value="100" />
                                        </asp:DropDownList>
                                    </div>
                                    <label class="span2 m-wrap">Records per page</label>
                                    <div class="span4 m-wrap"></div>
                                    <div class="span2 m-wrap">
                                        <%--<div class="searchDiv">
                                            Refresh page 
                                        <asp:ImageButton ID="imgRefresh" runat="server" ImageUrl="../Images/icons/refresh.png" CssClass="searchIcon"
                                            OnClick="imgRefresh_Click" style="width:64px;"/>
                                        </div>--%>
                                    </div>
                                    <div class="span2 m-wrap">
                                        <asp:TextBox ID="txtSearch" runat="server" placeholder="Search..." ValidationGroup="Search" CssClass="span12 m-wrap" />
                                    </div>
                                    <div class="span1 m-wrap" style="margin-left: 0px;">
                                        <asp:ImageButton ID="cmdSearch" ImageUrl="../Images/icons/icon-search.png" runat="server" Height="30px"
                                            ToolTip="Search..." OnClick="cmdSearch_Click" ValidationGroup="Search" />
                                    </div>
                                </div>

                                <div class="widget-content nopadding">
                                    <asp:GridView ID="gvCashBookList" runat="server" AllowPaging="true" EmptyDataText="No records found" DataKeyNames="CashBookId"
                                        AutoGenerateColumns="False" OnPageIndexChanging="gvCashBookList_PageIndexChanging" CssClass="table table-bordered"
                                        Width="100%" PageSize="10" usecustompager="true" OnRowCommand="gvCashBookList_RowCommand" OnRowDataBound="gvCashBookList_RowDataBound">
                                        <AlternatingRowStyle CssClass="gridcolor" />
                                        <PagerSettings Mode="Numeric" Position="Bottom" />
                                        <PagerStyle BackColor="#efefef" ForeColor="black" HorizontalAlign="Left" CssClass="pagination" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="S.No" HeaderStyle-CssClass="panel-heading" ItemStyle-CssClass="gradeC">
                                                <ItemTemplate>
                                                    <%# Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Code">
                                                        <ItemTemplate>
                                                            <%#Eval("CashBookKey")%>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>

                                                    <asp:TemplateField HeaderText="Name">
                                                        <ItemTemplate>
                                                            <%#Eval("CashDescription")%>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>

                                                    <asp:TemplateField HeaderText="Default Action">
                                                        <ItemTemplate>
                                                            <%#Eval("TransName")%>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>

                                                    <asp:TemplateField HeaderText="Default GI">
                                                        <ItemTemplate>
                                                            <%#Eval("GICode")%>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>

                                                    <asp:TemplateField HeaderText="Ref Format">
                                                        <ItemTemplate>
                                                            <%#Eval("ReferenceFormat")%>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>

                                                    <asp:TemplateField HeaderText="VAT Code">
                                                        <ItemTemplate>
                                                            <%#Eval("VatCodes")%>
                                                        </ItemTemplate>
                                                    </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Actions">
                                                <ItemTemplate>
                                                    <table>
                                                        <tr>
                                                                <td>
                                                                    <asp:ImageButton ID="imgEdit" ToolTip="Edit" runat="server" ImageUrl="../Images/icon-edit.png" Height="20" Width="20"
                                                                        CommandName="Edit Cash" CommandArgument='<%#Eval("CashBookId") %>' />
                                                                    <asp:ImageButton ID="imgDelete" ToolTip="Delete" runat="server" ImageUrl="../Images/icon-delete.png" Height="20" Width="20"
                                                                        CommandName="Delete Cash" CommandArgument='<%#Eval("CashBookId") %>' OnClientClick="javascript:return confirm('Are You Sure To Delete CashBook Details')" />

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
</asp:Content>


