<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Index.Master" AutoEventWireup="true" CodeBehind="theme.aspx.cs" Inherits="EpuExam.admin.theme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <!-- Custom styles for this page -->
  <link href="/lib/vendor/datatables/dataTables.bootstrap4.min.css" rel="stylesheet">  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
      <h1 class="h3 mb-0 text-gray-800">Danh sách</h1>
      <a href="" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm">
          <i class="fas fa-folder-plus"></i> Thêm khoa
      </a>
    </div>

    <!-- DataTales Example -->
    <div class="card shadow mb-4">
      <div class="card-header py-3">
        <h6 class="m-0 font-weight-bold text-primary">Khoa</h6>
      </div>
      <div class="card-body">
        <div class="table-responsive">
          <table class="table table-bordered table-hover" id="dataTable" width="100%" cellspacing="0">
            <thead>
              <tr>
                <th>Mã chủ đề</th>
                <th>Tên môn học</th>
                <th>Tên chủ đề</th>                 
                <th>Thao tác</th>
              </tr>
            </thead>
            <tfoot>
              <tr>
                <th>Mã chủ đề</th>
                <th>Tên môn học</th>
                <th>Tên chủ đề</th>
                <th>Thao tác</th>
              </tr>
            </tfoot>
            <tbody id="itemTable">
                <asp:PlaceHolder ID="PlaceHolder1" runat="server">

                </asp:PlaceHolder>
            </tbody>
          </table>
        </div>
      </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!-- Page level plugins -->
      <script src="/lib/vendor/datatables/jquery.dataTables.min.js"></script>
      <script src="/lib/vendor/datatables/dataTables.bootstrap4.min.js"></script>

      <!-- Page level custom scripts -->
      <script src="/lib/js/demo/datatables-demo.js"></script>
      <script src="/lib/ajax.js"></script>
</asp:Content>
