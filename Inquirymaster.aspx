<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Inquirymaster.aspx.cs" Inherits="Admin_Inquirymaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row">


        </div>
<div class="col-md-3">
</div>
 <div class="col-md-3">Inquiry Type :
</div>
<div class="col-md-3">
     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</div>
<div class="col-md-3">
</div>
        <div class="col-md-12">
          <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </div>
    <div class="row">

    </div>
     <div class="col-md-4" >

     </div>
    <div class="col-md-4" style="margin-top:20px;text-align:center;" >
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" DataKeyNames="Inquiry_id" OnRowDeleting="GridView1_RowDeleting">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="SN">
                                <ItemTemplate>
                                  <%--  <%#GridView1.Rows.Count + 1%>--%>
                                  <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                                <HeaderStyle HorizontalAlign="Left" />
                                <ItemStyle HorizontalAlign="Left" />
                            </asp:TemplateField>
                <asp:BoundField DataField="Inquiry_type" HeaderText="Inquiry Type" >
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle HorizontalAlign="Left" />
                </asp:BoundField>
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>

            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />

        </asp:GridView>

    </div>
     <div class="col-md-4">

     </div>
</asp:Content>

