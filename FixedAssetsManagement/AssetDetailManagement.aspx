<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerSite.Master" AutoEventWireup="true" CodeBehind="AssetDetailManagement.aspx.cs" Inherits="FixedAssetsManagement.AssetDetailManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="fvAssetDetails" runat="server"
        ItemType="FixedAssetsManagement.Models.Asset" SelectMethod="GetAsset" RenderOuterTable="false">
        <ItemTemplate>
            <div class="form-horizontal col-sm-offset-3" style="margin-top: 30px">
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="图片" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <img src="/images/Assets/<%#:Item.AssetImage %>" style="border: none; height: 200px"
                            alt="<%#:Item.AssetName %>" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label9" runat="server" Text="修改资产图片" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:FileUpload ID="EditAssetImage" runat="server" AssetImage="<%#:Item.AssetImage %>"/>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="资产编号" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="AssetIDTxt" runat="server" class="form-control" Text="<%#:Item.AssetID %>" ReadOnly></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="资产名称" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="AssetNameTxt" runat="server" class="form-control" Text="<%#:Item.AssetName %>"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="购买日期" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="PurchaseDateTxt" runat="server" class="form-control" Text="<%#:Item.PurchaseDate %>"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="存放位置" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="AssetLocationTxt" runat="server" class="form-control" Text="<%#:Item.StorageLocation %>"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label6" runat="server" Text="价格" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="AssetPrice" runat="server" class="form-control" Text='<%#:Item.AssetPrice %>'></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label10" runat="server" Text="规格" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:TextBox ID="AssetSpecification" runat="server" class="form-control" Text='<%#:Item.AssetSpecification %>'></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label7" runat="server" Text="分类" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:DropDownList ID="AssetCategoryDropDownList" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataValueField="AssetCategoryID" DataTextField="AssetCategoryName" AssetCategoryName="<%#:Item.AssetCategory.AssetCategoryName %>"></asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label8" runat="server" Text="保管人" class="col-sm-2 control-label"></asp:Label>
                    <div class="col-sm-6">
                        <asp:DropDownList ID="EmployeeDropDownList" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataValueField="EmployeeID" DataTextField="EmployeeName" EmployeeName="<%#:Item.Employee.EmployeeName %>"></asp:DropDownList>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-3 col-sm-6">
                        <asp:Button ID="SaveAssetBtn" runat="server" Text="保存" class="btn btn-primary" OnClick="SaveAssetBtn_Click" />
                    </div>
                </div>
            </div>
            <%--<br />
            <table style="margin:auto">
                <tr>
                    <td>
                        <img src="/images/Assets/<%#:Item.AssetImage %>" style="border: none; height: 200px"
                            alt="<%#:Item.AssetName %>" />
                    </td>
                    <td>&nbsp;</td>
                    <td style="vertical-align: top; text-align: left;">
                        <b>资产编号:</b><asp:TextBox ID="AssetIDTxt" runat="server" Text="<%#:Item.AssetID %>" ReadOnly></asp:TextBox>
                        <br />
                        <b>资产名称:</b><asp:TextBox ID="AssetNameTxt" runat="server" Text="<%#:Item.AssetName %>"></asp:TextBox>
                        <br />
                        <b>购买日期:</b><asp:TextBox ID="PurchaseDateTxt" runat="server" Text="<%#:Item.PurchaseDate %>"></asp:TextBox>
                        <br />
                        <b>存放位置:</b><asp:TextBox ID="AssetLocationTxt" runat="server" Text="<%#:Item.StorageLocation %>"></asp:TextBox>
                        <br />
                        <b>价格:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b><asp:TextBox ID="AssetPrice" runat="server" Text='<%#:Item.AssetPrice %>'></asp:TextBox>
                        <br />
                        <b>规格:</b><br />
                        <asp:TextBox ID="AssetSpecification" runat="server" Text="<%#:Item.AssetSpecification %>"></asp:TextBox>
                        <br />
                        <b>分类:</b>
                        <asp:DropDownList ID="AssetCategoryDropDownList" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataValueField="AssetCategoryID" DataTextField="AssetCategoryName" AssetCategoryName="<%#:Item.AssetCategory.AssetCategoryName %>"></asp:DropDownList>
                        <br />
                        <b>保管人:</b>
                        <asp:DropDownList ID="EmployeeDropDownList" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataValueField="EmployeeID" DataTextField="EmployeeName" EmployeeName="<%#:Item.Employee.EmployeeName %>"></asp:DropDownList>
                        <br />
                        <asp:Button ID="SaveAssetBtn" runat="server" Text="保存" Onclick="SaveAssetBtn_Click"/>
                    </td>
                </tr>
            </table>--%>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
