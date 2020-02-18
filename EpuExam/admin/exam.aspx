<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Index.Master" AutoEventWireup="true" CodeBehind="exam.aspx.cs" Inherits="EpuExam.admin.exam" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card shadow mb-4">
      <div class="card-header py-3">
        <h6 class="m-0 font-weight-bold text-primary">Bài thi </h6>
      </div>
      <div class="card-body">
        <div class="table-responsive">
            <asp:PlaceHolder ID="PlaceHolder1" runat="server">

            </asp:PlaceHolder>
        </div>
        <div>
            <button type="button" class="btn btn-success" onclick="calExamScores()">Nop bai</button>
        </div>
      </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <script src="/lib/ajax.js"></script>
      <script src="/lib/tinhDiem.js"></script>
</asp:Content>
