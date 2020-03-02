<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">




     <div class="form-container flip">
  <!-- <div class="login-form">-->
      <h3 class="title">User Login</h3>
      <div class="form-group" id="username">
        <%--<input class="form-input" tooltip-class="username-tooltip" placeholder="Username" id="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$" required="true"></input>--%>
         <asp:TextBox ID="txtUser" runat="server" placeholder="Username" class="form-input"></asp:TextBox>
        <span id="username-tool"class="tooltip username-tooltip">What's your username?</span>
      </div>
      <div class="form-group" id="password">        
        <asp:TextBox ID="txtPwd" runat="server" placeholder="Password" class="form-input" 
              TextMode="Password"></asp:TextBox>
        <span class="tooltip password-tooltip">What's your password?</span>
      </div>
      <div class="form-group">
        
             <asp:Button ID="btnLogin" runat="server" Text="Login" class="login-button" 
                 onclick="btnLogin_Click" />
        <input class="remember-checkbox"type="checkbox"></input>
        <p class="remember-p">Remember me</p>
      </div>
   <!--</div>-->
    <div class="loading">
      <div class="loading-spinner-large" style="display: none;"></div>
      <div class="loading-spinner-small" style="display: none;"></div>
    </div>
  </div>

   

 

</asp:Content>

