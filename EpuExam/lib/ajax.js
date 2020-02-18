function delRow(id,pathname) {
    jQuery.ajax({
        url: pathname + "/delRow",
        type: "POST",
        data: JSON.stringify({"idQuiz": id }),
        contentType: 'application/json; charset=utf-8',
        // contentType: "application/json; charset=utf-8",
        // dataType: "json",
        success: function (data) {
            if (data) {
                var item = document.querySelector('#bodyTable');
                var lis = item.children;
                for (var i = 0; i < lis.length; i += 1) {
                    var li = lis[i];
                    if (li.textContent.startsWith(id)) {
                        item.removeChild(li);
                        break;
                    }
                }
                alert("Xóa câu hỏi thành công!");
            }
        },
        error: (error) => {
            console.log(JSON.stringify(error));
        }

    });
}

function addItem(pathname,objJson) {
    jQuery.ajax({
        url: pathname + "/addItem",
        type: "POST",
        data: JSON.stringify(objJson),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            // body...
            if (data.d) {
                alert("Them thanh cong!");
            }else{
                alert("Them that bai!");
            }
        },
        error: (error) => {
            console.log(JSON.stringify(error));
        }

    });
}

function sendId(id,pathname) {
    jQuery.ajax({
        url: pathname + "/sendId",
        type: "POST",
        data: JSON.stringify({"id": id }),
        contentType: 'application/json; charset=utf-8',
        // dataType: "json",
        success: function (data) {
            // alert();
            window.location.href = data.d;
        },
        error: (error) => {
            console.log(JSON.stringify(error));
        }

    });
}

function getValueGr() {
    // body...
    var id = document.getElementById("selectGr").value;
    jQuery.ajax({
        url: document.location.pathname+"/getSubjById",
        type: "POST",
        data: JSON.stringify({"id": id }),
        contentType: 'application/json; charset=utf-8',
        // dataType: "json",
        success: function (data) {
            document.querySelector('#optSubject').removeAttribute("hidden");
            $("#btnAdd").html('Thêm môn học');
            var da = data.d;

            var sel = document.querySelector('#selectSubj');
            var op = sel.children;
            var x = op.length;
            while(x!=1){
                x--;
                op[x].remove();
            }

            for (index = 0; index < da.length; ++index) {
                var optCre = document.createElement('option');
                optCre.value = da[index].idSubject;
                optCre.innerHTML = da[index].nameSubject;
                var secOpt = sel.children[1];
                sel.insertBefore(optCre,secOpt);
            }
        },
        error: (error) => {
            console.log(JSON.stringify(error));
        }
    });
}

function getValueSubj() {
    // body...
    var id = document.getElementById("selectSubj").value;
    jQuery.ajax({
        url: document.location.pathname + "/getThemeById",
        type: "POST",
        data: JSON.stringify({"id": id }),
        contentType: 'application/json; charset=utf-8',
        // dataType: "json",
        success: function (data) {
            document.querySelector('#optTheme').removeAttribute("hidden"); 
            $("#btnAdd").html('Thêm chủ đề');
            var da = data.d;

            var sel = document.querySelector('#selectTheme');
            var op = sel.children;
            var x = op.length;
            while(x!=1){
                x--;
                op[x].remove();
            }            

            for (index = 0; index < da.length; ++index) {
                var opt = document.createElement('option');
                opt.value = da[index].idTheme;
                opt.innerHTML = da[index].nameTheme;
                var secOpt = sel.children[1];
                sel.insertBefore(opt,secOpt);
            }
        },
        error: (error) => {
            console.log(JSON.stringify(error));
        }
    });
}

function btnAddQuiz_Click() {
    // body...
    var cauhoi = document.querySelector("#txtContent").value;
    var dokho  = document.querySelector("#levelQuiz") .value;
    var a      = document.querySelector("#txtA")      .value;
    var b      = document.querySelector("#txtB")      .value;
    var c      = document.querySelector("#txtC")      .value;
    var d      = document.querySelector("#txtD")      .value;
    var cka    = document.querySelector("#ckA")       .checked;
    var ckb    = document.querySelector("#ckB")       .checked;
    var ckc    = document.querySelector("#ckC")       .checked;
    var ckd    = document.querySelector("#ckD")       .checked;
    var dapan  = "";
    if (cka) { dapan = a; } 
    if (ckb) { dapan = b; }
    if (ckc) { dapan = c; }
    if (ckd) { dapan = d; }
    var ngaytao = document.querySelector("#nowDate")    .value;
    var makhoa  = document.querySelector("#selectGr")   .value;
    var mamon   = document.querySelector("#selectSubj") .value;
    var machude = document.querySelector("#selectTheme").value;
    // var magv    = document.querySelector("#userSesion") .value;
    var magv    = "GV1681310038";
    var objJson = {"nd":cauhoi, "dk":dokho, "ngt":ngaytao, "macd":machude, "magv":magv, "a":a, "b":b, "c":c, "d":d, "dapan":dapan };
    addItem(document.location.pathname,objJson);
}

function getStageExam() {
    // body...
    var id = document.getElementById("StageExam").value;
    jQuery.ajax({
        url: "CreExam.aspx/getStageById",
        type: "POST",
        data: JSON.stringify({"id": id }),
        contentType: 'application/json; charset=utf-8',
        // dataType: "json",
        success: function (data) {
            document.querySelector('#moreStageExam').removeAttribute("hidden"); 
            var da = data.d;
            for (index = 0; index < da.length; ++index) {
                document.getElementById('timeDo').value = da[index].timeDoExam;
                document.getElementById('rank').value = da[index].rankExam;
                document.getElementById('training').value = da[index].trainingSys;
            }
        },
        error: (error) => {
            console.log(JSON.stringify(error));
        }
    });
}

function numQuiz_keyPress() {
    // body...
    document.querySelector('#numLevel').removeAttribute("hidden");
    var maxV = document.querySelector('#numQuiz').value;
    document.querySelector('#quizEasy').max = maxV;
    document.querySelector('#quizMedium').max = maxV; 
    document.querySelector('#quizHard').max = max;V
}

function btnCreExam_Click() {
    // body...
    var socau = document.querySelector('#numQuiz').value;
    var makythi = document.querySelector('#StageExam').value;
    var mamon = document.querySelector('#selectSubj').value;

    var sode = document.querySelector('#numExams').value;
    var qE = document.querySelector('#quizEasy').value; 
    var qM = document.querySelector('#quizMedium').value; 
    var qH = document.querySelector('#quizHard').value;

    var objJson = {"mkt":makythi, "mamon":mamon, "socau":socau, "easy":qE, "medium":qM, "hard":qH};
    addItem(document.location.pathname,objJson);
}

function infoRow(id) {
    // body...
    jQuery.ajax({
        url: document.location.pathname + "/infoRow",
        type: "POST",
        data: JSON.stringify({"idQuiz": id }),
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            // body...
            var da = data.d;
            document.querySelector("#txtContent").innerHTML = da[0].contentQuiz;
            document.querySelector(".modal-title span b").innerHTML = da[0].idQuiz;
            document.querySelector("#levelQuiz").value = da[0].levelQuiz;
            document.querySelector("#txtA").value =  da[0].ansA;
            document.querySelector("#txtB").value =  da[0].ansB;
            document.querySelector("#txtC").value =  da[0].ansC;
            document.querySelector("#txtD").value =  da[0].ansD;
            document.querySelector("#selectTheme").value = da[0].idTheme;
        },
        error: (error) => {
            console.log(JSON.stringify(error));
        }

    });
}

// var ansCorrect = document.querySelectorAll("div .dapan");
// var lisAns = [];

// function answerQuiz(i,ans) {
//     // body...
//     lisAns[--i] = ans;
// }

// function checkAnswer() {
//     // body...
//     jQuery.ajax({
//         url: document.location.pathname + "/calExamScores",
//         type: "POST",
//         data: JSON.stringify({"lis": lisAns }),
//         contentType: 'application/json; charset=utf-8',
//         success: function (data) {
//             // body...
//             var da = data.d;
            
//         },
//         error: (error) => {
//             console.log(JSON.stringify(error));
//         }

//     });
// }