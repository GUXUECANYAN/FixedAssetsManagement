<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerSite.Master" AutoEventWireup="true" CodeBehind="AssetCategoryManagement.aspx.cs" Inherits="FixedAssetsManagement.AssetCategoryManagement"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="AddAssetCategoryBtn" runat="server" Text="添加资产类别" class="btn btn-default" style="float:right;margin-top:50px" OnClick="AddAssetCategoryBtn_Click"/>
    <asp:GridView ID="AssetCategoryGridView" runat="server" OnRowCommand="AssetCategoryGridView_RowCommand" AutoGenerateColumns="False" class="table table-hover" Style="margin-top: 100px">
        <Columns>
            <asp:BoundField DataField="AssetCategoryID" HeaderText="类别编号" HeaderStyle-Width="10%" />
            <asp:BoundField DataField="AssetCategoryName" HeaderText="类别名称" HeaderStyle-Width="20%" />
            <asp:BoundField DataField="AssetCategoryDescription" HeaderText="类别说明" />
            <asp:TemplateField HeaderText="操作" HeaderStyle-Width="20%">
                <ItemTemplate>
                    <asp:Button ID="Button2" runat="server" CommandArgument='<%# Eval("AssetCategoryID") %>' Text="编辑" CommandName="AssetCategoryEd" class="btn btn-primary" Style="float:left;margin-left:15%" />
                    <asp:Button ID="Button3" runat="server" CommandArgument='<%# Eval("AssetCategoryID") %>' CommandName="AssetCategoryDe" Text="删除" class="btn btn-danger" Style="float:left;margin-left:15%"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
