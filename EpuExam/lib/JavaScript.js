function getNowDay() {
    var currentDate = new Date();
    var day = currentDate.getDate();
    var month = currentDate.getMonth() + 1;
    var year = currentDate.getFullYear();
    document.getElementById('nowDate').innerHTML = "<b>" + day + "/" + month + "/" + year + "</b>";
    document.getElementById('nowDate').value = year+"/"+month+"/"+day;
}
window.onload = getNowDay();

