<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerSite.Master" AutoEventWireup="true" CodeBehind="AssetManagement.aspx.cs" Inherits="FixedAssetsManagement.AssetManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!--下面放网站主要图片 -->
    <div id="TitleContent" style="text-align: center">
        <a runat="server" href="~/">
            <asp:Image ID="Image1" runat="server" ImageUrl="/images/zhaoqinguniversity.jpg" BorderStyle="None" Height="180px" Width="438px" />
        </a>
        <br />
    </div>
    <asp:Panel ID="Panel1" runat="server" Style="position: absolute; top: 35%; left: 50%; transform: translateX(-50%);width:800px">
        <asp:DropDownList ID="AssetDropDownList" runat="server" Style="float: left; width: 150px" CssClass="form-control">
            <asp:ListItem Value="AssetID">资产编号</asp:ListItem>
            <asp:ListItem Value="AssetName">资产名称</asp:ListItem>
            <asp:ListItem Value="AssetCategory">资产类别</asp:ListItem>
            <asp:ListItem Value="AssetPurchaseDate">购入日期</asp:ListItem>
            <asp:ListItem Value="AssetLocation">存放位置</asp:ListItem>
            <asp:ListItem Value="AssetEmployee">保管人姓名</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="SearchAssetTxt" runat="server" class="form-control" Style="float: left"></asp:TextBox>
        <asp:Button ID="SearchAssetBtn" runat="server" Text="搜索" OnClick="SearchAssetBtn_Click" class="btn btn-primary" />
        <asp:Label ID="MessageLabel" runat="server" ForeColor="Red"></asp:Label>
        <asp:Button ID="AddAssetBtn" runat="server" Text="添加资产" class="btn btn-default" Style="float:right" OnClick="AddAssetBtn_Click" />
    </asp:Panel>
    <section>
        <div>
            <br />
            <asp:ListView ID="lvAssetList" runat="server"
                DataKeyNames="AssetID" GroupItemCount="4"
                ItemType="FixedAssetsManagement.Models.Asset" SelectMethod="GetAssets">
                <EmptyDataTemplate>
                    <table>
                        <tr>
                            <td>无数据</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <!--每个资产-->
                            <tr>
                                <td style="width: 200px">
                                    <a href="AssetDetailManagement.aspx?AssetID=<%#:Item.AssetID%>">
                                        <img src="/images/Assets/<%#:Item.AssetImage%>" width="120" height="120" style="border: none" />
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <span>
                                        <br />
                                        <b><%#:Item.AssetName%></b>
                                    </span>
                                    <br />
                                    <span>
                                        <b>存放位置: </b><%#:Item.StorageLocation%>
                                    </span>
                                    <br />
                                    <span>
                                        <b>购买日期: </b><%#:Item.PurchaseDate%>
                                    </span>
                                    <br />
                                    <asp:Button ID="DeleteBtn" runat="server" Text="删除" class="btn btn-primary" Style="width: 100%" AssetID="<%# Item.AssetID%>" OnClick="DeleteAssetBtn_Click" />
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width: 100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer"
                                        runat="server" style="width: 100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
</asp:Content>
