<%@ Page Title="" Language="C#" MasterPageFile="~/DSR/DSR.master" AutoEventWireup="true" CodeFile="Laser_Sundry_DebtorsSpare_balance.aspx.cs" Inherits="DSR_Laser_Sundry_DebtorsSpare_balance" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
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
    <div class="form-body" id="form">
<div class="col-md-6 form-group">
    <label >Branch Name</label>
    <asp:DropDownList ID="ddlbranch" runat="server" CssClass="form-control"></asp:DropDownList>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
      ControlToValidate="ddlbranch" ErrorMessage="Select branch name" InitialValue="0" ValidationGroup="a"></asp:RequiredFieldValidator>
</div>
<div class="col-md-6 form-group">
    <label >Customer Name</label>
    <asp:TextBox ID="txtcustomernm" runat="server" CssClass="form-control"></asp:TextBox>
    
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtcustomernm" ErrorMessage="Enter customer name" ValidationGroup="a"></asp:RequiredFieldValidator>
</div>

        <div class="col-md-6 form-group">
            <label >Balance Amount</label>
            <asp:TextBox ID="txtbalanceamt" runat="server" CssClass="form-control">00.00</asp:TextBox>                
                
                <cc1:FilteredTextBoxExtender ID="txtbalanceamt_FilteredTextBoxExtender" runat="server" 
                Enabled="True" TargetControlID="txtbalanceamt" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>

                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtBalanceamt" ErrorMessage="Enter balance amount"></asp:RequiredFieldValidator>--%>
        </div>
        <div class="col-md-6 form-group">
            <label >Balance date</label>
            <asp:TextBox ID="txtbaldt" runat="server" CssClass="form-control"></asp:TextBox>
                <cc1:CalendarExtender ID="txtbaldt_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtbaldt" PopupPosition="TopRight">
            </cc1:CalendarExtender>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtbaldt" ErrorMessage="Enter balance date"></asp:RequiredFieldValidator>--%>
        </div>
        <div class="col-md-6 form-group">
          <label >Add bill during amount</label>  
             <asp:TextBox ID="txtadd_bill_during_amt" runat="server" CssClass="form-control" OnTextChanged="txtadd_bill_during_amt_TextChanged">00.00</asp:TextBox>               
              
              <cc1:FilteredTextBoxExtender ID="txtadd_bill_during_amt_FilteredTextBoxExtender" runat="server" 
                Enabled="True" TargetControlID="txtadd_bill_during_amt" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>

               <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtadd_bill_during_amt" ErrorMessage="Enter add bill during amount"></asp:RequiredFieldValidator>--%>
        </div>
        <div class="col-md-6 form-group">
            <label >Add bill during date</label> 
            <asp:TextBox ID="txtadd_bill_during" runat="server" CssClass="form-control"></asp:TextBox>               
                <cc1:CalendarExtender ID="txtadd_bill_during_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtadd_bill_during" PopupPosition="TopRight">
            </cc1:CalendarExtender>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="txtadd_bill_during" ErrorMessage="Enter add bill during date"></asp:RequiredFieldValidator>--%>
        </div>

         <div class="col-md-6 form-group">
            <label >Less payment received</label> 
            <asp:TextBox ID="txtLess_payment_received" runat="server" CssClass="form-control" AutoPostBack="True" OnTextChanged="txtLess_payment_received_TextChanged">00.00</asp:TextBox>  
                
              <cc1:FilteredTextBoxExtender ID="txtLess_payment_received_FilteredTextBoxExtender" runat="server" 
                Enabled="True" TargetControlID="txtLess_payment_received" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>

               <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="txtLess_payment_received" ErrorMessage="Enter less payment received"></asp:RequiredFieldValidator>--%>
        </div>
         <div class="col-md-6 form-group">
            <label >Less payment received date</label> 
            <asp:TextBox ID="txtLess_payment_receiveddt" runat="server" CssClass="form-control"></asp:TextBox>  
                <cc1:CalendarExtender ID="txtLess_payment_receiveddt_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtLess_payment_receiveddt" PopupPosition="TopRight">
             </cc1:CalendarExtender>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="txtLess_payment_receiveddt" ErrorMessage="Enter less payment received date"></asp:RequiredFieldValidator>--%>
        </div>
          <div class="col-md-6 form-group">
            <label >Balance Amount</label> 
            <asp:TextBox ID="txtbalance1_amt" runat="server" CssClass="form-control">00.00</asp:TextBox> 
               <cc1:FilteredTextBoxExtender ID="txtbalance1_amtFilteredTextBoxExtender1" runat="server" 
                Enabled="True" TargetControlID="txtbalance1_amt" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>

               
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                    ControlToValidate="txtbalance1_amt" ErrorMessage="Enter balance amount"></asp:RequiredFieldValidator>--%>
        </div>
          <div class="col-md-6 form-group">
            <label >Balance Date</label> 
            <asp:TextBox ID="txtbalance1_amtdt" runat="server" CssClass="form-control"></asp:TextBox>  
                <cc1:CalendarExtender ID="txtbalance1_amtdt_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtbalance1_amtdt" PopupPosition="TopRight">
              </cc1:CalendarExtender>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                    ControlToValidate="txtbalance1_amtdt" ErrorMessage="Enter balance date"></asp:RequiredFieldValidator>--%>
        </div>

        <div class="col-md-6 form-group">
            <label >Less payment received</label> 
            <asp:TextBox ID="txtLess_payment_received1" runat="server" CssClass="form-control">00.00</asp:TextBox>  
             <cc1:FilteredTextBoxExtender ID="txtLess_payment_received1FilteredTextBoxExtender1" runat="server" 
                Enabled="True" TargetControlID="txtLess_payment_received1" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                    ControlToValidate="txtLess_payment_received1" ErrorMessage="enter less payment received"></asp:RequiredFieldValidator>--%>
        </div>
          <div class="col-md-6 form-group">
            <label >Less payment received date</label> 
            <asp:TextBox ID="txtless_payment_receiveddt1" runat="server" CssClass="form-control"></asp:TextBox>  
                <cc1:CalendarExtender ID="txtless_payment_receiveddt1_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtless_payment_receiveddt1" PopupPosition="TopRight">
              </cc1:CalendarExtender>
               <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                    ControlToValidate="txtless_payment_receiveddt1" ErrorMessage="enter less payment received date"></asp:RequiredFieldValidator>--%>
        </div>
        <div class="col-md-6 form-group">
            <label >Net Balance</label> 
            <asp:TextBox ID="txtnet_balance" runat="server" CssClass="form-control" OnTextChanged="txtnet_balance_TextChanged">00.00</asp:TextBox>  
            <cc1:FilteredTextBoxExtender ID="txtnet_balanceFilteredTextBoxExtender1" runat="server" 
                Enabled="True" TargetControlID="txtnet_balance" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                    ControlToValidate="txtnet_balance" ErrorMessage="Enter net balance"></asp:RequiredFieldValidator>--%>
        </div>
          <div class="col-md-6 form-group">
            <label >Net Balance Date</label> 
            <asp:TextBox ID="txtnet_balancedt" runat="server" CssClass="form-control"></asp:TextBox>  
                <cc1:CalendarExtender ID="txtnet_balancedt_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtnet_balancedt" PopupPosition="TopRight">
              </cc1:CalendarExtender>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                    ControlToValidate="txtnet_balancedt" ErrorMessage="Enter net balance date"></asp:RequiredFieldValidator>--%>
        </div>
          <div class="col-md-6 form-group">
            <label >Expected date of Collection</label> 
            <asp:TextBox ID="txtexpected_date_of_Collection" runat="server" CssClass="form-control"></asp:TextBox>  
                <cc1:CalendarExtender ID="txtexpected_date_of_Collection_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtexpected_date_of_Collection" PopupPosition="TopRight">
              </cc1:CalendarExtender>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
                    ControlToValidate="txtexpected_date_of_Collection" ErrorMessage="Enter expected date of collection"></asp:RequiredFieldValidator>--%>
        </div>
        <div class="col-md-6 form-group">
            <label >MR No</label> 
            <asp:TextBox ID="txtMR_No" runat="server" CssClass="form-control"></asp:TextBox>  
                
        </div>
         <div class="col-md-6 form-group">
            <label >Date</label> 
            <asp:TextBox ID="txtdate" runat="server" CssClass="form-control"></asp:TextBox>  
                
             <cc1:CalendarExtender ID="txtdate_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtdate" PopupPosition="TopRight">
             </cc1:CalendarExtender>
                
        </div>
        <div class="col-md-6 form-group">
            <label >Mode of payment</label> 
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                <asp:ListItem Value="0">Select</asp:ListItem>
                <asp:ListItem>Cash</asp:ListItem>
                <asp:ListItem>Cheque</asp:ListItem>
                <asp:ListItem>DD</asp:ListItem>
                <asp:ListItem>BT</asp:ListItem>
            </asp:DropDownList> 
                
        </div>
        <div class="col-md-6 form-group">
            <label >Remarks</label> 
            <asp:TextBox ID="txtremark" runat="server" CssClass="form-control"></asp:TextBox>  
                
        </div>
        <div class="col-md-12 form-group">
            <asp:Button ID="Button1" runat="server" Text="SUBMIT" onclick="Button1_Click" Class=" btn btn-warning " ValidationGroup="a" />
              &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" ValidationGroup="a" />
        &nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
        <div class="col-md-12 grid-margin">
                 <div class="table-responsive" >
<table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0">
                   

</table>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="Lasser_spare_id" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" 
                    onrowdeleting="GridView1_RowDeleting" Width="100%" OnRowDataBound="GridView1_RowDataBound" ShowFooter="True" >
                       <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Branchname" HeaderText="Branch Name" />
                        <asp:BoundField DataField="Customername" HeaderText="Customer Name" FooterText="Total" />

                        <asp:TemplateField HeaderText="Balance as on" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                             
                     <ItemTemplate>
                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("Balanceamt","{0:n}")%>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal1" runat="server" Text="" ForeColor="White"></asp:Label>
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
                         <asp:Label ID="lbltotal2" runat="server" Text="" ForeColor="White"></asp:Label>
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
                         <asp:Label ID="lbltotal3" runat="server" Text="" ForeColor="White"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                         </asp:TemplateField>

                       <%-- 
                        <asp:TemplateField HeaderText="Total T.Sheet" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                     <ItemTemplate>
                         <asp:Label ID="Label4" runat="server" Text='<%#Eval("Total_T_Sheet") %>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal4" runat="server" Text="" ForeColor="White"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                         </asp:TemplateField>--%>

                        <%--<asp:BoundField DataField="T_S_In_Hand" HeaderText="T.S.In Hand" />
                        <asp:BoundField DataField="Total_T_Sheet" HeaderText="Total T.Sheet" />--%>
                         <asp:TemplateField  HeaderText="Edit">
                        <ItemTemplate>
                        
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/DSR/icon/edit.png" CommandName="Select"  />
                        
                        </ItemTemplate>
                        
                        </asp:TemplateField>
            <asp:TemplateField  HeaderText="Delete">
                        <ItemTemplate>
                        
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/DSR/icon/No.png"   CommandName="Delete" OnClientClick="return confirm('Do u delete Record?')" />
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:HyperLink ID="HyperLink1" runat="server" Text="Details" NavigateUrl='<%#Eval("Lasser_spare_id","Laser_Sundry_DebtorsSpare_balancedtl.aspx?id={0}") %>'></asp:HyperLink>

                            </ItemTemplate>

                        </asp:TemplateField>
                    </Columns>

           <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Right"  />
        
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
                 </div>
                        

             </div>
    </div>
</div>

</div>

</div>

      </div>

</asp:Content>

