<%@ Page Title="" Language="C#" MasterPageFile="~/DSR/DSR.master" AutoEventWireup="true" CodeFile="Laser_Sundry_DebtorsSpare_balancedtl.aspx.cs" Inherits="DSR_Laser_Sundry_DebtorsSpare_balancedtl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
<div class="main-page">
<div id="form1" class="forms validation">
<div class="form-grids row widget-shadow" data-example-id="basic-forms">
    <div class="form-title">
	<h4>SUNDRY DEBTORS SPARE BALANCE</h4>
	</div>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" Width="100%">
        <Fields>
            <asp:TemplateField>
                <ItemTemplate>
                    <div class="form-body" id="form">
                        <div class="col-md-12 form-group">
                            <asp:Button ID="Button1" runat="server" Text="Back" CssClass="btn-link" OnClick="Button1_Click" />
     
                        </div>
                      
<div class="col-md-6 form-group">
    <label >Branch Name</label>
    <asp:Label ID="lblbranchnm" runat="server" Text='<%#Eval("Branchname")%>' CssClass="form-control"></asp:Label>
</div>
<div class="col-md-6 form-group">
    <label >Customer Name</label>
   <asp:Label ID="lblCustomer" runat="server" Text='<%#Eval("Customername")%>' CssClass="form-control"></asp:Label>
</div>
        <div class="col-md-6 form-group">
            <label >Balance Amount</label>
            <asp:Label ID="lblBalanceAmt" runat="server" Text='<%#Eval("Balanceamt","{0:n}")%>' CssClass="form-control"></asp:Label>
        </div>
        <div class="col-md-6 form-group">
            <label >Balance date</label>
            <asp:Label ID="lblbaldt" runat="server" Text='<%#Eval("Balancedate")%>' CssClass="form-control"></asp:Label>
        </div>
        <div class="col-md-6 form-group">
          <label >Add bill during amount</label>  
             <asp:Label ID="lblAdd_bill_during_amount" runat="server" Text='<%#Eval("Add_bill_during_amt","{0:n}")%>' CssClass="form-control"></asp:Label>             
        </div>
        <div class="col-md-6 form-group">
            <label >Add bill during date</label> 
             <asp:Label ID="lblAdd_bill_during_date" runat="server" Text='<%#Eval("Add_bill__during_dt")%>' CssClass="form-control"></asp:Label>
        </div>

         <div class="col-md-6 form-group">
            <label>Less payment received</label>
             <asp:Label ID="lblLess_payment_received" runat="server" Text='<%#Eval("Less_payment_received","{0:n}")%>' CssClass="form-control"></asp:Label>            
        </div>
         <div class="col-md-6 form-group">
            <label >Less payment received date</label> 
              <asp:Label ID="lblLess_payment_receiveddt" runat="server" Text='<%#Eval("Less_payment_receiveddt")%>' CssClass="form-control"></asp:Label>            
        </div>
          <div class="col-md-6 form-group">
            <label >Balance Amount</label> 
              <asp:Label ID="lblbalance1_amt" runat="server" Text='<%#Eval("Balance1_amt","{0:n}")%>' CssClass="form-control"></asp:Label>           
        </div>
          <div class="col-md-6 form-group">
            <label >Balance Date</label> 
              <asp:Label ID="lblbalance1_amtdt" runat="server" Text='<%#Eval("Balance1date")%>' CssClass="form-control"></asp:Label>             
        </div>

        <div class="col-md-6 form-group">
            <label >Less payment received</label> 
             <asp:Label ID="lblLess_payment_received1" runat="server" Text='<%#Eval("Less_payment_received1","{0:n}")%>' CssClass="form-control"></asp:Label>            
        </div>
          <div class="col-md-6 form-group">
            <label >Less payment received date</label> 
             <asp:Label ID="lblless_payment_receiveddt1" runat="server" Text='<%#Eval("Less_payment_receiveddt1")%>' CssClass="form-control"></asp:Label>
        </div>
        <div class="col-md-6 form-group">
            <label>Net Balance</label> 
             <asp:Label ID="lblnet_balance" runat="server" Text='<%#Eval("Net_Balance")%>' CssClass="form-control"></asp:Label>
        </div>
          <div class="col-md-6 form-group">
            <label >Net Balance Date</label> 
             <asp:Label ID="lblnet_balancedt" runat="server" Text='<%#Eval("Net_Balancedt")%>' CssClass="form-control"></asp:Label>           
        </div>
          <div class="col-md-6 form-group">
            <label >Expected date of Collection</label> 
             <asp:Label ID="lblexpected_date_of_Collection" runat="server" Text='<%#Eval("Expected_date_of_Collection")%>' CssClass="form-control"></asp:Label>        

           
        </div>
        <div class="col-md-6 form-group">
            <label >MR No</label> 
             <asp:Label ID="lblMR_No" runat="server" Text='<%#Eval("MR_No")%>' CssClass="form-control"></asp:Label>        

                
        </div>
         <div class="col-md-6 form-group">
            <label >Date</label> 
               <asp:Label ID="lbldate" runat="server" Text='<%#Eval("Date")%>' CssClass="form-control"></asp:Label>   
        </div>
        <div class="col-md-6 form-group">
            <label >Mode of payment</label> 
           <asp:Label ID="lblMode_of_paymen" runat="server" Text='<%#Eval("Mode_of_payment")%>' CssClass="form-control"></asp:Label>   
                
        </div>
        <div class="col-md-6 form-group">
            <label >Remarks</label> 
           <asp:Label ID="lblremark" runat="server" Text='<%#Eval("Remarks")%>' CssClass="form-control"></asp:Label>   
                
        </div>
  
       
    </div>

                </ItemTemplate>

            </asp:TemplateField>
        </Fields>
        

    </asp:DetailsView>
    

</div>

</div>

</div>

      </div>
</asp:Content>

