<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="leave_register.aspx.cs" Inherits="Hr_leave_register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="Div1" class="forms validation">
        <div id="form1" class="forms validation">
           
			
           <div id="page-wrapper">
			<div class="main-page">
<div class="forms" data-example-id="form-validation-states">
    <div class="form-grids row widget-shadow" data-example-id="basic-forms">
        <div class="form-title">
							<h4>Leave Register :</h4>
		</div>
   
  <div class="col-md-6 form-group">
                                        <label >Month</label>
                                         <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" 
                                             AutoPostBack="True">
                                             <asp:ListItem Value="0">---select---</asp:ListItem>
                                             <asp:ListItem Value="01">jan</asp:ListItem>
                                             <asp:ListItem Value="02">feb</asp:ListItem>
                                             <asp:ListItem Value="03">mar</asp:ListItem>
                                             <asp:ListItem Value="04">apr</asp:ListItem>
                                             <asp:ListItem Value="05">may</asp:ListItem>
                                             <asp:ListItem Value="06">jun</asp:ListItem>
                                             <asp:ListItem Value="07">jul</asp:ListItem>
                                             <asp:ListItem Value="08">aug</asp:ListItem>
                                             <asp:ListItem Value="09">sep</asp:ListItem>
                                             <asp:ListItem Value="10">oct</asp:ListItem>
                                             <asp:ListItem Value="11">nov</asp:ListItem>
                                             <asp:ListItem Value="12">dec</asp:ListItem>
                                         </asp:DropDownList>
                                            </div>

                                     <div class="col-md-6 form-group">
                                        <label >Year</label>
                                                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" 
                                                    AutoPostBack="True">
                                                    <asp:ListItem>---select---</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-md-12 form-group">
                                    <asp:Button ID="submit" runat="server" Class=" btn btn-warning " Text="Search" 
                                                    OnClick="submit_Click" ValidationGroup="a"  />
                                   &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" 
                                                    ValidationGroup="b" onclick="Button2_Click" />
                              </div>

            <%-- <div class="col-md-12 form-group">
            <asp:Button ID="Button1" runat="server" Text="SUBMIT" onclick="Button1_Click" Class=" btn btn-warning " />
              &nbsp;<asp:Button ID="Button3" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" ValidationGroup="a" />
                 <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>--%>

             
                            <div class="col-md-12 grid-margin">
                 <div class="table-responsive" >
                      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="leaveapplication_id" CellPadding="4" 
        ForeColor="#333333" GridLines="None" Width="100%" OnRowDataBound="GridView1_RowDataBound">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Employee_Code" HeaderText="Employee Code" />            
            <asp:BoundField DataField="From_date" HeaderText="From date"  DataFormatString="{0:dd/MM/yyyy}" />

            <asp:BoundField DataField="To_date" HeaderText="To date" />
            <asp:BoundField DataField="Leave_type" HeaderText="Leave Type" />
             <asp:BoundField DataField="Leave_Duration" HeaderText="Leave Duration" />
            <asp:BoundField DataField="Reason" HeaderText="Reason" />
            <asp:BoundField DataField="Contact_during_Leave" HeaderText="Contact During Leave" />
       
            <asp:TemplateField  HeaderStyle-HorizontalAlign="Right">
                <HeaderTemplate>Status Hr</HeaderTemplate>
                <ItemTemplate>
                  <samp>
                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("Status_hr") %>' />
                     <asp:Button ID="Button3" runat="server" Text="Button"  />
                  </samp>
                    <samp>
                        <asp:Button ID="Button5" runat="server" Text="Button"   />
                  </samp>
                    
                   
                </ItemTemplate>
                

<HeaderStyle HorizontalAlign="Right"></HeaderStyle>
                

            </asp:TemplateField>
             <asp:TemplateField >
                <ItemTemplate>
                  
                    
                     
                   
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
<table id="Table1" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0"  >
    

</table>

                 </div>
                     

             </div>


         </div>

    </div>

</div>
    </div> 
    </div>
</asp:Content>

