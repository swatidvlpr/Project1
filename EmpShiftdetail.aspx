<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="EmpShiftdetail.aspx.cs" Inherits="Hr_Shiftdetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="page-wrapper">
         <div class="main-page">
             <div id="form1" class="forms validation">
                 <div class="form-grids row widget-shadow" data-example-id="basic-forms">
                      <div class="form-title">
							<h4>Assign shifts </h4>
						</div>
                     <div class="form-body" id="form">
                         
                     <div class="col-md-6 form-group">
                                       <label >Company name</label>  
                                       <asp:DropDownList ID="ddlcompany" runat="server"  
        AutoPostBack="True" CssClass="form-control">
    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
        ErrorMessage="select company name" ControlToValidate="ddlcompany" InitialValue="0"></asp:RequiredFieldValidator>
                     </div> 
                     
                     <div class="col-md-6 form-group">
                      <label >Department name </label>  
                          <asp:DropDownList ID="ddldepartment" runat="server"  
                                     CssClass="form-control">
                                </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="ddldepartment" ErrorMessage="Enter the location name"></asp:RequiredFieldValidator>
                     </div>
                         <div class="col-md-12 form-group">
                             <asp:Button ID="Button2" runat="server" Text="Search" Class=" btn btn-warning " onclick="Button2_Click" />
                         &nbsp;<asp:Button ID="Button3" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button3_Click" ValidationGroup="a" />
                         </div>

                         <div class="col-md-12  grid-margin">
                             <div class="table-responsive" >                            
                            <table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0"  >
                           
                             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                 BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
                                 CellPadding="3" CellSpacing="2" DataKeyNames="EmployeeCode" 
                                 onselectedindexchanged="GridView1_SelectedIndexChanged">
                                 <Columns>
           <asp:TemplateField>
<ItemTemplate>
<asp:CheckBox ID="chkSelect" runat="server" />
</ItemTemplate>
</asp:TemplateField>

                                     <asp:TemplateField HeaderText="ID">                                   

                                         <ItemTemplate>
                                             <asp:Label ID="lbllcode" runat="server" Text='<%#Eval("EmployeeCode")%>'></asp:Label>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="NAME">                                     
                                         <ItemTemplate>
                                             <asp:Label ID="lblname" runat="server" Text='<%#Eval("name")%>'></asp:Label>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                      <asp:TemplateField HeaderText="COMPANY">                                     
                                         <ItemTemplate>
                                             <asp:Label ID="lblcompany" runat="server" Text='<%#Eval("companyname")%>'></asp:Label>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="DEPARTMENT">                                     
                                         <ItemTemplate>
                                             <asp:Label ID="lbldepart" runat="server" Text='<%#Eval("Departmentnm")%>'></asp:Label>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                     <asp:TemplateField HeaderText="QUALIFICATION">                                     
                                         <ItemTemplate>
                                             <asp:Label ID="lblqual" runat="server" Text='<%#Eval("Qualification")%>'></asp:Label>
                                         </ItemTemplate>
                                     </asp:TemplateField>
                                    
                                     
                                 </Columns>
                                 <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                 <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                                 <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                                 <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                 <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                                 <SortedAscendingCellStyle BackColor="#FFF1D4" />
                                 <SortedAscendingHeaderStyle BackColor="#B95C30" />
                                 <SortedDescendingCellStyle BackColor="#F1E5CE" />
                                 <SortedDescendingHeaderStyle BackColor="#93451F" />

                             </asp:GridView>
                                 </table>
                            </div>
                         </div>
                                <div class="col-md-12 form-group">
                                  <label >Shift name</label>  
                                 <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                                     <asp:ListItem>----select shift----</asp:ListItem>
                                     <asp:ListItem>A</asp:ListItem>
                                     <asp:ListItem>B</asp:ListItem>
                                     <asp:ListItem>C</asp:ListItem>
                                     <asp:ListItem>GENERAL</asp:ListItem>
                                     </asp:DropDownList>
                                                    </div>
                                            
                                     <div class="col-md-12 form-group">
                                         <asp:HiddenField ID="hfCount" runat="server" Value = "0" />

<%--OnClientClick = "return ConfirmDelete();"--%>

                                 <asp:Button ID="Button1" runat="server" Text="Submit" Class=" btn btn-warning " onclick="Button1_Click" 
        Height="40px" Width="109px" /></div>
                           
                             <div class="col-md-12 form-group">
                                 
                                  </div>
                                     
                       <asp:Panel ID="Panel1" runat="server">
                         
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"  
        onselectedindexchanged="Page_Load" 
        DataKeyNames="shiftid" CellPadding="4" ForeColor="#333333" 
        GridLines="None" Width="100%">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
             <asp:BoundField DataField="EmployeeCode" HeaderText="EMPLOYEE CODE" />
             <asp:BoundField DataField="name" HeaderText="NAME" />
             <asp:BoundField DataField="shiftname" HeaderText="SHIFT NAME" />
             <asp:BoundField DataField="companyname" HeaderText="COMPANY NAME" />
              <asp:BoundField DataField="Departmentnm" HeaderText="DEPARTMENT NAME" />
                       
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Right"  />
        
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
       
    </asp:GridView>
     </asp:Panel>
             </div>
             </div>
             </div>
             
         </div>
     </div>

</asp:Content>

