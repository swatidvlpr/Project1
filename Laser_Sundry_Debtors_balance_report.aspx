<%@ Page Title="" Language="C#" MasterPageFile="~/DSR/DSR.master" AutoEventWireup="true" CodeFile="Laser_Sundry_Debtors_balance_report.aspx.cs" Inherits="DSR_Laser_Sundry_Debtors_balance_report" %>
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
			<h4>Laser Sundry Debtors Balance Report :</h4>
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
    <cc1:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox1" PopupPosition="TopRight">
    </cc1:CalendarExtender>
</div> 
<div class="col-md-6 form-group">
    <label >Branch Name</label>
    <asp:DropDownList ID="ddlbranch" runat="server" CssClass="form-control"></asp:DropDownList>
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

         <asp:Label ID="lblCaption" runat="server" Text="DICV BADCHANA SUNDRY DEBTORS SPARE BALANCE" Style="font-weight: bold;
                    color:black;"></asp:Label>
    
                

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="Lasser_spare_id" Width="100%" OnRowDataBound="GridView1_RowDataBound" ShowFooter="True" Font-Size="12px" >
                    <Columns>
                     <%--   <asp:BoundField DataField="Branchname" HeaderText="Branch Name" />--%>
                        <asp:BoundField DataField="Customername" HeaderText="Customer Name" FooterText="Total" />

                        <asp:TemplateField HeaderText="Balance as on" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                             <HeaderTemplate>
                                 <asp:Label ID="Label8" runat="server" Text="Balance as on"></asp:Label>

                             </HeaderTemplate>
                     <ItemTemplate>
                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("Balanceamt","{0:n}")%>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal1" runat="server" Text="" ForeColor="Black"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                      </asp:TemplateField>

                   
                        
                        <asp:TemplateField HeaderText="Add bill During" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                          
                     <ItemTemplate>
                         <asp:Label ID="Label2" runat="server" Text='<%#Eval("Add_bill_during_amt","{0:n}") %>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal2" runat="server" Text="" ForeColor="Black"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                         </asp:TemplateField>
                       
                        
                        <asp:TemplateField HeaderText="Less Payment Received" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                     <ItemTemplate>
                         <asp:Label ID="Label3" runat="server" Text='<%#Eval("Less_payment_received","{0:n}") %>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal3" runat="server" Text="" ForeColor="Black"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                         </asp:TemplateField>

                        
                        <asp:TemplateField HeaderText="Balance" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                     <ItemTemplate>
                         <asp:Label ID="Label4" runat="server" Text='<%#Eval("Balance1_amt","{0:n}") %>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal4" runat="server" Text="" ForeColor="Black"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                         </asp:TemplateField>

                         <asp:TemplateField HeaderText="Less payment received" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                     <ItemTemplate>
                         <asp:Label ID="Label5" runat="server" Text='<%#Eval("Less_payment_received1","{0:n}") %>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal5" runat="server" Text="" ForeColor="Black"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                         </asp:TemplateField>
                      
                         <asp:TemplateField HeaderText="Less payment received" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                     <ItemTemplate>
                         <asp:Label ID="Label6" runat="server" Text='<%#Eval("Less_payment_received1","{0:n}") %>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal6" runat="server" Text="" ForeColor="Black"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                         </asp:TemplateField>


                          <asp:TemplateField HeaderText="Net Balance" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                     <ItemTemplate>
                         <asp:Label ID="Label7" runat="server" Text='<%#Eval("Net_Balance","{0:n}") %>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal7" runat="server" Text="" ForeColor="Black"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                         </asp:TemplateField>

                        <asp:BoundField DataField="Expected_date_of_Collection" HeaderText="Expected date of Collection" />
                        <asp:BoundField DataField="MR_No" HeaderText="MR No" />
                        <asp:BoundField DataField="Date" HeaderText="Date" />
                        <asp:BoundField DataField="Mode_of_payment" HeaderText="Mode of payment" />
                        <asp:BoundField DataField="Remarks" HeaderText="Remarks" />
            
                    </Columns>

        <HeaderStyle HorizontalAlign="Right"  />
        
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

