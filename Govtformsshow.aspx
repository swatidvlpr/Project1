<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="Govtformsshow.aspx.cs" Inherits="Hr_Govtformsshow" %>

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
 
                            <div class="col-md-12 grid-margin">
                 <div class="table-responsive" ><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
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
            <%--<asp:BoundField DataField="govtform" HeaderText="govtform" />--%>
            <asp:TemplateField HeaderText="Forms">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" Text='<%#Eval("Govt_name")%>' NavigateUrl='<%#Eval("govtform")%>'></asp:HyperLink>
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
<table id="example" class="table table-striped table-bordered dt-responsive nowrap" cellspacing="0"  >
    

</table>

                 </div>
                     

             </div>


         </div>

    </div>

</div>
    </div> 
    </div>
</asp:Content>

