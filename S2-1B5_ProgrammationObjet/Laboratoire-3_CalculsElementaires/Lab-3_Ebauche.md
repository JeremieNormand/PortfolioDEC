Programmation Objet / Travail 1 > Algo

# Types et Calculs Elementaires

Concevoir une application qui effectue differents calculs avec deux nombres entiers tout en informant l'usager avec des commentaires.

## Algorithmes

```
EvaluerExpressionMathematique1()

	### (A+B) / (A-B)

	# Initialisation des variables

	entier EntreeA, EntreeB
	decimal SortieC

	# Lecture et Validation des entrees

	Si !entier.EssayerDeParser(txtEntreeA, out EntreeA)
		BoiteDeDialogue.Montrer("L'entree 'A' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer
	Si !entier.EssayerDeParser(txtEntreeB, out EntreeB)
		BoiteDeDialogue.Montrer("L'entree 'B' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer

	# Validation de la fesabilite du calcul mathematique

	Si EntreeA - EntreeB == 0
		BoiteDeDialogue.Montrer("Il est impossible de faire une division par zero.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Div. par zero"
		Terminer

	# Evaluation de l'expression avec les entrees A et B tous deux valides
	
	SortieC = (decimal)(A + B) / (A - B)

	# Affichage des sorties

	txtSortieC.Texte = SortieC.VersChaine()
	lblCommentaire.Texte = "Ok"


EvaluerExpressionMathematique2()

	### (A^2 + 2*B^3) / (2*(A+B))

	# Initialisation des variables

	entier EntreeA, EntreeB
	decimal SortieC

	# Lecture et Validation des entrees

	Si !entier.EssayerDeParser(txtEntreeA, out EntreeA)
		BoiteDeDialogue.Montrer("L'entree 'A' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer
	Si !entier.EssayerDeParser(txtEntreeB, out EntreeB)
		BoiteDeDialogue.Montrer("L'entree 'B' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer

	# Validation de la fesabilite du calcul mathematique

	Si EntreeA + EntreeB == 0
		BoiteDeDialogue.Montrer("Il est impossible de faire une division par zero.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Div. par zero"
		Terminer

	# Evaluation de l'expression avec les entrees A et B tous deux valides
	
	SortieC = (Math.Pow(EntreeA, 2) + 2.0m * Math.Pow(EntreeB, 3)) / (2.0m * (EntreeA + EntreeB))

	# Affichage des sorties

	txtSortieC.Texte = SortieC.VersChaine()
	lblCommentaire.Texte = "Ok"


EvaluerExpressionMathematique3()

	### 2*A*B + (A+B) / (2*(A-B)) + A^2 * B^3 * (A+B)^-23

	# Initialisation des variables

	entier EntreeA, EntreeB
	decimal SortieC

	# Lecture et Validation des entrees

	Si !entier.EssayerDeParser(txtEntreeA, out EntreeA)
		BoiteDeDialogue.Montrer("L'entree 'A' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer
	Si !entier.EssayerDeParser(txtEntreeB, out EntreeB)
		BoiteDeDialogue.Montrer("L'entree 'B' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer

	# Validation de la fesabilite du calcul mathematique

	Si EntreeA - EntreeB == 0 || EntreeA + EntreeB == 0
		BoiteDeDialogue.Montrer("Il est impossible de faire une division par zero.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Div. par zero"
		Terminer

	# Evaluation de l'expression avec les entrees A et B tous deux valides
	
	decimal Argument1 = 2.0m * EntreeA * EntreeB
	decimal Argument2 = (EntreeA + EntreeB) / (2.0m * (EntreeA - EntreeB))
	decimal Argument3 = Math.Pow(EntreeA, 2) * Math.Pow(EntreeB, 3) * Math.Pow(EntreeA + EntreeB, -23)

	SortieC = Argument1 + Argument2 + Argument3

	# Affichage des sorties

	txtSortieC.Texte = SortieC.VersChaine()
	lblCommentaire.Texte = "Ok"


EvaluerExpressionMathematique4()

	### ((A+B) / (A-B))^1/2

	# Initialisation des variables

	entier EntreeA, EntreeB
	decimal SortieC

	# Lecture et Validation des entrees

	Si !entier.EssayerDeParser(txtEntreeA, out EntreeA)
		BoiteDeDialogue.Montrer("L'entree 'A' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer
	Si !entier.EssayerDeParser(txtEntreeB, out EntreeB)
		BoiteDeDialogue.Montrer("L'entree 'B' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer

	# Validation de la fesabilite du calcul mathematique

	Si EntreeA - EntreeB == 0
		BoiteDeDialogue.Montrer("Il est impossible de faire une division par zero.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Div. par zero"
		Terminer
	Si (EntreeA + EntreeB) / (EntreeA - EntreeB) < 0
		BoiteDeDialogue.Montrer("Incapable d'effectuer le radical d'un nombre negatif.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Rad. negatif"
		Terminer

	# Evaluation de l'expression avec les entrees A et B tous deux valides
	
	SortieC = Math.Pow((decimal)(EntreeA + EntreeB) / (EntreeA - EntreeB), 1/2)

	# Affichage des sorties

	txtSortieC.Texte = SortieC.VersChaine()
	lblCommentaire.Texte = "Ok"


EvaluerExpressionMathematique5()

	### ((A^2 - B^2) / (A-B)^2)^1/3

	# Initialisation des variables

	entier EntreeA, EntreeB
	decimal SortieC

	# Lecture et Validation des entrees

	Si !entier.EssayerDeParser(txtEntreeA, out EntreeA)
		BoiteDeDialogue.Montrer("L'entree 'A' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer
	Si !entier.EssayerDeParser(txtEntreeB, out EntreeB)
		BoiteDeDialogue.Montrer("L'entree 'B' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer

	# Validation de la fesabilite du calcul mathematique

	Si EntreeA - EntreeB == 0
		BoiteDeDialogue.Montrer("Il est impossible de faire une division par zero.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Div. par zero"
		Terminer

	# Evaluation de l'expression avec les entrees A et B tous deux valides

	decimal Numerateur = (decimal)Math.Pow(EntreeA, 2) - Math.Pow(EntreeB^2)
	decimal Denominateur = (decimal)Math.Pow(EntreeA - EntreeB, 2)

	SortieC = Math.Pow(Numerateur / Denominateur, 1/3)

	# Affichage des sorties

	txtSortieC.Texte = SortieC.VersChaine()
	lblCommentaire.Texte = "Ok"


EvaluerExpressionMathematique6()

	### (A/15/2 + B/25/2) * 100

	# Initialisation des variables

	entier EntreeA, EntreeB
	decimal SortieC

	# Lecture et Validation des entrees

	Si !entier.EssayerDeParser(txtEntreeA, out EntreeA)
		BoiteDeDialogue.Montrer("L'entree 'A' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer
	Si !entier.EssayerDeParser(txtEntreeB, out EntreeB)
		BoiteDeDialogue.Montrer("L'entree 'B' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer

	# Validation de la fesabilite du calcul mathematique

	Si EntreeA < 0 || EntreeB < 0
		BoiteDeDialogue.Montrer("Il est impossible d'avoir une note inferieur a zero.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Note(s) negative(s)"
		Terminer
	Si EntreeA > 15 || EntreeB > 25
		BoiteDeDialogue.Montrer("Il est impossible d'avoir une note superieur a 15 pour 'A' et 25 pour 'B'.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Note(s) negative(s)"
		Terminer

	# Evaluation de l'expression avec les entrees A et B tous deux valides

	SortieC = (EntreeA / 15 / 2 + EntreeB / 25 / 2) * 100

	# Affichage des sorties

	txtSortieC.Texte = SortieC.VersChaine("0")
	lblCommentaire.Texte = "La note a deux decimales (arrondie) est de " + SortieC.VersChaine("0.00") + "%"


EvaluerExpressionMathematique7()

	### A / (A + B) * 100

	# Initialisation des variables

	entier EntreeA, EntreeB
	decimal SortieC

	# Lecture et Validation des entrees

	Si !entier.EssayerDeParser(txtEntreeA, out EntreeA)
		BoiteDeDialogue.Montrer("L'entree 'A' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer
	Si !entier.EssayerDeParser(txtEntreeB, out EntreeB)
		BoiteDeDialogue.Montrer("L'entree 'B' doit etre un nombre entier.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Ca va pas"
		Terminer

	# Validation de la fesabilite du calcul mathematique

	Si EntreeA + EntreeB == 0
		BoiteDeDialogue.Montrer("Il est impossible de faire une division par zero.")
		txtSortieC.Texte = ""
		lblCommentaire.Texte = "Div. par zero"
		Terminer

	# Evaluation de l'expression avec les entrees A et B tous deux valides

	SortieC = (decimal)EntreeA / (EntreeA + EntreeB) * 100

	# Affichage des sorties

	txtSortieC.Texte = SortieC.VersChaine()
	lblCommentaire.Texte = "Le pourcentage de filles a deux decimales (arrondie) est de " + (100 - SortieC).VersChaine("0.00") + "%"
```