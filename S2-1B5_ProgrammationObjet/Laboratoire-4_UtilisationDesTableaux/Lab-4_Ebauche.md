# Laboratoire 04 - Tableaux et Methodes

Programmation Objet

Jeremie Normand

---

## Algo

```
# Afficher les vendeurs
btnVendeurs_Click()

	# Initialisations
	string Affichage = "Nos redoutables vendeurs:\r-----------------------------------";

	# Parcours du tableau des vendeurs pour tous les afficher
	PourChaque string vendeur Dans m_tVendeurs Faire
		Affichage += "\n" + vendeur

	# Affichage
	MessageBox.Show(Affichage)
```

```
# Afficher les ventes par vendeurs
btnVentesParVendeurs_Click()

	# Initialisations
	string Affichage = "Ventes trimestrielles par vendeur:\r---------------------------------------------";

	# Parcours du tableau des vendeurs et de tableau des ventes trimestrielles
	Pour int vendeur = 0 TantQue vendeur < m_tVendeurs.Capacite FaireEnsuite ++vendeur
		Affichage += "\n" + m_tVendeurs[vendeur]
		Pour int trimestre = 0 TantQue trimestre < m_tVentesTrim[vendeur].Capacite FaireEnsuite ++trimestre
			Affichage += "\t" + m_tVentesTrim[vendeur, trimestre].VersChaine("Currency")

	# Affichage
	MessageBox.Show(Affichage)
``` 

```
# Afficher les ventes totales par trimestre
btnAfficheTotalParTrimestres_Click()

	# Initialisations
	string Affichage = "Ventes totales par trimestre:\r---------------------------------------------";

	# Parcours du tableau des ventes trimestrielles, placer les totaux dans m_tTotalVparTrimestre
	Pour int trimestre = 0 TantQue trimestre < m_tVentesTrim.GetCapacite(1) FaireEnsuite trimestre++
		Affichage += "\n" + $"Trimestre {trimestre}"
		Pour int vendeur = 0 TantQue vendeur < m_tVentesTrim.GetCapacite(0) FaireEnsuite vendeur++
			m_tTotalVparTrimestre[trimestre] += m_tVentesTrim[vendeur, trimestre]
		Affichage += "\t" + m_tTotalVparTrimestre[trimestre].VersChaine("Currency")

	# Affichage
	MessageBox.Show(Affichage)
```

```
# Afficher la vente totale du vendeur selectionne
btnAfficheVenteDuVendeur_Click()

	# Initialisations
	string Affichage = "Ventes totales du vendeur: " + cbVendeurs.SelectedItem + "\r---------------------------------------------\r";
	double totalV = 0
	int vendeur

	# Recherche dans tableau des vendeurs, calculer la somme des ventes du vendeur selectionne
	vendeur = m_tVendeurs.Trouve(cbVendeurs.SelectedItem)
	Pour int trimestre = 0 TantQue trimestre < m_tVentesTrim.GetCapacite(1) FaireEnsuite trimestre++
		totalV += m_tVentesTrim[vendeur, trimestre]
	Affichage += "\n" + totalV.VersChaine("Currency")

	# Affichage
	MessageBox.Show(Affichage)
```