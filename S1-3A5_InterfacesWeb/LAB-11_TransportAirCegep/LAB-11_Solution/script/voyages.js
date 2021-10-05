// Initialiser le gradateur au chargement de la page et sur le bouton Reset
function initRange() {
	document.getElementById("valeurPoids").innerHTML = 0;
}

// Afficher la valeur de poids à côté du gradateur
function affichePoids(gradateur) {
	document.getElementById("valeurPoids").innerHTML = gradateur.value;
}

// Validations et traitement du formulaire
function emettreBillet(formulaire) {
	// Effacement des avertissement
	effacerMessage();

	// Validations
	if (formulaire.nom.value == "") {
		afficherMessage("Le nom est obligatoire");
		return;
	}
	if (formulaire.sexe.value != "M" && formulaire.sexe.value != "F") {
		afficherMessage("Un sexe doit être choisi");
		return;
	}
	if (formulaire.voyageurs.value != "S" && formulaire.voyageurs.value != "C" && formulaire.voyageurs.value != "F") {
		afficherMessage("Le nombre de voyageurs doit être déterminé");
		return;
	}
	if (formulaire.destination.value != "M" && formulaire.destination.value != "T" && formulaire.destination.value != "V") {
		afficherMessage("Une destination doit être choisi");
		return;
	}

	// Calculation du cout des bagages et du voyage
	let coutBillet = 0;

	let trajet = "De Québec vers ";
	if (formulaire.destination.value == "M") {
		coutBillet += 100;
		trajet += "Montréal";
	}
	else if (formulaire.destination.value == "T") {
		coutBillet += 200;
		trajet += "Toronto";
	}
	else {
		coutBillet += 400;
		trajet += "Vancouver";
	}

	if (formulaire.voyageurs.value == "S" || formulaire.voyageurs.value == "C") {
		coutBillet = formulaire.voyageurs.value == "C" ? coutBillet * 2 : coutBillet;
	}
	else {
		coutBillet *= 3;
	}

	let coutBagages = calculerCoutBagage(formulaire.voyageurs.value, formulaire.poids.value);

	let formulePolitesse;
	if (formulaire.sexe.value == "M") {
		formulePolitesse = "M.";
	}
	else {
		formulePolitesse = "Mme";
	}

	afficherBillet(formulePolitesse, formulaire.nom.value, trajet, coutBillet, coutBagages);
	document.getElementById("billet").style.display = "block";
}

// Afficher les messages avertissements
function afficherMessage(message) {
	document.getElementById("info_output").innerHTML = message;
	document.getElementById("alerte").style.display = "block";
}

// Effacer les messages et le contenu du billet
function effacerMessage() {
	document.getElementById("info_output").innerHTML = "";
	document.getElementById("alerte").style.display = "none";
	document.getElementById("billet_output").innerHTML = "";
}

// Calculer le cout des bagages
function calculerCoutBagage(voyageurs, poids) {
	let coutBagages;

	if (voyageurs == "F") {
		coutBagages = poids > 50 ? (poids - 50) * .75 : 0;
	}
	else {
		coutBagages = poids > 25 ? (poids - 25) * .75 + 25 * .5 : poids * .5;
	}

	return coutBagages;
}

// Afficher le billet
function afficherBillet(formulePolitesse, nomComplet, trajet, coutBillet, coutBagages) {
	let titreNom = document.createElement("h1");
	titreNom.className = "border-bottom";
	titreNom.innerHTML = `${formulePolitesse} ${nomComplet}`;

	let titreTrajet = document.createElement("h4");
	titreTrajet.innerHTML = trajet;

	let coutDeBase = document.createElement("p");
	coutDeBase.innerHTML = `Coût de base : $ ${coutBillet}`;

	let bagages = document.createElement("p");
	bagages.innerHTML = `Coût des bagages : $ ${coutBagages}`;

	let titreCoutTotal = document.createElement("h3");
	titreCoutTotal.className = "text-right border";
	titreCoutTotal.innerHTML = `Total : $ ${coutBillet + coutBagages}`;

	document.getElementById("billet_output").append(titreNom, titreTrajet, coutDeBase, bagages, titreCoutTotal);
}

function cacherBillet() {
	document.getElementById("billet").style.display = "none";
}