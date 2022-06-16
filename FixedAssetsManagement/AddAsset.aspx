<%@ Page Title="" Language="C#" MasterPageFile="~/ManagerSite.Master" AutoEventWireup="true" CodeBehind="AddAsset.aspx.cs" Inherits="FixedAssetsManagement.AddAsset" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal" style="width:42%;margin:auto;margin-top:30px">
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="资产名称" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="AssetNameTxt" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="购买日期" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="AssetPurchaseDateTxt" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="存放位置" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="AssetLocationTxt" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label4" runat="server" Text="价格" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="AssetPrice" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label5" runat="server" Text="规格" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="AssetSpecification" runat="server" class="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label6" runat="server" Text="分类" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:DropDownList ID="AssetCategoryDropDownList" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataValueField="AssetCategoryID" DataTextField="AssetCategoryName" ></asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label7" runat="server" Text="保管人" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:DropDownList ID="EmployeeDropDownList" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataValueField="EmployeeID" DataTextField="EmployeeName" ></asp:DropDownList>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label8" runat="server" Text="资产图片" class="col-sm-2 control-label"></asp:Label>
            <div class="col-sm-10">
                <asp:FileUpload ID="AssetImage" runat="server" />
            </div>
        </div>
        <div class="form-group">
            <div class="col-sm-offset-4 col-sm-10">
                <asp:Button ID="AddAssetBtn" runat="server" Text="添加" class="btn btn-primary" OnClick="AddAssetBtn_Click" />
            </div>
        </div>
    </div>
</asp:Content>
