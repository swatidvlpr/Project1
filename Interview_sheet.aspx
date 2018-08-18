<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Interview_sheet.aspx.cs" Inherits="Hr_Interview_sheet" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="page-wrapper">
             <div class="main-page">
                       <div id="form1" class="forms validation">
                         <div class="form-grids row widget-shadow" data-example-id="basic-forms">
                           <div class="form-title">
                               <h4>Interview Sheet</h4>
                           </div>
                              <div class="form-body" id="form">
                                <div class="col-md-6 form-group">
                                        <label >Name of applicant</label>
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Width="402px"
                                            TextMode="SingleLine"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ErrorMessage="Enter your name" ControlToValidate="TextBox1" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>

                                 <div class="col-md-6 form-group">
                                        <label >Position applied for</label>
                                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" Width="402px" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                            ErrorMessage="Enter your position" ControlToValidate="TextBox2" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 form-group">
                                        <label >Center</label>
                                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" Width="402px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                            ErrorMessage="Enter your center" ControlToValidate="TextBox3" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>
                                     <div class="col-md-6 form-group">
                                        <label >Date of interview</label>
                                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" Width="402px"
                                             TextMode="SingleLine"></asp:TextBox>
                                         <cc1:CalendarExtender ID="TextBox4_CalendarExtender" runat="server" 
                                             Enabled="True" TargetControlID="TextBox4" PopupPosition="TopRight">
                                         </cc1:CalendarExtender>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                             ErrorMessage="Enter interview date" ControlToValidate="TextBox4" 
                                             ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>
                                 <div class="col-md-6 form-group">
                                        <label >Basic qualification:</label>                                  
                                
                                     <asp:RadioButtonList ID="RadioButtonList6" runat="server" RepeatDirection="Horizontal">
                                           <asp:ListItem>Post Gratuate</asp:ListItem>
                                         <asp:ListItem>Gratuate</asp:ListItem>
                                         <asp:ListItem>Under Gratuate</asp:ListItem>


                                     </asp:RadioButtonList>
                                        <br />
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" 
                                            ControlToValidate="RadioButtonList6" ErrorMessage="Enter qualification" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                 </div>
                                 <div class="col-md-6 form-group">
                                        <label >Professional qualification:</label>
                                     <asp:DropDownList ID="DropDownList1" runat="server">
                                         <asp:ListItem>Select</asp:ListItem>
                                         <asp:ListItem>MBA</asp:ListItem>
                                         <asp:ListItem>BE</asp:ListItem>
                                         <asp:ListItem>CA</asp:ListItem>
                                         <asp:ListItem>ICWAI</asp:ListItem>
                                         <asp:ListItem>DIPLOMA</asp:ListItem>
                                         <asp:ListItem>ITI</asp:ListItem>
                                         <asp:ListItem>PGDCA</asp:ListItem>
                                     </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                             ErrorMessage="Enter proffesional qualification" 
                                            ControlToValidate="DropDownList1" ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>
                                   <div class="col-md-6 form-group">
                                        <label >Experience details:</label>
                                       <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                                           <asp:ListItem>Fresher</asp:ListItem>
                                           <asp:ListItem>Experience</asp:ListItem>
                                       </asp:RadioButtonList>
                                       <%--<asp:Panel ID="Panel1" runat="server" CssClass="form-control">
                                           
                                               <div class="col-md-6 form-group">
                                                  <label >Last Orgation name :</label> 
                                                   <asp:TextBox ID="txtlnm" runat="server"></asp:TextBox>
                                               </div>
                                               <div class="col-md-6 form-group">
                                                  <label >Designation :</label> 
                                                   <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                                               </div>
                                               <div class="col-md-6 form-group">
                                                  <label >Total Experince :</label> 
                                                   <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                                               </div>
                                                <div class="col-md-6 form-group">
                                                  <label >Skill :</label> 
                                                   <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                                               </div>
                                          

                                       </asp:Panel>--%>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                                             ErrorMessage="Enter your experience" ControlToValidate="RadioButtonList1" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                       
                                </div>
                                <div class="col-md-6 form-group">
                                        <label >Communication skill:</label>
                                    <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal">
                                     <asp:ListItem>Excellent</asp:ListItem>
                                           <asp:ListItem>Good</asp:ListItem>
                                            <asp:ListItem>Average</asp:ListItem>
                                           <asp:ListItem>Poor</asp:ListItem>
                                    </asp:RadioButtonList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                                            ErrorMessage="Enter communication skill" 
                                            ControlToValidate="RadioButtonList2" ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-md-6 form-group">
                                        <label >Personality:</label>
                                   <asp:RadioButtonList ID="RadioButtonList3" runat="server" RepeatDirection="Horizontal">
                                     <asp:ListItem>Excellent</asp:ListItem>
                                           <asp:ListItem>Good</asp:ListItem>
                                            <asp:ListItem>Average</asp:ListItem>
                                           <asp:ListItem>Poor</asp:ListItem>
                                    </asp:RadioButtonList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                                            ErrorMessage="Enter personality" ControlToValidate="RadioButtonList3" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>

                                <div class="col-md-6 form-group">
                              
                                        <label >Father's Occupation:</label>
                                    <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                                            ErrorMessage="Enter father's occupation" ControlToValidate="TextBox5" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 form-group">
                                        <label >Mother's Occupation:</label>
                                    <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                                            ErrorMessage="Enter mother's occupation" ControlToValidate="TextBox6" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 form-group">
                                        <label >Brother's Occupation:</label>
                                    <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                                            ErrorMessage="Enter brother's occupation" ControlToValidate="TextBox7" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 form-group">
                                        <label >Sister's Occupation:</label>
                                    <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                                            ErrorMessage="Enter sister's occupation" ControlToValidate="TextBox8" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>
                                 <div class="col-md-6 form-group">
                                        <label >Dependants:</label>
                                       <asp:RadioButtonList ID="RadioButtonList4" runat="server" RepeatDirection="Vertical">
                                           <asp:ListItem>Yes</asp:ListItem>
                                           <asp:ListItem>No</asp:ListItem>
                                       </asp:RadioButtonList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                                             ErrorMessage="Enter your dependants" ControlToValidate="RadioButtonList4" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 form-group">
                                        <label >Does referred by our staff:</label>
                                       <asp:RadioButtonList ID="RadioButtonList5" runat="server" RepeatDirection="Horizontal">
                                           <asp:ListItem>Yes</asp:ListItem>
                                           <asp:ListItem>No</asp:ListItem>
                                       </asp:RadioButtonList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" 
                                             ErrorMessage="Enter your reference" ControlToValidate="RadioButtonList5" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                </div>
                                <div class="col-md-6 form-group">
                                        <label >Name & designation of referee:</label><br />
                                        <label >Unit:</label>
                                    <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" 
                                            ErrorMessage="Enter unit" ControlToValidate="TextBox9" ValidationGroup="a"></asp:RequiredFieldValidator>

                                 </div>
                                 <div class="col-md-6 form-group">
                                    <label >Center:</label>
                                    <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control" ></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" 
                                            ErrorMessage="Enter center" ControlToValidate="TextBox10" 
                                         ValidationGroup="a"></asp:RequiredFieldValidator>
                                     
                                </div>
                                 <div class="col-md-6 form-group">
                                    <label >Salary particulars:</label>
                                    <asp:TextBox ID="TextBox11" runat="server" CssClass="form-control" >00.00</asp:TextBox>
                                     <cc1:FilteredTextBoxExtender ID="TextBox11_FilteredTextBoxExtender" 
                                         runat="server" Enabled="True" FilterType="Numbers,Custom" InvalidChars=".," TargetControlID="TextBox11">
                                     </cc1:FilteredTextBoxExtender>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" 
                                            ErrorMessage="Enter salary particulars" ControlToValidate="TextBox11" 
                                         ValidationGroup="a"></asp:RequiredFieldValidator>
                                     
                                </div>
                                 <div class="col-md-6 form-group">
                                    <label >Salary drawing & expectation:</label>
                                    <asp:TextBox ID="TextBox12" runat="server" CssClass="form-control" >00.00</asp:TextBox>
                                     <cc1:FilteredTextBoxExtender ID="TextBox12_FilteredTextBoxExtender" 
                                         runat="server" Enabled="True" FilterType="Numbers,Custom" InvalidChars=".," TargetControlID="TextBox12">
                                     </cc1:FilteredTextBoxExtender>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" 
                                            ErrorMessage="Enter expectation" ControlToValidate="TextBox12" 
                                         ValidationGroup="a"></asp:RequiredFieldValidator>
                                     
                                </div>
                                <div class="col-md-6 form-group">
                                    <label >Salary offered:</label>
                                    <asp:TextBox ID="TextBox13" runat="server" CssClass="form-control" >00.00</asp:TextBox>
                                    <cc1:FilteredTextBoxExtender ID="TextBox13_FilteredTextBoxExtender" 
                                        runat="server" Enabled="True" FilterType="Numbers,Custom" InvalidChars=".," 
                                        TargetControlID="TextBox13">
                                    </cc1:FilteredTextBoxExtender>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                            ErrorMessage="Enter salary offered" ControlToValidate="TextBox13" 
                                        ValidationGroup="a"></asp:RequiredFieldValidator>
                                     
                                </div>
                                    <div class="col-md-6 form-group">
                                    <label >Date of joining:</label>
                                    <asp:TextBox ID="TextBox14" runat="server" CssClass="form-control" ></asp:TextBox>
                                        <cc1:CalendarExtender ID="TextBox13_CalendarExtender" runat="server" 
                                            Enabled="True" TargetControlID="TextBox14" PopupPosition="TopRight">
                                        </cc1:CalendarExtender>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" 
                                            ErrorMessage="Enter date of joining" ControlToValidate="TextBox15" 
                                            ValidationGroup="a"></asp:RequiredFieldValidator>
                                     
                                </div>
                                 <div class="col-md-6 form-group">
                                    <label >Overall comments about the applicant:</label>
                                    <asp:TextBox ID="TextBox15" runat="server" CssClass="form-control" 
                                         TextMode="MultiLine"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" 
                                            ErrorMessage="Enter center" ControlToValidate="TextBox15" 
                                         ValidationGroup="a"></asp:RequiredFieldValidator>
                                     
                                </div>


                            <div class="col-md-6 form-group">
                                 <asp:Button ID="Button1" runat="server" Text="Submit" 
                                     Class=" btn btn-warning " onclick="Button1_Click" ValidationGroup="a" />
                                  &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " 
                                     Text="reset" onclick="Button2_Click" ValidationGroup="b" />
                                     &nbsp;
          
                                <br />
                                 <asp:Label ID="Label1" runat="server"></asp:Label>
                                <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>  
                              </div>
                        </div>
                  </div>
          </div>
     </div>
 </div>
                              

</asp:Content>

