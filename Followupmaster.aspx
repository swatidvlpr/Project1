<%@ Page Title="" Language="C#" MasterPageFile="~/DSR/DSR.master" AutoEventWireup="true" CodeFile="Followupmaster.aspx.cs" Inherits="DSR_Followupmaster" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
<div class="main-page">
<div id="form1" class="forms validation">
  
<div class="form-grids row widget-shadow" data-example-id="basic-forms">
    <div class="form-title">
	<h4>Follow up</h4>
	</div>
    <div class="form-body" id="form">
          <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

           
<div class="col-md-6 form-group">
    <label >Sales Man Name</label>
    <asp:DropDownList ID="ddlsales" runat="server" CssClass="form-control"  AutoPostBack="True" ViewStateMode="Enabled"  EnableViewState="true"  OnSelectedIndexChanged="ddlsales_SelectedIndexChanged"></asp:DropDownList>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
      ControlToValidate="ddlsales" ErrorMessage="Select sales man name" ValidationGroup="a"></asp:RequiredFieldValidator>
    
</div>
         
       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
        <div class="col-md-6 form-group">
    <label >Customer Name</label>
    <asp:DropDownList ID="ddlcustomer" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlcustomer_SelectedIndexChanged" OnDataBound="ddlcustomer_DataBound"></asp:DropDownList>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
      ControlToValidate="ddlcustomer" ErrorMessage="Select customer name" ValidationGroup="a"></asp:RequiredFieldValidator>
</div>
          <div class="col-md-6 form-group">
            <label >Date</label> 
            <asp:TextBox ID="txtdate" runat="server" CssClass="form-control"></asp:TextBox>
                <cc1:CalendarExtender ID="txtdate_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtdate" PopupPosition="TopRight">
            </cc1:CalendarExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="txtdate" ErrorMessage="Enter date" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
         <div class="col-md-6 form-group">
            <label >Company Name </label> 
           <%-- <asp:TextBox ID="txtdate" runat="server" CssClass="form-control"></asp:TextBox>--%>
             <asp:DropDownList ID="ddlcompany" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlcompany_SelectedIndexChanged">
                 
              </asp:DropDownList>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server"  
                    ControlToValidate="ddlcompany" ErrorMessage="Enter company name" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
         <div class="col-md-6 form-group">
            <label >Category Name </label> 
           <%-- <asp:TextBox ID="txtdate" runat="server" CssClass="form-control"></asp:TextBox>--%>
             <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged" OnDataBound="ddlCategory_DataBound">                 
              </asp:DropDownList>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server"  
                    ControlToValidate="ddlCategory" ErrorMessage="Enter category name" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>

          <div class="col-md-6 form-group">
            <label >Model Name </label> 
           <%-- <asp:TextBox ID="txtdate" runat="server" CssClass="form-control"></asp:TextBox>--%>
             <asp:DropDownList ID="ddlmodelnm" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlmodelnm_SelectedIndexChanged" OnDataBound="ddlmodelnm_DataBound">                 
              </asp:DropDownList>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server"  
                    ControlToValidate="ddlmodelnm" ErrorMessage="Enter model name" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
         <div class="col-md-6 form-group">
            <label >Model No </label> 
            <asp:TextBox ID="txtmodelno" runat="server" CssClass="form-control"></asp:TextBox>
                       
                <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server"  
                    ControlToValidate="txtmodelno" ErrorMessage="Enter model no" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>

<div class="col-md-6 form-group">
    <label >Followup Type</label>
    <asp:DropDownList ID="ddlFollowuptype" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="ddlFollowuptype" ErrorMessage="Select follow up type" ValidationGroup="a"></asp:RequiredFieldValidator>
</div>
         <div class="col-md-6 form-group">
            <label >Followup Status</label>
             <asp:DropDownList ID="ddlfollowupstatus" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="ddlfollowupstatus" ErrorMessage="Select followup status" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-6 form-group">
            <label >Customer Comparing Price</label>
            <asp:TextBox ID="txtcustomercomparingprice" runat="server" CssClass="form-control"></asp:TextBox>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtcustomercomparingprice" ErrorMessage="Enter customer comparing price" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
         <div class="col-md-6 form-group">
            <label >Branch Name</label>
             <asp:DropDownList ID="ddlbranch" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="ddlbranch" ErrorMessage="Select branch name" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
       <div class="col-md-6 form-group">
            <label >Next Follow up Date</label> 
            <asp:TextBox ID="txtnextfollowupdt" runat="server" CssClass="form-control"></asp:TextBox>
                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Enabled="True" TargetControlID="txtnextfollowupdt" PopupPosition="TopRight">
            </cc1:CalendarExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="txtnextfollowupdt" ErrorMessage="Enter next follow up date" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
       
      
        <div class="col-md-12 form-group">
            <asp:Button ID="Button1" runat="server" Text="SUBMIT" onclick="Button1_Click" Class=" btn btn-warning " ValidationGroup="a" />
              &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" />
        &nbsp;<asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
        </ContentTemplate>
      
        </asp:UpdatePanel>
        
        <div class="col-md-12 grid-margin">
                 <div class="table-responsive" >
<table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0">
                   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="Follow_id" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" 
                    onrowdeleting="GridView1_RowDeleting" Width="100%" >
                       <AlternatingRowStyle  BackColor="White" ForeColor="#284775" />
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
                        <asp:BoundField DataField="Followup_type" HeaderText="Followup Type" />  
                        <asp:BoundField DataField="Followup_status" HeaderText="Followup Status" />  
                        <asp:BoundField DataField="date" HeaderText="Date" />  
                        <asp:BoundField DataField="Next_dt" HeaderText="Next Followup Date" />  
                       
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
                    </Columns>

           <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" HorizontalAlign="Right"  />
        
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>

</table>

                 </div>
                        

             </div>
    </div>
</div>

</div>

</div>

      </div>
</asp:Content>

