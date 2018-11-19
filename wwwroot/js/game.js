var options = ["paper", "rock", "lizard", "spock", "scissors"];
let optRes = ["rock", "scissors", "paper", "lizard", "spock"];
var results = [0, 1, -1];

function selectIcon(selected) {
    $("#restartGame").show();
    $("#iconSelection").hide();

    let enemySelected = Math.round(Math.random() * options.length);
    let res = chooseWinner(optRes[selected], optRes[enemySelected]);
    
    if (res == 1) {
        $("#playerPoints").text(+$("#playerPoints").text() + 1);
        $("#gameResult").text("Win");
    }
    else if (res == -1) {
        $("#enemyPoints").text(+$("#enemyPoints").text() + 1);
        $("#gameResult").text("Lose");
    }
    else {
        $("#gameResult").text("Tie");
    }

    $("#playerChoise").attr('class', optRes[selected]);
    $("#enemyChoise").attr('class', optRes[enemySelected]);
}

function restartGame() {
    $("#restartGame").hide();
    $("#iconSelection").show();
}

//function chooseWinner(choice1, choice2) {
//    let dif = choice2 - choice1;
//    if (dif < 0) {
//        dif += options.length;
//    }
//    while (dif > 2) {
//        dif -= 2;
//    }
//    return results[dif];
//};

function chooseWinner(choice1, choice2) {
    var index1 = options.indexOf(choice1), 
        index2 = options.indexOf(choice2), 
        dif = index2 - index1;
    if (dif < 0) { 
        dif += options.length; 
    }
    while (dif > 2) { 
        dif -= 2; 
    }
    return results[dif];
};