const rock = 0;
const paper = 1;
const scissors = 2;

let playerScore = 0;
let enemyScore = 0;

let enemySign = 0;

let round = 1;

function handleSigns(playerSign) {
    enemySign = Math.floor(Math.random() * 3);
    compareSigns(playerSign);
    round++;
    translateEnemySign();
    printScore();
    printRound();
    checkGameOver();
}

function compareSigns(playerSign) {
	if(playerSign === kertas && enemySign === batu) {
        playerScore++;
        console.log("Congrats, you won");
        alert("Congrats, you won!");
	} else if(playerSign === batu && enemySign === gunting){
        playerScore++;
        console.log("Congrats, you won");
        alert("Congrats, you won!");
	} else if(playerSign === gunting && enemySign === kertas){
        playerScore++;
        console.log("Congrats, you won");
        alert("Congrats, you won!");
	} else if(playerSign === enemySign){
        alert("Draw!");
        console.log("Draw");
	} else {
        enemyScore++;
        console.log("You lose!");
        alert("You lose!");
    }
}

function translateEnemySign(){
    if(enemySign == 0){
        alert("The enemy's choice is rock");
    }
    else if(enemySign == 1){
        alert("The enemy's choice is paper");
    }
    else{
        alert("The enemy's choice is scissors");
    }
}

function printScore() {

  const playerScoreElement = document.getElementById('playerScore');
  playerScoreElement.innerHTML = playerScore;

  const enemyScoreElement = document.getElementById('enemyScore');
  enemyScoreElement.innerHTML = enemyScore;

}

function printRound() {
  
  const roundElement = document.getElementById('round');
  roundElement.innerHTML = round;

}

function checkGameOver() {
    if(round == 6) {
        alert('Game Selesai!');
        showFinalScore();
	      reset();
    }
}

function showFinalScore() {
	if(playerScore > enemyScore){
		alert("The final result of the match is " + playerScore + "-" + enemyScore + " Congrats, you won");
	}
	else if(playerScore == enemyScore){
		alert("The final result of the match is " + playerScore + "-" + enemyScore + " It's still a draw");
	}
	else{
		alert("The final result of the match is " + playerScore + "-" + enemyScore + " Don't be sad, try again");
	}
}

function reset() {
    playerScore = 0;
    enemyScore = 0;
    round = 1;

    printScore();
    printRound();
}
