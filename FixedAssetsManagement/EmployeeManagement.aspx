<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerSite.Master" AutoEventWireup="true" CodeBehind="EmployeeManagement.aspx.cs" Inherits="FixedAssetsManagement.EmployeeManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="AddEmployeeBtn" runat="server" Text="添加员工" class="btn btn-default" Style="float: right; margin-top: 50px" OnClick="AddEmployeeBtn_Click" />
    <asp:GridView ID="EmployeeGridView" runat="server" OnRowCommand="EmployeeGridView_RowCommand" AutoGenerateColumns="False" class="table table-hover" Style="margin-top: 100px">
        <Columns>
            <asp:BoundField DataField="EmployeeID" HeaderText="员工编号" HeaderStyle-Width="10%"/>
            <asp:BoundField DataField="EmployeeName" HeaderText="姓名" HeaderStyle-Width="20%"/>
            <asp:BoundField DataField="Telephone" HeaderText="电话" HeaderStyle-Width="20%" />
            <asp:BoundField DataField="IsManager" HeaderText="是否为管理员" HeaderStyle-Width="10%" />
            <asp:BoundField HeaderText="邮箱" HeaderStyle-Width="20%" DataField="Email" />
            <asp:TemplateField HeaderText="操作" HeaderStyle-Width="20%">
                <ItemTemplate>
                    <asp:Button ID="Button2" runat="server" CommandArgument='<%# Eval("EmployeeID") %>' Text="编辑" CommandName="EmployeeEd" class="btn btn-primary" Style="float: left; margin-left: 15%" />
                    <asp:Button ID="Button3" runat="server" CommandArgument='<%# Eval("EmployeeID") %>' CommandName="EmployeeDe" Text="删除" class="btn btn-danger" Style="float: left; margin-left: 15%" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
