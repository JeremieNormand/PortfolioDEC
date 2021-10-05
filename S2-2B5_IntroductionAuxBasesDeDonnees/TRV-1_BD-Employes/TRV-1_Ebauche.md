# Travail 1

Introduction aux bases de donnees

Jeremie Normand

---

```
ALTER SESSION SET NLS_DATE_FORMAT  = 'YYYY-MM-DD'
```

## Numero 1 : Creer la table employe.
```
DROP TABLE employe
CREATE TABLE employe
(
	emp_no NUMBER(4),
	emp_nom VARCHAR2(15),
	job VARCHAR2(15),
	superviseur NUMBER(4),
	date_embauche DATE,
	salaire NUMBER(8,2),
	commission NUMBER(6,2),
	dep_no CHAR(3)
);
```

## Numero 2 : Ajouter le champ codepostal de 6 caracteres de long.
```
ALTER TABLE employe ADD code_postal CHAR(6);
```

## Numero 3 : Modifier le champ empnom a 50 de long.
```
ALTER TABLE employe MODIFY emp_nom VARCHAR2(50);
```

## Numero 4 : Renommer le champ dateembauche par embauche.
```
ALTER TABLE employe RENAME COLUMN date_embauche TO embauche;
```

## Numero 5 : Afficher la structure de la table employe.
```
DESCRIBE employe
```

## Numero 6 : Effacer le champ commission.
```
ALTER TABLE employe DROP COLUMN commission;
```

## Numero 7 : Renommer la table employe par employes.
```
ALTER TABLE employe RENAME TO employes;
```

## Numero 8 : Ajouter les champs empprenom avec 50 de long et le champ ville de 30 de long, a partir de la meme commande.
```
ALTER TABLE employes ADD (emp_prenom VARCHAR2(50), ville VARCHAR2(30));
```

## Numero 9 : Afficher la structure de la table employes.
```
DESCRIBE employes
```

## Numero 10 : Ajouter les 3 employes suivants a la table avec les donnees fournies.
```
INSERT INTO employes VALUES (7893, 'King', 'President', NULL, '2013-01-21', 286574.55, 'OPE', 'G6SJ8R', 'James', 'Levis');
INSERT INTO employes VALUES (7566, 'Jones', 'Manager', 1893, '2014-01-25', 123456.00, 'CPT', 'G6D9K9', 'Bob', 'Quebec');
INSERT INTO employes VALUES (7902, 'Ford', 'Analyste', 7566, '2014-08-24', 75259.85, 'CPT', 'G6D8F9', 'Tom', 'Levis');
```

## Numero 11 : Afficher a l'ecran tout le contenu de la table.
```
SELECT * FROM employes;
```

## Numero 12 : Ajouter un nouveau contact a votre table.
```
INSERT INTO employes (emp_no, emp_nom, job, salaire) VALUES (7845, 'Chabot', 'Programmeur', 65699.00);
```

## Numero 13 : Ajouter l'employe suivant.
```
INSERT INTO employes VALUES (7902, 'Ford', 'Vendeur', 7566, '2021-02-15', 75000.00, 'VTE', 'G6D6G6', 'Tom', 'Levis');
```

## Numero 14 : Mettre a jour le numero d'employe du dernier ajout pour lui donner un numero unique.
```
UPDATE employes SET emp_no=7707 WHERE job='Vendeur';
```

## Numero 15 : Mettre a jour l'employe Chabot dont le numero est 7845, afin d'ajouter son superviseur (7902) et son departement (INF).
```
UPDATE employes SET superviseur=7902, dep_no='INF' WHERE emp_no=7845;
```

## Numero 16 : Ajouter deux nouveaux employes.
```
INSERT INTO employes (emp_no, emp_nom, job, superviseur, embauche, dep_no, code_postal, emp_prenom, ville) VALUES (7369, 'Smith', 'Secretaire', 7902, '2015-10-03', 'OPE', NULL, 'Julia', NULL);
INSERT INTO employes (emp_no, emp_nom, job, superviseur, embauche, dep_no, code_postal, emp_prenom, ville) VALUES (7698, 'Blake', 'Manager', 7893, '2021-02-15', 'INF', NULL, 'Tom', NULL);
```

## Numero 17 : Afficher tout le contenu de la table.
```
SELECT * FROM employes;
```

## Numero 18 : Afficher seulement le numero, le nom et le prenom des employes.
```
SELECT emp_no, emp_nom, emp_prenom FROM employes;
```

## Numero 19 : Afficher, dans cet ordre, le numero, le nom, le prenom, le superviseur de chaque employe.
```
SELECT emp_no, emp_nom, emp_prenom, superviseur FROM employes;
```

## Numero 20 : Afficher le nom en majuscules, le prenom et la date d'embauche sous le format (lundi 21 janvier), pour tous les employes.
```
SELECT UPPER(emp_nom), emp_prenom, embauche FROM employes;
```

## Numero 21 : Afficher le numero, nom, prenom, et le nombre de mois entre la date d'embauche et aujourd'hui pour tous les employes.
```
SELECT emp_no, emp_nom, emp_prenom, '2021-02-15' - embauche FROM employes;
```

## Numero 22 : Afficher le nombre d'employes contenus dans la table.
```
SELECT emp_no.COUNT FROM employes;
```

## Numero 23 : Afficher la somme de tous les salaires que la compagnie doit payer.
```
SELECT salaire.SUM FROM employes;
```

## Numero 24 : Afficher la chaine d'embauche dans le format suivant : 'Prenom Nom a ete embauche un lundi'.
```

```

## Numero 25 : Afficher le plus gros et le plus petit salaire de l'entreprise.
```
SELECT MIN(salaire) FROM employes;
SELECT MAX(salaire) FROM employes;
```

## Numero 26 : Afficher la liste des superviseurs distincts.
```
SELECT DISTINCT 
```