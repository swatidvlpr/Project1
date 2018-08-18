<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Leaveapplication.aspx.cs" Inherits="Hr_Leaveapplication" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
<div class="main-page">
    <div id="form1" class="forms validation">
        <div class="form-grids row widget-shadow" data-example-id="basic-forms">
            <div class="form-title">
							<h4>Leave Application:</h4>
						</div>
             <div class="form-body" id="form">
                  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                     <ContentTemplate>                     
                  <div class="col-md-6 form-group">
                     <label >Employee Code:</label>
                      <asp:TextBox ID="txtecode" runat="server" CssClass="form-control" AutoPostBack="True" OnTextChanged="txtecode_TextChanged"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        ErrorMessage="Enter employee code" ControlToValidate="txtecode" ValidationGroup="a"></asp:RequiredFieldValidator>
                  </div>
                  <div class="col-md-6 form-group">
                     <label >From date:</label> 
                      <asp:TextBox ID="txtfromdate" runat="server" CssClass="form-control" OnTextChanged="txtfromdate_TextChanged" AutoPostBack="True"></asp:TextBox>
    
                      <cc1:CalendarExtender ID="txtfromdate_CalendarExtender" runat="server" Enabled="True" PopupPosition="TopRight" TargetControlID="txtfromdate">
                      </cc1:CalendarExtender>
    
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  
        ErrorMessage="Enter from date" ControlToValidate="txtfromdate" ValidationGroup="a"></asp:RequiredFieldValidator>
                 </div>
                 <div class="col-md-6 form-group">
                    <label >To date:</label>                      
                     
                     <asp:TextBox ID="txttodate" runat="server" CssClass="form-control"></asp:TextBox>
                     <cc1:CalendarExtender ID="txttodate_CalendarExtender" runat="server" Enabled="True" PopupPosition="TopLeft" TargetControlID="txttodate">
                     </cc1:CalendarExtender>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter to date" ControlToValidate="txttodate" ValidationGroup="a"></asp:RequiredFieldValidator>
   
                 </div>

                   <div class="col-md-6 form-group">
                    <label >Leave type:</label>                      
                     
                       <asp:DropDownList ID="ddlleavetype" runat="server" CssClass="form-control">
                           <asp:ListItem Value="0">--Select--</asp:ListItem>
                       </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter leave type" ControlToValidate="ddlleavetype" ValidationGroup="a" InitialValue="0"></asp:RequiredFieldValidator>
   
                 </div>
                
                  <div class="col-md-6 form-group">
                    <label >Leave Duration:</label>                      
                     
                       <asp:DropDownList ID="ddlleaveduration" runat="server" CssClass="form-control">
                           <asp:ListItem Value="0">Select</asp:ListItem>
                           <asp:ListItem>Full Day</asp:ListItem>
                           <asp:ListItem>Half Day</asp:ListItem>
                      </asp:DropDownList>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter leave duration" ControlToValidate="ddlleaveduration" ValidationGroup="a" InitialValue="0"></asp:RequiredFieldValidator>
   
                 </div>
                 <div class="col-md-6 form-group">
                    <label >Reason:</label>                      
                     
                     <asp:TextBox ID="txtreason" runat="server" CssClass="form-control" ></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Enter reason" ControlToValidate="txtreason" ValidationGroup="a"></asp:RequiredFieldValidator>
   
                 </div>
                  <div class="col-md-6 form-group">
                    <label >Contact no.During Leave:</label>                      
                     
                     <asp:TextBox ID="txtContact" runat="server" CssClass="form-control" ></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Enter contact no.during Leave" ControlToValidate="txtContact" ValidationGroup="a"></asp:RequiredFieldValidator>
   
                 </div>

                 <div class="col-md-6 form-group">                     
                   
                 </div>
                 <div class="col-md-12 form-group">
                     <asp:Button ID="Button1" runat="server" Text="submit" onclick="Button1_Click" Class=" btn btn-warning " ValidationGroup="a" />
                       &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" />
                     <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                 </div>
                 <div class="col-md-12 grid-margin">
                 <div class="table-responsive" >
<table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="leaveapplication_id" onrowdeleting="GridView1_RowDeleting" 
        onselectedindexchanged="GridView1_SelectedIndexChanged" CellPadding="4" 
        ForeColor="#333333" GridLines="None" Width="100%" OnRowDataBound="GridView1_RowDataBound">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Employee_Code" HeaderText="Employee Code" />
            <asp:BoundField DataField="From_date" HeaderText="From date" />
            <asp:BoundField DataField="To_date" HeaderText="To date" />
            <asp:BoundField DataField="Leave_type" HeaderText="Leave Type" />
             <asp:BoundField DataField="Leave_Duration" HeaderText="Leave Duration" />
            <asp:BoundField DataField="Reason" HeaderText="Reason" />
            <asp:BoundField DataField="Contact_during_Leave" HeaderText="Contact During Leave" />
       
            <asp:CommandField ShowSelectButton="true" SelectText="Edit" />
            <asp:CommandField ShowDeleteButton="True" />
            <asp:TemplateField HeaderText="Status Hod">
                <ItemTemplate>
                   <%--  <asp:Button ID="lnk_ship" runat="server" CssClass="btn-mini" Text="Ship Software" Visible='<%# DataBinder.Eval(Container.DataItem, "shipped" ) == "Yes" ? true : false %>' /></ItemTemplate>--%>
                    <asp:HiddenField ID="HiddenField1" runat="server" Value='<%#Eval("Status_hod") %>'/>
                     <asp:Button ID="Button3" runat="server" Text="Button" />
                </ItemTemplate>
                

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Status Hr">
                <ItemTemplate>
                   <%--  <asp:Button ID="lnk_ship" runat="server" CssClass="btn-mini" Text="Ship Software" Visible='<%# DataBinder.Eval(Container.DataItem, "shipped" ) == "Yes" ? true : false %>' /></ItemTemplate>--%>
                    <asp:HiddenField ID="HiddenField2" runat="server" Value='<%#Eval("Status_hr") %>'/>
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
                   <div class="col-md-12 form-group">

                       

                   </div>     

             </div>
                  </ContentTemplate>
                 </asp:UpdatePanel>
             </div>

        </div>


    </div>

</div>

    </div>
</asp:Content>

