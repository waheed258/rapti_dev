<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.master" AutoEventWireup="true" CodeFile="BranchList.aspx.cs"EnableEventValidation="false"  Inherits="Admin_BranchList" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
          <h4 class="page-header" style="margin: -4px;">Branch List</h4>
        <div class="panel-body">
            <div class="form-horizontal">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

                  <asp:UpdatePanel ID="UpdateSearch" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                <section class="panel">
                   
                    <div class="panel-body">

                        <div class="row">
                            <div class="col-sm-6">
                                <div class="mb-md">

                                    <asp:Button ID="btnAdd" runat="server" Text="Add" class="btn btn-primary" OnClick="btnAdd_Click" />
                                </div>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-sm-12">&nbsp</div>
                            <div class="col-sm-12">
                                <div class="col-sm-2">
                                    <asp:DropDownList ID="DropPage" runat="server" CssClass="form-control" OnSelectedIndexChanged="DropPage_SelectedIndexChanged"
                                        AutoPostBack="true">
                                        <asp:ListItem Value="10" Selected="True">10</asp:ListItem>
                                        <asp:ListItem Value="25">25</asp:ListItem>
                                        <asp:ListItem Value="50">50</asp:ListItem>
                                        <asp:ListItem Value="100">100</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-sm-2">
                                    <label class="control-label">
                                        Records per page</label>
                                </div>
                                <div class="col-sm-4">
                                </div>
                                <div class="col-sm-1">
                                    <label class="control-label">Search</label>
                                </div>

                                <div class="col-sm-3">
                                    <div class="input-group">
                                        <asp:TextBox ID="txtSearch" runat="server" placeholder="Search" CssClass="form-control"> </asp:TextBox>
                                        <span class="input-group-btn">
                                            <asp:ImageButton ID="imgsearch" runat="server" ImageUrl="../Images/icon-search.png" Height="25" Width="25" OnClick="imgsearch_Click" />
                                        </span>

                                    </div>
                                </div>
                            </div>
                        </div>

                        &nbsp;

                <asp:HiddenField ID="hf_BranchId" runat="server" Value="0" />
                   

                        <asp:GridView ID="gvBranchList" runat="server" AllowPaging="true" EmptyDataText="No Data Found" PageSize="10"
                            AutoGenerateColumns="False" CssClass="table table-bordered table-striped mb-none dataTable no-footer" OnRowDataBound="gvBranchList_RowDataBound"
                            Width="100%" OnRowCommand="gvBranchList_RowCommand" OnPageIndexChanging="gvBranchList_PageIndexChanging" OnSorting="gvBranchList_Sorting">

                            <PagerStyle BackColor="#efefef" ForeColor="black" CssClass="pagination1" />

                            <RowStyle CssClass="gradeA odd" />
                            <AlternatingRowStyle CssClass="gradeA even" />
                            <Columns>

                                <asp:TemplateField HeaderText="Branch Name">
                                    <ItemTemplate>
                                        <%#Eval("BranchName")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:TemplateField HeaderText="Active">
                                    <ItemTemplate>
                                        <%#Eval("BranchIsActive")%>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                
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

                                <asp:TemplateField HeaderText="IATA RegNo">
                                    <ItemTemplate>
                                        <%#Eval("BranchIATARegNo")%>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Vat Reg No">
                                    <ItemTemplate>
                                        <%#Eval("BranchVatRegNo")%>
                                    </ItemTemplate>
                                </asp:TemplateField>


                                <asp:TemplateField HeaderText="Actions">
                                    <ItemTemplate>
                                        <table>
                                            <tr></tr>
                                            <td>
                                                <asp:ImageButton ID="imgEdit" ToolTip="Edit" runat="server" ImageUrl="../Images/icon-edit.png" Height="20" Width="20"
                                                    CommandName="Edit Branch" CommandArgument='<%#Eval("BranchId")+","+ Eval("ConfigurationId")%>'/>
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

                </section>
            </ContentTemplate>
        </asp:UpdatePanel>
                </div>
            </div>
    

</asp:Content>

