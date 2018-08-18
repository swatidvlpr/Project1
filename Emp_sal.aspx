<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Emp_sal.aspx.cs" Inherits="Hr_Emp_sal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">    
<div class="main-page">
<div id="form1" class="forms validation">
<div class="form-grids row widget-shadow" data-example-id="basic-forms">
    <div class="form-title">
	<h4>Salary Structure</h4>
	</div>
    <div class="form-body" id="form">
        <div class="col-md-6 form-group">
            <label >Month</label>
            <asp:DropDownList ID="ddlmonth" runat="server" CssClass="form-control">
                 <asp:ListItem Value="0">---Select Month----</asp:ListItem>
                <asp:ListItem Value="01">Jan</asp:ListItem>
                <asp:ListItem Value="02">Feb</asp:ListItem>
                <asp:ListItem Value="03">Mar</asp:ListItem>
                <asp:ListItem Value="04">Apr</asp:ListItem>
                <asp:ListItem Value="05">May</asp:ListItem>
               <asp:ListItem Value="06">Jun</asp:ListItem>
                <asp:ListItem Value="07">Jul</asp:ListItem>
                <asp:ListItem Value="08">Aug</asp:ListItem>
                <asp:ListItem Value="09">Sep</asp:ListItem>
                <asp:ListItem Value="10">Oct</asp:ListItem>
                <asp:ListItem Value="11">Nov</asp:ListItem>
                <asp:ListItem Value="12">Dec</asp:ListItem>

            </asp:DropDownList>
        </div>
        <div class="col-md-6 form-group">
            <label >Year</label>
            <asp:DropDownList ID="ddlyear" runat="server" CssClass="form-control">
                <asp:ListItem Value="0">Select</asp:ListItem>
            </asp:DropDownList>
        </div>
         <div class="col-md-6 form-group">
          <label >Employee No</label>
             <asp:TextBox ID="txtempno" runat="server" Class="form-control" placeholder="Employee no" data-error="Please enter employee no"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >Name</label>
         <asp:TextBox ID="txtname" runat="server" Class="form-control" placeholder="Name" data-error="Please enter name"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >Department</label>
             <asp:DropDownList ID="ddldepartment" runat="server" Class="form-control" placeholder="Enter department" data-error="Please enter department"  ValidationGroup="a"></asp:DropDownList>
        <%-- <asp:TextBox ID="txtdepartment" runat="server" Class="form-control" placeholder="Enter department" data-error="Please enter department"  ValidationGroup="a"></asp:TextBox>--%>
         </div>
        <div class="col-md-6 form-group">         
          <label >Designation</label>
         <asp:TextBox ID="txtdesignation" runat="server" Class="form-control" placeholder="Enter designation" data-error="Please enter designation"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Grade</label>
         <asp:TextBox ID="txtgrade" runat="server" Class="form-control" placeholder="Enter grade" data-error="Please enter grade"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >Working</label>
         <asp:TextBox ID="txtworking" runat="server" Class="form-control" placeholder="Enter working" data-error="Please enter working"  ValidationGroup="a"></asp:TextBox>
         </div>

            <div class="col-md-6 form-group">         
          <label >No of Sunday</label>
         <asp:TextBox ID="txtno_of_sunday" runat="server" Class="form-control" placeholder="Enter no of sunday" data-error="Please enter no of sunday"  ValidationGroup="a"></asp:TextBox>
         </div>
        
            <div class="col-md-6 form-group">         
          <label >Leave Casual</label>
         <asp:TextBox ID="txtleave_casual" runat="server" Class="form-control" placeholder="Enter no of leave casual" data-error="Please enter leave casual"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Availed earned</label>
         <asp:TextBox ID="txtavailed_earned" runat="server" Class="form-control" placeholder="Enter no of availed earned" data-error="Please enter availed earned"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >Sick</label>
         <asp:TextBox ID="txtsick" runat="server" Class="form-control" placeholder="Enter no of sick" data-error="Please enter sick"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >El earned</label>
         <asp:TextBox ID="txtel_earned" runat="server" Class="form-control" placeholder="Enter no of El earned" data-error="Please enter El earned"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Basic pay</label>
         <asp:TextBox ID="txtbasic_pay" runat="server" Class="form-control" placeholder="Enter no of basic pay" data-error="Please enter basic pay"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Hra allowance</label>
         <asp:TextBox ID="txthra_allowance" runat="server" Class="form-control" placeholder="Enter no of hra allowance" data-error="Please enter hra allowance"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Medical allonancee</label>
         <asp:TextBox ID="txtmedical_allonance" runat="server" Class="form-control" placeholder="Enter no of medical allonance" data-error="Please enter medical allonance"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Conveyance allowance</label>
         <asp:TextBox ID="txtconveyance_allowance" runat="server" Class="form-control" placeholder="Enter no of conveyance allowance" data-error="Please enter conveyance allowance"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >C C A allowance</label>
         <asp:TextBox ID="txtC_C_A_allowance" runat="server" Class="form-control" placeholder="Enter C C A allowance" data-error="Please enter C C A allowance"  ValidationGroup="a"></asp:TextBox>
         </div>
          <div class="col-md-6 form-group">         
          <label >Washing allowance</label>
         <asp:TextBox ID="txtwashing_allowance" runat="server" Class="form-control" placeholder="Enter washing allowance" data-error="Please enter washing allowance"  ValidationGroup="a"></asp:TextBox>
         </div>
          <div class="col-md-6 form-group">         
          <label >Arrear pay</label>
         <asp:TextBox ID="txtarrear_pay" runat="server" Class="form-control" placeholder="Enter arrear pay" data-error="Please enter arrear pay"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Misc earning narration amt</label>
         <asp:TextBox ID="txtmisc_earning_narration_amt" runat="server" Class="form-control" placeholder="Enter misc earning narration amt" data-error="Please enter misc earning narration amt"  ValidationGroup="a"></asp:TextBox>
         </div>

        <div class="col-md-6 form-group">         
          <label >Leave encash</label>
         <asp:TextBox ID="txtleaveencash" runat="server" Class="form-control" placeholder="Enter leave encash" data-error="Please enter leave encash"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Gross Earning</label>
         <asp:TextBox ID="txtgrossearning" runat="server" Class="form-control" placeholder="Enter gross earning" data-error="Please enter gross earning"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >Epf</label>
         <asp:TextBox ID="txtepf" runat="server" Class="form-control" placeholder="Enter epf" data-error="Please enter epf"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Fpf</label>
         <asp:TextBox ID="txtFpf" runat="server" Class="form-control" placeholder="Enter fpf" data-error="Please enter fpf"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >VPF</label>
         <asp:TextBox ID="txtvpf" runat="server" Class="form-control" placeholder="Enter vpf" data-error="Please enter vpf"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >ESI</label>
         <asp:TextBox ID="txtESI" runat="server" Class="form-control" placeholder="Enter ESI" data-error="Please enter ESI"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Medical advance</label>
         <asp:TextBox ID="txtmedicaladvance" runat="server" Class="form-control" placeholder="Enter medical advance" data-error="Please enter medical advance"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >Festival advance</label>
         <asp:TextBox ID="txtfestivaladvance" runat="server" Class="form-control" placeholder="Enter festival advance" data-error="Please enter festival advance"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Personal advance</label>
         <asp:TextBox ID="txtpersonal_advance" runat="server" Class="form-control" placeholder="Enter personal advance" data-error="Please enter festival advance"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >Vehicle advance</label>
         <asp:TextBox ID="txtvehicle_advance" runat="server" Class="form-control" placeholder="Enter vehicle advance" data-error="Please enter vehicle advance"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >Misc deduction narration amount advance</label>
         <asp:TextBox ID="txtmisc_deduction_narration_amount_advance" runat="server" Class="form-control" placeholder="Enter misc deduction narration amount advance" data-error="Please enter misc deduction narration amount advance"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Income tax</label>
         <asp:TextBox ID="txtincome_tax" runat="server" Class="form-control" placeholder="Enter income tax" data-error="Please enter income tax"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >Total deduction</label>
         <asp:TextBox ID="txttotal_deduction" runat="server" Class="form-control" placeholder="Enter total deduction" data-error="Please enter income tax"  ValidationGroup="a"></asp:TextBox>
         </div>
         <div class="col-md-6 form-group">         
          <label >net pay</label>
         <asp:TextBox ID="txtnet_pay" runat="server" Class="form-control" placeholder="Enter net pay" data-error="Please enter net pay"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-6 form-group">         
          <label >net_round</label>
         <asp:TextBox ID="txtnet_round" runat="server" Class="form-control" placeholder="Enter net round" data-error="Please enter net round"  ValidationGroup="a"></asp:TextBox>
         </div>
        <div class="col-md-12 form-group">
            <div class="col-md-12 form-group">
                     <asp:Button ID="Button1" runat="server" Text="submit" onclick="Button1_Click" Class=" btn btn-warning " />
                       &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" ValidationGroup="a" />
                     <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                 </div>
        </div>
    </div>
</div>
</div>
</div>
    </div>
</asp:Content>

