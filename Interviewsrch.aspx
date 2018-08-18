<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Interviewsrch.aspx.cs" Inherits="Hr_Interviewdtl" %>

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
							<h4>Interview details :</h4>
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
        CellPadding="4" GridLines="None" 
        DataKeyNames="interview_id" onrowdeleting="GridView1_RowDeleting" Width="100%" >
        <AlternatingRowStyle  ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="Name_of_applicant" HeaderText="Name of applicant" />
            <asp:BoundField DataField="Position_applied_for" 
                HeaderText="Position applied for" />
            <asp:BoundField DataField="Center" HeaderText="Center" />
            <asp:BoundField DataField="Date_of_interview" HeaderText="Date of interview" />
            <asp:BoundField DataField="Basic_qualification" 
                HeaderText="Basic qualification" />
            <asp:BoundField DataField="Professional_qualification" 
                HeaderText="Professional qualification" />
           <%-- <asp:BoundField DataField="Experience_details" 
                HeaderText="Experience details" />--%>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:TemplateField>
                <ItemTemplate>

                </ItemTemplate>
                <ItemStyle Width="20px" />
            </asp:TemplateField>
            <asp:TemplateField>
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("interview_id","Intrvwdtlshow.aspx?id={0}")%>' Text="Details"></asp:HyperLink>
            </ItemTemplate></asp:TemplateField>
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

