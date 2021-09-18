//@ts-check

function funcExerciceQuatre() {
	let varUn;
	let varDeux = 2;
	let varTrois = "trois";

	window.alert("Variable un : " + typeof (varUn));
	window.alert("Variable deux : " + typeof (varDeux));
	window.alert("Variable trois : " + typeof (varTrois));
}

function exerciceCinqBlockOver() {
	document.getElementById("blockVide").style.backgroundColor = "green";
}

function exerciceCinqBlockOut() {
	document.getElementById("blockVide").style.backgroundColor = "blue";
}

function exerciceSixJumbotron() {
	let divElements;

	divElements = document.getElementsByTagName("div");

	let nbreElements;

	nbreElements = divElements.length;
	console.log(nbreElements);

	for (let i = 0; i < nbreElements; i++) {
		let enfant = document.createElement("p");
		enfant.innerHTML = i + 1;

		divElements[i].appendChild(enfant);
	}

}

function exerciceSeptLumiere() {
	if (document.getElementById("btnBulb").innerHTML == "On") {
		document.getElementById("lampe").src = "../img/bulb_on.png";
		document.getElementById("btnBulb").className = "btn btn-secondary";
		document.getElementById("btnBulb").innerHTML = "Off";
	} else {
		document.getElementById("lampe").src = "../img/bulb_off.png";
		document.getElementById("btnBulb").className = "btn btn-success";
		document.getElementById("btnBulb").innerHTML = "On";
	}
}
