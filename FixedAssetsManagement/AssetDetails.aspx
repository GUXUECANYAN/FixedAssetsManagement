<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AssetDetails.aspx.cs" Inherits="FixedAssetsManagement.AssetDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="fvAssetDetails" runat="server"
        ItemType="FixedAssetsManagement.Models.Asset" SelectMethod="GetAsset" RenderOuterTable="false">
        <ItemTemplate>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/images/Assets/<%#:Item.AssetImage %>" style="border: none; height: 200px"
                            alt="<%#:Item.AssetName %>" />
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align: left;">
                        <h4><b><%#:Item.AssetName %></b></h4>
                        <b>资产编号:</b><%#:Item.AssetID %>
                        <br />
                        <b>购买日期:</b><%#:Item.PurchaseDate %>
                        <br />
                        <b>存放位置:</b><%#:Item.StorageLocation %>
                        <br />
                        <b>价格:</b>&nbsp;<%#: String.Format("{0:c}", Item.AssetPrice) %>
                        <br />
                        <b>规格:</b>
                        <%#:Item.AssetSpecification %>
                        <br />
                        <b>分类:</b>
                        <%#:Item.AssetCategory.AssetCategoryName %>
                        <br />
                        <b>保管人:</b>
                        <%#:Item.Employee.EmployeeName %>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
