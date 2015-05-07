<%@ page title="" language="C#" masterpagefile="~/Site.master" autoeventwireup="true" inherits="WicketStatistics, App_Web_5ldfayhw" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="lblSelectKYZ" runat="server" Text="选择客运站："></asp:Label>
    <asp:DropDownList ID="cboSelectKYZ" runat="server" onprerender="cboSelectKYZ_PreRender"></asp:DropDownList>
    <asp:Label ID="lblFromDate" runat="server" Text="起始日期："></asp:Label>
    <asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtFromDate" Display="Dynamic" ErrorMessage="请输入起始日期" 
        ForeColor="#FF3300"></asp:RequiredFieldValidator>
    <asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="txtFromDate" Display="Dynamic" ErrorMessage="起始日期格式错误" 
        ForeColor="Red" MaximumValue="2999-01-01" MinimumValue="2000-01-01" Type="Date"></asp:RangeValidator>
    <asp:Label ID="lblToDate" runat="server" Text="截止日期"></asp:Label>
    <asp:TextBox ID="txtToDate" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtToDate" Display="Dynamic" ErrorMessage="请输入截止日期" 
        ForeColor="#FF3300"></asp:RequiredFieldValidator>
    <asp:RangeValidator ID="RangeValidator2" runat="server" 
        ControlToValidate="txtToDate" Display="Dynamic" ErrorMessage="截止日期格式错误" 
        ForeColor="Red" MaximumValue="2999-01-01" MinimumValue="2000-01-01" Type="Date"></asp:RangeValidator>
    <asp:Button ID="btnQuery" runat="server" Text="查询" onclick="btnQuery_Click" />
    <hr />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="JPS" HeaderText="检票数">
            <HeaderStyle Width="200px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="JSS" HeaderText="结算数">
            <HeaderStyle Width="200px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Username" HeaderText="用户名">
            <HeaderStyle Width="200px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>

