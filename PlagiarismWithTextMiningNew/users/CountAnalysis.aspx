<%@ Page Title="" Language="C#" MasterPageFile="~/users/UserMasterPage.master" AutoEventWireup="true" CodeFile="~/users/CountAnalysis.aspx.cs" Inherits="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
   
    <tr>
            <td bgcolor="#336699" style="width: 158px">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/web_img/registration.png" 
                    Width="40px" />
            </td>
            <td bgcolor="#336699">
                <asp:Label ID="Label1" runat="server" Text="Plagiarism Count Analysis" Font-Size="Large" 
                    ForeColor="#3366CC"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height: 22px" bgcolor="#009999" colspan="2">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#3366CC" 
                    Text="Analysis"></asp:Label>
            </td>
        </tr>



        <tr>
            <td style="height: 22px" bgcolor="#009999" colspan="2">
                &nbsp;</td>
        </tr>



            <tr>
                <td style="width: 158px">
                    <asp:Label ID="Label12" runat="server" Text="Plagiarismis Count"></asp:Label>
                </td>
                <td>
          

                
                    <asp:Label ID="lblCount" runat="server" Text="-----" Font-Bold="True" 
                Font-Names="Lucida Calligraphy" Font-Size="Medium" ForeColor="#FF3300"></asp:Label>
                    <asp:Label ID="lblCount0" runat="server" Font-Bold="True" 
                        Font-Names="Lucida Bright" Font-Size="14pt" ForeColor="Red" Text="%"></asp:Label>
                </td>
            </tr>
            
    
    
            <tr>
                <td style="width: 158px">
                    <asp:Label ID="Label13" runat="server" Text="Status"></asp:Label>
                </td>
                <td>
          

                
                    <asp:Label ID="lblStatus" runat="server" Text="-----" Font-Bold="True" 
                Font-Names="Lucida Calligraphy" Font-Size="Medium" ForeColor="#FF3300"></asp:Label>
                </td>
            </tr>
            
    
    
            <tr>
                <td style="width: 158px">
                    <asp:Label ID="Label14" runat="server" Text="Doc Description"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDesc" runat="server" Font-Size="Medium" Width="283px" 
                        Height="32px" TextMode="MultiLine"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtDesc" ErrorMessage="*" Font-Bold="True" Font-Size="16pt" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            
    
    
    <tr>
        <td style="width: 158px">
                    &nbsp;</td>
        <td>
          

                
            <asp:Button ID="btnRegister" runat="server" Text="Save File" 
                class="login-button reg-btn" onclick="btnRegister_Click" />
        </td>
    </tr>
            
    
    
    <tr>
        <td style="width: 158px">
            &nbsp;</td>
        <td>
          

                
                    <asp:Label ID="lblMsg" runat="server" Text="-----" Font-Bold="True" 
                Font-Names="Lucida Calligraphy" Font-Size="Medium" ForeColor="#FF3300"></asp:Label>
        </td>
    </tr>
            
    
    
    <tr>
        <td style="width: 158px">
            &nbsp;</td>
        <td>
          

                
            &nbsp;</td>
    </tr>
    </table>



</asp:Content>

