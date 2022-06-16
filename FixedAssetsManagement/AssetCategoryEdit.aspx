<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerSite.Master" AutoEventWireup="true" CodeBehind="AssetCategoryEdit.aspx.cs" Inherits="FixedAssetsManagement.AssetCategoryEdit"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="fvAssetCategory" runat="server"
        ItemType="FixedAssetsManagement.Models.AssetCategory" SelectMethod="GetAssetCategory" RenderOuterTable="false">
        <ItemTemplate>
            <div class="form-horizontal col-sm-offset-3" style="margin-top: 30px">
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="资产类别编号" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="AssetCategoryIDTxt" runat="server" class="form-control" Text="<%# Item.AssetCategoryID %>" ReadOnly></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="资产类别名称" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="AssetCategoryNameTxt" runat="server" class="form-control" Text="<%# Item.AssetCategoryName %>"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="资产类别说明" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="AssetCategoryDescriptionTxt" runat="server" class="form-control" Text="<%# Item.AssetCategoryDescription %>"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-3 col-sm-6">
                        <asp:Button ID="SaveAssetCategoryBtn" runat="server" Text="修改" class="btn btn-primary" OnClick="SaveAssetCategoryBtn_Click" />
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
