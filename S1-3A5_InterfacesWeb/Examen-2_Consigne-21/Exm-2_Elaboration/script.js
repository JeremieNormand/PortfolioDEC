function CalculerHypothenuse(longueur_cote_adjacent, longueur_cote_oppose) {
	var longueur_hypotenuse = Math.sqrt(Math.pow(longueur_cote_adjacent, 2) + Math.pow(longueur_cote_oppose, 2));
	return longueur_hypotenuse;
}

console.log(CalculerHypothenuse(3, 4));