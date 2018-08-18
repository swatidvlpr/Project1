<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Employee_Reg.aspx.cs" Inherits="Hr_Employee_Reg"  %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  
    <style type="text/css">
         .header_menu_bg 
        {
            background:url(icon/Buttonmenu.JPG);
            padding:10px 8px;
            color:White;
       
        }
        .ali_wid 
        {
            background:#fFf;
            padding:6px 24px;
            color:#333;
       
        }

    </style>

    <script language=javascript>
        function chkvalidation() {
           // alert("kamal");
            //if (document.getElementById("submit").value == "SUBMIT") {
                
            if (document.getElementById("ContentPlaceHolder1_ddlcompany").selectedIndex == 0) {
                alert("Select the company");
                document.getElementById("ContentPlaceHolder1_ddlcompany").focus();
                return false
            }

            if (document.getElementById("ContentPlaceHolder1_ddllocation").selectedIndex == 0) {
                alert("Select the location");
                document.getElementById("ContentPlaceHolder1_ddllocation").focus();
                return false
            }

            if (document.getElementById("ContentPlaceHolder1_ddlCategory").selectedIndex == 0) {
                alert("Select the category");
                document.getElementById("ContentPlaceHolder1_ddlCategory").focus();
                return false
            }

                if (document.getElementById('<%=txtname.ClientID%>').value == "") {
                    alert("Enter the Name.");
                    document.getElementById('<%=txtname.ClientID%>').focus();
                    return false
                }

                if (document.getElementById("ContentPlaceHolder1_DropDownList2").selectedIndex == 0) {
                    alert("Select the gender");
                    document.getElementById("ContentPlaceHolder1_DropDownList2").focus();
                    return false
                }


                if (document.getElementById("ContentPlaceHolder1_DropDownList3").selectedIndex == 0) {
                    alert("Select the marital status");
                    document.getElementById("ContentPlaceHolder1_DropDownList3").focus();
                    return false
                }
                                
                if (document.getElementById("ContentPlaceHolder1_TextBox27").value == "") {
                    alert("Enter The DOJ");
                    document.getElementById("ContentPlaceHolder1_TextBox27").focus();
                    return false
                }



            //}
        }
</script>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      
    <div id="page-wrapper">
			<div class="main-page">
                <div id="form1" class="forms validation"> 
              
               <div class="form-grids row widget-shadow" data-example-id="basic-forms">
						<div class="form-title">
							<h4>Employee Form :</h4>
						</div>
                        <div class="form-body" id="form">
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                                </asp:ScriptManager>
							  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>

            
                           <%--<asp:TextBox ID="TextBox2" runat="server" Class="form-control" placeholder="Marital status" data-error="Please enter marital status" ></asp:TextBox>--%>
                               <div class="col-md-6 form-group">
                                        <label >Company Name</label> 
                                 <asp:DropDownList ID="ddlcompany" runat="server" Class="form-control" OnSelectedIndexChanged="ddlcompany_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                   </div>
                                    <div class="col-md-6 form-group">
                                    <label >Location Name</label>
                                     <asp:DropDownList ID="ddllocation" runat="server" CssClass="form-control" OnDataBound="ddllocation_DataBound" ValidationGroup="a" AutoPostBack="True" OnSelectedIndexChanged="ddllocation_SelectedIndexChanged"></asp:DropDownList>
                                        <%--<asp:TextBox ID="TextBox3" runat="server" Class="form-control" placeholder="Company Name" data-error="Please enter company name" ></asp:TextBox>--%>
                                </div>
                             <div class="col-md-6 form-group">
                                    <label >Category Name</label>
                                     <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control" ValidationGroup="a" AutoPostBack="True" OnDataBound="ddlCategory_DataBound" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged" ></asp:DropDownList>
                                        <%--<asp:TextBox ID="TextBox3" runat="server" Class="form-control" placeholder="Company Name" data-error="Please enter company name" ></asp:TextBox>--%>
                                </div>
                                     </ContentTemplate>

							  </asp:UpdatePanel>

                                                                  
                                  <div class="col-md-6 form-group">
                                        <label >Name</label> 
                                      <asp:TextBox ID="txtname" runat="server" Class="form-control" placeholder="Name" data-error="Please enter name" AutoPostBack="True" OnTextChanged="txtname_TextChanged" ></asp:TextBox> 
                                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Enter the name" ControlToValidate="txtname" ValidationGroup="a">.</asp:RequiredFieldValidator>
                                        <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" runat="server" Enabled="True" TargetControlID="RequiredFieldValidator1">
                                        </cc1:ValidatorCalloutExtender>
                                  </div>
                       
                            <div class="col-md-6 form-group">
                                       <label >Employee code</label>
                                       <asp:TextBox ID="txtempcode" runat="server" Class="form-control" placeholder="Employee code" data-error="Please enter employee code"  ValidationGroup="a" OnTextChanged="txtempcode_TextChanged" ReadOnly="True"></asp:TextBox>
                                <asp:HiddenField ID="HiddenField2" runat="server" />
                            </div>    
                                    <div class="col-md-6 form-group">
                                       <label >Gender</label>
                                        <asp:DropDownList ID="DropDownList2" runat="server" Class="form-control">
                                            <asp:ListItem Value="0">Select</asp:ListItem>
                                            <asp:ListItem>Male</asp:ListItem>
                                            <asp:ListItem>Female</asp:ListItem>
                                        </asp:DropDownList>
                                       <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Select gender" ControlToValidate="DropDownList2" InitialValue="0" ValidationGroup="a"></asp:RequiredFieldValidator>

                                        <cc1:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" runat="server" Enabled="True" TargetControlID="RequiredFieldValidator2">
                                        </cc1:ValidatorCalloutExtender>

                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                        <label >Marital Status</label>
                                       <asp:DropDownList ID="DropDownList3" Class="form-control" runat="server">
                                           <asp:ListItem Value="0">Select</asp:ListItem>
                                           <asp:ListItem>Married</asp:ListItem>
                                           <asp:ListItem>Unmarried</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select marital status" ControlToValidate="DropDownList3" InitialValue="0" ValidationGroup="a"></asp:RequiredFieldValidator>
                                   </div>
                               <div class="col-md-6 form-group">
                                       <label >Blooad group</label>
                                   <asp:DropDownList ID="DropDownList4" runat="server" Class="form-control">
                                       <asp:ListItem Value="0">Select</asp:ListItem>
                                       <asp:ListItem>O−</asp:ListItem>
                                       <asp:ListItem>O+</asp:ListItem>
                                       <asp:ListItem>A−</asp:ListItem>
                                       <asp:ListItem>A+</asp:ListItem>
                                       <asp:ListItem>B−</asp:ListItem>
                                       <asp:ListItem>B+</asp:ListItem>
                                       <asp:ListItem>AB−</asp:ListItem>
                                       <asp:ListItem>AB+</asp:ListItem>
                                       </asp:DropDownList>
                                       <%--<div class="form-body">--%>

                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                        <label >Caste</label>
                                       <asp:DropDownList ID="DropDownList5" runat="server" Class="form-control">
                                           <asp:ListItem Value="0">Select</asp:ListItem>
                                           <asp:ListItem>Gen</asp:ListItem>
                                           <asp:ListItem>SEBC</asp:ListItem>
                                           <asp:ListItem>SE</asp:ListItem>
                                           <asp:ListItem>ST</asp:ListItem>
                                        </asp:DropDownList>
                                        <%#GridView1.Rows.Count + 1%> 
                                   </div>

                                <div class="col-md-6 form-group">
                                       <label >Urban Rural</label>
                                       <asp:TextBox ID="TextBox5" runat="server" Class="form-control" placeholder="Urban Rural" data-error="Please enter company name" ></asp:TextBox>
                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                        <label >Address</label> 
                                      <asp:TextBox ID="TextBox6" runat="server" Class="form-control" placeholder="Addres" data-error="Please enter company name" TextMode="MultiLine"></asp:TextBox> 
                                   </div>
                                <div class="col-md-6 form-group">
                                       <label >Pincode</label>
                                       <asp:TextBox ID="TextBox7" runat="server" Class="form-control" placeholder="Pincode" data-error="Please enter company name" ></asp:TextBox>
                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                        <label >Mobile no</label> 
                                      <asp:TextBox ID="TextBox8" runat="server" Class="form-control" placeholder="Mobile no" data-error="Please enter company name" ></asp:TextBox> 
                                   </div>

                                 <div class="col-md-6 form-group">
                                       <label >Alternate mobile</label>
                                       <asp:TextBox ID="TextBox9" runat="server" Class="form-control" placeholder="Alternate mobile" data-error="Please enter company name" ></asp:TextBox>
                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                        <label >Father name</label> 
                                      <asp:TextBox ID="TextBox10" runat="server" Class="form-control" placeholder="Father name" data-error="Please enter company name" ></asp:TextBox> 
                                   </div>

                                 <div class="col-md-6 form-group">
                                       <label >Mother name</label>
                                       <asp:TextBox ID="TextBox11" runat="server" Class="form-control" placeholder="Mother name" data-error="Please enter company name" ></asp:TextBox>
                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                        <label >Father occupation</label> 
                                      <asp:TextBox ID="TextBox12" runat="server" Class="form-control" placeholder="Father occupation" data-error="Please enter company name" ></asp:TextBox> 
                                   </div>

                               <div class="col-md-6 form-group">
                                       <label >Email id</label>
                                       <asp:TextBox ID="TextBox13" runat="server" Class="form-control" placeholder="Email id" data-error="Please enter company name" ></asp:TextBox>
                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                        <label >DOB</label> 
                                      <asp:TextBox ID="TextBox14" runat="server" Class="form-control" placeholder="DOB" data-error="Please enter company name" ></asp:TextBox> 
                                        <cc1:CalendarExtender ID="TextBox14_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox14" PopupPosition="TopRight">
                                        </cc1:CalendarExtender>
                                   </div>

                              
                               <div class="col-md-6 form-group">
                                       <label >Religion</label>
                                   <asp:DropDownList ID="DropDownList6" runat="server" Class="form-control">
                                       <asp:ListItem Value="0">Select</asp:ListItem>
                                       <asp:ListItem Value="Hinduism">Hinduism</asp:ListItem>
                                       <asp:ListItem Value="Christianity">Christianity</asp:ListItem>
                                       <asp:ListItem Value="Islam">Islam</asp:ListItem>
                                       <asp:ListItem Value="Hinduism">Hinduism</asp:ListItem>
                                       <asp:ListItem Value="Buddhism">Buddhism</asp:ListItem>
                                       </asp:DropDownList>
                                       <%-- </div>--%>
                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                        <label >Phone no</label> 
                                      <asp:TextBox ID="TextBox18" runat="server" Class="form-control" placeholder="Phone no" data-error="Please enter company name" ></asp:TextBox> 
                                   </div>


                               <div class="col-md-6 form-group">
                                       <label >Higher qualification</label>
                                       <asp:TextBox ID="TextBox15" runat="server" Class="form-control" placeholder="Higher qualification" data-error="Please enter company name" ></asp:TextBox>
                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                        <label >Post applied for</label> 
                                      <asp:TextBox ID="TextBox16" runat="server" Class="form-control" placeholder="Post applied for" data-error="Please enter company name" ></asp:TextBox> 
                                   </div>

                                    <div class="col-md-6 form-group">
                                       <label >Reference</label>
                                       <asp:TextBox ID="TextBox21" runat="server" Class="form-control" placeholder="Referenc" data-error="Please enter company name" ></asp:TextBox>
                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                        <label >Final Intv Date</label> 
                                      <asp:TextBox ID="TextBox22" runat="server" CssClass="form-control" placeholder="Final intv date" data-error="Please enter company name" OnTextChanged="TextBox22_TextChanged" ></asp:TextBox> 
                                        <cc1:CalendarExtender ID="TextBox22_CalendarExtender" runat="server" Enabled="True" PopupPosition="TopRight" TargetControlID="TextBox22">
                                        </cc1:CalendarExtender>
                                   </div>

                               
                                <div class="col-md-6 form-group">
                                       <label >Interviewer</label>
                                       <asp:TextBox ID="TextBox25" runat="server" Class="form-control" placeholder="Company Name" data-error="Please enter company name" ></asp:TextBox>
                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                        <label >Expected Salary</label> 
                                      <asp:TextBox ID="TextBox26" runat="server" Class="form-control" placeholder="Expected salary" data-error="Please enter company name" >00.00</asp:TextBox> 
                                   </div>
                             
                                   <div class="col-md-6 form-group">
                                        <label >Department Name</label> 
                                       <asp:DropDownList ID="ddldepartment" runat="server" Class="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddldepartment_SelectedIndexChanged"></asp:DropDownList>
                                   </div>
                            <div class="col-md-6 form-group">
                                        <label >Designation Name</label> 
                                       <asp:DropDownList ID="ddlDesignation" runat="server" Class="form-control" OnDataBound="ddlDesignation_DataBound"></asp:DropDownList>
                                   </div>
                               <div class="col-md-6 form-group">
                                       <label >DOJ</label>
                                       <asp:TextBox ID="TextBox27" runat="server" Class="form-control" placeholder="date" data-error="Please enter company name"></asp:TextBox>
                                       <cc1:CalendarExtender ID="TextBox27_CalendarExtender" runat="server" Enabled="True" PopupPosition="TopRight" TargetControlID="TextBox27">
                                       </cc1:CalendarExtender>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Enter the DOJ" ControlToValidate="TextBox27" ValidationGroup="a"></asp:RequiredFieldValidator>

                                   </div>                                   
                                   <div class="col-md-6 form-group">
                                    
                                   </div>
                            <div class="col-md-12 form-group"> 

                                <div class="form-title">
							<h4>Attachement File :</h4>
						        </div>

                            </div>
                                <%--<div class="form-body">--%>
                                     <div class="col-md-4 form-group">
                                          <label >File Name</label>
                                         <asp:DropDownList ID="DropDownList1" CssClass="form-control" runat="server">
                                            <asp:ListItem>Select</asp:ListItem>
                                            <asp:ListItem>Pan card</asp:ListItem>
                                            <asp:ListItem>Resume</asp:ListItem>
                                            <asp:ListItem>Addharcard</asp:ListItem>
                                            <asp:ListItem>DL Cartificate</asp:ListItem>
                                            <asp:ListItem>BLOOD Cartificate</asp:ListItem>
                                        </asp:DropDownList>
                                     </div>
                                    <div class="col-md-6 form-group">
                                        <label >Attach File</label>
                                         <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                                        <asp:HiddenField ID="HiddenField1" runat="server" />
                                         
                                     </div>
                                    <div class="col-md-6 form-group">
                                        <asp:Button ID="Button2" runat="server" Text="Add"  Class="btn-dark" OnClick="Button2_Click"/>

                                    </div>
                                   

                                    <div class="col-md-12 form-group">
                                         <div class="col-md-12 grid-margin">
                 <div class="table-responsive" >
<table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" >
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    onrowdeleting="GridView1_RowDeleting" 
                    ShowFooter="True" 
                    Width="100%" DataKeyNames="Emp_id">
                    <Columns>
                        <asp:TemplateField ControlStyle-CssClass="header_menu_bg" HeaderText="SN">
                            <ItemTemplate>
                          
                                <%#GridView1.Rows.Count + 1%>
                               
                            </ItemTemplate>
                            <ControlStyle CssClass="header_menu_bg" />
                            <FooterStyle CssClass="ali_wid" />
                            <HeaderStyle CssClass="header_menu_bg" ForeColor="White" 
                                HorizontalAlign="Center" />
                            <ItemStyle CssClass="ali_wid" HorizontalAlign="Left" />
                        </asp:TemplateField>

                        <asp:BoundField DataField="Attachmentfilename" HeaderText="File Name">
                        <FooterStyle CssClass="ali_wid" />
                        <HeaderStyle CssClass="header_menu_bg" HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Left" CssClass="ali_wid" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Attach_file" HeaderText="Attach file">
                        <HeaderStyle CssClass="header_menu_bg" HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Left" />
                        </asp:BoundField>

                        <asp:CommandField HeaderText="Delete" ShowDeleteButton="True">
                        <FooterStyle CssClass="ali_wid" />
                        <HeaderStyle CssClass="header_menu_bg" HorizontalAlign="Center" />
                        <ItemStyle HorizontalAlign="Left" CssClass="ali_wid" />
                        </asp:CommandField>
                    </Columns>
                </asp:GridView>
    </table>
                     </div>
</div>
                             


                                    </div>
                               <%-- </div>--%>


                           
                            <div class="col-md-6 form-group">
                                <label >Photo</label>
                                       <asp:FileUpload ID="FileUpload2" Class="form-control" runat="server" />
                                <asp:Image ID="Image1" runat="server" Width="100px" Height="100px" />
                            </div>
                            
                            <div class="col-md-6 form-group">


                                


                            </div>
                             <div class="col-md-12 form-group">
                                    <asp:Button ID="submit" runat="server" Class=" btn btn-warning " Text="Submit" OnClick="submit_Click" ValidationGroup="a" OnClientClick="return chkvalidation()" />
                                 &nbsp;<asp:Button ID="Button1" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button1_Click" />
                               </div>
                             <div class="col-md-12 form-group">
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                   
                                    
                                   </div>
                          
                                
							
						</div>
                        
                        </div>
				

              
            



             </div>

    </div>

        </div>
    
</asp:Content>

