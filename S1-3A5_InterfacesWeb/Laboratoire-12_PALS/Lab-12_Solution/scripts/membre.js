const formulaire = document.querySelector('form');

function generer_numero_de_membre() {
	formulaire.getElementById('numero-de-membre').value = Math.round(999 * Math.random());
}