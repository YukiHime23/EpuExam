<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Index.Master" AutoEventWireup="true" CodeBehind="listQuiz.aspx.cs" Inherits="EpuExam.admin.listQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Custom styles for this page -->
  <link href="/lib/vendor/datatables/dataTables.bootstrap4.min.css" rel="stylesheet">   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <!-- Page Heading -->
    <div class="d-sm-flex align-items-center justify-content-between mb-4">
      <h1 class="h3 mb-0 text-gray-800">Danh sách</h1>
      <a href="addQuiz.aspx" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm">
          <i class="fas fa-folder-plus"></i> Thêm câu hỏi
      </a>
    </div>

    <!-- DataTales Example -->
    <div class="card shadow mb-4">
      <div class="card-header py-3">
        <h6 class="m-0 font-weight-bold text-primary">Câu hỏi</h6>
      </div>
      <div class="card-body">
        <div class="table-responsive">
          <table class="table table-bordered table-hover" id="dataTable" width="100%" cellspacing="0">
            <thead>
              <tr>
                <th>Mã</th>
                <th>Câu hỏi</th>
                <th>Độ khó</th>
                <th>Ngày tạo</th>
                <th>Thao tác</th>
              </tr>
            </thead>
            <tfoot>
              <tr>
                <th>Mã</th>
                <th>Câu hỏi</th>
                <th>Độ khó</th>
                <th>Ngày tạo</th>
                <th>Thao tác</th>
              </tr>
            </tfoot>
            <tbody id="bodyTable">
                <asp:PlaceHolder ID="PlaceHolder1" runat="server">

                </asp:PlaceHolder>
            </tbody>
          </table>
        </div>
      </div>
    </div>
        
    <%-- info quiz --%>
         

    <div class="modal fade infoQuiz">
        <div class="modal-dialog modal-dialog-scrollable">
            <div class="modal-content">
     
              <!-- Modal Header -->
              <div class="modal-header">
                <h4 class="modal-title">Chi tiet cau hoi <span><b></b></span></h4>
                <button type="button" class="close" data-dismiss="modal">&times;</button>
              </div>
          
              <!-- Modal body -->
              <div class="modal-body">
                  <div>Nguoi tao: <b></b></div>
                  <div>Ngay tao: <b></b></div>
                <div class="form-group">
                    <label for="txtContent"> <i class="fas fa-question"></i> Nội dung câu hỏi:</label>
                    <textarea class="form-control" rows="3" id="txtContent"></textarea>
                </div>
                <div class="form-group">
                    <label for="comLevel"> <i class="fas fa-question"></i> Độ khó:</label>
                    <select class="form-control col-sm-3" style="display:inline" id="levelQuiz">
                        <option selected disabled>-- Select one --</option>
                        <option value="easy">Dễ</option>
                        <option value="medium">Trung bình</option>
                        <option value="hard">Khó</option>
                    </select>
                </div>
                <fieldset>
                    <legend><i class="fas fa-question"></i> Đáp án </legend>
                    <div class="form-group">
                        <input type="radio" name="ans" id="ckA" checked>
                        <input class="" id="txtA"/>
                    </div>
                    <div class="form-group">
                        <input type="radio" id="ckB" name="ans">
                        <input class="" id="txtB"/>
                    </div>
                    <div class="form-group">
                        <input type="radio" id="ckC" name="ans">
                        <input class="" id="txtC"/>
                    </div>
                    <div class="form-group">
                        <input type="radio" id="ckD" name="ans">
                        <input class="" id="txtD"/>
                    </div>
                </fieldset>

                <div class="form-group" id="optTheme">
                    <label for="comLevel"> <i class="fas fa-info"></i> Chủ đề:</label>
                    <select class="form-control col-sm-7" style="display:inline" id="selectTheme">
                        <option selected disabled>- Select one -</option>
                        <asp:PlaceHolder ID="PlaceHolder2" runat="server">

                        </asp:PlaceHolder>
                    </select>
                </div>
          
              <!-- Modal footer -->
              <div class="modal-footer">
                <button class='btn btn-warning' onclick=""><i class='fas fa-edit'>Sua</i></button>&nbsp;
                <button type="button" class="btn btn-danger" data-dismiss="modal"><i class="fas fa-times">Dong</i></button>
              </div>
          
            </div>
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
    
    <%--<script type="text/javascript">

        function BtnDel_Click()
        {
         __doPostBack('btnDel');
        } 
    </script> --%>
</asp:Content>
