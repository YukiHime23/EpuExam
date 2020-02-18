<%@ Page Title="" Language="C#" MasterPageFile="~/admin/Index.Master" AutoEventWireup="true" CodeBehind="addQuiz.aspx.cs" Inherits="EpuExam.admin.addQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<!-- Page Heading -->
        <div class="d-sm-flex align-items-center justify-content-between mb-4">
            <h1 class="h3 mb-0 text-gray-800">Thêm câu hỏi mới</h1>
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
                  
                </div>
                <button Class="btn btn-success" id="btnAddQuiz" onclick="btnAddQuiz_Click()">Thêm câu hỏi</button>
              </div>
            </div>

            <!-- Pie Chart -->
            <div class="col-xl-4 col-lg-5">
              <div class="card shadow mb-4">
                <!-- Card Header - Dropdown -->
                <div class="card-header py-3 d-flex flex-row align-items-center justify-content-between">
                  <h6 class="m-0 font-weight-bold text-primary">Phân loại câu hỏi</h6>
                </div>
                <!-- Card Body -->
                <div class="card-body">
                    <div class="form-group">
                        <label for="comLevel"> <i class="fas fa-info"></i> Khoa:</label>
                        <select class="form-control col-sm-7" style="display:inline" onchange="getValueGr()" id="selectGr">
                            <option selected disabled>- Select one -</option>
                            <asp:PlaceHolder ID="PlaceHolder1" runat="server">

                            </asp:PlaceHolder>
                        </select>
                    </div>
                    <div class="form-group"id="optSubject" hidden>
                        <label for="comLevel"> <i class="fas fa-info"></i> Môn học:</label>   
                        <select class="form-control col-sm-7" style="display:inline" onchange="getValueSubj()" id="selectSubj">
                            <option selected disabled>- Select one -</option>
                        </select>
                    </div>
                    <div class="form-group" id="optTheme" hidden>
                        <label for="comLevel"> <i class="fas fa-info"></i> Chủ đề:</label>
                        <select class="form-control col-sm-7" style="display:inline" id="selectTheme">
                            <option selected disabled>- Select one -</option>
                        </select>
                    </div>
                    
                    <button class="btn btn-danger" id="btnAdd">Thêm môn</button>
                </div>
              </div>
            </div>
          </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
	<%--<script src='https://cdnjs.cloudflare.com/ajax/libs/mathjax/2.7.5/MathJax.js?config=TeX-MML-AM_CHTML' async></script>--%>
    <script src="../lib/JavaScript.js"></script>
    <script src="../lib/ajax.js"></script>

</asp:Content>
