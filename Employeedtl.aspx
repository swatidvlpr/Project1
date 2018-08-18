<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Employeedtl.aspx.cs" Inherits="Hr_Employeedtl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div id="page-wrapper">
         <div class="main-page">
             <div id="form1" class="forms validation">
                 <div class="form-grids row widget-shadow" data-example-id="basic-forms">
                     <div class="form-title">
							<h4>Employee Detail:</h4>
						</div>
                     <div class="form-body" id="form">
                         <div class="col-md-12 form-group">
<asp:FormView ID="FormView1" runat="server" Width="100%" DataKeyNames="EmployeeCode" OnDataBound="FormView1_DataBound">
     <ItemTemplate>
 <table Width="100%">
     <tr>
         <td colspan="2">
              <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#Eval("EmployeeCode","Employee_Reg.aspx?id={0}")%>' Text="Edit"></asp:HyperLink>
         </td>
          
 <tr>
     <td></td>
 <td>
     <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("photo")%>' Width="120" Height="120"/>
 </td></tr>
 <tr>
 <td>
 Employee Code
 </td><td>
    <asp:Label ID="Label1" runat="server" Text='<%#Eval("EmployeeCode")%>'></asp:Label></td> 
 </tr>
 <tr>
 <td>
Name
 </td><td>
     <asp:Label ID="Label2" runat="server" Text='<%#Eval("Name")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Sex
 </td><td>
     <asp:Label ID="Label3" runat="server" Text='<%#Eval("Sex")%>'></asp:Label></td>
 </tr>
<tr>
 <td>
 Marital Status
 </td><td>
     <asp:Label ID="Label4" runat="server" Text='<%#Eval("Marital_Status")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Blood group
 </td><td>
     <asp:Label ID="Label5" runat="server" Text='<%#Eval("Blooad_group")%>'></asp:Label></td>
 </tr>
<tr>
 <td>
Caste
 </td><td>
     <asp:Label ID="Label6" runat="server" Text='<%#Eval("Caste")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
 Urban Rural
 </td><td>
     <asp:Label ID="Label7" runat="server" Text='<%#Eval("Urban_Rural")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Address 
 </td><td>
     <asp:Label ID="Label8" runat="server" Text='<%#Eval("Address")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Pincode
 </td><td>
     <asp:Label ID="Label9" runat="server" Text='<%#Eval("Pincode")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
 Mobile No
 </td><td>
     <asp:Label ID="Label10" runat="server" Text='<%#Eval("Mobileno")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Alternate Mobile
 </td><td>
     <asp:Label ID="Label11" runat="server" Text='<%#Eval("Alternate_mob")%>'></asp:Label></td>
 </tr>
<tr>
 <td>
Father Name
 </td><td>
     <asp:Label ID="Label12" runat="server" Text='<%#Eval("father_name")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Mother Name
 </td><td>
     <asp:Label ID="Label13" runat="server" Text='<%#Eval("mother_name")%>'></asp:Label></td>
 </tr>
<tr>
 <td>
Father Occupation
 </td><td>
     <asp:Label ID="Label14" runat="server" Text='<%#Eval("father_occupation")%>'></asp:Label></td>
 </tr>
<tr>
 <td>
Emailid
 </td><td>
     <asp:Label ID="Label15" runat="server" Text='<%#Eval("emailid")%>'></asp:Label></td>
 </tr>
<tr>
 <td>
DOB 
 </td><td>
     <asp:Label ID="Label16" runat="server" Text='<%#Eval("DOB ")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Religion
 </td><td>
     <asp:Label ID="Label17" runat="server" Text='<%#Eval("Religion")%>'></asp:Label></td>
 </tr>
<tr>
 <td>
phone No
 </td><td>
     <asp:Label ID="Label18" runat="server" Text='<%#Eval("phone_no")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Qualification
 </td><td>
     <asp:Label ID="Label19" runat="server" Text='<%#Eval("Qualification")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Post applied for
 </td>
 <td><asp:Label ID="Label20" runat="server" Text='<%#Eval("Post_applied_for")%>'></asp:Label>
     </td>
 </tr>
 <tr>
 <td>
Reference
 </td><td>
     <asp:Label ID="Label21" runat="server" Text='<%#Eval("Reference")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Final Intv Date
 </td><td>
     <asp:Label ID="Label22" runat="server" Text='<%#Eval("Final_Intv_Date")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Interviewee
 </td><td>
     <asp:Label ID="Label23" runat="server" Text='<%#Eval("Interviewee")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
Exptd Salary
 </td><td>
     <asp:Label ID="Label24" runat="server" Text='<%#Eval("Exptd_Salary")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
date
 </td><td>
     <asp:Label ID="Label25" runat="server" Text='<%#Eval("date")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
month
 </td><td>
     <asp:Label ID="Label26" runat="server" Text='<%#Eval("month")%>'></asp:Label></td>
 </tr>
 <tr>
 <td>
year
 </td><td>
     <asp:Label ID="Label27" runat="server" Text='<%#Eval("year")%>'></asp:Label></td>
 </tr
     <tr>
         <td colspan="2">
              <div class="form-title">
							<h4>Attachement File :</h4>
						        </div>
           <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="Attachmentfilename" HeaderText="File Name" />
        <asp:TemplateField HeaderText="Action">
            
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("Attach_file") %>' ImageUrl="~/Hr/icon/view.png"></asp:HyperLink>

            </ItemTemplate>

        </asp:TemplateField>
    </Columns>

             </asp:GridView>  

         </td>

     </tr>
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

