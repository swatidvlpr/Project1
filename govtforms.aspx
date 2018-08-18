<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="govtforms.aspx.cs" Inherits="Hr_govtforms" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div id="form1" class="forms validation">
           <div id="page-wrapper">
			<div class="main-page">
<div class="forms" data-example-id="form-validation-states">
    <div class="form-grids row widget-shadow" data-example-id="basic-forms">
        <div class="form-title">
							<h4>Govt. Form :</h4>
		</div>
   <div class="col-md-6 form-group">
    <label >Govt. Forms Name </label>
       <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                
</div>
<div class="col-md-6 form-group">
    <label >Govt. Forms</label>
    <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control"/>
                
</div>
             <div class="col-md-12 form-group">
            <asp:Button ID="Button1" runat="server" Text="SUBMIT" onclick="Button1_Click" Class=" btn btn-warning " />
              &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" ValidationGroup="a" />
                 <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>

             
                            <div class="col-md-12 grid-margin">
                 <div class="table-responsive" >
                     
<table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0"  >
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        onrowdeleting="GridView1_RowDeleting" 
        DataKeyNames="uploadgovt_id" CellPadding="4" ForeColor="#333333" 
        GridLines="None" Width="100%">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>   
             <asp:TemplateField HeaderText="SN" >
                     <ItemTemplate>
                         <%#GridView1.Rows.Count + 1%>
                     </ItemTemplate>
                     <HeaderStyle HorizontalAlign="Left"/>
                     <ItemStyle HorizontalAlign="Left" />
                 </asp:TemplateField>         
            <asp:BoundField DataField="govtform" HeaderText="govtform" />
            <asp:CommandField ShowDeleteButton="True" HeaderText="Action" HeaderStyle-HorizontalAlign="Left">
<HeaderStyle HorizontalAlign="Left"></HeaderStyle>
            </asp:CommandField>
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

