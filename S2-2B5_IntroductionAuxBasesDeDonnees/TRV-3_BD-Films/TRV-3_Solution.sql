----------------------------------------------------------------
-- TP3 - Utilisation de la commande Join
-- Introduction aux bases de donnees
-- Jeremie Normand
----------------------------------------------------------------

-------- Partie No. 1

---- Question No. 1

-- Altere le format de date de la session

ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD';

-- Reinitialise la base de donnees

DROP TABLE emprunts;
DROP TABLE clients;
DROP TABLE films;

DROP SEQUENCE seq_clients_client_code;
DROP SEQUENCE seq_films_film_code;

-- Declare les tables

CREATE TABLE clients
(
    client_code         NUMBER(8),
    client_prenom       VARCHAR2(32),
    client_nom          VARCHAR2(32),
    client_rue          VARCHAR2(128),
    client_ville        VARCHAR2(32),
    client_code_postal  NUMBER(5),
    CONSTRAINT pk_clients_client_code PRIMARY KEY (client_code)
);

CREATE TABLE films
(
    film_code   NUMBER(8),
    film_titre  VARCHAR2(256),
    CONSTRAINT pk_films_film_code PRIMARY KEY (film_code)
);

CREATE TABLE emprunts
(
    client_code         NUMBER(8),
    film_code           NUMBER(8),
    emprunt_date_debut  DATE,
    emprunt_duree       NUMBER(3),
    CONSTRAINT pk_emprunts_client_code_film_code PRIMARY KEY (client_code, film_code),
    CONSTRAINT fk_emprunts_client_code FOREIGN KEY (client_code) REFERENCES clients(client_code),
    CONSTRAINT fk_emprunts_film_code FOREIGN KEY (film_code) REFERENCES films(film_code)
);

-- Declare les sequences

CREATE SEQUENCE seq_clients_client_code
	MINVALUE        1
	MAXVALUE        99999999
	START WITH      1
	INCREMENT BY    1
;

CREATE SEQUENCE seq_films_film_code
	MINVALUE        1
	MAXVALUE        99999999
	START WITH      1
	INCREMENT BY    1
;

-- Initialise les tables

INSERT INTO clients VALUES (seq_clients_client_code.NEXTVAL, 'Alberto', 'Dubois', '3 rue du Pont', 'Saint-Avold', 57500);
INSERT INTO clients VALUES (seq_clients_client_code.NEXTVAL, 'Mi', 'Volond', '4 rue de la Liberte', 'Saint-Avold', 57500);
INSERT INTO clients VALUES (seq_clients_client_code.NEXTVAL, 'Roger', 'Botas', '5 place du Marche', 'Saint-Avold', 57500);
INSERT INTO clients VALUES (seq_clients_client_code.NEXTVAL, 'Edouard', 'Noulas', '41 rue de l''Eglise', 'Forbach', 57600);
INSERT INTO clients VALUES (seq_clients_client_code.NEXTVAL, 'Paul', 'Lontague', '21 boulevard des Oiseaux', 'Freyming', 57800);
INSERT INTO clients VALUES (seq_clients_client_code.NEXTVAL, 'Eric', 'Pondier', '14 rue des Agates', 'Forbach', 57600);
INSERT INTO clients VALUES (seq_clients_client_code.NEXTVAL, 'Thomas', 'Malon', '12 rue des Lapins', 'Forbach', 57600);
INSERT INTO clients VALUES (seq_clients_client_code.NEXTVAL, 'Renato', 'Point', '451 rue de l''Egalite', 'Saint-Avold', 57500);
INSERT INTO clients VALUES (seq_clients_client_code.NEXTVAL, 'Michel', 'Botas', '17 rue des Hochets', 'Saint-Avold', 57500);
INSERT INTO clients VALUES (seq_clients_client_code.NEXTVAL, 'David', 'Collague', '14 rue Utrillo', 'Forbach', 57600);
INSERT INTO clients VALUES (seq_clients_client_code.NEXTVAL, 'Simon', 'Potillon', '17 rue des Marguerittes', 'Freyming', 57800);

INSERT INTO films VALUES (seq_films_film_code.NEXTVAL, 'C''est arrive pres de chez vous');
INSERT INTO films VALUES (seq_films_film_code.NEXTVAL, 'Bernie');
INSERT INTO films VALUES (seq_films_film_code.NEXTVAL, 'Dans la peau de John Malkovitch');
INSERT INTO films VALUES (seq_films_film_code.NEXTVAL, 'Intouchables');
INSERT INTO films VALUES (seq_films_film_code.NEXTVAL, 'Ong Bak');
INSERT INTO films VALUES (seq_films_film_code.NEXTVAL, 'Shoot'' Em UP');
INSERT INTO films VALUES (seq_films_film_code.NEXTVAL, 'Tigres et dragons');
INSERT INTO films VALUES (seq_films_film_code.NEXTVAL, 'Matrix 1');
INSERT INTO films VALUES (seq_films_film_code.NEXTVAL, 'Machete');
INSERT INTO films VALUES (seq_films_film_code.NEXTVAL, 'Boulevard de la mort');
INSERT INTO films VALUES (seq_films_film_code.NEXTVAL, 'Brain dead');

INSERT INTO emprunts VALUES (1, 2, CAST('2013-04-11' AS DATE), 1);
INSERT INTO emprunts VALUES (1, 4, CAST('2013-04-12' AS DATE), 3);
INSERT INTO emprunts VALUES (1, 5, CAST('2013-04-13' AS DATE), 3);
INSERT INTO emprunts VALUES (2, 1, CAST('2013-04-09' AS DATE), 2);
INSERT INTO emprunts VALUES (3, 2, CAST('2013-04-15' AS DATE), 5);
INSERT INTO emprunts VALUES (4, 1, CAST('2013-04-17' AS DATE), 1);
INSERT INTO emprunts VALUES (4, 6, CAST('2013-04-21' AS DATE), 2);
INSERT INTO emprunts VALUES (5, 2, CAST('2013-04-25' AS DATE), 3);
INSERT INTO emprunts VALUES (6, 8, CAST('2013-05-01' AS DATE), 2);
INSERT INTO emprunts VALUES (7, 7, CAST('2013-04-09' AS DATE), 1);
INSERT INTO emprunts VALUES (7, 9, CAST('2012-12-31' AS DATE), 4);

-------- Partie No. 2

---- Question No. 2

SELECT films.film_titre, emprunts.emprunt_date_debut
FROM films
INNER JOIN emprunts ON films.film_code=emprunts.film_code
ORDER BY films.film_titre, emprunts.emprunt_date_debut;

---- Question No. 3

SELECT clients.client_code, clients.client_ville, emprunts.film_code
FROM clients
LEFT JOIN emprunts ON emprunts.client_code=clients.client_code
ORDER BY clients.client_ville, clients.client_code;

---- Question No. 4

SELECT clients.client_nom, emprunts.film_code, emprunts.emprunt_date_debut
FROM clients
INNER JOIN emprunts ON clients.client_code=emprunts.client_code
ORDER BY clients.client_nom;

---- Question No. 5

SELECT clients.client_nom, films.film_titre, emprunts.emprunt_date_debut
FROM emprunts
INNER JOIN films ON films.film_code=emprunts.film_code
INNER JOIN clients ON clients.client_code=emprunts.client_code
ORDER BY clients.client_nom, films.film_titre;

---- Question No. 6

SELECT clients.client_nom, films.film_titre, emprunts.emprunt_duree
FROM clients
LEFT JOIN emprunts ON clients.client_code=emprunts.client_code
LEFT JOIN films ON films.film_code=emprunts.film_code
ORDER BY clients.client_nom, films.film_titre;

---- Question No. 7

SELECT clients.client_nom, emprunts.film_code, emprunts.emprunt_duree
FROM emprunts
INNER JOIN clients ON clients.client_code=emprunts.client_code
ORDER BY clients.client_nom;

---- Question No. 8

SELECT films.film_titre, emprunts.emprunt_duree
FROM films
LEFT JOIN emprunts ON films.film_code=emprunts.film_code
ORDER BY films.film_titre;

---- Question No. 9

SELECT films.film_titre, emprunts.emprunt_duree, emprunts.emprunt_date_debut
FROM emprunts
INNER JOIN films ON films.film_code=emprunts.film_code
LEFT JOIN clients ON clients.client_code=emprunts.client_code
ORDER BY clients.client_nom;

---- Question No. 10

SELECT films.film_titre, emprunts.emprunt_duree
FROM emprunts
INNER JOIN films ON films.film_code=emprunts.film_code;

---- Question No. 11

SELECT clients.client_nom, films.film_titre, emprunts.emprunt_duree
FROM clients
LEFT JOIN emprunts ON clients.client_code=emprunts.client_code
INNER JOIN films ON films.film_code=emprunts.film_code
ORDER BY clients.client_nom, films.film_titre;

---- Question No. 12

SELECT clients.client_nom, films.film_titre, emprunts.emprunt_duree
FROM emprunts
INNER JOIN films ON films.film_code=emprunts.film_code
RIGHT JOIN clients ON clients.client_code=emprunts.client_code
ORDER BY clients.client_nom, films.film_titre;