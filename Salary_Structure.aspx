<%@ Page Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Salary_Structure.aspx.cs" Inherits="AdminZone_Salary_Structure" Title="AdminZone::Salary_Structure" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
        .style4
        {
            height: 21px;
        }
        .style5
        {
            height: 22px;
        }
        .style6
        {
            width: 10px;
            height: 22px;
        }
        .style7
        {
            width: 263px;
        }
        .style8
        {
            height: 21px;
            width: 263px;
        }
        .style9
        {
            width: 263px;
            height: 22px;
        }
        .style10
        {
            height: 18px;
        }
        .style11
        {
            width: 10px;
            height: 18px;
        }
        </style>

    </asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
        <div class="main-page">
            <div id="form1" class="forms validation">
                <div class="form-grids row widget-shadow" data-example-id="basic-forms">
                    <div class="form-title">
							<h4>Employee Form :</h4>
						</div>
                     <div class="form-body" id="form">
                         <div class="col-md-12 form-group">
                             <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                                RepeatDirection="Horizontal" AutoPostBack="True" 
                                onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
                                CellPadding="12" CellSpacing="12" Width="800px">
                                <asp:ListItem>EARNINGS</asp:ListItem>
                                <%--<asp:ListItem>ADVANCE</asp:ListItem>--%>
                                <asp:ListItem>DEDUCTIONS</asp:ListItem>
                                <asp:ListItem>PAYMENT</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                          <div class="col-md-12 form-group">
                              <asp:Panel ID="Panel1" runat="server"  width="100%">
                     
                          <label class="col-md-4 form-group">Employee code</label>
                                  <div class="col-md-6 form-group">

                           <asp:DropDownList ID="ddlemployee" runat="server" AutoPostBack="True" 
                CssClass="col-md-6 form-control" onselectedindexchanged="ddlemployee_SelectedIndexChanged" >
            </asp:DropDownList>  
                                  </div>

                                   <label class="col-md-4 form-group">Month and Year:</label>
                                  <div class="col-md-3 form-group">
                                      <asp:DropDownList ID="ddlmonth0" runat="server" CssClass="form-control" TabIndex="1" >
                    <asp:ListItem Value="0">--Select--</asp:ListItem>
                </asp:DropDownList>

                                  </div>
                                  <div class="col-md-3 form-group">
                                       <asp:DropDownList ID="ddlyear0" runat="server" CssClass="form-control"  
                    AutoPostBack="True" onselectedindexchanged="ddlyear0_SelectedIndexChanged" TabIndex="2">
                    <asp:ListItem Value="0">--Select--</asp:ListItem>
                </asp:DropDownList>
                                  </div>
                                  <label class="col-md-4 form-group">Name :</label>
                                  <div class="col-md-6 form-group">
                                      <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TabIndex="3"></asp:TextBox>
                                  </div>
                                   <label class="col-md-4 form-group">Basic :</label>
                                  <div class="col-md-6 form-group">
                                      <asp:TextBox ID="txtbasic" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtbasic_TextChanged" TabIndex="4" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="txtbasic_FilteredTextBoxExtender" 
                runat="server" Enabled="True" TargetControlID="txtbasic" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
                                  </div>
                                  <label class="col-md-4 form-group">HRA :</label>
                                  <div class="col-md-6 form-group">
                                       <asp:TextBox ID="txthra" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txthra_TextChanged" TabIndex="5" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="txthra_FilteredTextBoxExtender" runat="server" 
                Enabled="True" TargetControlID="txthra" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
                                  </div>
                                  <label class="col-md-4 form-group">Medical Allowance :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtmedical" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtmedical_TextChanged" TabIndex="6" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender1" runat="server" 
                Enabled="True" TargetControlID="txtmedical" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
             <label class="col-md-4 form-group">Conveyance Allowance :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtConveyance" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtConveyance_TextChanged" TabIndex="7" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender2" runat="server" 
                Enabled="True" TargetControlID="txtConveyance" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
                                   <label class="col-md-4 form-group">C.C.A Allowance :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtC_C_Allowance" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtC_C_Allowance_TextChanged" TabIndex="8" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender3" runat="server" 
                Enabled="True" TargetControlID="txtC_C_Allowance" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
                                    <label class="col-md-4 form-group">Washing Allowance :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtWashing" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtWashing_TextChanged" TabIndex="9" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender4" runat="server" 
                Enabled="True" TargetControlID="txtWashing" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
<label class="col-md-4 form-group">Arrear Pay Allowance :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtarrear_Pay_All" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtarrear_pay_all_TextChanged" TabIndex="10" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender15" runat="server" 
                Enabled="True" TargetControlID="txtarrear_Pay_All" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
<label class="col-md-4 form-group">Misc.Earning Narration Amount :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtmisc_earning_narration" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtmisc_earning_narration_TextChanged" TabIndex="11" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender16" runat="server" 
                Enabled="True" TargetControlID="txtmisc_earning_narration" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
                                  <label class="col-md-4 form-group">Leave Encash :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtLeave_encash" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtLeave_encash_TextChanged" TabIndex="12" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender17" runat="server" 
                Enabled="True" TargetControlID="txtLeave_encash" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
                                   <label class="col-md-4 form-group">GROSS EARNING :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtgross_earning" runat="server" CssClass="form-control" AutoPostBack="True" ReadOnly="True" 
                 >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender18" runat="server" 
                Enabled="True" TargetControlID="txtgross_earning" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>


                                  <label class="col-md-4 form-group">EPF :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtEPF" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtEPF_TextChanged" TabIndex="13" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender5" runat="server" 
                Enabled="True" TargetControlID="txtEPF" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
                                                                 <label class="col-md-4 form-group">FPF :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtFPF" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtFPF_TextChanged" TabIndex="14" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender6" runat="server" 
                Enabled="True" TargetControlID="txtFPF" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>

                                   <label class="col-md-4 form-group">VPF :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtVPF" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtVPF_TextChanged" TabIndex="15" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender7" runat="server" 
                Enabled="True" TargetControlID="txtVPF" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
                                                               <label class="col-md-4 form-group">ESI :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtESI" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtESI_TextChanged" TabIndex="16" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender8" runat="server" 
                Enabled="True" TargetControlID="txtESI" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
                                  
               <label class="col-md-4 form-group">Medical Advance :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtMedical_Adv" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtMedical_Adv_TextChanged" TabIndex="17" >00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender9" runat="server" 
                Enabled="True" TargetControlID="txtMedical_Adv" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
                                  <label class="col-md-4 form-group">Festival Advance :</label>
<div class="col-md-6 form-group">
     <asp:TextBox ID="txtFestival" runat="server" CssClass="form-control" AutoPostBack="True" 
                ontextchanged="txtFestival_TextChanged" TabIndex="18">00.00</asp:TextBox>
            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender10" runat="server" 
                Enabled="True" TargetControlID="txtFestival" FilterType="Numbers, Custom" ValidChars=".,">
            </cc1:FilteredTextBoxExtender>
</div>
                <label class="col-md-4 form-group">Personal Advance :</label>
          <div class="col-md-6 form-group">
                     <asp:TextBox ID="txtPersonal" runat="server" CssClass="form-control" AutoPostBack="True" 
                                ontextchanged="txtPersonal_TextChanged" TabIndex="19" >00.00</asp:TextBox>
                            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender11" runat="server" 
                                Enabled="True" TargetControlID="txtPersonal" FilterType="Numbers, Custom" ValidChars=".,">
                            </cc1:FilteredTextBoxExtender>
         </div>
  <label class="col-md-4 form-group">Vehicle Advance :</label>
          <div class="col-md-6 form-group">
                     <asp:TextBox ID="txtVehicle" runat="server" CssClass="form-control" AutoPostBack="True" 
                                ontextchanged="txtVehicle_TextChanged" TabIndex="20" >00.00</asp:TextBox>
                            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender12" runat="server" 
                                Enabled="True" TargetControlID="txtVehicle" FilterType="Numbers, Custom" ValidChars=".,">
                            </cc1:FilteredTextBoxExtender>
         </div>
                                  <label class="col-md-4 form-group">MISC Narration Advance :</label>
          <div class="col-md-6 form-group">
                     <asp:TextBox ID="txtMISC_Narration_Advance" runat="server" CssClass="form-control" AutoPostBack="True" 
                                ontextchanged="txtMISC_Narration_Advance_TextChanged" TabIndex="21" >00.00</asp:TextBox>
                            <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender13" runat="server" 
                                Enabled="True" TargetControlID="txtMISC_Narration_Advance" FilterType="Numbers, Custom" ValidChars=".,">
                            </cc1:FilteredTextBoxExtender>
         </div>    
                                  
                                   <label class="col-md-4 form-group">Total Deduction :</label>
                                   <div class="col-md-6 form-group">
                                  <asp:TextBox ID="txtotaldeduction" runat="server" CssClass="form-control" 
                SkinID="00.00" ReadOnly="True"></asp:TextBox>
                                  </div>
 


                                   <label class="col-md-4 form-group">Total :</label>
                                   <div class="col-md-6 form-group">
                                  <asp:TextBox ID="txtF_Total" runat="server" CssClass="form-control" 
                SkinID="00.00"></asp:TextBox>
                                  </div>
                                  <div class="col-md-12 form-group">
                                      <asp:Button ID="btnsave" runat="server"  Class=" btn btn-warning "  onclick="btnsave_Click" Text="Submit" 
                                        Width="80px" />&nbsp;
                                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update"  Class=" btn btn-warning "/>&nbsp;
                                    <asp:Button ID="btnrest" runat="server" Class="btn btn-info "  onclick="btnrest_Click" Text="Reset" 
                                        Width="80px" />
                                      <asp:Button ID="Button2" runat="server" BackColor="Yellow" BorderColor="Black" 
                                        Height="35px" onclick="Button2_Click" Text="View" Visible="False" 
                                        Width="80px" />
                                      <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                                      &nbsp;<asp:Label ID="Label6" runat="server"></asp:Label>
                                  </div>

                                  <div class="col-md-12 form-group">

                <asp:GridView ID="GridView1" runat="server" 
                AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Emp_id" 
                ForeColor="#333333" GridLines="None" 
                onrowdeleting="GridView1_RowDeleting" AllowPaging="True" 
                onpageindexchanging="GridView1_PageIndexChanging" PageSize="5" 
                Width="1000px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Basic" HeaderText="BASIC" DataFormatString="{0:n}" >
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="HRA" HeaderText="HRA"  DataFormatString="{0:n}">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Travel_Allowance" HeaderText="TA" 
                        DataFormatString="{0:n}" >
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Other_Allowances" 
                        HeaderText="OA" DataFormatString="{0:n}" >
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Bonus" HeaderText="BONUS" DataFormatString="{0:n}" >
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Mobile_Reimbursement" 
                        HeaderText="MR"  DataFormatString="{0:n}">
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Fixed_Allowances" HeaderText="FA" 
                        DataFormatString="{0:n}" >
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="Total_Salarry" HeaderText="TOTAL SALARY" 
                        DataFormatString="{0:n}" >
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:CommandField HeaderText="DELETE" ShowDeleteButton="True" />
                </Columns>
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            </asp:GridView>

                                  </div>
                                 
                                </asp:Panel>

                          </div>
                         <div class="col-md-12 form-group">
                             <asp:Panel ID="Panel2" runat="server" >
                                  <label class="col-md-4 form-group">Employee code</label>
                                  <div class="col-md-6 form-group">
                                      <asp:DropDownList ID="ddlemp" runat="server"  CssClass="form-control"
                                                onselectedindexchanged="ddlemp_SelectedIndexChanged"  
                                                 AutoPostBack="True">
                                            </asp:DropDownList>

                                  </div>
                                   <label class="col-md-4 form-group"> Month &amp; Year :</label>
                                   <div class="col-md-3 form-group">
                                       <asp:DropDownList ID="ddlmonth" runat="server" CssClass="form-control" >
                                                  <asp:ListItem Value="0">----Select----</asp:ListItem>
              
                                              </asp:DropDownList>

                                   </div>
                                 <div class="col-md-3 form-group">
                                     <asp:DropDownList ID="ddlyear" runat="server" AutoPostBack="True" 
                                                  CssClass="form-control" onselectedindexchanged="ddlyear_SelectedIndexChanged" >
                                              </asp:DropDownList>

                                 </div>
                                 <label class="col-md-4 form-group">Salary :</label>
                                 <div class="col-md-6 form-group">
                                      <asp:TextBox ID="txtsalary" runat="server" ReadOnly="True" 
                                                ontextchanged="txtsalary_TextChanged" CssClass="form-control"></asp:TextBox>

                                 </div>
                                 <label class="col-md-4 form-group">Total days of Month :</label>
                                 <div class="col-md-6 form-group">
                                     <asp:TextBox ID="TextBox4" runat="server"  CssClass="form-control"
                                                ontextchanged="TextBox4_TextChanged">00</asp:TextBox>                                      

                                 </div>
                                 <label class="col-md-4 form-group">Total Working Days :</label>
                                 <div class="col-md-6 form-group">
                                      <asp:TextBox ID="txttotalworking" runat="server" CssClass="form-control" 
                                                  AutoPostBack="True" ontextchanged="txttotalworking_TextChanged">00</asp:TextBox>
                                 </div>
                                  <label class="col-md-4 form-group">Worked for :</label>
                                 <div class="col-md-6 form-group">
                                     <asp:TextBox ID="txtWorkedfor" runat="server" CssClass="form-control" ReadOnly="True" 
                                                 ontextchanged="txtWorkedfor_TextChanged"></asp:TextBox>
                                      <asp:HiddenField ID="HiddenField1" runat="server" />
                                 </div>
                                 <label class="col-md-4 form-group">Total Leaves :</label>
                                 <div class="col-md-6 form-group">
                                     <asp:TextBox ID="TextBox5" runat="server"  CssClass="form-control"
                                                  ontextchanged="TextBox5_TextChanged">00</asp:TextBox>

                                 </div>
                                 <label class="col-md-4 form-group">Paid Leaves :</label>
                                 <div class="col-md-6 form-group">
                                     <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"  CssClass="form-control"
                                                  ontextchanged="TextBox1_TextChanged1" >00</asp:TextBox>

                                 </div>
                                 <label class="col-md-4 form-group">UnPaid  Leaves :</label>
                                 <div class="col-md-6 form-group">
                                    <asp:TextBox ID="txtbleaves" runat="server" AutoPostBack="True" CssClass="form-control"
                                                  ontextchanged="txtbleaves_TextChanged" ReadOnly="True" ></asp:TextBox>

                                 </div>

                                 <label class="col-md-4 form-group">Unpaid Leave price :</label>
                                 <div class="col-md-6 form-group">
                                      <asp:TextBox ID="txtlvesprice" runat="server" AutoPostBack="True" 
                                                CssClass="form-control" ontextchanged="txtlvesprice_TextChanged" ReadOnly="True" 
                                                ></asp:TextBox>
                                       <asp:HiddenField ID="HiddenField2" runat="server" />
                                 </div>

                                  <label class="col-md-4 form-group">Advance Taken :</label>
                                 <div class="col-md-6 form-group">
                                       <asp:TextBox ID="TextBox6" runat="server" AutoPostBack="True"  CssClass="form-control"
                                                  ontextchanged="TextBox6_TextChanged">00.00</asp:TextBox>

                                 </div>
                                 <label class="col-md-4 form-group">Advance Deduct :</label>
                                 <div class="col-md-6 form-group">
                                     <asp:HiddenField ID="HiddenField3" runat="server" Value="00.00" />
                                            <asp:TextBox ID="txtAdv" runat="server" AutoPostBack="True"  CssClass="form-control" 
                                                ontextchanged="txtAdv_TextChanged" >00.00</asp:TextBox>

                                 </div>
                                 <label class="col-md-4 form-group">Current Salary :</label>
                                 <div class="col-md-6 form-group">
                                       <asp:TextBox ID="txtspaid" runat="server" AutoPostBack="True" 
                                                  ontextchanged="txtspaid_TextChanged"   CssClass="form-control" >00.00</asp:TextBox>

                                 </div>
                                  <label class="col-md-4 form-group">Others :</label>
                                 <div class="col-md-6 form-group">
                                     <asp:TextBox ID="txtother" runat="server"  CssClass="form-control"  
                                                ontextchanged="txtother_TextChanged"  AutoPostBack="True">00.00</asp:TextBox>

                                 </div>
                                 <label class="col-md-4 form-group"> Previous Dues :</label>
                                 <div class="col-md-6 form-group">
                                      <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control">00.00</asp:TextBox>

                                 </div>

                                     <label class="col-md-4 form-group">Income Tax :</label>
                                      <div class="col-md-5 form-group">
                                                 <asp:TextBox ID="txtIncomeTax" runat="server" CssClass="form-control" AutoPostBack="True" 
                                                            ontextchanged="txtIncomeTax_TextChanged" >00</asp:TextBox>
                                                        <cc1:FilteredTextBoxExtender ID="FilteredTextBoxExtender14" runat="server" 
                                                            Enabled="True" TargetControlID="txtIncomeTax" FilterType="Numbers, Custom" ValidChars=".,">
                                                        </cc1:FilteredTextBoxExtender>
                                     </div>
                                 <div class="col-md-1">%</div>

                                 <label class="col-md-4 form-group"> Total :</label>
                                 <div class="col-md-6 form-group">
                                        <asp:TextBox ID="txt_total" runat="server" CssClass="form-control"></asp:TextBox>
                                      <asp:TextBox ID="txt_sub_tot_word" runat="server" Width="250px" Visible="False"></asp:TextBox>
                                 </div>
                                 <div class="col-md-12 form-group">
                                        <asp:Button ID="Button3" runat="server"  Class="btn btn-warning"  Text="Submit" 
                                                onclick="btnsubmit_Click"   /> &nbsp;
                                            <asp:Button ID="Button4" runat="server" Text="Update" onclick="Button4_Click" Class="btn btn-warning" />&nbsp;
                                            <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="View"  Class="btn btn-success"   />
                                            <asp:Button ID="Button8" runat="server" Class=" btn btn-info " onclick="Button8_Click" Text="Reset" />
                                      <asp:Label ID="Label20" runat="server" CssClass="errorlbls"></asp:Label>
                                            <asp:Label ID="lblmsg" runat="server" CssClass="errorlbls"></asp:Label>
                                     <asp:HiddenField ID="HiddenField4" runat="server" />
                                 </div>


                                  

                                        </asp:Panel>
                         </div>
                        <div class="col-md-12 form-group">
                            <asp:Panel ID="Panel3" runat="server">

        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" 
            GridLines="None" onrowdeleting="GridView2_RowDeleting" Width="100%" 
            AllowPaging="True" DataKeyNames="Emp_id" 
            onpageindexchanging="GridView2_PageIndexChanging" PageSize="5">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Emp_id" HeaderText="Name" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Salary" HeaderText="Salary" 
                    DataFormatString="{0:n}" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Salary_month" HeaderText="Month" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="total_working" HeaderText="Total Working" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="working_for" HeaderText="Working For" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Adv" HeaderText="Adv" DataFormatString="{0:n}" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="other" HeaderText="Other" DataFormatString="{0:n}" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="leavs_price" HeaderText="Leaves" 
                    DataFormatString="{0:n}" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:BoundField DataField="Sub_total" HeaderText="Sub Total" 
                    DataFormatString="{0:n}" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
                </asp:BoundField>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        </asp:GridView>

                             </asp:Panel>

                        </div>
                         <div class="col-md-12 form-group">
                             <asp:Panel ID="Panel4" runat="server" Visible="false" >
                              
                                 <div class="col-md-12 form-group">
                                     <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
                   CellPadding="4" ForeColor="#333333" GridLines="None" Width="400px">
                   <AlternatingRowStyle BackColor="White" />
                   <Columns>
                       <asp:BoundField DataField="Emp_Id" HeaderText="ID">
                       <HeaderStyle HorizontalAlign="Center" />
                       <ItemStyle HorizontalAlign="Center" />
                       </asp:BoundField>
                       <asp:BoundField DataField="Advance" HeaderText="Advance" 
                           DataFormatString="{0:n}">
                       <HeaderStyle HorizontalAlign="Right" />
                       <ItemStyle HorizontalAlign="Right" />
                       </asp:BoundField>
                       <asp:BoundField DataField="Remarks" HeaderText="Remarks">
                       <HeaderStyle HorizontalAlign="Center" />
                       <ItemStyle HorizontalAlign="Center" />
                       </asp:BoundField>
                   </Columns>
                   <EditRowStyle BackColor="#2461BF" />
                   <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                   <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                   <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                   <RowStyle BackColor="#EFF3FB" />
                   <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                   <SortedAscendingCellStyle BackColor="#F5F7FB" />
                   <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                   <SortedDescendingCellStyle BackColor="#E9EBEF" />
                   <SortedDescendingHeaderStyle BackColor="#4870BE" />
               </asp:GridView>
                                 </div>

                                 <label class="col-md-4 form-group">Employee code :</label>
                                 <div class="col-md-6 form-group">
                                      <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" 
                      AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                      <asp:ListItem Value="0">--Select--</asp:ListItem>
                  </asp:DropDownList>

                                 </div>
                               

                          

                                  <label class="col-md-4 form-group">Total Advance :</label>
                                 <div class="col-md-6 form-group">
                                     <asp:TextBox ID="txtadv1" runat="server" CssClass="form-control">00.00</asp:TextBox>
                  <cc1:FilteredTextBoxExtender ID="txtadv1_FilteredTextBoxExtender" 
                      runat="server" Enabled="True" TargetControlID="txtadv1" FilterType="Numbers, Custom" ValidChars=".,">
                  </cc1:FilteredTextBoxExtender>

                                 </div>

                                  <label class="col-md-4 form-group">Remarks :</label>
                                 <div class="col-md-6 form-group">
                                    <asp:TextBox ID="txtremark1" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>

                                 </div>
                                  <label class="col-md-4 form-group">Date :</label>
                                 <div class="col-md-6 form-group">
                                      <asp:TextBox ID="txtcdt" runat="server" CssClass="form-control"></asp:TextBox>
                    <cc1:CalendarExtender ID="txtcdt_CalendarExtender" runat="server" 
                        Enabled="True" Format="dd/MM/yyyy" 
                        TargetControlID="txtcdt" PopupPosition="TopRight">
                    </cc1:CalendarExtender>
                    

                                 </div>
                                 <div class="col-md-12 form-group">
                                      <asp:Button ID="Button6" runat="server" BackColor="Yellow" BorderColor="Black" 
                        Height="35px" onclick="Button6_Click" Text="Submit" Width="80px" />&nbsp;
                    <asp:Button ID="btnrestt" runat="server" BackColor="Yellow" BorderColor="Black" 
                        CssClass="btn" Height="35px" onclick="btnrestt_Click" Text="Reset" 
                        Width="80px" />
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    <asp:Label ID="msg" runat="server"></asp:Label>

                                 </div>       

        </asp:Panel>

                         </div>

          <div class="col-md-12 form-group">
         <asp:Panel ID="Panel5" runat="server">
              <label class="col-md-4 form-group">Employee code :</label>
                                 <div class="col-md-6 form-group">
                                      <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                                         onselectedindexchanged="DropDownList2_SelectedIndexChanged" CssClass="form-control">
                                         <asp:ListItem Value="--Select--">--Select--</asp:ListItem>
                                     </asp:DropDownList>

                                 </div>
             <label class="col-md-4 form-group"> Salary :</label>
                                 <div class="col-md-6 form-group">
                            <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control">00.00</asp:TextBox>
        
                             <cc1:FilteredTextBoxExtender ID="TextBox7_FilteredTextBoxExtender" 
                                 runat="server" Enabled="True" TargetControlID="TextBox7"   FilterType="Numbers, Custom" ValidChars=".,">
                             </cc1:FilteredTextBoxExtender>

                                 </div>

              <label class="col-md-4 form-group"> Payment Salary :</label>
                                 <div class="col-md-6 form-group">
                                     <asp:TextBox ID="TextBox8" runat="server" AutoPostBack="True" 
                        ontextchanged="TextBox8_TextChanged" CssClass="form-control">00.00</asp:TextBox>
                    <cc1:FilteredTextBoxExtender ID="TextBox8_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" TargetControlID="TextBox8"   FilterType="Numbers, Custom" ValidChars=".,">
                    </cc1:FilteredTextBoxExtender>

                                 </div>
              <label class="col-md-4 form-group">Due :</label>
                                 <div class="col-md-6 form-group">
                                     <asp:TextBox ID="TextBox9" runat="server"  
                        ontextchanged="TextBox9_TextChanged" CssClass="form-control">00.00</asp:TextBox>
                    <cc1:FilteredTextBoxExtender ID="TextBox9_FilteredTextBoxExtender" 
                        runat="server" Enabled="True" TargetControlID="TextBox9"   FilterType="Numbers, Custom" ValidChars=".,">
                    </cc1:FilteredTextBoxExtender>

                                 </div>
             <label class="col-md-4 form-group">Date :</label>
                                 <div class="col-md-6 form-group">
                                     <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control"></asp:TextBox>
                  
                    <cc1:CalendarExtender ID="TextBox10_CalendarExtender" runat="server" 
                        Enabled="True" Format="dd/MM/yyyy"  
                        TargetControlID="TextBox10" PopupPosition="TopRight">
                    </cc1:CalendarExtender>
                   

                                 </div>
             <div class="col-md-12 form-group">
                 <asp:Button ID="Button7" runat="server" BackColor="Yellow" BorderColor="Black" 
                        Height="35px" onclick="Button7_Click" Text="Submit" Width="80px" />
                      &nbsp;<asp:Button ID="Button9" runat="server" BackColor="Yellow" 
                        BorderColor="Black" Height="35px" onclick="Button9_Click" Text="Reset" 
                        Width="80px" />
                    &nbsp;&nbsp; &nbsp; &nbsp;<asp:Label ID="Label32" runat="server"></asp:Label>

             </div>

        

        </asp:Panel>

                         </div>

                         </div>

                     </div>
                </div>

            </div>

        </div>

    </div>

</asp:Content>