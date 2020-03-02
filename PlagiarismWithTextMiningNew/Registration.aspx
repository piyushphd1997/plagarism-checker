<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
   
    <tr>
            <td bgcolor="#336699" style="width: 121px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/web_img/registration.png" 
                    Width="40px" />
            </td>
            <td bgcolor="#336699">
                <asp:Label ID="Label1" runat="server" Text="New User Registration" Font-Size="Large" 
                    ForeColor="#3366CC"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 22px" bgcolor="#009999" colspan="2">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#3366CC" 
                    Text="Personal Details"></asp:Label>
            </td>
        </tr>



                    <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label4" runat="server" Text="Reg. ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtID" runat="server" Font-Size="Large" Width="82px" 
                        Height="27px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label10" runat="server" Text="Roll Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRollNo" runat="server" Font-Size="Large" Width="173px" 
                        Height="23px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtRollNo" ErrorMessage="*" Font-Bold="True" 
                        Font-Size="Medium" ForeColor="Red" ValidationGroup="aa"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 121px; height: 23px">
                    <asp:Label ID="Label5" runat="server" Text="Name"></asp:Label>
                </td>
                <td style="height: 23px">
                    <asp:TextBox ID="txtName" runat="server" Font-Size="Medium" Width="318px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="*" Font-Bold="True" Font-Size="Medium" ForeColor="Red" ValidationGroup="aa"></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                        runat="server" ControlToValidate="txtName" ValidationExpression="[a-zA-Z ]*$" 
                        ErrorMessage="Not Valid" ForeColor="Red" ValidationGroup="aa"></asp:RegularExpressionValidator>
                 
                </td>
            </tr>
            <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label6" runat="server" Text="Mobile No"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMobileNo" runat="server" Font-Size="Medium" Width="173px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtMobileNo" ErrorMessage="*" Font-Bold="True" Font-Size="Medium" ForeColor="Red" ValidationGroup="aa"></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtMobileNo" ValidationExpression="[0-9]{10}" ErrorMessage="Must be proper format" ForeColor="Red" ValidationGroup="aa"></asp:RegularExpressionValidator>
                 
                </td>
            </tr>
            <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label7" runat="server" Text="Email ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmailid" runat="server" Font-Size="Medium" Width="313px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtemailid" ErrorMessage="*" Font-Bold="True" Font-Size="Medium" ForeColor="Red" ValidationGroup="aa"></asp:RequiredFieldValidator>
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtEmailid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="Not Valid Email ID" ForeColor="Red" ValidationGroup="aa"></asp:RegularExpressionValidator>
                  
                </td>
            </tr>
            <tr>
                <td style="width: 121px" valign="top">
                    <asp:Label ID="Label8" runat="server" Text="Address"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" Font-Size="Medium" Width="313px" 
                        Height="47px" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>




    <tr>
        <td bgcolor="#009999" colspan="2">
            <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#3366CC" 
                Text="Authentication Details"></asp:Label>
        </td>
    </tr>
    
    <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label9" runat="server" Text="User Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server" Font-Size="Medium" Width="173px"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtUsername" ErrorMessage="*" Font-Bold="True" Font-Size="Medium" ForeColor="Red" ValidationGroup="aa"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label11" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server" Font-Size="Medium" Width="173px" TextMode="Password"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd" ErrorMessage="*" Font-Bold="True" Font-Size="Medium" ForeColor="Red" ValidationGroup="aa"></asp:RequiredFieldValidator> 
                </td>
            </tr>
            <tr>
                <td style="width: 121px">
                    <asp:Label ID="Label12" runat="server" Text="Profile"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="FileUpload1" ErrorMessage="*" Font-Bold="True" 
                        Font-Size="Medium" ForeColor="Red" ValidationGroup="aa"></asp:RequiredFieldValidator> 
                </td>
            </tr>
            
    
    
    <tr>
        <td style="width: 121px">
            &nbsp;</td>
        <td>
          

                
            <asp:Button ID="btnRegister" runat="server" Text="Register Now" 
                class="login-button reg-btn" onclick="btnRegister_Click" />
        </td>
    </tr>
    </table>



</asp:Content>

