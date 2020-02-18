<%@ Page Title="" Language="C#" MasterPageFile="~/Log.Master" AutoEventWireup="true" CodeBehind="forgot-password.aspx.cs" Inherits="EpuExam.forgot_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Forgot Password</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-6">
                <div class="p-5">
                  <div class="text-center">
                    <h1 class="h4 text-gray-900 mb-2">Quên mật khẩu?</h1>
                    <p class="mb-4">We get it, stuff happens. Just enter your email address below and we'll send you a link to reset your password!</p>
                  </div>
                  <div class="user">
                    <div class="form-group">
                      <input type="email" class="form-control form-control-user" id="exampleInputEmail" aria-describedby="emailHelp" placeholder="Enter Email Address...">
                    </div>
                    <a href="login.aspx" class="btn btn-primary btn-user btn-block">
                      Khôi phục mật khẩu
                    </a>
                  </div>
                  <hr>
                  <div class="text-center">
                    <a class="small" href="login.aspx">Đăng nhập!</a>
                  </div>
                </div>
              </div>
</asp:Content>
