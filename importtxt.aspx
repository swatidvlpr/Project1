<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="importtxt.aspx.cs" Inherits="Hr_importtxt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
         <div id="page-wrapper">
<div class="main-page">
        <asp:FileUpload ID="FileUpload1" runat="server" />       

        <asp:Button ID="Button1" runat="server" Text="Export" OnClick="btnUpload_Click" />

    &nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </div></div>
    </div>
</asp:Content>

