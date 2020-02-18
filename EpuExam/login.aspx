<%@ Page Title="" Language="C#" MasterPageFile="~/Log.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="EpuExam.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                      <div class="col-lg-6">
                        <div class="p-5">
                          <div class="text-center">
                            <h1 class="h4 text-gray-900 mb-4">Welcome to Epu - Exam Online</h1>
                          </div>
                          <div class="user">
                            <div class="form-group">
                                <input type="text" class="form-control form-control-user" runat="server" id="user" aria-describedby="emailHelp" placeholder="Ma dang nhap..." required/>
                            </div>
                            <div class="form-group">
                              <input type="password" class="form-control form-control-user" runat="server" id="password" placeholder="mat khau" required/>
                            </div>
                            <asp:Label ID="lbError" runat="server" Text=""></asp:Label>
                            <asp:Button ID="LoginButton" runat="server" Text="Đăng nhập" CssClass="btn btn-primary btn-user btn-block" OnClick="LoginButton_Click"/>
                          </div>
                          <hr>
                          <div class="text-center">
                            <a class="small" href="forgot-password.aspx">Quên mật khẩu?</a>
                          </div>
                        </div>
                      </div>

</asp:Content>
