<%@ Page Title="" Language="C#" MasterPageFile="~/users/UserMasterPage.master" AutoEventWireup="true" CodeFile="Profile.aspx.cs" Inherits="users_Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
    <tr>
        <td bgcolor="#990000">
            <asp:Label ID="Label1" runat="server" ForeColor="Black" Text="Profile" 
                Font-Bold="True" Font-Size="Medium"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" 
                DataSourceID="SqlDataProfile" Height="50px" Width="261px">
                <Fields>
                    <asp:BoundField DataField="rollno" HeaderText="rollno" 
                        SortExpression="rollno" />
                    <asp:BoundField DataField="uname" HeaderText="uname" SortExpression="uname" />
                    <asp:BoundField DataField="mobileno" HeaderText="mobileno" 
                        SortExpression="mobileno" />
                    <asp:BoundField DataField="emailid" HeaderText="emailid" 
                        SortExpression="emailid" />
                    <asp:BoundField DataField="address" HeaderText="address" 
                        SortExpression="address" />
                    <asp:BoundField DataField="userid" HeaderText="userid" 
                        SortExpression="userid" />
                    <asp:BoundField DataField="pwd" HeaderText="pwd" 
                        SortExpression="pwd" />
                </Fields>
            </asp:DetailsView>
            <asp:SqlDataSource ID="SqlDataProfile" runat="server" 
                ConnectionString="<%$ ConnectionStrings:PlagiarismWithTextMiningConnectionString %>" 
                
                
                SelectCommand="SELECT [rollno], [uname], [mobileno], [emailid], [address], [userid], [pwd] FROM [Registration] WHERE ([id] = @id)">
                <SelectParameters>
                    <asp:SessionParameter Name="id" SessionField="id" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

