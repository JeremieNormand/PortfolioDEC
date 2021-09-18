420-1B5-LL - Programmation Objet > Laboratoire 2

# Projet ABC - Algo

## Quoi faire?

Avec un Windows From, creer une interface ou il y aura deux entrees numeriques, deux boutons et deux sorties, une numerique et l'autre chaine. Les bouton seront nommes Calculer et Sommation et serviront respectivement a faire la somme des deux entrees et a faire la sommation des nombres compris entre les deux entree. Les deux boutons font en realite un peu plus que juste cela, plus de detail suit.

### Bouton Calculer

Le bouton calculer prend deux nombres reels comme entree, puis converti par casting les nombres en entier pour finalement les additionner et afficher le resultat dans la sortie. Si le resultat est negatif, afficher dans la deuxieme sortie "deshonneur", "succes" si au moins 60 et "echec" pour tout autre cas.

### Bouton Sommation

Les entrees sont caster de reel a entier. La sortie principale es le resultat de la somme de tout les nombre compris entre les deux entrees inclus. Si les deux entrees sont identiques, la sortie est egal a la premiere entree. La sortie secondaire sert a indiquer le signe de la sortie, somme negative, neutre ou positive.

## Algorithmes

```
Calculer()

	# Initialisation des variables

	reel EntreeA
	reel EntreeB

	bool SontValide : VRAI

	entier SortieC
	chaine Message


	# Lecture et validation des entrees

	SontValide : reel.EssaiDeConvertir(txtEntreeA.Texte, EnvoyerDans EntreeA)
	SontValide : SontValide ? reel.EssaiDeConvertir(txtEntreeB.Texte, EnvoyerDans EntreeB) : SontValide
	
	Si !SontValide
		Renvoyer


	# Addition et Determination du message

	SortieC : (entier)EntreeA + (entier)EntreeB

	Si SortieC < 0
		Message : 'Deshonneur'
	SinonSi SortieC < 60
		Message : 'Echec'
	Sinon
		Message : 'Succes'


	# Ecriture des sorties

	txtSortieC.Texte : SortieC.VersChaine()
	txtMessage.Texte : Message



Sommation()

	# Initialisation des variables

	reel EntreeA
	reel EntreeB

	bool SontValide : VRAI

	entier Pas

	entier SortieC : 0
	chaine Message


	# Lecture et Validation des entrees

	SontValide : reel.EssaiDeConvertir(txtEntreeA.Texte, EnvoyerDans EntreeA)
	SontValide : SontValide ? reel.EssaiDeConvertir(txtEntreeB.Texte, EnvoyerDans EntreeB) : SontValide
	
	Si !SontValide
		Renvoyer


	# Sommation des nombres et Determination du message

	Pas : EntreeA > EntreeB ? -1 : 1
	Pour entier NombreCourant : (entier)EntreeA Jusqua (entier)EntreeB AvecSautDe Pas
		SortieC += NombreCourant

	Si SortieC < 0
		Message : 'Sommation negative'
	SinonSi SortieC > 0
		Message : 'Sommation positive'
	Sinon
		Message : 'Sommation neutre'


	# Ecriture des sorties

	txtSortieC.Texte : SortieC.VersChaine()
	txtMessage.Texte : Message
```

## Signature

1334718 - Jeremie Normand