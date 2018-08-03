<%@ Page Title="" Language="C#" MasterPageFile="~/DSR/DSR.master" AutoEventWireup="true" CodeFile="Enquryform11.aspx.cs" Inherits="DSR_Enquryform" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
<div class="main-page">
<div id="form1" class="forms validation">
<div class="form-grids row widget-shadow" data-example-id="basic-forms">
    <div class="form-title">
	<h4>Enquiry Details</h4>
	</div>
    <div class="form-body" id="form">
<div class="col-md-6 form-group">
    <label >Customer Name</label>
    <asp:TextBox ID="txtcustomernm" runat="server" CssClass="form-control"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
      ControlToValidate="txtcustomernm" ErrorMessage="Enter customer name" ValidationGroup="a"></asp:RequiredFieldValidator>
</div>
<div class="col-md-6 form-group">
    <label >Email id</label>
    <asp:TextBox ID="txtemailid" runat="server" CssClass="form-control"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtemailid" ErrorMessage="Enter email id" ValidationGroup="a"></asp:RequiredFieldValidator>
</div>

        <div class="col-md-6 form-group">
            <label >Mobile no</label>
            <asp:TextBox ID="txtmobileno" runat="server" CssClass="form-control" MaxLength="10">0</asp:TextBox>
                <cc1:FilteredTextBoxExtender ID="txtSaleQty_FilteredTextBoxExtender" runat="server" Enabled="True" FilterType="Numbers"  TargetControlID="txtmobileno">
            </cc1:FilteredTextBoxExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtmobileno" ErrorMessage="Enter mobile no" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-6 form-group">
            <label >Site location</label>
            <asp:TextBox ID="txtsitelocation" runat="server" CssClass="form-control"></asp:TextBox>
              
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtsitelocation" ErrorMessage="Enter site location" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-6 form-group">
          <label >Address </label>  
             <asp:TextBox ID="txtaddress" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>                
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtaddress" ErrorMessage="Enter address" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-6 form-group">
            <label >Pincode </label>
&nbsp;<asp:TextBox ID ="txtpincode" runat="server" CssClass="form-control" MaxLength="6">0</asp:TextBox>
                <cc1:FilteredTextBoxExtender ID ="txtpincodess" runat="server" Enabled="True" FilterType="Numbers" TargetControlID="txtpincode">
            </cc1:FilteredTextBoxExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="txtpincode" ErrorMessage="Enter pincode" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>

         <div class="col-md-6 form-group">
            <label >State</label> 
            <asp:TextBox ID="txtstate" runat="server" CssClass="form-control"></asp:TextBox>
             <%--<asp:DropDownList ID="ddlState" runat="server" CssClass="form-control"></asp:DropDownList>--%>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"  
                    ControlToValidate="txtstate" ErrorMessage="Enter state" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
         <div class="col-md-6 form-group">
            <label >City </label> 
            <asp:TextBox ID="txtcity" runat="server" CssClass="form-control"></asp:TextBox>
           <%--  <asp:DropDownList ID="ddlCity" runat="server" CssClass="form-control"></asp:DropDownList> --%>          
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server"  
                    ControlToValidate="txtcity" ErrorMessage="Enter city" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>

         <div class="col-md-6 form-group">
            <label >District </label> 
            <asp:TextBox ID="txtdistrict" runat="server" CssClass="form-control"></asp:TextBox>
             <%--<asp:DropDownList ID="ddldistrict" runat="server" CssClass="form-control"></asp:DropDownList>        --%>   
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"  
                    ControlToValidate="txtdistrict" ErrorMessage="Enter district" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
          <div class="col-md-6 form-group">
            <label >Account Category </label> 
           <%-- <asp:TextBox ID="txtdate" runat="server" CssClass="form-control"></asp:TextBox>--%>
             <asp:DropDownList ID="ddlAccountCategory" runat="server" CssClass="form-control">
                 <asp:ListItem Value="0">Select</asp:ListItem>
                 <asp:ListItem>Corporate</asp:ListItem>
                 <asp:ListItem>Government</asp:ListItem>
                 <asp:ListItem>Individual</asp:ListItem>
                 <asp:ListItem>Institute</asp:ListItem>
              </asp:DropDownList>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server"  
                    ControlToValidate="ddlAccountCategory" ErrorMessage="Enter account category" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
          <div class="col-md-6 form-group">
            <label >Fleet Size </label> 
           <%-- <asp:TextBox ID="txtdate" runat="server" CssClass="form-control"></asp:TextBox>--%>
             <asp:DropDownList ID="ddlfleetsize" runat="server" CssClass="form-control">
                 <asp:ListItem Value="0">Select</asp:ListItem>
                 <asp:ListItem>FTU(0-1)</asp:ListItem>
                 <asp:ListItem>SFO(2-10)</asp:ListItem>
                 <asp:ListItem>MFO(11-25)</asp:ListItem>
                 <asp:ListItem>LFO(>25)</asp:ListItem>
                 <asp:ListItem>>100</asp:ListItem>
              </asp:DropDownList>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server"  
                    ControlToValidate="ddlfleetsize" ErrorMessage="Enter fleet size" ValidationGroup="a"></asp:RequiredFieldValidator>
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
             <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">                 
              </asp:DropDownList>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server"  
                    ControlToValidate="ddlCategory" ErrorMessage="Enter category name" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>

          <div class="col-md-6 form-group">
            <label >Model Name </label> 
           <%-- <asp:TextBox ID="txtdate" runat="server" CssClass="form-control"></asp:TextBox>--%>
             <asp:DropDownList ID="ddlmodelnm" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlmodelnm_SelectedIndexChanged">                 
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
            <label >Unit of required </label> 
            <asp:TextBox ID="txtUnit_of_required" runat="server" CssClass="form-control"></asp:TextBox>
                       
                <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server"  
                    ControlToValidate="txtUnit_of_required" ErrorMessage="Enter unit of required" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>

         <div class="col-md-6 form-group">
            <label >Employee Name </label> 
            <asp:DropDownList ID="ddlemployee" runat="server" CssClass="form-control">                 
              </asp:DropDownList>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server"  
                    ControlToValidate="ddlemployee" ErrorMessage="Select employee name" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>

       <%-- <div class="col-md-6 form-group">
            <label >Employee Name </label> 
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">                 
              </asp:DropDownList>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server"  
                    ControlToValidate="ddlemployee" ErrorMessage="Select employee name" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>--%>
        <div class="col-md-6 form-group">
            <label >Purchase Plan </label>
            <asp:TextBox ID="txtpurchaseplan" runat="server" CssClass="form-control"></asp:TextBox>
            <%--<asp:DropDownList ID="ddlPurchaseplan" runat="server" CssClass="form-control">                 
              </asp:DropDownList>--%>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server"  
                    ControlToValidate="txtpurchaseplan" ErrorMessage="Enter purchase plan" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
         <div class="col-md-6 form-group">
            <label >Enquiry Source </label> 
            <asp:DropDownList ID="ddlEnquirysource" runat="server" CssClass="form-control">                 
              </asp:DropDownList>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server"  
                    ControlToValidate="ddlEnquirysource" ErrorMessage="Select enquiry source" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
        <div class="col-md-6 form-group">
            <label >Date </label> 
            <asp:TextBox ID="txtdate" runat="server" CssClass="form-control"></asp:TextBox>         
                <cc1:CalendarExtender ID="txtdate_CalendarExtender" runat="server" Enabled="True" TargetControlID="txtdate" PopupPosition="TopRight">
            </cc1:CalendarExtender>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server"  
                    ControlToValidate="txtdate" ErrorMessage="Enter the date" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>
          <div class="col-md-6 form-group">
            <label >Branch Name </label> 
            <asp:DropDownList ID="ddlbranch" runat="server" CssClass="form-control">                 
              </asp:DropDownList>           
                <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server"  
                    ControlToValidate="ddlbranch" ErrorMessage="Select branch name" ValidationGroup="a"></asp:RequiredFieldValidator>
        </div>

        <div class="col-md-12 form-group">
            <asp:Button ID="Button1" runat="server" Text="SUBMIT" onclick="Button1_Click" Class=" btn btn-warning " ValidationGroup="a" />
              &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" ValidationGroup="a" />
        &nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server"></asp:Label>
        &nbsp;<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        &nbsp;</div>
        <div class="col-md-12 grid-margin">
                 <div class="table-responsive" >
<table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0">
                   

</table>

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="Enquryid" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged" 
                    onrowdeleting="GridView1_RowDeleting" Width="100%" ShowFooter="True" >
                       <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="Customer_name" HeaderText="Customer Name" />
                        <asp:BoundField DataField="Email_id" HeaderText="Email Id"  />
                        <asp:BoundField DataField="Mobile_no" HeaderText="Mobile No"  />
                        <asp:BoundField DataField="Pincode" HeaderText="Pincode"  />
                        <asp:BoundField DataField="Modelname" HeaderText="Model Name"  />
                        <asp:BoundField DataField="Modelno" HeaderText="Model No"  />

                        <%--<asp:TemplateField HeaderText="Sale Qty" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                     <ItemTemplate>
                         <asp:Label ID="Label1" runat="server" Text='<%#Eval("Sale_Qty") %>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal1" runat="server" Text="" ForeColor="White"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                      </asp:TemplateField>                  
                        
                        <asp:TemplateField HeaderText="Total" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                     <ItemTemplate>
                         <asp:Label ID="Label2" runat="server" Text='<%#Eval("Total") %>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal2" runat="server" Text="" ForeColor="White"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                         </asp:TemplateField>                       
                        
                        <asp:TemplateField HeaderText="T.S.In Hand" ItemStyle-HorizontalAlign="Right" 
                                    FooterStyle-HorizontalAlign="Left">
                     <ItemTemplate>
                         <asp:Label ID="Label3" runat="server" Text='<%#Eval("T_S_In_Hand") %>'></asp:Label>
                     </ItemTemplate>
                     <FooterTemplate>
                         <asp:Label ID="lbltotal3" runat="server" Text="" ForeColor="White"></asp:Label>
                     </FooterTemplate>

                            <FooterStyle HorizontalAlign="Left"></FooterStyle>

                                             <HeaderStyle HorizontalAlign="Left" />

                        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                                         </asp:TemplateField>

                        
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
                                         </asp:TemplateField>      --%>                
                       
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


                 </div>
                        

             </div>
    </div>
</div>

</div>

</div>

      </div>
</asp:Content>

