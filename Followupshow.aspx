<%@ Page Title="" Language="C#" MasterPageFile="~/DSR/DSR.master" AutoEventWireup="true" CodeFile="Followupshow.aspx.cs" Inherits="DSR_Followupshow" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript">

         function PrintGridData() {

             var prtGrid = document.getElementById('ContentPlaceHolder1_GridView1');

             prtGrid.border = 0;

             var prtwin = window.open('', 'PrintGridViewData', 'left=100,top=100,width=1000,height=1000,tollbar=0,scrollbars=1,status=0,resizable=1');


             prtwin.document.write(prtGrid.outerHTML);

             prtwin.document.close();

             prtwin.focus();
             prtwin.print();
             prtwin.close();
         }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
<div class="main-page">
    <div id="form1" class="forms validation">
        <div class="form-grids row widget-shadow" data-example-id="basic-forms">
            <div class="form-title">
			<h4>Followup Show :</h4>
			</div>
             <div class="form-body" id="form">                 
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
    <cc1:calendarextender ID="TextBox1_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox1" PopupPosition="TopRight">
    </cc1:calendarextender>
</div> 

<div class="col-md-12 form-group">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:Button ID="Button1" runat="server" Text="SEARCH" onclick="Button1_Click" Class=" btn btn-warning " />
              &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" ValidationGroup="a" />&nbsp;
            <asp:Button ID="Button5" runat="server" Text="Export To Excel" Class="btn btn-danger"  OnClick="Button5_Click"  />
        </div>
                 <div class="col-md-12 grid-margin">
<div class="table-responsive" >                 
<table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0">
    <asp:Panel runat="server" ID="Panel1">
         <asp:Label ID="lblCaption" runat="server" Text="Follow up Show" Style="font-weight: bold;
                    color:black;"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="Follow_id" Width="100%" >
                       <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:TemplateField ControlStyle-CssClass="" HeaderText="SN">
                            <ItemTemplate>
                          
                                <%#GridView1.Rows.Count + 1%>
                               
                            </ItemTemplate>
                            <ControlStyle />
                            <FooterStyle />
                            <HeaderStyle CssClass="" ForeColor="White" 
                                HorizontalAlign="Left" />
                            <ItemStyle CssClass="" HorizontalAlign="Left" />
                        </asp:TemplateField> 
                        <asp:BoundField DataField="Name" HeaderText="Salesman" />
                        <asp:BoundField DataField="Customer_name" HeaderText="Customer" />
                        <asp:BoundField DataField="companyname" HeaderText="Company" />
                        <asp:BoundField DataField="Categorynm" HeaderText="Category" />                        
                        <asp:BoundField DataField="Modelnm" HeaderText="Model" />  
                         <asp:BoundField DataField="Modelno" HeaderText="Model No" /> 
                        <asp:BoundField DataField="branchname" HeaderText="Branch Name" />  
                         <asp:BoundField DataField="Customer_comparing_price" HeaderText="Customer Comparing Price" DataFormatString="{0:n}" />

                        <asp:BoundField DataField="Followup_type" HeaderText="Followup Type" />  
                        <asp:BoundField DataField="Followup_status" HeaderText="Followup Status" />  
                        <asp:BoundField DataField="date" HeaderText="Date" />  
                       
                       
                    </Columns>

           <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Right"  />
        
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
                 
   </asp:Panel>
    </table>
                 
  </div>
                 </div>
                  
             </div>

        </div>
         </div>
     </div>
           </div>
</asp:Content>

