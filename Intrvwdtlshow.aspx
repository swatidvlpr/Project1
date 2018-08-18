<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Intrvwdtlshow.aspx.cs" Inherits="Hr_Intrvwdtlshow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="page-wrapper">
         <div class="main-page">
             <div id="form1" class="forms validation">
                 <div class="form-grids row widget-shadow" data-example-id="basic-forms">
                     <div class="form-title">
							<h4>Interviewee Detail:</h4>
						</div>
                     <div class="form-body" id="form">
                         <div class="col-md-12 form-group">
    <asp:FormView ID="FormView1" runat="server" onpageindexchanging="FormView1_PageIndexChanging" 
                                 Width="530px">
    <ItemTemplate>
    <table width="100%">
     <tr><td colspan="2" align="center">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("interview_id","Interview_sheet.aspx?id={0}")%>' Text="Edit"></asp:HyperLink>
    </td></tr>
    <tr><td>Name</td>
    <td>
        <asp:Label ID="Label1" runat="server" Text='<%#Eval("Name_of_applicant")%>'></asp:Label></td></tr>
        <tr><td>Position</td>
    <td>
        <asp:Label ID="Label2" runat="server" Text='<%#Eval("Position_applied_for")%>'></asp:Label></td></tr>
        <tr><td>Center</td>
    <td>
        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Center")%>'></asp:Label></td></tr>
        <tr><td>Date of interview</td>
    <td>
        <asp:Label ID="Label4" runat="server" Text='<%#Eval("Date_of_interview")%>'></asp:Label></td></tr>
        <tr><td>Basic qualification</td>
    <td>
        <asp:Label ID="Label5" runat="server" Text='<%#Eval("Basic_qualification")%>'></asp:Label></td></tr>
        <tr><td>Professional qualification</td>
    <td>
        <asp:Label ID="Label6" runat="server" Text='<%#Eval("Professional_qualification")%>'></asp:Label></td></tr>
        <tr><td>Experience details</td>
    <td>
        <asp:Label ID="Label7" runat="server" Text='<%#Eval("Experience_details")%>'></asp:Label></td></tr>
        <tr><td>Communication skill</td>
    <td>
        <asp:Label ID="Label8" runat="server" Text='<%#Eval("Communication_skill")%>'></asp:Label></td></tr>
        <tr><td>Personality</td>
    <td>
        <asp:Label ID="Label9" runat="server" Text='<%#Eval("Personality")%>'></asp:Label></td></tr>
        <tr><td>Fathers occupation</td>
    <td>
        <asp:Label ID="Label10" runat="server" Text='<%#Eval("Fathers_occupation")%>'></asp:Label></td></tr>
        <tr><td>Mothers occupation</td>
    <td>
        <asp:Label ID="Label11" runat="server" Text='<%#Eval("Mothers_occupation")%>'></asp:Label></td></tr>
   
        <tr><td>Brother</td>
    <td>
        <asp:Label ID="Label13" runat="server" Text='<%#Eval("Brother")%>'></asp:Label></td></tr>
        <tr><td>Sister</td>
    <td>
        <asp:Label ID="Label14" runat="server" Text='<%#Eval("Sister")%>'></asp:Label></td></tr>
        <tr><td>Dependants</td>
    <td>
        <asp:Label ID="Label15" runat="server" Text='<%#Eval("Dependants")%>'></asp:Label></td></tr>
        <tr><td>Reffered by staff</td>
    <td>
        <asp:Label ID="Label16" runat="server" Text='<%#Eval("Reffered_by_staff")%>'></asp:Label></td></tr>
        <tr><td>Unit</td>
    <td>
        <asp:Label ID="Label17" runat="server" Text='<%#Eval("Unit")%>'></asp:Label></td></tr>
        
      <tr><td>Referee center</td>
    <td>
        <asp:Label ID="Label19" runat="server" Text='<%#Eval("Referee_center")%>'></asp:Label></td></tr>
        <tr><td>Salary partclrs</td>
    <td>
        <asp:Label ID="Label20" runat="server" Text='<%#Eval("Salary_partclrs","{0:n}")%>'></asp:Label></td></tr>
        <tr><td>Salary expctn</td>
    <td>
        <asp:Label ID="Label12" runat="server" Text='<%#Eval("Salary_expctn","{0:n}")%>'></asp:Label></td></tr>
        <tr><td>Salary offered</td>
    <td>
        <asp:Label ID="Label18" runat="server" Text='<%#Eval("Salary_offered","{0:n}")%>'></asp:Label></td></tr>
        <tr><td>Date of joining</td>
    <td>
        <asp:Label ID="Label21" runat="server" Text='<%#Eval("Date_of_joining")%>'></asp:Label></td></tr>
        <tr><td>Comments</td>
    <td>
        <asp:Label ID="Label22" runat="server" Text='<%#Eval("Comments")%>'></asp:Label></td></tr>
       
    </table>
    </ItemTemplate>
    </asp:FormView>
                         </div>
                     </div>
               </div>
         </div>
     </div>
 </div>
    
    </asp:Content>

