<%@ page title="" language="C#" masterpagefile="~/Site.master" autoeventwireup="true" inherits="WicketCTQuery, App_Web_jilka24y" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="lblSelectKYZ" runat="server" Text="选择客运站："></asp:Label>
    <asp:DropDownList ID="cboSelectKYZ" runat="server"></asp:DropDownList>
    <asp:Label ID="lblDate" runat="server" Text="售票日期："></asp:Label>
    <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ControlToValidate="txtDate" Display="Dynamic" ErrorMessage="未输入售票日期" 
        ForeColor="#FF3300"></asp:RequiredFieldValidator>
    <asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="txtDate" Display="Dynamic" ErrorMessage="售票日期输入不正确" 
        ForeColor="#FF3300" MaximumValue="2999-01-01" MinimumValue="2000-01-01" 
        Type="Date"></asp:RangeValidator>
    <asp:Label ID="lblValue" runat="server" Text="连售张数："></asp:Label>
    <asp:TextBox ID="txtValve" runat="server" style="margin-bottom: 0px">5</asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtValve" Display="Dynamic" ErrorMessage="未输入连售张数" 
        ForeColor="#FF3300"></asp:RequiredFieldValidator>
    <asp:RangeValidator ID="RangeValidator2" runat="server" 
        ControlToValidate="txtValve" Display="Dynamic" ErrorMessage="连售张数输入不正确" 
        ForeColor="#FF3300" MaximumValue="50" MinimumValue="1" Type="Integer"></asp:RangeValidator>
    <asp:RadioButton ID="rdoCurrent" runat="server" Checked="True" 
    GroupName="1" Text="当前记录" />
    <asp:RadioButton ID="rdoHistory" runat="server" GroupName="1" Text="历史记录" />
    <asp:Button ID="btnQuery" runat="server" Text="查询" onclick="btnQuery_Click" />
    <hr />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="SPY" HeaderText="编号">
            <HeaderStyle Width="100px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Name" HeaderText="姓名">
            <HeaderStyle Width="100px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="SPRQ" HeaderText="售票时间">
            <HeaderStyle Width="150px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="CC" HeaderText="班次">
            <HeaderStyle Width="100px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="RQ" DataFormatString="{0:yyyy-MM-dd}" 
                HeaderText="日期">
            <HeaderStyle Width="100px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="FCSJ" HeaderText="发车时间">
            <HeaderStyle Width="100px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="DZ" HeaderText="到站">
            <HeaderStyle Width="100px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Count" HeaderText="售票数">
            <HeaderStyle Width="100px" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
