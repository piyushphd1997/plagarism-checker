<%@ Page Title="" Language="C#" MasterPageFile="~/users/UserMasterPage.master" AutoEventWireup="true" CodeFile="~/users/UploadDoc.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
   
    <tr>
            <td bgcolor="#336699" style="width: 136px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/web_img/registration.png" 
                    Width="40px" />
            </td>
            <td bgcolor="#336699">
                <asp:Label ID="Label1" runat="server" Text="Upload New Documents" Font-Size="Large" 
                    ForeColor="#3366CC"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 22px" bgcolor="#009999" colspan="2">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#3366CC" 
                    Text="Upload"></asp:Label>
            </td>
        </tr>



        <tr>
            <td style="height: 22px" bgcolor="#009999" colspan="2">
                &nbsp;</td>
        </tr>



            <tr>
                <td style="width: 136px">
                    <asp:Label ID="Label13" runat="server" Text="Select Type"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" Width="193px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>ASP Dot Net</asp:ListItem>
                        <asp:ListItem>Adv Java</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            
    
    
            <tr>
                <td style="width: 136px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            
    
    
            <tr>
                <td style="width: 136px">
                    <asp:Label ID="Label12" runat="server" Text="Select Doc File"></asp:Label>
                </td>
                <td>
                    <asp:FileUpload ID="FileUploadWord" runat="server" />
                </td>
            </tr>
            
    
    
    <tr>
        <td style="width: 136px">
                    <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" Width="74px" 
                        Height="16px" TextMode="MultiLine"></asp:TextBox>
                </td>
        <td>
          

                
            <asp:Button ID="btnRegister" runat="server" Text="Upload" 
                class="login-button reg-btn" onclick="btnRegister_Click" />
        </td>
    </tr>
            
    
    
    <tr>
        <td style="width: 136px">
            &nbsp;</td>
        <td>
          

                
                    <asp:Label ID="lblMsg" runat="server" Text="-----" Font-Bold="True" 
                Font-Names="Lucida Calligraphy" Font-Size="Medium" ForeColor="#FF3300"></asp:Label>
        </td>
    </tr>
            
    
    
    <tr>
        <td style="width: 136px">
            &nbsp;</td>
        <td>
          

                
            &nbsp;</td>
    </tr>
    </table>



</asp:Content>

