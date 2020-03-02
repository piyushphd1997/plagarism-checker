<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="~/admin/DoneUser.aspx.cs" Inherits="admin_ViewDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
                    ForeColor="#990000" Text="User List"></asp:Label>
            </td>
        </tr>

        <tr>
            <td style="height: 23px">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="4" DataSourceID="SqlDataDonorData" 
                    ForeColor="Black" GridLines="Horizontal" Width="100%" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" ButtonType="Button" 
                            SelectText="Download" />
                        <asp:BoundField DataField="pid" HeaderText="Doc ID" SortExpression="pid" />
                        <asp:BoundField DataField="rollno" HeaderText="Roll No." 
                            SortExpression="rollno" />
                        <asp:BoundField DataField="uname" HeaderText="Student" SortExpression="uname" />
                        <asp:BoundField DataField="pdesc" HeaderText="Desc" SortExpression="pdesc" />
                         <asp:TemplateField>
                                <ItemTemplate>
                                    <img src='../users/photos/<%# Eval("photo") %>' width="100px" />
                                </ItemTemplate>
                            </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataDonorData" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:PlagiarismWithTextMiningConnectionString %>" 
                    
                    
                    
                    SelectCommand="select * from Registration inner join  Papers on Registration.id=Papers.uid">
                </asp:SqlDataSource>
            </td>
        </tr>
        </table>





    <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        </table>
&nbsp;<br />
    <br />
    




</asp:Content>

