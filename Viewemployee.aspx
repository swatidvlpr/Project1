<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Viewemployee.aspx.cs" Inherits="Hr_Viewemployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div id="page-wrapper">
			<div class="main-page">
                <div id="form1" class="forms validation">
                     <div class="form-grids row widget-shadow" data-example-id="basic-forms">
                         <div class="form-title">
							<h4>View Employee:</h4>
						</div>
                           <div class="form-body" id="form">


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
                               <div class="col-md-6 form-group">
                                       <label >Month</label>                                      
                                    <asp:DropDownList ID="DropDownList1" runat="server" Class="form-control">
                                       <asp:ListItem Value="0">---Select Month----</asp:ListItem>
                                    <asp:ListItem Value="01">Jan</asp:ListItem>
                                    <asp:ListItem Value="02">Feb</asp:ListItem>
                                    <asp:ListItem Value="03">Mar</asp:ListItem>
                                    <asp:ListItem Value="04">Apr</asp:ListItem>
                                    <asp:ListItem Value="05">May</asp:ListItem>
                                   <asp:ListItem Value="06">Jun</asp:ListItem>
                                    <asp:ListItem Value="07">Jul</asp:ListItem>
                                    <asp:ListItem Value="08">Aug</asp:ListItem>
                                    <asp:ListItem Value="09">Sep</asp:ListItem>
                                    <asp:ListItem Value="10">Oct</asp:ListItem>
                                    <asp:ListItem Value="11">Nov</asp:ListItem>
                                    <asp:ListItem Value="12">Dec</asp:ListItem>
                                    </asp:DropDownList>
                                   </div>   
                               <div class="col-md-6 form-group">
                                       <label >Year</label>
                                       <asp:DropDownList ID="DropDownList2" runat="server" Class="form-control">
                                          <asp:ListItem Value="0">---Select Year---</asp:ListItem>
                                      </asp:DropDownList>
                                   </div> 
                               
                                <div class="col-md-6 form-group">
                                       <label >Employee code</label>
                                       <asp:TextBox ID="txtempcode" runat="server" Class="form-control" placeholder="Employee code" data-error="Please enter employee code"  ValidationGroup="a"></asp:TextBox>
                                   </div>    
                               <div class="col-md-6 form-group">
                                   <label >Employee Name</label>
                                       <asp:TextBox ID="TextBox1" runat="server" Class="form-control" placeholder="Employee Name" data-error="Please enter employee code"  ValidationGroup="a"></asp:TextBox>

                               </div>
                              <div class="col-md-12 form-group">
                                    <asp:Button ID="submit" runat="server" Class=" btn btn-warning " Text="Search" OnClick="submit_Click" ValidationGroup="a" />
                                   &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" ValidationGroup="a" />
                              </div>

                                 <div class="col-md-12 grid-margin">
                 <div class="table-responsive" >
<table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0" >

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  CssClass="example" Width="80%"
                            DataKeyNames="Emp_id" onrowdeleting="GridView1_RowDeleting" >
                            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <Columns>
                                <asp:BoundField DataField="EmployeeCode" HeaderText="Employee Code">
                                <HeaderStyle HorizontalAlign="Left" />
                                <ItemStyle HorizontalAlign="Left"  />
                                </asp:BoundField>
                                <asp:BoundField DataField="Name" HeaderText="Name">
                                <HeaderStyle HorizontalAlign="Left"  />
                                <ItemStyle HorizontalAlign="Left"  />
                                </asp:BoundField>
                                <asp:BoundField DataField="Mobileno" HeaderText="Mobile no">
                                <HeaderStyle HorizontalAlign="Left"  />
                                <ItemStyle HorizontalAlign="Left"  />
                                </asp:BoundField>

                                <asp:BoundField DataField="emailid" HeaderText="Emailid">
                                <HeaderStyle HorizontalAlign="Left"  />
                                <ItemStyle HorizontalAlign="Left"  />
                                </asp:BoundField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("Emp_id","Employeedtl.aspx?id={0}") %>' Text="Detail"></asp:HyperLink>

                                    </ItemTemplate>

                                </asp:TemplateField>
                              
            <%--<asp:TemplateField  HeaderText="Delete">
                        <ItemTemplate>
                        
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/DSR/icon/No.png"   CommandName="Delete" OnClientClick="return confirm('Do u delete Record?')" />
                        </ItemTemplate>
                        </asp:TemplateField> --%>
                            </Columns>
                        </asp:GridView>
</table>

                 </div>
                   <div class="col-md-12 form-group">

                   </div>     

             </div>
                           </div>

                     </div>


                </div>


                </div>
         </div>
</asp:Content>

