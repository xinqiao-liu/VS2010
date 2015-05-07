<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>欢迎使用-公路客运联网小件系统</h2>
    <br />
    <div>
        <asp:Label ID="lblSN" runat="server" Text="运单编号："></asp:Label>
        <br />
        <asp:TextBox ID="txtSN" runat="server"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" Text="查询" />
        <br />
        <asp:Label ID="lblTrack" runat="server" Text="运单跟踪："></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Width="600px" Height="160px">
        </asp:ListBox>
        <br />
        <br />
    </div>
</asp:Content>
