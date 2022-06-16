<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerSite.Master" AutoEventWireup="true" CodeBehind="AssetCategoryAdd.aspx.cs" Inherits="FixedAssetsManagement.AssetCategoryAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal" style="width: 42%; margin: auto; margin-top: 30px">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="资产类别名称" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="AssetCategoryNameTxt" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="资产类别说明" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="AssetCategoryDescriptionTxt" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-4 col-sm-10">
                <asp:Button ID="SaveAssetCategoryBtn" runat="server" Text="添加类别" class="btn btn-primary" OnClick="AddAssetCategoryBtn_Click" />
            </div>
        </div>
    </div>
</asp:Content>
