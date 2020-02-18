var ansCorrect = document.querySelectorAll("div .dapan");
var lisAns = [];

function answerQuiz(i,ans) {
	// body...
	lisAns[--i] = ans;
}

function calExamScores() {
	// body...
	var counts = 0;
	for(i=0; i<ansCorrect.length; i++){
		if(ansCorrect[i].textContent == lisAns[i]){
			counts++;

		}
	}

	var score = 10/ansCorrect.length;
	console.log(score*counts);
	alert(counts+"/"+ansCorrect.length);
}
