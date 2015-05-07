<%@ Page Title="主页" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>欢迎使用-公路客运联网小件系统</h2>
    <br />
    <p><a href="http://172.26.9.210/公路客运小件系统_使用帮助.PDF" title="公路客运小件系统-使用帮助">公路客运小件系统_使用帮助.PDF</a></p>
    <br />
    <p><b>客户端安装流程：</b></p>
    <br />
    <p>第一步、（必须步骤）打开本机文件 C:\Windows\System32\drivers\etc\hosts ，并添加 172.26.9.210 wl-server 到文件结尾处，须新起一行</p>
    <p>第二步、（必须步骤）下载并安装<a href="http://172.26.9.210/Downloads/dotNetFx40_Full_x86_x64.zip" title="NET 4.0 安装包"> .NET 4.0 安装包</a></p>
    <p>第三步、（必须步骤）下载并安装<a href="http://172.26.9.210/Downloads/dotNetFx40LP_Full_x86_x64zh-Hans.zip" title="NET 4.0 语言包"> .NET 4.0 语言包</a></p>
    <p>第四步、（必须步骤）下载并安装<a href="http://172.26.9.210/Downloads/ReportViewer_2010_SP1.zip" title="ReportViewer 2010 SP1 安装包"> ReportViewer 2010 SP1 安装包</a></p>
    <p>第五步、（必须步骤）下载并安装<a href="http://172.26.9.210/Downloads/ReportViewer_2010_SP1_语言包.zip" title="ReportViewer 2010 SP1 语言包"> ReportViewer 2010 SP1 语言包</a></p>
    <p>第六步、（可选步骤）下载并安装<a href="http://172.26.9.210/Downloads/办单.zip" title="办单管理平台">办单管理平台</a></p>
    <p>第七步、（可选步骤）下载并安装<a href="http://172.26.9.210/Downloads/结账.zip" title="统计结账平台">统计结账平台</a></p>
    <br />
    <p><b>备注</b>：如果第二步安装时提示缺少组件，可安装<a href="http://172.26.9.210/Downloads/wic_x86_chs.zip" title="补充组件">补充组件</a>后再次尝试！</p>
    <br />
</asp:Content>
