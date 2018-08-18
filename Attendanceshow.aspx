<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Attendanceshow.aspx.cs" Inherits="Hr_Attendanceshow" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
<div class="main-page">
    <div id="form1" class="forms validation">
        <div class="form-grids row widget-shadow" data-example-id="basic-forms">
            <div class="form-title">
			<h4>Attendance Show :</h4>
			</div>
             <div class="form-body" id="form">
                            <div class="col-md-6 form-group">
    <label >Employee code </label>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
</div>
                 <div class="col-md-6 form-group">
    <label >Month </label>
      <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
           <asp:ListItem Value="0">---Select Month----</asp:ListItem>
                <asp:ListItem Value="1">Jan</asp:ListItem>
                <asp:ListItem Value="2">Feb</asp:ListItem>
                <asp:ListItem Value="3">Mar</asp:ListItem>
                <asp:ListItem Value="4">Apr</asp:ListItem>
                <asp:ListItem Value="5">May</asp:ListItem>
               <asp:ListItem Value="6">Jun</asp:ListItem>
                <asp:ListItem Value="7">Jul</asp:ListItem>
                <asp:ListItem Value="8">Aug</asp:ListItem>
                <asp:ListItem Value="9">Sep</asp:ListItem>
                <asp:ListItem Value="10">Oct</asp:ListItem>
                <asp:ListItem Value="11">Nov</asp:ListItem>
                <asp:ListItem Value="12">Dec</asp:ListItem>

      </asp:DropDownList>
</div>
<div class="col-md-6 form-group">
    <label >Year </label>
    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control">
        <asp:ListItem Value="0">--Select--</asp:ListItem>
    </asp:DropDownList>
</div>
<div class="col-md-6 form-group">
    <label >Date </label>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
    <cc1:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox1" PopupPosition="TopRight" Format="dd/MM/yyyy">
    </cc1:CalendarExtender>
</div>
  <div class="col-md-6 form-group">
    <label >Status </label>
      <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control">
          <asp:ListItem Value="0">--Select--</asp:ListItem>
          <asp:ListItem>Present</asp:ListItem>
          <asp:ListItem>Absent</asp:ListItem>
      </asp:DropDownList>
</div>

<div class="col-md-12 form-group">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:Button ID="Button1" runat="server" Text="SEARCH" onclick="Button1_Click" Class=" btn btn-warning " />
              &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" ValidationGroup="a" />
        </div>
                 <div class="col-md-12 grid-margin">
<div class="table-responsive" >                 
<table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0">


                 <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="E_Code" CellPadding="4" 
        ForeColor="#333333" GridLines="None" Width="100%" OnRowDataBound="GridView1_RowDataBound">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="E_Code" HeaderText="E.Code" />            
            <asp:BoundField DataField="Name" HeaderText="Name" />
             <asp:BoundField DataField="Category" HeaderText="Category" />
            <asp:BoundField DataField="Department" HeaderText="Department" />
             <asp:BoundField DataField="Shift" HeaderText="Shift" />
            <asp:BoundField DataField="InTime1" HeaderText="In Time" />
             <asp:BoundField DataField="OutTime1" HeaderText="Out Time" />
             <asp:BoundField DataField="Work_Dur1" HeaderText="Work Dur." />
           <%-- <asp:BoundField DataField="OT" HeaderText="OT" />
            <asp:BoundField DataField="Tot_Dur1" HeaderText="Total Dur." />--%>
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:BoundField DataField="date" HeaderText="Date" />
             <asp:TemplateField HeaderText="Action">
                <ItemTemplate>                  
                 
                    <%--<asp:HiddenField ID="HiddenField2" runat="server" Value='<%#Eval("Status_hod") %>' />--%>
                     <asp:Button ID="Button4" runat="server" Text="Button" />
                </ItemTemplate>
                

            </asp:TemplateField>
                 
       
            
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
       
    </asp:GridView>
   
                 </table>
  </div>
                 </div>
                  
             </div>

        </div>
         </div>
     </div>
           </div>
    
</asp:Content>

