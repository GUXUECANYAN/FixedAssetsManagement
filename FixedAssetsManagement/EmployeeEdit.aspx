<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerSite.Master" AutoEventWireup="true" CodeBehind="EmployeeEdit.aspx.cs" Inherits="FixedAssetsManagement.EmployeeEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="fvEmployee" runat="server"
        ItemType="FixedAssetsManagement.Models.Employee" SelectMethod="GetEmployee" RenderOuterTable="false">
        <ItemTemplate>
            <div class="form-horizontal col-sm-offset-3" style="margin-top: 30px">
                <div class="form-group">
                    <asp:Label ID="Label6" runat="server" Text="员工编号" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="EmployeeIDTxt" runat="server" class="form-control" Text="<%# Item.EmployeeID %>" ReadOnly></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="姓名" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="EmployeeNameTxt" runat="server" class="form-control" Text="<%# Item.EmployeeName %>"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="密码" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="EmployeePasswordTxt" runat="server" class="form-control" Text="<%# Item.Password %>"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="电话" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="EmployeeTelephoneTxt" runat="server" class="form-control" Text="<%# Item.Telephone %>"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="邮箱" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="EmployeeEmailTxt" runat="server" class="form-control" Text="<%# Item.Email %>"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="是否为管理员" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:CheckBox ID="IsManagerCheckBox" runat="server" Text="是管理员" Checked="<%# Item.IsManager %>"/>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-3 col-sm-6">
                        <asp:Button ID="SaveEmployeeBtn" runat="server" Text="修改" class="btn btn-primary" OnClick="SaveEmployeeBtn_Click" />
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
