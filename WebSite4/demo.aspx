

<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeFile="demo.aspx.cs" Inherits="demo" Debug="true" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="AjaxControlToolkit" %>

<!DOCTYPE html>
<script>
    
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title> PVR</title>
		<link href="http://fonts.googleapis.com/css?family=Cantarell:regular,italic,bold,bolditalic" rel="stylesheet" />
		<link href="http://fonts.googleapis.com/css?family=Droid+Serif:regular,italic,bold,bolditalic" rel="stylesheet" />
		<link rel="stylesheet" href="grey.css" />
    <style type="text/css">
        #TextArea1 {
            width: 1057px;
            height: 540px;
        }
        center1{
            position:fixed;
            vertical-align:bottom;
            text-align:center
        }


        body{
            background: -webkit-linear-gradient(white,pink) fixed; /* For Safari 5.1 to 6.0 */
  background: -o-linear-gradient(white,pink) fixed; /* For Opera 11.1 to 12.0 */
  background: -moz-linear-gradient(white,pink) fixed; /* For Firefox 3.6 to 15 */
 background: -webkit-gradient(linear, left top, left bottom, from(white), to(pink)) fixed;

        }
        .auto-style1 {
            width: 103px;
        }
    </style>
</head>
   
<body>

    <form id="form1" runat="server">
  		
 
  		<asp:ScriptManager ID="Scriptmanager1" runat="server" EnablePartialRendering="true">
  		</asp:ScriptManager>
        
    <div>
      
        <br />
        
    </div>
        <table width="70%">
            <tr >
                <td>
<asp:FileUpload ID="FileUpload1" runat="server" Font-Bold="True" Font-Names="sans serif" Font-Size="X-Large" BackColor="#efefef" ForeColor="Brown"/>
     
                </td>
                <td>
                    <asp:ImageButton ID="Button2" runat="server" OnClick="Button2_Click" Font-Names="sans serif" Font-Bold="true" Font-Size="Large" ImageUrl="~/images/open.gif" Height="62px" Width="103px" BackColor="#efefef" ForeColor="Brown" />
            
                </td>
            </tr>
        </table>

       <br /><br />



           <table width="70%" align="center" border="0">
               <tr>
                   <td class="auto-style1">
                       <asp:ImageButton ID="Button4" runat="server" OnClick="Button4_Click" ImageUrl="~/images/3.png" Height="62px" Width="103px" Font-Names="sans serif" Font-Bold="true" Font-Size="Large" BackColor="#efefef" ForeColor="Brown"/>
        
                   </td>
                   <td>
 <asp:ImageButton ID="Button3" runat="server" OnClick="Button3_Click" Font-Names="sans serif" Font-Bold="true" Font-Size="Large" ImageUrl="~/images/2.png" Width="103px" Height="62px" BackColor="#efefef" ForeColor="Brown"/>
       
                   </td>
                   <td>
 <asp:ImageButton ID="Button5" runat="server" Height="62px" OnClick="Button5_Click" Width="99px" ImageUrl="~/images/1.png"/>
                   </td>
                   <td>
                        <asp:ImageButton ID="Button7" runat="server" OnClick="Button7_Click" Height="62px" Width="103px" ImageUrl="~/images/5.png" />
        
                   </td>
                   <td rowspan="2">
                        <asp:TextBox ID="TextBox1" TextMode="MultiLine" runat="server" Height="117px" Width="417px" Font-Bold="True" Font-Size="X-Large" style="margin-top: 13px; margin-left: 44px; margin-right: 0px;" BackColor="#efefef" ForeColor="Brown" ></asp:TextBox>
                
                   </td>
               </tr>
               <tr>
                   
             
                   <td colspan="4">
                   <asp:Label ID="Label2" runat="server" Text=" " Font-Bold="True" Font-Size="60px" ForeColor="Brown"></asp:Label>

                   </td>
               </tr>
               <tr>
                   <td colspan="4">

                   </td>
                   <td align="center">
<asp:ImageButton ID="Button6" runat="server" Text="Button" OnClick="Button6_Click" Height="62px" Width="103px" ImageUrl="~/images/1.png" /> 
                       
                   </td>
                   
               </tr>
           </table>



        <br /><br /><br />



            <asp:UpdatePanel ID="upnlFont" runat="server">
  				<ContentTemplate>
              <!--         <div style="width: 631px; height: 163px; margin-top: 29px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  		-->		<center>	<asp:Label ID="lblSelectedFont" runat="server" Text=" " Font-Bold="True" Font-Size="60px" width="60%" ForeColor="Brown" ></asp:Label><br />
                      </center>     </div>
  					<br />
  					<!--<asp:Panel ID="pnlDDHeader" runat="server" Width="122px">
  						Select Font...
  					</asp:Panel> -->
  				<br />
                      <br />
                      <br />
                      <div>
                      	<asp:Panel ID="pnlDDFonts" runat="server" Width="792px" >
  						<asp:LinkButton ID="lbArial" runat="server" Font-Names="Arial" OnClick="FontSelected" Font-Bold="true" Font-Size="20px">A</asp:LinkButton>
  						<asp:LinkButton ID="lbComicSans" runat="server" Font-Names="Comic Sans" OnClick="FontSelected" Font-Bold="true" Font-Size="20px">A</asp:LinkButton>
  						<asp:LinkButton ID="lbVerdana" runat="server" Font-Names="Verdana" OnClick="FontSelected"  Font-Bold="true" Font-Size="20px">A</asp:LinkButton>
  						<asp:LinkButton ID="lbHelvetica" runat="server" Font-Names="Helvetica" OnClick="FontSelected"  Font-Bold="true" Font-Size="20px">A</asp:LinkButton>
  						<asp:LinkButton ID="lbTahoma" runat="server" Font-Names="Tahoma" OnClick="FontSelected"  Font-Bold="true" Font-Size="20px">A</asp:LinkButton>

  					</asp:Panel>
  					<AjaxControlToolkit:DropDownExtender ID="DropDownExtender1" runat="server" TargetControlID="pnlDDHeader"
  						DropDownControlID="pnlDDFonts">
  					</AjaxControlToolkit:DropDownExtender>
  				</ContentTemplate>
  			</asp:UpdatePanel>
     </div>
  

   <div>
      
  		<!--	<asp:Label ID="Label4" runat="server" Text="Label" onClick="test12()"></asp:Label> 
             
       -->
       
      
  		</div>
        <div>
      
  			<asp:UpdatePanel ID="UpdatePanel3" runat="server">
  				<ContentTemplate>
                      <!-- <div style="width: 631px; height: 163px; margin-top: 29px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;




  			<!--		<asp:Label ID="Label1" runat="server" Text=" " Font-Bold="True" Font-Size="60px" ForeColor="Brown"></asp:Label><br />
                -->       </div> 
  					<br />
  				<!--	<asp:Panel ID="Panel3" runat="server">
  						Select Color...
  					</asp:Panel> -->
  		
                
                      		<asp:Panel ID="Panel4" runat="server">
  						<asp:LinkButton ID="LinkButton8" runat="server" OnClick="ColorSelected" ForeColor="Brown">1</asp:LinkButton>
  						<asp:LinkButton ID="LinkButton9" runat="server" OnClick="ColorSelected" ForeColor="Blue">2</asp:LinkButton>
  						<asp:LinkButton ID="LinkButton10" runat="server" OnClick="ColorSelected" ForeColor="Black">3</asp:LinkButton>
  						<asp:LinkButton ID="LinkButton11" runat="server" OnClick="ColorSelected" ForeColor="Plum">4</asp:LinkButton>
  					</asp:Panel>
  				<!--	<AjaxControlToolkit:DropDownExtender ID="DropDownExtender2" runat="server" TargetControlID="Panel3"
  						DropDownControlID="Panel4">
  					</AjaxControlToolkit:DropDownExtender>  -->
               
  				</ContentTemplate>
  			</asp:UpdatePanel>
            
            
  		


      
        <div>
      
  			<asp:UpdatePanel ID="UpdatePanel7" runat="server">
  				<ContentTemplate>
                   <!--    <div style="width: 631px; height: 163px; margin-top: 29px;">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; -->
  					<!--<asp:Label ID="Label3" runat="server" Text=" " Font-Bold="True" Font-Size="60px" ForeColor="Brown"></asp:Label><br />
                  -->         </div>
  					<br />
  				<!--	<asp:Panel ID="Panel7" runat="server">
  						Select Color highlet...
  					</asp:Panel>  -->



                      <div>
  					<asp:Panel ID="Panel8" runat="server">
  						<asp:LinkButton ID="LinkButton12" runat="server" OnClick="BgSelected" ForeColor="Green">1</asp:LinkButton>
  						<asp:LinkButton ID="LinkButton13" runat="server" OnClick="BgSelected" ForeColor="White">2</asp:LinkButton>
  						<asp:LinkButton ID="LinkButton14" runat="server" OnClick="BgSelected" ForeColor="Yellow">3</asp:LinkButton>
  						<asp:LinkButton ID="LinkButton15" runat="server" OnClick="BgSelected" ForeColor="Red">4</asp:LinkButton>
  
  					</asp:Panel>
  					<AjaxControlToolkit:DropDownExtender ID="DropDownExtender3" runat="server" TargetControlID="Panel7"
  						DropDownControlID="Panel8">
  					</AjaxControlToolkit:DropDownExtender>
  				</ContentTemplate>
  			</asp:UpdatePanel>
            </div>
  		      
              
    </form>
   
</body>
</html>