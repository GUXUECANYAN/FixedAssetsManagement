<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerSite.Master" AutoEventWireup="true" CodeBehind="EmployeeAdd.aspx.cs" Inherits="FixedAssetsManagement.EmployeeAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal" style="width: 42%; margin: auto; margin-top: 30px">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="姓名" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="EmployeeNameTxt" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="密码" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="EmployeePasswordTxt" runat="server" class="form-control" Text="123456"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="电话" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="EmployeeTelephoneTxt" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="邮箱" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="EmployeeEmailTxt" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="是否为管理员" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:CheckBox ID="IsManagerCheckBox" runat="server" Text="是管理员" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-4 col-sm-10">
                <asp:Button ID="SaveEmployeeBtn" runat="server" Text="添加员工" class="btn btn-primary" OnClick="AddEmployeeBtn_Click" />
            </div>
        </div>
    </div>
</asp:Content>
