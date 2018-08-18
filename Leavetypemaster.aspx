<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Leavetypemaster.aspx.cs" Inherits="Hr_Leavetypemaster" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
<div class="main-page">
    <div id="form1" class="forms validation">
        <div class="form-grids row widget-shadow" data-example-id="basic-forms">
            <div class="form-title">
							<h4>Leave Type Master:</h4>
						</div>
             <div class="form-body" id="form">
                  <div class="col-md-6 form-group">
                     <label >Employee Type</label>
                      <asp:DropDownList ID="ddlemployee" runat="server" CssClass="form-control">
                          <asp:ListItem Value="0">Select</asp:ListItem>
                          <asp:ListItem Value="1">Worker</asp:ListItem>
                          <asp:ListItem Value="2">Staff</asp:ListItem>
                          <asp:ListItem Value="3">Executive</asp:ListItem>
                      </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Enter employee type" ControlToValidate="ddlemployee" ValidationGroup="a" InitialValue="0"></asp:RequiredFieldValidator>
                  </div>
                  <div class="col-md-6 form-group">
                     <label >Type Of Leave</label> 
                      <asp:DropDownList ID="ddlleavetype" runat="server" CssClass="form-control"></asp:DropDownList>
    
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  
        ErrorMessage="Enter type of leave" ControlToValidate="ddlleavetype" ValidationGroup="a" InitialValue="0"></asp:RequiredFieldValidator>
                 </div>
                 <div class="col-md-6 form-group">
                    <label >Assign leave</label>                      
                     
                     <asp:TextBox ID="txtassighnleave" runat="server" CssClass="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter Assign leave" ControlToValidate="txtassighnleave" ValidationGroup="a"></asp:RequiredFieldValidator>
   
                 </div>
                
                 <div class="col-md-6 form-group">                     
                   
                 </div>
                 <div class="col-md-12 form-group">
                     <asp:Button ID="Button1" runat="server" Text="submit" onclick="Button1_Click" Class=" btn btn-warning " ValidationGroup="a" />
                       &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" ValidationGroup="a" />
                     <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                 </div>
                 <div class="col-md-12 grid-margin">
                 <div class="table-responsive" >
<table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0"  >
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="typeleaveid" onrowdeleting="GridView1_RowDeleting" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" CellPadding="4" 
        ForeColor="#333333" GridLines="None" Width="653px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="employee_type" HeaderText="Employee Type" />
            <asp:BoundField DataField="leavenm" HeaderText="Leave Nm" />
            <asp:BoundField DataField="Total_year_leave" HeaderText="Total leave" />
           
            <asp:CommandField ShowSelectButton="true" SelectText="Edit" />
            <asp:CommandField ShowDeleteButton="True" />
            
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
                   <div class="col-md-12 form-group">

                   </div>     

             </div>

             </div>

        </div>


    </div>

</div>

    </div>
</asp:Content>

