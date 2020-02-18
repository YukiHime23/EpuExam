<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Index.Master" AutoEventWireup="true" CodeBehind="CreExam.aspx.cs" Inherits="EpuExam.admin.CreExam" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Page Heading -->
        <div class="d-sm-flex align-items-center justify-content-between mb-4">
            <h1 class="h3 mb-0 text-gray-800">Tạo bài thi - kiểm tra</h1>
            <%--<a href="#" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm"><i class="fas fa-download fa-sm text-white-50"></i> Tải về báo cáo</a>--%>
            <div class="d-none d-sm-inline-block btn btn-sm shadow-sm">
                <i class="fas fa-calendar"></i>
                <p id="nowDate" style="display:inline;"></p>
            </div>
        </div>
            <!-- Content Row -->

            <div class="row">

            <!-- Area Chart -->
            <div class="col-xl-8 col-lg-7">
              <div class="card shadow mb-4">
                <div class="card-body">
                    <div class="form-group">
                        <label for="StageExam"> <i class="fas fa-question"></i> Kỳ thi: </label>
                        <select class="form-control col-sm-3" style="display:inline" id="StageExam" onchange="getStageExam()">
                            <option selected disabled>- Select one -</option>
                            <asp:PlaceHolder ID="PlaceHolder1" runat="server">

                            </asp:PlaceHolder>
                        </select>
                    </div>

                    <div class="row" hidden id="moreStageExam">
                        <div class="form-group col-sm-3">
                            <label for="StageExam">Thời gian làm bài: </label>
                            <input type="number" min="15" value="" class="form-control" id="timeDo"/>
                        </div>
                        <div class="form-group col-sm-3">
                            <label for="StageExam">Trình độ: </label>
                            <input type="text" value="" class="form-control" id="rank"/>
                        </div>
                        <div class="form-group col-sm-3">
                            <label for="StageExam">Hệ đào tạo: </label>
                            <input type="text" value="" class="form-control" id="training"/>
                        </div>
                    </div>

                    <div class="form-group col-sm-3">
                        <label for="StageExam">Số câu: </label>
                        <input type="number" min="15" value="" class="form-control" id="numQuiz" onchange="numQuiz_keyPress()"/>
                    </div>

                    <div class="row" hidden id="numLevel">
                        <div class="form-group col-sm-3">
                            <label for="StageExam">Số câu dễ: </label>
                            <input type="number" min="1" value="" class="form-control" id="quizEasy"/>
                        </div>
                        <div class="form-group col-sm-3">
                            <label for="StageExam">Số câu trung bình: </label>
                            <input type="number" min="1" value="" class="form-control" id="quizMedium"/>
                        </div>
                        <div class="form-group col-sm-3">
                            <label for="StageExam">Số câu khó: </label>
                            <input type="number" min="1" value="" class="form-control" id="quizHard"/>
                        </div>
                    </div>

                    <div class="form-group col-sm-3">
                        <label for="StageExam">Số đề: </label>
                        <input type="number" min="1" max="10" value="" class="form-control" id="numExams"/>
                    </div>
                  
                </div>
                <button Class="btn btn-success" id="btnAddQuiz" onclick="btnCreExam_Click()">Tạo bài thi - kiểm tra</button>
              </div>
            </div>

            <!-- Pie Chart -->
            <div class="col-xl-4 col-lg-5">
              <div class="card shadow mb-4">
                <!-- Card Header - Dropdown -->
                <div class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                  <h6 class="m-0 font-weight-bold text-primary">Chọn môn thi</h6>
                </div>
                <!-- Card Body -->
                <div class="card-body">
                    <div class="form-group">
                        <label> <i class="fas fa-info"></i> Khoa:</label>
                        <select class="form-control col-sm-7" style="display:inline" onchange="getValueGr()" id="selectGr">
                            <option selected disabled>- Select one -</option>
                            <asp:PlaceHolder ID="PlaceHolder2" runat="server">

                            </asp:PlaceHolder>
                        </select>
                    </div>

                    <div class="form-group" id="optSubject" hidden>
                        <label for="comLevel"> <i class="fas fa-info"></i> Môn học:</label>   
                        <select class="form-control col-sm-7" style="display:inline" id="selectSubj">
                            <option selected disabled>- Select one -</option>
                        </select>
                    </div>
                    
                    <button class="btn btn-danger" id="btnAdd">Thêm khoa</button>
                </div>
              </div>
            </div>
          </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script src="/lib/ajax.js"></script>
</asp:Content>
