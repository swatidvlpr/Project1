<%@ Page Title="" Language="C#" MasterPageFile="~/Hr/hr.master" AutoEventWireup="true" CodeFile="upload_attendance.aspx.cs" Inherits="Hr_upload_attendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div id="page-wrapper">
			<div class="main-page">
                <div id="form1" class="forms validation">
                    <div class="form-grids row widget-shadow" data-example-id="basic-forms">
                         <div class="form-title">
							<h4>Company Master</h4>
						</div>
                        <div class="form-body" id="form">
                             <div class="col-md-12 form-group">
                                  <label >Company name</label>  
                                 <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                             </div>
                            
                            <div class="col-md-12 form-group">
                                 <asp:Button ID="Button1" runat="server" Text="Submit" Class=" btn btn-warning " onclick="Button1_Click" 
        Height="40px" Width="109px" />
                                  &nbsp;<asp:Button ID="Button2" runat="server" Class=" btn btn-info " Text="Reset" OnClick="Button2_Click" ValidationGroup="a" />
                                <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>  
<asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>

                             </div>

                            <div class="col-md-12 form-group">

                            </div>
                             <div class="col-md-12 form-group">
                                 <asp:HyperLink ID="HyperLink1" runat="server" Text="Download Excel Format" NavigateUrl="~/Uploaded Folder/Daily_Attendance.xlsx"></asp:HyperLink>
                            </div>
                           

                          

                        </div>
                    </div>

                </div>
                </div>
         </div>



    

    

</asp:Content>

