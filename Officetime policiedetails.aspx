<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Officetime policiedetails.aspx.cs" Inherits="Hr_Officetime_policiedetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <div id="page-wrapper">
           <div class="main-page">
                <div id="form1" class="forms validation">
                       <div class="form-grids row widget-shadow" data-example-id="basic-forms">
                               <div class="form-title">
					<h4>Policies Details</h4>

                               </div>
                               <div class="form-body" id="form">
                                      <div class="col-md-12 form-group">
                               <label >Policies type</label>
                                          <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" >
                                              <asp:ListItem>-----select-----</asp:ListItem>
                                              <asp:ListItem>Late arrival</asp:ListItem>
                                              <asp:ListItem>Early depatures</asp:ListItem>
                                              <asp:ListItem>Present</asp:ListItem>
                                              <asp:ListItem>Half day</asp:ListItem>
                                              <asp:ListItem>Absent</asp:ListItem>
                                          </asp:DropDownList>  
                                          <br />
                                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                              ControlToValidate="DropDownList1" ErrorMessage="Required policies type"></asp:RequiredFieldValidator>
                                      </div>
                               <div class="col-md-12 form-group">
                                <label >Policies title</label>
                                   <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                                   <br />
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                       ControlToValidate="TextBox1" ErrorMessage="Required polies title"></asp:RequiredFieldValidator>
                               </div>
                               <div class="col-md-12 form-group">
                                <label >Description</label>
                                   <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" 
                                       TextMode="MultiLine"></asp:TextBox>
                                   <br />
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                       ControlToValidate="TextBox2" ErrorMessage="Required description"></asp:RequiredFieldValidator>
                               </div>
                               
                            <div class="col-md-12 form-group">
                                 <asp:Button ID="Button1" runat="server" Text="Submit" Class=" btn btn-warning " onclick="Button1_Click" 
        Height="40px" Width="109px" />
         &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" Height="40px" Width="109px" />
                                  &nbsp;<br />
    <asp:Label ID="Label1" runat="server"></asp:Label>  

                               </div>
                                   <asp:ScriptManager ID="ScriptManager1" runat="server">
                                   </asp:ScriptManager>
                                      <br />
                                      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                                          CellPadding="4" ForeColor="#333333" GridLines="None" 
                                          DataKeyNames="Policies_id" onrowdeleting="GridView1_RowDeleting" 
                                          onselectedindexchanged="GridView1_SelectedIndexChanged" Width="100%">
                                          <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                          <Columns>
                                              <asp:BoundField DataField="Policies_type" HeaderText="POLICIES TYPE" />
                                              <asp:BoundField DataField="Policies_title" HeaderText="POLICIES TITLE" />
                                              <asp:BoundField DataField="Description" HeaderText="DESCRIPTION" />
                                              <asp:CommandField SelectText="Edit" ShowSelectButton="True" />
                                              <asp:CommandField ShowDeleteButton="True" />
                                          </Columns>
                                          <EditRowStyle BackColor="#999999" />
                                          <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                          <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                          <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                          <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                          <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                          <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                          <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                          <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                          <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                      </asp:GridView>
                       </div>
                </div>
          </div>
 </div>
 </div>
</asp:Content>

